using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateBearerTokenResponse : SdkResponse
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreationTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ExpirationTime { get; set; }

        /// <summary>
        /// 访问令牌
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 访问令牌的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("token_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBearerTokenResponse {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  tokenId: ").Append(TokenId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBearerTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBearerTokenResponse input)
        {
            if (input == null) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.ExpirationTime != input.ExpirationTime || (this.ExpirationTime != null && !this.ExpirationTime.Equals(input.ExpirationTime))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.TokenId != input.TokenId || (this.TokenId != null && !this.TokenId.Equals(input.TokenId))) return false;

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
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.ExpirationTime != null) hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenId != null) hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                return hashCode;
            }
        }
    }
}
