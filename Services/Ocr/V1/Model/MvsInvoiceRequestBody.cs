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
    public class MvsInvoiceRequestBody 
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
        /// 如果为True，返回体中会包含text_location对象，内容是各字段的检测框四点坐标。如果是False或者没有这个key，则返回体中不包含text_location对象。 
        /// </summary>
        [JsonProperty("return_text_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTextLocation { get; set; }

        /// <summary>
        /// 如果为True，返回体中会包含confidence对象，内容是各字段的置信度。如果是False或者没有这个key，则返回体中不包含confidence对象。 
        /// </summary>
        [JsonProperty("return_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnConfidence { get; set; }

        /// <summary>
        /// 如果没有type字段则默认返回原机动车销售发票出参； 若存在type字段但是不属于 auto、new或者used三个枚举值，API返回AIS.0101入参错误； 如果type为auto，API自动判断发票类型，并在返回参数中添加type出参以指明发票类型； 如果type为new，API在检测出的类型为机动车发票时返回原版机动车发票出参并添加type出参（机动车销售统一发票），不一致时报错AIS.0104图像质量差； 如果type为used，API在检测出的类型为二手车时返回二手车发票出参，并添加type出参（二手车销售统一发票），不一致时报错AIS.0104图像质量差。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MvsInvoiceRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnTextLocation: ").Append(ReturnTextLocation).Append("\n");
            sb.Append("  returnConfidence: ").Append(ReturnConfidence).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MvsInvoiceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MvsInvoiceRequestBody input)
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
                    this.ReturnTextLocation == input.ReturnTextLocation ||
                    (this.ReturnTextLocation != null &&
                    this.ReturnTextLocation.Equals(input.ReturnTextLocation))
                ) && 
                (
                    this.ReturnConfidence == input.ReturnConfidence ||
                    (this.ReturnConfidence != null &&
                    this.ReturnConfidence.Equals(input.ReturnConfidence))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ReturnTextLocation != null)
                    hashCode = hashCode * 59 + this.ReturnTextLocation.GetHashCode();
                if (this.ReturnConfidence != null)
                    hashCode = hashCode * 59 + this.ReturnConfidence.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
