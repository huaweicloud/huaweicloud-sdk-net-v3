using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 企业配置。
    /// </summary>
    public class CorpConfigInfo 
    {

        /// <summary>
        /// 查询的配置configKey。
        /// </summary>
        [JsonProperty("config_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// 根据configKey查到的configValue。
        /// </summary>
        [JsonProperty("config_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorpConfigInfo {\n");
            sb.Append("  configKey: ").Append(ConfigKey).Append("\n");
            sb.Append("  configValue: ").Append(ConfigValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CorpConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CorpConfigInfo input)
        {
            if (input == null) return false;
            if (this.ConfigKey != input.ConfigKey || (this.ConfigKey != null && !this.ConfigKey.Equals(input.ConfigKey))) return false;
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
                if (this.ConfigKey != null) hashCode = hashCode * 59 + this.ConfigKey.GetHashCode();
                if (this.ConfigValue != null) hashCode = hashCode * 59 + this.ConfigValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
