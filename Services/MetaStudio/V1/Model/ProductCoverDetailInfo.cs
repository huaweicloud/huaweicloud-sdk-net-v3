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
    /// 商品封面信息
    /// </summary>
    public class ProductCoverDetailInfo 
    {

        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 封面图片路径。
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 缩略图路径。
        /// </summary>
        [JsonProperty("thumbnail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductCoverDetailInfo {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  thumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductCoverDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductCoverDetailInfo input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.ThumbnailUrl != input.ThumbnailUrl || (this.ThumbnailUrl != null && !this.ThumbnailUrl.Equals(input.ThumbnailUrl))) return false;

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
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.ThumbnailUrl != null) hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
