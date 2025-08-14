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
    public class ListBearerTokensResponse : SdkResponse
    {

        /// <summary>
        /// 访问令牌列表
        /// </summary>
        [JsonProperty("bearer_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public List<BearerToken> BearerTokens { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBearerTokensResponse {\n");
            sb.Append("  bearerTokens: ").Append(BearerTokens).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBearerTokensResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBearerTokensResponse input)
        {
            if (input == null) return false;
            if (this.BearerTokens != input.BearerTokens || (this.BearerTokens != null && input.BearerTokens != null && !this.BearerTokens.SequenceEqual(input.BearerTokens))) return false;

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
                if (this.BearerTokens != null) hashCode = hashCode * 59 + this.BearerTokens.GetHashCode();
                return hashCode;
            }
        }
    }
}
