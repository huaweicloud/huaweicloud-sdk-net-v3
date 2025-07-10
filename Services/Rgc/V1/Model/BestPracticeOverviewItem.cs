using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 最佳实践检测结果各个场景的概览。
    /// </summary>
    public class BestPracticeOverviewItem 
    {

        /// <summary>
        /// 分数
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Score { get; set; }

        /// <summary>
        /// 检测项个数
        /// </summary>
        [JsonProperty("detection_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DetectionCount { get; set; }

        /// <summary>
        /// 高风险项个数
        /// </summary>
        [JsonProperty("high_risk_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HighRiskCount { get; set; }

        /// <summary>
        /// 中风险项个数
        /// </summary>
        [JsonProperty("medium_risk_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MediumRiskCount { get; set; }

        /// <summary>
        /// 低风险项个数
        /// </summary>
        [JsonProperty("low_risk_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LowRiskCount { get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("risk_item_description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RiskItemDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BestPracticeOverviewItem {\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  detectionCount: ").Append(DetectionCount).Append("\n");
            sb.Append("  highRiskCount: ").Append(HighRiskCount).Append("\n");
            sb.Append("  mediumRiskCount: ").Append(MediumRiskCount).Append("\n");
            sb.Append("  lowRiskCount: ").Append(LowRiskCount).Append("\n");
            sb.Append("  riskItemDescription: ").Append(RiskItemDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BestPracticeOverviewItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BestPracticeOverviewItem input)
        {
            if (input == null) return false;
            if (this.Score != input.Score || (this.Score != null && !this.Score.Equals(input.Score))) return false;
            if (this.DetectionCount != input.DetectionCount || (this.DetectionCount != null && !this.DetectionCount.Equals(input.DetectionCount))) return false;
            if (this.HighRiskCount != input.HighRiskCount || (this.HighRiskCount != null && !this.HighRiskCount.Equals(input.HighRiskCount))) return false;
            if (this.MediumRiskCount != input.MediumRiskCount || (this.MediumRiskCount != null && !this.MediumRiskCount.Equals(input.MediumRiskCount))) return false;
            if (this.LowRiskCount != input.LowRiskCount || (this.LowRiskCount != null && !this.LowRiskCount.Equals(input.LowRiskCount))) return false;
            if (this.RiskItemDescription != input.RiskItemDescription || (this.RiskItemDescription != null && input.RiskItemDescription != null && !this.RiskItemDescription.SequenceEqual(input.RiskItemDescription))) return false;

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
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.DetectionCount != null) hashCode = hashCode * 59 + this.DetectionCount.GetHashCode();
                if (this.HighRiskCount != null) hashCode = hashCode * 59 + this.HighRiskCount.GetHashCode();
                if (this.MediumRiskCount != null) hashCode = hashCode * 59 + this.MediumRiskCount.GetHashCode();
                if (this.LowRiskCount != null) hashCode = hashCode * 59 + this.LowRiskCount.GetHashCode();
                if (this.RiskItemDescription != null) hashCode = hashCode * 59 + this.RiskItemDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
