using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RocketMQConfigResp 
    {

        /// <summary>
        /// RocketMQ配置名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// RocketMQ配置当前值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// RocketMQ配置的类型
        /// </summary>
        [JsonProperty("config_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigType { get; set; }

        /// <summary>
        /// RocketMQ配置的默认值
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// RocketMQ配置取值的范围
        /// </summary>
        [JsonProperty("valid_values", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidValues { get; set; }

        /// <summary>
        /// RocketMQ配置值的类型
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RocketMQConfigResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  configType: ").Append(ConfigType).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  validValues: ").Append(ValidValues).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RocketMQConfigResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RocketMQConfigResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ConfigType == input.ConfigType ||
                    (this.ConfigType != null &&
                    this.ConfigType.Equals(input.ConfigType))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.ValidValues == input.ValidValues ||
                    (this.ValidValues != null &&
                    this.ValidValues.Equals(input.ValidValues))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ConfigType != null)
                    hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.ValidValues != null)
                    hashCode = hashCode * 59 + this.ValidValues.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                return hashCode;
            }
        }
    }
}
