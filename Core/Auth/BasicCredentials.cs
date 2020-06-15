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

namespace HuaweiCloud.SDK.Core.Auth
{
    public class BasicCredentials : ICredential
    {
        private readonly string _ak;
        private readonly string _sk;
        private readonly string _projectId;
        private readonly string _domainId;

        public BasicCredentials(string ak, string sk, string projectId, string domainId = null)
        {
            if (string.IsNullOrEmpty(ak))
            {
                throw new ArgumentNullException("AK can not be null.");
            }
            if (string.IsNullOrEmpty(sk))
            {
                throw new ArgumentNullException("SK cannot be null.");
            }
            
            this._ak = ak;
            this._sk = sk;
            this._projectId = projectId;
            this._domainId = domainId;
        }

        public Dictionary<string, string> GetPathParamDictionary()
        {
            var pathParamDictionary = new Dictionary<string, string>();
            if (_projectId != null)
            {
                pathParamDictionary.Add("project_id", _projectId);
            }
            if (_domainId != null)
            {
                pathParamDictionary.Add("domain_id", _domainId);
            }
            return pathParamDictionary;
        }

        public void SignAuthRequest(HttpRequest request)
        {
            var signer = new Signer {Key = _ak, Secret = _sk};

            if (_domainId != null)
            {
                request.Headers.Add("X-Domain-Id", _domainId);
            }

            if (_projectId != null)
            {
                request.Headers.Add("X-Project-Id", _projectId);
            }

            signer.Sign(request);
        }
    }
}