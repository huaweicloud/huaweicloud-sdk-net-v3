using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SearchTransactionConfigResponse : SdkResponse
    {

        /// <summary>
        /// URL跟踪视图配置列表。
        /// </summary>
        [JsonProperty("transaction_config_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransactionConfigItem> TransactionConfigItemList { get; set; }

        /// <summary>
        /// 总页数。
        /// </summary>
        [JsonProperty("total_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// 总配置数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchTransactionConfigResponse {\n");
            sb.Append("  transactionConfigItemList: ").Append(TransactionConfigItemList).Append("\n");
            sb.Append("  totalPage: ").Append(TotalPage).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchTransactionConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchTransactionConfigResponse input)
        {
            if (input == null) return false;
            if (this.TransactionConfigItemList != input.TransactionConfigItemList || (this.TransactionConfigItemList != null && input.TransactionConfigItemList != null && !this.TransactionConfigItemList.SequenceEqual(input.TransactionConfigItemList))) return false;
            if (this.TotalPage != input.TotalPage || (this.TotalPage != null && !this.TotalPage.Equals(input.TotalPage))) return false;
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
                if (this.TransactionConfigItemList != null) hashCode = hashCode * 59 + this.TransactionConfigItemList.GetHashCode();
                if (this.TotalPage != null) hashCode = hashCode * 59 + this.TotalPage.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
