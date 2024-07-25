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
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace HuaweiCloud.SDK.Core.Auth
{
    public class GlobalCredentials : Credentials<GlobalCredentials>
    {

        internal const string Type = "global";

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

            if (AuthCache.Value.ContainsKey(Ak))
            {
                DomainId = AuthCache.Value[Ak];
                return this;
            }

            var derivedFunc = DerivedPredicate;
            DerivedPredicate = null;

            IamEndpoint = string.IsNullOrEmpty(IamEndpoint) ? IamService.DefaultIamEndpoint : IamEndpoint;
            var logger = client.GetLogger();
            logger.LogInformation("Domain id not found in BasicCredentials, trying to obtain domain id from IAM service: {}", IamEndpoint);
            var request = IamService.GetKeystoneListAuthDomainsRequest(IamEndpoint, client.GetHttpConfig());
            request = SignAuthRequest(request).Result;
            try
            {
                var response = IamService.InternalKeystoneListAuthDomains(client, request);
                if (response.Domains == null || response.Domains.Count == 0)
                {
                    throw new SdkException(string.Format("Failed to get domain id automatically, X-IAM-Trace-Id={}. " +
                                                         "Please confirm that you have 'iam:users:getUser' permission, " +
                                                         "or specify domain id manually: new GlobalCredentials(ak, sk, domainId);", response.TraceId));
                }
                DomainId = response.Domains[0].Id;
                logger.LogInformation("Success to obtain domain id: {}", DomainId);
                AuthCache.Value[Ak] = DomainId;
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
