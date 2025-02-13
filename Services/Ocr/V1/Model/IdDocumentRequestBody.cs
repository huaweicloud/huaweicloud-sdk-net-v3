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
    public class IdDocumentRequestBody 
    {

        /// <summary>
        /// 该参数与url二选一。图像数据，base64编码，要求base64编码后大小不超过10MB。图片最小边不小于100px，最长边不超过8192px，支持JPEG、JPG、PNG、BMP、TIFF。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 该参数与image二选一。  要求base64编码后大小不超过10MB。 图片最小边不小于100px，最长边不超过8192px，支持JPEG、JPG、PNG、BMP、TIFF。 图片的url路径，目前支持： Image URL. Currently, the following URLs are supported: - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。 &gt; 说明: - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 证件签发国家或地区代码，命名遵循ISO-3166 3位代码。可选值。支持填写1个或多个国家/地区。指定参数后，服务只识别指定国家/地区的卡证，如留空，则识别所有地区卡证。建议国家/地区固定或有限范围的情况下填写。支持国家/地区列表见表1国家/地区和证件列表。 
        /// </summary>
        [JsonProperty("country_region", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CountryRegion { get; set; }

        /// <summary>
        /// 证件类型。可选值。支持填写1种或多种证件。指定参数后，服务只识别指定类型的卡证，如留空，默认识别所有类型卡证，建议已知证件类型的情况下填写。支持证件类型如下： - PP: passport，国际护照。 - DL: driving license，驾驶证。 - ID: identification card，各国颁发的身份证类型证件，比如身份证、选民卡、社保卡等。 
        /// </summary>
        [JsonProperty("id_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IdType { get; set; }

        /// <summary>
        /// 控制是否返回portrait_image（证件中的人像图片），True代表需要返回，False代表不需要。 
        /// </summary>
        [JsonProperty("return_portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitImage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdDocumentRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  countryRegion: ").Append(CountryRegion).Append("\n");
            sb.Append("  idType: ").Append(IdType).Append("\n");
            sb.Append("  returnPortraitImage: ").Append(ReturnPortraitImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdDocumentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdDocumentRequestBody input)
        {
            if (input == null) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.CountryRegion != input.CountryRegion || (this.CountryRegion != null && input.CountryRegion != null && !this.CountryRegion.SequenceEqual(input.CountryRegion))) return false;
            if (this.IdType != input.IdType || (this.IdType != null && input.IdType != null && !this.IdType.SequenceEqual(input.IdType))) return false;
            if (this.ReturnPortraitImage != input.ReturnPortraitImage || (this.ReturnPortraitImage != null && !this.ReturnPortraitImage.Equals(input.ReturnPortraitImage))) return false;

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
                if (this.CountryRegion != null) hashCode = hashCode * 59 + this.CountryRegion.GetHashCode();
                if (this.IdType != null) hashCode = hashCode * 59 + this.IdType.GetHashCode();
                if (this.ReturnPortraitImage != null) hashCode = hashCode * 59 + this.ReturnPortraitImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
