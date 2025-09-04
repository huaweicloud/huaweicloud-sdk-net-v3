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
    public class DiscountInfoV3 
    {

        /// <summary>
        /// 订单的可用折扣ID。 支付订单时，输入该参数的值，即可使用折扣。
        /// </summary>
        [JsonProperty("discount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountId { get; set; }

        /// <summary>
        /// 折扣率或者满减值，如果折扣模式是一口价，这个值为空。
        /// </summary>
        [JsonProperty("discount_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountValue { get; set; }

        /// <summary>
        /// 折扣类型，取值为 0：促销折扣1：合同折扣2：商务优惠3：合作伙伴授予折扣609：订单调价折扣
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscountType { get; set; }

        /// <summary>
        /// 可使用折扣的订单列表。 具体请参见表3。
        /// </summary>
        [JsonProperty("orders", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderV3> Orders { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountInfoV3 {\n");
            sb.Append("  discountId: ").Append(DiscountId).Append("\n");
            sb.Append("  discountValue: ").Append(DiscountValue).Append("\n");
            sb.Append("  discountType: ").Append(DiscountType).Append("\n");
            sb.Append("  orders: ").Append(Orders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiscountInfoV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiscountInfoV3 input)
        {
            if (input == null) return false;
            if (this.DiscountId != input.DiscountId || (this.DiscountId != null && !this.DiscountId.Equals(input.DiscountId))) return false;
            if (this.DiscountValue != input.DiscountValue || (this.DiscountValue != null && !this.DiscountValue.Equals(input.DiscountValue))) return false;
            if (this.DiscountType != input.DiscountType || (this.DiscountType != null && !this.DiscountType.Equals(input.DiscountType))) return false;
            if (this.Orders != input.Orders || (this.Orders != null && input.Orders != null && !this.Orders.SequenceEqual(input.Orders))) return false;

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
                if (this.DiscountId != null) hashCode = hashCode * 59 + this.DiscountId.GetHashCode();
                if (this.DiscountValue != null) hashCode = hashCode * 59 + this.DiscountValue.GetHashCode();
                if (this.DiscountType != null) hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.Orders != null) hashCode = hashCode * 59 + this.Orders.GetHashCode();
                return hashCode;
            }
        }
    }
}
