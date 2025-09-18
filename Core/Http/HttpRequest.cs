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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

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

        public HttpRequestMessage ToHttpRequestMessage()
        {
            var message = new HttpRequestMessage
            {
                RequestUri = Url,
                Method = new HttpMethod(Method)
            };

            foreach (var kvp in Headers.AllKeys.Select(k => new KeyValuePair<string, string[]>(k, Headers.GetValues(k))))
            {
                message.Headers.TryAddWithoutValidation(kvp.Key, kvp.Value);
            }

            if (TryProcessHttpContent(out var httpContent))
            {
                message.Content = httpContent;
            }
            return message;
        }

        private bool TryProcessHttpContent(out HttpContent httpContent)
        {
            httpContent = null;
            if (string.Equals(Method, "GET", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            var contentType = HttpContentType.Process(ContentType);
            if (FileStream != null && FileStream != Stream.Null)
            {
                httpContent = new StreamContent(FileStream);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                return true;
            }

            if (FormData != null && FormData.Count != 0)
            {
                httpContent = ContentType == HttpContentType.ApplicationFormUrlEncoded ? ProcessFormUrlEncodedContent() : ProcessFormDataContent();
                return true;
            }

            if (contentType.StartsWith(HttpContentType.ApplicationJson))
            {
                httpContent = new StringContent(Body);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                return true;
            }

            return false;
        }

        private HttpContent ProcessFormUrlEncodedContent()
        {
            var pairs = FormData.Select(pair => new KeyValuePair<string, string>(pair.Key, pair.Value.ToString())).ToList();
            return new FormUrlEncodedContent(pairs);
        }

        private HttpContent ProcessFormDataContent()
        {
            var boundary = Guid.NewGuid().ToString("N");
            var contentType = "multipart/form-data; boundary=" + boundary;
            var multipartContent = new MultipartFormDataContent(boundary);
            Headers.Set(HttpContentType.Name, contentType);
            multipartContent.Headers.Remove(HttpContentType.Name);
            multipartContent.Headers.TryAddWithoutValidation(HttpContentType.Name, contentType);

            var fileParts = new Dictionary<string, FormDataFilePart>();

            foreach (var pair in FormData)
            {
                if (pair.Value is FormDataFilePart formDataFilePart)
                {
                    fileParts[pair.Key] = formDataFilePart;
                }
                else
                {
                    multipartContent.Add(new StringContent(pair.Value.ToString()), $"\"{pair.Key}\"");
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
                multipartContent.Add(streamContent, $"\"{pair.Key}\"", $"\"{filePart.GetFilename()}\"");
            }

            foreach (var content in multipartContent)
            {
                var headerContent = content.Headers.ContentDisposition.Parameters.SingleOrDefault(x => x.Name == "filename*");
                if (headerContent != null)
                    content.Headers.ContentDisposition.Parameters.Remove(headerContent);
            }

            return multipartContent;
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
