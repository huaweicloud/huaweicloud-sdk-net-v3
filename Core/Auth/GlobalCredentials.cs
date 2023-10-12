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
using System.Threading.Tasks;

namespace HuaweiCloud.SDK.Core.Auth
{
    public class GlobalCredentials : Credentials<GlobalCredentials>
    {
        public GlobalCredentials(string ak, string sk, string domainId = null)
        {
            Ak = ak;
            Sk = sk;
            DomainId = domainId;
        }

        private string DomainId { set; get; }

        public override void ProcessDerivedAuthParams(string derivedAuthServiceName, string regionId)
        {
            if (DerivedAuthServiceName == null)
            {
                DerivedAuthServiceName = derivedAuthServiceName;
            }

            if (RegionId == null)
            {
                RegionId = "globe";
            }
        }

        public override Dictionary<string, string> GetPathParamDictionary()
        {
            var pathParamDictionary = new Dictionary<string, string>();

            if (DomainId != null)
            {
                pathParamDictionary.Add("domain_id", DomainId);
            }

            return pathParamDictionary;
        }

        public override Task<HttpRequest> SignAuthRequest(HttpRequest request)
        {
            var httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                if (DomainId != null)
                {
                    request.Headers.Add("X-Domain-Id", DomainId);
                }

                if (SecurityToken != null)
                {
                    request.Headers.Add("X-Security-Token", SecurityToken);
                }

                if (IsDerivedAuth(request))
                {
                    DerivedSigner.GetInstance().Sign(request, this);
                    return request;
                }

                IAkSkSigner signer = AkSkSignerFactory.GetSigner(request.SigningAlgorithm);
                signer.Sign(request, this);
                return request;
            });

            return httpRequestTask;
        }

        public override ICredential ProcessAuthParams(SdkHttpClient client, string regionId)
        {
            if (DomainId != null)
            {
                return this;
            }

            var domainId = AuthCache.GetAuth(Ak);
            if (!string.IsNullOrEmpty(domainId))
            {
                DomainId = domainId;
                return this;
            }

            var derivedFunc = DerivedPredicate;
            DerivedPredicate = null;

            IamEndpoint = string.IsNullOrEmpty(IamEndpoint) ? IamService.DefaultIamEndpoint : IamEndpoint;
            var request = IamService.GetKeystoneListAuthDomainsRequest(IamEndpoint, client.GetHttpConfig());
            request = SignAuthRequest(request).Result;
            try
            {
                DomainId = IamService.KeystoneListAuthDomains(client, request);
                AuthCache.PutAuth(Ak, DomainId);
                DerivedPredicate = derivedFunc;
                return this;
            }
            catch (ServiceResponseException e)
            {
                throw new ArgumentException("Failed to get domain id, " + e.ErrorMsg);
            }
        }
    }
}
