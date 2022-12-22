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
    public class HandwritingRequestBody 
    {

        /// <summary>
        /// 与url二选一  图像数据，base64编码，要求base64编码后大小不超过10MB。图片最小边不小于8px，最长边不超过8192px，支持JPEG、JPG、PNG、BMP、TIFF格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。   
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一  图片的URL路径，目前支持：  - 公网http/https url  - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。  &gt; 说明：  - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。  - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 快速模式开关，针对单行文字图片（要求图片只包含一行文字，且文字区域占比超过50%），打开时可以更快返回识别内容。可选值包括：  - true：打开快速模式；  - false：关闭快速模式。  &gt; 说明：  - 未传入该参数时默认为false，即关闭快速模式 
        /// </summary>
        [JsonProperty("quick_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuickMode { get; set; }

        /// <summary>
        /// 字符集设置，用户可以根据实际需要限定输出字符集范围。可选值如下所示。  - \&quot;digit\&quot;: 数字模式；  - \&quot;letter\&quot;: 大小写字母模式；  - \&quot;digit_letter\&quot;: 数字+字母模式；  - \&quot;general\&quot;: 数字+字母+中文模式；  &gt; 说明：  - 未传入该参数时，默认为“general”模式。 
        /// </summary>
        [JsonProperty("char_set", NullValueHandling = NullValueHandling.Ignore)]
        public string CharSet { get; set; }

        /// <summary>
        /// 校正图片的倾斜角度开关，可选值如下所示。  - true：校正图片的倾斜角度；  - false：不校正图片的倾斜角度。  &gt; 说明：  - 支持任意角度的校正，未传入该参数时默认为“false”。 
        /// </summary>
        [JsonProperty("detect_direction", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectDirection { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HandwritingRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  quickMode: ").Append(QuickMode).Append("\n");
            sb.Append("  charSet: ").Append(CharSet).Append("\n");
            sb.Append("  detectDirection: ").Append(DetectDirection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HandwritingRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HandwritingRequestBody input)
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
                    this.QuickMode == input.QuickMode ||
                    (this.QuickMode != null &&
                    this.QuickMode.Equals(input.QuickMode))
                ) && 
                (
                    this.CharSet == input.CharSet ||
                    (this.CharSet != null &&
                    this.CharSet.Equals(input.CharSet))
                ) && 
                (
                    this.DetectDirection == input.DetectDirection ||
                    (this.DetectDirection != null &&
                    this.DetectDirection.Equals(input.DetectDirection))
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
                if (this.QuickMode != null)
                    hashCode = hashCode * 59 + this.QuickMode.GetHashCode();
                if (this.CharSet != null)
                    hashCode = hashCode * 59 + this.CharSet.GetHashCode();
                if (this.DetectDirection != null)
                    hashCode = hashCode * 59 + this.DetectDirection.GetHashCode();
                return hashCode;
            }
        }
    }
}
