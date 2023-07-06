using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据加工信息
    /// </summary>
    public class TransformationInfo 
    {
        /// <summary>
        /// - 生成加工规则值为contentConditionalFilter - 生成配置规则值为configConditionalFilter
        /// </summary>
        /// <value>- 生成加工规则值为contentConditionalFilter - 生成配置规则值为configConditionalFilter</value>
        [JsonConverter(typeof(EnumClassConverter<TransformationTypeEnum>))]
        public class TransformationTypeEnum
        {
            /// <summary>
            /// Enum CONTENTCONDITIONALFILTER for value: contentConditionalFilter
            /// </summary>
            public static readonly TransformationTypeEnum CONTENTCONDITIONALFILTER = new TransformationTypeEnum("contentConditionalFilter");

            /// <summary>
            /// Enum CONFIGCONDITIONALFILTER for value: configConditionalFilter
            /// </summary>
            public static readonly TransformationTypeEnum CONFIGCONDITIONALFILTER = new TransformationTypeEnum("configConditionalFilter");

            private static readonly Dictionary<string, TransformationTypeEnum> StaticFields =
            new Dictionary<string, TransformationTypeEnum>()
            {
                { "contentConditionalFilter", CONTENTCONDITIONALFILTER },
                { "configConditionalFilter", CONFIGCONDITIONALFILTER },
            };

            private string _value;

            public TransformationTypeEnum()
            {

            }

            public TransformationTypeEnum(string value)
            {
                _value = value;
            }

            public static TransformationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TransformationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TransformationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TransformationTypeEnum a, TransformationTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TransformationTypeEnum a, TransformationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// - 生成加工规则值为contentConditionalFilter - 生成配置规则值为configConditionalFilter
        /// </summary>
        [JsonProperty("transformation_type", NullValueHandling = NullValueHandling.Ignore)]
        public TransformationTypeEnum TransformationType { get; set; }
        /// <summary>
        /// 过滤条件，生成加工规则值为sql条件语句，生成配置规则值为config。长度限制256。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransformationInfo {\n");
            sb.Append("  transformationType: ").Append(TransformationType).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransformationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransformationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransformationType == input.TransformationType ||
                    (this.TransformationType != null &&
                    this.TransformationType.Equals(input.TransformationType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TransformationType != null)
                    hashCode = hashCode * 59 + this.TransformationType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
