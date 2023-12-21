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

namespace HuaweiCloud.SDK.Core
{
    public class EnvRegionProvider : IRegionProvider
    {
        private const string EnvRegionPrefix = "HUAWEICLOUD_SDK_REGION";

        private readonly string _serviceName;

        public EnvRegionProvider(string serviceName)
        {
            _serviceName = serviceName.ToUpperInvariant();
        }

        public Region GetRegion(string regionId)
        {
            Region region;
            if (EnvRegionCache.Dict.TryGetValue(regionId, out region))
            {
                return region;
            }
            
            
            var envName = $"{EnvRegionPrefix}_{_serviceName}_{regionId.Replace('-', '_').ToUpperInvariant()}";
            var endpoint = Environment.GetEnvironmentVariable(envName);
            if (string.IsNullOrEmpty(endpoint))
            {
                return null;
            }

            var endpoints = endpoint.Split(',');
            region = new Region(regionId, endpoints);
            EnvRegionCache.Dict[_serviceName + regionId] = region;
            return region;
        }
    }
}
