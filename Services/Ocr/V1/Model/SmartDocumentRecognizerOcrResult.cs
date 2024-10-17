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
    public class SmartDocumentRecognizerOcrResult 
    {

        /// <summary>
        /// 图片朝向 
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public float? Direction { get; set; }

        /// <summary>
        /// 识别文字块数目。 
        /// </summary>
        [JsonProperty("words_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WordsBlockCount { get; set; }

        /// <summary>
        /// 识别文字块列表，输出顺序从左到右，先上后下。 
        /// </summary>
        [JsonProperty("words_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartDocumentRecognizerWordsBlockList> WordsBlockList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerOcrResult {\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  wordsBlockCount: ").Append(WordsBlockCount).Append("\n");
            sb.Append("  wordsBlockList: ").Append(WordsBlockList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerOcrResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerOcrResult input)
        {
            if (input == null) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.WordsBlockCount != input.WordsBlockCount || (this.WordsBlockCount != null && !this.WordsBlockCount.Equals(input.WordsBlockCount))) return false;
            if (this.WordsBlockList != input.WordsBlockList || (this.WordsBlockList != null && input.WordsBlockList != null && !this.WordsBlockList.SequenceEqual(input.WordsBlockList))) return false;

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
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.WordsBlockCount != null) hashCode = hashCode * 59 + this.WordsBlockCount.GetHashCode();
                if (this.WordsBlockList != null) hashCode = hashCode * 59 + this.WordsBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
