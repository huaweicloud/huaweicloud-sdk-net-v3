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
    /// Response Object
    /// </summary>
    public class ShowStatisticSecretKeyResponse : SdkResponse
    {

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 无效数量
        /// </summary>
        [JsonProperty("invalid_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? InvalidCount { get; set; }

        /// <summary>
        /// 有效数量
        /// </summary>
        [JsonProperty("valid_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ValidCount { get; set; }

        /// <summary>
        /// 密钥分布按服务类型统计
        /// </summary>
        [JsonProperty("key_counts_by_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<VendorKeyStatistic> KeyCountsByServiceType { get; set; }

        /// <summary>
        /// 密钥分布按算法统计
        /// </summary>
        [JsonProperty("key_counts_by_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public List<VendorKeyStatistic> KeyCountsByAlgorithm { get; set; }

        /// <summary>
        /// 密钥分布按算法和集群统计
        /// </summary>
        [JsonProperty("key_counts_by_algorithm_and_cluster", NullValueHandling = NullValueHandling.Ignore)]
        public List<VendorKeyStatistic> KeyCountsByAlgorithmAndCluster { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatisticSecretKeyResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  invalidCount: ").Append(InvalidCount).Append("\n");
            sb.Append("  validCount: ").Append(ValidCount).Append("\n");
            sb.Append("  keyCountsByServiceType: ").Append(KeyCountsByServiceType).Append("\n");
            sb.Append("  keyCountsByAlgorithm: ").Append(KeyCountsByAlgorithm).Append("\n");
            sb.Append("  keyCountsByAlgorithmAndCluster: ").Append(KeyCountsByAlgorithmAndCluster).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatisticSecretKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatisticSecretKeyResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.InvalidCount != input.InvalidCount || (this.InvalidCount != null && !this.InvalidCount.Equals(input.InvalidCount))) return false;
            if (this.ValidCount != input.ValidCount || (this.ValidCount != null && !this.ValidCount.Equals(input.ValidCount))) return false;
            if (this.KeyCountsByServiceType != input.KeyCountsByServiceType || (this.KeyCountsByServiceType != null && input.KeyCountsByServiceType != null && !this.KeyCountsByServiceType.SequenceEqual(input.KeyCountsByServiceType))) return false;
            if (this.KeyCountsByAlgorithm != input.KeyCountsByAlgorithm || (this.KeyCountsByAlgorithm != null && input.KeyCountsByAlgorithm != null && !this.KeyCountsByAlgorithm.SequenceEqual(input.KeyCountsByAlgorithm))) return false;
            if (this.KeyCountsByAlgorithmAndCluster != input.KeyCountsByAlgorithmAndCluster || (this.KeyCountsByAlgorithmAndCluster != null && input.KeyCountsByAlgorithmAndCluster != null && !this.KeyCountsByAlgorithmAndCluster.SequenceEqual(input.KeyCountsByAlgorithmAndCluster))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.InvalidCount != null) hashCode = hashCode * 59 + this.InvalidCount.GetHashCode();
                if (this.ValidCount != null) hashCode = hashCode * 59 + this.ValidCount.GetHashCode();
                if (this.KeyCountsByServiceType != null) hashCode = hashCode * 59 + this.KeyCountsByServiceType.GetHashCode();
                if (this.KeyCountsByAlgorithm != null) hashCode = hashCode * 59 + this.KeyCountsByAlgorithm.GetHashCode();
                if (this.KeyCountsByAlgorithmAndCluster != null) hashCode = hashCode * 59 + this.KeyCountsByAlgorithmAndCluster.GetHashCode();
                return hashCode;
            }
        }
    }
}
