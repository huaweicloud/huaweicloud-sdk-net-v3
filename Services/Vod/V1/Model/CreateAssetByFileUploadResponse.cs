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
    public class CreateAssetByFileUploadResponse : SdkResponse
    {

        /// <summary>
        /// 媒体ID 
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 视频上传URL 
        /// </summary>
        [JsonProperty("video_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoUploadUrl { get; set; }

        /// <summary>
        /// 封面上传地址 
        /// </summary>
        [JsonProperty("cover_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUploadUrl { get; set; }

        /// <summary>
        /// 字幕文件上传url数组 
        /// </summary>
        [JsonProperty("subtitle_upload_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubtitleUploadUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public FileAddr Target { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAssetByFileUploadResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  videoUploadUrl: ").Append(VideoUploadUrl).Append("\n");
            sb.Append("  coverUploadUrl: ").Append(CoverUploadUrl).Append("\n");
            sb.Append("  subtitleUploadUrls: ").Append(SubtitleUploadUrls).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAssetByFileUploadResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssetByFileUploadResponse input)
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
                    this.VideoUploadUrl == input.VideoUploadUrl ||
                    (this.VideoUploadUrl != null &&
                    this.VideoUploadUrl.Equals(input.VideoUploadUrl))
                ) && 
                (
                    this.CoverUploadUrl == input.CoverUploadUrl ||
                    (this.CoverUploadUrl != null &&
                    this.CoverUploadUrl.Equals(input.CoverUploadUrl))
                ) && 
                (
                    this.SubtitleUploadUrls == input.SubtitleUploadUrls ||
                    this.SubtitleUploadUrls != null &&
                    input.SubtitleUploadUrls != null &&
                    this.SubtitleUploadUrls.SequenceEqual(input.SubtitleUploadUrls)
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.VideoUploadUrl != null)
                    hashCode = hashCode * 59 + this.VideoUploadUrl.GetHashCode();
                if (this.CoverUploadUrl != null)
                    hashCode = hashCode * 59 + this.CoverUploadUrl.GetHashCode();
                if (this.SubtitleUploadUrls != null)
                    hashCode = hashCode * 59 + this.SubtitleUploadUrls.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }
    }
}
