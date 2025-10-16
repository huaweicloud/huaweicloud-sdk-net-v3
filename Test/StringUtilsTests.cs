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
    public class StringUtilsTests
    {
        [TestCase("abcdefghijklmnopqrstuvwxyz123456", 0.7, '*', "abcde**********************23456")]
        [TestCase("123456", 0.8, '*', "1****6")]
        [TestCase("12345", 0.8, '*', "****5")]
        [TestCase("12345", 1, '*', "*****")]
        [TestCase("12345", 1.5, '*', "*****")]
        [TestCase("12345", 0, '*', "12345")]
        [TestCase("12345", -1, '*', "12345")]
        public void TestMask(string input, double ratio, char maskChar, string expected)
        {
            Assert.That(StringUtils.Mask(input, ratio, maskChar), Is.EqualTo(expected));
        }
    }
}
