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
    /// **参数解释：** 集群限制检查状态 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
    /// </summary>
    public class ClusterCheckStatus 
    {

        /// <summary>
        /// **参数解释：** 状态 **约束限制：** 不涉及 **取值范围：** - Init：初始化 - Running：运行中 - Success：成功 - Failed：失败  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// **参数解释：** 检查项状态集合 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("itemsStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreCheckItemStatus> ItemsStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterCheckStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  itemsStatus: ").Append(ItemsStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterCheckStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterCheckStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.ItemsStatus != input.ItemsStatus || (this.ItemsStatus != null && input.ItemsStatus != null && !this.ItemsStatus.SequenceEqual(input.ItemsStatus))) return false;

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
                if (this.ItemsStatus != null) hashCode = hashCode * 59 + this.ItemsStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
