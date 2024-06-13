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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HuaweiCloud.SDK.Core
{
    public class AsyncInvoker<TResp> : BaseInvoker<AsyncInvoker<TResp>, TResp> where TResp : SdkResponse
    {
        public AsyncInvoker(Client client, string method, SdkRequest request, Func<HttpResponseMessage, TResp> deserializeMethod) : base(client, method, request, deserializeMethod)
        {
        }

        public async Task<TResp> Invoke()
        {
            if (MaxRetries == 0 || RetryCondition == null)
            {
                var responseMessage = await Client.DoHttpRequestAsync(Method, Request, SdkExchange);
                return DeserializeMethod.Invoke(responseMessage);
            }

            var execTimes = 0;
            TResp resp;
            SdkException exception;

            while (true)
            {
                try
                {
                    var responseMessage = await Client.DoHttpRequestAsync(Method, Request, SdkExchange);
                    resp = DeserializeMethod.Invoke(responseMessage);
                    exception = null;
                }
                catch (SdkException sdkException)
                {
                    exception = sdkException;
                    resp = null;
                }
                finally
                {
                    execTimes++;
                }

                if (execTimes > MaxRetries || !RetryCondition.Invoke(resp, exception))
                {
                    break;
                }
                
                var delay = BackoffStrategy.CalculateRetryDelayMillis(execTimes);
                if (delay > 0)
                {
                    Thread.Sleep(delay);
                }
            }

            if (exception != null)
            {
                throw exception;
            }
            return resp;
        }
    }
}
