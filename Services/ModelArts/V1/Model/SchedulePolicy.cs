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
    public class SchedulePolicy 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("required_affinity", NullValueHandling = NullValueHandling.Ignore)]
        public RequiredAffinity RequiredAffinity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("preferred_affinity", NullValueHandling = NullValueHandling.Ignore)]
        public PreferredAffinity PreferredAffinity { get; set; }

        /// <summary>
        /// **参数解释**：训练作业优先级。 **约束限制**： - 仅使用专属资源池训练时才支持设置训练作业优先级。 - 作业优先级取值为1~3，默认优先级为1，最高优先级为3。 默认用户权限可选择优先级1和2，配置了“设置作业为高优先级权限”的用户可选择优先级1~3。  **取值范围**：0-3 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释**：是否可以被抢占。 **约束限制**：不涉及。 **取值范围**： - true：可以被抢占 - false：不可以被抢占  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("preemptible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preemptible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulePolicy {\n");
            sb.Append("  requiredAffinity: ").Append(RequiredAffinity).Append("\n");
            sb.Append("  preferredAffinity: ").Append(PreferredAffinity).Append("\n");
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
            return this.Equals(input as SchedulePolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SchedulePolicy input)
        {
            if (input == null) return false;
            if (this.RequiredAffinity != input.RequiredAffinity || (this.RequiredAffinity != null && !this.RequiredAffinity.Equals(input.RequiredAffinity))) return false;
            if (this.PreferredAffinity != input.PreferredAffinity || (this.PreferredAffinity != null && !this.PreferredAffinity.Equals(input.PreferredAffinity))) return false;
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
                if (this.PreferredAffinity != null) hashCode = hashCode * 59 + this.PreferredAffinity.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Preemptible != null) hashCode = hashCode * 59 + this.Preemptible.GetHashCode();
                return hashCode;
            }
        }
    }
}
