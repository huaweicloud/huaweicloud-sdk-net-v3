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
    public class GeneralTableRequestBody 
    {

        /// <summary>
        /// 与url二选一  图片最小边不小于15px，最长边不超过8192px，支持JPEG、JPG、PNG、BMP、TIFF格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。   
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 返回文本块坐标及单元格坐标信息，可选值如下所示： - true：返回文本块和单元格坐标 - false：不返回  &gt; 说明： - 如果未传入该参数时默认为false，即不返回。 
        /// </summary>
        [JsonProperty("return_text_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTextLocation { get; set; }

        /// <summary>
        /// 返回单字符的坐标信息，可选值包括： - true：返回单字符的坐标 - false：不返回  未传入该参数时默认为false，即不返回。如果此参数为true时，return_text_loaction必须为true 
        /// </summary>
        [JsonProperty("return_char_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnCharLocation { get; set; }

        /// <summary>
        /// 是否返回置信度的开关，可选值包括： - true：返回置信度 - false：不返回置信度  &gt; 说明： - 如果未传入该参数，系统默认为“false”，即不返回置信度。 
        /// </summary>
        [JsonProperty("return_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnConfidence { get; set; }

        /// <summary>
        /// 是否返回表格转换Microsoft Excel的base64编码字段。可选值包括： - true：返回&#39;excel&#39;字段，表示xlsx格式的表格识别结果的base64编码 - false：不返回。默认为false  &gt; 说明： - 对返回的Excel编码，可用Python函数 base64.b64decode解码后保存为.xlsx文件。 
        /// </summary>
        [JsonProperty("return_excel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnExcel { get; set; }

        /// <summary>
        /// 可选值包括： - true：返回透视变换矩阵 - false：不返回  未传入该参数时默认为false，即不返回透视变换矩阵。 
        /// </summary>
        [JsonProperty("return_rectification_matrix", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnRectificationMatrix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralTableRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnTextLocation: ").Append(ReturnTextLocation).Append("\n");
            sb.Append("  returnCharLocation: ").Append(ReturnCharLocation).Append("\n");
            sb.Append("  returnConfidence: ").Append(ReturnConfidence).Append("\n");
            sb.Append("  returnExcel: ").Append(ReturnExcel).Append("\n");
            sb.Append("  returnRectificationMatrix: ").Append(ReturnRectificationMatrix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralTableRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralTableRequestBody input)
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
                    this.ReturnCharLocation == input.ReturnCharLocation ||
                    (this.ReturnCharLocation != null &&
                    this.ReturnCharLocation.Equals(input.ReturnCharLocation))
                ) && 
                (
                    this.ReturnConfidence == input.ReturnConfidence ||
                    (this.ReturnConfidence != null &&
                    this.ReturnConfidence.Equals(input.ReturnConfidence))
                ) && 
                (
                    this.ReturnExcel == input.ReturnExcel ||
                    (this.ReturnExcel != null &&
                    this.ReturnExcel.Equals(input.ReturnExcel))
                ) && 
                (
                    this.ReturnRectificationMatrix == input.ReturnRectificationMatrix ||
                    (this.ReturnRectificationMatrix != null &&
                    this.ReturnRectificationMatrix.Equals(input.ReturnRectificationMatrix))
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
                if (this.ReturnCharLocation != null)
                    hashCode = hashCode * 59 + this.ReturnCharLocation.GetHashCode();
                if (this.ReturnConfidence != null)
                    hashCode = hashCode * 59 + this.ReturnConfidence.GetHashCode();
                if (this.ReturnExcel != null)
                    hashCode = hashCode * 59 + this.ReturnExcel.GetHashCode();
                if (this.ReturnRectificationMatrix != null)
                    hashCode = hashCode * 59 + this.ReturnRectificationMatrix.GetHashCode();
                return hashCode;
            }
        }
    }
}
