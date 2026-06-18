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
    /// **参数解释**： 接口/v5/agencies/assume-with-saml的Http请求体。  **取值范围**： 不涉及。 
    /// </summary>
    public class AssumeAgencyWithSAMLReqBody 
    {

        /// <summary>
        /// **参数解释**： 获得的临时安全凭证的有效时间（单位：秒）。  **约束限制**： 获得的临时安全凭证的有效时间（单位：秒）。请注意，该时间需要小于信任委托本身设置的最大会话持续时间。同时最终的会话持续时间以duration_seconds，  SAML身份验证响应中SessionNotOnOrAfter值和SessionDuration值三者中较短的一个为准。  **取值范围**： 取值范围为[900,43200]。  **默认取值**： 默认值为3600。 
        /// </summary>
        [JsonProperty("duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// **参数解释**： 自定义策略，限制本次会话获得的临时安全凭证的权限范围不会超过该自定义策略指定的权限。  **约束限制**： 本次会话获得的临时安全凭证的权限范围不会超过该自定义策略指定的权限。 长度范围为[2,2048]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// **参数解释**： 预置策略列表，限制本次会话获得的临时安全凭证的权限范围不会超过该预置策略指定的权限。  **约束限制**： 不涉及。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// **参数解释**： SAML提供商的URN。  **约束限制**： 长度范围为[0,1500]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("provider_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderUrn { get; set; }

        /// <summary>
        /// **参数解释**： 目标信任委托的URN。  **约束限制**： 长度范围为[0,1500]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyUrn { get; set; }

        /// <summary>
        /// **参数解释**： 由SAML身份提供商提供的Base64编码的SAML身份验证响应。  **约束限制**： 长度范围为[4,100000]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("saml_assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string SamlAssertion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssumeAgencyWithSAMLReqBody {\n");
            sb.Append("  durationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  policyIds: ").Append(PolicyIds).Append("\n");
            sb.Append("  providerUrn: ").Append(ProviderUrn).Append("\n");
            sb.Append("  agencyUrn: ").Append(AgencyUrn).Append("\n");
            sb.Append("  samlAssertion: ").Append(SamlAssertion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssumeAgencyWithSAMLReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssumeAgencyWithSAMLReqBody input)
        {
            if (input == null) return false;
            if (this.DurationSeconds != input.DurationSeconds || (this.DurationSeconds != null && !this.DurationSeconds.Equals(input.DurationSeconds))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.PolicyIds != input.PolicyIds || (this.PolicyIds != null && input.PolicyIds != null && !this.PolicyIds.SequenceEqual(input.PolicyIds))) return false;
            if (this.ProviderUrn != input.ProviderUrn || (this.ProviderUrn != null && !this.ProviderUrn.Equals(input.ProviderUrn))) return false;
            if (this.AgencyUrn != input.AgencyUrn || (this.AgencyUrn != null && !this.AgencyUrn.Equals(input.AgencyUrn))) return false;
            if (this.SamlAssertion != input.SamlAssertion || (this.SamlAssertion != null && !this.SamlAssertion.Equals(input.SamlAssertion))) return false;

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
                if (this.DurationSeconds != null) hashCode = hashCode * 59 + this.DurationSeconds.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.PolicyIds != null) hashCode = hashCode * 59 + this.PolicyIds.GetHashCode();
                if (this.ProviderUrn != null) hashCode = hashCode * 59 + this.ProviderUrn.GetHashCode();
                if (this.AgencyUrn != null) hashCode = hashCode * 59 + this.AgencyUrn.GetHashCode();
                if (this.SamlAssertion != null) hashCode = hashCode * 59 + this.SamlAssertion.GetHashCode();
                return hashCode;
            }
        }
    }
}
