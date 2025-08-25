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
    public class QueryRequest
    {
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        [SDKProperty("enable", IsQuery = true)]
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public SortDir SortDir { get; set; }
        
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }

        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }
        
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Order { get; set; }
        
        [SDKProperty("sort_dir2", IsQuery = true)]
        [JsonProperty("sort_dir2", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortDir> SortDir2 { get; set; }
        
        [SDKProperty("state2", IsQuery = true)]
        [JsonProperty("state2", NullValueHandling = NullValueHandling.Ignore)]
        public List<StateEnum> State2 { get; set; }
    }
}
