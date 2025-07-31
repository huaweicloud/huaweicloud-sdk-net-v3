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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace HuaweiCloud.SDK.Core
{
    public static class HttpUtils
    {

        private static readonly List<string> HttpContentHeadersList = new List<string>
        {
            "Allow",
            "Content-Disposition",
            "Content-Encoding",
            "Content-Language",
            "Content-Location",
            "Content-MD5",
            "Content-Range",
            "Content-Type",
            "Content-Length",
            "Expires",
            "Last-Modified"
        };

        public static string AddUrlPath(string path, Dictionary<string, string> pathParams)
        {
            return pathParams.Aggregate(path,
                (current, keyValuePair) => current.Replace("{" + keyValuePair.Key + "}",
                    keyValuePair.Value));
        }

        private static string GetQueryParameters(object obj)
        {
            var sb = new StringBuilder();
            var t = obj.GetType();
            var pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var p in pi)
            {
                var attributes = p.GetCustomAttributes(typeof(SDKPropertyAttribute), true);
                SDKPropertyAttribute sdkPropertyAttribute = null;

                if (attributes.Length == 0)
                {
                    continue;
                }

                foreach (var a in attributes)
                {
                    if (a is SDKPropertyAttribute propertyAttribute)
                    {
                        sdkPropertyAttribute = propertyAttribute;
                    }
                }

                if (sdkPropertyAttribute == null || !sdkPropertyAttribute.IsQuery)
                {
                    continue;
                }

                var value = p.GetValue(obj, null);
                if (value == null || string.IsNullOrEmpty(Convert.ToString(value)))
                {
                    continue;
                }

                if (value is IList list)
                {
                    sb.Append(BuildQueryListParameter(sdkPropertyAttribute.PropertyName, list));
                }
                else if (value is IDictionary dictionary)
                {
                    sb.Append(BuildQueryDictionaryParameter(sdkPropertyAttribute.PropertyName, dictionary));
                }
                else if (value is bool boolean)
                {
                    sb.Append(BuildQueryBooleanParameter(sdkPropertyAttribute.PropertyName, boolean));
                }
                else
                {
                    sb.Append(BuildQueryStringParameter(sdkPropertyAttribute.PropertyName, Convert.ToString(value)));
                }
            }

            var strIndex = sb.Length;
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                sb.Remove(strIndex - 1, 1);
            }

            return sb.ToString();
        }

        private static StringBuilder BuildQueryStringParameter(string key, string value)
        {
            var sb = new StringBuilder();
            return sb.Append(key).Append("=").Append(Convert.ToString(value)).Append("&");
        }

        private static StringBuilder BuildQueryBooleanParameter(string key, bool boolean)
        {
            var sb = new StringBuilder();
            return sb.Append(key).Append("=").Append(Convert.ToString(boolean).ToLowerInvariant()).Append("&");
        }

        private static StringBuilder BuildQueryListParameter(string key, IList list)
        {
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(key).Append("=").Append(Convert.ToString(item)).Append("&");
            }

            return sb;
        }

        private static StringBuilder BuildQueryDictionaryParameter(string key, IDictionary dict)
        {
            var sb = new StringBuilder();
            foreach (var k in dict.Keys)
            {
                if (dict[k] is IList list)
                {
                    sb.Append(BuildQueryListParameter(key + "[" + k + "]", list));
                }
                else if (dict[k] is IDictionary dictionary)
                {
                    sb.Append(BuildQueryDictionaryParameter(key + "[" + k + "]", dictionary));
                }
                else
                {
                    sb.Append(BuildQueryStringParameter(key + "[" + k + "]", Convert.ToString(dict[k])));
                }
            }

            return sb;
        }

        private static Dictionary<string, string> GetRequestHeader(object obj)
        {
            var t = obj.GetType();
            var pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var element = new Dictionary<string, string>();
            foreach (var p in pi)
            {
                var attributes = p.GetCustomAttributes(typeof(SDKPropertyAttribute), true);
                SDKPropertyAttribute sdkPropertyAttribute = null;

                if (attributes.Length == 0)
                {
                    continue;
                }

                foreach (var a in attributes)
                {
                    if (a is SDKPropertyAttribute propertyAttribute)
                    {
                        sdkPropertyAttribute = propertyAttribute;
                    }
                }

                if (sdkPropertyAttribute == null || !sdkPropertyAttribute.IsHeader)
                {
                    continue;
                }

                var value = p.GetValue(obj, null);
                if (value == null || string.IsNullOrEmpty(Convert.ToString(value)))
                {
                    continue;
                }

                element.Add(sdkPropertyAttribute.PropertyName, Convert.ToString(value));
            }

            return element;
        }

        private static string GetCname(object obj)
        {
            var t = obj.GetType();
            var pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var element = new Dictionary<string, string>();
            foreach (var p in pi)
            {
                var attributes = p.GetCustomAttributes(typeof(SDKPropertyAttribute), true);
                SDKPropertyAttribute sdkPropertyAttribute = null;

                if (attributes.Length == 0)
                {
                    continue;
                }

                foreach (var a in attributes)
                {
                    if (a is SDKPropertyAttribute propertyAttribute)
                    {
                        sdkPropertyAttribute = propertyAttribute;
                    }
                }

                if (sdkPropertyAttribute == null || !sdkPropertyAttribute.IsCname)
                {
                    continue;
                }

                var value = p.GetValue(obj, null);
                if (value == null || string.IsNullOrEmpty(Convert.ToString(value)))
                {
                    continue;
                }

                return Convert.ToString(value);
            }

            return null;
        }

        private static string GetRequestBody(object obj, string contentType)
        {
            var t = obj.GetType();
            var pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var sdkPropertyList = new List<object>();

            foreach (var p in pi)
            {
                var attributes = p.GetCustomAttributes(typeof(SDKPropertyAttribute), true);
                SDKPropertyAttribute sdkPropertyAttribute = null;

                if (attributes.Length == 0)
                {
                    continue;
                }

                foreach (var a in attributes)
                {
                    if (a is SDKPropertyAttribute propertyAttribute)
                    {
                        sdkPropertyAttribute = propertyAttribute;
                    }
                }

                if (sdkPropertyAttribute == null || !sdkPropertyAttribute.IsBody)
                {
                    continue;
                }

                var value = p.GetValue(obj, null);
                if (value == null)
                {
                    continue;
                }

                sdkPropertyList.Add(value);
            }

            if (sdkPropertyList.Count == 1)
            {
                foreach (var elem in sdkPropertyList)
                {
                    if (elem is string eleString)
                    {
                        return eleString;
                    }

                    return contentType == "application/xml" ? XmlUtils.Serialize(elem) : JsonUtils.Serialize(elem);
                }
            }

            return "";
        }

        private static Dictionary<string, object> GetFormData(object obj)
        {
            var t = obj.GetType();
            var pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var sdkPropertyList = new List<object>();

            foreach (var p in pi)
            {
                var attributes = p.GetCustomAttributes(typeof(SDKPropertyAttribute), true);
                SDKPropertyAttribute sdkPropertyAttribute = null;

                if (attributes.Length == 0)
                {
                    continue;
                }

                foreach (var a in attributes)
                {
                    if (a is SDKPropertyAttribute propertyAttribute)
                    {
                        sdkPropertyAttribute = propertyAttribute;
                    }
                }

                if (sdkPropertyAttribute == null || !sdkPropertyAttribute.IsBody)
                {
                    continue;
                }

                var value = p.GetValue(obj, null);
                if (value == null)
                {
                    continue;
                }

                sdkPropertyList.Add(value);
            }

            if (sdkPropertyList.Count == 1)
            {
                foreach (var elem in sdkPropertyList)
                {
                    if (elem is IFormDataBody)
                    {
                        return ((IFormDataBody)elem).BuildFormData();
                    }
                }
            }

            return null;
        }

        public static SdkRequest InitSdkRequest(string path, object data = null)
        {
            return InitSdkRequest(path, null, data);
        }

        public static SdkRequest InitSdkRequest(string path, string contentType, object data = null)
        {
            if (path != null && string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("Url cannot be null.");
            }

            var request = new SdkRequest
            {
                Path = path
            };
            if (data == null)
            {
                return request;
            }

            var cname = GetCname(data);
            if (!string.IsNullOrEmpty(cname))
            {
                request.Cname = cname;
            }

            var prams = GetQueryParameters(data);
            if (prams != "")
            {
                request.QueryParams = prams;
            }

            var headers = GetRequestHeader(data);
            if (headers != null)
            {
                request.Header = headers;
            }

            if (contentType == "multipart/form-data" || contentType == "application/x-www-form-urlencoded")
            {
                var formData = GetFormData(data);
                if (formData != null)
                {
                    request.FormData = formData;
                }
            }
            else
            {
                var bodyData = GetRequestBody(data, contentType);
                if (bodyData != null)
                {
                    request.Body = bodyData;
                }
            }

            if (!string.IsNullOrEmpty(contentType))
            {
                request.ContentType = contentType;
                request.Header.Add("Content-Type", request.ContentType);
            }

            if (data.GetType().IsSubclassOf(typeof(SdkStreamRequest)))
            {
                var streamRequest = (SdkStreamRequest)data;
                if (streamRequest.TransferProgress != null)
                {
                    long contentLength = -1;
                    if (request.Header.ContainsKey("Content-Length"))
                    {
                        contentLength = long.Parse(request.Header["Content-Length"]);
                    }
                    else
                    {
                        contentLength = streamRequest.FileStream.Length;
                    }

                    var transferStream = new TransferStream(streamRequest.FileStream);
                    TransferStreamManager mgr;
                    if (streamRequest.ProgressType == ProgressTypeEnum.ByBytes)
                    {
                        mgr = new TransferStreamByBytes(request, streamRequest.TransferProgress,
                            contentLength, 0, streamRequest.ProgressInterval);
                    }
                    else
                    {
                        mgr = new ThreadSafeTransferStreamBySeconds(request, streamRequest.TransferProgress,
                            contentLength, 0, streamRequest.ProgressInterval);
                        transferStream.CloseStream += mgr.TransferEnd;
                    }

                    transferStream.BytesRead += mgr.BytesTransferred;
                    transferStream.StartRead += mgr.TransferStart;
                    transferStream.BytesReset += mgr.TransferReset;

                    streamRequest.FileStream = transferStream;
                    request.FileStream = streamRequest.FileStream;
                }
                else
                {
                    request.FileStream = streamRequest.FileStream;
                }
            }

            return request;
        }

        public static T DeSerializeStream<T>(HttpResponseMessage message) where T : new()
        {
            var t = new T();
            t.GetType().GetProperty("HttpStatusCode")?.SetValue(t, (int)message.StatusCode, null);
            t.GetType().GetProperty("HttpHeaders")?.SetValue(t, message.Headers.ToString(), null);
            var flag = BindingFlags.Public | BindingFlags.Instance;
            t.GetType().GetMethod("SetStream")
                ?.Invoke(t, flag, Type.DefaultBinder,
                    new object[]
                    {
                        message.Content.ReadAsStreamAsync().Result
                    }, null);
            return t;
        }

        public static T DeSerializeStream<R, T>(R progressRequest, HttpResponseMessage message)
            where R : IProgressRequest
            where T : SdkStreamResponse, new()
        {
            var streamResponse = new T
            {
                HttpStatusCode = (int)message.StatusCode,
                HttpHeaders = message.Headers.ToString()
            };

            var stream = message.Content.ReadAsStreamAsync().Result;

            if (progressRequest.TransferProgress != null)
            {
                var contentLength = message.Content.Headers.ContentLength ?? stream.Length;
                var transferStream = new TransferStream(stream);
                TransferStreamManager mgr;
                if (progressRequest.ProgressType == ProgressTypeEnum.ByBytes)
                {
                    mgr = new TransferStreamByBytes(streamResponse, progressRequest.TransferProgress,
                        contentLength, 0, progressRequest.ProgressInterval);
                }
                else
                {
                    mgr = new ThreadSafeTransferStreamBySeconds(streamResponse, progressRequest.TransferProgress,
                        contentLength, 0, progressRequest.ProgressInterval);
                    transferStream.CloseStream += mgr.TransferEnd;
                }

                transferStream.BytesRead += mgr.BytesTransferred;
                transferStream.StartRead += mgr.TransferStart;
                transferStream.BytesReset += mgr.TransferReset;
                stream = transferStream;
            }

            streamResponse.SetStream(stream);

            return streamResponse;
        }

        public static void SetAdditionalAttrs<T>(HttpResponseMessage message, T response, string body) where T : SdkResponse
        {
            response.HttpStatusCode = (int)message.StatusCode;
            response.HttpHeaders = message.Headers.ToString();
            response.HttpBody = body;
        }

        public static void SetResponseHeaders<T>(HttpResponseMessage message, T obj)
        {
            const BindingFlags instanceBindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

            var properties = obj.GetType().GetProperties(instanceBindFlags);

            foreach (var property in properties)
            {
                string oriAttrName = null;
                var customAttrs = property.GetCustomAttributes(typeof(SDKPropertyAttribute), true);
                if (customAttrs.Length > 0)
                {
                    SDKPropertyAttribute sdkPropertyAttribute = null;
                    foreach (var customAttr in customAttrs)
                    {
                        if (customAttr is SDKPropertyAttribute propertyAttribute)
                        {
                            sdkPropertyAttribute = propertyAttribute;
                        }

                        if (sdkPropertyAttribute == null || !sdkPropertyAttribute.IsHeader)
                        {
                            continue;
                        }

                        oriAttrName = sdkPropertyAttribute.PropertyName;
                    }
                }

                if (string.IsNullOrEmpty(oriAttrName))
                {
                    continue;
                }

                if (HttpContentHeadersList.Contains(oriAttrName))
                {
                    if (message.Content.Headers.Contains(oriAttrName))
                    {
                        property.SetValue(obj, message.Content.Headers.GetValues(oriAttrName).First());
                    }
                }
                else
                {
                    if (message.Headers.Contains(oriAttrName))
                    {
                        property.SetValue(obj, message.Headers.GetValues(oriAttrName).First());
                    }
                }
            }
        }
    }
}
