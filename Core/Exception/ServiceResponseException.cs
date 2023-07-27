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

namespace HuaweiCloud.SDK.Core
{
    public class ServiceResponseException : SdkException
    {

        public ServiceResponseException(int? httpStatusCode, SdkError sdkError)
        {
            HttpStatusCode = httpStatusCode;
            ErrorCode = sdkError.ErrorCode;
            ErrorMsg = sdkError.ErrorMsg;
            RequestId = sdkError.RequestId;
            EncodedAuthorizationMessage = sdkError.EncodedAuthorizationMessage;
        }

        public int? HttpStatusCode { get; set; }

        public string ErrorMsg { get; set; }

        public string ErrorCode { get; set; }

        public string RequestId { get; set; }

        public string EncodedAuthorizationMessage { get; set; }

        public static ServiceResponseException MapException(int? httpStatusCode, SdkError sdkError)
        {
            if (httpStatusCode >= 400 && httpStatusCode < 500)
            {
                return new ClientRequestException(httpStatusCode, sdkError);
            }

            if (httpStatusCode >= 500 && httpStatusCode < 600)
            {
                return new ServerResponseException(httpStatusCode, sdkError);
            }

            return new ServiceResponseException(httpStatusCode, sdkError);
        }
    }
}
