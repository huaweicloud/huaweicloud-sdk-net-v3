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
    public class ListThumbnailDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 截图图片总数 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 截图结果列表 
        /// </summary>
        [JsonProperty("thumbnail_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<ThumbnailRsp> ThumbnailResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListThumbnailDetailsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  thumbnailResult: ").Append(ThumbnailResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListThumbnailDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListThumbnailDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.ThumbnailResult != input.ThumbnailResult || (this.ThumbnailResult != null && input.ThumbnailResult != null && !this.ThumbnailResult.SequenceEqual(input.ThumbnailResult))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ThumbnailResult != null) hashCode = hashCode * 59 + this.ThumbnailResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
