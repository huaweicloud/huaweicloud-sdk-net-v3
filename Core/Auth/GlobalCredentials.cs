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
using static System.String;

namespace HuaweiCloud.SDK.Core.Auth
{
    public class GlobalCredentials : Credentials
    {
        private string Ak { set; get; }
        private string Sk { set; get; }
        private string DomainId { set; get; }
        private string SecurityToken { set; get; }
        private string IamEndpoint { set; get; }
        private Func<HttpRequest, bool> DerivedPredicate { set; get; }
        private string _derivedAuthServiceName;
        private string _regionId;


        public GlobalCredentials(string ak, string sk, string domainId = null)
        {
            if (IsNullOrEmpty(ak))
            {
                throw new ArgumentNullException(nameof(ak));
            }

            if (IsNullOrEmpty(sk))
            {
                throw new ArgumentNullException(nameof(sk));
            }

            this.Ak = ak;
            this.Sk = sk;
            this.DomainId = domainId;
        }

        public GlobalCredentials WithIamEndpoint(string endpoint)
        {
            IamEndpoint = endpoint;
            return this;
        }

        public GlobalCredentials WithSecurityToken(string token)
        {
            this.SecurityToken = token;
            return this;
        }

        /**
         * @param derivedPredicate optional property, judge whether to use the DerivedAKSKSigner
         * @return DerivedT with derived set
         */
        public GlobalCredentials WithDerivedPredicate(Func<HttpRequest, bool> func)
        {
            this.DerivedPredicate = func;
            return this;
        }

        protected bool IsDerivedAuth(HttpRequest httpRequest)
        {
            if (DerivedPredicate == null)
            {
                return false;
            }

            return DerivedPredicate(httpRequest);
        }

        public override void ProcessDerivedAuthParams(string derivedAuthServiceName, string regionId)
        {
            if (this._derivedAuthServiceName == null)
            {
                this._derivedAuthServiceName = derivedAuthServiceName;
            }

            if (this._regionId == null)
            {
                this._regionId = regionId;
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
            Task<HttpRequest> httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                if (DomainId != null)
                {
                    request.Headers.Add("X-Domain-Id", DomainId);
                }

                if (SecurityToken != null)
                {
                    request.Headers.Add("X-Security-Token", SecurityToken);
                }

                if (!IsNullOrEmpty(request.ContentType) && !request.ContentType.Contains("application/json"))
                {
                    request.Headers.Add("X-Sdk-Content-Sha256", "UNSIGNED-PAYLOAD");
                }

                if (IsDerivedAuth(request))
                {
                    var signer = new DerivedSigner
                    {
                        Key = Ak,
                        Secret = Sk
                    };
                    signer.Sign(request, _regionId, _derivedAuthServiceName);
                }
                else
                {
                    var signer = new Signer
                    {
                        Key = Ak,
                        Secret = Sk
                    };
                    signer.Sign(request);
                }

                return request;
            });

            return httpRequestTask;
        }

        public override Credentials ProcessAuthParams(SdkHttpClient client, string regionId)
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

            Func<HttpRequest, bool> derivedFunc = DerivedPredicate;
            DerivedPredicate = null;

            IamEndpoint = IsNullOrEmpty(IamEndpoint) ? IamService.DefaultIamEndpoint : IamEndpoint;
            var request = IamService.GetKeystoneListAuthDomainsRequest(IamEndpoint);
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
