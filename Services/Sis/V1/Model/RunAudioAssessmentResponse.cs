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
    /// Response Object
    /// </summary>
    public class RunAudioAssessmentResponse : SdkResponse
    {

        /// <summary>
        /// 综合评分，0-100
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public float? Score { get; set; }

        /// <summary>
        /// 完整性评分，0-100 表示有多少比例的单词发音是清楚的
        /// </summary>
        [JsonProperty("completeness", NullValueHandling = NullValueHandling.Ignore)]
        public float? Completeness { get; set; }

        /// <summary>
        /// 音频/视频时长，单位秒
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pronunciation", NullValueHandling = NullValueHandling.Ignore)]
        public Pronunciation Pronunciation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fluency", NullValueHandling = NullValueHandling.Ignore)]
        public Fluency Fluency { get; set; }

        /// <summary>
        /// 单词评测打分表
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public List<Word> Words { get; set; }

        /// <summary>
        /// 评测失败时定位问题使用的字段
        /// </summary>
        [JsonProperty("traceId", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunAudioAssessmentResponse {\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  completeness: ").Append(Completeness).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  pronunciation: ").Append(Pronunciation).Append("\n");
            sb.Append("  fluency: ").Append(Fluency).Append("\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunAudioAssessmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunAudioAssessmentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Completeness == input.Completeness ||
                    (this.Completeness != null &&
                    this.Completeness.Equals(input.Completeness))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                    this.Words == input.Words ||
                    this.Words != null &&
                    input.Words != null &&
                    this.Words.SequenceEqual(input.Words)
                ) && 
                (
                    this.TraceId == input.TraceId ||
                    (this.TraceId != null &&
                    this.TraceId.Equals(input.TraceId))
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
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Completeness != null)
                    hashCode = hashCode * 59 + this.Completeness.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Pronunciation != null)
                    hashCode = hashCode * 59 + this.Pronunciation.GetHashCode();
                if (this.Fluency != null)
                    hashCode = hashCode * 59 + this.Fluency.GetHashCode();
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
                if (this.TraceId != null)
                    hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
