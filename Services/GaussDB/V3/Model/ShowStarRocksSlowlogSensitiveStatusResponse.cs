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
    /// Response Object
    /// </summary>
    public class ShowStarRocksSlowlogSensitiveStatusResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**:  慢日志开关状态。  **取值范围**：  - true，开启。 - false，关闭。
        /// </summary>
        [JsonProperty("open_slow_log_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenSlowLogSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStarRocksSlowlogSensitiveStatusResponse {\n");
            sb.Append("  openSlowLogSwitch: ").Append(OpenSlowLogSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStarRocksSlowlogSensitiveStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStarRocksSlowlogSensitiveStatusResponse input)
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
