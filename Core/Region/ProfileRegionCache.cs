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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace HuaweiCloud.SDK.Core
{
    internal class ProfileRegionCache
    {
        private const string DefaultRegionsFileName = "regions.yaml";

        private const string RegionsFileEnv = "HUAWEICLOUD_SDK_REGIONS_FILE";

        private static readonly object Lock = new object();

        private static ConcurrentDictionary<string, Region> _instance;

        internal static ConcurrentDictionary<string, Region> GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = initInstance();
                    }
                }
            }
            return _instance;
        }

        private static ConcurrentDictionary<string, Region> initInstance()
        {
            var regionsFilePath = GetRegionsFilePath();
            if (string.IsNullOrEmpty(regionsFilePath) || !File.Exists(regionsFilePath))
            {
                return new ConcurrentDictionary<string, Region>();
            }

            var yaml = File.ReadAllText(regionsFilePath);
            var deserializer = new DeserializerBuilder().WithNamingConvention(UnderscoredNamingConvention.Instance).IgnoreUnmatchedProperties().Build();
            var serviceRegion = deserializer.Deserialize<Dictionary<string, List<RegionInfo>>>(yaml);

            var result = new ConcurrentDictionary<string, Region>();
            foreach (var pair in serviceRegion)
            {
                foreach (var regionInfo in pair.Value)
                {
                    if (string.IsNullOrEmpty(regionInfo.Id))
                    {
                        continue;
                    }

                    if (regionInfo.Endpoints != null && regionInfo.Endpoints.Count != 0)
                    {
                        result[pair.Key.ToUpperInvariant() + regionInfo.Id] = new Region(regionInfo.Id, regionInfo.Endpoints.ToArray());
                    }
                }
            }

            return result;
        }

        private static string GetUserHomePath()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            }

            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private static string GetRegionsFilePath()
        {
            var regionsFile = Environment.GetEnvironmentVariable(RegionsFileEnv);
            if (!string.IsNullOrEmpty(regionsFile))
            {
                return regionsFile;
            }

            var userHomePath = GetUserHomePath();
            return string.IsNullOrEmpty(userHomePath) ? null : Path.Combine(userHomePath, Constants.DefaultProfileDirName, DefaultRegionsFileName);
        }


        private class RegionInfo
        {
            public string Id { get; set; }
            public List<string> Endpoints { get; set; }
        }
    }
}
