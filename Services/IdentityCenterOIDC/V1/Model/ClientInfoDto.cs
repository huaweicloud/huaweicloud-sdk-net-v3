using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterOIDC.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientInfoDto 
    {

        /// <summary>
        /// 客户端可以请求授权的端点
        /// </summary>
        [JsonProperty("authorization_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// 客户端应用唯一标识
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// 客户端标识符和客户端密钥的注册时间
        /// </summary>
        [JsonProperty("client_id_issued_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClientIdIssuedAt { get; set; }

        /// <summary>
        /// 为客户端生成的秘密字符串。客户端将使用此字符串在后续调用中获得服务的身份验证
        /// </summary>
        [JsonProperty("client_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 客户端标识符和客户端密钥失效的时间
        /// </summary>
        [JsonProperty("client_secret_expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClientSecretExpiresAt { get; set; }

        /// <summary>
        /// 客户端可以在其中获取访问令牌的端点
        /// </summary>
        [JsonProperty("token_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// 服务器为客户端注册的作用域列表。后续授权访问令牌时，权限都应该限制在此作用域列表的子集范围内
        /// </summary>
        [JsonProperty("scopes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Scopes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientInfoDto {\n");
            sb.Append("  authorizationEndpoint: ").Append(AuthorizationEndpoint).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  clientIdIssuedAt: ").Append(ClientIdIssuedAt).Append("\n");
            sb.Append("  clientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  clientSecretExpiresAt: ").Append(ClientSecretExpiresAt).Append("\n");
            sb.Append("  tokenEndpoint: ").Append(TokenEndpoint).Append("\n");
            sb.Append("  scopes: ").Append(Scopes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientInfoDto input)
        {
            if (input == null) return false;
            if (this.AuthorizationEndpoint != input.AuthorizationEndpoint || (this.AuthorizationEndpoint != null && !this.AuthorizationEndpoint.Equals(input.AuthorizationEndpoint))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.ClientIdIssuedAt != input.ClientIdIssuedAt || (this.ClientIdIssuedAt != null && !this.ClientIdIssuedAt.Equals(input.ClientIdIssuedAt))) return false;
            if (this.ClientSecret != input.ClientSecret || (this.ClientSecret != null && !this.ClientSecret.Equals(input.ClientSecret))) return false;
            if (this.ClientSecretExpiresAt != input.ClientSecretExpiresAt || (this.ClientSecretExpiresAt != null && !this.ClientSecretExpiresAt.Equals(input.ClientSecretExpiresAt))) return false;
            if (this.TokenEndpoint != input.TokenEndpoint || (this.TokenEndpoint != null && !this.TokenEndpoint.Equals(input.TokenEndpoint))) return false;
            if (this.Scopes != input.Scopes || (this.Scopes != null && input.Scopes != null && !this.Scopes.SequenceEqual(input.Scopes))) return false;

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
                if (this.AuthorizationEndpoint != null) hashCode = hashCode * 59 + this.AuthorizationEndpoint.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientIdIssuedAt != null) hashCode = hashCode * 59 + this.ClientIdIssuedAt.GetHashCode();
                if (this.ClientSecret != null) hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.ClientSecretExpiresAt != null) hashCode = hashCode * 59 + this.ClientSecretExpiresAt.GetHashCode();
                if (this.TokenEndpoint != null) hashCode = hashCode * 59 + this.TokenEndpoint.GetHashCode();
                if (this.Scopes != null) hashCode = hashCode * 59 + this.Scopes.GetHashCode();
                return hashCode;
            }
        }
    }
}
