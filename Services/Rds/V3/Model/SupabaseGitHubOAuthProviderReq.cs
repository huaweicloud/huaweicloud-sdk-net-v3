using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// enable_github&#x3D;false时清空oauth_client_id/secret/redirect_uri。
    /// </summary>
    public class SupabaseGitHubOAuthProviderReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_github", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableGithub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("oauth_client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OauthClientId { get; set; }

        /// <summary>
        /// 秘密，受控输入，show不返回。
        /// </summary>
        [JsonProperty("oauth_client_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string OauthClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirect_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupabaseGitHubOAuthProviderReq {\n");
            sb.Append("  enableGithub: ").Append(EnableGithub).Append("\n");
            sb.Append("  oauthClientId: ").Append(OauthClientId).Append("\n");
            sb.Append("  oauthClientSecret: ").Append(OauthClientSecret).Append("\n");
            sb.Append("  redirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupabaseGitHubOAuthProviderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupabaseGitHubOAuthProviderReq input)
        {
            if (input == null) return false;
            if (this.EnableGithub != input.EnableGithub || (this.EnableGithub != null && !this.EnableGithub.Equals(input.EnableGithub))) return false;
            if (this.OauthClientId != input.OauthClientId || (this.OauthClientId != null && !this.OauthClientId.Equals(input.OauthClientId))) return false;
            if (this.OauthClientSecret != input.OauthClientSecret || (this.OauthClientSecret != null && !this.OauthClientSecret.Equals(input.OauthClientSecret))) return false;
            if (this.RedirectUri != input.RedirectUri || (this.RedirectUri != null && !this.RedirectUri.Equals(input.RedirectUri))) return false;

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
                if (this.EnableGithub != null) hashCode = hashCode * 59 + this.EnableGithub.GetHashCode();
                if (this.OauthClientId != null) hashCode = hashCode * 59 + this.OauthClientId.GetHashCode();
                if (this.OauthClientSecret != null) hashCode = hashCode * 59 + this.OauthClientSecret.GetHashCode();
                if (this.RedirectUri != null) hashCode = hashCode * 59 + this.RedirectUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
