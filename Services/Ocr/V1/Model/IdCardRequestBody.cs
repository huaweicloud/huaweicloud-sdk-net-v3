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
    public class IdCardRequestBody 
    {

        /// <summary>
        /// 与url二选一  图像数据，base64编码，要求base64编码后大小不超过10MB。图片最小边不小于15px，最长边不超过8000px。支持JPEG、JPG、PNG、BMP、TIFF格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        ///  - front：身份证人像面。 - back：身份证国徽面。 - double_side：身份证双面信息 &gt; 说明： 如果参数值为空或无该参数，系统自动识别，建议填写，准确率更高。 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 返回校验身份证号等信息的开关，默认false，可选值如下所示：  - true：返回校验信息  - false：不返回校验信息 
        /// </summary>
        [JsonProperty("return_verification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnVerification { get; set; }

        /// <summary>
        /// 识别到的文字块的区域位置信息。可选值包括：  - true：返回各个文字块区域  - false：不返回各个文字块区域  如果无该参数，系统默认不返回文字块区域。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_text_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTextLocation { get; set; }

        /// <summary>
        /// 返回判断身份证图像是否经过翻拍的开关，默认false，可选值如下所示：  - true ：开启判断身份证图像是否经过翻拍功能  - false：关闭判断身份证图像是否经过翻拍功能 
        /// </summary>
        [JsonProperty("detect_reproduce", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectReproduce { get; set; }

        /// <summary>
        /// 返回判断身份证图像是否是黑白复印件的开关，默认false，可选值如下所示：  - true ：开启判断身份证图像是否是复印件功能  - false : 关闭身份证图像是否是复印件功能 
        /// </summary>
        [JsonProperty("detect_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectCopy { get; set; }

        /// <summary>
        /// 返回头像位置信息的开关，默认false，可选值如下所示：  - true ：开启返回头像位置信息的功能 - false : 关闭返回头像位置信息的功能 
        /// </summary>
        [JsonProperty("return_portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitLocation { get; set; }

        /// <summary>
        /// 返回头像图片信息（base64码）的开关，默认false，可选值如下所示：  - true ：开启头像图片信息（base64码）的功能 - false : 关闭头像图片信息（base64码）的功能 
        /// </summary>
        [JsonProperty("return_portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitImage { get; set; }

        /// <summary>
        /// 返回身份证卡面（base64码）的开关，默认false，可选值如下所示：  - true ：开启身份证卡面（base64码）的功能 - false : 关闭身份证卡面（base64码）的功能 
        /// </summary>
        [JsonProperty("return_adjusted_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnAdjustedImage { get; set; }

        /// <summary>
        /// 身份证图像PS告警功能开关，默认false，可选值如下：  - true ：开启身份证图像PS告警功能 - false : 关闭身份证图像告警功能 
        /// </summary>
        [JsonProperty("detect_tampering", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectTampering { get; set; }

        /// <summary>
        /// 身份证图像边框完整性告警功能开关，默认false，可选值如下：  - true ：打开身份证图像边框完整性告警功能 - false : 关闭身份证图像边框完整性告警功能 
        /// </summary>
        [JsonProperty("detect_border_integrity", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBorderIntegrity { get; set; }

        /// <summary>
        /// 身份证图像边框内部是否有异物遮挡的告警功能开关，默认false，可选值如下：  - true ：开启身份证边框内部异物遮挡告警功能 - false : 关闭身份证边框内部异物遮挡告警功能 
        /// </summary>
        [JsonProperty("detect_blocking_within_border", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlockingWithinBorder { get; set; }

        /// <summary>
        /// 身份证图像模糊告警功能的开关，默认false，可选值如下：  - true ：开启身份证图像模糊告警功能 - false : 关闭身份证图像模糊告警功能 
        /// </summary>
        [JsonProperty("detect_blur", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlur { get; set; }

        /// <summary>
        /// 临时身份证告警功能开关，默认false，可选值如下：  - true ：开启临时身份证告警功能 - false : 关闭临时身份证告警功能 
        /// </summary>
        [JsonProperty("detect_interim", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectInterim { get; set; }

        /// <summary>
        /// 身份证反光告警功能开关，默认false，可选值如下：  - true ：开启身份证反光告警功能  - false : 关闭身份证反光告警功能 
        /// </summary>
        [JsonProperty("detect_glare", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectGlare { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdCardRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  returnVerification: ").Append(ReturnVerification).Append("\n");
            sb.Append("  returnTextLocation: ").Append(ReturnTextLocation).Append("\n");
            sb.Append("  detectReproduce: ").Append(DetectReproduce).Append("\n");
            sb.Append("  detectCopy: ").Append(DetectCopy).Append("\n");
            sb.Append("  returnPortraitLocation: ").Append(ReturnPortraitLocation).Append("\n");
            sb.Append("  returnPortraitImage: ").Append(ReturnPortraitImage).Append("\n");
            sb.Append("  returnAdjustedImage: ").Append(ReturnAdjustedImage).Append("\n");
            sb.Append("  detectTampering: ").Append(DetectTampering).Append("\n");
            sb.Append("  detectBorderIntegrity: ").Append(DetectBorderIntegrity).Append("\n");
            sb.Append("  detectBlockingWithinBorder: ").Append(DetectBlockingWithinBorder).Append("\n");
            sb.Append("  detectBlur: ").Append(DetectBlur).Append("\n");
            sb.Append("  detectInterim: ").Append(DetectInterim).Append("\n");
            sb.Append("  detectGlare: ").Append(DetectGlare).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdCardRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdCardRequestBody input)
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
                    this.ReturnVerification == input.ReturnVerification ||
                    (this.ReturnVerification != null &&
                    this.ReturnVerification.Equals(input.ReturnVerification))
                ) && 
                (
                    this.ReturnTextLocation == input.ReturnTextLocation ||
                    (this.ReturnTextLocation != null &&
                    this.ReturnTextLocation.Equals(input.ReturnTextLocation))
                ) && 
                (
                    this.DetectReproduce == input.DetectReproduce ||
                    (this.DetectReproduce != null &&
                    this.DetectReproduce.Equals(input.DetectReproduce))
                ) && 
                (
                    this.DetectCopy == input.DetectCopy ||
                    (this.DetectCopy != null &&
                    this.DetectCopy.Equals(input.DetectCopy))
                ) && 
                (
                    this.ReturnPortraitLocation == input.ReturnPortraitLocation ||
                    (this.ReturnPortraitLocation != null &&
                    this.ReturnPortraitLocation.Equals(input.ReturnPortraitLocation))
                ) && 
                (
                    this.ReturnPortraitImage == input.ReturnPortraitImage ||
                    (this.ReturnPortraitImage != null &&
                    this.ReturnPortraitImage.Equals(input.ReturnPortraitImage))
                ) && 
                (
                    this.ReturnAdjustedImage == input.ReturnAdjustedImage ||
                    (this.ReturnAdjustedImage != null &&
                    this.ReturnAdjustedImage.Equals(input.ReturnAdjustedImage))
                ) && 
                (
                    this.DetectTampering == input.DetectTampering ||
                    (this.DetectTampering != null &&
                    this.DetectTampering.Equals(input.DetectTampering))
                ) && 
                (
                    this.DetectBorderIntegrity == input.DetectBorderIntegrity ||
                    (this.DetectBorderIntegrity != null &&
                    this.DetectBorderIntegrity.Equals(input.DetectBorderIntegrity))
                ) && 
                (
                    this.DetectBlockingWithinBorder == input.DetectBlockingWithinBorder ||
                    (this.DetectBlockingWithinBorder != null &&
                    this.DetectBlockingWithinBorder.Equals(input.DetectBlockingWithinBorder))
                ) && 
                (
                    this.DetectBlur == input.DetectBlur ||
                    (this.DetectBlur != null &&
                    this.DetectBlur.Equals(input.DetectBlur))
                ) && 
                (
                    this.DetectInterim == input.DetectInterim ||
                    (this.DetectInterim != null &&
                    this.DetectInterim.Equals(input.DetectInterim))
                ) && 
                (
                    this.DetectGlare == input.DetectGlare ||
                    (this.DetectGlare != null &&
                    this.DetectGlare.Equals(input.DetectGlare))
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
                if (this.ReturnVerification != null)
                    hashCode = hashCode * 59 + this.ReturnVerification.GetHashCode();
                if (this.ReturnTextLocation != null)
                    hashCode = hashCode * 59 + this.ReturnTextLocation.GetHashCode();
                if (this.DetectReproduce != null)
                    hashCode = hashCode * 59 + this.DetectReproduce.GetHashCode();
                if (this.DetectCopy != null)
                    hashCode = hashCode * 59 + this.DetectCopy.GetHashCode();
                if (this.ReturnPortraitLocation != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitLocation.GetHashCode();
                if (this.ReturnPortraitImage != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitImage.GetHashCode();
                if (this.ReturnAdjustedImage != null)
                    hashCode = hashCode * 59 + this.ReturnAdjustedImage.GetHashCode();
                if (this.DetectTampering != null)
                    hashCode = hashCode * 59 + this.DetectTampering.GetHashCode();
                if (this.DetectBorderIntegrity != null)
                    hashCode = hashCode * 59 + this.DetectBorderIntegrity.GetHashCode();
                if (this.DetectBlockingWithinBorder != null)
                    hashCode = hashCode * 59 + this.DetectBlockingWithinBorder.GetHashCode();
                if (this.DetectBlur != null)
                    hashCode = hashCode * 59 + this.DetectBlur.GetHashCode();
                if (this.DetectInterim != null)
                    hashCode = hashCode * 59 + this.DetectInterim.GetHashCode();
                if (this.DetectGlare != null)
                    hashCode = hashCode * 59 + this.DetectGlare.GetHashCode();
                return hashCode;
            }
        }
    }
}
