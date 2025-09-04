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
    /// Response Object
    /// </summary>
    public class ListOnDemandResourceRatingsResponse : SdkResponse
    {

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
        /// 币种。 USD：美元。 值为空代表美元。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 产品询价结果，具体参见表2。
        /// </summary>
        [JsonProperty("product_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemandProductRatingResult> ProductRatingResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOnDemandResourceRatingsResponse {\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  productRatingResults: ").Append(ProductRatingResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOnDemandResourceRatingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOnDemandResourceRatingsResponse input)
        {
            if (input == null) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
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
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ProductRatingResults != null) hashCode = hashCode * 59 + this.ProductRatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
