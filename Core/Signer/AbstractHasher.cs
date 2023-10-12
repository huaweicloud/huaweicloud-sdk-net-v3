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
    internal abstract class AbstractHasher
    {

        internal abstract byte[] Hash(byte[] data);

        internal abstract byte[] Hmac(byte[] data, byte[] key);

        internal static string ToHexString(byte[] value)
        {
            var num = value.Length * 2;
            var array = new char[num];
            var num2 = 0;
            for (var i = 0; i < num; i += 2)
            {
                var b = value[num2++];
                array[i] = GetHexValue(b / 16);
                array[i + 1] = GetHexValue(b % 16);
            }

            return new string(array, 0, num);
        }

        private static char GetHexValue(int i)
        {
            if (i < 10)
            {
                return (char)(i + '0');
            }

            return (char)(i - 10 + 'a');
        }



        internal string HashHexString(byte[] data)
        {
            return ToHexString(Hash(data));
        }

        internal string HmacHexString(byte[] data, byte[] key)
        {
            return ToHexString(Hmac(data, key));
        }
    }
}
