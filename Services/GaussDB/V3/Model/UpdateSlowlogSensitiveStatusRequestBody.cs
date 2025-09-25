using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateSlowlogSensitiveStatusRequestBody 
    {

        /// <summary>
        /// **参数解释**：  慢日志开关状态。  **约束限制**：  不涉及。  **取值范围**： - true，开启。 - false，关闭。            **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("open_slow_log_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenSlowLogSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSlowlogSensitiveStatusRequestBody {\n");
            sb.Append("  openSlowLogSwitch: ").Append(OpenSlowLogSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSlowlogSensitiveStatusRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSlowlogSensitiveStatusRequestBody input)
        {
            if (input == null) return false;
            if (this.OpenSlowLogSwitch != input.OpenSlowLogSwitch || (this.OpenSlowLogSwitch != null && !this.OpenSlowLogSwitch.Equals(input.OpenSlowLogSwitch))) return false;

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
                if (this.OpenSlowLogSwitch != null) hashCode = hashCode * 59 + this.OpenSlowLogSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
