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
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HuaweiCloud.SDK.Core
{
    public class RetryHandler : DelegatingHandler
    {
        private const int MaxRetries = 1;

        public RetryHandler(HttpMessageHandler innerHandler) : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (var i = 0; i < MaxRetries; i++)
            {
                response = await base.SendAsync(request, cancellationToken);
                if (response.IsSuccessStatusCode) {
                    return response;
                }
            }
            return response;
        }
    }
    
    public class SdkHttpClient
    {
        private static HttpClient _httpClient;

        public SdkHttpClient(HttpConfig config)
        {
            if (_httpClient != null)
            {
                return;
            }
            var handler = new HttpClientHandler
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) => 
                        config.IgnoreSslVerification || policyErrors == SslPolicyErrors.None
            };
            if (!string.IsNullOrEmpty(config.ProxyHost))
            {
                handler.Proxy = InitProxy(config);
            }
            _httpClient = new HttpClient(new RetryHandler(handler));
            ConfigClientTimeout(config);  
        }

        private WebProxy InitProxy(HttpConfig config)
        {
            var proxy = config.ProxyPort.HasValue 
                ? new WebProxy(config.ProxyHost, config.ProxyPort.Value) 
                : new WebProxy(config.ProxyHost);
            proxy.BypassProxyOnLocal = true;
            proxy.UseDefaultCredentials = false;
            proxy.Credentials = string.IsNullOrEmpty(config.ProxyDomain)
                ? new NetworkCredential(config.ProxyUsername,
                    config.ProxyPassword ?? string.Empty)
                : new NetworkCredential(config.ProxyUsername,
                    config.ProxyPassword ?? string.Empty,
                    config.ProxyDomain);
            return proxy;
        }

        private void ConfigClientTimeout(HttpConfig config)
        {
            if (config.Timeout.HasValue)
            {
                _httpClient.Timeout = TimeSpan.FromSeconds(config.Timeout.Value);
            }
        }

        public HttpRequestMessage InitHttpRequest(HttpRequest request)
        {
            var message = new HttpRequestMessage
            {
                RequestUri = request.Url,
                Method = new HttpMethod(request.Method)
            };

            foreach (var key in  request.Headers.AllKeys)
            {
                if (key.Equals(HttpRequestHeader.Authorization.ToString()))
                {
                    message.Headers.TryAddWithoutValidation(HttpRequestHeader.Authorization.ToString(), 
                        request.Headers.GetValues(key));
                }
                else
                {
                    message.Headers.TryAddWithoutValidation(key, request.Headers.GetValues(key));
                }
            }

            if (request.Body != null)
            {
                message.Content = new StringContent(request.Body);
                message.Content.Headers.ContentType = new MediaTypeHeaderValue(select_header_content_type(request.ContentType));
            }

            return message;
        }

        private string select_header_content_type(string contentType)
        {
            if (contentType == null)
            {
                return "application/json";
            }

            if (contentType.Contains("application/json") || contentType.Contains("*/*"))
            {
                return "application/json";
            }

            return contentType;
        }

        public Task<HttpResponseMessage> DoHttpRequest(HttpRequestMessage request)
        {
            var task = _httpClient.SendAsync(request);
            return task;
        }
    }
}