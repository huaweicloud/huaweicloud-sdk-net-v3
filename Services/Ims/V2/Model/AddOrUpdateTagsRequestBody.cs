using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 请求参数
    /// </summary>
    public class AddOrUpdateTagsRequestBody 
    {

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 标签数据。 tag和image_tag只能使用一个。
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_tag", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTag ImageTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrUpdateTagsRequestBody {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  imageTag: ").Append(ImageTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddOrUpdateTagsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddOrUpdateTagsRequestBody input)
        {
            if (input == null) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.ImageTag != input.ImageTag || (this.ImageTag != null && !this.ImageTag.Equals(input.ImageTag))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.ImageTag != null) hashCode = hashCode * 59 + this.ImageTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
