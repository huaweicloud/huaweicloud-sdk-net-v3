﻿/*
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
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HuaweiCloud.SDK.Core
{
    public static class JsonUtils
    {
        public static T DeSerialize<T>(HttpResponseMessage message) where T : SdkResponse
        {
            if (typeof(T).IsSubclassOf(typeof(SdkStreamResponse)))
            {
                return HttpUtils.DeSerializeStream<T>(message);
            }

            var body = Encoding.UTF8.GetString(message.Content.ReadAsByteArrayAsync().Result);
            var response = SetResponseBody<T>(body);

            HttpUtils.SetAdditionalAttrs(message, response, body);
            HttpUtils.SetResponseHeaders(message, response);

            return response;
        }

        private static T SetResponseBody<T>(string body) where T : SdkResponse
        {
            return string.IsNullOrEmpty(body) ? Activator.CreateInstance<T>() : JsonConvert.DeserializeObject<T>(body, GetJsonSettings());
        }

        public static T DeSerialize<T>(SdkResponse response) where T : SdkResponse
        {
            var tResponse = SetResponseBody<T>(response.HttpBody);
            tResponse.HttpStatusCode = response.HttpStatusCode;
            tResponse.HttpHeaders = response.HttpHeaders;
            tResponse.HttpBody = response.HttpBody;
            return tResponse;
        }

        public static T DeSerializeNull<T>(HttpResponseMessage message) where T : SdkResponse
        {
            var response = Activator.CreateInstance<T>();
            response.HttpStatusCode = (int)message.StatusCode;
            response.HttpHeaders = message.Headers.ToString();
            response.HttpBody = Encoding.UTF8.GetString(message.Content.ReadAsByteArrayAsync().Result);
            return response;
        }

        public static List<T> DeSerializeList<T>(HttpResponseMessage message)
        {
            var body = Encoding.UTF8.GetString(message.Content.ReadAsByteArrayAsync().Result);
            return string.IsNullOrEmpty(body) ? new List<T>() : JArray.Parse(body).ToObject<List<T>>(JsonSerializer.CreateDefault(GetJsonSettings()));
        }

        public static Dictionary<TK, TV> DeSerializeMap<TK, TV>(HttpResponseMessage message)
        {
            var body = Encoding.UTF8.GetString(message.Content.ReadAsByteArrayAsync().Result);
            return string.IsNullOrEmpty(body) ? new Dictionary<TK, TV>() : JObject.Parse(body).ToObject<Dictionary<TK, TV>>(JsonSerializer.CreateDefault(GetJsonSettings()));
        }

        public static string Serialize(object item)
        {
            return JsonConvert.SerializeObject(item);
        }

        private static JsonSerializerSettings GetJsonSettings()
        {
            var settings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateParseHandling = DateParseHandling.DateTime
            };
            return settings;
        }
    }
}
