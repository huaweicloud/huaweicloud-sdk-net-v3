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
    public class GeneralTextRequestBody 
    {

        /// <summary>
        /// 与url二选一。  图片的Base64编码，要求单个图片、PDF文件其对应的Base64编码不超过10MB。文件在Base64编码后会大于文件原本大小，请注意做好边界判断，建议文件大小不超过7MB。 图片最小边不小于15px，最长边不超过30000px。图片分辨率不能大于1.6亿px。 支持JPEG、JPG、PNG、BMP、GIF、TIFF、WEBP、PCX、ICO、PSD、PDF格式。  图片文件Base64编码字符串，[点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)](tag:hc)[点击[这里](https://support.huaweicloud.com/intl/zh-cn/ocr_faq/ocr_01_0032.html)](tag:hk)查看详细获取方式。     
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一。  单个图片、PDF文件其对应的Base64编码不超过10MB。文件在Base64编码后会大于文件原本大小，请注意做好边界判断，建议文件大小不超过7MB。 图片最小边不小于15px，最长边不超过30000px。图片分辨率不能大于1.6亿px。 支持JPEG、JPG、PNG、BMP、GIF、TIFF、WEBP、PCX、ICO、PSD、PDF格式。 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，[详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。](tag:hc)[详情参见[配置OBS访问权限](https://support.huaweicloud.com/intl/zh-cn/api-ocr/ocr_03_0132.html)。](tag:hk)  &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 图片朝向检测开关，可选值包括： - true：打开检测图片朝向功能。 - false：关闭检测图片朝向功能。  &gt; 说明： - 支持任意角度的图片朝向检测。未传入该参数时默认为false，即不检测图片朝向。 
        /// </summary>
        [JsonProperty("detect_direction", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectDirection { get; set; }

        /// <summary>
        /// 快速模式开关，针对单行文字图片（要求图片只包含一行文字，且文字区域占比超过50%），打开时可以更快返回识别。可选值包括： - true：打开快速识别模式。 - false：关闭快速识别模式。  &gt; 说明： - 未传入该参数时默认为false，即关闭快速模式。 
        /// </summary>
        [JsonProperty("quick_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuickMode { get; set; }

        /// <summary>
        /// 单字符模式开关。可选值包括： - true：打开单字符模式。 - false：关闭单字符模式。  未传入该参数时默认为false，即不返回单个文本行的单字符信息。 
        /// </summary>
        [JsonProperty("character_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CharacterMode { get; set; }

        /// <summary>
        /// 语种选择，取值范围可参考表1中英文列。未传入该参数时默认为中英文识别模式。 **表1* 语种选择说明 | 英文 |     中文     | | :- -: | :- -- -- -- -- -: | | auto | 自动语种分类 | |  ms  |    马来语    | |  uk  |   乌克兰语   | |  hi  |    印地语    | |  ru  |     俄语     | |  vi  |    越南语    | |  id  |    印尼语    | |  th  |     泰语     | |  zh  |    中英文    | |  ar  |   阿拉伯语   | |  de  |     德语     | |  la  |    拉丁语    | |  fr  |     法语     | |  it  |   意大利语   | |  es  |   西班牙语   | |  pt  |   葡萄牙语   | |  ro  |  罗马尼亚语  | |  pl  |    波兰语    | |  am  |  阿姆哈拉语  | |  ja  |     日语     | |  ko  |     韩语     | |  tr  |   土耳其语   | |  no  |   挪威语     | |  da  |   丹麦语     | |  sv  |   瑞典语     | |  km  |   柬埔寨语   | |  he  |   希伯来语   | 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 单朝向模式开关。可选值包括： - true：打开单朝向模式。 - false：关闭单朝向模式。 图片文字方向一致时，打开该开关可提升识别精度；图片文字方向不一致时，关闭该开关可支持多朝向文字识别。未传入该参数时默认为false，即默认图片中的文字朝向为多朝向。 
        /// </summary>
        [JsonProperty("single_orientation_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SingleOrientationMode { get; set; }

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
            sb.Append("class GeneralTextRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  detectDirection: ").Append(DetectDirection).Append("\n");
            sb.Append("  quickMode: ").Append(QuickMode).Append("\n");
            sb.Append("  characterMode: ").Append(CharacterMode).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  singleOrientationMode: ").Append(SingleOrientationMode).Append("\n");
            sb.Append("  pdfPageNumber: ").Append(PdfPageNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralTextRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralTextRequestBody input)
        {
            if (input == null) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.DetectDirection != input.DetectDirection || (this.DetectDirection != null && !this.DetectDirection.Equals(input.DetectDirection))) return false;
            if (this.QuickMode != input.QuickMode || (this.QuickMode != null && !this.QuickMode.Equals(input.QuickMode))) return false;
            if (this.CharacterMode != input.CharacterMode || (this.CharacterMode != null && !this.CharacterMode.Equals(input.CharacterMode))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.SingleOrientationMode != input.SingleOrientationMode || (this.SingleOrientationMode != null && !this.SingleOrientationMode.Equals(input.SingleOrientationMode))) return false;
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
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.DetectDirection != null) hashCode = hashCode * 59 + this.DetectDirection.GetHashCode();
                if (this.QuickMode != null) hashCode = hashCode * 59 + this.QuickMode.GetHashCode();
                if (this.CharacterMode != null) hashCode = hashCode * 59 + this.CharacterMode.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SingleOrientationMode != null) hashCode = hashCode * 59 + this.SingleOrientationMode.GetHashCode();
                if (this.PdfPageNumber != null) hashCode = hashCode * 59 + this.PdfPageNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
