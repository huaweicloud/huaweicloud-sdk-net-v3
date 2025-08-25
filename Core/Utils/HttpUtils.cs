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
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace HuaweiCloud.SDK.Core
{
    public static class HttpUtils
    {
        private const string ContentType = "Content-Type";
        private const string ContentLength = "Content-Length";

        private const string ApplicationXml = "application/xml";
        private const string MultipartFormdata = "multipart/form-data";
        private const string ApplicationFormUrlEncoded = "application/x-www-form-urlencoded";

        private const string HttpStatusCode = "HttpStatusCode";
        private const string HttpHeaders = "HttpHeaders";
        private const string SetStream = "SetStream";

        private static readonly List<string> HttpContentHeadersList = new List<string>
        {
            ContentType,
            ContentLength,
            "Allow",
            "Content-Disposition",
            "Content-Encoding",
            "Content-Language",
            "Content-Location",
            "Content-MD5",
            "Content-Range",
            "Expires",
            "Last-Modified",
        };

        public static string AddUrlPath(string path, Dictionary<string, string> pathParams)
        {
            return pathParams.Aggregate(path,
                (current, keyValuePair) => current.Replace("{" + keyValuePair.Key + "}",
                    keyValuePair.Value));
        }

        private static string ConvertToString(object value)
        {
            if (value is bool boolean)
            {
                return Convert.ToString(boolean).ToLowerInvariant();
            }
            if (value is Enum enumValue)
            {
                var type = enumValue.GetType();
                var name = Enum.GetName(type, enumValue);
                if (name == null) return string.Empty;

                var field = type.GetField(name);
                if (field == null) return string.Empty;

                var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
                return attribute?.Value;
            }

            return Convert.ToString(value);
        }

        private static StringBuilder BuildQueryStringParameter(string key, object value)
        {
            var sb = new StringBuilder();
            var str = ConvertToString(value);
            if (string.IsNullOrEmpty(str)) return sb;

            return sb.Append(key).Append("=").Append(str).Append("&");
        }

        private static StringBuilder BuildQueryListParameter(string key, IList list)
        {
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(BuildQueryStringParameter(key, item));
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
                    sb.Append(BuildQueryStringParameter(key + "[" + k + "]", dict[k]));
                }
            }

            return sb;
        }

        private static SDKPropertyAttribute GetSdkPropertyAttribute(PropertyInfo propertyInfo)
        {
            var attributes = propertyInfo.GetCustomAttributes(typeof(SDKPropertyAttribute), true);
            if (attributes.Length == 0)
            {
                return null;
            }

            foreach (var attribute in attributes)
            {
                if (attribute is SDKPropertyAttribute sdkPropertyAttribute)
                {
                    return sdkPropertyAttribute;
                }
            }
            return null;
        }

        private static void ProcessQueryParams(StringBuilder stringBuilder, string name, object value)
        {
            if (value is IList list && list.Count != 0)
            {
                stringBuilder.Append(BuildQueryListParameter(name, list));
                return;
            }

            if (value is IDictionary dictionary && dictionary.Count != 0)
            {
                stringBuilder.Append(BuildQueryDictionaryParameter(name, dictionary));
                return;
            }

            stringBuilder.Append(BuildQueryStringParameter(name, value));
        }

        private static void ProcessRequestBody(SdkRequest request, object value, string contentType)
        {
            if (value is string strVal)
            {
                request.Body = strVal;
                return;
            }

            if ((contentType == MultipartFormdata || contentType == ApplicationFormUrlEncoded) && value is IFormDataBody formDataBody)
            {
                request.FormData = formDataBody.BuildFormData();
                return;
            }

            request.Body = contentType == ApplicationXml ? XmlUtils.Serialize(value) : JsonUtils.Serialize(value);
        }

        private static void ProcessStreamRequest(SdkRequest request, SdkStreamRequest streamRequest)
        {
            if (streamRequest.FileStream == null) return;

            if (streamRequest.TransferProgress == null)
            {
                request.FileStream = streamRequest.FileStream;
                return;
            }

            var contentLength = request.Header.TryGetValue(ContentLength, out var contentLengthInHeader) ? long.Parse(contentLengthInHeader) : streamRequest.FileStream.Length;
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

        private static void ProcessRequestParams(object obj, SdkRequest request, string contentType)
        {
            var querySb = new StringBuilder();
            var headers = new Dictionary<string, string>();

            var type = obj.GetType();
            var propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var propertyInfo in propertyInfos)
            {
                var sdkPropertyAttribute = GetSdkPropertyAttribute(propertyInfo);
                if (sdkPropertyAttribute == null) continue;

                var value = propertyInfo.GetValue(obj, null);
                if (value == null) continue;

                if (sdkPropertyAttribute.IsCname)
                {
                    var cname = Convert.ToString(value);
                    if (!string.IsNullOrEmpty(cname)) request.Cname = cname;
                }
                else if (sdkPropertyAttribute.IsQuery)
                {
                    ProcessQueryParams(querySb, sdkPropertyAttribute.PropertyName, value);
                }
                else if (sdkPropertyAttribute.IsHeader)
                {
                    var strVal = Convert.ToString(value);
                    if (!string.IsNullOrEmpty(strVal)) headers.Add(sdkPropertyAttribute.PropertyName, strVal);
                }
                else if (sdkPropertyAttribute.IsBody)
                {
                    ProcessRequestBody(request, value, contentType);
                }
            }

            // query
            var strIndex = querySb.Length;
            if (!string.IsNullOrEmpty(querySb.ToString()))
            {
                querySb.Remove(strIndex - 1, 1);
            }
            var queryStr = querySb.ToString();
            if (!string.IsNullOrEmpty(queryStr)) request.QueryParams = queryStr;
            // headers
            request.Header = headers;
            // content-type
            if (!string.IsNullOrEmpty(contentType))
            {
                request.ContentType = contentType;
                request.Header.Add(ContentType, request.ContentType);
            }
            // stream
            if (obj is SdkStreamRequest streamRequest)
            {
                ProcessStreamRequest(request, streamRequest);
            }
        }

        public static SdkRequest InitSdkRequest(string path, object data = null)
        {
            return InitSdkRequest(path, null, data);
        }

        public static SdkRequest InitSdkRequest(string path, string contentType, object data = null)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));

            var request = new SdkRequest
            {
                Path = path
            };
            if (data == null) return request;

            ProcessRequestParams(data, request, contentType);
            return request;
        }

        public static T DeSerializeStream<T>(HttpResponseMessage message)
        {
            var t = Activator.CreateInstance<T>();
            t.GetType().GetProperty(HttpStatusCode)?.SetValue(t, (int)message.StatusCode, null);
            t.GetType().GetProperty(HttpHeaders)?.SetValue(t, message.Headers.ToString(), null);
            var flag = BindingFlags.Public | BindingFlags.Instance;
            t.GetType().GetMethod(SetStream)
                ?.Invoke(t, flag, Type.DefaultBinder,
                    new object[]
                    {
                        message.Content.ReadAsStreamAsync().Result
                    }, null);
            return t;
        }

        public static T DeSerializeStream<R, T>(R progressRequest, HttpResponseMessage message)
            where R : IProgressRequest
            where T : SdkStreamResponse
        {
            var streamResponse = Activator.CreateInstance<T>();

            streamResponse.HttpStatusCode = (int)message.StatusCode;
            streamResponse.HttpHeaders = message.Headers.ToString();

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
