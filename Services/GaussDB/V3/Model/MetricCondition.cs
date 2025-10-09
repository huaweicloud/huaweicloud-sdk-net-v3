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
    public class MetricCondition 
    {

        /// <summary>
        /// **参数描述**:  指标名称。  **约束限制**：  不涉及。  **取值范围**： - cpuTotalUsage：CPU使用率。 - memoryTotalUsage：内存使用率。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// **参数描述**：  指标变配阈值。  **约束限制**：  取值为百分比的10000倍，比如50%对应的参数值为5000。  **取值范围**：  6000-8000。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("metric_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? MetricValue { get; set; }

        /// <summary>
        /// **参数描述**：  比较模式。  **约束限制**：  不涉及。。  **取值范围**：  GT：大于。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("compare_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricCondition {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  metricValue: ").Append(MetricValue).Append("\n");
            sb.Append("  compareMode: ").Append(CompareMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricCondition input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.MetricValue != input.MetricValue || (this.MetricValue != null && !this.MetricValue.Equals(input.MetricValue))) return false;
            if (this.CompareMode != input.CompareMode || (this.CompareMode != null && !this.CompareMode.Equals(input.CompareMode))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.MetricValue != null) hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                if (this.CompareMode != null) hashCode = hashCode * 59 + this.CompareMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
