﻿/*
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

namespace HuaweiCloud.SDK.Core
{
    public class HttpConfig
    {
        public int? Timeout = 120;

        public bool IgnoreSslVerification = false;

        public bool IgnoreBodyForGetRequest = false;

        public string ProxyUsername { get; set; }

        public string ProxyPassword { get; set; }

        public string ProxyDomain { get; set; }

        public string ProxyHost { get; set; }

        public int? ProxyPort { get; set; }

        public static HttpConfig GetDefaultConfig()
        {
            return new HttpConfig();
        }

        public HttpConfig WithTimeout(int timeout)
        {
            this.Timeout = timeout;
            return this;
        }

        public HttpConfig WithIgnoreSslVerification(bool ignore)
        {
            this.IgnoreSslVerification = ignore;
            return this;
        }

        public HttpConfig WithIgnoreBodyForGetRequest(bool ignore)
        {
            this.IgnoreBodyForGetRequest = ignore;
            return this;
        }

        public HttpConfig WithIgnoreProxyUsername(string username)
        {
            this.ProxyUsername = username;
            return this;
        }

        public HttpConfig WithIgnoreProxyPassword(string password)
        {
            this.ProxyPassword = password;
            return this;
        }

        public HttpConfig WithProxyDomain(string domain)
        {
            this.ProxyDomain = domain;
            return this;
        }

        public HttpConfig WithProxyHost(string host)
        {
            this.ProxyHost = host;
            return this;
        }

        public HttpConfig WithProxyPort(int port)
        {
            this.ProxyPort = port;
            return this;
        }
    }
}