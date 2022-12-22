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
    public class ImageDetectionResult 
    {

        /// <summary>
        /// 审核结果是否通过。  block：包含敏感信息，不通过  pass：不包含敏感信息，通过  review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 检测结果的一级标签。 支持category列表如下： terrorism: 暴恐 porn: 色情 image_text: 图文审核
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 检测详情
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageDetectionResultDetail> Details { get; set; }

        /// <summary>
        /// 图文审核检测出的文本，只有在category参数配置image_text且检测出文本时展示该字段。
        /// </summary>
        [JsonProperty("ocr_text", NullValueHandling = NullValueHandling.Ignore)]
        public string OcrText { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResult {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  details: ").Append(Details).Append("\n");
            sb.Append("  ocrText: ").Append(OcrText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResult input)
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.OcrText == input.OcrText ||
                    (this.OcrText != null &&
                    this.OcrText.Equals(input.OcrText))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.OcrText != null)
                    hashCode = hashCode * 59 + this.OcrText.GetHashCode();
                return hashCode;
            }
        }
    }
}
