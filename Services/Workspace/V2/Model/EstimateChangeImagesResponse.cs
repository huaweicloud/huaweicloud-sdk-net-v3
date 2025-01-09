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
    /// Response Object
    /// </summary>
    public class EstimateChangeImagesResponse : SdkResponse
    {

        /// <summary>
        /// 币种，比如CNY
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 询价结果
        /// </summary>
        [JsonProperty("cloud_service_rating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<CloudServiceRatingResult> CloudServiceRatingResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateChangeImagesResponse {\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  cloudServiceRatingResults: ").Append(CloudServiceRatingResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateChangeImagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EstimateChangeImagesResponse input)
        {
            if (input == null) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.CloudServiceRatingResults != input.CloudServiceRatingResults || (this.CloudServiceRatingResults != null && input.CloudServiceRatingResults != null && !this.CloudServiceRatingResults.SequenceEqual(input.CloudServiceRatingResults))) return false;

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
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CloudServiceRatingResults != null) hashCode = hashCode * 59 + this.CloudServiceRatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
