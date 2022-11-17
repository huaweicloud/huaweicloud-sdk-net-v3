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
using System.Web;

namespace HuaweiCloud.SDK.Core
{
    public class HttpRequest
    {
        public string Method = "GET";
        public string Host = "";
        public Uri Url = null;
        public Dictionary<string, List<string>> QueryParam = new Dictionary<string, List<string>>();
        public WebHeaderCollection Headers = new WebHeaderCollection();
        public string Body = "";
        public string ContentType = "application/json";
        public Stream FileStream = Stream.Null;

        public HttpRequest(string method = "GET", string contentType = "application/json", Uri url = null,
            WebHeaderCollection headers = null,
            string body = null, Stream fileStream = null)
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
                    Body = "";
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
        }

        private void ParseQueryParam()
        {
            if (Url.Query.Length > 1)
            {
                foreach (var kv in Url.Query.Substring(1).Split('&'))
                {
                    var spl = kv.Split(new char[] {'='}, 2);
                    var key = HttpUtility.UrlDecode(spl[0]);
                    var value = "";
                    if (spl.Length > 1)
                    {
                        value = HttpUtility.UrlDecode(spl[1]);
                    }

                    if (QueryParam.ContainsKey(key))
                    {
                        QueryParam[key].Add(value);
                    }
                    else
                    {
                        QueryParam[key] = new List<string> {value};
                    }
                }
            }
        }
    }
}