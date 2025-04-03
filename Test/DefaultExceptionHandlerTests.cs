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

using System.Net;
using System.Net.Http;
using HuaweiCloud.SDK.Core;
using NUnit.Framework;

namespace Test
{
    public class DefaultExceptionHandlerTests
    {
        private static readonly IExceptionHandler ExceptionHandler = new DefaultExceptionHandler();

        [TestCase("{\"error_code\":\"XXX.0001\",\"error_msg\":\"Some errors occurred.\",\"encoded_authorization_message\":\"Egpjbi1ub*****GoxMzgrcA==\"}",
            400, "Egpjbi1ub*****GoxMzgrcA==", "XXX.0001", "Some errors occurred.", "97e2***11df")]
        [TestCase("{\"error\":{\"code\":\"XXX.0001\",\"message\":\"Some errors occurred.\",\"encoded_authorization_message\":\"Egpjbi1ub*****GoxMzgrcA==\"}}",
            400, "Egpjbi1ub*****GoxMzgrcA==", "XXX.0001", "Some errors occurred.", "97e2***11df")]
        [TestCase("{\"error\":{\"code\":\"XXX.0001\",\"message\":\"Some errors occurred.\"},\"error_code\":\"XXX.0001\",\"error_msg\":\"Some errors occurred.\",\"encoded_authorization_message\":\"Egpjbi1ub*****GoxMzgrcA==\"}",
            400, "Egpjbi1ub*****GoxMzgrcA==", "XXX.0001", "Some errors occurred.", "97e2***11df")]
        [TestCase("{\"invalid_key\":\"invalid_value\"}",
            400, null, null, "{\"invalid_key\":\"invalid_value\"}", "97e2***11df")]
        [TestCase("invalid json data",
            400, null, null, "invalid json data", "97e2***11df")]
        [TestCase("{\"error_code\":\"XXX.0001\",\"error_msg\":\"Some errors occurred.\",\"encoded_authorization_message\":null}",
            400, null, "XXX.0001", "Some errors occurred.", "97e2***11df")]
        public void TestHandleException(string errorMessage, int expectedStatusCode, string expectedEncodedAuthMsg, string expectedErrorCode, string expectedErrorMsg, string expectedRequestId)
        {
            var response = ProcessErrorResponse(errorMessage);
            try
            {
                ExceptionHandler.HandleException(null, response);
                Assert.Fail("expect ServiceResponseException");
            }
            catch (ServiceResponseException e)
            {
                Assert.Multiple(() =>
                {
                    Assert.That(e.HttpStatusCode, Is.EqualTo(expectedStatusCode));
                    Assert.That(e.EncodedAuthorizationMessage, Is.EqualTo(expectedEncodedAuthMsg));
                    Assert.That(e.ErrorCode, Is.EqualTo(expectedErrorCode));
                    Assert.That(e.ErrorMsg, Is.EqualTo(expectedErrorMsg));
                    Assert.That(e.RequestId, Is.EqualTo(expectedRequestId));
                    Assert.That(e.ToString(), Is.Not.Null);
                });
            }
        }

        private static HttpResponseMessage ProcessErrorResponse(string message)
        {
            var responseMessage = new HttpResponseMessage();
            responseMessage.StatusCode = HttpStatusCode.BadRequest;
            responseMessage.Content = new StringContent(message);
            responseMessage.Headers.TryAddWithoutValidation("X-Request-Id", "97e2***11df");
            return responseMessage;
        }
    }
}
