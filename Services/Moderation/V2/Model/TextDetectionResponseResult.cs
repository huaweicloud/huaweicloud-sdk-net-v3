using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 调用成功时表示调用结果。  调用失败时无此字段。
    /// </summary>
    public class TextDetectionResponseResult 
    {

        /// <summary>
        /// 检测结果是否通过。  block：包含敏感信息，不通过。  pass：不包含敏感信息，通过。  review：需要人工复查。
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 返回的相关检测结果详细信息：  - politics：涉政敏感词列表。  - porn：涉黄敏感词列表。  - ad：广告敏感词列表。  - abuse：辱骂敏感词列表。  - contraband：违禁品敏感词列表。  - flood：灌水文本。  &gt; - 灌水文本最多显示200个字符。 &gt; - 每个场景的返回结果的详细信息是指命中词，不是返回全部文本。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public Object Detail { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDetectionResponseResult {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextDetectionResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextDetectionResponseResult input)
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
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }
    }
}
