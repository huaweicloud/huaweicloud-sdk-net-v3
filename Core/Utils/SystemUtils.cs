// Copyright 2025 Huawei Technologies Co.,Ltd.
// 
//  Licensed to the Apache Software Foundation (ASF) under one
//  or more contributor license agreements.  See the NOTICE file
//  distributed with this work for additional information
//  regarding copyright ownership.  The ASF licenses this file
//  to you under the Apache License, Version 2.0 (the
//  "License"); you may not use this file except in compliance
//  with the License.  You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

namespace HuaweiCloud.SDK.Core
{
    public static class SystemUtils
    {
        private const string AppFileName = "application_id";
        private const string UnknownArch = "unknown_arch";
        private static readonly object Lock = new object();
        private static string _envInfo;

        public static string GetEnvInfoString()
        {
            if (_envInfo == null)
            {
                lock (Lock)
                {
                    if (_envInfo == null)
                    {
                        _envInfo = ProcessEnvInfoString();
                    }
                }
            }
            return _envInfo;
        }

        private static class OS
        {
            public const string Windows = "Windows";
            public const string Linux = "Linux";
            public const string MacOS = "macOS";
        }

        private static string GetOsPlatform()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? OS.Windows :
                   RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? OS.Linux :
                   RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ? OS.MacOS : Environment.OSVersion.Platform.ToString();
        }

        private static string GetArchitecture()
        {
            var arch = RuntimeInformation.OSArchitecture.ToString();
            return !string.IsNullOrEmpty(arch) ? arch : UnknownArch;
        }

        private static string GetOsVersion()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? Environment.OSVersion.Version.ToString() : RuntimeInformation.OSDescription;
        }

        private static string GetOsInfo()
        {
            var os = $"{GetOsPlatform()}#{GetOsVersion()}#{GetArchitecture()}".Replace(' ', '_');
            var framework = RuntimeInformation.FrameworkDescription.Replace(' ', '_');
            var culture = CultureInfo.CurrentCulture.Name;
            
            return $"os/{os} csharp/{framework} meta/{culture}";
        }

        private static bool TryReadAppId(out string value)
        {
            value = null;
            try
            {
                var userHomePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                var appFilePath = Path.Combine(userHomePath, Constants.DefaultProfileDirName, AppFileName);
                if (File.Exists(appFilePath))
                {
                    value = File.ReadAllText(appFilePath);
                    return Guid.TryParse(value, out _);
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool TryGetAppId(out string value)
        {
            if (TryReadAppId(out var appId))
            {
                value = appId;
                return true;
            }

            if (TryGenerateAndStoreAppId(out appId))
            {
                value = appId;
                return true;
            }

            value = null;
            return false;
        }

        private static bool TryGetAppIdInfo(out string value)
        {
            if (TryGetAppId(out var appId))
            {
                value = "app/" + appId;
                return true;
            }

            value = null;
            return false;
        }

        private static bool TryGenerateAndStoreAppId(out string value)
        {
            var uuid = Guid.NewGuid().ToString();
            try
            {
                var userHomePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                var profileDir = Path.Combine(userHomePath, Constants.DefaultProfileDirName);
                if (!Directory.Exists(profileDir))
                {
                    Directory.CreateDirectory(profileDir);
                }
                var appFilePath = Path.Combine(profileDir, AppFileName);
                File.WriteAllText(appFilePath, uuid);
            }
            catch (Exception)
            {
                value = null;
                return false;
            }
            value = uuid;
            return true;
        }

        private static string ProcessEnvInfoString()
        {
            var uas = new List<string>
            {
                GetOsInfo()
            };
            if (TryGetAppIdInfo(out var info))
            {
                uas.Add(info);
            }

            return StringUtils.ReplaceNonAscii(string.Join("; ", uas), '_');
        }
    }
}
