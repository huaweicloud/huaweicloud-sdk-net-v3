using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceLtCredentialsResponse : SdkResponse
    {

        /// <summary>
        /// 长期访问凭据总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 长期访问凭证列表
        /// </summary>
        [JsonProperty("auth_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthToken> AuthTokens { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceLtCredentialsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  authTokens: ").Append(AuthTokens).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceLtCredentialsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceLtCredentialsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.AuthTokens != input.AuthTokens || (this.AuthTokens != null && input.AuthTokens != null && !this.AuthTokens.SequenceEqual(input.AuthTokens))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.AuthTokens != null) hashCode = hashCode * 59 + this.AuthTokens.GetHashCode();
                return hashCode;
            }
        }
    }
}
