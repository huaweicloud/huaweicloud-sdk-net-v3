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
    public class CreateAssetProcessTaskResponse : SdkResponse
    {

        /// <summary>
        /// 媒资ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 截图任务id，仅支持多截图场景会返回。
        /// </summary>
        [JsonProperty("thumbnail_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailTaskId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAssetProcessTaskResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  thumbnailTaskId: ").Append(ThumbnailTaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAssetProcessTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssetProcessTaskResponse input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.ThumbnailTaskId != input.ThumbnailTaskId || (this.ThumbnailTaskId != null && !this.ThumbnailTaskId.Equals(input.ThumbnailTaskId))) return false;

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
                if (this.ThumbnailTaskId != null) hashCode = hashCode * 59 + this.ThumbnailTaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
