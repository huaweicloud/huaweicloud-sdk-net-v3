using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 评估指标详情
    /// </summary>
    public class AssessProperty 
    {

        /// <summary>
        /// 预期信息
        /// </summary>
        [JsonProperty("expected", NullValueHandling = NullValueHandling.Ignore)]
        public string Expected { get; set; }

        /// <summary>
        /// 实际信息
        /// </summary>
        [JsonProperty("actual", NullValueHandling = NullValueHandling.Ignore)]
        public string Actual { get; set; }

        /// <summary>
        /// 中文建议
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 英文建议
        /// </summary>
        [JsonProperty("suggestion_en", NullValueHandling = NullValueHandling.Ignore)]
        public string SuggestionEn { get; set; }

        /// <summary>
        /// 是否超出范围
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssessProperty {\n");
            sb.Append("  expected: ").Append(Expected).Append("\n");
            sb.Append("  actual: ").Append(Actual).Append("\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  suggestionEn: ").Append(SuggestionEn).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssessProperty);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssessProperty input)
        {
            if (input == null) return false;
            if (this.Expected != input.Expected || (this.Expected != null && !this.Expected.Equals(input.Expected))) return false;
            if (this.Actual != input.Actual || (this.Actual != null && !this.Actual.Equals(input.Actual))) return false;
            if (this.Suggestion != input.Suggestion || (this.Suggestion != null && !this.Suggestion.Equals(input.Suggestion))) return false;
            if (this.SuggestionEn != input.SuggestionEn || (this.SuggestionEn != null && !this.SuggestionEn.Equals(input.SuggestionEn))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Expected != null) hashCode = hashCode * 59 + this.Expected.GetHashCode();
                if (this.Actual != null) hashCode = hashCode * 59 + this.Actual.GetHashCode();
                if (this.Suggestion != null) hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.SuggestionEn != null) hashCode = hashCode * 59 + this.SuggestionEn.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
