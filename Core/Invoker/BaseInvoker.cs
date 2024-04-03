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
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCloud.SDK.Core
{
    public abstract class BaseInvoker<TInvoker, TResp> where TInvoker : BaseInvoker<TInvoker, TResp> where TResp : SdkResponse
    {
        protected readonly Client Client;
        protected readonly string Method;
        protected readonly SdkRequest Request;
        protected readonly Func<HttpResponseMessage, TResp> DeserializeMethod;

        public BaseInvoker(Client client, string method, SdkRequest request, Func<HttpResponseMessage, TResp> deserializeMethod)
        {
            Client = client;
            Method = method;
            Request = request;
            DeserializeMethod = deserializeMethod;
        }

        public TInvoker AddHeader(string key, string value)
        {
            Request.Header.Add(key, value);
            return (TInvoker)this;
        }

        public TInvoker ReplaceCredentialWhen(Func<ICredential, ICredential> function)
        {
            Client.WithCredential(function.Invoke(Client.GetCredential()));
            return (TInvoker)this;
        }
    }
}
