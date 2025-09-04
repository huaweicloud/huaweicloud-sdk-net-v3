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
    public class OptionalDiscountRatingResult 
    {

        /// <summary>
        /// 折扣优惠ID。
        /// </summary>
        [JsonProperty("discount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountId { get; set; }

        /// <summary>
        /// 总额，即最终优惠后的金额。 amount&#x3D; official_website_amount - discountAmount。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 包年/包月产品的官网价。
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 可选折扣优惠额，如商务折扣、伙伴折扣、促销折扣和折扣券选用时的优惠额。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 价格度量单位标识。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 折扣优惠类型。商务授权折扣：605(华为云BE场景下的合同商务折扣)、伙伴授予折扣：606(分销商BE场景下的合同商务折扣)、伙伴设置折扣：607(合作伙伴设置折扣-折扣率)
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscountType { get; set; }

        /// <summary>
        /// 折扣名称。
        /// </summary>
        [JsonProperty("discount_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountName { get; set; }

        /// <summary>
        /// 是否为最优折扣。 0：不是最优折扣，为缺省值。1：是最优折扣最优折扣：在商务折扣、伙伴折扣中选择（优惠金额最大的折扣为最优，优惠金额相等则按此顺序排优先级），促销折扣，折扣券不参与最优折扣的计算。
        /// </summary>
        [JsonProperty("best_offer", NullValueHandling = NullValueHandling.Ignore)]
        public int? BestOffer { get; set; }

        /// <summary>
        /// 产品询价结果，具体参见表5。
        /// </summary>
        [JsonProperty("product_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<PeriodProductRatingResult> ProductRatingResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionalDiscountRatingResult {\n");
            sb.Append("  discountId: ").Append(DiscountId).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  discountType: ").Append(DiscountType).Append("\n");
            sb.Append("  discountName: ").Append(DiscountName).Append("\n");
            sb.Append("  bestOffer: ").Append(BestOffer).Append("\n");
            sb.Append("  productRatingResults: ").Append(ProductRatingResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OptionalDiscountRatingResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OptionalDiscountRatingResult input)
        {
            if (input == null) return false;
            if (this.DiscountId != input.DiscountId || (this.DiscountId != null && !this.DiscountId.Equals(input.DiscountId))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.DiscountType != input.DiscountType || (this.DiscountType != null && !this.DiscountType.Equals(input.DiscountType))) return false;
            if (this.DiscountName != input.DiscountName || (this.DiscountName != null && !this.DiscountName.Equals(input.DiscountName))) return false;
            if (this.BestOffer != input.BestOffer || (this.BestOffer != null && !this.BestOffer.Equals(input.BestOffer))) return false;
            if (this.ProductRatingResults != input.ProductRatingResults || (this.ProductRatingResults != null && input.ProductRatingResults != null && !this.ProductRatingResults.SequenceEqual(input.ProductRatingResults))) return false;

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
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.DiscountType != null) hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.DiscountName != null) hashCode = hashCode * 59 + this.DiscountName.GetHashCode();
                if (this.BestOffer != null) hashCode = hashCode * 59 + this.BestOffer.GetHashCode();
                if (this.ProductRatingResults != null) hashCode = hashCode * 59 + this.ProductRatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
