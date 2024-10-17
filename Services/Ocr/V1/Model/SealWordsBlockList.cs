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
    public class SealWordsBlockList 
    {

        /// <summary>
        /// 印章文本块。
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 印章文本块的置信度。
        /// </summary>
        [JsonProperty("words_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? WordsConfidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SealWordsBlockList {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  wordsConfidence: ").Append(WordsConfidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SealWordsBlockList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SealWordsBlockList input)
        {
            if (input == null) return false;
            if (this.Words != input.Words || (this.Words != null && !this.Words.Equals(input.Words))) return false;
            if (this.WordsConfidence != input.WordsConfidence || (this.WordsConfidence != null && !this.WordsConfidence.Equals(input.WordsConfidence))) return false;

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
                if (this.WordsConfidence != null) hashCode = hashCode * 59 + this.WordsConfidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
