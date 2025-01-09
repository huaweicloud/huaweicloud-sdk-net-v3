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
    /// 第三方网关信息
    /// </summary>
    public class ThirdGatewayInfo 
    {

        /// <summary>
        /// 第三方登录url
        /// </summary>
        [JsonProperty("login_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginUrl { get; set; }

        /// <summary>
        /// 第三方登出url
        /// </summary>
        [JsonProperty("logout_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoutUrl { get; set; }

        /// <summary>
        /// 第三方网关token校验url
        /// </summary>
        [JsonProperty("token_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// 校验证书url
        /// </summary>
        [JsonProperty("verification_cipher_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCipherUrl { get; set; }

        /// <summary>
        /// 第三方网关认证证书
        /// </summary>
        [JsonProperty("cert_content", NullValueHandling = NullValueHandling.Ignore)]
        public string CertContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdGatewayInfo {\n");
            sb.Append("  loginUrl: ").Append(LoginUrl).Append("\n");
            sb.Append("  logoutUrl: ").Append(LogoutUrl).Append("\n");
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
            return this.Equals(input as ThirdGatewayInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThirdGatewayInfo input)
        {
            if (input == null) return false;
            if (this.LoginUrl != input.LoginUrl || (this.LoginUrl != null && !this.LoginUrl.Equals(input.LoginUrl))) return false;
            if (this.LogoutUrl != input.LogoutUrl || (this.LogoutUrl != null && !this.LogoutUrl.Equals(input.LogoutUrl))) return false;
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
                if (this.LoginUrl != null) hashCode = hashCode * 59 + this.LoginUrl.GetHashCode();
                if (this.LogoutUrl != null) hashCode = hashCode * 59 + this.LogoutUrl.GetHashCode();
                if (this.TokenUrl != null) hashCode = hashCode * 59 + this.TokenUrl.GetHashCode();
                if (this.VerificationCipherUrl != null) hashCode = hashCode * 59 + this.VerificationCipherUrl.GetHashCode();
                if (this.CertContent != null) hashCode = hashCode * 59 + this.CertContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
