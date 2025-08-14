using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 身份提供商
    /// </summary>
    public class IdentityProviderConfigDto 
    {

        /// <summary>
        /// 身份提供商issuer
        /// </summary>
        [JsonProperty("issuer_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// 身份提供商元数据
        /// </summary>
        [JsonProperty("metadata_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataUrl { get; set; }

        /// <summary>
        /// 身份提供商远程登录链接
        /// </summary>
        [JsonProperty("remote_login_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteLoginUrl { get; set; }

        /// <summary>
        /// 身份提供商远程登出链接
        /// </summary>
        [JsonProperty("remote_logout_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteLogoutUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityProviderConfigDto {\n");
            sb.Append("  issuerUrl: ").Append(IssuerUrl).Append("\n");
            sb.Append("  metadataUrl: ").Append(MetadataUrl).Append("\n");
            sb.Append("  remoteLoginUrl: ").Append(RemoteLoginUrl).Append("\n");
            sb.Append("  remoteLogoutUrl: ").Append(RemoteLogoutUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityProviderConfigDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdentityProviderConfigDto input)
        {
            if (input == null) return false;
            if (this.IssuerUrl != input.IssuerUrl || (this.IssuerUrl != null && !this.IssuerUrl.Equals(input.IssuerUrl))) return false;
            if (this.MetadataUrl != input.MetadataUrl || (this.MetadataUrl != null && !this.MetadataUrl.Equals(input.MetadataUrl))) return false;
            if (this.RemoteLoginUrl != input.RemoteLoginUrl || (this.RemoteLoginUrl != null && !this.RemoteLoginUrl.Equals(input.RemoteLoginUrl))) return false;
            if (this.RemoteLogoutUrl != input.RemoteLogoutUrl || (this.RemoteLogoutUrl != null && !this.RemoteLogoutUrl.Equals(input.RemoteLogoutUrl))) return false;

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
                if (this.IssuerUrl != null) hashCode = hashCode * 59 + this.IssuerUrl.GetHashCode();
                if (this.MetadataUrl != null) hashCode = hashCode * 59 + this.MetadataUrl.GetHashCode();
                if (this.RemoteLoginUrl != null) hashCode = hashCode * 59 + this.RemoteLoginUrl.GetHashCode();
                if (this.RemoteLogoutUrl != null) hashCode = hashCode * 59 + this.RemoteLogoutUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
