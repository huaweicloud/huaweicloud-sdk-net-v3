using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigItem 
    {

        /// <summary>
        /// 配置项名称。
        /// </summary>
        [JsonProperty("config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigName { get; set; }

        /// <summary>
        /// 配置项值。
        /// </summary>
        [JsonProperty("config_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// 是否重写。
        /// </summary>
        [JsonProperty("should_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShouldOverride { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigItem {\n");
            sb.Append("  configName: ").Append(ConfigName).Append("\n");
            sb.Append("  configValue: ").Append(ConfigValue).Append("\n");
            sb.Append("  shouldOverride: ").Append(ShouldOverride).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigItem input)
        {
            if (input == null) return false;
            if (this.ConfigName != input.ConfigName || (this.ConfigName != null && !this.ConfigName.Equals(input.ConfigName))) return false;
            if (this.ConfigValue != input.ConfigValue || (this.ConfigValue != null && !this.ConfigValue.Equals(input.ConfigValue))) return false;
            if (this.ShouldOverride != input.ShouldOverride || (this.ShouldOverride != null && !this.ShouldOverride.Equals(input.ShouldOverride))) return false;

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
                if (this.ConfigName != null) hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                if (this.ConfigValue != null) hashCode = hashCode * 59 + this.ConfigValue.GetHashCode();
                if (this.ShouldOverride != null) hashCode = hashCode * 59 + this.ShouldOverride.GetHashCode();
                return hashCode;
            }
        }
    }
}
