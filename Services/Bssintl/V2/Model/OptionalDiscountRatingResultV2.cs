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
    public class OptionalDiscountRatingResultV2 
    {

        /// <summary>
        /// |参数名称：折扣优惠ID| |参数约束及描述：折扣优惠ID|
        /// </summary>
        [JsonProperty("discount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountId { get; set; }

        /// <summary>
        /// |参数名称：总额，即最终优惠后的金额。单位为元。amount&#x3D; official_website_amount - discount_amount| |参数约束及描述：总额，即最终优惠后的金额。单位为元。amount&#x3D; official_website_amount - discount_amount|
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// |参数名称：官网价。单位为元| |参数约束及描述：官网价。单位为元|
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// |参数名称：可选折扣优惠额，如商务折扣、伙伴折扣、促销折扣和折扣券选用时的优惠额。单位为| |参数约束及描述：可选折扣优惠额，如商务折扣、伙伴折扣、促销折扣和折扣券选用时的优惠额。单位为|
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// |参数名称：折扣优惠类型| |参数约束及描述：折扣优惠类型。商务授权折扣：605(华为云BE场景下的合同商务折扣)、伙伴授予折扣：606(分销商BE场景下的合同商务折扣)、伙伴设置折扣：607(合作伙伴设置折扣-折扣率)|
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscountType { get; set; }

        /// <summary>
        /// |参数名称：折扣名称| |参数约束及描述：折扣名称|
        /// </summary>
        [JsonProperty("discount_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountName { get; set; }

        /// <summary>
        /// |参数名称：是否为最优折扣。0：不是最优折扣，为缺省值。1：是最优折扣最优折扣：在商务折扣、伙伴折扣中选择（优惠金额最大的折扣为最优，优惠金额相等则按此顺序排优先级），促销折扣，折扣券不参与最优折扣的计算| |参数的约束及描述：是否为最优折扣。0：不是最优折扣，为缺省值。1：是最优折扣最优折扣：在商务折扣、伙伴折扣中选择（优惠金额最大的折扣为最优，优惠金额相等则按此顺序排优先级），促销折扣，折扣券不参与最优折扣的计算|
        /// </summary>
        [JsonProperty("best_offer", NullValueHandling = NullValueHandling.Ignore)]
        public int? BestOffer { get; set; }

        /// <summary>
        /// |参数名称：分期金额的官网价。单位为元| |参数约束及描述：分期金额的官网价。单位为元|
        /// </summary>
        [JsonProperty("installment_official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentOfficialWebsiteAmount { get; set; }

        /// <summary>
        /// |参数名称：分期金额的折扣价。单位为元| |参数约束及描述：分期金额的折扣价。单位为元|
        /// </summary>
        [JsonProperty("installment_official_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentOfficialDiscountAmount { get; set; }

        /// <summary>
        /// |参数名称：分期金额的成交价。单位为元| |参数约束及描述：分期金额的成交价。单位为元|
        /// </summary>
        [JsonProperty("installment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentAmount { get; set; }

        /// <summary>
        /// |参数名称：分期付款的周期类型。2：月| |参数的约束及描述：分期付款的周期类型。2：月|
        /// </summary>
        [JsonProperty("installment_period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstallmentPeriodType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionalDiscountRatingResultV2 {\n");
            sb.Append("  discountId: ").Append(DiscountId).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  discountType: ").Append(DiscountType).Append("\n");
            sb.Append("  discountName: ").Append(DiscountName).Append("\n");
            sb.Append("  bestOffer: ").Append(BestOffer).Append("\n");
            sb.Append("  installmentOfficialWebsiteAmount: ").Append(InstallmentOfficialWebsiteAmount).Append("\n");
            sb.Append("  installmentOfficialDiscountAmount: ").Append(InstallmentOfficialDiscountAmount).Append("\n");
            sb.Append("  installmentAmount: ").Append(InstallmentAmount).Append("\n");
            sb.Append("  installmentPeriodType: ").Append(InstallmentPeriodType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OptionalDiscountRatingResultV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OptionalDiscountRatingResultV2 input)
        {
            if (input == null) return false;
            if (this.DiscountId != input.DiscountId || (this.DiscountId != null && !this.DiscountId.Equals(input.DiscountId))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.DiscountType != input.DiscountType || (this.DiscountType != null && !this.DiscountType.Equals(input.DiscountType))) return false;
            if (this.DiscountName != input.DiscountName || (this.DiscountName != null && !this.DiscountName.Equals(input.DiscountName))) return false;
            if (this.BestOffer != input.BestOffer || (this.BestOffer != null && !this.BestOffer.Equals(input.BestOffer))) return false;
            if (this.InstallmentOfficialWebsiteAmount != input.InstallmentOfficialWebsiteAmount || (this.InstallmentOfficialWebsiteAmount != null && !this.InstallmentOfficialWebsiteAmount.Equals(input.InstallmentOfficialWebsiteAmount))) return false;
            if (this.InstallmentOfficialDiscountAmount != input.InstallmentOfficialDiscountAmount || (this.InstallmentOfficialDiscountAmount != null && !this.InstallmentOfficialDiscountAmount.Equals(input.InstallmentOfficialDiscountAmount))) return false;
            if (this.InstallmentAmount != input.InstallmentAmount || (this.InstallmentAmount != null && !this.InstallmentAmount.Equals(input.InstallmentAmount))) return false;
            if (this.InstallmentPeriodType != input.InstallmentPeriodType || (this.InstallmentPeriodType != null && !this.InstallmentPeriodType.Equals(input.InstallmentPeriodType))) return false;

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
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountType != null) hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.DiscountName != null) hashCode = hashCode * 59 + this.DiscountName.GetHashCode();
                if (this.BestOffer != null) hashCode = hashCode * 59 + this.BestOffer.GetHashCode();
                if (this.InstallmentOfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.InstallmentOfficialWebsiteAmount.GetHashCode();
                if (this.InstallmentOfficialDiscountAmount != null) hashCode = hashCode * 59 + this.InstallmentOfficialDiscountAmount.GetHashCode();
                if (this.InstallmentAmount != null) hashCode = hashCode * 59 + this.InstallmentAmount.GetHashCode();
                if (this.InstallmentPeriodType != null) hashCode = hashCode * 59 + this.InstallmentPeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
