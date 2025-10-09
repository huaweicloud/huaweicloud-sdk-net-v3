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
    /// **参数描述**：  变配条件。  **约束限制**：  至少各定义一个CPU使用率和内存使用率指标条件，最多各定义两个。
    /// </summary>
    public class ScalingCondition 
    {

        /// <summary>
        /// **参数描述**:  变配条件名称。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字和中划线组成，且长度不超过32个字符，不能为空。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("condition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionId { get; set; }

        /// <summary>
        /// **参数描述**：  持续时间，单位是毫秒。  **约束限制**：  不涉及。  **取值范围**：  2000-5000。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// **参数解释**:  间隔时间，单位是毫秒。  **约束限制**：  不涉及。  **取值范围**：  1000-5000。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// **参数描述**:  指标变配条件。  **约束条件**：  不涉及。
        /// </summary>
        [JsonProperty("metric_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricCondition> MetricConditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingCondition {\n");
            sb.Append("  conditionId: ").Append(ConditionId).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  metricConditions: ").Append(MetricConditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingCondition input)
        {
            if (input == null) return false;
            if (this.ConditionId != input.ConditionId || (this.ConditionId != null && !this.ConditionId.Equals(input.ConditionId))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.MetricConditions != input.MetricConditions || (this.MetricConditions != null && input.MetricConditions != null && !this.MetricConditions.SequenceEqual(input.MetricConditions))) return false;

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
                if (this.ConditionId != null) hashCode = hashCode * 59 + this.ConditionId.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.MetricConditions != null) hashCode = hashCode * 59 + this.MetricConditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
