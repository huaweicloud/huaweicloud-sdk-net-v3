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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HuaweiCloud.SDK.Core
{
    public static class JsonUtils
    {
        public static T DeSerialize<T>(SdkResponse sdkResponse) where T : SdkResponse
        {
            var jsonObject = JsonConvert.DeserializeObject<T>(sdkResponse.GetHttpBody());

            if (jsonObject == null)
            {
                return DeSerializeNull<T>(sdkResponse);
            }

            jsonObject.HttpStatusCode = sdkResponse.HttpStatusCode;
            jsonObject.HttpHeaders = sdkResponse.HttpHeaders;
            jsonObject.HttpBody = sdkResponse.HttpBody;
            return jsonObject;
        }

        public static T DeSerializeNull<T>(SdkResponse sdkResponse) where T : SdkResponse
        {
            var t = Activator.CreateInstance<T>();
            t.HttpHeaders = sdkResponse.HttpHeaders;
            t.HttpBody = sdkResponse.HttpBody;
            t.HttpStatusCode = sdkResponse.HttpStatusCode;
            return t;
        }

        public static List<T> DeSerializeList<T>(SdkResponse sdkResponse)
        {
            var data = JArray.Parse(sdkResponse.GetHttpBody()).ToObject<List<T>>();
            return data;
        }

        public static string Serialize(object item)
        {
            return JsonConvert.SerializeObject(item);
        }
    }
}