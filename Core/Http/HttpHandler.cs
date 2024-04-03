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
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace HuaweiCloud.SDK.Core
{
    public class HttpHandler
    {
        private readonly List<Action<HttpRequestMessage, ILogger>> _requestHandlers =
            new List<Action<HttpRequestMessage, ILogger>>();

        private readonly List<Action<HttpResponseMessage, ILogger>> _responseHandlers =
            new List<Action<HttpResponseMessage, ILogger>>();

        public HttpHandler AddRequestHandler(Action<HttpRequestMessage, ILogger> func)
        {
            _requestHandlers.Add(func);
            return this;
        }

        public HttpHandler AddResponseHandler(Action<HttpResponseMessage, ILogger> func)
        {
            _responseHandlers.Add(func);
            return this;
        }

        public void ProcessRequest(HttpRequestMessage request, ILogger logger)
        {
            foreach (var requestHandler in _requestHandlers)
            {
                requestHandler(request, logger);
            }
        }

        public void ProcessResponse(HttpResponseMessage response, ILogger logger)
        {
            foreach (var responseHandler in _responseHandlers)
            {
                responseHandler(response, logger);
            }
        }
    }
}
