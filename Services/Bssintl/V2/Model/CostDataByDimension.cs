using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CostDataByDimension 
    {

        /// <summary>
        /// 维度列表。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<DimensionGroup> Dimensions { get; set; }

        /// <summary>
        /// 成本值。
        /// </summary>
        [JsonProperty("costs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Cost> Costs { get; set; }

        /// <summary>
        /// 此维度值对应整个时间跨度的成本汇总金额。
        /// </summary>
        [JsonProperty("amount_by_costs", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountByCosts { get; set; }

        /// <summary>
        /// 此维度值对应整个时间跨度的官网价汇总金额。
        /// </summary>
        [JsonProperty("official_amount_by_costs", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialAmountByCosts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CostDataByDimension {\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  costs: ").Append(Costs).Append("\n");
            sb.Append("  amountByCosts: ").Append(AmountByCosts).Append("\n");
            sb.Append("  officialAmountByCosts: ").Append(OfficialAmountByCosts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CostDataByDimension);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CostDataByDimension input)
        {
            if (input == null) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;
            if (this.Costs != input.Costs || (this.Costs != null && input.Costs != null && !this.Costs.SequenceEqual(input.Costs))) return false;
            if (this.AmountByCosts != input.AmountByCosts || (this.AmountByCosts != null && !this.AmountByCosts.Equals(input.AmountByCosts))) return false;
            if (this.OfficialAmountByCosts != input.OfficialAmountByCosts || (this.OfficialAmountByCosts != null && !this.OfficialAmountByCosts.Equals(input.OfficialAmountByCosts))) return false;

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
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Costs != null) hashCode = hashCode * 59 + this.Costs.GetHashCode();
                if (this.AmountByCosts != null) hashCode = hashCode * 59 + this.AmountByCosts.GetHashCode();
                if (this.OfficialAmountByCosts != null) hashCode = hashCode * 59 + this.OfficialAmountByCosts.GetHashCode();
                return hashCode;
            }
        }
    }
}
