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
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HuaweiCloud.SDK.Core
{
    public static class JsonUtils
    {
        public static T DeSerialize<T>(HttpResponseMessage message)
        {
            if (typeof(T).IsSubclassOf(typeof(SdkStreamResponse)))
            {
                return DeSerializeStream<T>(message);
            }

            var body = message.Content.ReadAsStringAsync().Result;
            var jsonObject = JsonConvert.DeserializeObject<T>(body, GetJsonSettings());
            if (jsonObject == null)
            {
                jsonObject = Activator.CreateInstance<T>();
            }

            jsonObject.GetType().GetProperty("HttpStatusCode")?.SetValue(jsonObject, (int) message.StatusCode, null);
            jsonObject.GetType().GetProperty("HttpHeaders")?.SetValue(jsonObject, message.Headers.ToString(), null);
            jsonObject.GetType().GetProperty("HttpBody")?.SetValue(jsonObject, body, null);

            return jsonObject;
        }
        
        private static T DeSerializeStream<T>(HttpResponseMessage message)
        {
            var t = Activator.CreateInstance<T>();
            t.GetType().GetProperty("HttpStatusCode")?.SetValue(t, (int) message.StatusCode, null);
            t.GetType().GetProperty("HttpHeaders")?.SetValue(t, message.Headers.ToString(), null);
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance;
            t.GetType().GetMethod("SetStream")
                ?.Invoke(t, flag, Type.DefaultBinder,
                    new object[] {message.Content.ReadAsStreamAsync().Result}, null);
            return t;
        }

        public static T DeSerialize<T>(SdkResponse response) where T : SdkResponse
        {
            var jsonObject = JsonConvert.DeserializeObject<T>(response.HttpBody, GetJsonSettings()) ?? Activator.CreateInstance<T>();

            jsonObject.HttpStatusCode = response.HttpStatusCode;
            jsonObject.HttpHeaders = response.HttpHeaders;
            jsonObject.HttpBody = response.HttpBody;
            return jsonObject;
        }

        public static T DeSerializeNull<T>(HttpResponseMessage message) where T : SdkResponse
        {
            var t = Activator.CreateInstance<T>();
            t.HttpStatusCode = (int) message.StatusCode;
            t.HttpHeaders = message.Headers.ToString();
            t.HttpBody = message.Content.ReadAsStringAsync().Result;
            return t;
        }

        public static List<T> DeSerializeList<T>(HttpResponseMessage message)
        {
            var body = message.Content.ReadAsStringAsync().Result;
            return JArray.Parse(body).ToObject<List<T>>(JsonSerializer.CreateDefault(GetJsonSettings()));
        }

        public static Dictionary<TK, TV> DeSerializeMap<TK, TV>(HttpResponseMessage message)
        {
            var body = message.Content.ReadAsStringAsync().Result;
            return JArray.Parse(body).ToObject<Dictionary<TK, TV>>(JsonSerializer.CreateDefault(GetJsonSettings()));
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