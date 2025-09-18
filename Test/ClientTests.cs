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
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using NUnit.Framework;

namespace Test
{
    public class ClientTests
    {
        class TestClient : Client
        {
            public static ClientBuilder<TestClient> NewBuilder()
            {
                return new ClientBuilder<TestClient>();
            }

        }

        private class MockHttpHandler : HttpMessageHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                VerifyRequest(request);
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/json")
                };
            }

            protected virtual void VerifyRequest(HttpRequestMessage request)
            {
            }
        }

        private class DefaultUserAgentHandler : MockHttpHandler
        {
            protected override void VerifyRequest(HttpRequestMessage request)
            {
                const string prefix = "huaweicloud-usdk-net/3.0";
                var userAgent = request.Headers.UserAgent.ToString();
                Console.WriteLine("User-Agent: {0}", userAgent);
                if (!userAgent.StartsWith(prefix))
                {
                    throw new AssertionException($"User-Agent should starts with: {prefix}");
                }
                if (!userAgent.Contains("os/"))
                {
                    throw new AssertionException("User-Agent should contains: os/");
                }
                if (!userAgent.Contains("csharp/"))
                {
                    throw new AssertionException("User-Agent should contains: csharp/");
                }
            }
        }

        private class CustomUserAgentHandler : MockHttpHandler
        {
            protected override void VerifyRequest(HttpRequestMessage request)
            {
                const string expected = "huaweicloud-usdk-net/3.0; custom user-agent";
                if (!expected.Equals(request.Headers.UserAgent.ToString()))
                {
                    throw new AssertionException($"expected: {expected}, actual: {request.Headers.UserAgent}");
                }
            }
        }

        [Test]
        [Order(2)]
        public void TestDefaultUserAgent()
        {
            var client = TestClient.NewBuilder()
                .WithEndPoint("endpoint")
                .WithCredential(new BasicCredentials("ak", "sk", "project_id"))
                .Build();
            TestUtils.SetHttpMessageHandler(client, new DefaultUserAgentHandler());
            var urlPath = HttpUtils.AddUrlPath("/test-default-user-agent", new Dictionary<string, string>());
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", new object());
            var responseMessage = client.DoHttpRequestSync("GET", request);
            Assert.That(responseMessage.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(GetEnvInfoFromSystemUtils(), Is.Not.Null);
        }


        [Test]
        [Order(1)]
        public void TestCustomUserAgent()
        {
            var client = TestClient.NewBuilder()
                .WithEndPoint("endpoint")
                .WithCredential(new BasicCredentials("ak", "sk", "project_id"))
                .WithHttpConfig(HttpConfig.GetDefaultConfig().WithUserAgent("custom user-agent"))
                .Build();
            TestUtils.SetHttpMessageHandler(client, new CustomUserAgentHandler());
            var urlPath = HttpUtils.AddUrlPath("/test-custom-user-agent", new Dictionary<string, string>());
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", new object());
            var responseMessage = client.DoHttpRequestSync("GET", request);
            Assert.That(responseMessage.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(GetEnvInfoFromSystemUtils(), Is.Null);
        }

        private static string GetEnvInfoFromSystemUtils()
        {
            var envInfoField = typeof(SystemUtils).GetField("_envInfo", BindingFlags.NonPublic | BindingFlags.Static);
            return (string)envInfoField?.GetValue(null);
        }
    }
}
