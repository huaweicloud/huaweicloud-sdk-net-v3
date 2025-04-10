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
    /// Response Object
    /// </summary>
    public class CreateTokenResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("token_info", NullValueHandling = NullValueHandling.Ignore)]
        public TokenInfoDto TokenInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTokenResponse {\n");
            sb.Append("  tokenInfo: ").Append(TokenInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTokenResponse input)
        {
            if (input == null) return false;
            if (this.TokenInfo != input.TokenInfo || (this.TokenInfo != null && !this.TokenInfo.Equals(input.TokenInfo))) return false;

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
                if (this.TokenInfo != null) hashCode = hashCode * 59 + this.TokenInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
