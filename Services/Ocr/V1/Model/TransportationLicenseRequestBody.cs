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
    public class TransportationLicenseRequestBody 
    {

        /// <summary>
        /// 与url二选一。  图片的Base64编码，要求单个图片其对应的Base64编码不超过10MB。文件在Base64编码后会大于文件原本大小，请注意做好边界判断，建议文件大小不超过7MB。 图片最小边不小于15px，最长边不超过4096px，支持JPEG、JPG、PNG、BMP、TIFF格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。   
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一。  单个图片其对应的Base64编码不超过10MB。文件在Base64编码后会大于文件原本大小，请注意做好边界判断，建议文件大小不超过7MB。 图片最小边不小于15px，最长边不超过4096px，支持JPEG、JPG、PNG、BMP、TIFF格式。 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 返回道路运输证在原图中的坐标位置的开关，默认false，取值范围包括：  - true: 开启返回坐标位置的功能。 - false: 关闭返回坐标位置的功能。 
        /// </summary>
        [JsonProperty("return_image_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnImageLocation { get; set; }

        /// <summary>
        /// 返回道路运输证（base64）的开关，默认false，取值范围包括：  - true: 开启道路运输证（base64）的功能。 - false: 关闭道路运输证（base64）的功能。 
        /// </summary>
        [JsonProperty("return_adjusted_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnAdjustedImage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransportationLicenseRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnImageLocation: ").Append(ReturnImageLocation).Append("\n");
            sb.Append("  returnAdjustedImage: ").Append(ReturnAdjustedImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransportationLicenseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransportationLicenseRequestBody input)
        {
            if (input == null) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.ReturnImageLocation != input.ReturnImageLocation || (this.ReturnImageLocation != null && !this.ReturnImageLocation.Equals(input.ReturnImageLocation))) return false;
            if (this.ReturnAdjustedImage != input.ReturnAdjustedImage || (this.ReturnAdjustedImage != null && !this.ReturnAdjustedImage.Equals(input.ReturnAdjustedImage))) return false;

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
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ReturnImageLocation != null) hashCode = hashCode * 59 + this.ReturnImageLocation.GetHashCode();
                if (this.ReturnAdjustedImage != null) hashCode = hashCode * 59 + this.ReturnAdjustedImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
