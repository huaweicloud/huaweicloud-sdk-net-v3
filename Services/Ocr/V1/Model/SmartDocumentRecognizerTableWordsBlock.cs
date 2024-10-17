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
    public class SmartDocumentRecognizerTableWordsBlock 
    {

        /// <summary>
        /// 单元格内的文字识别结果。 
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 文字块占用的行信息，编号从0开始，列表形式，数据类型为Integer。 
        /// </summary>
        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Rows { get; set; }

        /// <summary>
        /// 文字块占用的列信息，编号从0开始，列表形式，数据类型为Integer。 
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Columns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerTableWordsBlock {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  rows: ").Append(Rows).Append("\n");
            sb.Append("  columns: ").Append(Columns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerTableWordsBlock);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerTableWordsBlock input)
        {
            if (input == null) return false;
            if (this.Words != input.Words || (this.Words != null && !this.Words.Equals(input.Words))) return false;
            if (this.Rows != input.Rows || (this.Rows != null && input.Rows != null && !this.Rows.SequenceEqual(input.Rows))) return false;
            if (this.Columns != input.Columns || (this.Columns != null && input.Columns != null && !this.Columns.SequenceEqual(input.Columns))) return false;

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
                if (this.Rows != null) hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.Columns != null) hashCode = hashCode * 59 + this.Columns.GetHashCode();
                return hashCode;
            }
        }
    }
}
