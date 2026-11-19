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
    public class ShowColdTableSwitchResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  冷热分离开关状态。  **取值范围**： - off：关闭。 - on：开启。
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }

        /// <summary>
        /// **参数解释**：  支持冷热分离的最低内核版本。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("kernel_version", NullValueHandling = NullValueHandling.Ignore)]
        public string KernelVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowColdTableSwitchResponse {\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("  kernelVersion: ").Append(KernelVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowColdTableSwitchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowColdTableSwitchResponse input)
        {
            if (input == null) return false;
            if (this.SwitchStatus != input.SwitchStatus || (this.SwitchStatus != null && !this.SwitchStatus.Equals(input.SwitchStatus))) return false;
            if (this.KernelVersion != input.KernelVersion || (this.KernelVersion != null && !this.KernelVersion.Equals(input.KernelVersion))) return false;

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
                if (this.KernelVersion != null) hashCode = hashCode * 59 + this.KernelVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
