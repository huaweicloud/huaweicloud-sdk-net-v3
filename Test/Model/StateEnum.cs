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
using HuaweiCloud.SDK.Core;
using Newtonsoft.Json;

namespace Test.Model
{
    [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
    public class StateEnum
    {
        private string _value;
        public static readonly StateEnum FAILED = new StateEnum("failed");
        public static readonly StateEnum SUCCESS = new StateEnum("success");
        public static readonly StateEnum UNKNOWN = new StateEnum("unknown");

        private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                {
                    "failed", FAILED
                },
                {
                    "success", SUCCESS
                },
                {
                    "unknown", UNKNOWN
                }
            };


        public StateEnum()
        {
        }

        public StateEnum(string value)
        {
            _value = value;
        }

        public string GetValue()
        {
            return _value;
        }
        
        public static StateEnum FromValue(string value)
        {
            if(value == null){
                return null;
            }

            if (StaticFields.TryGetValue(value, out var val))
            {
                return val;
            }

            return null;
        }

        public override string ToString()
        {
            return $"{_value}";
        }
    }
}
