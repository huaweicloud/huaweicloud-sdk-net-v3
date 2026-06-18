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
    public class AssumeAgencyWithSAMLResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： SAML断言中SourceIdentity属性值所申明的身份。  **约束限制**： 不涉及。 
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
        /// **参数解释**：  SAML断言中SubjectConfirmationData元素的Recipient属性值。  **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("audience", NullValueHandling = NullValueHandling.Ignore)]
        public string Audience { get; set; }

        /// <summary>
        /// **参数解释**： SAML断言中Issuer元素的值。  **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// **参数解释**： 以下三部分的哈希值：issuer、华为云账号的Account ID以及IAM中SAML提供商的名称（URN的最后一部分）。name_qualifier和subject的组合可用于唯一标识用户。下面的伪代码展示了哈希值的计算方式：BASE64 ( SHA1 ( \&quot;https://example.com/saml\&quot; + \&quot;8c1eef3a241945f69c3d3axxxxxxxxxx\&quot; + \&quot;/MySAMLIdPName\&quot; ) )  **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("name_qualifier", NullValueHandling = NullValueHandling.Ignore)]
        public string NameQualifier { get; set; }

        /// <summary>
        /// **参数解释**：  SAML断言中Subject元素的NameID元素的值。  **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// **参数解释**：  NameID的格式，由SAML断言中NameID元素的Format属性定义。格式的典型示例是transient（临时）或persistent（持久）。 如果该格式包含前缀urn:oasis:names:tc:SAML:2.0:nameid-format，该前缀将被移除。例如，urn:oasis:names:tc:SAML:2.0:nameid-format:transient将作为transient返回。如果格式包含任何其他前缀，则直接返回该格式而不作任何修改。  **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("subject_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssumeAgencyWithSAMLResponse {\n");
            sb.Append("  sourceIdentity: ").Append(SourceIdentity).Append("\n");
            sb.Append("  assumedAgency: ").Append(AssumedAgency).Append("\n");
            sb.Append("  credentials: ").Append(Credentials).Append("\n");
            sb.Append("  audience: ").Append(Audience).Append("\n");
            sb.Append("  issuer: ").Append(Issuer).Append("\n");
            sb.Append("  nameQualifier: ").Append(NameQualifier).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  subjectType: ").Append(SubjectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssumeAgencyWithSAMLResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssumeAgencyWithSAMLResponse input)
        {
            if (input == null) return false;
            if (this.SourceIdentity != input.SourceIdentity || (this.SourceIdentity != null && !this.SourceIdentity.Equals(input.SourceIdentity))) return false;
            if (this.AssumedAgency != input.AssumedAgency || (this.AssumedAgency != null && !this.AssumedAgency.Equals(input.AssumedAgency))) return false;
            if (this.Credentials != input.Credentials || (this.Credentials != null && !this.Credentials.Equals(input.Credentials))) return false;
            if (this.Audience != input.Audience || (this.Audience != null && !this.Audience.Equals(input.Audience))) return false;
            if (this.Issuer != input.Issuer || (this.Issuer != null && !this.Issuer.Equals(input.Issuer))) return false;
            if (this.NameQualifier != input.NameQualifier || (this.NameQualifier != null && !this.NameQualifier.Equals(input.NameQualifier))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.SubjectType != input.SubjectType || (this.SubjectType != null && !this.SubjectType.Equals(input.SubjectType))) return false;

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
                if (this.Issuer != null) hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.NameQualifier != null) hashCode = hashCode * 59 + this.NameQualifier.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.SubjectType != null) hashCode = hashCode * 59 + this.SubjectType.GetHashCode();
                return hashCode;
            }
        }
    }
}
