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
    public class SearchTransactionResponse : SdkResponse
    {

        /// <summary>
        /// URL跟踪视图列表。
        /// </summary>
        [JsonProperty("tx_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TxItemVo> TxItemList { get; set; }

        /// <summary>
        /// 最后响应时间。
        /// </summary>
        [JsonProperty("latest_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestTime { get; set; }

        /// <summary>
        /// 总数据条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 请求id。
        /// </summary>
        [JsonProperty("result_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchTransactionResponse {\n");
            sb.Append("  txItemList: ").Append(TxItemList).Append("\n");
            sb.Append("  latestTime: ").Append(LatestTime).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  resultId: ").Append(ResultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchTransactionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchTransactionResponse input)
        {
            if (input == null) return false;
            if (this.TxItemList != input.TxItemList || (this.TxItemList != null && input.TxItemList != null && !this.TxItemList.SequenceEqual(input.TxItemList))) return false;
            if (this.LatestTime != input.LatestTime || (this.LatestTime != null && !this.LatestTime.Equals(input.LatestTime))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.ResultId != input.ResultId || (this.ResultId != null && !this.ResultId.Equals(input.ResultId))) return false;

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
                if (this.TxItemList != null) hashCode = hashCode * 59 + this.TxItemList.GetHashCode();
                if (this.LatestTime != null) hashCode = hashCode * 59 + this.LatestTime.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ResultId != null) hashCode = hashCode * 59 + this.ResultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
