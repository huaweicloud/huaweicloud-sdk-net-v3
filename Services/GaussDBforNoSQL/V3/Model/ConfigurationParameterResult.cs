using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigurationParameterResult 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 是否需要重启。 - 取值为“false”，不需要重启。 - 取值为“true”，需要重启。
        /// </summary>
        [JsonProperty("restart_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartRequired { get; set; }

        /// <summary>
        /// 是否只读。 - 取值为“false”，非只读参数。 - 取值为“true”，只读参数。
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; }

        /// <summary>
        /// 参数值范围，如integer取值0-1、boolean取值true|false等。
        /// </summary>
        [JsonProperty("value_range", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueRange { get; set; }

        /// <summary>
        /// 参数类型，取值为“string”、“integer”、“boolean”、“list”或“float”之一。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 参数描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationParameterResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  restartRequired: ").Append(RestartRequired).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("  valueRange: ").Append(ValueRange).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationParameterResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationParameterResult input)
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
                    this.RestartRequired == input.RestartRequired ||
                    (this.RestartRequired != null &&
                    this.RestartRequired.Equals(input.RestartRequired))
                ) && 
                (
                    this.Readonly == input.Readonly ||
                    (this.Readonly != null &&
                    this.Readonly.Equals(input.Readonly))
                ) && 
                (
                    this.ValueRange == input.ValueRange ||
                    (this.ValueRange != null &&
                    this.ValueRange.Equals(input.ValueRange))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.RestartRequired != null)
                    hashCode = hashCode * 59 + this.RestartRequired.GetHashCode();
                if (this.Readonly != null)
                    hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                if (this.ValueRange != null)
                    hashCode = hashCode * 59 + this.ValueRange.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
