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
    /// Request Object
    /// </summary>
    public class DeleteImageCacheRequest 
    {

        /// <summary>
        /// **参数解释：** 镜像缓存ID。 **约束限制：** 不涉及 **取值范围：** 镜像缓存ID。 **默认取值：** 不涉及 
        /// </summary>
        [SDKProperty("image_cache_id", IsPath = true)]
        [JsonProperty("image_cache_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageCacheId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteImageCacheRequest {\n");
            sb.Append("  imageCacheId: ").Append(ImageCacheId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteImageCacheRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteImageCacheRequest input)
        {
            if (input == null) return false;
            if (this.ImageCacheId != input.ImageCacheId || (this.ImageCacheId != null && !this.ImageCacheId.Equals(input.ImageCacheId))) return false;

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
                if (this.ImageCacheId != null) hashCode = hashCode * 59 + this.ImageCacheId.GetHashCode();
                return hashCode;
            }
        }
    }
}
