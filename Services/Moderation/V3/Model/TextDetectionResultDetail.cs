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
    public class TextDetectionResultDetail 
    {

        /// <summary>
        /// 审核结果是否通过。  block：包含敏感信息，不通过  pass：不包含敏感信息，通过  review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 检测结果的标签。  支持label列表如下：  politics: 涉政  terrorism: 暴恐  porn: 色情  ban: 违禁  abuse: 辱骂  ad: 广告  ad_law: 广告法  meaningless: ⽆意义  customized：自定义（命中自定义词库中的关键词）
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 置信度，取值范围 0-1，值越⼤，可信度越⾼。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 命中的风险片段信息，如果命中了语义算法模型，则会返回一个空的列表。
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<SegmentResult> Segments { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDetectionResultDetail {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  segments: ").Append(Segments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextDetectionResultDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextDetectionResultDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Suggestion == input.Suggestion ||
                    (this.Suggestion != null &&
                    this.Suggestion.Equals(input.Suggestion))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    input.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
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
                if (this.Suggestion != null)
                    hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                return hashCode;
            }
        }
    }
}
