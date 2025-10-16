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
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;

namespace HuaweiCloud.SDK.Core
{
    public static class StringUtils
    {
        private const string LowerTrue = "true";
        private const string LowerFalse = "false";

        public static string ToSnakeCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x : x.ToString()))
                .ToLowerInvariant();
        }

        public static string UnderscoreToCamel(string str)
        {
            var item = str;
            while (item.IndexOf('_') >= 0)
            {
                var newUpper = item.Substring(item.IndexOf('_'), 2);
                item = item.Replace(newUpper, newUpper.Trim('_').ToUpperInvariant());
                str = str.Replace(newUpper, newUpper.Trim('_').ToUpperInvariant());
            }
            return str;
        }

        public static bool TryConvertToNonEmptyString(object value, out string result)
        {
            result = string.Empty;
            if (value is bool boolean)
            {
                result = boolean ? LowerTrue : LowerFalse;
                return true;
            }
            if (value is Enum enumValue)
            {
                var type = enumValue.GetType();
                var name = Enum.GetName(type, enumValue);
                if (name == null)
                {
                    return false;
                }

                var field = type.GetField(name);
                if (field == null)
                {
                    return false;
                }

                var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
                if (attribute == null)
                {
                    return false;
                }

                result = attribute.Value;
                return true;
            }

            result = Convert.ToString(value);
            return !string.IsNullOrEmpty(result);
        }

        public static string ReplaceNonAscii(string input, char replacement = ' ')
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var sb = new StringBuilder(input.Length);
            foreach (var c in input)
            {
                sb.Append(c <= 0x7F ? c : replacement);
            }
            return sb.ToString();
        }

        public static string Mask(string input, double maskRatio = 0.7, char maskChar = '*')
        {
            if (string.IsNullOrEmpty(input) || maskRatio <= 0)
            {
                return input;
            }

            if (maskRatio >= 1)
            {
                return new string(maskChar, input.Length);
            }

            var maskLength = (int)(input.Length * maskRatio);
            var start = Math.Max(0, (input.Length - maskLength) / 2);
            var end = Math.Min(input.Length, start + maskLength);
            var chars = input.ToCharArray();
            for (var i = start; i < end; i++)
            {
                chars[i] = maskChar;
            }
            return new string(chars);
        }
    }
}
