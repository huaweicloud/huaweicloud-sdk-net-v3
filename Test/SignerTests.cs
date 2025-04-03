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
using System.Linq;
using System.Net;
using System.Text;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using NUnit.Framework;

namespace Test
{
    public class SignerTests
    {
        private const string Ak = "AccessKey";
        private const string Sk = "SecretKey";
        private const string XSdkDate = "20191115T033655Z";

        [Test]
        public void TestHmacSha256Signer_GetMethod()
        {
            var credentials = new BasicCredentials(Ak, Sk);
            var uri = new Uri("https://service.region.example.com/v1/77b6a44cba5143ab91d13ab9a8ff44fd/vpcs?limit=2&marker=13551d6b-755d-4757-b956-536f674975c0");
            var collection = new WebHeaderCollection
            {
                {
                    "X-Sdk-Date", XSdkDate
                },
                {
                    "TEST_UNDERSCORE", "TEST_VALUE"
                }
            };
            var request = new HttpRequest(url: uri, headers: collection);
            var signer = Signer.GetInstance();
            signer.Sign(request, credentials);
            Assert.That(request.Headers.Get("Authorization"),
                Is.EqualTo("SDK-HMAC-SHA256 Access=AccessKey, SignedHeaders=host;x-sdk-date, Signature=fd95e7da6f695cfb4cabbb9d6b0968aec155bc576b064835282473539ae9ea1d"));
        }

        [Test]
        public void TestHmacSha256Signer_PostMethod()
        {
            var credentials = new BasicCredentials(Ak, Sk);
            var uri = new Uri("https://service.region.example.com/v1/77b6a44cba5143ab91d13ab9a8ff44fd/vpc/123");
            var collection = new WebHeaderCollection
            {
                {
                    "X-Sdk-Date", XSdkDate
                },
                {
                    "TEST_UNDERSCORE", "TEST_VALUE"
                }
            };
            var request = new HttpRequest(method: "POST", url: uri, headers: collection, body: "{\"key\":\"value\"}");
            var signer = Signer.GetInstance();
            signer.Sign(request, credentials);
            Assert.That(request.Headers.Get("Authorization"),
                Is.EqualTo("SDK-HMAC-SHA256 Access=AccessKey, SignedHeaders=host;x-sdk-date, Signature=b5649aa774f6cac7437631662f08815fc65c70e40e486df6db2436ce68902771"));
        }
    }
}
