using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RenewResourceConfigReq 
    {
        /// <summary>
        /// |参数名称：续订资源设置属性类型| |参数的约束及描述：该参数必填，设置类型，支持枚举| |DEDUCTION_DATE：设置自动续费扣款日，EXPIRE_DATE：设置续费后资源统一到期日|
        /// </summary>
        /// <value>|参数名称：续订资源设置属性类型| |参数的约束及描述：该参数必填，设置类型，支持枚举| |DEDUCTION_DATE：设置自动续费扣款日，EXPIRE_DATE：设置续费后资源统一到期日|</value>
        [JsonConverter(typeof(EnumClassConverter<ConfigNameEnum>))]
        public class ConfigNameEnum
        {
            /// <summary>
            /// Enum DEDUCTION_DATE for value: DEDUCTION_DATE
            /// </summary>
            public static readonly ConfigNameEnum DEDUCTION_DATE = new ConfigNameEnum("DEDUCTION_DATE");

            /// <summary>
            /// Enum EXPIRE_DATE for value: EXPIRE_DATE
            /// </summary>
            public static readonly ConfigNameEnum EXPIRE_DATE = new ConfigNameEnum("EXPIRE_DATE");

            private static readonly Dictionary<string, ConfigNameEnum> StaticFields =
            new Dictionary<string, ConfigNameEnum>()
            {
                { "DEDUCTION_DATE", DEDUCTION_DATE },
                { "EXPIRE_DATE", EXPIRE_DATE },
            };

            private string _value;

            public ConfigNameEnum()
            {

            }

            public ConfigNameEnum(string value)
            {
                _value = value;
            }

            public static ConfigNameEnum FromValue(string value)
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

                if (this.Equals(obj as ConfigNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfigNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfigNameEnum a, ConfigNameEnum b)
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

            public static bool operator !=(ConfigNameEnum a, ConfigNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// |参数名称：续订资源设置属性类型| |参数的约束及描述：该参数必填，设置类型，支持枚举| |DEDUCTION_DATE：设置自动续费扣款日，EXPIRE_DATE：设置续费后资源统一到期日|
        /// </summary>
        [JsonProperty("config_name", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigNameEnum ConfigName { get; set; }
        /// <summary>
        /// |参数名称：续订资源设置属性值| |参数约束及描述：该参数必填，当config_name值为DEDUCTION_DATE时，支持设置资源到期前2天至前7天自动扣款，config_value范围：2，3，4，5，6，7。 当config_name值为EXPIRE_DATE时，支持设置统一到期日为每个月的同一天（1~28号及每个月最后一天），config_value范围：1，2，3，4，5，6，7，8，9，10，11，12，13，14，15，16，17，18，19，20，21，22，23，24，25，26，27，28，-1|
        /// </summary>
        [JsonProperty("config_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenewResourceConfigReq {\n");
            sb.Append("  configName: ").Append(ConfigName).Append("\n");
            sb.Append("  configValue: ").Append(ConfigValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RenewResourceConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RenewResourceConfigReq input)
        {
            if (input == null) return false;
            if (this.ConfigName != input.ConfigName) return false;
            if (this.ConfigValue != input.ConfigValue || (this.ConfigValue != null && !this.ConfigValue.Equals(input.ConfigValue))) return false;

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
                hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                if (this.ConfigValue != null) hashCode = hashCode * 59 + this.ConfigValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
