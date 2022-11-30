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

using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;

namespace HuaweiCloud.SDK.Core.Auth
{
    public abstract class Credentials
    {
        public static readonly string DEFAULT_ENDPOINT_REG =
            "^[a-z][a-z0-9-]+(\\.[a-z]{2,}-[a-z]+-\\d{1,2})?\\.(my)?(huaweicloud|myhwclouds).(com|cn)";
        public abstract Dictionary<string, string> GetPathParamDictionary();

        public abstract Task<HttpRequest> SignAuthRequest(HttpRequest request);

        public abstract Credentials ProcessAuthParams(SdkHttpClient client, string regionId);

        public abstract void ProcessDerivedAuthParams(string derivedAuthServiceName, string regionId);

        public static Func<HttpRequest, bool> DefaultDerivedPredicate = httpRequest =>
            !Regex.IsMatch(httpRequest.Url.Host, DEFAULT_ENDPOINT_REG);
    }
}