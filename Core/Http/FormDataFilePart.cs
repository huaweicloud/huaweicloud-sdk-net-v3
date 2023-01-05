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

using System.IO;
using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Core
{
    [JsonConverter(typeof(FormDataFilePartConverter))]
    public class FormDataFilePart : FormDataPart<Stream>
    {
        private readonly string _filename;

        private string _contentType;

        public FormDataFilePart(Stream stream, string filename) : base(stream)
        {
            _filename = filename;
        }

        public string GetFilename()
        {
            return _filename;
        }

        public FormDataFilePart WithContentType(string contentType)
        {
            _contentType = contentType;
            return this;
        }

        public string GetContentType()
        {
            return _contentType;
        }

        public Stream GetStream()
        {
            return GetValue();
        }
    }
}
