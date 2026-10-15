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
    /// **参数解释**： 接口/v5/agencies/assume的Http请求体。  **约束限制**： 不涉及。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
    /// </summary>
    public class AssumeAgencyReqBody 
    {

        /// <summary>
        /// **参数解释**： 获得的临时安全凭证的有效时间（单位：秒）。  **约束限制**： 请注意，该时间需要小于委托本身设置的最大会话持续时间（在IAM控制台「委托」页面中获取），同时在携带X-Security-Token的Header头时该时间不能超过3600秒。  **取值范围**： 取值范围为[900,43200]。  **默认取值**： 默认值为3600。 
        /// </summary>
        [JsonProperty("duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// **参数解释**： 外部ID，防止混淆代理人问题。  **约束限制**： 不涉及。  **取值范围**： 长度为2到1224个字符，只允许大小写字母、数字、\&quot;_\&quot;、\&quot;+\&quot;、\&quot;&#x3D;\&quot;、\&quot;,\&quot;、\&quot;.\&quot;、\&quot;@\&quot;、\&quot;:\&quot;、\&quot;/\&quot;、\&quot;-\&quot;。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// **参数解释**： 自定义策略，用于进一步限制临时安全凭证的权限范围。  **约束限制**： 本次会话获得的临时安全凭证的权限范围不会超过该自定义策略指定的权限。  **取值范围**： 长度为2到4096个字符。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// **参数解释**： 预置策略列表，限制本次会话获得的临时安全凭证的权限范围不会超过该预置策略指定的权限。 每个元素为预置策略的标识ID，长度限制为1到64个字符，只允许大小写字母、数字、\&quot;_\&quot;、\&quot;-\&quot;，且至少包含一个字符。  **约束限制**： 该数组允许的元素个数最多为20。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// **参数解释**： 目标委托的URN，在IAM控制台的「委托」页面中获取。  **约束限制**： 不涉及。  **取值范围**： 长度最多为1500个字符。格式为5段，用\&quot;:\&quot;分隔，各段允许大小写字母、数字、\&quot;+\&quot;、\&quot;/\&quot;、\&quot;&#x3D;\&quot;、\&quot;-\&quot;、\&quot;_\&quot;（第2段还额外允许 \&quot;*\&quot;），长度限制为：第1段至少1位，第2段0~255位，第3段1~64位，第4段1~64位，第5段至少1位（任意字符）。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyUrn { get; set; }

        /// <summary>
        /// **参数解释**： 委托会话的会话名。  **约束限制**： 不涉及。  **取值范围**： 长度为2到128个字符，只允许大小写字母、数字、\&quot;_\&quot;、\&quot;+\&quot;、\&quot;&#x3D;\&quot;、\&quot;,\&quot;、\&quot;.\&quot;、\&quot;@\&quot;、\&quot;-\&quot;。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("agency_session_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencySessionName { get; set; }

        /// <summary>
        /// **参数解释**： 调用者绑定的MFA设备的序列号。在IAM控制台-&gt;「用户」-&gt;「安全设置」-&gt;「多因素认证设备」中获取。  **约束限制**： 不涉及。  **取值范围**： 长度为9到256个字符，只允许大小写字母、数字、\&quot;_\&quot;、\&quot;+\&quot;、\&quot;&#x3D;\&quot;、\&quot;/\&quot;、\&quot;:\&quot;、\&quot;,\&quot;、\&quot;.\&quot;、\&quot;@\&quot;、\&quot;-\&quot;。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// **参数解释**： 调用者绑定的MFA设备上的6位纯数字。  **约束限制**： 只允许6位数字。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("token_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenCode { get; set; }

        /// <summary>
        /// **参数解释**： 调用链里最初调用者所声明的身份。  **约束限制**： 不涉及。  **取值范围**： 长度为2到64个字符，只允许大小写字母、数字、\&quot;_\&quot;、\&quot;+\&quot;、\&quot;&#x3D;\&quot;、\&quot;,\&quot;、\&quot;.\&quot;、\&quot;@\&quot;、\&quot;-\&quot;。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("source_identity", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIdentity { get; set; }

        /// <summary>
        /// **参数解释**： 自定义标签列表。  **约束限制**： 该数组允许的元素个数最多为20。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagDto> Tags { get; set; }

        /// <summary>
        /// **参数解释**： 随着临时安全凭证调用链持续透传的标签键列表。  **约束限制**： 该数组允许的元素个数最多为20。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("transitive_tag_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransitiveTagKeys { get; set; }

        /// <summary>
        /// **参数解释**： 预先获取的可信上下文断言列表，格式为数组。  **约束限制**： 该数组允许的元素个数为1到5。  **取值范围**： 不涉及。  **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("provided_contexts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProvidedContextDto> ProvidedContexts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssumeAgencyReqBody {\n");
            sb.Append("  durationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  externalId: ").Append(ExternalId).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  policyIds: ").Append(PolicyIds).Append("\n");
            sb.Append("  agencyUrn: ").Append(AgencyUrn).Append("\n");
            sb.Append("  agencySessionName: ").Append(AgencySessionName).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  tokenCode: ").Append(TokenCode).Append("\n");
            sb.Append("  sourceIdentity: ").Append(SourceIdentity).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  transitiveTagKeys: ").Append(TransitiveTagKeys).Append("\n");
            sb.Append("  providedContexts: ").Append(ProvidedContexts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssumeAgencyReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssumeAgencyReqBody input)
        {
            if (input == null) return false;
            if (this.DurationSeconds != input.DurationSeconds || (this.DurationSeconds != null && !this.DurationSeconds.Equals(input.DurationSeconds))) return false;
            if (this.ExternalId != input.ExternalId || (this.ExternalId != null && !this.ExternalId.Equals(input.ExternalId))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.PolicyIds != input.PolicyIds || (this.PolicyIds != null && input.PolicyIds != null && !this.PolicyIds.SequenceEqual(input.PolicyIds))) return false;
            if (this.AgencyUrn != input.AgencyUrn || (this.AgencyUrn != null && !this.AgencyUrn.Equals(input.AgencyUrn))) return false;
            if (this.AgencySessionName != input.AgencySessionName || (this.AgencySessionName != null && !this.AgencySessionName.Equals(input.AgencySessionName))) return false;
            if (this.SerialNumber != input.SerialNumber || (this.SerialNumber != null && !this.SerialNumber.Equals(input.SerialNumber))) return false;
            if (this.TokenCode != input.TokenCode || (this.TokenCode != null && !this.TokenCode.Equals(input.TokenCode))) return false;
            if (this.SourceIdentity != input.SourceIdentity || (this.SourceIdentity != null && !this.SourceIdentity.Equals(input.SourceIdentity))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TransitiveTagKeys != input.TransitiveTagKeys || (this.TransitiveTagKeys != null && input.TransitiveTagKeys != null && !this.TransitiveTagKeys.SequenceEqual(input.TransitiveTagKeys))) return false;
            if (this.ProvidedContexts != input.ProvidedContexts || (this.ProvidedContexts != null && input.ProvidedContexts != null && !this.ProvidedContexts.SequenceEqual(input.ProvidedContexts))) return false;

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
                if (this.ExternalId != null) hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.PolicyIds != null) hashCode = hashCode * 59 + this.PolicyIds.GetHashCode();
                if (this.AgencyUrn != null) hashCode = hashCode * 59 + this.AgencyUrn.GetHashCode();
                if (this.AgencySessionName != null) hashCode = hashCode * 59 + this.AgencySessionName.GetHashCode();
                if (this.SerialNumber != null) hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.TokenCode != null) hashCode = hashCode * 59 + this.TokenCode.GetHashCode();
                if (this.SourceIdentity != null) hashCode = hashCode * 59 + this.SourceIdentity.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TransitiveTagKeys != null) hashCode = hashCode * 59 + this.TransitiveTagKeys.GetHashCode();
                if (this.ProvidedContexts != null) hashCode = hashCode * 59 + this.ProvidedContexts.GetHashCode();
                return hashCode;
            }
        }
    }
}
