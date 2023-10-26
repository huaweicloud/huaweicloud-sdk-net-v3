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
using System.Collections.Generic;

namespace HuaweiCloud.SDK.Core.Auth
{
    public class CredentialProviderChain : ICredentialProvider
    {
        private readonly ICredentialProvider[] _providers;

        public CredentialProviderChain(ICredentialProvider[] providers)
        {
            _providers = providers;
        }

        public static CredentialProviderChain GetDefault(string credentialType)
        {
            var credentialProviders = new ICredentialProvider[]
            {
                new EnvCredentialProvider(credentialType),
                new ProfileCredentialProvider(credentialType)
            };

            return new CredentialProviderChain(credentialProviders);
        }

        public static CredentialProviderChain GetBasic()
        {
            return GetDefault(BasicCredentials.Type);
        }

        public static CredentialProviderChain GetGlobal()
        {
            return GetDefault(GlobalCredentials.Type);
        }

        public ICredential GetCredentials()
        {
            var exceptions = new List<SdkException>();
            foreach (var provider in _providers)
            {
                try
                {
                    var credentials = provider.GetCredentials();
                    if (credentials != null)
                    {
                        return credentials;
                    }
                }
                catch (SdkException e)
                {
                    exceptions.Add(e);
                }
            }

            throw new SdkException("failed to get credentials in providers", new AggregateException(exceptions));
        }
    }
}
