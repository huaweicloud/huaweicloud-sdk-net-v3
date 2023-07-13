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
    public class FinancialStatementWordsBlockList 
    {

        /// <summary>
        /// 文字块内容。当入参\&quot;return_text_location\&quot;为false时，每个单元格返回一个文本值，不同行文本由换行符 \&quot;\\n\&quot; 拼接。 
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 文字块位置信息，列表形式，分别表示文字块4个顶点的x, y坐标;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 文字块识别结果置信度信息，置信度越大，表示本次识别的对应字段的可靠性越大，在统计意义上，置信度越大正确率越高。注：置信度由算法给出，其不直接等价于对应字段的精度。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 单元格行信息，列表形式。多个连续值表示单元格垮多行。 
        /// </summary>
        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Rows { get; set; }

        /// <summary>
        /// 单元格列信息，列表形式。多个连续值表示单元格垮多列。 
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Columns { get; set; }

        /// <summary>
        /// 单元格位置信息，列表形式，分别表示单元格4个顶点的x, y坐标;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("cell_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> CellLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinancialStatementWordsBlockList {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  rows: ").Append(Rows).Append("\n");
            sb.Append("  columns: ").Append(Columns).Append("\n");
            sb.Append("  cellLocation: ").Append(CellLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FinancialStatementWordsBlockList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FinancialStatementWordsBlockList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Words == input.Words ||
                    (this.Words != null &&
                    this.Words.Equals(input.Words))
                ) && 
                (
                    this.Location == input.Location ||
                    this.Location != null &&
                    input.Location != null &&
                    this.Location.SequenceEqual(input.Location)
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    input.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.CellLocation == input.CellLocation ||
                    this.CellLocation != null &&
                    input.CellLocation != null &&
                    this.CellLocation.SequenceEqual(input.CellLocation)
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
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.CellLocation != null)
                    hashCode = hashCode * 59 + this.CellLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
