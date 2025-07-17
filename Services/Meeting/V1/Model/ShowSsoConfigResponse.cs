using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSsoConfigResponse : SdkResponse
    {

        /// <summary>
        /// 是否开启SSO登录。
        /// </summary>
        [JsonProperty("enableSSO", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSSO { get; set; }

        /// <summary>
        /// 企业域名。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 鉴权中心URL。
        /// </summary>
        [JsonProperty("authorizeUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizeUrl { get; set; }

        /// <summary>
        /// 获取Token URL。
        /// </summary>
        [JsonProperty("getTokenUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string GetTokenUrl { get; set; }

        /// <summary>
        /// APP ID。
        /// </summary>
        [JsonProperty("clientId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// APP秘钥。
        /// </summary>
        [JsonProperty("clientSecret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 授权范围。 * openid：OAuth2.0的OIDC 
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// 第三方帐号的字段名称。
        /// </summary>
        [JsonProperty("accFieldName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccFieldName { get; set; }

        /// <summary>
        /// 用户信息查询URL。
        /// </summary>
        [JsonProperty("getUserInfoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string GetUserInfoUrl { get; set; }

        /// <summary>
        /// 鉴权类型。OAuth2.0鉴权时取0。 * 0：OAuth2.0鉴权 
        /// </summary>
        [JsonProperty("oauth2ServerType", NullValueHandling = NullValueHandling.Ignore)]
        public int? Oauth2ServerType { get; set; }

        /// <summary>
        /// 拉起PC端终端的schema。
        /// </summary>
        [JsonProperty("pcSchemaUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string PcSchemaUrl { get; set; }

        /// <summary>
        /// 拉起安卓端终端的schema。
        /// </summary>
        [JsonProperty("androidSchemaUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string AndroidSchemaUrl { get; set; }

        /// <summary>
        /// 拉起ios端终端的schema。
        /// </summary>
        [JsonProperty("iosSchemaUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string IosSchemaUrl { get; set; }

        /// <summary>
        /// 第三方名称的字段名称。
        /// </summary>
        [JsonProperty("thirdName", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdName { get; set; }

        /// <summary>
        /// 第三方邮箱的字段名称。
        /// </summary>
        [JsonProperty("thirdEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdEmail { get; set; }

        /// <summary>
        /// 第三方手机号的字段名称。
        /// </summary>
        [JsonProperty("thirdMobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdMobile { get; set; }

        /// <summary>
        /// 第三方accessToken的字段名称。
        /// </summary>
        [JsonProperty("thirdAccessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdAccessToken { get; set; }

        /// <summary>
        /// 第三方头像链接的字段名称。
        /// </summary>
        [JsonProperty("thirdHeadImgUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdHeadImgUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSsoConfigResponse {\n");
            sb.Append("  enableSSO: ").Append(EnableSSO).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  authorizeUrl: ").Append(AuthorizeUrl).Append("\n");
            sb.Append("  getTokenUrl: ").Append(GetTokenUrl).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  clientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  accFieldName: ").Append(AccFieldName).Append("\n");
            sb.Append("  getUserInfoUrl: ").Append(GetUserInfoUrl).Append("\n");
            sb.Append("  oauth2ServerType: ").Append(Oauth2ServerType).Append("\n");
            sb.Append("  pcSchemaUrl: ").Append(PcSchemaUrl).Append("\n");
            sb.Append("  androidSchemaUrl: ").Append(AndroidSchemaUrl).Append("\n");
            sb.Append("  iosSchemaUrl: ").Append(IosSchemaUrl).Append("\n");
            sb.Append("  thirdName: ").Append(ThirdName).Append("\n");
            sb.Append("  thirdEmail: ").Append(ThirdEmail).Append("\n");
            sb.Append("  thirdMobile: ").Append(ThirdMobile).Append("\n");
            sb.Append("  thirdAccessToken: ").Append(ThirdAccessToken).Append("\n");
            sb.Append("  thirdHeadImgUrl: ").Append(ThirdHeadImgUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSsoConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSsoConfigResponse input)
        {
            if (input == null) return false;
            if (this.EnableSSO != input.EnableSSO || (this.EnableSSO != null && !this.EnableSSO.Equals(input.EnableSSO))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AuthorizeUrl != input.AuthorizeUrl || (this.AuthorizeUrl != null && !this.AuthorizeUrl.Equals(input.AuthorizeUrl))) return false;
            if (this.GetTokenUrl != input.GetTokenUrl || (this.GetTokenUrl != null && !this.GetTokenUrl.Equals(input.GetTokenUrl))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.ClientSecret != input.ClientSecret || (this.ClientSecret != null && !this.ClientSecret.Equals(input.ClientSecret))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.AccFieldName != input.AccFieldName || (this.AccFieldName != null && !this.AccFieldName.Equals(input.AccFieldName))) return false;
            if (this.GetUserInfoUrl != input.GetUserInfoUrl || (this.GetUserInfoUrl != null && !this.GetUserInfoUrl.Equals(input.GetUserInfoUrl))) return false;
            if (this.Oauth2ServerType != input.Oauth2ServerType || (this.Oauth2ServerType != null && !this.Oauth2ServerType.Equals(input.Oauth2ServerType))) return false;
            if (this.PcSchemaUrl != input.PcSchemaUrl || (this.PcSchemaUrl != null && !this.PcSchemaUrl.Equals(input.PcSchemaUrl))) return false;
            if (this.AndroidSchemaUrl != input.AndroidSchemaUrl || (this.AndroidSchemaUrl != null && !this.AndroidSchemaUrl.Equals(input.AndroidSchemaUrl))) return false;
            if (this.IosSchemaUrl != input.IosSchemaUrl || (this.IosSchemaUrl != null && !this.IosSchemaUrl.Equals(input.IosSchemaUrl))) return false;
            if (this.ThirdName != input.ThirdName || (this.ThirdName != null && !this.ThirdName.Equals(input.ThirdName))) return false;
            if (this.ThirdEmail != input.ThirdEmail || (this.ThirdEmail != null && !this.ThirdEmail.Equals(input.ThirdEmail))) return false;
            if (this.ThirdMobile != input.ThirdMobile || (this.ThirdMobile != null && !this.ThirdMobile.Equals(input.ThirdMobile))) return false;
            if (this.ThirdAccessToken != input.ThirdAccessToken || (this.ThirdAccessToken != null && !this.ThirdAccessToken.Equals(input.ThirdAccessToken))) return false;
            if (this.ThirdHeadImgUrl != input.ThirdHeadImgUrl || (this.ThirdHeadImgUrl != null && !this.ThirdHeadImgUrl.Equals(input.ThirdHeadImgUrl))) return false;

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
                if (this.EnableSSO != null) hashCode = hashCode * 59 + this.EnableSSO.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AuthorizeUrl != null) hashCode = hashCode * 59 + this.AuthorizeUrl.GetHashCode();
                if (this.GetTokenUrl != null) hashCode = hashCode * 59 + this.GetTokenUrl.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null) hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.AccFieldName != null) hashCode = hashCode * 59 + this.AccFieldName.GetHashCode();
                if (this.GetUserInfoUrl != null) hashCode = hashCode * 59 + this.GetUserInfoUrl.GetHashCode();
                if (this.Oauth2ServerType != null) hashCode = hashCode * 59 + this.Oauth2ServerType.GetHashCode();
                if (this.PcSchemaUrl != null) hashCode = hashCode * 59 + this.PcSchemaUrl.GetHashCode();
                if (this.AndroidSchemaUrl != null) hashCode = hashCode * 59 + this.AndroidSchemaUrl.GetHashCode();
                if (this.IosSchemaUrl != null) hashCode = hashCode * 59 + this.IosSchemaUrl.GetHashCode();
                if (this.ThirdName != null) hashCode = hashCode * 59 + this.ThirdName.GetHashCode();
                if (this.ThirdEmail != null) hashCode = hashCode * 59 + this.ThirdEmail.GetHashCode();
                if (this.ThirdMobile != null) hashCode = hashCode * 59 + this.ThirdMobile.GetHashCode();
                if (this.ThirdAccessToken != null) hashCode = hashCode * 59 + this.ThirdAccessToken.GetHashCode();
                if (this.ThirdHeadImgUrl != null) hashCode = hashCode * 59 + this.ThirdHeadImgUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
