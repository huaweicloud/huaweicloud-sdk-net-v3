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
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;

namespace HuaweiCloud.SDK.Core
{
    public class SdkHttpClient
    {
        private readonly HttpClient _myHttpClient;
        private readonly ILogger _logger;
        private readonly HttpHandler _httpHandler;

        public SdkHttpClient(String clientName, HttpConfig config, HttpHandler httpHandler, bool logging,
            LogLevel logLevel)
        {
            var serviceProvider = GetServiceCollection(config, logging, logLevel).BuildServiceProvider();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            this._logger = loggerFactory.CreateLogger("HuaweiCloud.Sdk");
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            this._myHttpClient = httpClientFactory.CreateClient("SdkHttpClient");
            this._httpHandler = httpHandler;
        }

        private IServiceCollection GetServiceCollection(HttpConfig httpConfig, bool logging, LogLevel logLevel)
        {
            var service = new ServiceCollection()
                .AddHttpClient(
                    "SdkHttpClient",
                    x => { x.Timeout = TimeSpan.FromSeconds(httpConfig.Timeout.Value); }
                )
                .AddTransientHttpErrorPolicy(builder => builder.WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(3),
                    TimeSpan.FromSeconds(3),
                    TimeSpan.FromSeconds(3)
                }))
                .ConfigurePrimaryHttpMessageHandler(
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

        public HttpRequestMessage InitHttpRequest(HttpRequest request, bool ignoreBodyForGetRequest)
        {
            var message = new HttpRequestMessage
            {
                RequestUri = request.Url,
                Method = new HttpMethod(request.Method)
            };

            foreach (var key in request.Headers.AllKeys)
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

            // Temporary workaround for .NET Framework, this framework does not support Content-Type headers in GET requests.
            if (!ignoreBodyForGetRequest || message.Method != HttpMethod.Get)
            {
                message.Content = new StringContent(request.Body);
                message.Content.Headers.ContentType =
                    new MediaTypeHeaderValue(SelectHeaderContentType(request.ContentType));
            }

            if (request.FileStream != null && request.FileStream != Stream.Null)
            {
                message.Content = new StreamContent(request.FileStream);
                message.Content.Headers.ContentType =
                    new MediaTypeHeaderValue(SelectHeaderContentType(request.ContentType));
            }

            if (request.FormData != null && request.FormData.Count != 0)
            {
                var formDataContent = GetFormDataContent(request);
                message.Content = formDataContent;
            }

            return message;
        }

        private string SelectHeaderContentType(string contentType)
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

        private HttpContent GetFormDataContent(HttpRequest request)
        {
            var boundary = Guid.NewGuid().ToString("N");
            var contentType = "multipart/form-data; boundary=" + boundary;
            var content = new MultipartFormDataContent(boundary);
            request.Headers.Add("ContentType", contentType);
            content.Headers.Remove("Content-Type");
            content.Headers.TryAddWithoutValidation("Content-Type", contentType);

            var fileParts = new Dictionary<string, FormDataFilePart>();

            foreach (var pair in request.FormData)
            {
                if (pair.Value is FormDataFilePart formDataFilePart)
                {
                    fileParts.Add(pair.Key, formDataFilePart);
                }
                else
                {
                    content.Add(new StringContent(pair.Value.ToString()), $"\"{pair.Key}\"");
                }
            }

            foreach (var pair in fileParts)
            {
                var filePart = pair.Value;
                var streamContent = new StreamContent(filePart.GetValue());
                if (filePart.GetContentType() != null)
                {
                    streamContent.Headers.ContentType = new MediaTypeHeaderValue(filePart.GetContentType());
                }
                content.Add(streamContent, $"\"{pair.Key}\"", $"\"{filePart.GetFilename()}\"");
            }

            return content;
        }

        public async Task<HttpResponseMessage> DoHttpRequest(HttpRequestMessage request)
        {
            _httpHandler?.ProcessRequest(request, this._logger);
            var response = await _myHttpClient.SendAsync(request);
            _httpHandler?.ProcessResponse(response, this._logger);
            return response;
        }
    }
}
