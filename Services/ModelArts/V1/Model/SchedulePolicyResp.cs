using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业调度策略
    /// </summary>
    public class SchedulePolicyResp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("required_affinity", NullValueHandling = NullValueHandling.Ignore)]
        public RequiredAffinityResp RequiredAffinity { get; set; }

        /// <summary>
        /// **参数解释**：训练作业优先级。 **取值范围**：0-3
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释**：是否可以被抢占。 **取值范围**： - true：可以被抢占 - false：不可以被抢占
        /// </summary>
        [JsonProperty("preemptible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preemptible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulePolicyResp {\n");
            sb.Append("  requiredAffinity: ").Append(RequiredAffinity).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  preemptible: ").Append(Preemptible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchedulePolicyResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SchedulePolicyResp input)
        {
            if (input == null) return false;
            if (this.RequiredAffinity != input.RequiredAffinity || (this.RequiredAffinity != null && !this.RequiredAffinity.Equals(input.RequiredAffinity))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Preemptible != input.Preemptible || (this.Preemptible != null && !this.Preemptible.Equals(input.Preemptible))) return false;

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
                if (this.RequiredAffinity != null) hashCode = hashCode * 59 + this.RequiredAffinity.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Preemptible != null) hashCode = hashCode * 59 + this.Preemptible.GetHashCode();
                return hashCode;
            }
        }
    }
}
