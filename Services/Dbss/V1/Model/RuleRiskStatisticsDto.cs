using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RuleRiskStatisticsDto 
    {

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// 实例数据库风险汇总
        /// </summary>
        [JsonProperty("instance_risk_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditInstanceRiskCount> InstanceRiskCount { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleRiskStatisticsDto {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  instanceRiskCount: ").Append(InstanceRiskCount).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleRiskStatisticsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleRiskStatisticsDto input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.InstanceRiskCount != input.InstanceRiskCount || (this.InstanceRiskCount != null && input.InstanceRiskCount != null && !this.InstanceRiskCount.SequenceEqual(input.InstanceRiskCount))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.InstanceRiskCount != null) hashCode = hashCode * 59 + this.InstanceRiskCount.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
