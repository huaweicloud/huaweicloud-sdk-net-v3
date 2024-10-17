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
    public class DocumentVideoImageDetail 
    {

        /// <summary>
        /// 截帧在视频文件中的时间，单位为秒
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public float? Time { get; set; }

        /// <summary>
        /// 截帧审核结果是否通过。 block：包含敏感信息，不通过 review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 截帧检测出的文本
        /// </summary>
        [JsonProperty("ocr_text", NullValueHandling = NullValueHandling.Ignore)]
        public string OcrText { get; set; }

        /// <summary>
        /// 识别的详细标签
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 命中的文本风险片段列表
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<DocumentVideoImageDetailSegments> Segments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentVideoImageDetail {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  ocrText: ").Append(OcrText).Append("\n");
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
            return this.Equals(input as DocumentVideoImageDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentVideoImageDetail input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Suggestion != input.Suggestion || (this.Suggestion != null && !this.Suggestion.Equals(input.Suggestion))) return false;
            if (this.OcrText != input.OcrText || (this.OcrText != null && !this.OcrText.Equals(input.OcrText))) return false;
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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Suggestion != null) hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.OcrText != null) hashCode = hashCode * 59 + this.OcrText.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Segments != null) hashCode = hashCode * 59 + this.Segments.GetHashCode();
                return hashCode;
            }
        }
    }
}
