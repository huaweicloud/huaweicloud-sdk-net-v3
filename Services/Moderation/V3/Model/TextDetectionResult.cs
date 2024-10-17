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
    public class TextDetectionResult 
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
        /// 检测详情
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<TextDetectionResultDetail> Details { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDetectionResult {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  details: ").Append(Details).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextDetectionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextDetectionResult input)
        {
            if (input == null) return false;
            if (this.Suggestion != input.Suggestion || (this.Suggestion != null && !this.Suggestion.Equals(input.Suggestion))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.Details != input.Details || (this.Details != null && input.Details != null && !this.Details.SequenceEqual(input.Details))) return false;

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
                if (this.Suggestion != null) hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Details != null) hashCode = hashCode * 59 + this.Details.GetHashCode();
                return hashCode;
            }
        }
    }
}
