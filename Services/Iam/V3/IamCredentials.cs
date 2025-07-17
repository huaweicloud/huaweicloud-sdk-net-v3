/*
 * Copyright 2022 Huawei Technologies Co.,Ltd.
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
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCloud.SDK.Iam.V3
{
    public class IamCredentials : ICredential
    {

        public string XAuthToken { set; get; }

        private static readonly Dictionary<string, string> PathParamDict = new Dictionary<string, string>();

        public IamCredentials(string xAuthToken = null)
        {
            this.XAuthToken = xAuthToken;
        }

        public Dictionary<string, string> GetPathParamDictionary()
        {
            return PathParamDict;
        }

        public Task<HttpRequest> SignAuthRequest(HttpRequest request, SdkHttpClient client = null)
        {
            var httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                if (XAuthToken != null)
                {
                    request.Headers.Add("X-Auth-Token", XAuthToken);
                }

                return request;
            });

            return httpRequestTask;
        }

        public ICredential ProcessAuthParams(SdkHttpClient client, string regionId)
        {
            return this;
        }

        public void ProcessDerivedAuthParams(string derivedAuthServiceName, string regionId)
        {
        }
    }
}
