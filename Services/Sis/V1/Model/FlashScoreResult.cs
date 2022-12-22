using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlashScoreResult 
    {

        /// <summary>
        /// 调用成功表示识别出的内容。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 调用成功表示识别出的置信度，取值范围：0~1。
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public double? Score { get; set; }

        /// <summary>
        /// 分词信息列表
        /// </summary>
        [JsonProperty("word_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<WordInfo> WordInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlashScoreResult {\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  wordInfo: ").Append(WordInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlashScoreResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlashScoreResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.WordInfo == input.WordInfo ||
                    this.WordInfo != null &&
                    input.WordInfo != null &&
                    this.WordInfo.SequenceEqual(input.WordInfo)
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.WordInfo != null)
                    hashCode = hashCode * 59 + this.WordInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
