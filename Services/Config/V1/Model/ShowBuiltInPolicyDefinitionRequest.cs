using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowBuiltInPolicyDefinitionRequest 
    {

        /// <summary>
        /// 策略ID
        /// </summary>
        [SDKProperty("policy_definition_id", IsPath = true)]
        [JsonProperty("policy_definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// 选择接口返回的信息的语言，默认为\&quot;zh-cn\&quot;中文
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBuiltInPolicyDefinitionRequest {\n");
            sb.Append("  policyDefinitionId: ").Append(PolicyDefinitionId).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBuiltInPolicyDefinitionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBuiltInPolicyDefinitionRequest input)
        {
            if (input == null) return false;
            if (this.PolicyDefinitionId != input.PolicyDefinitionId || (this.PolicyDefinitionId != null && !this.PolicyDefinitionId.Equals(input.PolicyDefinitionId))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;

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
                if (this.PolicyDefinitionId != null) hashCode = hashCode * 59 + this.PolicyDefinitionId.GetHashCode();
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
