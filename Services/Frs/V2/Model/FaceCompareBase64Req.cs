using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FaceCompareBase64Req 
    {

        /// <summary>
        /// 图像数据，Base64编码，要求： • Base64编码后大小不超过8MB，建议小于1MB。 • 图片为JPG/JPEG/BMP/PNG格式。
        /// </summary>
        [JsonProperty("image2_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string Image2Base64 { get; set; }

        /// <summary>
        /// 图像数据，Base64编码，要求： • Base64编码后大小不超过8MB，建议小于1MB。 • 图片为JPG/JPEG/BMP/PNG格式。
        /// </summary>
        [JsonProperty("image1_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string Image1Base64 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceCompareBase64Req {\n");
            sb.Append("  image2Base64: ").Append(Image2Base64).Append("\n");
            sb.Append("  image1Base64: ").Append(Image1Base64).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceCompareBase64Req);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FaceCompareBase64Req input)
        {
            if (input == null) return false;
            if (this.Image2Base64 != input.Image2Base64 || (this.Image2Base64 != null && !this.Image2Base64.Equals(input.Image2Base64))) return false;
            if (this.Image1Base64 != input.Image1Base64 || (this.Image1Base64 != null && !this.Image1Base64.Equals(input.Image1Base64))) return false;

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
                if (this.Image2Base64 != null) hashCode = hashCode * 59 + this.Image2Base64.GetHashCode();
                if (this.Image1Base64 != null) hashCode = hashCode * 59 + this.Image1Base64.GetHashCode();
                return hashCode;
            }
        }
    }
}
