using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 输出资产信息配置。
    /// </summary>
    public class OutputAssetInfo 
    {

        /// <summary>
        /// 输出视频资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 输出视频资产名称。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 视频封面URL。
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 预览视频下载URL。URL有效期24小时。 &gt; * 分身数字人视频制作不支持预览。
        /// </summary>
        [JsonProperty("preview_video_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviewVideoUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputAssetInfo {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  previewVideoUrl: ").Append(PreviewVideoUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputAssetInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputAssetInfo input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.PreviewVideoUrl != input.PreviewVideoUrl || (this.PreviewVideoUrl != null && !this.PreviewVideoUrl.Equals(input.PreviewVideoUrl))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.PreviewVideoUrl != null) hashCode = hashCode * 59 + this.PreviewVideoUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
