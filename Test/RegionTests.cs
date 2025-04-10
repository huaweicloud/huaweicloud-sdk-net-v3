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

using HuaweiCloud.SDK.Core;
using NUnit.Framework;

namespace Test
{
    public class RegionTests
    {
        [Test]
        public void TestNewRegionWithSingleEndpoint()
        {
            var region = new Region("id", "endpoint");
            Assert.That(region.Endpoints.Count, Is.EqualTo(1));
            Assert.That(region.Endpoints[0], Is.EqualTo("endpoint"));
        }

        [Test]
        public void TestNewRegionWithMultiEndpoints()
        {
            var region = new Region("id", "endpoint1", "endpoint2", "endpoint3");
            Assert.That(region.Endpoints.Count, Is.EqualTo(3));
            Assert.Multiple(() =>
            {
                Assert.That(region.Endpoints[0], Is.EqualTo("endpoint1"));
                Assert.That(region.Endpoints[1], Is.EqualTo("endpoint2"));
                Assert.That(region.Endpoints[2], Is.EqualTo("endpoint3"));
            });
        }
    }
}
