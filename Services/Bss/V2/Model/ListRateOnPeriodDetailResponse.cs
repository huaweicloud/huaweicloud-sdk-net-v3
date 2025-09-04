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
    /// Response Object
    /// </summary>
    public class ListRateOnPeriodDetailResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("official_website_rating_result", NullValueHandling = NullValueHandling.Ignore)]
        public OfficialWebsiteRatingResult OfficialWebsiteRatingResult { get; set; }

        /// <summary>
        /// 存在可选折扣优惠时返回折扣优惠维度询价结果，每个折扣优惠一组询价结果，具体参见表4。
        /// </summary>
        [JsonProperty("optional_discount_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionalDiscountRatingResult> OptionalDiscountRatingResults { get; set; }

        /// <summary>
        /// 币种。 CNY：人民币。 值为空代表人民币。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRateOnPeriodDetailResponse {\n");
            sb.Append("  officialWebsiteRatingResult: ").Append(OfficialWebsiteRatingResult).Append("\n");
            sb.Append("  optionalDiscountRatingResults: ").Append(OptionalDiscountRatingResults).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRateOnPeriodDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRateOnPeriodDetailResponse input)
        {
            if (input == null) return false;
            if (this.OfficialWebsiteRatingResult != input.OfficialWebsiteRatingResult || (this.OfficialWebsiteRatingResult != null && !this.OfficialWebsiteRatingResult.Equals(input.OfficialWebsiteRatingResult))) return false;
            if (this.OptionalDiscountRatingResults != input.OptionalDiscountRatingResults || (this.OptionalDiscountRatingResults != null && input.OptionalDiscountRatingResults != null && !this.OptionalDiscountRatingResults.SequenceEqual(input.OptionalDiscountRatingResults))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;

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
                if (this.OfficialWebsiteRatingResult != null) hashCode = hashCode * 59 + this.OfficialWebsiteRatingResult.GetHashCode();
                if (this.OptionalDiscountRatingResults != null) hashCode = hashCode * 59 + this.OptionalDiscountRatingResults.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
