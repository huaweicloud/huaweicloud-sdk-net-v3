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
    public class FinancialStatementResult 
    {

        /// <summary>
        /// 识别出来的表格、文本区域个数。 
        /// </summary>
        [JsonProperty("words_region_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WordsRegionCount { get; set; }

        /// <summary>
        /// 返回的表格、文本区域列表。输出顺序从左到右，从上到下。 
        /// </summary>
        [JsonProperty("words_region_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FinancialStatementWordsRegionList> WordsRegionList { get; set; }

        /// <summary>
        /// 表格图像转换为excel的base64编码，图像中的文字和表格按位置写入excel，可编辑。对返回的excel编码，可用base64.b64decode解码并保存为xlsx文件。 
        /// </summary>
        [JsonProperty("excel", NullValueHandling = NullValueHandling.Ignore)]
        public string Excel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_size", NullValueHandling = NullValueHandling.Ignore)]
        public FinancialStatementResultImageSize ImageSize { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinancialStatementResult {\n");
            sb.Append("  wordsRegionCount: ").Append(WordsRegionCount).Append("\n");
            sb.Append("  wordsRegionList: ").Append(WordsRegionList).Append("\n");
            sb.Append("  excel: ").Append(Excel).Append("\n");
            sb.Append("  imageSize: ").Append(ImageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FinancialStatementResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FinancialStatementResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WordsRegionCount == input.WordsRegionCount ||
                    (this.WordsRegionCount != null &&
                    this.WordsRegionCount.Equals(input.WordsRegionCount))
                ) && 
                (
                    this.WordsRegionList == input.WordsRegionList ||
                    this.WordsRegionList != null &&
                    input.WordsRegionList != null &&
                    this.WordsRegionList.SequenceEqual(input.WordsRegionList)
                ) && 
                (
                    this.Excel == input.Excel ||
                    (this.Excel != null &&
                    this.Excel.Equals(input.Excel))
                ) && 
                (
                    this.ImageSize == input.ImageSize ||
                    (this.ImageSize != null &&
                    this.ImageSize.Equals(input.ImageSize))
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
                if (this.WordsRegionCount != null)
                    hashCode = hashCode * 59 + this.WordsRegionCount.GetHashCode();
                if (this.WordsRegionList != null)
                    hashCode = hashCode * 59 + this.WordsRegionList.GetHashCode();
                if (this.Excel != null)
                    hashCode = hashCode * 59 + this.Excel.GetHashCode();
                if (this.ImageSize != null)
                    hashCode = hashCode * 59 + this.ImageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
