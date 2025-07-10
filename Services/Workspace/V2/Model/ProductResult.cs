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
    /// 产品计算结果。
    /// </summary>
    public class ProductResult 
    {

        /// <summary>
        /// 对应请求体中的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 总额，即最终优惠后的金额(预留实例只包含预付部分)。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 优惠额(预留实例只包含预付部分)。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 原总额，即优惠前总额(预留实例只包含预付部分)。
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OriginalAmount { get; set; }

        /// <summary>
        /// 官网价（非所有接口有该字段）(预留实例只包含预付部分)。
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 官网价优惠额（非所有接口有该字段）(预留实例只包含预付部分)。
        /// </summary>
        [JsonProperty("official_website_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteDiscountAmount { get; set; }

        /// <summary>
        /// 可选折扣优惠额(预留实例只包含预付部分)，如商务折扣、伙伴折扣、促销折扣和折扣券选用时的优惠额（非所有接口有该字段）。
        /// </summary>
        [JsonProperty("optional_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OptionalDiscountAmount { get; set; }

        /// <summary>
        /// 总分期金额(批量询价的商品分期周期类型一致，才会有总分期金额，分期周期类型不一致，该信息没有)。
        /// </summary>
        [JsonProperty("per_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerAmount { get; set; }

        /// <summary>
        /// 总分期金额的优惠额(perDiscountAmount &#x3D; perOriginalAmount - perAmount)。
        /// </summary>
        [JsonProperty("per_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerDiscountAmount { get; set; }

        /// <summary>
        /// 总分期金额原价。
        /// </summary>
        [JsonProperty("per_original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerOriginalAmount { get; set; }

        /// <summary>
        /// 分期金额的官网价。
        /// </summary>
        [JsonProperty("per_official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerOfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 分期金额的官网价官网价优惠额，即：perOfficialWebsiteDiscountAmount &#x3D;perOriginalAmount-perOfficialWebsiteAmount。
        /// </summary>
        [JsonProperty("per_official_website_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerOfficialWebsiteDiscountAmount { get; set; }

        /// <summary>
        /// 分期金额的可选折扣优惠额，如商务折扣、伙伴折扣、促销折扣和折扣券选用时的优惠额 perOptionalDiscountAmount&#x3D; perOfficialWebsiteAmount- perAmount。
        /// </summary>
        [JsonProperty("per_optional_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PerOptionalDiscountAmount { get; set; }

        /// <summary>
        /// 分期周期类型 2:月 4:小时。
        /// </summary>
        [JsonProperty("per_period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPeriodType { get; set; }

        /// <summary>
        /// 度量单位。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 扩展参数。
        /// </summary>
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  originalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
            sb.Append("  officialWebsiteDiscountAmount: ").Append(OfficialWebsiteDiscountAmount).Append("\n");
            sb.Append("  optionalDiscountAmount: ").Append(OptionalDiscountAmount).Append("\n");
            sb.Append("  perAmount: ").Append(PerAmount).Append("\n");
            sb.Append("  perDiscountAmount: ").Append(PerDiscountAmount).Append("\n");
            sb.Append("  perOriginalAmount: ").Append(PerOriginalAmount).Append("\n");
            sb.Append("  perOfficialWebsiteAmount: ").Append(PerOfficialWebsiteAmount).Append("\n");
            sb.Append("  perOfficialWebsiteDiscountAmount: ").Append(PerOfficialWebsiteDiscountAmount).Append("\n");
            sb.Append("  perOptionalDiscountAmount: ").Append(PerOptionalDiscountAmount).Append("\n");
            sb.Append("  perPeriodType: ").Append(PerPeriodType).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.OriginalAmount != input.OriginalAmount || (this.OriginalAmount != null && !this.OriginalAmount.Equals(input.OriginalAmount))) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
            if (this.OfficialWebsiteDiscountAmount != input.OfficialWebsiteDiscountAmount || (this.OfficialWebsiteDiscountAmount != null && !this.OfficialWebsiteDiscountAmount.Equals(input.OfficialWebsiteDiscountAmount))) return false;
            if (this.OptionalDiscountAmount != input.OptionalDiscountAmount || (this.OptionalDiscountAmount != null && !this.OptionalDiscountAmount.Equals(input.OptionalDiscountAmount))) return false;
            if (this.PerAmount != input.PerAmount || (this.PerAmount != null && !this.PerAmount.Equals(input.PerAmount))) return false;
            if (this.PerDiscountAmount != input.PerDiscountAmount || (this.PerDiscountAmount != null && !this.PerDiscountAmount.Equals(input.PerDiscountAmount))) return false;
            if (this.PerOriginalAmount != input.PerOriginalAmount || (this.PerOriginalAmount != null && !this.PerOriginalAmount.Equals(input.PerOriginalAmount))) return false;
            if (this.PerOfficialWebsiteAmount != input.PerOfficialWebsiteAmount || (this.PerOfficialWebsiteAmount != null && !this.PerOfficialWebsiteAmount.Equals(input.PerOfficialWebsiteAmount))) return false;
            if (this.PerOfficialWebsiteDiscountAmount != input.PerOfficialWebsiteDiscountAmount || (this.PerOfficialWebsiteDiscountAmount != null && !this.PerOfficialWebsiteDiscountAmount.Equals(input.PerOfficialWebsiteDiscountAmount))) return false;
            if (this.PerOptionalDiscountAmount != input.PerOptionalDiscountAmount || (this.PerOptionalDiscountAmount != null && !this.PerOptionalDiscountAmount.Equals(input.PerOptionalDiscountAmount))) return false;
            if (this.PerPeriodType != input.PerPeriodType || (this.PerPeriodType != null && !this.PerPeriodType.Equals(input.PerPeriodType))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.OriginalAmount != null) hashCode = hashCode * 59 + this.OriginalAmount.GetHashCode();
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.OfficialWebsiteDiscountAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteDiscountAmount.GetHashCode();
                if (this.OptionalDiscountAmount != null) hashCode = hashCode * 59 + this.OptionalDiscountAmount.GetHashCode();
                if (this.PerAmount != null) hashCode = hashCode * 59 + this.PerAmount.GetHashCode();
                if (this.PerDiscountAmount != null) hashCode = hashCode * 59 + this.PerDiscountAmount.GetHashCode();
                if (this.PerOriginalAmount != null) hashCode = hashCode * 59 + this.PerOriginalAmount.GetHashCode();
                if (this.PerOfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.PerOfficialWebsiteAmount.GetHashCode();
                if (this.PerOfficialWebsiteDiscountAmount != null) hashCode = hashCode * 59 + this.PerOfficialWebsiteDiscountAmount.GetHashCode();
                if (this.PerOptionalDiscountAmount != null) hashCode = hashCode * 59 + this.PerOptionalDiscountAmount.GetHashCode();
                if (this.PerPeriodType != null) hashCode = hashCode * 59 + this.PerPeriodType.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
