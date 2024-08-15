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
    public class DriverLicenseRequestBody 
    {

        /// <summary>
        /// 与url二选一  图像数据，base64编码，要求base64编码后大小不超过10MB。图片最小边不小于100px，最长边不超过8000px。支持JPEG、JPG、PNG、BMP、TIFF格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 检测场景: - front：驾驶证主页。 - back：驾驶证副页。 - double_side：驾驶证双页信息  &gt; 说明：如果参数值为空或无该参数，系统默认识别主页，建议填写，准确率更高。 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 是否返回发证机关的开关，可选值包括： true：返回发证机关 false：不返回发证机关  如果无该参数，系统默认不返回发证机关。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnIssuingAuthority { get; set; }

        /// <summary>
        /// 识别到的文字块的区域位置信息。可选值包括： - true：返回各个文字块区域 - false：不返回各个文字块区域  如果无该参数，系统默认不返回文字块区域。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_text_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTextLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DriverLicenseRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  returnIssuingAuthority: ").Append(ReturnIssuingAuthority).Append("\n");
            sb.Append("  returnTextLocation: ").Append(ReturnTextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DriverLicenseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DriverLicenseRequestBody input)
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
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.ReturnIssuingAuthority == input.ReturnIssuingAuthority ||
                    (this.ReturnIssuingAuthority != null &&
                    this.ReturnIssuingAuthority.Equals(input.ReturnIssuingAuthority))
                ) && 
                (
                    this.ReturnTextLocation == input.ReturnTextLocation ||
                    (this.ReturnTextLocation != null &&
                    this.ReturnTextLocation.Equals(input.ReturnTextLocation))
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
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.ReturnIssuingAuthority != null)
                    hashCode = hashCode * 59 + this.ReturnIssuingAuthority.GetHashCode();
                if (this.ReturnTextLocation != null)
                    hashCode = hashCode * 59 + this.ReturnTextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
