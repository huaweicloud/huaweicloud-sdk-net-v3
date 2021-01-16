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
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.String;

namespace HuaweiCloud.SDK.Core
{
    public static class ExceptionUtils
    {
        private const string XRequestId = "X-Request-Id";

        public static ServiceResponseException GetException(HttpResponseMessage responseMessage)
        {
            var result = new SdkResponse
            {
                HttpStatusCode = (int) responseMessage.StatusCode,
                HttpHeaders = responseMessage.Headers.ToString(),
                HttpBody = responseMessage.Content.ReadAsStringAsync().Result
            };

            var requestId = "";
            if (responseMessage.Headers.Contains(XRequestId))
            {
                requestId = responseMessage.Headers.GetValues(XRequestId).FirstOrDefault();
            }

            SdkError sdkError;
            try
            {
                sdkError = GetSdkErrorFromResponse(requestId, result);
            }
            catch (Exception exception)
            {
                throw new ServerResponseException(result.HttpStatusCode,
                    new SdkError {ErrorMsg = exception.Message});
            }

            throw ServiceResponseException.MapException((int) responseMessage.StatusCode, sdkError);
        }

        private static SdkError GetSdkErrorFromResponse(string requestId, SdkResponse response)
        {
            SdkError sdkError;
            try
            {
                sdkError = JsonUtils.DeSerialize<SdkError>(response);
                if (IsNullOrEmpty(sdkError.ErrorCode) || IsNullOrEmpty(sdkError.ErrorMsg))
                {
                    sdkError = HandleServiceCommonException(response);
                }
            }
            catch (Exception)
            {
                sdkError = new SdkError();
            }

            if (IsNullOrEmpty(sdkError.ErrorMsg))
            {
                sdkError = HandleServiceSpecException(response);
            }

            if (IsNullOrEmpty(sdkError.RequestId))
            {
                sdkError.RequestId = requestId;
            }

            return sdkError;
        }

        private static SdkError HandleServiceSpecException(SdkResponse response)
        {
            return new SdkError();
        }

        private static SdkError HandleServiceCommonException(SdkResponse response)
        {
            var exception = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.HttpBody);
            if (exception.ContainsKey("code") && exception.ContainsKey("message"))
            {
                return new SdkError(exception["code"].ToString(), exception["message"].ToString());
            }

            foreach (var item in exception)
            {
                var jValue = JObject.Parse(item.Value.ToString());
                var message = jValue["message"];
                var code = jValue["code"];
                if (message != null && code != null)
                {
                    return new SdkError(code.ToString(), message.ToString());
                }
            }

            return new SdkError(response.HttpBody);
        }
    }
}