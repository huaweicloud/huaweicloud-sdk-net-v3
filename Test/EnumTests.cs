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
using Newtonsoft.Json;
using NUnit.Framework;
using Test.Model;

namespace Test
{
    public class EnumTests
    {
        [Test]
        public void TestEnumSerialization()
        {
            var model = new ContainsEnumModel();
            Assert.That(JsonUtils.Serialize(model), Is.EqualTo("{\"required_sort_dir\":0}"));

            model.RequiredSortDir = SortDir.ASC;
            Assert.That(JsonUtils.Serialize(model), Is.EqualTo("{\"required_sort_dir\":\"asc\"}"));

            model.OptionalSortDir = SortDir.DESC;
            Assert.That(JsonUtils.Serialize(model), Is.EqualTo("{\"required_sort_dir\":\"asc\",\"optional_sort_dir\":\"desc\"}"));
        }

        [Test]
        public void TestEnumDeSerialization()
        {
            var model = JsonConvert.DeserializeObject<ContainsEnumModel>("{}");
            Assert.That(model.OptionalSortDir, Is.Null);

            model = JsonConvert.DeserializeObject<ContainsEnumModel>("{\"required_sort_dir\":\"asc\"}");
            Assert.Multiple(() =>
            {
                Assert.That(model.RequiredSortDir, Is.EqualTo(SortDir.ASC));
                Assert.That(model.OptionalSortDir, Is.Null);
            });

            model = JsonConvert.DeserializeObject<ContainsEnumModel>("{\"required_sort_dir\":\"asc\",\"optional_sort_dir\":\"desc\"}");
            Assert.Multiple(() =>
            {
                Assert.That(model.RequiredSortDir, Is.EqualTo(SortDir.ASC));
                Assert.That(model.OptionalSortDir, Is.EqualTo(SortDir.DESC));
            });
        }
    }
}
