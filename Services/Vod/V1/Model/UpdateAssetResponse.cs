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
    public class UpdateAssetResponse : SdkResponse
    {

        /// <summary>
        /// 媒资ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 视频上传地址。  用于客户端上传不超过20MB的小视频文件（&lt;&#x3D;20MB）。该URL中携带了临时授权信息，当文件大于20MB时，需要采用分段方式上传。  &gt; 您可以使用PUT请求向“**video_upload_url**”中上传视频文件。其中，“**Content-Type**”需要根据上传的视频文件类型进行设置，如下所示：视频文件：video/视频格式，如：“video/mp4”。
        /// </summary>
        [JsonProperty("video_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoUploadUrl { get; set; }

        /// <summary>
        /// 封面上传地址，用于上传封面文件。  &gt; 您可以使用PUT请求向“**cover_upload_url**”中上传封面图片。其中，“**Content-Type**”需要根据上传的封面文件类型进行设置，如下所示：图片文件：image/图片格式，如：“image/png”。
        /// </summary>
        [JsonProperty("cover_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUploadUrl { get; set; }

        /// <summary>
        /// 字幕上传地址，用于上传字幕。  &gt; 您可以使用PUT请求向“**subtitle_upload_urls**”中上传字幕文件。其中，“**Content-Type**”需要根据上传的字幕文件类型进行设置，如下所示：字幕文件：application/octet-stream。
        /// </summary>
        [JsonProperty("subtitle_upload_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubtitleUploadUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAssetResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  videoUploadUrl: ").Append(VideoUploadUrl).Append("\n");
            sb.Append("  coverUploadUrl: ").Append(CoverUploadUrl).Append("\n");
            sb.Append("  subtitleUploadUrls: ").Append(SubtitleUploadUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAssetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAssetResponse input)
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
                return hashCode;
            }
        }
    }
}
