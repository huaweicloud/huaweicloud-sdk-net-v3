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

using System.Collections.Generic;
using System.Reflection;
using HuaweiCloud.SDK.Core;
using NUnit.Framework;

namespace Test
{
    public class ClientBuilderTests
    {
        [Test]
        public void TestWithEndpoint()
        {
            var builder = new Client.ClientBuilder<Client>().WithEndPoint("endpoint");
            var type = builder.GetType();
            var fieldInfo = type.GetField("_endpoints", 
                BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.That(fieldInfo, Is.Not.Null);

            var value = (List<string>)fieldInfo.GetValue(builder);
            Assert.That(value, Has.Count.EqualTo(1));
            Assert.That(value[0], Is.EqualTo("endpoint"));
            
            builder = new Client.ClientBuilder<Client>().WithEndPoint("endpoint1", "endpoint2");
            value = (List<string>)fieldInfo.GetValue(builder);
            
            Assert.That(value, Has.Count.EqualTo(2));
            Assert.That(value[0], Is.EqualTo("endpoint1"));
            Assert.That(value[1], Is.EqualTo("endpoint2"));
        }
    }
}
