/*
 * Copyright 2020 Huawei Technologies Co.,Ltd.
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core.Auth;
using Microsoft.Extensions.Logging;
using static System.String;

namespace HuaweiCloud.SDK.Core
{
    public class Client
    {
        public class ClientBuilder<T> where T : Client
        {
            private string[] CredentialType { get; } =
            {
                nameof(BasicCredentials)
            };

            public ClientBuilder()
            {
            }

            public ClientBuilder(string credentialType)
            {
                this.CredentialType = credentialType.Split(',');
            }

            private Credentials _credentials;
            private HttpConfig _httpConfig;
            private Region _region;
            private List<string> _endpoints;
            private bool _enableLogging;
            private LogLevel _logLevel = LogLevel.Information;
            private HttpHandler _httpHandler;
            private string _derivedAuthServiceName;

            private const string HttpScheme = "http";
            private const string HttpsScheme = "https";

            public ClientBuilder<T> WithCredential(Credentials credentials)
            {
                this._credentials = credentials;
                return this;
            }

            public ClientBuilder<T> WithHttpConfig(HttpConfig httpConfig)
            {
                this._httpConfig = httpConfig;
                return this;
            }

            public ClientBuilder<T> WithRegion(Region region)
            {
                this._region = region;
                return this;
            }
            
            [Obsolete("As of 3.1.26, because of the support of the multi-endpoint feature, use WithEndPoints instead")]
            public ClientBuilder<T> WithEndPoint(string endpoint)
            {
                return this.WithEndPoints(new List<string>
                {
                    endpoint
                });
            }

            public ClientBuilder<T> WithEndPoints(List<string> endpoints)
            {
                this._endpoints = endpoints;
                return this;
            }

            public ClientBuilder<T> WithLogging(LogLevel logLevel)
            {
                this._enableLogging = true;
                this._logLevel = logLevel;
                return this;
            }

            public ClientBuilder<T> WithHttpHandler(HttpHandler httpHandler)
            {
                this._httpHandler = httpHandler;
                return this;
            }

            public ClientBuilder<T> WithDerivedAuthServiceName(string derivedAuthServiceName)
            {
                this._derivedAuthServiceName = derivedAuthServiceName;
                return this;
            }

            public T Build()
            {
                Client client = Activator.CreateInstance<T>();

                if (this._credentials == null)
                {
                    this._credentials = EnvCredentials.LoadCredentialsFromEnv(CredentialType[0]);
                }

                if (!CredentialType.Contains(this._credentials.GetType().Name))
                {
                    throw new ArgumentException(
                        $"credential type error, support credential type is {Join(",", CredentialType)}");
                }

                client.WithHttpConfig(_httpConfig ?? HttpConfig.GetDefaultConfig())
                    .InitSdkHttpClient(this._httpHandler, this._enableLogging, this._logLevel);

                if (this._region != null)
                {
                    this._endpoints = this._region.Endpoints;
                    this._credentials = _credentials.ProcessAuthParams(client._sdkHttpClient, _region.Id);
                    this._credentials.ProcessDerivedAuthParams(_derivedAuthServiceName, _region.Id);
                }

                for (var i = 0; i < _endpoints.Count; i++)
                {
                    var endpoint = _endpoints[i];
                    if (!endpoint.StartsWith(HttpScheme))
                    {
                        _endpoints[i] = HttpsScheme + "://" + endpoint;
                    }
                }

                client.WithCredential(this._credentials)
                    .WithEndPoints(this._endpoints);

                return (T)client;
            }
        }

        private List<string> _endpoints;
        private volatile int _endpointIndex;
        private HttpConfig _httpConfig;
        private Credentials _credential;

        private SdkHttpClient _sdkHttpClient;

        private const string XRequestAgent = "User-Agent";
        private const string CredentialsNull = "Credentials cannot be null.";

        private Client WithCredential(Credentials credentials)
        {
            this._credential = credentials ?? throw new ArgumentNullException(CredentialsNull);
            return this;
        }

        private Client WithHttpConfig(HttpConfig httpConfig)
        {
            this._httpConfig = httpConfig;
            return this;
        }

        private Client WithEndPoints(List<string> endpoints)
        {
            this._endpoints = endpoints;
            return this;
        }


        private void InitSdkHttpClient(HttpHandler httpHandler, bool enableLogging, LogLevel logLevel)
        {
            this._sdkHttpClient =
                new SdkHttpClient(this.GetType().FullName, _httpConfig, httpHandler, enableLogging, logLevel);
        }

        protected async Task<HttpResponseMessage> DoHttpRequestAsync(string methodType, SdkRequest request)
        {
            var url = GetRealEndpoint(request)
                      + HttpUtils.AddUrlPath(request.Path, _credential.GetPathParamDictionary())
                      + (IsNullOrEmpty(request.QueryParams) ? "" : "?" + request.QueryParams);
            return await _async_http(url, methodType.ToUpper(), request);
        }

        private async Task<HttpResponseMessage> _async_http(string url, string method, SdkRequest sdkRequest)
        {
            var request = GetHttpRequest(url, method, sdkRequest);
            if (IsNullOrEmpty(request.Headers.Get("Authorization")))
            {
                request = await _credential.SignAuthRequest(request);
            }

            var message = this._sdkHttpClient.InitHttpRequest(request, _httpConfig.IgnoreBodyForGetRequest);
            try
            {
                var response = await this._sdkHttpClient.DoHttpRequest(message);
                return GetResult(response);
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        protected HttpResponseMessage DoHttpRequestSync(string methodType, SdkRequest request)
        {
            while (true)
            {
                var url = GetRealEndpoint(request) + HttpUtils.AddUrlPath(request.Path, _credential.GetPathParamDictionary())
                                                   + (IsNullOrEmpty(request.QueryParams) ? "" : "?" + request.QueryParams);
                try
                {
                    return _sync_http(url, methodType.ToUpper(), request);
                }
                catch (HostUnreachableException hostUnreachableException)
                {
                    if (this._endpointIndex < this._endpoints.Count - 1)
                    {
                        Interlocked.Increment(ref _endpointIndex);
                    }
                    else
                    {
                        throw hostUnreachableException;
                    }
                }
            }
        }

        private HttpResponseMessage _sync_http(string url, string method, SdkRequest sdkRequest)
        {
            var request = GetHttpRequest(url, method, sdkRequest);
            if (IsNullOrEmpty(request.Headers.Get("Authorization")))
            {
                request = _credential.SignAuthRequest(request).Result;
            }

            var message = this._sdkHttpClient.InitHttpRequest(request, _httpConfig.IgnoreBodyForGetRequest);
            try
            {
                var response = this._sdkHttpClient.DoHttpRequest(message).Result;
                return GetResult(response);
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }

        private string GetRealEndpoint(SdkRequest request)
        {
            var endpoint = this._endpoints[_endpointIndex];
            if (String.IsNullOrEmpty(request.Cname))
            {
                return endpoint;
            }

            return endpoint.Insert(8, request.Cname + ".");
        }

        private HttpResponseMessage GetResult(HttpResponseMessage responseMessage)
        {
            if ((int)responseMessage.StatusCode < 400)
            {
                return responseMessage;
            }

            throw ExceptionUtils.GetException(responseMessage);
        }

        private HttpRequest GetHttpRequest(string url, string method, SdkRequest sdkRequest)
        {
            var request = new HttpRequest(method.ToUpper(), sdkRequest.ContentType, new Uri(url))
            {
                Body = sdkRequest.Body ?? "",
                FileStream = sdkRequest.FileStream,
                FormData = sdkRequest.FormData
            };

            UpdateHeaders(request, sdkRequest.Header);
            return request;
        }

        private void UpdateHeaders(HttpRequest request, Dictionary<string, string> headers)
        {
            if (headers == null)
            {
                return;
            }

            foreach (var header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            request.Headers.Add(XRequestAgent, "huaweicloud-usdk-net/3.0");
        }
    }
}
