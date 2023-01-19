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
    /// Response Object
    /// </summary>
    public class ShowAssetDetailResponse : SdkResponse
    {

        /// <summary>
        /// 媒资ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public BaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transcode_info", NullValueHandling = NullValueHandling.Ignore)]
        public TranscodeInfo TranscodeInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail_info", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailInfo ThumbnailInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_info", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewInfo ReviewInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetDetailResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  transcodeInfo: ").Append(TranscodeInfo).Append("\n");
            sb.Append("  thumbnailInfo: ").Append(ThumbnailInfo).Append("\n");
            sb.Append("  reviewInfo: ").Append(ReviewInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetDetailResponse input)
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
                    this.BaseInfo == input.BaseInfo ||
                    (this.BaseInfo != null &&
                    this.BaseInfo.Equals(input.BaseInfo))
                ) && 
                (
                    this.TranscodeInfo == input.TranscodeInfo ||
                    (this.TranscodeInfo != null &&
                    this.TranscodeInfo.Equals(input.TranscodeInfo))
                ) && 
                (
                    this.ThumbnailInfo == input.ThumbnailInfo ||
                    (this.ThumbnailInfo != null &&
                    this.ThumbnailInfo.Equals(input.ThumbnailInfo))
                ) && 
                (
                    this.ReviewInfo == input.ReviewInfo ||
                    (this.ReviewInfo != null &&
                    this.ReviewInfo.Equals(input.ReviewInfo))
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
                if (this.BaseInfo != null)
                    hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.TranscodeInfo != null)
                    hashCode = hashCode * 59 + this.TranscodeInfo.GetHashCode();
                if (this.ThumbnailInfo != null)
                    hashCode = hashCode * 59 + this.ThumbnailInfo.GetHashCode();
                if (this.ReviewInfo != null)
                    hashCode = hashCode * 59 + this.ReviewInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
