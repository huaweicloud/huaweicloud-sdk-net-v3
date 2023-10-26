/*
 * Copyright 2023 Huawei Technologies Co.,Ltd.
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

using System;
using System.Collections.Generic;
using System.Linq;

namespace HuaweiCloud.SDK.Core
{
    public class Region
    {


        public Region(string id, params string[] endpoints)
        {
            Id = id;
            Endpoints = endpoints.ToList();
        }

        public string Id { get; set; }

        [Obsolete("As of 3.1.26, because of the support of the multi-endpoint feature, use Endpoints instead")]
        public string Endpoint
        {
            get => Endpoints == null || Endpoints.Count == 0 ? null : Endpoints[0];
            set =>
                Endpoints = new List<string>
                {
                    value
                };
        }

        public List<string> Endpoints { get; set; }

        [Obsolete("As of 3.1.26, because of the support of the multi-endpoint feature, use WithEndpointsOverride instead")]
        public Region WithEndpointOverride(string newEndpoint)
        {
            return WithEndpointsOverride(new List<string>
            {
                newEndpoint
            });
        }

        public Region WithEndpointsOverride(List<string> endpoints)
        {
            Endpoints = endpoints;
            return this;
        }
    }
}
