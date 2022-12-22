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

using System.Xml.Serialization;
using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Core
{
    [XmlRoot("Error")]
    public class SdkError : SdkResponse
    {
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Message")]
        public string ErrorMsg { get; set; }

        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Code")]
        public string ErrorCode;

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("RequestId")]
        public string RequestId;

        public SdkError()
        {
        }

        public SdkError(string errorCode, string errorMsg, string requestId)
        {
            this.ErrorCode = errorCode;
            this.ErrorMsg = errorMsg;
            this.RequestId = requestId;
        }
        
        public SdkError(string errorCode, string errorMsg)
        {
            this.ErrorCode = errorCode;
            this.ErrorMsg = errorMsg;
        }
        
        public SdkError(string errorMsg)
        {
            this.ErrorMsg = errorMsg;
        }
    }
}