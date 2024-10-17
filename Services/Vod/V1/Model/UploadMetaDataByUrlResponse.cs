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
    public class UploadMetaDataByUrlResponse : SdkResponse
    {

        /// <summary>
        /// 待拉取创建的媒资元数据
        /// </summary>
        [JsonProperty("upload_assets", NullValueHandling = NullValueHandling.Ignore)]
        public List<UploadAsset> UploadAssets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadMetaDataByUrlResponse {\n");
            sb.Append("  uploadAssets: ").Append(UploadAssets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadMetaDataByUrlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadMetaDataByUrlResponse input)
        {
            if (input == null) return false;
            if (this.UploadAssets != input.UploadAssets || (this.UploadAssets != null && input.UploadAssets != null && !this.UploadAssets.SequenceEqual(input.UploadAssets))) return false;

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
                if (this.UploadAssets != null) hashCode = hashCode * 59 + this.UploadAssets.GetHashCode();
                return hashCode;
            }
        }
    }
}
