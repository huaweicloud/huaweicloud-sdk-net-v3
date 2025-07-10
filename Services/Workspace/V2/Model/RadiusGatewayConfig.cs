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
    /// 短信辅助认证配置。
    /// </summary>
    public class RadiusGatewayConfig 
    {

        /// <summary>
        /// 是否启用。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 获取token地址。
        /// </summary>
        [JsonProperty("token_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// 获取验证码地址。
        /// </summary>
        [JsonProperty("verification_cipher_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCipherUrl { get; set; }

        /// <summary>
        /// 证书内容（PEM）。
        /// </summary>
        [JsonProperty("cert_content", NullValueHandling = NullValueHandling.Ignore)]
        public string CertContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadiusGatewayConfig {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  tokenUrl: ").Append(TokenUrl).Append("\n");
            sb.Append("  verificationCipherUrl: ").Append(VerificationCipherUrl).Append("\n");
            sb.Append("  certContent: ").Append(CertContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RadiusGatewayConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RadiusGatewayConfig input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.TokenUrl != input.TokenUrl || (this.TokenUrl != null && !this.TokenUrl.Equals(input.TokenUrl))) return false;
            if (this.VerificationCipherUrl != input.VerificationCipherUrl || (this.VerificationCipherUrl != null && !this.VerificationCipherUrl.Equals(input.VerificationCipherUrl))) return false;
            if (this.CertContent != input.CertContent || (this.CertContent != null && !this.CertContent.Equals(input.CertContent))) return false;

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
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.TokenUrl != null) hashCode = hashCode * 59 + this.TokenUrl.GetHashCode();
                if (this.VerificationCipherUrl != null) hashCode = hashCode * 59 + this.VerificationCipherUrl.GetHashCode();
                if (this.CertContent != null) hashCode = hashCode * 59 + this.CertContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
