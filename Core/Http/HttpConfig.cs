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

namespace HuaweiCloud.SDK.Core
{
    public class HttpConfig
    {
        public int? Timeout = 120;

        public bool IgnoreSslVerification;
        
        [Obsolete("This configuration has been deprecated and can be safely removed. Retaining it will not cause errors, but it also has no effect.")]
        public bool IgnoreBodyForGetRequest;

        /// <summary>
        /// Experimental configuration, the default value is false.
        /// Automatic redirection is allowed when turns on, which may cause some request exceptions.
        /// </summary>
        public bool AllowRedirects;

        public SigningAlgorithm SigningAlgorithm = Constants.DefaultSigningAlgorithm;

        public string ProxyUsername { get; set; }

        public string ProxyPassword { get; set; }

        public string ProxyDomain { get; set; }

        public string ProxyHost { get; set; }

        public int? ProxyPort { get; set; }

        public string UserAgent { get; set; }

        public static HttpConfig GetDefaultConfig()
        {
            return new HttpConfig();
        }

        public HttpConfig WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        public HttpConfig WithIgnoreSslVerification(bool ignore)
        {
            IgnoreSslVerification = ignore;
            return this;
        }
        
        [Obsolete("This configuration has been deprecated and can be safely removed. Retaining it will not cause errors, but it also has no effect.")]

        public HttpConfig WithIgnoreBodyForGetRequest(bool ignore)
        {
            IgnoreBodyForGetRequest = ignore;
            return this;
        }

        /// <summary>
        /// Experimental configuration, the default value is false.
        /// Automatic redirection is allowed when turns on, which may cause some request exceptions.
        /// </summary>
        public HttpConfig WithAllowRedirects(bool allowRedirects)
        {
            AllowRedirects = allowRedirects;
            return this;
        }

        public HttpConfig WithSigningAlgorithm(SigningAlgorithm signingAlgorithm)
        {
            SigningAlgorithm = signingAlgorithm;
            return this;
        }

        public HttpConfig WithIgnoreProxyUsername(string username)
        {
            ProxyUsername = username;
            return this;
        }

        public HttpConfig WithIgnoreProxyPassword(string password)
        {
            ProxyPassword = password;
            return this;
        }

        public HttpConfig WithProxyDomain(string domain)
        {
            ProxyDomain = domain;
            return this;
        }

        public HttpConfig WithProxyHost(string host)
        {
            ProxyHost = host;
            return this;
        }

        public HttpConfig WithProxyPort(int port)
        {
            ProxyPort = port;
            return this;
        }

        public HttpConfig WithUserAgent(string userAgent)
        {
            UserAgent = userAgent;
            return this;
        }
    }
}
