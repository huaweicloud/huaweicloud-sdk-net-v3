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
using System.IO;
using HuaweiCloud.SDK.Core;
using Newtonsoft.Json;

namespace Test.Model
{
    public class FormdataBody : IFormDataBody
    {
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart ImageFile { get; set; }

        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }

        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalFields { get; set; }

        [JsonProperty("single", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Single { get; set; }


        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("image_file", ImageFile);
            if (ExternalImageId != null)
            {
                formData.Add("external_image_id", new FormDataPart<string>(ExternalImageId));
            }
            if (ExternalFields != null)
            {
                formData.Add("external_fields", new FormDataPart<string>(ExternalFields));
            }
            if (Single != null)
            {
                formData.Add("single", new FormDataPart<bool?>(Single));
            }

            return formData;
        }

    }
}
