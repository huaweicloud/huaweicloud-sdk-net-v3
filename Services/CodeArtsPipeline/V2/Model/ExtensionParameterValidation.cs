using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 参数校验规则
    /// </summary>
    public class ExtensionParameterValidation 
    {

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonProperty("isRequired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// 正则校验
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// 校验说明
        /// </summary>
        [JsonProperty("patternDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string PatternDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionParameterValidation {\n");
            sb.Append("  isRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  patternDescription: ").Append(PatternDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionParameterValidation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionParameterValidation input)
        {
            if (input == null) return false;
            if (this.IsRequired != input.IsRequired || (this.IsRequired != null && !this.IsRequired.Equals(input.IsRequired))) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.PatternDescription != input.PatternDescription || (this.PatternDescription != null && !this.PatternDescription.Equals(input.PatternDescription))) return false;

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
                if (this.IsRequired != null) hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.PatternDescription != null) hashCode = hashCode * 59 + this.PatternDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
