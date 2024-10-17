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
    public class SmartDocumentRecognizerKVBlock 
    {

        /// <summary>
        /// key-value对（键值对）中的key，例如“姓名：小明”中的“姓名” 
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// key-value对（键值对）中的value，例如“姓名：小明”中的“小明” 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 该键值对中所包含的文本框数量。   
        /// </summary>
        [JsonProperty("words_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WordsBlockCount { get; set; }

        /// <summary>
        /// 文本框识别结果列表。 
        /// </summary>
        [JsonProperty("words_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartDocumentRecognizerKVWordsBlock> WordsBlockList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerKVBlock {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SmartDocumentRecognizerKVBlock);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerKVBlock input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.WordsBlockCount != null) hashCode = hashCode * 59 + this.WordsBlockCount.GetHashCode();
                if (this.WordsBlockList != null) hashCode = hashCode * 59 + this.WordsBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
