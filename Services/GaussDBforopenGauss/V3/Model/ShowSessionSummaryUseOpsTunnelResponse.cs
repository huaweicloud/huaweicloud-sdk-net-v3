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
    public class ShowSessionSummaryUseOpsTunnelResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 活跃会话数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("active_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveCount { get; set; }

        /// <summary>
        /// **参数解释**: 会话总数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**: 最大SQL执行时间。单位：秒。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("max_query_time_cost", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxQueryTimeCost { get; set; }

        /// <summary>
        /// **参数解释**: 最大事务执行时间。单位：秒。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("max_transaction_time_cost", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTransactionTimeCost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSessionSummaryUseOpsTunnelResponse {\n");
            sb.Append("  activeCount: ").Append(ActiveCount).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  maxQueryTimeCost: ").Append(MaxQueryTimeCost).Append("\n");
            sb.Append("  maxTransactionTimeCost: ").Append(MaxTransactionTimeCost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSessionSummaryUseOpsTunnelResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSessionSummaryUseOpsTunnelResponse input)
        {
            if (input == null) return false;
            if (this.ActiveCount != input.ActiveCount || (this.ActiveCount != null && !this.ActiveCount.Equals(input.ActiveCount))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.MaxQueryTimeCost != input.MaxQueryTimeCost || (this.MaxQueryTimeCost != null && !this.MaxQueryTimeCost.Equals(input.MaxQueryTimeCost))) return false;
            if (this.MaxTransactionTimeCost != input.MaxTransactionTimeCost || (this.MaxTransactionTimeCost != null && !this.MaxTransactionTimeCost.Equals(input.MaxTransactionTimeCost))) return false;

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
                if (this.ActiveCount != null) hashCode = hashCode * 59 + this.ActiveCount.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.MaxQueryTimeCost != null) hashCode = hashCode * 59 + this.MaxQueryTimeCost.GetHashCode();
                if (this.MaxTransactionTimeCost != null) hashCode = hashCode * 59 + this.MaxTransactionTimeCost.GetHashCode();
                return hashCode;
            }
        }
    }
}
