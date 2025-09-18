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
        private const string HttpStatusCode = "HttpStatusCode";
        private const string HttpHeaders = "HttpHeaders";
        private const string SetStream = "SetStream";

        public static string AddUrlPath(string path, Dictionary<string, string> pathParams)
        {
            return pathParams.Aggregate(path, (current, keyValuePair) => current.Replace("{" + keyValuePair.Key + "}", keyValuePair.Value));
        }

        private static StringBuilder BuildQueryStringParameter(string key, object value)
        {
            var sb = new StringBuilder();
            return StringUtils.TryConvertToNonEmptyString(value, out var str) ? sb.Append(key).Append("=").Append(str).Append("&") : sb;
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

        private static StringBuilder BuildQueryDictionaryParameter(string key, IDictionary dict, HashSet<object> processedObjects = null)
        {
            if (processedObjects == null)
            {
                processedObjects = new HashSet<object>();
            }
            if (processedObjects.Contains(dict))
            {
                return new StringBuilder();
            }
            processedObjects.Add(dict);

            var sb = new StringBuilder();
            foreach (KeyValuePair<string, object> pair in dict)
            {
                var inputKey = $"{key}[{pair.Key}]";
                switch (pair.Value)
                {
                    case IList list:
                        sb.Append(BuildQueryListParameter(inputKey, list));
                        break;
                    case IDictionary dictionary:
                        sb.Append(BuildQueryDictionaryParameter(inputKey, dictionary, processedObjects));
                        break;
                    default:
                        sb.Append(BuildQueryStringParameter(inputKey, pair.Value));
                        break;
                }
            }

            processedObjects.Remove(dict);
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

            if ((contentType == HttpContentType.MultipartFormData || contentType == HttpContentType.ApplicationFormUrlEncoded) && value is IFormDataBody formDataBody)
            {
                request.FormData = formDataBody.BuildFormData();
                return;
            }

            request.Body = contentType == HttpContentType.ApplicationXml ? XmlUtils.Serialize(value) : JsonUtils.Serialize(value);
        }

        private static void ProcessStreamRequest(SdkRequest request, SdkStreamRequest streamRequest)
        {
            if (streamRequest.FileStream == null) return;

            if (streamRequest.TransferProgress == null)
            {
                request.FileStream = streamRequest.FileStream;
                return;
            }

            var contentLength = request.Header.TryGetValue(HttpContentType.Length, out var contentLengthInHeader) ? long.Parse(contentLengthInHeader) : streamRequest.FileStream.Length;
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
                if (sdkPropertyAttribute == null)
                {
                    continue;
                }

                var value = propertyInfo.GetValue(obj, null);
                if (value == null)
                {
                    continue;
                }

                if (sdkPropertyAttribute.IsQuery)
                {
                    ProcessQueryParams(querySb, sdkPropertyAttribute.PropertyName, value);
                }
                else if (sdkPropertyAttribute.IsBody)
                {
                    ProcessRequestBody(request, value, contentType);
                }
                else if (StringUtils.TryConvertToNonEmptyString(value, out var strVal))
                {
                    if (sdkPropertyAttribute.IsHeader)
                    {
                        headers.Add(sdkPropertyAttribute.PropertyName, strVal);
                    }
                    else if (sdkPropertyAttribute.IsCname)
                    {
                        request.Cname = strVal;
                    }
                }
            }

            // query
            var strIndex = querySb.Length;
            if (!string.IsNullOrEmpty(querySb.ToString()))
            {
                querySb.Remove(strIndex - 1, 1);
            }
            var queryStr = querySb.ToString();
            if (!string.IsNullOrEmpty(queryStr))
            {
                request.QueryParams = queryStr;
            }
            // headers
            request.Header = headers;
            // content-type
            if (!string.IsNullOrEmpty(contentType))
            {
                request.ContentType = contentType;
                request.Header.Add(HttpContentType.Name, request.ContentType);
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
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            var request = new SdkRequest
            {
                Path = path
            };
            if (data == null)
            {
                return request;
            }

            ProcessRequestParams(data, request, contentType);
            return request;
        }

        public static T DeSerializeStream<T>(HttpResponseMessage message)
        {
            var t = Activator.CreateInstance<T>();
            t.GetType().GetProperty(HttpStatusCode)?.SetValue(t, (int)message.StatusCode, null);
            t.GetType().GetProperty(HttpHeaders)?.SetValue(t, message.Headers.ToString(), null);
            const BindingFlags flag = BindingFlags.Public | BindingFlags.Instance;
            t.GetType().GetMethod(SetStream)?.Invoke(t, flag, Type.DefaultBinder,
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
                var propertyAttribute = GetSdkPropertyAttribute(property);
                if (propertyAttribute == null || !propertyAttribute.IsHeader || string.IsNullOrEmpty(propertyAttribute.PropertyName))
                {
                    continue;
                }

                if (message.Headers.TryGetValues(propertyAttribute.PropertyName, out var values))
                {
                    property.SetValue(obj, values.First());
                }
                else if (message.Content.Headers.TryGetValues(propertyAttribute.PropertyName, out values))
                {
                    property.SetValue(obj, values.First());
                }
            }
        }
    }
}
