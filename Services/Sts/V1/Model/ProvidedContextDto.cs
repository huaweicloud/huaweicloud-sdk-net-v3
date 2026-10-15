using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sts.V1.Model
{
    /// <summary>
    /// 可信上下文信息。
    /// </summary>
    public class ProvidedContextDto 
    {

        /// <summary>
        /// **参数解释**： 生成可信上下文断言的提供者的URN。  **约束限制**： 长度最多为1500个字符。格式为5段，用\&quot;:\&quot;分隔，各段允许大小写字母、数字、\&quot;+\&quot;、\&quot;/\&quot;、\&quot;&#x3D;\&quot;、\&quot;-\&quot;、\&quot;_\&quot;（第2段还额外允许 \&quot;*\&quot;），长度限制为：第1段至少1位，第2段0~255位，第3段1~64位，第4段1~64位，第5段至少1位（任意字符）。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("context_provider_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ContextProviderUrn { get; set; }

        /// <summary>
        /// **参数解释**： 经过签名和加密的可信上下文断言。  **约束限制**： 不涉及。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("context_assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string ContextAssertion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvidedContextDto {\n");
            sb.Append("  contextProviderUrn: ").Append(ContextProviderUrn).Append("\n");
            sb.Append("  contextAssertion: ").Append(ContextAssertion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProvidedContextDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProvidedContextDto input)
        {
            if (input == null) return false;
            if (this.ContextProviderUrn != input.ContextProviderUrn || (this.ContextProviderUrn != null && !this.ContextProviderUrn.Equals(input.ContextProviderUrn))) return false;
            if (this.ContextAssertion != input.ContextAssertion || (this.ContextAssertion != null && !this.ContextAssertion.Equals(input.ContextAssertion))) return false;

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
                if (this.ContextProviderUrn != null) hashCode = hashCode * 59 + this.ContextProviderUrn.GetHashCode();
                if (this.ContextAssertion != null) hashCode = hashCode * 59 + this.ContextAssertion.GetHashCode();
                return hashCode;
            }
        }
    }
}
