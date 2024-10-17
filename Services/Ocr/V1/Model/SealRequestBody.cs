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
    public class SealRequestBody 
    {

        /// <summary>
        /// 该参数与url二选一。 图片的Base64编码，要求Base64编码后大小不超过10MB。 图片最短边不小于15px，最长边不超过8192px。支持JPEG、JPG、PNG、BMP、GIF、TIFF、WEBP、PCX、ICO、PSD、PDF格式。 图片Base64编码示例如/9j/4AAQSkZJRgABAg...，带有多余前缀会产生The image format is not supported报错。 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// 与data二选一 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 是否返回提取的印章base64编码图片，可选值如下所示： - true：返回提取的印章图片base64编码 - false：不返回提取的印章图片base64编码  如果无该参数，系统默认不返回印章擦除后的图片。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_seal_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnSealImage { get; set; }

        /// <summary>
        /// 是否返回印章擦除后的base64编码图片，可选值包括： - true：返回印章擦除后的图片base64编码 - false：不返回印章擦除后的图片base64编码  如果无该参数，系统默认不返回印章擦除后的图片。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_erased_seal_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnErasedSealImage { get; set; }

        /// <summary>
        /// 指定PDF页码识别。传入该参数时，则识别指定页码的内容。如果不传该参数，则默认识别第1页。 
        /// </summary>
        [JsonProperty("pdf_page_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfPageNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SealRequestBody {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnSealImage: ").Append(ReturnSealImage).Append("\n");
            sb.Append("  returnErasedSealImage: ").Append(ReturnErasedSealImage).Append("\n");
            sb.Append("  pdfPageNumber: ").Append(PdfPageNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SealRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SealRequestBody input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.ReturnSealImage != input.ReturnSealImage || (this.ReturnSealImage != null && !this.ReturnSealImage.Equals(input.ReturnSealImage))) return false;
            if (this.ReturnErasedSealImage != input.ReturnErasedSealImage || (this.ReturnErasedSealImage != null && !this.ReturnErasedSealImage.Equals(input.ReturnErasedSealImage))) return false;
            if (this.PdfPageNumber != input.PdfPageNumber || (this.PdfPageNumber != null && !this.PdfPageNumber.Equals(input.PdfPageNumber))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ReturnSealImage != null) hashCode = hashCode * 59 + this.ReturnSealImage.GetHashCode();
                if (this.ReturnErasedSealImage != null) hashCode = hashCode * 59 + this.ReturnErasedSealImage.GetHashCode();
                if (this.PdfPageNumber != null) hashCode = hashCode * 59 + this.PdfPageNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
