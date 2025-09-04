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
    public class AmountInfomationV2 
    {

        /// <summary>
        /// 费用项。 具体请参见表7。
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiscountItemV2> Discounts { get; set; }

        /// <summary>
        /// 现金券金额。
        /// </summary>
        [JsonProperty("flexipurchase_coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? FlexipurchaseCouponAmount { get; set; }

        /// <summary>
        /// 代金券金额。
        /// </summary>
        [JsonProperty("coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? CouponAmount { get; set; }

        /// <summary>
        /// 储值卡金额。
        /// </summary>
        [JsonProperty("stored_card_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? StoredCardAmount { get; set; }

        /// <summary>
        /// 手续费（仅退订订单存在）。
        /// </summary>
        [JsonProperty("commission_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? CommissionAmount { get; set; }

        /// <summary>
        /// 消费金额（仅退订订单存在）。
        /// </summary>
        [JsonProperty("consumed_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? ConsumedAmount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmountInfomationV2 {\n");
            sb.Append("  discounts: ").Append(Discounts).Append("\n");
            sb.Append("  flexipurchaseCouponAmount: ").Append(FlexipurchaseCouponAmount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  storedCardAmount: ").Append(StoredCardAmount).Append("\n");
            sb.Append("  commissionAmount: ").Append(CommissionAmount).Append("\n");
            sb.Append("  consumedAmount: ").Append(ConsumedAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AmountInfomationV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AmountInfomationV2 input)
        {
            if (input == null) return false;
            if (this.Discounts != input.Discounts || (this.Discounts != null && input.Discounts != null && !this.Discounts.SequenceEqual(input.Discounts))) return false;
            if (this.FlexipurchaseCouponAmount != input.FlexipurchaseCouponAmount || (this.FlexipurchaseCouponAmount != null && !this.FlexipurchaseCouponAmount.Equals(input.FlexipurchaseCouponAmount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.StoredCardAmount != input.StoredCardAmount || (this.StoredCardAmount != null && !this.StoredCardAmount.Equals(input.StoredCardAmount))) return false;
            if (this.CommissionAmount != input.CommissionAmount || (this.CommissionAmount != null && !this.CommissionAmount.Equals(input.CommissionAmount))) return false;
            if (this.ConsumedAmount != input.ConsumedAmount || (this.ConsumedAmount != null && !this.ConsumedAmount.Equals(input.ConsumedAmount))) return false;

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
                if (this.Discounts != null) hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                if (this.FlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.FlexipurchaseCouponAmount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.StoredCardAmount != null) hashCode = hashCode * 59 + this.StoredCardAmount.GetHashCode();
                if (this.CommissionAmount != null) hashCode = hashCode * 59 + this.CommissionAmount.GetHashCode();
                if (this.ConsumedAmount != null) hashCode = hashCode * 59 + this.ConsumedAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
