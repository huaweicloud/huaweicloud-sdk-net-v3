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
    public class VehicleLicenseRequestBody 
    {

        /// <summary>
        /// 与url二选一。  图片的Base64编码，要求单个图片其对应的Base64编码不超过10MB。文件在Base64编码后会大于文件原本大小，请注意做好边界判断，建议文件大小不超过7MB。 图片最小边不小于100px，最长边不超过8192px。支持JPEG、JPG、PNG、BMP、TIFF格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。   
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一。  单个图片其对应的Base64编码不超过10MB。文件在Base64编码后会大于文件原本大小，请注意做好边界判断，建议文件大小不超过7MB。 图片最小边不小于100px，最长边不超过8192px。支持JPEG、JPG、PNG、BMP、TIFF格式。 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        ///  - front：行驶证主页  - back：行驶证副页  - double_side：行驶证双页信息  &gt; 说明： 如果参数值为空或无该参数，系统默认识别主页，建议填写，准确率更高。 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 是否返回发证机关的开关，可选值包括： - true：返回发证机关 - false：不返回发证机关  &gt; 说明： - 如果无该参数，系统默认不返回发证机关。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnIssuingAuthority { get; set; }

        /// <summary>
        /// 识别到的文字块的区域位置信息。取值范围：  - true：返回各个文字块区域  - false：不返回各个文字块区域  如果无该参数，系统默认不返回文字块区域。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("return_text_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTextLocation { get; set; }

        /// <summary>
        /// 是否支持识别电子行驶证，取值范围：  - true：支持识别电子行驶证  - false：不支持识别电子行驶证  默认不支持识别电子行驶证。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("recognize_electronic_license", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecognizeElectronicLicense { get; set; }

        /// <summary>
        /// 是否返回纸质行驶证图像的告警信息，可选值包括： - true：返回纸质行驶证图像的告警信息 - false：不返回纸质行驶证图像的告警信息 如果无该参数，系统默认不返回告警信息。如果输入参数不是Boolean类型，则会报非法参数错误。 
        /// </summary>
        [JsonProperty("alarm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alarm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleLicenseRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  returnIssuingAuthority: ").Append(ReturnIssuingAuthority).Append("\n");
            sb.Append("  returnTextLocation: ").Append(ReturnTextLocation).Append("\n");
            sb.Append("  recognizeElectronicLicense: ").Append(RecognizeElectronicLicense).Append("\n");
            sb.Append("  alarm: ").Append(Alarm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VehicleLicenseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VehicleLicenseRequestBody input)
        {
            if (input == null) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Side != input.Side || (this.Side != null && !this.Side.Equals(input.Side))) return false;
            if (this.ReturnIssuingAuthority != input.ReturnIssuingAuthority || (this.ReturnIssuingAuthority != null && !this.ReturnIssuingAuthority.Equals(input.ReturnIssuingAuthority))) return false;
            if (this.ReturnTextLocation != input.ReturnTextLocation || (this.ReturnTextLocation != null && !this.ReturnTextLocation.Equals(input.ReturnTextLocation))) return false;
            if (this.RecognizeElectronicLicense != input.RecognizeElectronicLicense || (this.RecognizeElectronicLicense != null && !this.RecognizeElectronicLicense.Equals(input.RecognizeElectronicLicense))) return false;
            if (this.Alarm != input.Alarm || (this.Alarm != null && !this.Alarm.Equals(input.Alarm))) return false;

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
                if (this.Side != null) hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.ReturnIssuingAuthority != null) hashCode = hashCode * 59 + this.ReturnIssuingAuthority.GetHashCode();
                if (this.ReturnTextLocation != null) hashCode = hashCode * 59 + this.ReturnTextLocation.GetHashCode();
                if (this.RecognizeElectronicLicense != null) hashCode = hashCode * 59 + this.RecognizeElectronicLicense.GetHashCode();
                if (this.Alarm != null) hashCode = hashCode * 59 + this.Alarm.GetHashCode();
                return hashCode;
            }
        }
    }
}
