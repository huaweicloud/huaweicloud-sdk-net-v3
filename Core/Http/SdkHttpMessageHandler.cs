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

using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;

namespace HuaweiCloud.SDK.Core
{
    public class HwMessageHandlerFactory
    {
        private readonly HttpConfig _httpConfig;

        public HwMessageHandlerFactory(HttpConfig httpConfig)
        {
            _httpConfig = httpConfig;
        }

        public DelegatingHandler GetHandler()
        {
            var handler = new HttpClientHandler
            {
                AllowAutoRedirect = _httpConfig.AllowRedirects,
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) =>
                        _httpConfig.IgnoreSslVerification || policyErrors == SslPolicyErrors.None
            };
            if (!string.IsNullOrEmpty(_httpConfig.ProxyHost))
            {
                handler.Proxy = InitProxy(_httpConfig);
            }

            return new RetryHandler(handler);
        }

        private static WebProxy InitProxy(HttpConfig config)
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
    }

    public class RetryHandler : DelegatingHandler
    {
        private const int MaxRetries = 1;

        public RetryHandler(HttpMessageHandler innerHandler) : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (var i = 0; i < MaxRetries; i++)
            {
                response = await base.SendAsync(request, cancellationToken);

                // todo Retry depends on policy
                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
            }

            return response;
        }
    }
}
