using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 实例配置项
    /// </summary>
    public class QueryRedisConfig 
    {

        /// <summary>
        /// 配置参数值。
        /// </summary>
        [JsonProperty("param_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamValue { get; set; }

        /// <summary>
        /// 配置参数的值类型。
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }

        /// <summary>
        /// 配置参数的取值范围。
        /// </summary>
        [JsonProperty("value_range", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueRange { get; set; }

        /// <summary>
        /// 配置项的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 配置参数的默认值。
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 配置参数名称。
        /// </summary>
        [JsonProperty("param_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamName { get; set; }

        /// <summary>
        /// 配置参数ID。
        /// </summary>
        [JsonProperty("param_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParamId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRedisConfig {\n");
            sb.Append("  paramValue: ").Append(ParamValue).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("  valueRange: ").Append(ValueRange).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  paramName: ").Append(ParamName).Append("\n");
            sb.Append("  paramId: ").Append(ParamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRedisConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRedisConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParamValue == input.ParamValue ||
                    (this.ParamValue != null &&
                    this.ParamValue.Equals(input.ParamValue))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.ValueRange == input.ValueRange ||
                    (this.ValueRange != null &&
                    this.ValueRange.Equals(input.ValueRange))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.ParamName == input.ParamName ||
                    (this.ParamName != null &&
                    this.ParamName.Equals(input.ParamName))
                ) && 
                (
                    this.ParamId == input.ParamId ||
                    (this.ParamId != null &&
                    this.ParamId.Equals(input.ParamId))
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
                if (this.ParamValue != null)
                    hashCode = hashCode * 59 + this.ParamValue.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.ValueRange != null)
                    hashCode = hashCode * 59 + this.ValueRange.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.ParamName != null)
                    hashCode = hashCode * 59 + this.ParamName.GetHashCode();
                if (this.ParamId != null)
                    hashCode = hashCode * 59 + this.ParamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
