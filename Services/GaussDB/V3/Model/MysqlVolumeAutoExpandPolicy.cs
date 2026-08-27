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
    public class MysqlVolumeAutoExpandPolicy 
    {

        /// <summary>
        /// **参数解释**：  存储自动扩容上限，需要为10的倍数，单位GB。  **约束限制**：  不涉及。  **取值范围**：  10-128000。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("limit_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitSize { get; set; }

        /// <summary>
        /// **参数解释**：  可用存储空间率。  **约束限制**：  不涉及。  **取值范围**：  - 1 - 5 - 10 - 15 - 20  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("trigger_available_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerAvailablePercent { get; set; }

        /// <summary>
        /// **参数解释**：  扩容步长百分比。  **约束限制**：  不涉及。  **取值范围**：  5-50。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("step_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlVolumeAutoExpandPolicy {\n");
            sb.Append("  limitSize: ").Append(LimitSize).Append("\n");
            sb.Append("  triggerAvailablePercent: ").Append(TriggerAvailablePercent).Append("\n");
            sb.Append("  stepPercent: ").Append(StepPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlVolumeAutoExpandPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlVolumeAutoExpandPolicy input)
        {
            if (input == null) return false;
            if (this.LimitSize != input.LimitSize || (this.LimitSize != null && !this.LimitSize.Equals(input.LimitSize))) return false;
            if (this.TriggerAvailablePercent != input.TriggerAvailablePercent || (this.TriggerAvailablePercent != null && !this.TriggerAvailablePercent.Equals(input.TriggerAvailablePercent))) return false;
            if (this.StepPercent != input.StepPercent || (this.StepPercent != null && !this.StepPercent.Equals(input.StepPercent))) return false;

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
                if (this.LimitSize != null) hashCode = hashCode * 59 + this.LimitSize.GetHashCode();
                if (this.TriggerAvailablePercent != null) hashCode = hashCode * 59 + this.TriggerAvailablePercent.GetHashCode();
                if (this.StepPercent != null) hashCode = hashCode * 59 + this.StepPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
