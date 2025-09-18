using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckPoint 
    {
        /// <summary>
        /// 响应提取时要使用什么方法处理参数
        /// </summary>
        /// <value>响应提取时要使用什么方法处理参数</value>
        [JsonConverter(typeof(EnumClassConverter<FunctionTypeEnum>))]
        public class FunctionTypeEnum
        {
            /// <summary>
            /// Enum REGEX for value: REGEX
            /// </summary>
            public static readonly FunctionTypeEnum REGEX = new FunctionTypeEnum("REGEX");

            /// <summary>
            /// Enum SUBSTRING for value: SUBSTRING
            /// </summary>
            public static readonly FunctionTypeEnum SUBSTRING = new FunctionTypeEnum("SUBSTRING");

            private static readonly Dictionary<string, FunctionTypeEnum> StaticFields =
            new Dictionary<string, FunctionTypeEnum>()
            {
                { "REGEX", REGEX },
                { "SUBSTRING", SUBSTRING },
            };

            private string _value;

            public FunctionTypeEnum()
            {

            }

            public FunctionTypeEnum(string value)
            {
                _value = value;
            }

            public static FunctionTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as FunctionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FunctionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FunctionTypeEnum a, FunctionTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(FunctionTypeEnum a, FunctionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 运算符
        /// </summary>
        [JsonProperty("comparison", NullValueHandling = NullValueHandling.Ignore)]
        public string Comparison { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 响应提取时要使用什么方法处理参数
        /// </summary>
        [JsonProperty("function_arg", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionArg { get; set; }

        /// <summary>
        /// 响应提取时要使用什么方法处理参数
        /// </summary>
        [JsonProperty("function_type", NullValueHandling = NullValueHandling.Ignore)]
        public FunctionTypeEnum FunctionType { get; set; }
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckPoint {\n");
            sb.Append("  comparison: ").Append(Comparison).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  functionArg: ").Append(FunctionArg).Append("\n");
            sb.Append("  functionType: ").Append(FunctionType).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckPoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckPoint input)
        {
            if (input == null) return false;
            if (this.Comparison != input.Comparison || (this.Comparison != null && !this.Comparison.Equals(input.Comparison))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FunctionArg != input.FunctionArg || (this.FunctionArg != null && !this.FunctionArg.Equals(input.FunctionArg))) return false;
            if (this.FunctionType != input.FunctionType) return false;
            if (this.Property != input.Property || (this.Property != null && !this.Property.Equals(input.Property))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Comparison != null) hashCode = hashCode * 59 + this.Comparison.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FunctionArg != null) hashCode = hashCode * 59 + this.FunctionArg.GetHashCode();
                hashCode = hashCode * 59 + this.FunctionType.GetHashCode();
                if (this.Property != null) hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
