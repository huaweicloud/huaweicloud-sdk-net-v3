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
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core.Auth;
using Microsoft.Extensions.Logging;

namespace HuaweiCloud.SDK.Core
{
    public class Client
    {

        private const string XRequestAgent = "User-Agent";
        private const string CredentialsNull = "Credentials cannot be null.";
        private ICredential _credentials;
        private volatile int _endpointIndex;

        private List<string> _endpoints;
        private HttpConfig _httpConfig;

        private SdkHttpClient _sdkHttpClient;

        private Client WithCredential(ICredential credentials)
        {
            _credentials = credentials ?? throw new ArgumentNullException(CredentialsNull);
            return this;
        }

        private Client WithHttpConfig(HttpConfig httpConfig)
        {
            _httpConfig = httpConfig;
            return this;
        }

        private Client WithEndPoints(List<string> endpoints)
        {
            _endpoints = endpoints;
            return this;
        }


        private void InitSdkHttpClient(HttpHandler httpHandler, bool enableLogging, LogLevel logLevel)
        {
            _sdkHttpClient =
                new SdkHttpClient(GetType().FullName, _httpConfig, httpHandler, enableLogging, logLevel);
        }

        protected async Task<HttpResponseMessage> DoHttpRequestAsync(string methodType, SdkRequest request)
        {
            var url = GetRealEndpoint(request)
                      + HttpUtils.AddUrlPath(request.Path, _credentials.GetPathParamDictionary())
                      + (string.IsNullOrEmpty(request.QueryParams) ? "" : "?" + request.QueryParams);
            return await _async_http(url, methodType.ToUpper(), request);
        }

        private async Task<HttpResponseMessage> _async_http(string url, string method, SdkRequest sdkRequest)
        {
            var request = GetHttpRequest(url, method, sdkRequest);
            if (string.IsNullOrEmpty(request.Headers.Get("Authorization")))
            {
                request = await _credentials.SignAuthRequest(request);
            }

            var message = _sdkHttpClient.InitHttpRequest(request, _httpConfig.IgnoreBodyForGetRequest);
            try
            {
                var response = await _sdkHttpClient.DoHttpRequest(message);
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
                var url = GetRealEndpoint(request) + HttpUtils.AddUrlPath(request.Path, _credentials.GetPathParamDictionary())
                                                   + (string.IsNullOrEmpty(request.QueryParams) ? "" : "?" + request.QueryParams);
                try
                {
                    return _sync_http(url, methodType.ToUpper(), request);
                }
                catch (HostUnreachableException hostUnreachableException)
                {
                    if (_endpointIndex < _endpoints.Count - 1)
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
            if (string.IsNullOrEmpty(request.Headers.Get("Authorization")))
            {
                request = _credentials.SignAuthRequest(request).Result;
            }

            var message = _sdkHttpClient.InitHttpRequest(request, _httpConfig.IgnoreBodyForGetRequest);
            try
            {
                var response = _sdkHttpClient.DoHttpRequest(message).Result;
                return GetResult(response);
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }

        private string GetRealEndpoint(SdkRequest request)
        {
            var endpoint = _endpoints[_endpointIndex];
            if (string.IsNullOrEmpty(request.Cname))
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
                FormData = sdkRequest.FormData,
                SigningAlgorithm = _httpConfig.SigningAlgorithm
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

        public class ClientBuilder<T> where T : Client
        {

            private const string HttpScheme = "http";
            private const string HttpsScheme = "https";

            private ICredential _credentials;
            private string _derivedAuthServiceName;
            private bool _enableLogging;
            private List<string> _endpoints;
            private HttpConfig _httpConfig;
            private HttpHandler _httpHandler;
            private LogLevel _logLevel = LogLevel.Information;
            private Region _region;

            public ClientBuilder()
            {
            }

            public ClientBuilder(string credentialType)
            {
                CredentialType = credentialType.Split(',');
            }

            private string[] CredentialType { get; } =
            {
                nameof(BasicCredentials)
            };

            public ClientBuilder<T> WithCredential(ICredential credentials)
            {
                _credentials = credentials;
                return this;
            }

            public ClientBuilder<T> WithHttpConfig(HttpConfig httpConfig)
            {
                _httpConfig = httpConfig;
                return this;
            }

            public ClientBuilder<T> WithRegion(Region region)
            {
                _region = region;
                return this;
            }

            [Obsolete("As of 3.1.26, because of the support of the multi-endpoint feature, use WithEndPoints instead")]
            public ClientBuilder<T> WithEndPoint(string endpoint)
            {
                return WithEndPoints(new List<string>
                {
                    endpoint
                });
            }

            public ClientBuilder<T> WithEndPoints(List<string> endpoints)
            {
                _endpoints = endpoints;
                return this;
            }

            public ClientBuilder<T> WithLogging(LogLevel logLevel)
            {
                _enableLogging = true;
                _logLevel = logLevel;
                return this;
            }

            public ClientBuilder<T> WithHttpHandler(HttpHandler httpHandler)
            {
                _httpHandler = httpHandler;
                return this;
            }

            public ClientBuilder<T> WithDerivedAuthServiceName(string derivedAuthServiceName)
            {
                _derivedAuthServiceName = derivedAuthServiceName;
                return this;
            }

            public T Build()
            {
                Client client = Activator.CreateInstance<T>();

                if (_credentials == null)
                {
                    _credentials = CredentialProviderChain.GetDefault(CredentialType[0]).GetCredentials();
                }

                if (!CredentialType.Contains(_credentials.GetType().Name))
                {
                    throw new ArgumentException(
                        $"credential type error, support credential type is {string.Join(",", CredentialType)}");
                }

                client.WithHttpConfig(_httpConfig ?? HttpConfig.GetDefaultConfig())
                    .InitSdkHttpClient(_httpHandler, _enableLogging, _logLevel);

                if (_region != null)
                {
                    _endpoints = _region.Endpoints;
                    _credentials = _credentials.ProcessAuthParams(client._sdkHttpClient, _region.Id);
                    _credentials.ProcessDerivedAuthParams(_derivedAuthServiceName, _region.Id);
                }

                for (var i = 0; i < _endpoints.Count; i++)
                {
                    var endpoint = _endpoints[i];
                    if (!endpoint.StartsWith(HttpScheme))
                    {
                        _endpoints[i] = HttpsScheme + "://" + endpoint;
                    }
                }

                client.WithCredential(_credentials)
                    .WithEndPoints(_endpoints);

                return (T)client;
            }
        }
    }
}
