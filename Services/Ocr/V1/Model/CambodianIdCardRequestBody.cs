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
    public class CambodianIdCardRequestBody 
    {

        /// <summary>
        /// 与url二选一。图像数据，base64编码。图片尺寸不小于15像素，最长边不超过8192像素，支持JPG/PNG/BMP/TIF格式。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一。 图片的url路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/intl/zh-cn/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 是否返回头像内容开关，可选值如下所示： - true: 返回身份证头像照片的 base64 编码 - false: 不返回身份证头像照片的 base64 编码 未传入该参数时默认为“false”，即不返回身份证头像照片的 base64 编码。 
        /// </summary>
        [JsonProperty("return_portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitImage { get; set; }

        /// <summary>
        /// 是否返回头像坐标的开关，可选值如下所示： - true: 返回身份证头像的位置坐标 - false: 不返回身份证头像的位置坐标 未传入该参数时默认为“false”，即不返回身份证的头像坐标。 
        /// </summary>
        [JsonProperty("return_portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitLocation { get; set; }

        /// <summary>
        /// 是否返回身份证类型的开关，可选值如下所示： - true:返回身份证的类型，类型包括身份证原件以及身份证复印件 - false：不返回身份证的类型 
        /// </summary>
        [JsonProperty("return_idcard_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnIdcardType { get; set; }

        /// <summary>
        /// 返回身份证边框完整性的告警结果的开关，可选值如下所示 - true：打开身份证图像边框完整性告警功能  - false：关闭身份证图像边框完整性告警功能 
        /// </summary>
        [JsonProperty("detect_border_integrity", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBorderIntegrity { get; set; }

        /// <summary>
        /// 返回身份证内部是否有被遮挡的告警结果的开关，可选值如下所示 - true：打开身份证内部是否有被遮挡的告警功能  - false：关闭身份证内部是否有被遮挡的告警功能 
        /// </summary>
        [JsonProperty("detect_blocking_within_border", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlockingWithinBorder { get; set; }

        /// <summary>
        /// 返回身份证模糊告警结果的开关，可选值如下所示 - true:打开身份证是否模糊的告警功能 - false：关闭身份证是否模糊的告警功能 
        /// </summary>
        [JsonProperty("detect_blur", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlur { get; set; }

        /// <summary>
        /// 返回身份证是否反光的告警结果的开关，可选值如下所示 - true：打开身份证是否反光的告警功能  - false：关闭身份证是否反光的告警功能 
        /// </summary>
        [JsonProperty("detect_glare", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectGlare { get; set; }

        /// <summary>
        /// 返回身份证四点原图的base64编码 - true: 返回身份证原图的base64编码  - false：不返回身份证原图的base64编码 
        /// </summary>
        [JsonProperty("return_adjusted_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnAdjustedImage { get; set; }

        /// <summary>
        /// 返回身份证人像是否被篡改的告警结果的开关，可选值如下所示 - true:  打开身份证人像是否被篡改的告警功能  - false：关闭身份证人像被篡改的告警功能 不支持精细化的P图 
        /// </summary>
        [JsonProperty("detect_tampering", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectTampering { get; set; }

        /// <summary>
        /// 返回判断身份证图像是否经过翻拍告警的开关，可选值如下所示 - true:打开判断身份证图像是否经过翻拍告警的功能  - false:关闭判断身份证图像是否经过翻拍告警的功能 
        /// </summary>
        [JsonProperty("detect_reproduce", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectReproduce { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CambodianIdCardRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnPortraitImage: ").Append(ReturnPortraitImage).Append("\n");
            sb.Append("  returnPortraitLocation: ").Append(ReturnPortraitLocation).Append("\n");
            sb.Append("  returnIdcardType: ").Append(ReturnIdcardType).Append("\n");
            sb.Append("  detectBorderIntegrity: ").Append(DetectBorderIntegrity).Append("\n");
            sb.Append("  detectBlockingWithinBorder: ").Append(DetectBlockingWithinBorder).Append("\n");
            sb.Append("  detectBlur: ").Append(DetectBlur).Append("\n");
            sb.Append("  detectGlare: ").Append(DetectGlare).Append("\n");
            sb.Append("  returnAdjustedImage: ").Append(ReturnAdjustedImage).Append("\n");
            sb.Append("  detectTampering: ").Append(DetectTampering).Append("\n");
            sb.Append("  detectReproduce: ").Append(DetectReproduce).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CambodianIdCardRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CambodianIdCardRequestBody input)
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
                ) && 
                (
                    this.ReturnIdcardType == input.ReturnIdcardType ||
                    (this.ReturnIdcardType != null &&
                    this.ReturnIdcardType.Equals(input.ReturnIdcardType))
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
                    this.DetectGlare == input.DetectGlare ||
                    (this.DetectGlare != null &&
                    this.DetectGlare.Equals(input.DetectGlare))
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
                    this.DetectReproduce == input.DetectReproduce ||
                    (this.DetectReproduce != null &&
                    this.DetectReproduce.Equals(input.DetectReproduce))
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
                if (this.ReturnIdcardType != null)
                    hashCode = hashCode * 59 + this.ReturnIdcardType.GetHashCode();
                if (this.DetectBorderIntegrity != null)
                    hashCode = hashCode * 59 + this.DetectBorderIntegrity.GetHashCode();
                if (this.DetectBlockingWithinBorder != null)
                    hashCode = hashCode * 59 + this.DetectBlockingWithinBorder.GetHashCode();
                if (this.DetectBlur != null)
                    hashCode = hashCode * 59 + this.DetectBlur.GetHashCode();
                if (this.DetectGlare != null)
                    hashCode = hashCode * 59 + this.DetectGlare.GetHashCode();
                if (this.ReturnAdjustedImage != null)
                    hashCode = hashCode * 59 + this.ReturnAdjustedImage.GetHashCode();
                if (this.DetectTampering != null)
                    hashCode = hashCode * 59 + this.DetectTampering.GetHashCode();
                if (this.DetectReproduce != null)
                    hashCode = hashCode * 59 + this.DetectReproduce.GetHashCode();
                return hashCode;
            }
        }
    }
}
