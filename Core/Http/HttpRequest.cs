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

namespace HuaweiCloud.SDK.Core
{
    public class HttpRequest
    {
        public string Body = string.Empty;
        public string ContentType = "application/json";
        public Stream FileStream = Stream.Null;
        public Dictionary<string, object> FormData;
        public WebHeaderCollection Headers = new WebHeaderCollection();
        public string Host = string.Empty;
        public string Method = "GET";
        public Dictionary<string, List<string>> QueryParam = new Dictionary<string, List<string>>();
        public Uri Url;
        public SigningAlgorithm SigningAlgorithm;

        public HttpRequest(string method = "GET", string contentType = "application/json", Uri url = null,
            WebHeaderCollection headers = null,
            string body = null, Stream fileStream = null, SigningAlgorithm signingAlgorithm = Constants.DefaultSigningAlgorithm)
        {
            if (method != null)
            {
                Method = method;
            }

            if (url != null)
            {
                Url = url;
                Host = url.Scheme + "://" + url.Host;
                ParseQueryParam();
            }

            if (headers != null)
            {
                Headers = headers;
            }

            if (body != null)
            {
                Body = body;
                if (Method != "POST" && Method != "PATCH" && Method != "PUT")
                {
                    Body = string.Empty;
                }
            }

            if (contentType != null)
            {
                ContentType = contentType;
            }

            if (fileStream != null)
            {
                FileStream = fileStream;
            }

            SigningAlgorithm = signingAlgorithm;
        }

        private void ParseQueryParam()
        {
            if (Url.Query.Length > 1)
            {
                foreach (var kv in Url.Query.Substring(1).Split('&'))
                {
                    var spl = kv.Split(new[]
                    {
                        '='
                    }, 2);
                    var key = WebUtility.UrlDecode(spl[0]);
                    var value = string.Empty;
                    if (spl.Length > 1)
                    {
                        value = WebUtility.UrlDecode(spl[1]);
                    }

                    if (QueryParam.ContainsKey(key))
                    {
                        QueryParam[key].Add(value);
                    }
                    else
                    {
                        QueryParam[key] = new List<string>
                        {
                            value
                        };
                    }
                }
            }
        }
    }
}
