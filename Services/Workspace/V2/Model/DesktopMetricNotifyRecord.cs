using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 对应指标维度产生的告警记录
    /// </summary>
    public class DesktopMetricNotifyRecord 
    {

        /// <summary>
        /// 满足通知规则阈值的桌面数
        /// </summary>
        [JsonProperty("match_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchCount { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 统计持续周期(天)
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 统计指标对应的统计值和threshold进行比较的条件 * &#x60;&gt;&#x3D;&#x60; -  统计指标大于等于threshold时触发 * &#x60;&gt;&#x60; -   统计指标大于threshold时触发 * &#x60;&#x3D;&#x60; -  统计指标等于threshold时触发 * &#x60;&lt;&#x3D;&#x60; -  统计指标小于等于threshold时触发 * &#x60;&lt;&#x60; -  统计指标小于threshold时触发
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopMetricNotifyRecord {\n");
            sb.Append("  matchCount: ").Append(MatchCount).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopMetricNotifyRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopMetricNotifyRecord input)
        {
            if (input == null) return false;
            if (this.MatchCount != input.MatchCount || (this.MatchCount != null && !this.MatchCount.Equals(input.MatchCount))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.ComparisonOperator != input.ComparisonOperator || (this.ComparisonOperator != null && !this.ComparisonOperator.Equals(input.ComparisonOperator))) return false;

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
                if (this.MatchCount != null) hashCode = hashCode * 59 + this.MatchCount.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.ComparisonOperator != null) hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                return hashCode;
            }
        }
    }
}
