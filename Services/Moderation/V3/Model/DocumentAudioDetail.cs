using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentAudioDetail 
    {

        /// <summary>
        /// 音频片段开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? StartTime { get; set; }

        /// <summary>
        /// 音频片段结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? EndTime { get; set; }

        /// <summary>
        /// 音频片段审核处理建议： block：包含敏感信息，不通过 review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 音频片段文本内容
        /// </summary>
        [JsonProperty("audio_text", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioText { get; set; }

        /// <summary>
        /// 音频片段标签
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 命中的风险片段信息列表
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<DocumentVideoImageDetailSegments> Segments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentAudioDetail {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  audioText: ").Append(AudioText).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  segments: ").Append(Segments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentAudioDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentAudioDetail input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Suggestion != input.Suggestion || (this.Suggestion != null && !this.Suggestion.Equals(input.Suggestion))) return false;
            if (this.AudioText != input.AudioText || (this.AudioText != null && !this.AudioText.Equals(input.AudioText))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.Segments != input.Segments || (this.Segments != null && input.Segments != null && !this.Segments.SequenceEqual(input.Segments))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Suggestion != null) hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.AudioText != null) hashCode = hashCode * 59 + this.AudioText.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Segments != null) hashCode = hashCode * 59 + this.Segments.GetHashCode();
                return hashCode;
            }
        }
    }
}
