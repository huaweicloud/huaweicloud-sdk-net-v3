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
    /// 询价结果。
    /// </summary>
    public class CloudServiceRatingResult 
    {

        /// <summary>
        /// 下单请求体中的orderRequestId。
        /// </summary>
        [JsonProperty("order_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("official_website_rating_result", NullValueHandling = NullValueHandling.Ignore)]
        public OfficialWebsiteRatingResult OfficialWebsiteRatingResult { get; set; }

        /// <summary>
        /// 优惠询价结果。
        /// </summary>
        [JsonProperty("optional_discount_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionalDiscountRatingResult> OptionalDiscountRatingResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudServiceRatingResult {\n");
            sb.Append("  orderRequestId: ").Append(OrderRequestId).Append("\n");
            sb.Append("  officialWebsiteRatingResult: ").Append(OfficialWebsiteRatingResult).Append("\n");
            sb.Append("  optionalDiscountRatingResults: ").Append(OptionalDiscountRatingResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudServiceRatingResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudServiceRatingResult input)
        {
            if (input == null) return false;
            if (this.OrderRequestId != input.OrderRequestId || (this.OrderRequestId != null && !this.OrderRequestId.Equals(input.OrderRequestId))) return false;
            if (this.OfficialWebsiteRatingResult != input.OfficialWebsiteRatingResult || (this.OfficialWebsiteRatingResult != null && !this.OfficialWebsiteRatingResult.Equals(input.OfficialWebsiteRatingResult))) return false;
            if (this.OptionalDiscountRatingResults != input.OptionalDiscountRatingResults || (this.OptionalDiscountRatingResults != null && input.OptionalDiscountRatingResults != null && !this.OptionalDiscountRatingResults.SequenceEqual(input.OptionalDiscountRatingResults))) return false;

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
                if (this.OrderRequestId != null) hashCode = hashCode * 59 + this.OrderRequestId.GetHashCode();
                if (this.OfficialWebsiteRatingResult != null) hashCode = hashCode * 59 + this.OfficialWebsiteRatingResult.GetHashCode();
                if (this.OptionalDiscountRatingResults != null) hashCode = hashCode * 59 + this.OptionalDiscountRatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
