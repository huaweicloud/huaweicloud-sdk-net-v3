using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class OfficialWebsiteRatingResult 
    {

        /// <summary>
        /// 订单总额，即最终优惠后的订单金额(预留实例只包含预付部分)
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 官网价(预留实例只包含预付部分)
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 订单原总额，即优惠前订单总额(预留实例只包含预付部分)
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OriginalAmount { get; set; }

        /// <summary>
        /// 官网价优惠额(预留实例只包含预付部分)
        /// </summary>
        [JsonProperty("official_website_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteDiscountAmount { get; set; }

        /// <summary>
        /// 可选折扣优惠额(预留实例只包含预付部分)
        /// </summary>
        [JsonProperty("optional_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OptionalDiscountAmount { get; set; }

        /// <summary>
        /// 总优惠额(预留实例只包含预付部分)
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 总分期金额(批量询价的商品分期周期类型一致，才会有总分期金额，分期周期类型不一致，该信息没有)
        /// </summary>
        [JsonProperty("per_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerAmount { get; set; }

        /// <summary>
        /// 总分期金额的优惠额(perDiscountAmount &#x3D; perOriginalAmount - perAmount)
        /// </summary>
        [JsonProperty("per_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerDiscountAmount { get; set; }

        /// <summary>
        /// 总分期金额原价
        /// </summary>
        [JsonProperty("per_original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerOriginalAmount { get; set; }

        /// <summary>
        /// 分期周期类型 2:月 4:小时
        /// </summary>
        [JsonProperty("per_period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPeriodType { get; set; }

        /// <summary>
        /// 度量单位
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 产品询价结果
        /// </summary>
        [JsonProperty("product_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductResult> ProductRatingResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfficialWebsiteRatingResult {\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
            sb.Append("  originalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  officialWebsiteDiscountAmount: ").Append(OfficialWebsiteDiscountAmount).Append("\n");
            sb.Append("  optionalDiscountAmount: ").Append(OptionalDiscountAmount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  perAmount: ").Append(PerAmount).Append("\n");
            sb.Append("  perDiscountAmount: ").Append(PerDiscountAmount).Append("\n");
            sb.Append("  perOriginalAmount: ").Append(PerOriginalAmount).Append("\n");
            sb.Append("  perPeriodType: ").Append(PerPeriodType).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  productRatingResults: ").Append(ProductRatingResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OfficialWebsiteRatingResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OfficialWebsiteRatingResult input)
        {
            if (input == null) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
            if (this.OriginalAmount != input.OriginalAmount || (this.OriginalAmount != null && !this.OriginalAmount.Equals(input.OriginalAmount))) return false;
            if (this.OfficialWebsiteDiscountAmount != input.OfficialWebsiteDiscountAmount || (this.OfficialWebsiteDiscountAmount != null && !this.OfficialWebsiteDiscountAmount.Equals(input.OfficialWebsiteDiscountAmount))) return false;
            if (this.OptionalDiscountAmount != input.OptionalDiscountAmount || (this.OptionalDiscountAmount != null && !this.OptionalDiscountAmount.Equals(input.OptionalDiscountAmount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.PerAmount != input.PerAmount || (this.PerAmount != null && !this.PerAmount.Equals(input.PerAmount))) return false;
            if (this.PerDiscountAmount != input.PerDiscountAmount || (this.PerDiscountAmount != null && !this.PerDiscountAmount.Equals(input.PerDiscountAmount))) return false;
            if (this.PerOriginalAmount != input.PerOriginalAmount || (this.PerOriginalAmount != null && !this.PerOriginalAmount.Equals(input.PerOriginalAmount))) return false;
            if (this.PerPeriodType != input.PerPeriodType || (this.PerPeriodType != null && !this.PerPeriodType.Equals(input.PerPeriodType))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
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
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.OriginalAmount != null) hashCode = hashCode * 59 + this.OriginalAmount.GetHashCode();
                if (this.OfficialWebsiteDiscountAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteDiscountAmount.GetHashCode();
                if (this.OptionalDiscountAmount != null) hashCode = hashCode * 59 + this.OptionalDiscountAmount.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.PerAmount != null) hashCode = hashCode * 59 + this.PerAmount.GetHashCode();
                if (this.PerDiscountAmount != null) hashCode = hashCode * 59 + this.PerDiscountAmount.GetHashCode();
                if (this.PerOriginalAmount != null) hashCode = hashCode * 59 + this.PerOriginalAmount.GetHashCode();
                if (this.PerPeriodType != null) hashCode = hashCode * 59 + this.PerPeriodType.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.ProductRatingResults != null) hashCode = hashCode * 59 + this.ProductRatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
