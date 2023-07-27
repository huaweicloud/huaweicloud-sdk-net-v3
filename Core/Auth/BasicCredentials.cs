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

namespace HuaweiCloud.SDK.Core.Auth
{
    public class BasicCredentials : Credentials
    {
        private string _derivedAuthServiceName;
        private string _regionId;

        public BasicCredentials(string ak, string sk, string projectId = null)
        {
            if (string.IsNullOrEmpty(ak))
            {
                throw new ArgumentNullException(nameof(ak));
            }

            if (string.IsNullOrEmpty(sk))
            {
                throw new ArgumentNullException(nameof(sk));
            }

            Ak = ak;
            Sk = sk;
            ProjectId = projectId;
        }

        private string Ak { set; get; }
        private string Sk { set; get; }
        private string ProjectId { set; get; }
        private string SecurityToken { set; get; }
        private string IamEndpoint { set; get; }
        private Func<HttpRequest, bool> DerivedPredicate { set; get; }

        public BasicCredentials WithIamEndpoint(string endpoint)
        {
            IamEndpoint = endpoint;
            return this;
        }

        public BasicCredentials WithSecurityToken(string token)
        {
            SecurityToken = token;
            return this;
        }

        public BasicCredentials WithDerivedPredicate(Func<HttpRequest, bool> func)
        {
            DerivedPredicate = func;
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
            if (_derivedAuthServiceName == null)
            {
                _derivedAuthServiceName = derivedAuthServiceName;
            }

            if (_regionId == null)
            {
                _regionId = regionId;
            }
        }

        public override Dictionary<string, string> GetPathParamDictionary()
        {
            var pathParamDictionary = new Dictionary<string, string>();
            if (ProjectId != null)
            {
                pathParamDictionary.Add("project_id", ProjectId);
            }

            return pathParamDictionary;
        }

        public override Task<HttpRequest> SignAuthRequest(HttpRequest request)
        {
            var httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                if (ProjectId != null)
                {
                    request.Headers.Add("X-Project-Id", ProjectId);
                }

                if (SecurityToken != null)
                {
                    request.Headers.Add("X-Security-Token", SecurityToken);
                }

                if (!string.IsNullOrEmpty(request.ContentType) && !request.ContentType.Contains("application/json"))
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
            if (ProjectId != null)
            {
                return this;
            }

            var akWithName = Ak + regionId;
            var projectId = AuthCache.GetAuth(akWithName);
            if (!string.IsNullOrEmpty(projectId))
            {
                ProjectId = projectId;
                return this;
            }

            var derivedFunc = DerivedPredicate;
            DerivedPredicate = null;

            IamEndpoint = string.IsNullOrEmpty(IamEndpoint) ? IamService.DefaultIamEndpoint : IamEndpoint;
            var request = IamService.GetKeystoneListProjectsRequest(IamEndpoint, regionId);
            request = SignAuthRequest(request).Result;
            try
            {
                ProjectId = IamService.KeystoneListProjects(client, request);
                AuthCache.PutAuth(akWithName, ProjectId);
                DerivedPredicate = derivedFunc;
                return this;
            }
            catch (ServiceResponseException e)
            {
                throw new ArgumentException("Failed to get project id, " + e.ErrorMsg);
            }
        }
    }
}
