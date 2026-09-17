using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** 集群升级流程的执行状态 **约束限制：** 当前仅支持Cancel **取值范围：** - Cancel：表示取消升级  **默认取值：** 不涉及
    /// </summary>
    public class UpgradeWorkFlowUpdateRequestBodyStatus 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public WorkFlowPhase? Phase { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeWorkFlowUpdateRequestBodyStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeWorkFlowUpdateRequestBodyStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeWorkFlowUpdateRequestBodyStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                return hashCode;
            }
        }
    }
}
