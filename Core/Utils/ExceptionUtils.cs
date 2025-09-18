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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.String;

namespace HuaweiCloud.SDK.Core
{
    public static class ExceptionUtils
    {
        private const string XRequestId = "X-Request-Id";
        private const string EncodedAuthorizationMessage = "encoded_authorization_message";
        private const string ErrorCode = "error_code";
        private const string ErrorMsg = "error_msg";
        private const string Code = "code";
        private const string Message = "message";

        public static string GetMessageFromAggregateException(AggregateException aggregateException)
        {
            var messages = new StringBuilder();
            messages.AppendLine(aggregateException.Message);
            foreach (var innerException in aggregateException.InnerExceptions)
            {
                messages.AppendLine(innerException.Message);
            }
            return messages.ToString();
        }

        public static SdkException HandleException(Exception exception)
        {
            if (exception is AggregateException)
            {
                if (exception.InnerException is SdkException sdkException)
                {
                    return sdkException;
                }

                if (exception.InnerException is HttpRequestException httpRequestException)
                {
                    if (httpRequestException.InnerException == null)
                    {
                        return new ConnectionException(httpRequestException.Message, exception);
                    }

                    if (httpRequestException.InnerException is WebException webException)
                    {
                        switch (webException.Status)
                        {
                            case WebExceptionStatus.NameResolutionFailure:
                                return new HostUnreachableException(webException.Message, exception);
                            case WebExceptionStatus.TrustFailure:
                                return new SslHandShakeException(webException.Message, exception);
                            case WebExceptionStatus.Timeout:
                                return new RequestTimeoutException(webException.Message, exception);
                            default:
                                return new ConnectionException(webException.Message, exception);
                        }
                    }
                }

                if (exception.InnerException != null)
                {
                    return new SdkException(exception.InnerException.Message, exception.InnerException);
                }
            }
            return new SdkException(exception.Message, exception);
        }

        public static ServiceResponseException GetException(HttpResponseMessage responseMessage)
        {
            var result = new SdkResponse
            {
                HttpStatusCode = (int)responseMessage.StatusCode,
                HttpHeaders = responseMessage.Headers.ToString(),
                HttpBody = Encoding.UTF8.GetString(responseMessage.Content.ReadAsByteArrayAsync().Result)
            };

            var requestId = string.Empty;
            if (responseMessage.Headers.Contains(XRequestId))
            {
                requestId = responseMessage.Headers.GetValues(XRequestId).FirstOrDefault();
            }

            SdkError sdkError;
            try
            {
                sdkError = responseMessage.Content.Headers.ContentType.MediaType.Equals("application/xml")
                               ? XmlUtils.DeSerialize<SdkError>(result)
                               : GetSdkErrorFromResponse(requestId, result);
            }
            catch (Exception exception)
            {
                throw new ServerResponseException(result.HttpStatusCode,
                    new SdkError
                    {
                        ErrorMsg = exception.Message
                    });
            }

            throw ServiceResponseException.MapException((int)responseMessage.StatusCode, sdkError);
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
            catch (JsonReaderException)
            {
                sdkError = new SdkError(response.HttpBody);
            }
            catch (Exception e)
            {
                sdkError = new SdkError(e.Message);
            }

            if (IsNullOrEmpty(sdkError.ErrorMsg))
            {
                sdkError = new SdkError(response.HttpBody);
            }

            if (IsNullOrEmpty(sdkError.RequestId))
            {
                sdkError.RequestId = requestId;
            }

            return sdkError;
        }

        private static void ProcessSdkError(JObject jObject, SdkError sdkError)
        {
            if (jObject.TryGetValue(EncodedAuthorizationMessage, out var encodedMsg))
            {
                sdkError.EncodedAuthorizationMessage = encodedMsg.ToString();
            }

            if (jObject.TryGetValue(ErrorCode, out var errCode) && jObject.TryGetValue(ErrorMsg, out var errMsg))
            {
                sdkError.ErrorCode = errCode.ToString();
                sdkError.ErrorMsg = errMsg.ToString();
                return;
            }

            if (jObject.TryGetValue(Code, out errCode) && jObject.TryGetValue(Message, out errMsg))
            {
                sdkError.ErrorCode = errCode.ToString();
                sdkError.ErrorMsg = errMsg.ToString();
                return;
            }

            foreach (var pair in jObject)
            {
                if (pair.Value is JObject value)
                {
                    ProcessSdkError(value, sdkError);
                }
            }
        }

        private static SdkError HandleServiceCommonException(SdkResponse response)
        {
            var errorDict = JsonConvert.DeserializeObject<JObject>(response.HttpBody);
            if (errorDict == null)
            {
                return new SdkError(response.HttpBody);
            }

            var sdkError = new SdkError();
            ProcessSdkError(errorDict, sdkError);
            if (sdkError.ErrorMsg == null)
            {
                sdkError.ErrorMsg = response.HttpBody;
            }
            return sdkError;
        }
    }
}
