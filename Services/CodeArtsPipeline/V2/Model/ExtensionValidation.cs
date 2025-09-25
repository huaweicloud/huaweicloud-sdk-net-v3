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
    /// 
    /// </summary>
    public class ExtensionValidation 
    {

        /// <summary>
        /// **参数解释**： 若插件输入项为必填而实际未填写时，提示的信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("required_message", NullValueHandling = NullValueHandling.Ignore)]
        public string RequiredMessage { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项值的校验正则表达式。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("regex", NullValueHandling = NullValueHandling.Ignore)]
        public string Regex { get; set; }

        /// <summary>
        /// **参数解释**： 若插件输入项的值不满足regex中的正则表达式时，提示的信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("regex_message", NullValueHandling = NullValueHandling.Ignore)]
        public string RegexMessage { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项值的最大长度。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项值的最小长度。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("min_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinLength { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionValidation {\n");
            sb.Append("  requiredMessage: ").Append(RequiredMessage).Append("\n");
            sb.Append("  regex: ").Append(Regex).Append("\n");
            sb.Append("  regexMessage: ").Append(RegexMessage).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  minLength: ").Append(MinLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionValidation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionValidation input)
        {
            if (input == null) return false;
            if (this.RequiredMessage != input.RequiredMessage || (this.RequiredMessage != null && !this.RequiredMessage.Equals(input.RequiredMessage))) return false;
            if (this.Regex != input.Regex || (this.Regex != null && !this.Regex.Equals(input.Regex))) return false;
            if (this.RegexMessage != input.RegexMessage || (this.RegexMessage != null && !this.RegexMessage.Equals(input.RegexMessage))) return false;
            if (this.MaxLength != input.MaxLength || (this.MaxLength != null && !this.MaxLength.Equals(input.MaxLength))) return false;
            if (this.MinLength != input.MinLength || (this.MinLength != null && !this.MinLength.Equals(input.MinLength))) return false;

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
                if (this.RequiredMessage != null) hashCode = hashCode * 59 + this.RequiredMessage.GetHashCode();
                if (this.Regex != null) hashCode = hashCode * 59 + this.Regex.GetHashCode();
                if (this.RegexMessage != null) hashCode = hashCode * 59 + this.RegexMessage.GetHashCode();
                if (this.MaxLength != null) hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.MinLength != null) hashCode = hashCode * 59 + this.MinLength.GetHashCode();
                return hashCode;
            }
        }
    }
}
