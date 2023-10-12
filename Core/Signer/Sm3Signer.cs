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

namespace HuaweiCloud.SDK.Core
{
    public class Sm3Signer : Signer
    {
        
        private static Sm3Signer _instance;
        
        private static readonly object Lock = new object();
        public new static Sm3Signer GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Sm3Signer();
                    }
                }
            }
            return _instance;
        }
        public Sm3Signer()
        {
            Algorithm = "SDK-HMAC-SM3";
            HeaderContent = "X-Sdk-Content-Sm3";
            EmptyHash = "1ab21d8355cfa17f8e61194831e81a8f22bec8c728fefb747ed035eb5082aa2b";
            Hasher = new Sm3Hasher();
        }
    }
}
