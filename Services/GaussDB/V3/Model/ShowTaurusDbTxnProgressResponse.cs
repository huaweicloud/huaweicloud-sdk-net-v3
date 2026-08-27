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
    /// Response Object
    /// </summary>
    public class ShowTaurusDbTxnProgressResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  处于活跃状态（回滚中）的事务进度列表。如果输入的ID已结束或不存在，则不在此列表中返回。
        /// </summary>
        [JsonProperty("transactions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TxnItem> Transactions { get; set; }

        /// <summary>
        /// **参数解释**： 满足查询条件的事务记录总数。 **取值范围**： 0~100。 
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTaurusDbTxnProgressResponse {\n");
            sb.Append("  transactions: ").Append(Transactions).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTaurusDbTxnProgressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTaurusDbTxnProgressResponse input)
        {
            if (input == null) return false;
            if (this.Transactions != input.Transactions || (this.Transactions != null && input.Transactions != null && !this.Transactions.SequenceEqual(input.Transactions))) return false;
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
                if (this.Transactions != null) hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
