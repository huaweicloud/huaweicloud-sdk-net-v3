using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowStatusClusterItem 
    {

        /// <summary>
        /// 成功率
        /// </summary>
        [JsonProperty("success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? SuccessRate { get; set; }

        /// <summary>
        /// 失败率
        /// </summary>
        [JsonProperty("fail_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? FailRate { get; set; }

        /// <summary>
        /// 成功次数
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SuccessCount { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 平均值
        /// </summary>
        [JsonProperty("average_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageValue { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalValue { get; set; }

        /// <summary>
        /// 指标是否超出限制
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Limit { get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatusClusterItem {\n");
            sb.Append("  successRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  failRate: ").Append(FailRate).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  averageValue: ").Append(AverageValue).Append("\n");
            sb.Append("  totalValue: ").Append(TotalValue).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatusClusterItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatusClusterItem input)
        {
            if (input == null) return false;
            if (this.SuccessRate != input.SuccessRate || (this.SuccessRate != null && !this.SuccessRate.Equals(input.SuccessRate))) return false;
            if (this.FailRate != input.FailRate || (this.FailRate != null && !this.FailRate.Equals(input.FailRate))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.AverageValue != input.AverageValue || (this.AverageValue != null && !this.AverageValue.Equals(input.AverageValue))) return false;
            if (this.TotalValue != input.TotalValue || (this.TotalValue != null && !this.TotalValue.Equals(input.TotalValue))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ClusterName != input.ClusterName || (this.ClusterName != null && !this.ClusterName.Equals(input.ClusterName))) return false;

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
                if (this.SuccessRate != null) hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.FailRate != null) hashCode = hashCode * 59 + this.FailRate.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.AverageValue != null) hashCode = hashCode * 59 + this.AverageValue.GetHashCode();
                if (this.TotalValue != null) hashCode = hashCode * 59 + this.TotalValue.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterName != null) hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                return hashCode;
            }
        }
    }
}
