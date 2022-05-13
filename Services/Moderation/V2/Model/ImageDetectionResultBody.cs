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
    /// 
    /// </summary>
    public class ImageDetectionResultBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public ImageDetectionResultDetail Detail { get; set; }

        /// <summary>
        /// 检测结果是否通过。 - block：包含敏感信息，不通过 - pass：不包含敏感信息，通过 - review：需要人工复检 &gt; 当同时检测多个场景时，suggestion的值以最可能包含敏感信息的场景为准。即任一场景出现了block则总的suggestion为block，所有场景都pass时suggestion为pass，这两种情况之外则一定有场景需要review，此时suggestion为review。 
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 具体每个场景的检测结果。  block：包含敏感信息，不通过  pass：不包含敏感信息，通过  review：需要人工复检 
        /// </summary>
        [JsonProperty("category_suggestions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CategorySuggestions { get; set; }

        /// <summary>
        /// 文本结果
        /// </summary>
        [JsonProperty("ocr_text", NullValueHandling = NullValueHandling.Ignore)]
        public string OcrText { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResultBody {\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  categorySuggestions: ").Append(CategorySuggestions).Append("\n");
            sb.Append("  ocrText: ").Append(OcrText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResultBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResultBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Suggestion == input.Suggestion ||
                    (this.Suggestion != null &&
                    this.Suggestion.Equals(input.Suggestion))
                ) && 
                (
                    this.CategorySuggestions == input.CategorySuggestions ||
                    this.CategorySuggestions != null &&
                    input.CategorySuggestions != null &&
                    this.CategorySuggestions.SequenceEqual(input.CategorySuggestions)
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Suggestion != null)
                    hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.CategorySuggestions != null)
                    hashCode = hashCode * 59 + this.CategorySuggestions.GetHashCode();
                if (this.OcrText != null)
                    hashCode = hashCode * 59 + this.OcrText.GetHashCode();
                return hashCode;
            }
        }
    }
}
