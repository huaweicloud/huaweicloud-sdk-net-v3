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
    public class KeystoneCreateUserTokenByPasswordResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public TokenResult Token { get; set; }

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
            sb.Append("class KeystoneCreateUserTokenByPasswordResponse {\n");
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
            return this.Equals(input as KeystoneCreateUserTokenByPasswordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneCreateUserTokenByPasswordResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.XSubjectToken == input.XSubjectToken ||
                    (this.XSubjectToken != null &&
                    this.XSubjectToken.Equals(input.XSubjectToken))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.XSubjectToken != null)
                    hashCode = hashCode * 59 + this.XSubjectToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
