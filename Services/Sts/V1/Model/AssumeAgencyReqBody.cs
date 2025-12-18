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
    /// 接口/v5/agencies/assume的Http请求体。
    /// </summary>
    public class AssumeAgencyReqBody 
    {

        /// <summary>
        /// 获得的临时安全凭证的有效时间（单位秒）。请注意，该时间需要小于委托本身设置的最大会话持续时间，同时在携带X-Security-Token的Header头时该时间不能超过3600秒。
        /// </summary>
        [JsonProperty("duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// 外部ID，防止混淆代理人问题。
        /// </summary>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// 自定义策略，限制本次会话获得的临时安全凭证的权限范围不会超过该自定义策略指定的权限。
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// 预置策略列表，限制本次会话获得的临时安全凭证的权限范围不会超过该预置策略指定的权限。
        /// </summary>
        [JsonProperty("policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// 目标委托的URN。
        /// </summary>
        [JsonProperty("agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyUrn { get; set; }

        /// <summary>
        /// 委托会话的会话名。
        /// </summary>
        [JsonProperty("agency_session_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencySessionName { get; set; }

        /// <summary>
        /// 调用者绑定的MFA设备的序列号。
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 调用者绑定的MFA设备上的6位数字码。
        /// </summary>
        [JsonProperty("token_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenCode { get; set; }

        /// <summary>
        /// 调用链里最初调用者所声明的身份。
        /// </summary>
        [JsonProperty("source_identity", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIdentity { get; set; }

        /// <summary>
        /// 自定义标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagDto> Tags { get; set; }

        /// <summary>
        /// 随着临时安全凭证调用链持续透传的标签键列表。
        /// </summary>
        [JsonProperty("transitive_tag_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransitiveTagKeys { get; set; }



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
                return hashCode;
            }
        }
    }
}
