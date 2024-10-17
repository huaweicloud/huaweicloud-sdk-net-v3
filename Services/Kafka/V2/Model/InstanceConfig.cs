using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceConfig 
    {
        /// <summary>
        /// 配置类型：static/dynamic。
        /// </summary>
        /// <value>配置类型：static/dynamic。</value>
        [JsonConverter(typeof(EnumClassConverter<ConfigTypeEnum>))]
        public class ConfigTypeEnum
        {
            /// <summary>
            /// Enum STATIC for value: static
            /// </summary>
            public static readonly ConfigTypeEnum STATIC = new ConfigTypeEnum("static");

            /// <summary>
            /// Enum DYNAMIC for value: dynamic
            /// </summary>
            public static readonly ConfigTypeEnum DYNAMIC = new ConfigTypeEnum("dynamic");

            private static readonly Dictionary<string, ConfigTypeEnum> StaticFields =
            new Dictionary<string, ConfigTypeEnum>()
            {
                { "static", STATIC },
                { "dynamic", DYNAMIC },
            };

            private string _value;

            public ConfigTypeEnum()
            {

            }

            public ConfigTypeEnum(string value)
            {
                _value = value;
            }

            public static ConfigTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ConfigTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfigTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfigTypeEnum a, ConfigTypeEnum b)
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

            public static bool operator !=(ConfigTypeEnum a, ConfigTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 配置名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 有效值。
        /// </summary>
        [JsonProperty("valid_values", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidValues { get; set; }

        /// <summary>
        /// 默认值。
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 配置类型：static/dynamic。
        /// </summary>
        [JsonProperty("config_type", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigTypeEnum ConfigType { get; set; }
        /// <summary>
        /// 配置当前值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 值类型。
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceConfig {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  validValues: ").Append(ValidValues).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  configType: ").Append(ConfigType).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceConfig input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ValidValues != input.ValidValues || (this.ValidValues != null && !this.ValidValues.Equals(input.ValidValues))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.ConfigType != input.ConfigType) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.ValueType != input.ValueType || (this.ValueType != null && !this.ValueType.Equals(input.ValueType))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ValidValues != null) hashCode = hashCode * 59 + this.ValidValues.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ValueType != null) hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                return hashCode;
            }
        }
    }
}
