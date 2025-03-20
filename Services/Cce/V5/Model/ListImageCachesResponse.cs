using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListImageCachesResponse : SdkResponse
    {

        /// <summary>
        /// 镜像缓存列表。
        /// </summary>
        [JsonProperty("image_caches", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageCacheDetail> ImageCaches { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListImageCachesResponse {\n");
            sb.Append("  imageCaches: ").Append(ImageCaches).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListImageCachesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListImageCachesResponse input)
        {
            if (input == null) return false;
            if (this.ImageCaches != input.ImageCaches || (this.ImageCaches != null && input.ImageCaches != null && !this.ImageCaches.SequenceEqual(input.ImageCaches))) return false;

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
                if (this.ImageCaches != null) hashCode = hashCode * 59 + this.ImageCaches.GetHashCode();
                return hashCode;
            }
        }
    }
}
