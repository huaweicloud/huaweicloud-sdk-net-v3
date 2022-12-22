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
    /// 单个单词的发音评测结果
    /// </summary>
    public class Word 
    {

        /// <summary>
        /// 去除了所有标点符号后的原始文本 前端调用接口后推荐使用“​text​”来在UI 中展示结果
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 接口接收的原始文本
        /// </summary>
        [JsonProperty("text_original", NullValueHandling = NullValueHandling.Ignore)]
        public string TextOriginal { get; set; }

        /// <summary>
        /// 原始文本规范化后切分成的单词 如175 会 规范为 [\&quot;one\&quot;, \&quot;\&quot;hundred\&quot;, \&quot;and\&quot;, \&quot;seventy\&quot;, \&quot;five\&quot;]
        /// </summary>
        [JsonProperty("text_normalised", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TextNormalised { get; set; }

        /// <summary>
        /// 是否命中模型发音字典 如果未命中，则表明会根据发音规律推测正确发音
        /// </summary>
        [JsonProperty("out_of_vocabulary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OutOfVocabulary { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? EndTime { get; set; }

        /// <summary>
        /// 综合评分
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public float? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pronunciation", NullValueHandling = NullValueHandling.Ignore)]
        public WordPronunciation Pronunciation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fluency", NullValueHandling = NullValueHandling.Ignore)]
        public WordFluency Fluency { get; set; }

        /// <summary>
        /// 音节打分表
        /// </summary>
        [JsonProperty("phonemes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Phoneme> Phonemes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Word {\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  textOriginal: ").Append(TextOriginal).Append("\n");
            sb.Append("  textNormalised: ").Append(TextNormalised).Append("\n");
            sb.Append("  outOfVocabulary: ").Append(OutOfVocabulary).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  pronunciation: ").Append(Pronunciation).Append("\n");
            sb.Append("  fluency: ").Append(Fluency).Append("\n");
            sb.Append("  phonemes: ").Append(Phonemes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Word);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Word input)
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
                    this.TextOriginal == input.TextOriginal ||
                    (this.TextOriginal != null &&
                    this.TextOriginal.Equals(input.TextOriginal))
                ) && 
                (
                    this.TextNormalised == input.TextNormalised ||
                    this.TextNormalised != null &&
                    input.TextNormalised != null &&
                    this.TextNormalised.SequenceEqual(input.TextNormalised)
                ) && 
                (
                    this.OutOfVocabulary == input.OutOfVocabulary ||
                    (this.OutOfVocabulary != null &&
                    this.OutOfVocabulary.Equals(input.OutOfVocabulary))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Pronunciation == input.Pronunciation ||
                    (this.Pronunciation != null &&
                    this.Pronunciation.Equals(input.Pronunciation))
                ) && 
                (
                    this.Fluency == input.Fluency ||
                    (this.Fluency != null &&
                    this.Fluency.Equals(input.Fluency))
                ) && 
                (
                    this.Phonemes == input.Phonemes ||
                    this.Phonemes != null &&
                    input.Phonemes != null &&
                    this.Phonemes.SequenceEqual(input.Phonemes)
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
                if (this.TextOriginal != null)
                    hashCode = hashCode * 59 + this.TextOriginal.GetHashCode();
                if (this.TextNormalised != null)
                    hashCode = hashCode * 59 + this.TextNormalised.GetHashCode();
                if (this.OutOfVocabulary != null)
                    hashCode = hashCode * 59 + this.OutOfVocabulary.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Pronunciation != null)
                    hashCode = hashCode * 59 + this.Pronunciation.GetHashCode();
                if (this.Fluency != null)
                    hashCode = hashCode * 59 + this.Fluency.GetHashCode();
                if (this.Phonemes != null)
                    hashCode = hashCode * 59 + this.Phonemes.GetHashCode();
                return hashCode;
            }
        }
    }
}
