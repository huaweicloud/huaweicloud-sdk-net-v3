using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 图片审核结果。
    /// </summary>
    public class ImageModerationResult 
    {

        /// <summary>
        /// 审核情况。
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("category_suggestions", NullValueHandling = NullValueHandling.Ignore)]
        public CategorySuggestions CategorySuggestions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageModerationResult {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  categorySuggestions: ").Append(CategorySuggestions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageModerationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageModerationResult input)
        {
            if (input == null) return false;
            if (this.Suggestion != input.Suggestion || (this.Suggestion != null && !this.Suggestion.Equals(input.Suggestion))) return false;
            if (this.CategorySuggestions != input.CategorySuggestions || (this.CategorySuggestions != null && !this.CategorySuggestions.Equals(input.CategorySuggestions))) return false;

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
                if (this.CategorySuggestions != null) hashCode = hashCode * 59 + this.CategorySuggestions.GetHashCode();
                return hashCode;
            }
        }
    }
}
