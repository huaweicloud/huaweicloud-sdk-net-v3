/*
 * Copyright 2023 Huawei Technologies Co.,Ltd.
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

namespace HuaweiCloud.SDK.Core.Auth
{
    public class EnvCredentialProvider : ICredentialProvider
    {
        private const string AkEnvName = "HUAWEICLOUD_SDK_AK";
        private const string SkEnvName = "HUAWEICLOUD_SDK_SK";
        private const string ProjectIdEnvName = "HUAWEICLOUD_SDK_PROJECT_ID";
        private const string DomainIdEnvName = "HUAWEICLOUD_SDK_DOMAIN_ID";
        private const string SecurityTokenEnvName = "HUAWEICLOUD_SDK_SECURITY_TOKEN";

        private readonly string _credentialType;

        public EnvCredentialProvider(string credentialType)
        {
            _credentialType = credentialType.ToLower();
        }

        public static EnvCredentialProvider GetBasic()
        {
            return new EnvCredentialProvider(BasicCredentials.Type);
        }

        public static EnvCredentialProvider GetGlobal()
        {
            return new EnvCredentialProvider(GlobalCredentials.Type);
        }

        public ICredential GetCredentials()
        {
            if (string.IsNullOrEmpty(_credentialType))
            {
                throw new SdkException("credential type is empty");
            }

            var ak = Environment.GetEnvironmentVariable(AkEnvName);
            var sk = Environment.GetEnvironmentVariable(SkEnvName);
            var securityToken = Environment.GetEnvironmentVariable(SecurityTokenEnvName);

            if (string.IsNullOrEmpty(ak) || string.IsNullOrEmpty(sk))
            {
                throw new SdkException("ak or sk does not exist in environmental variables");
            }

            if (_credentialType.StartsWith(BasicCredentials.Type))
            {
                return new BasicCredentials(ak, sk, Environment.GetEnvironmentVariable(ProjectIdEnvName)).WithSecurityToken(securityToken);
            }
            else if (_credentialType.StartsWith(GlobalCredentials.Type))
            {
                return new GlobalCredentials(ak, sk, Environment.GetEnvironmentVariable(DomainIdEnvName)).WithSecurityToken(securityToken);
            }

            throw new SdkException("unsupported credential type: " + _credentialType);
        }
    }
}
