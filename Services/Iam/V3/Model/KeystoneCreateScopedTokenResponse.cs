using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class KeystoneCreateScopedTokenResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public ScopeTokenResult Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Subject-Token", IsHeader = true)]
        [JsonProperty("X-Subject-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSubjectToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneCreateScopedTokenResponse {\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  xSubjectToken: ").Append(XSubjectToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneCreateScopedTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneCreateScopedTokenResponse input)
        {
            if (input == null) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.XSubjectToken != input.XSubjectToken || (this.XSubjectToken != null && !this.XSubjectToken.Equals(input.XSubjectToken))) return false;

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
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.XSubjectToken != null) hashCode = hashCode * 59 + this.XSubjectToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
