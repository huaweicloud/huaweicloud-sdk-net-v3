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
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core.Auth;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.String;

namespace HuaweiCloud.SDK.Core
{
    public class Client
    {
        public class ClientBuilder<T> where T : Client
        {
            private string[] CredentialType { get; } = {nameof(BasicCredentials)};

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
            private string _endPoint;
            private bool _enableLogging;
            private LogLevel _logLevel = LogLevel.Information;
            private HttpHandler _httpHandler;

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

            public ClientBuilder<T> WithEndPoint(string endPoint)
            {
                this._endPoint = endPoint;
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

            public T Build()
            {
                Client client = Activator.CreateInstance<T>();

                if (this._credentials == null)
                {
                    this._credentials = Credentials.GetCredentialFromEnvironment<T>(CredentialType[0]);
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
                    this._endPoint = _region.Endpoint;
                    this._credentials = _credentials.ProcessAuthParams(client._sdkHttpClient, _region.Id);
                }


                client.WithCredential(this._credentials)
                    .WithEndPoint(this._endPoint);

                return (T) client;
            }
        }

        private string _endpoint;
        private HttpConfig _httpConfig;
        private Credentials _credential;

        private SdkHttpClient _sdkHttpClient;

        private const string XRequestId = "X-Request-Id";
        private const string XRequestAgent = "User-Agent";
        private const string CredentialsNull = "Credentials cannot be null.";

        private Client WithCredential(Credentials credentials)
        {
            this._credential = credentials ?? throw new ArgumentNullException(CredentialsNull);
            this._httpConfig = HttpConfig.GetDefaultConfig();
            return this;
        }

        private Client WithHttpConfig(HttpConfig httpConfig)
        {
            this._httpConfig = httpConfig;
            return this;
        }

        private Client WithEndPoint(string endPoint)
        {
            this._endpoint = endPoint;
            return this;
        }

        private void InitSdkHttpClient(HttpHandler httpHandler, bool enableLogging, LogLevel logLevel)
        {
            this._sdkHttpClient =
                new SdkHttpClient(this.GetType().FullName, _httpConfig, httpHandler, enableLogging, logLevel);
        }

        protected async Task<HttpResponseMessage> DoHttpRequestAsync(string methodType, SdkRequest request)
        {
            var url = _endpoint
                      + HttpUtils.AddUrlPath(request.Path, _credential.GetPathParamDictionary())
                      + (IsNullOrEmpty(request.QueryParams) ? "" : "?" + request.QueryParams);
            return await _async_http(url, methodType.ToUpper(), request);
        }

        private async Task<HttpResponseMessage> _async_http(string url, string method, SdkRequest sdkRequest)
        {
            var request = GetHttpRequest(url, method, sdkRequest);
            request = await _credential.SignAuthRequest(request);

            var message = this._sdkHttpClient.InitHttpRequest(request);
            try
            {
                var response = await this._sdkHttpClient.DoHttpRequest(message);
                return GetResult(response);
            }
            catch (AggregateException aggregateException)
            {
                throw new ConnectionException(aggregateException.Message);
            }
        }

        protected HttpResponseMessage DoHttpRequestSync(string methodType, SdkRequest request)
        {
            var url = _endpoint
                      + HttpUtils.AddUrlPath(request.Path, _credential.GetPathParamDictionary())
                      + (IsNullOrEmpty(request.QueryParams) ? "" : "?" + request.QueryParams);
            return _sync_http(url, methodType.ToUpper(), request);
        }

        private HttpResponseMessage _sync_http(string url, string method, SdkRequest sdkRequest)
        {
            var request = GetHttpRequest(url, method, sdkRequest);
            request = _credential.SignAuthRequest(request).Result;

            var message = this._sdkHttpClient.InitHttpRequest(request);
            try
            {
                var response = this._sdkHttpClient.DoHttpRequest(message).Result;
                return GetResult(response);
            }
            catch (AggregateException aggregateException)
            {
                throw new ConnectionException(aggregateException.Message);
            }
        }

        private HttpResponseMessage GetResult(HttpResponseMessage responseMessage)
        {
            if ((int) responseMessage.StatusCode < 400)
            {
                return responseMessage;
            }

            var result = new SdkResponse
            {
                HttpStatusCode = (int) responseMessage.StatusCode,
                HttpHeaders = responseMessage.Headers.ToString(),
                HttpBody = responseMessage.Content.ReadAsStringAsync().Result
            };

            var requestId = "";
            if (responseMessage.Headers.Contains(XRequestId))
            {
                requestId = responseMessage.Headers.GetValues(XRequestId).FirstOrDefault();
            }

            SdkError sdkError;
            try
            {
                sdkError = GetSdkErrorFromResponse(requestId, result);
            }
            catch (Exception exception)
            {
                throw new ServerResponseException(result.HttpStatusCode,
                    new SdkError {ErrorMsg = exception.Message});
            }

            if (result.HttpStatusCode >= 400 && result.HttpStatusCode < 500)
            {
                throw new ClientRequestException(result.HttpStatusCode, sdkError);
            }

            throw new ServerResponseException(result.HttpStatusCode, sdkError);
        }

        protected virtual SdkError HandleServiceSpecException(SdkResponse response)
        {
            return new SdkError();
        }

        private SdkError HandleServiceCommonException(SdkResponse response)
        {
            var exception = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.HttpBody);
            if (exception.ContainsKey("code") && exception.ContainsKey("message"))
            {
                return new SdkError(exception["code"].ToString(), exception["message"].ToString());
            }

            foreach (var item in exception)
            {
                var jValue = JObject.Parse(item.Value.ToString());
                var message = jValue["message"];
                var code = jValue["code"];
                if (message != null && code != null)
                {
                    return new SdkError(code.ToString(), message.ToString());
                }
            }

            return new SdkError(response.HttpBody);
        }

        private SdkError GetSdkErrorFromResponse(string requestId, SdkResponse response)
        {
            SdkError sdkError;
            try
            {
                sdkError = JsonUtils.DeSerialize<SdkError>(response);
                if (IsNullOrEmpty(sdkError.ErrorCode) || IsNullOrEmpty(sdkError.ErrorMsg))
                {
                    sdkError = HandleServiceCommonException(response);
                }
            }
            catch (Exception)
            {
                sdkError = new SdkError();
            }

            if (IsNullOrEmpty(sdkError.ErrorMsg))
            {
                sdkError = HandleServiceSpecException(response);
            }

            if (IsNullOrEmpty(sdkError.RequestId))
            {
                sdkError.RequestId = requestId;
            }

            return sdkError;
        }

        private HttpRequest GetHttpRequest(string url, string method, SdkRequest sdkRequest)
        {
            var request = new HttpRequest(method.ToUpper(), sdkRequest.ContentType, new Uri(url))
            {
                Body = sdkRequest.Body ?? "",
                FileStream = sdkRequest.FileStream
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