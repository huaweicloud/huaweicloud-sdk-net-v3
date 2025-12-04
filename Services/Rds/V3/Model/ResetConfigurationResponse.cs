using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ResetConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  参数组模板名称。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigName { get; set; }

        /// <summary>
        /// **参数解释**：  是否涉及重启。（当前该字段不使用，默认为false）  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("need_restart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedRestart { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetConfigurationResponse {\n");
            sb.Append("  configName: ").Append(ConfigName).Append("\n");
            sb.Append("  needRestart: ").Append(NeedRestart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.ConfigName != input.ConfigName || (this.ConfigName != null && !this.ConfigName.Equals(input.ConfigName))) return false;
            if (this.NeedRestart != input.NeedRestart || (this.NeedRestart != null && !this.NeedRestart.Equals(input.NeedRestart))) return false;

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
                if (this.NeedRestart != null) hashCode = hashCode * 59 + this.NeedRestart.GetHashCode();
                return hashCode;
            }
        }
    }
}
