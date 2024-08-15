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
    public class SmartDocumentRecognizerRequestBody 
    {

        /// <summary>
        /// 与url二选一。图片或PDF格式，base64编码，要求base64编码后大小不超过10M。 图像尺寸不小于15×15像素，最长边不超过8192像素，支持JPG/PNG/BMP/TIFF格式。 PDF以144dpi的分辨率转为图像进行文档解析，需符合上述图像尺寸规定。若PDF有多页，当前仅对第1页进行识别。 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// 与data二选一。 图片或PDF的URL路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 单朝向模式开关。可选值包括： - true：打开单朝向模式 - false：关闭单朝向模式  未传入该参数时默认为false，即默认图片中的字段为多朝向 
        /// </summary>
        [JsonProperty("single_orientation_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SingleOrientationMode { get; set; }

        /// <summary>
        /// 是否进行键值对（key-value）提取。若是，结果会以“kv_result”这一关键字返回。 
        /// </summary>
        [JsonProperty("kv", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kv { get; set; }

        /// <summary>
        /// 是否进行表格识别。此处表格特指逻辑表格，通常具有M行N列的形式，且第一行或第一列为表头。若是，结果会以“table_result”这一关键字返回。 
        /// </summary>
        [JsonProperty("table", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Table { get; set; }

        /// <summary>
        /// 是否进行版面分析。若是，结果会以“layout_result”这一关键字返回。 
        /// </summary>
        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Layout { get; set; }

        /// <summary>
        /// 仅当table为True时有效。是否返回表格转换Microsoft Excel的Base64编码字段。 
        /// </summary>
        [JsonProperty("return_excel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnExcel { get; set; }

        /// <summary>
        /// 是否进行有线表单识别。有线表单指关键信息以有线单元格形式进行呈现，例如户口本、机动车发票等。若是，结果会以\&quot;form_result\&quot;这一关键字返回。 
        /// </summary>
        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Form { get; set; }

        /// <summary>
        /// 是否进行公式识别，识别结果为latex序列。若是，结果会以“formula_result”这一关键字返回。 当前仅支持文档（例如论文）中的公式识别，不支持公式切片图像。 
        /// </summary>
        [JsonProperty("formula", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Formula { get; set; }

        /// <summary>
        /// 需要传入字典的json序列化后字符串，用于对kv_result中的特定key值进行归一化映射。例如，kv_result中包含{\&quot;名称\&quot;：\&quot;小明\&quot;}的键值对，若传入{\&quot;名称\&quot;：\&quot;姓名\&quot;}的kv_map，则返回结果为{“姓名”：“小明”}。  &gt; 参数传入示例： - \&quot;kv_map\&quot;:\&quot;{\\\&quot;名称\\\&quot;:\\\&quot;姓名\\\&quot;}\&quot; 
        /// </summary>
        [JsonProperty("kv_map", NullValueHandling = NullValueHandling.Ignore)]
        public string KvMap { get; set; }

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
            sb.Append("class SmartDocumentRecognizerRequestBody {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  singleOrientationMode: ").Append(SingleOrientationMode).Append("\n");
            sb.Append("  kv: ").Append(Kv).Append("\n");
            sb.Append("  table: ").Append(Table).Append("\n");
            sb.Append("  layout: ").Append(Layout).Append("\n");
            sb.Append("  returnExcel: ").Append(ReturnExcel).Append("\n");
            sb.Append("  form: ").Append(Form).Append("\n");
            sb.Append("  formula: ").Append(Formula).Append("\n");
            sb.Append("  kvMap: ").Append(KvMap).Append("\n");
            sb.Append("  pdfPageNumber: ").Append(PdfPageNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.SingleOrientationMode == input.SingleOrientationMode ||
                    (this.SingleOrientationMode != null &&
                    this.SingleOrientationMode.Equals(input.SingleOrientationMode))
                ) && 
                (
                    this.Kv == input.Kv ||
                    (this.Kv != null &&
                    this.Kv.Equals(input.Kv))
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.ReturnExcel == input.ReturnExcel ||
                    (this.ReturnExcel != null &&
                    this.ReturnExcel.Equals(input.ReturnExcel))
                ) && 
                (
                    this.Form == input.Form ||
                    (this.Form != null &&
                    this.Form.Equals(input.Form))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.KvMap == input.KvMap ||
                    (this.KvMap != null &&
                    this.KvMap.Equals(input.KvMap))
                ) && 
                (
                    this.PdfPageNumber == input.PdfPageNumber ||
                    (this.PdfPageNumber != null &&
                    this.PdfPageNumber.Equals(input.PdfPageNumber))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.SingleOrientationMode != null)
                    hashCode = hashCode * 59 + this.SingleOrientationMode.GetHashCode();
                if (this.Kv != null)
                    hashCode = hashCode * 59 + this.Kv.GetHashCode();
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.ReturnExcel != null)
                    hashCode = hashCode * 59 + this.ReturnExcel.GetHashCode();
                if (this.Form != null)
                    hashCode = hashCode * 59 + this.Form.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.KvMap != null)
                    hashCode = hashCode * 59 + this.KvMap.GetHashCode();
                if (this.PdfPageNumber != null)
                    hashCode = hashCode * 59 + this.PdfPageNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
