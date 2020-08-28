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
using System.Reflection;
using System.Threading.Tasks;
using static System.String;

namespace HuaweiCloud.SDK.Core.Auth
{
    public abstract class Credentials
    {
        public abstract Dictionary<string, string> GetPathParamDictionary();

        public abstract Task<HttpRequest> SignAuthRequest(HttpRequest request);

        public static Credentials GetCredentialFromEnvironment<T>(string defaultCredentials) where T : Client
        {
            var credentialsTypeDef = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_TYPE");
            if (IsNullOrEmpty(credentialsTypeDef))
            {
                credentialsTypeDef = defaultCredentials;
            }

            var credentialsType = GetCredentialsType<T>(credentialsTypeDef);
            if (credentialsType == null)
            {
                return null;
            }

            var credentials = InitializeCredentials(credentialsType);
            credentials = LoadOptionalParams(credentials);

            return credentials;
        }

        private static Type GetCredentialsType<T>(string credentialType)
        {
            var credentialsType = Type.GetType($"HuaweiCloud.SDK.Core.Auth.{credentialType}");
            if (credentialsType == null)
            {
                credentialsType = Type.GetType($"{typeof(T).Namespace}.{credentialType}");
            }

            return credentialsType;
        }

        private static Credentials InitializeCredentials(Type credentialsType)
        {
            var constructors = credentialsType.GetConstructors();
            var paramInfos = constructors[0].GetParameters();
            var paramList = new List<Object>();
            foreach (var paramInfo in paramInfos)
            {
                paramList.Add(
                    Environment.GetEnvironmentVariable(
                        $"HUAWEICLOUD_SDK_{StringUtils.ToSnakeCase(paramInfo.Name).ToUpper()}"));
            }
            return (Credentials)Activator.CreateInstance(credentialsType, paramList.ToArray());
        }

        private static Credentials LoadOptionalParams(Credentials credentials)
        {
            const BindingFlags instanceBindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            foreach (var property in credentials.GetType().GetProperties(instanceBindFlags))
            {
                if (property.GetValue(credentials) == null)
                {
                    property.SetValue(credentials,Environment.GetEnvironmentVariable(
                        $"HUAWEICLOUD_SDK_{StringUtils.ToSnakeCase(property.Name).ToUpper()}")); 
                }
            }

            return credentials;
        }
    }
}