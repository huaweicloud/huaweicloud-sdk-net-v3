using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AssetReviewReq 
    {

        /// <summary>
        /// 媒资ID
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review", NullValueHandling = NullValueHandling.Ignore)]
        public Review Review { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetReviewReq {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  review: ").Append(Review).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetReviewReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetReviewReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.Review == input.Review ||
                    (this.Review != null &&
                    this.Review.Equals(input.Review))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Review != null)
                    hashCode = hashCode * 59 + this.Review.GetHashCode();
                return hashCode;
            }
        }
    }
}
