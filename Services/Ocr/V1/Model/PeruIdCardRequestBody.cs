using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PeruIdCardRequestBody 
    {

        /// <summary>
        /// 与url二选一。 图像数据，base64编码，要求base64编码后大小不超过10M。图片最小边不小于15像素，最长边不超过8192像素，支持JPG/PNG/BMP/TIFF/PDF格式，支持识别多页PDF数据。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一。 图片的URL路径，目前仅支持华为云上OBS提供的匿名公开授权访问的URL以及公网URL。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 是否返回头像内容开关，可选值如下所示：  - true: 返回身份证头像照片的 base64 编码。 - false:  返回为空值。 未传入该参数时默认为“false”，即返回为空值。 
        /// </summary>
        [JsonProperty("return_portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitImage { get; set; }

        /// <summary>
        /// 是否返回头像坐标的开关，可选值如下所示：  - true: 返回身份证头像的位置坐标。 - false: 返回为空值 未传入该参数时默认为“false”，即返回为空。 
        /// </summary>
        [JsonProperty("return_portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeruIdCardRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnPortraitImage: ").Append(ReturnPortraitImage).Append("\n");
            sb.Append("  returnPortraitLocation: ").Append(ReturnPortraitLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeruIdCardRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PeruIdCardRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ReturnPortraitImage == input.ReturnPortraitImage ||
                    (this.ReturnPortraitImage != null &&
                    this.ReturnPortraitImage.Equals(input.ReturnPortraitImage))
                ) && 
                (
                    this.ReturnPortraitLocation == input.ReturnPortraitLocation ||
                    (this.ReturnPortraitLocation != null &&
                    this.ReturnPortraitLocation.Equals(input.ReturnPortraitLocation))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ReturnPortraitImage != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitImage.GetHashCode();
                if (this.ReturnPortraitLocation != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
