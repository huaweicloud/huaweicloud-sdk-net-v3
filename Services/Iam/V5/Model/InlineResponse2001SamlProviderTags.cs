using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// **参数解释**： 自定义标签信息。  **取值范围**： 不涉及。
    /// </summary>
    public class InlineResponse2001SamlProviderTags 
    {

        /// <summary>
        /// **参数解释**： 标签键。  **取值范围**： 字符串长度在 1 到 64 之间，可以包含任意语种字母、数字、空格以及\&quot;_\&quot;、\&quot;.\&quot;、\&quot;:\&quot;、\&quot;&#x3D;\&quot;、\&quot;+\&quot;、\&quot;-\&quot;、\&quot;@\&quot;符号；首尾不能包含空格，且不能以\&quot;_sys_\&quot;开头。
        /// </summary>
        [JsonProperty("tag_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TagKey { get; set; }

        /// <summary>
        /// **参数解释**： 标签值。  **取值范围**： 字符串长度在 0 到 128 之间，可以包含任意语种字母、数字、空格以及\&quot;_\&quot;、\&quot;.\&quot;、\&quot;:\&quot;、\&quot;/\&quot;、\&quot;&#x3D;\&quot;、\&quot;+\&quot;、\&quot;-\&quot;、\&quot;@\&quot;符号，可以为空字符串。
        /// </summary>
        [JsonProperty("tag_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TagValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001SamlProviderTags {\n");
            sb.Append("  tagKey: ").Append(TagKey).Append("\n");
            sb.Append("  tagValue: ").Append(TagValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse2001SamlProviderTags);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InlineResponse2001SamlProviderTags input)
        {
            if (input == null) return false;
            if (this.TagKey != input.TagKey || (this.TagKey != null && !this.TagKey.Equals(input.TagKey))) return false;
            if (this.TagValue != input.TagValue || (this.TagValue != null && !this.TagValue.Equals(input.TagValue))) return false;

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
                if (this.TagKey != null) hashCode = hashCode * 59 + this.TagKey.GetHashCode();
                if (this.TagValue != null) hashCode = hashCode * 59 + this.TagValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
