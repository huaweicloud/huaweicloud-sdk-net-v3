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
    /// 文字区域识别结果列表，输出顺序从左到右，先上后下。
    /// </summary>
    public class WordsRegionList 
    {

        /// <summary>
        /// 文字识别区域类型。 - text：文本识别区域; - table：表格识别区域。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 子区域识别文字块数目。 
        /// </summary>
        [JsonProperty("words_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WordsBlockCount { get; set; }

        /// <summary>
        /// 子区域识别文字块列表，输出顺序从左到右，先上后下。 
        /// </summary>
        [JsonProperty("words_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneralTableWordsBlockList> WordsBlockList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WordsRegionList {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
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
            return this.Equals(input as WordsRegionList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WordsRegionList input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.WordsBlockCount != null) hashCode = hashCode * 59 + this.WordsBlockCount.GetHashCode();
                if (this.WordsBlockList != null) hashCode = hashCode * 59 + this.WordsBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
