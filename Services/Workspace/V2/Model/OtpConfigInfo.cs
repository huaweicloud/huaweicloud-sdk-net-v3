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
    /// OTP辅助认证方式配置。
    /// </summary>
    public class OtpConfigInfo 
    {

        /// <summary>
        /// 是否启用。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("receive_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ReceiveModeEnum? ReceiveMode { get; set; }

        /// <summary>
        /// 辅助认证服务器地址。
        /// </summary>
        [JsonProperty("auth_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthUrl { get; set; }

        /// <summary>
        /// 认证服务接入账号。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 认证服务接入密码。
        /// </summary>
        [JsonProperty("app_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string AppSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_server_access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AuthServerAccessMode? AuthServerAccessMode { get; set; }

        /// <summary>
        /// pem格式证书内容。
        /// </summary>
        [JsonProperty("cert_content", NullValueHandling = NullValueHandling.Ignore)]
        public string CertContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("apply_rule", NullValueHandling = NullValueHandling.Ignore)]
        public ApplyRuleInfo ApplyRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OtpConfigInfo {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  receiveMode: ").Append(ReceiveMode).Append("\n");
            sb.Append("  authUrl: ").Append(AuthUrl).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appSecret: ").Append(AppSecret).Append("\n");
            sb.Append("  authServerAccessMode: ").Append(AuthServerAccessMode).Append("\n");
            sb.Append("  certContent: ").Append(CertContent).Append("\n");
            sb.Append("  applyRule: ").Append(ApplyRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OtpConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OtpConfigInfo input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.ReceiveMode != input.ReceiveMode || (this.ReceiveMode != null && !this.ReceiveMode.Equals(input.ReceiveMode))) return false;
            if (this.AuthUrl != input.AuthUrl || (this.AuthUrl != null && !this.AuthUrl.Equals(input.AuthUrl))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppSecret != input.AppSecret || (this.AppSecret != null && !this.AppSecret.Equals(input.AppSecret))) return false;
            if (this.AuthServerAccessMode != input.AuthServerAccessMode || (this.AuthServerAccessMode != null && !this.AuthServerAccessMode.Equals(input.AuthServerAccessMode))) return false;
            if (this.CertContent != input.CertContent || (this.CertContent != null && !this.CertContent.Equals(input.CertContent))) return false;
            if (this.ApplyRule != input.ApplyRule || (this.ApplyRule != null && !this.ApplyRule.Equals(input.ApplyRule))) return false;

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
                if (this.ReceiveMode != null) hashCode = hashCode * 59 + this.ReceiveMode.GetHashCode();
                if (this.AuthUrl != null) hashCode = hashCode * 59 + this.AuthUrl.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppSecret != null) hashCode = hashCode * 59 + this.AppSecret.GetHashCode();
                if (this.AuthServerAccessMode != null) hashCode = hashCode * 59 + this.AuthServerAccessMode.GetHashCode();
                if (this.CertContent != null) hashCode = hashCode * 59 + this.CertContent.GetHashCode();
                if (this.ApplyRule != null) hashCode = hashCode * 59 + this.ApplyRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
