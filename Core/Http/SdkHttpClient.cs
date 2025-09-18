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
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HuaweiCloud.SDK.Core
{
    public class SdkHttpClient
    {
        private const string Name = "SdkHttpClient";
        private const string LoggerName = "HuaweiCloud.Sdk";
        private readonly HttpHandler _httpHandler;
        private readonly ILogger _logger;
        private readonly HttpClient _myHttpClient;
        private readonly HttpConfig _httpConfig;

        public SdkHttpClient(string clientName, HttpConfig config, HttpHandler httpHandler, bool logging,
            LogLevel logLevel)
        {
            var serviceProvider = GetServiceCollection(config, logging, logLevel).BuildServiceProvider();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            _logger = loggerFactory.CreateLogger(LoggerName);
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            _myHttpClient = httpClientFactory.CreateClient(Name);
            _httpHandler = httpHandler;
            _httpConfig = config;
        }

        public HttpConfig GetHttpConfig()
        {
            return _httpConfig;
        }

        internal ILogger GetLogger()
        {
            return _logger;
        }

        private static IServiceCollection GetServiceCollection(HttpConfig httpConfig, bool logging, LogLevel logLevel)
        {
            var service = new ServiceCollection()
                .AddHttpClient(
                    Name,
                    x => { x.Timeout = TimeSpan.FromSeconds(httpConfig.Timeout ?? 60); }
                ).ConfigurePrimaryHttpMessageHandler(
                    () => new HwMessageHandlerFactory(httpConfig).GetHandler()
                )
                .Services;

            if (logging)
            {
                service = service.AddLogging(builder => builder
                    .AddConsole()
                    .AddDebug()
                    .AddFilter(level => level >= logLevel));
            }

            return service;
        }

        public async Task<HttpResponseMessage> DoHttpRequest(HttpRequestMessage request)
        {
            _httpHandler?.ProcessRequest(request, _logger);
            var response = await _myHttpClient.SendAsync(request);
            _httpHandler?.ProcessResponse(response, _logger);
            return response;
        }

        [Obsolete("Use HttpRequest.ToHttpRequestMessage() instead.")]
        public HttpRequestMessage InitHttpRequest(HttpRequest request, bool ignoreBodyForGetRequest)
        {
            return request.ToHttpRequestMessage();
        }
    }
}
