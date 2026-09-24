using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSqlRecommendRulesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 推荐规则列表。
        /// </summary>
        [JsonProperty("recommend_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListSqlRecommendRulesResponseResult> RecommendRules { get; set; }

        /// <summary>
        /// **参数解释**: 推荐总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSqlRecommendRulesResponse {\n");
            sb.Append("  recommendRules: ").Append(RecommendRules).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSqlRecommendRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSqlRecommendRulesResponse input)
        {
            if (input == null) return false;
            if (this.RecommendRules != input.RecommendRules || (this.RecommendRules != null && input.RecommendRules != null && !this.RecommendRules.SequenceEqual(input.RecommendRules))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.RecommendRules != null) hashCode = hashCode * 59 + this.RecommendRules.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
