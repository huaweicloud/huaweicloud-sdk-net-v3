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
    public class MyanmarIdcardRequestBody 
    {

        /// <summary>
        /// 与url二选一  图像数据，base64编码，要求base64编码后大小不超过10MB。图片最小边不小于15px，最长边不超过4096px，支持JPEG、JPG、PNG、BMP、TIFF格式。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/intl/zh-cn/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// - true：输出为unicode格式 - false：输出为zawgyi格式 如果参数值为空或无该参数，默认输出为zawgyi格式。 
        /// </summary>
        [JsonProperty("convert_unicode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConvertUnicode { get; set; }

        /// <summary>
        /// 是否返回置信度的开关，可选值如下所示。 - true：返回置信度 - false：不返回置信度 如果无该参数，系统默认不返回置信度。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnConfidence { get; set; }

        /// <summary>
        /// 是否返回头像内容开关，可选值如下所示： - true：返回身份证头像照片的 base64 编码 - false：不返回身份证头像照片的 base64 编码 
        /// </summary>
        [JsonProperty("return_portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitImage { get; set; }

        /// <summary>
        /// 是否返回头像坐标的开关，可选值如下所示： - true：返回身份证头像的位置 - false：不返回身份证头像的位置 
        /// </summary>
        [JsonProperty("return_portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitLocation { get; set; }

        /// <summary>
        /// 是否返回身份证类型的开关，可选值如下所示： - true：返回身份证的类型，类型包括身份证原件以及身份证复印件 - false：不返回身份证的类型 未传入该参数时默认为false，即不返回身份证头像照片的 base64 编码。 
        /// </summary>
        [JsonProperty("return_idcard_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnIdcardType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MyanmarIdcardRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  convertUnicode: ").Append(ConvertUnicode).Append("\n");
            sb.Append("  returnConfidence: ").Append(ReturnConfidence).Append("\n");
            sb.Append("  returnPortraitImage: ").Append(ReturnPortraitImage).Append("\n");
            sb.Append("  returnPortraitLocation: ").Append(ReturnPortraitLocation).Append("\n");
            sb.Append("  returnIdcardType: ").Append(ReturnIdcardType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MyanmarIdcardRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MyanmarIdcardRequestBody input)
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
                    this.ConvertUnicode == input.ConvertUnicode ||
                    (this.ConvertUnicode != null &&
                    this.ConvertUnicode.Equals(input.ConvertUnicode))
                ) && 
                (
                    this.ReturnConfidence == input.ReturnConfidence ||
                    (this.ReturnConfidence != null &&
                    this.ReturnConfidence.Equals(input.ReturnConfidence))
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
                ) && 
                (
                    this.ReturnIdcardType == input.ReturnIdcardType ||
                    (this.ReturnIdcardType != null &&
                    this.ReturnIdcardType.Equals(input.ReturnIdcardType))
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
                if (this.ConvertUnicode != null)
                    hashCode = hashCode * 59 + this.ConvertUnicode.GetHashCode();
                if (this.ReturnConfidence != null)
                    hashCode = hashCode * 59 + this.ReturnConfidence.GetHashCode();
                if (this.ReturnPortraitImage != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitImage.GetHashCode();
                if (this.ReturnPortraitLocation != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitLocation.GetHashCode();
                if (this.ReturnIdcardType != null)
                    hashCode = hashCode * 59 + this.ReturnIdcardType.GetHashCode();
                return hashCode;
            }
        }
    }
}
