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
    public class DemandProductRatingResult 
    {

        /// <summary>
        /// 同一次询价中不能重复，用于标识返回询价结果和请求的映射关系。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 按需产品的ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 折扣的金额。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 优惠额（官网价和总价的差）。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 按需产品的官网价。
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 度量单位标识。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 折扣优惠明细，包含产品本身的促销信息，同时包含商务或者伙伴折扣的优惠信息，具体参见表3。
        /// </summary>
        [JsonProperty("discount_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemandDiscountRatingResult> DiscountRatingResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemandProductRatingResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  discountRatingResults: ").Append(DiscountRatingResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DemandProductRatingResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DemandProductRatingResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.DiscountRatingResults != input.DiscountRatingResults || (this.DiscountRatingResults != null && input.DiscountRatingResults != null && !this.DiscountRatingResults.SequenceEqual(input.DiscountRatingResults))) return false;

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
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.DiscountRatingResults != null) hashCode = hashCode * 59 + this.DiscountRatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
