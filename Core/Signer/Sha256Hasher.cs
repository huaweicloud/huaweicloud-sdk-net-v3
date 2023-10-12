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

using System.Security.Cryptography;

namespace HuaweiCloud.SDK.Core
{
    internal class Sha256Hasher: AbstractHasher
    {
        internal override byte[] Hash(byte[] data)
        {
            SHA256 sha256 = new SHA256Managed();
            var bytes = sha256.ComputeHash(data);
            sha256.Clear();
            return bytes;
        }

        internal override byte[] Hmac(byte[] data, byte[] key)
        {
            using (var hMacSha256 = new HMACSHA256(key))
            {
                return hMacSha256.ComputeHash(data);
            }
        }
    }
}
