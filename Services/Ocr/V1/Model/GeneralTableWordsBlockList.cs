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
    /// 子区域识别文字块列表，输出顺序从左到右，先上后下。
    /// </summary>
    public class GeneralTableWordsBlockList 
    {

        /// <summary>
        /// 文字块识别结果。 
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 字段的平均置信度，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 文字块位置信息，列表形式，分别表示文字块4个顶点的x, y坐标;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 单元格内文字段列表。输出顺序从左到右，从上到下。仅当入参\&quot;return_text_location\&quot;为true时存在。 
        /// </summary>
        [JsonProperty("words_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<WordsListIem> WordsList { get; set; }

        /// <summary>
        /// 文字块占用的行信息，编号从0开始，列表形式，数据类型为Integer。仅在表格区域内有效，即type字段为\&quot;table\&quot;时该字段有效。 
        /// </summary>
        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Rows { get; set; }

        /// <summary>
        /// 文字块占用的列信息，编号从0开始，列表形式，数据类型为Integer。仅在表格区域内有效，即type字段为\&quot;table\&quot;时该字段有效。 
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
            sb.Append("class GeneralTableWordsBlockList {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  wordsList: ").Append(WordsList).Append("\n");
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
            return this.Equals(input as GeneralTableWordsBlockList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralTableWordsBlockList input)
        {
            if (input == null) return false;
            if (this.Words != input.Words || (this.Words != null && !this.Words.Equals(input.Words))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.Location != input.Location || (this.Location != null && input.Location != null && !this.Location.SequenceEqual(input.Location))) return false;
            if (this.WordsList != input.WordsList || (this.WordsList != null && input.WordsList != null && !this.WordsList.SequenceEqual(input.WordsList))) return false;
            if (this.Rows != input.Rows || (this.Rows != null && input.Rows != null && !this.Rows.SequenceEqual(input.Rows))) return false;
            if (this.Columns != input.Columns || (this.Columns != null && input.Columns != null && !this.Columns.SequenceEqual(input.Columns))) return false;
            if (this.CellLocation != input.CellLocation || (this.CellLocation != null && input.CellLocation != null && !this.CellLocation.SequenceEqual(input.CellLocation))) return false;

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
                if (this.Words != null) hashCode = hashCode * 59 + this.Words.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.WordsList != null) hashCode = hashCode * 59 + this.WordsList.GetHashCode();
                if (this.Rows != null) hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.Columns != null) hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.CellLocation != null) hashCode = hashCode * 59 + this.CellLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
