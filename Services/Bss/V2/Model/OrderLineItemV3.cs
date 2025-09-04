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
    public class OrderLineItemV3 
    {

        /// <summary>
        /// 可使用相同折扣的订单项合并后的订单项ID列表。 相同产品、相同规格（对于线性产品）、相同最终价格（例如，严选产品改价）的订单项将进行合并。
        /// </summary>
        [JsonProperty("order_line_item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OrderLineItemIds { get; set; }

        /// <summary>
        /// 订单可用折扣的模式 。 0：折扣1：一口价2：满减
        /// </summary>
        [JsonProperty("discount_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscountMode { get; set; }

        /// <summary>
        /// 订单可用的折扣金额（即减免金额）。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 订单可用的折扣比例。
        /// </summary>
        [JsonProperty("discount_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineItemV3 {\n");
            sb.Append("  orderLineItemIds: ").Append(OrderLineItemIds).Append("\n");
            sb.Append("  discountMode: ").Append(DiscountMode).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  discountRatio: ").Append(DiscountRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderLineItemV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderLineItemV3 input)
        {
            if (input == null) return false;
            if (this.OrderLineItemIds != input.OrderLineItemIds || (this.OrderLineItemIds != null && input.OrderLineItemIds != null && !this.OrderLineItemIds.SequenceEqual(input.OrderLineItemIds))) return false;
            if (this.DiscountMode != input.DiscountMode || (this.DiscountMode != null && !this.DiscountMode.Equals(input.DiscountMode))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.DiscountRatio != input.DiscountRatio || (this.DiscountRatio != null && !this.DiscountRatio.Equals(input.DiscountRatio))) return false;

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
                if (this.OrderLineItemIds != null) hashCode = hashCode * 59 + this.OrderLineItemIds.GetHashCode();
                if (this.DiscountMode != null) hashCode = hashCode * 59 + this.DiscountMode.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountRatio != null) hashCode = hashCode * 59 + this.DiscountRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
