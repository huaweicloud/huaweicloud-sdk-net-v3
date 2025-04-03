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
    public class TokenInfoDto 
    {

        /// <summary>
        /// 用于访问分配给用户的IAM身份中心资源的不透明令牌
        /// </summary>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 访问令牌的过期时间（以秒为单位）
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 用于表明用户身份的不透明令牌
        /// </summary>
        [JsonProperty("id_token", NullValueHandling = NullValueHandling.Ignore)]
        public string IdToken { get; set; }

        /// <summary>
        /// 刷新令牌，此令牌可在访问令牌过期后获取新的访问令牌
        /// </summary>
        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 用于通知客户端返回的令牌是访问令牌，目前为BearerToken
        /// </summary>
        [JsonProperty("token_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenInfoDto {\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  expiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  idToken: ").Append(IdToken).Append("\n");
            sb.Append("  refreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  tokenType: ").Append(TokenType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokenInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TokenInfoDto input)
        {
            if (input == null) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;
            if (this.ExpiresIn != input.ExpiresIn || (this.ExpiresIn != null && !this.ExpiresIn.Equals(input.ExpiresIn))) return false;
            if (this.IdToken != input.IdToken || (this.IdToken != null && !this.IdToken.Equals(input.IdToken))) return false;
            if (this.RefreshToken != input.RefreshToken || (this.RefreshToken != null && !this.RefreshToken.Equals(input.RefreshToken))) return false;
            if (this.TokenType != input.TokenType || (this.TokenType != null && !this.TokenType.Equals(input.TokenType))) return false;

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
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ExpiresIn != null) hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.IdToken != null) hashCode = hashCode * 59 + this.IdToken.GetHashCode();
                if (this.RefreshToken != null) hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.TokenType != null) hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                return hashCode;
            }
        }
    }
}
