using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListCostsReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time_condition", NullValueHandling = NullValueHandling.Ignore)]
        public TimeCondition TimeCondition { get; set; }

        /// <summary>
        /// 查询维度，具体请参见表 GroupBy。
        /// </summary>
        [JsonProperty("groupby", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupBy> Groupby { get; set; }

        /// <summary>
        /// 成本类型。ORIGINAL_COST：原始成本AMORTIZED_COST：摊销成本
        /// </summary>
        [JsonProperty("cost_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CostType { get; set; }

        /// <summary>
        /// 展示的金额类型。PAYMENT_AMOUNT：应付NET_AMOUNT：实付
        /// </summary>
        [JsonProperty("amount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountType { get; set; }

        /// <summary>
        /// 偏移量。从0开始，默认为0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的记录数，默认为10
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 过滤条件，具体请参见表 过滤条件。此参数不携带或携带值为空列表或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<FilterV2> Filters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCostsReq {\n");
            sb.Append("  timeCondition: ").Append(TimeCondition).Append("\n");
            sb.Append("  groupby: ").Append(Groupby).Append("\n");
            sb.Append("  costType: ").Append(CostType).Append("\n");
            sb.Append("  amountType: ").Append(AmountType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  filters: ").Append(Filters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCostsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCostsReq input)
        {
            if (input == null) return false;
            if (this.TimeCondition != input.TimeCondition || (this.TimeCondition != null && !this.TimeCondition.Equals(input.TimeCondition))) return false;
            if (this.Groupby != input.Groupby || (this.Groupby != null && input.Groupby != null && !this.Groupby.SequenceEqual(input.Groupby))) return false;
            if (this.CostType != input.CostType || (this.CostType != null && !this.CostType.Equals(input.CostType))) return false;
            if (this.AmountType != input.AmountType || (this.AmountType != null && !this.AmountType.Equals(input.AmountType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Filters != input.Filters || (this.Filters != null && input.Filters != null && !this.Filters.SequenceEqual(input.Filters))) return false;

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
                if (this.TimeCondition != null) hashCode = hashCode * 59 + this.TimeCondition.GetHashCode();
                if (this.Groupby != null) hashCode = hashCode * 59 + this.Groupby.GetHashCode();
                if (this.CostType != null) hashCode = hashCode * 59 + this.CostType.GetHashCode();
                if (this.AmountType != null) hashCode = hashCode * 59 + this.AmountType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Filters != null) hashCode = hashCode * 59 + this.Filters.GetHashCode();
                return hashCode;
            }
        }
    }
}
