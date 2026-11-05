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
    /// Response Object
    /// </summary>
    public class ShowSupabaseApplicationAuthConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_account_sign_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAccountSignUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_anonymous_users", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAnonymousUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("api_external_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiExternalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("site_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allow_redirect_urls", NullValueHandling = NullValueHandling.Ignore)]
        public string AllowRedirectUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("github_oauth_provider", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseApiGitHubOAuthProvider GithubOauthProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email_oauth_provider", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseApiEmailOAuthProvider EmailOauthProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email_template_config", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseApiEmailTemplate EmailTemplateConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSupabaseApplicationAuthConfigResponse {\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  enableAccountSignUp: ").Append(EnableAccountSignUp).Append("\n");
            sb.Append("  enableAnonymousUsers: ").Append(EnableAnonymousUsers).Append("\n");
            sb.Append("  apiExternalUrl: ").Append(ApiExternalUrl).Append("\n");
            sb.Append("  siteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  allowRedirectUrls: ").Append(AllowRedirectUrls).Append("\n");
            sb.Append("  githubOauthProvider: ").Append(GithubOauthProvider).Append("\n");
            sb.Append("  emailOauthProvider: ").Append(EmailOauthProvider).Append("\n");
            sb.Append("  emailTemplateConfig: ").Append(EmailTemplateConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSupabaseApplicationAuthConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSupabaseApplicationAuthConfigResponse input)
        {
            if (input == null) return false;
            if (this.UpdatedTime != input.UpdatedTime || (this.UpdatedTime != null && !this.UpdatedTime.Equals(input.UpdatedTime))) return false;
            if (this.EnableAccountSignUp != input.EnableAccountSignUp || (this.EnableAccountSignUp != null && !this.EnableAccountSignUp.Equals(input.EnableAccountSignUp))) return false;
            if (this.EnableAnonymousUsers != input.EnableAnonymousUsers || (this.EnableAnonymousUsers != null && !this.EnableAnonymousUsers.Equals(input.EnableAnonymousUsers))) return false;
            if (this.ApiExternalUrl != input.ApiExternalUrl || (this.ApiExternalUrl != null && !this.ApiExternalUrl.Equals(input.ApiExternalUrl))) return false;
            if (this.SiteUrl != input.SiteUrl || (this.SiteUrl != null && !this.SiteUrl.Equals(input.SiteUrl))) return false;
            if (this.AllowRedirectUrls != input.AllowRedirectUrls || (this.AllowRedirectUrls != null && !this.AllowRedirectUrls.Equals(input.AllowRedirectUrls))) return false;
            if (this.GithubOauthProvider != input.GithubOauthProvider || (this.GithubOauthProvider != null && !this.GithubOauthProvider.Equals(input.GithubOauthProvider))) return false;
            if (this.EmailOauthProvider != input.EmailOauthProvider || (this.EmailOauthProvider != null && !this.EmailOauthProvider.Equals(input.EmailOauthProvider))) return false;
            if (this.EmailTemplateConfig != input.EmailTemplateConfig || (this.EmailTemplateConfig != null && !this.EmailTemplateConfig.Equals(input.EmailTemplateConfig))) return false;

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
                if (this.UpdatedTime != null) hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.EnableAccountSignUp != null) hashCode = hashCode * 59 + this.EnableAccountSignUp.GetHashCode();
                if (this.EnableAnonymousUsers != null) hashCode = hashCode * 59 + this.EnableAnonymousUsers.GetHashCode();
                if (this.ApiExternalUrl != null) hashCode = hashCode * 59 + this.ApiExternalUrl.GetHashCode();
                if (this.SiteUrl != null) hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.AllowRedirectUrls != null) hashCode = hashCode * 59 + this.AllowRedirectUrls.GetHashCode();
                if (this.GithubOauthProvider != null) hashCode = hashCode * 59 + this.GithubOauthProvider.GetHashCode();
                if (this.EmailOauthProvider != null) hashCode = hashCode * 59 + this.EmailOauthProvider.GetHashCode();
                if (this.EmailTemplateConfig != null) hashCode = hashCode * 59 + this.EmailTemplateConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
