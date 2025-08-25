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
using System.IO;
using HuaweiCloud.SDK.Core;
using NUnit.Framework;
using Test.Model;

namespace Test
{
    public class HttpUtilsTests
    {
        [Test]
        public void TestInitRequestWithQueryParams()
        {
            var sdkRequest = HttpUtils.InitSdkRequest("path", new QueryRequest());
            Assert.That(sdkRequest.QueryParams, Is.Null);

            var request = new QueryRequest
            {
                Limit = 10,
                Marker = "mark",
                Enable = true,
                Name = new List<string>
                {
                    "abc",
                    "def"
                },
                State = StateEnum.UNKNOWN,
                State2 = new List<StateEnum>
                {
                    StateEnum.SUCCESS,
                    StateEnum.FAILED
                },
                SortDir = SortDir.DEFAULT,
                SortDir2 = new List<SortDir>
                {
                    SortDir.DESC,
                    SortDir.ASC
                },
                Order = new List<int>
                {
                    1,
                    2
                }
            };

            sdkRequest = HttpUtils.InitSdkRequest("path", request);
            Console.WriteLine(sdkRequest.QueryParams);
            Assert.That(sdkRequest.QueryParams, Is.EqualTo(
                "limit=10&marker=mark&enable=true&sort_dir=default&state=unknown&name=abc&name=def&order=1&order=2&sort_dir2=desc&sort_dir2=asc&state2=success&state2=failed"));
        }

        [Test]
        public void TestInitRequestWithBodyAndHeaders()
        {
            var sdkRequest = HttpUtils.InitSdkRequest("path", new CommonRequest());
            Assert.Multiple(() =>
            {
                Assert.That(sdkRequest.Header, Is.Empty);
                Assert.That(sdkRequest.Body, Is.Null);
            });


            var request = new CommonRequest
            {
                Name = "name",
                Id = "id",
                Body = new Dictionary<string, object>
                {
                    {
                        "enable", true
                    },
                    {
                        "key", "value"
                    },
                    {
                        "count", 10
                    }
                }
            };
            sdkRequest = HttpUtils.InitSdkRequest("path", "application/json", request);
            Assert.Multiple(() =>
            {
                Assert.That(sdkRequest.Header["x-name"], Is.EqualTo("name"));
                Assert.That(sdkRequest.Header["x-id"], Is.EqualTo("id"));
                Assert.That(sdkRequest.Body, Is.EqualTo("{\"enable\":true,\"key\":\"value\",\"count\":10}"));
            });
        }

        [Test]
        public void TestInitRequestWithCname()
        {
            var sdkRequest = HttpUtils.InitSdkRequest("path", new CnameRequest());
            Assert.That(sdkRequest.Cname, Is.Null);

            var request = new CnameRequest
            {
                Name = "name"
            };
            sdkRequest = HttpUtils.InitSdkRequest("path", request);
            Assert.That(sdkRequest.Cname, Is.EqualTo("name"));
        }

        [Test]
        public void TestInitRequestWithFormdata()
        {
            var sdkRequest = HttpUtils.InitSdkRequest("path", "multipart/form-data", new FormdataRequest());
            Assert.Multiple(() =>
            {
                Assert.That(sdkRequest.Body, Is.Null);
                Assert.That(sdkRequest.FormData, Is.Null);
            });

            var stream = new MemoryStream();
            var body = new FormdataBody
            {
                ImageFile = new FormDataFilePart(stream, "tmp"),
                ExternalImageId = "id",
                Single = true
            };
            var request = new FormdataRequest
            {
                Body = body
            };

            sdkRequest = HttpUtils.InitSdkRequest("path", "multipart/form-data", request);
            stream.Close();
            Assert.Multiple(() =>
            {
                Assert.That(sdkRequest.Body, Is.Null);
                Assert.That(sdkRequest.FormData, Is.Not.Empty);
                Assert.That(sdkRequest.FormData, Has.Count.EqualTo(3));
            });
        }

        [Test]
        public void TestInitRequestWithStream()
        {
            var streamRequest = new SdkStreamRequest();
            streamRequest.FileStream = new MemoryStream();

            var sdkRequest = HttpUtils.InitSdkRequest("path", "application/octet-stream", streamRequest);
            streamRequest.FileStream.Close();
            Assert.That(sdkRequest.FileStream, Is.InstanceOf<MemoryStream>());
            
            streamRequest = new SdkStreamRequest();
            streamRequest.TransferProgress = (sender, status) => { };
            streamRequest.FileStream = new MemoryStream();

            sdkRequest = HttpUtils.InitSdkRequest("path", "application/octet-stream", streamRequest);
            streamRequest.FileStream.Close();
            Assert.That(sdkRequest.FileStream, Is.InstanceOf<TransferStream>());
        }
    }
}
