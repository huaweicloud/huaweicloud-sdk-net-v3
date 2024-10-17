using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 指定用户的背景图，优先级大于default_user_background_image
    /// </summary>
    public class MixUserBackgroundImage 
    {

        /// <summary>
        /// 需要设置背景图的用户ID
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 需要设置背景图的地址，图片先上传obs，格式s3://bucket/object
        /// </summary>
        [JsonProperty("image_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixUserBackgroundImage {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  imageUri: ").Append(ImageUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MixUserBackgroundImage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MixUserBackgroundImage input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.ImageUri != input.ImageUri || (this.ImageUri != null && !this.ImageUri.Equals(input.ImageUri))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ImageUri != null) hashCode = hashCode * 59 + this.ImageUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
