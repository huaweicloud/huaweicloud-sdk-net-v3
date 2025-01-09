using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 短信辅助认证配置
    /// </summary>
    public class RadiusGatewayConfigInfo 
    {

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 证书域名
        /// </summary>
        [JsonProperty("cert_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertDomainName { get; set; }

        /// <summary>
        /// 获取token地址
        /// </summary>
        [JsonProperty("token_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// 获取验证码地址
        /// </summary>
        [JsonProperty("verification_cipher_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCipherUrl { get; set; }

        /// <summary>
        /// 认证类型
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// 辅助认证类型
        /// </summary>
        [JsonProperty("assist_auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssistAuthType { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        public string Expiration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadiusGatewayConfigInfo {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  certDomainName: ").Append(CertDomainName).Append("\n");
            sb.Append("  tokenUrl: ").Append(TokenUrl).Append("\n");
            sb.Append("  verificationCipherUrl: ").Append(VerificationCipherUrl).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  assistAuthType: ").Append(AssistAuthType).Append("\n");
            sb.Append("  expiration: ").Append(Expiration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RadiusGatewayConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RadiusGatewayConfigInfo input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.CertDomainName != input.CertDomainName || (this.CertDomainName != null && !this.CertDomainName.Equals(input.CertDomainName))) return false;
            if (this.TokenUrl != input.TokenUrl || (this.TokenUrl != null && !this.TokenUrl.Equals(input.TokenUrl))) return false;
            if (this.VerificationCipherUrl != input.VerificationCipherUrl || (this.VerificationCipherUrl != null && !this.VerificationCipherUrl.Equals(input.VerificationCipherUrl))) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;
            if (this.AssistAuthType != input.AssistAuthType || (this.AssistAuthType != null && !this.AssistAuthType.Equals(input.AssistAuthType))) return false;
            if (this.Expiration != input.Expiration || (this.Expiration != null && !this.Expiration.Equals(input.Expiration))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.CertDomainName != null) hashCode = hashCode * 59 + this.CertDomainName.GetHashCode();
                if (this.TokenUrl != null) hashCode = hashCode * 59 + this.TokenUrl.GetHashCode();
                if (this.VerificationCipherUrl != null) hashCode = hashCode * 59 + this.VerificationCipherUrl.GetHashCode();
                if (this.AuthType != null) hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AssistAuthType != null) hashCode = hashCode * 59 + this.AssistAuthType.GetHashCode();
                if (this.Expiration != null) hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                return hashCode;
            }
        }
    }
}
