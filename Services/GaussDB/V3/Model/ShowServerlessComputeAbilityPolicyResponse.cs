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
    public class ShowServerlessComputeAbilityPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数描述**：  当前算力。  **取值范围**：  介于最大算力和最小算力之间。
        /// </summary>
        [JsonProperty("current_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  最小算力。  **取值范围**：  ≥0.5。
        /// </summary>
        [JsonProperty("min_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  最大算力。  **取值范围**：  ≥4。
        /// </summary>
        [JsonProperty("max_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxVcpus { get; set; }

        /// <summary>
        /// **参数解释**:  增删只读节点开关。  **取值范围**： - true: 开启增删只读节点。 - false: 关闭增删只读节点。
        /// </summary>
        [JsonProperty("scale_out_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScaleOutSwitch { get; set; }

        /// <summary>
        /// **参数解释**：  最大只读节点个数。  **取值范围**：  ≥2。
        /// </summary>
        [JsonProperty("max_readonly_node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReadonlyNodeCount { get; set; }

        /// <summary>
        /// **参数解释**：  最小只读节点个数。  **取值范围**：  ≥1。    
        /// </summary>
        [JsonProperty("min_readonly_node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinReadonlyNodeCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerlessComputeAbilityPolicyResponse {\n");
            sb.Append("  currentVcpus: ").Append(CurrentVcpus).Append("\n");
            sb.Append("  minVcpus: ").Append(MinVcpus).Append("\n");
            sb.Append("  maxVcpus: ").Append(MaxVcpus).Append("\n");
            sb.Append("  scaleOutSwitch: ").Append(ScaleOutSwitch).Append("\n");
            sb.Append("  maxReadonlyNodeCount: ").Append(MaxReadonlyNodeCount).Append("\n");
            sb.Append("  minReadonlyNodeCount: ").Append(MinReadonlyNodeCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerlessComputeAbilityPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerlessComputeAbilityPolicyResponse input)
        {
            if (input == null) return false;
            if (this.CurrentVcpus != input.CurrentVcpus || (this.CurrentVcpus != null && !this.CurrentVcpus.Equals(input.CurrentVcpus))) return false;
            if (this.MinVcpus != input.MinVcpus || (this.MinVcpus != null && !this.MinVcpus.Equals(input.MinVcpus))) return false;
            if (this.MaxVcpus != input.MaxVcpus || (this.MaxVcpus != null && !this.MaxVcpus.Equals(input.MaxVcpus))) return false;
            if (this.ScaleOutSwitch != input.ScaleOutSwitch || (this.ScaleOutSwitch != null && !this.ScaleOutSwitch.Equals(input.ScaleOutSwitch))) return false;
            if (this.MaxReadonlyNodeCount != input.MaxReadonlyNodeCount || (this.MaxReadonlyNodeCount != null && !this.MaxReadonlyNodeCount.Equals(input.MaxReadonlyNodeCount))) return false;
            if (this.MinReadonlyNodeCount != input.MinReadonlyNodeCount || (this.MinReadonlyNodeCount != null && !this.MinReadonlyNodeCount.Equals(input.MinReadonlyNodeCount))) return false;

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
                if (this.CurrentVcpus != null) hashCode = hashCode * 59 + this.CurrentVcpus.GetHashCode();
                if (this.MinVcpus != null) hashCode = hashCode * 59 + this.MinVcpus.GetHashCode();
                if (this.MaxVcpus != null) hashCode = hashCode * 59 + this.MaxVcpus.GetHashCode();
                if (this.ScaleOutSwitch != null) hashCode = hashCode * 59 + this.ScaleOutSwitch.GetHashCode();
                if (this.MaxReadonlyNodeCount != null) hashCode = hashCode * 59 + this.MaxReadonlyNodeCount.GetHashCode();
                if (this.MinReadonlyNodeCount != null) hashCode = hashCode * 59 + this.MinReadonlyNodeCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
