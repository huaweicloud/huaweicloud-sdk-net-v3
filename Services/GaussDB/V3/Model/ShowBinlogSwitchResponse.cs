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
    public class ShowBinlogSwitchResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  Binlog日志开关状态。   **取值范围**：  - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }

        /// <summary>
        /// **参数解释**：  Binlog日志保留天数。  **取值范围**：  1-180。如果为null表示未开启Binlog日志开关。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBinlogSwitchResponse {\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBinlogSwitchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBinlogSwitchResponse input)
        {
            if (input == null) return false;
            if (this.SwitchStatus != input.SwitchStatus || (this.SwitchStatus != null && !this.SwitchStatus.Equals(input.SwitchStatus))) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;

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
                if (this.SwitchStatus != null) hashCode = hashCode * 59 + this.SwitchStatus.GetHashCode();
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
