using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 合规统计结果
    /// </summary>
    public class PolicyStatesStatistics 
    {

        /// <summary>
        /// 资源总数
        /// </summary>
        [JsonProperty("total_resource_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalResourceCount { get; set; }

        /// <summary>
        /// 不合规资源数量
        /// </summary>
        [JsonProperty("non_compliant_resource_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NonCompliantResourceCount { get; set; }

        /// <summary>
        /// 合规规则总数
        /// </summary>
        [JsonProperty("total_policy_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPolicyCount { get; set; }

        /// <summary>
        /// 不合规规则数量
        /// </summary>
        [JsonProperty("non_compliant_policy_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NonCompliantPolicyCount { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [JsonProperty("statistic_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StatisticDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyStatesStatistics {\n");
            sb.Append("  totalResourceCount: ").Append(TotalResourceCount).Append("\n");
            sb.Append("  nonCompliantResourceCount: ").Append(NonCompliantResourceCount).Append("\n");
            sb.Append("  totalPolicyCount: ").Append(TotalPolicyCount).Append("\n");
            sb.Append("  nonCompliantPolicyCount: ").Append(NonCompliantPolicyCount).Append("\n");
            sb.Append("  statisticDate: ").Append(StatisticDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyStatesStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyStatesStatistics input)
        {
            if (input == null) return false;
            if (this.TotalResourceCount != input.TotalResourceCount || (this.TotalResourceCount != null && !this.TotalResourceCount.Equals(input.TotalResourceCount))) return false;
            if (this.NonCompliantResourceCount != input.NonCompliantResourceCount || (this.NonCompliantResourceCount != null && !this.NonCompliantResourceCount.Equals(input.NonCompliantResourceCount))) return false;
            if (this.TotalPolicyCount != input.TotalPolicyCount || (this.TotalPolicyCount != null && !this.TotalPolicyCount.Equals(input.TotalPolicyCount))) return false;
            if (this.NonCompliantPolicyCount != input.NonCompliantPolicyCount || (this.NonCompliantPolicyCount != null && !this.NonCompliantPolicyCount.Equals(input.NonCompliantPolicyCount))) return false;
            if (this.StatisticDate != input.StatisticDate || (this.StatisticDate != null && !this.StatisticDate.Equals(input.StatisticDate))) return false;

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
                if (this.TotalResourceCount != null) hashCode = hashCode * 59 + this.TotalResourceCount.GetHashCode();
                if (this.NonCompliantResourceCount != null) hashCode = hashCode * 59 + this.NonCompliantResourceCount.GetHashCode();
                if (this.TotalPolicyCount != null) hashCode = hashCode * 59 + this.TotalPolicyCount.GetHashCode();
                if (this.NonCompliantPolicyCount != null) hashCode = hashCode * 59 + this.NonCompliantPolicyCount.GetHashCode();
                if (this.StatisticDate != null) hashCode = hashCode * 59 + this.StatisticDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
