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
    public class FinancialStatementRequestBody 
    {

        /// <summary>
        /// 与url二选一  图像数据，base64编码，要求base64编码后大小不超过10MB。图片最小边不小于15px，最长边不超过8192px，支持JPEG、JPG、PNG、BMP、TIFF格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一 图片的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 返回文本块坐标及单元格坐标信息，可选值包括： - true：返回文本块和单元格坐标; - false：不返回。  &gt; 说明： - 未传入该参数时默认为false，即不返回。 
        /// </summary>
        [JsonProperty("return_text_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTextLocation { get; set; }

        /// <summary>
        /// 返回字段识别置信度，小数点后四位。可选值包括： - true：返回字段置信度; - false：不返回。  &gt; 说明： - 未传入该参数时默认为false，即不返回字段置信度。 
        /// </summary>
        [JsonProperty("return_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnConfidence { get; set; }

        /// <summary>
        /// 是否返回表格转换Microsoft Excel的base64编码字段。可选值包括： - true：返回’excel’字段，表示xlsx格式的表格识别结果的base64编码; - false：不返回。  &gt; 说明： - 对返回的Excel编码，可用Python函数 base64.b64decode解码后保存为xlsx文件。 
        /// </summary>
        [JsonProperty("return_excel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnExcel { get; set; }

        /// <summary>
        /// 返回表格坐标，可选值包括： - true：返回表格坐标; - false：不返回。  &gt; 说明： - 未传入该参数时默认为false，即不返回。 
        /// </summary>
        [JsonProperty("return_table_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnTableLocation { get; set; }

        /// <summary>
        /// 返回矫正后的图像大小，可选值包括： - true：返回矫正图像大小; - false：不返回。  &gt; 说明： - 未传入该参数时默认为false，即不返回。 
        /// </summary>
        [JsonProperty("return_image_size", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnImageSize { get; set; }

        /// <summary>
        /// 透视变换矩阵，可选值包括： - true：返回透视变换矩阵; - false：不返回。  &gt; 说明： - 未传入该参数时默认为false，即不返回透视变换矩阵。 
        /// </summary>
        [JsonProperty("return_rectification_matrix", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnRectificationMatrix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinancialStatementRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnTextLocation: ").Append(ReturnTextLocation).Append("\n");
            sb.Append("  returnConfidence: ").Append(ReturnConfidence).Append("\n");
            sb.Append("  returnExcel: ").Append(ReturnExcel).Append("\n");
            sb.Append("  returnTableLocation: ").Append(ReturnTableLocation).Append("\n");
            sb.Append("  returnImageSize: ").Append(ReturnImageSize).Append("\n");
            sb.Append("  returnRectificationMatrix: ").Append(ReturnRectificationMatrix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FinancialStatementRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FinancialStatementRequestBody input)
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
                    this.ReturnExcel == input.ReturnExcel ||
                    (this.ReturnExcel != null &&
                    this.ReturnExcel.Equals(input.ReturnExcel))
                ) && 
                (
                    this.ReturnTableLocation == input.ReturnTableLocation ||
                    (this.ReturnTableLocation != null &&
                    this.ReturnTableLocation.Equals(input.ReturnTableLocation))
                ) && 
                (
                    this.ReturnImageSize == input.ReturnImageSize ||
                    (this.ReturnImageSize != null &&
                    this.ReturnImageSize.Equals(input.ReturnImageSize))
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
                if (this.ReturnConfidence != null)
                    hashCode = hashCode * 59 + this.ReturnConfidence.GetHashCode();
                if (this.ReturnExcel != null)
                    hashCode = hashCode * 59 + this.ReturnExcel.GetHashCode();
                if (this.ReturnTableLocation != null)
                    hashCode = hashCode * 59 + this.ReturnTableLocation.GetHashCode();
                if (this.ReturnImageSize != null)
                    hashCode = hashCode * 59 + this.ReturnImageSize.GetHashCode();
                if (this.ReturnRectificationMatrix != null)
                    hashCode = hashCode * 59 + this.ReturnRectificationMatrix.GetHashCode();
                return hashCode;
            }
        }
    }
}
