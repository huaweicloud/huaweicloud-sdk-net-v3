/*
 * Copyright 2020 Huawei Technologies Co.,Ltd.
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
using System.IO;
using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Core
{
    public class FormDataFilePartConverter : JsonConverter<FormDataFilePart>
    {
        public override void WriteJson(JsonWriter writer, FormDataFilePart value, JsonSerializer serializer)
        {

        }

        public override FormDataFilePart ReadJson(JsonReader reader, Type objectType, FormDataFilePart existingValue, bool hasExistingValue, JsonSerializer serializer)
        {

            if (reader.Value != null && reader.Value is string path)
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException(path + " does not exist.");
                }

                var split = path.Split(Path.DirectorySeparatorChar);
                var filename = split[split.Length - 1];
                return new FormDataFilePart(File.OpenRead(path), filename);
            }
            return null;
        }
    }
}
