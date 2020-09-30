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
using System.Reflection;
using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Core
{
    public class EnumClassConverter<T> : JsonConverter
    {
        private readonly FieldInfo _value = typeof(T).GetField("Value", BindingFlags.Instance | BindingFlags.NonPublic);
        private readonly MethodInfo _methodGetValue = typeof(T).GetMethod("GetValue");
        private readonly MethodInfo _methodFromValue = typeof(T).GetMethod("FromValue");

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                var actualValue = _methodGetValue.Invoke(value, new object[] { });
                writer.WriteValue(actualValue);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            var actualValue = reader.Value;
            if (reader.ValueType != _value.FieldType)
            {
                actualValue = Convert.ChangeType(reader.Value, Nullable.GetUnderlyingType(_value.FieldType));
            }

            var obj = _methodFromValue.Invoke(null, new[] {actualValue});
            if (obj == null)
            {
                ConstructorInfo constructor = typeof(T).GetConstructor(new[] {_value.FieldType});
                obj = constructor.Invoke(new[] {actualValue});
            }

            return obj;
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}