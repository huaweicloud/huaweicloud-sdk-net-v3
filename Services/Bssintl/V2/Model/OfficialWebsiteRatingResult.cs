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
    public class OfficialWebsiteRatingResult 
    {

        /// <summary>
        /// 包年/包月产品的官网价。
        /// </summary>
        [JsonProperty("official_website_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialWebsiteAmount { get; set; }

        /// <summary>
        /// 价格度量单位标识。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 产品询价结果，具体参见表5。
        /// </summary>
        [JsonProperty("product_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<PeriodProductOfficialRatingResult> ProductRatingResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfficialWebsiteRatingResult {\n");
            sb.Append("  officialWebsiteAmount: ").Append(OfficialWebsiteAmount).Append("\n");
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
            if (this.OfficialWebsiteAmount != input.OfficialWebsiteAmount || (this.OfficialWebsiteAmount != null && !this.OfficialWebsiteAmount.Equals(input.OfficialWebsiteAmount))) return false;
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
                if (this.OfficialWebsiteAmount != null) hashCode = hashCode * 59 + this.OfficialWebsiteAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.ProductRatingResults != null) hashCode = hashCode * 59 + this.ProductRatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
