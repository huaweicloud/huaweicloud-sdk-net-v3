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
    /// Response Object
    /// </summary>
    public class AssumeAgencyWithOIDCResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 身份提供商返回的OIDC令牌中所申明的身份。  **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("source_identity", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIdentity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assumed_agency", NullValueHandling = NullValueHandling.Ignore)]
        public AssumedAgencyWithFederationDto AssumedAgency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public CredentialsDto Credentials { get; set; }

        /// <summary>
        /// **参数解释**： OIDC令牌的预期受众（也称为客户端ID），通常是分发给应用程序的客户端标识符。  **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("audience", NullValueHandling = NullValueHandling.Ignore)]
        public string Audience { get; set; }

        /// <summary>
        /// **参数解释**： 身份提供商的URN。  **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// **参数解释**： 由身份提供商返回的唯一用户标识符，即OIDC令牌中的sub(Subject)声明的值。  **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("subject_from_id_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectFromIdToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssumeAgencyWithOIDCResponse {\n");
            sb.Append("  sourceIdentity: ").Append(SourceIdentity).Append("\n");
            sb.Append("  assumedAgency: ").Append(AssumedAgency).Append("\n");
            sb.Append("  credentials: ").Append(Credentials).Append("\n");
            sb.Append("  audience: ").Append(Audience).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  subjectFromIdToken: ").Append(SubjectFromIdToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssumeAgencyWithOIDCResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssumeAgencyWithOIDCResponse input)
        {
            if (input == null) return false;
            if (this.SourceIdentity != input.SourceIdentity || (this.SourceIdentity != null && !this.SourceIdentity.Equals(input.SourceIdentity))) return false;
            if (this.AssumedAgency != input.AssumedAgency || (this.AssumedAgency != null && !this.AssumedAgency.Equals(input.AssumedAgency))) return false;
            if (this.Credentials != input.Credentials || (this.Credentials != null && !this.Credentials.Equals(input.Credentials))) return false;
            if (this.Audience != input.Audience || (this.Audience != null && !this.Audience.Equals(input.Audience))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.SubjectFromIdToken != input.SubjectFromIdToken || (this.SubjectFromIdToken != null && !this.SubjectFromIdToken.Equals(input.SubjectFromIdToken))) return false;

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
                if (this.SourceIdentity != null) hashCode = hashCode * 59 + this.SourceIdentity.GetHashCode();
                if (this.AssumedAgency != null) hashCode = hashCode * 59 + this.AssumedAgency.GetHashCode();
                if (this.Credentials != null) hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Audience != null) hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.SubjectFromIdToken != null) hashCode = hashCode * 59 + this.SubjectFromIdToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
