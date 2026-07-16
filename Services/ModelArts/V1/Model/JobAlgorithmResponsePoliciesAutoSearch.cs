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
    /// 超参搜索配置。
    /// </summary>
    public class JobAlgorithmResponsePoliciesAutoSearch 
    {

        /// <summary>
        /// 需要排除的超参组合。
        /// </summary>
        [JsonProperty("skip_search_params", NullValueHandling = NullValueHandling.Ignore)]
        public string SkipSearchParams { get; set; }

        /// <summary>
        /// 搜索指标列表。
        /// </summary>
        [JsonProperty("reward_attrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobAlgorithmResponsePoliciesAutoSearchRewardAttrs> RewardAttrs { get; set; }

        /// <summary>
        /// 搜索参数。
        /// </summary>
        [JsonProperty("search_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobAlgorithmResponsePoliciesAutoSearchSearchParams> SearchParams { get; set; }

        /// <summary>
        /// 搜索算法配置。
        /// </summary>
        [JsonProperty("algo_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobAlgorithmResponsePoliciesAutoSearchAlgoConfigs> AlgoConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobAlgorithmResponsePoliciesAutoSearch {\n");
            sb.Append("  skipSearchParams: ").Append(SkipSearchParams).Append("\n");
            sb.Append("  rewardAttrs: ").Append(RewardAttrs).Append("\n");
            sb.Append("  searchParams: ").Append(SearchParams).Append("\n");
            sb.Append("  algoConfigs: ").Append(AlgoConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobAlgorithmResponsePoliciesAutoSearch);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobAlgorithmResponsePoliciesAutoSearch input)
        {
            if (input == null) return false;
            if (this.SkipSearchParams != input.SkipSearchParams || (this.SkipSearchParams != null && !this.SkipSearchParams.Equals(input.SkipSearchParams))) return false;
            if (this.RewardAttrs != input.RewardAttrs || (this.RewardAttrs != null && input.RewardAttrs != null && !this.RewardAttrs.SequenceEqual(input.RewardAttrs))) return false;
            if (this.SearchParams != input.SearchParams || (this.SearchParams != null && input.SearchParams != null && !this.SearchParams.SequenceEqual(input.SearchParams))) return false;
            if (this.AlgoConfigs != input.AlgoConfigs || (this.AlgoConfigs != null && input.AlgoConfigs != null && !this.AlgoConfigs.SequenceEqual(input.AlgoConfigs))) return false;

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
                if (this.SkipSearchParams != null) hashCode = hashCode * 59 + this.SkipSearchParams.GetHashCode();
                if (this.RewardAttrs != null) hashCode = hashCode * 59 + this.RewardAttrs.GetHashCode();
                if (this.SearchParams != null) hashCode = hashCode * 59 + this.SearchParams.GetHashCode();
                if (this.AlgoConfigs != null) hashCode = hashCode * 59 + this.AlgoConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
