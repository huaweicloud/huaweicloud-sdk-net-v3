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
    public class CreateImageCacheResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_cache", NullValueHandling = NullValueHandling.Ignore)]
        public ImageCacheDetail ImageCache { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateImageCacheResponse {\n");
            sb.Append("  imageCache: ").Append(ImageCache).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateImageCacheResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateImageCacheResponse input)
        {
            if (input == null) return false;
            if (this.ImageCache != input.ImageCache || (this.ImageCache != null && !this.ImageCache.Equals(input.ImageCache))) return false;

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
                if (this.ImageCache != null) hashCode = hashCode * 59 + this.ImageCache.GetHashCode();
                return hashCode;
            }
        }
    }
}
