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
    /// **参数解释**： 接口/v5/agencies/assume-with-oidc的Http请求体。  **约束限制**： 不涉及。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
    /// </summary>
    public class AssumeAgencyWithOIDCReqBody 
    {

        /// <summary>
        /// **参数解释**： 获得的临时安全凭证的有效时间（单位：秒）。  **约束限制**： 请注意，该时间需要小于委托本身设置的最大会话持续时间，同时在携带X-Security-Token的Header头时该时间不能超过3600秒。  **取值范围**： 取值范围为[900,43200]。  **默认取值**： 默认值为3600。 
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
        /// **参数解释**： OIDC提供商的URN。  **约束限制**： 长度范围为[0,1500]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("provider_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderUrn { get; set; }

        /// <summary>
        /// **参数解释**： 目标信任委托的URN。  **约束限制**： 长度范围为[0,1500]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyUrn { get; set; }

        /// <summary>
        /// **参数解释**： 信任委托会话的会话名。  **约束限制**： 长度范围为[2,128]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("agency_session_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencySessionName { get; set; }

        /// <summary>
        /// **参数解释**： 由身份提供商提供的OIDC令牌。  **约束限制**： 长度范围为[4,20000]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("id_token", NullValueHandling = NullValueHandling.Ignore)]
        public string IdToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssumeAgencyWithOIDCReqBody {\n");
            sb.Append("  durationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  policyIds: ").Append(PolicyIds).Append("\n");
            sb.Append("  providerUrn: ").Append(ProviderUrn).Append("\n");
            sb.Append("  agencyUrn: ").Append(AgencyUrn).Append("\n");
            sb.Append("  agencySessionName: ").Append(AgencySessionName).Append("\n");
            sb.Append("  idToken: ").Append(IdToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssumeAgencyWithOIDCReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssumeAgencyWithOIDCReqBody input)
        {
            if (input == null) return false;
            if (this.DurationSeconds != input.DurationSeconds || (this.DurationSeconds != null && !this.DurationSeconds.Equals(input.DurationSeconds))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.PolicyIds != input.PolicyIds || (this.PolicyIds != null && input.PolicyIds != null && !this.PolicyIds.SequenceEqual(input.PolicyIds))) return false;
            if (this.ProviderUrn != input.ProviderUrn || (this.ProviderUrn != null && !this.ProviderUrn.Equals(input.ProviderUrn))) return false;
            if (this.AgencyUrn != input.AgencyUrn || (this.AgencyUrn != null && !this.AgencyUrn.Equals(input.AgencyUrn))) return false;
            if (this.AgencySessionName != input.AgencySessionName || (this.AgencySessionName != null && !this.AgencySessionName.Equals(input.AgencySessionName))) return false;
            if (this.IdToken != input.IdToken || (this.IdToken != null && !this.IdToken.Equals(input.IdToken))) return false;

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
                if (this.AgencySessionName != null) hashCode = hashCode * 59 + this.AgencySessionName.GetHashCode();
                if (this.IdToken != null) hashCode = hashCode * 59 + this.IdToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
