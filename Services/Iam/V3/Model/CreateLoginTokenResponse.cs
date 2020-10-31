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
    public class CreateLoginTokenResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logintoken", NullValueHandling = NullValueHandling.Ignore)]
        public LoginToken Logintoken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Subject-LoginToken", IsHeader = true)]
        [JsonProperty("X-Subject-LoginToken", NullValueHandling = NullValueHandling.Ignore)]
        public string XSubjectLoginToken { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoginTokenResponse {\n");
            sb.Append("  logintoken: ").Append(Logintoken).Append("\n");
            sb.Append("  xSubjectLoginToken: ").Append(XSubjectLoginToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoginTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoginTokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Logintoken == input.Logintoken ||
                    (this.Logintoken != null &&
                    this.Logintoken.Equals(input.Logintoken))
                ) && 
                (
                    this.XSubjectLoginToken == input.XSubjectLoginToken ||
                    (this.XSubjectLoginToken != null &&
                    this.XSubjectLoginToken.Equals(input.XSubjectLoginToken))
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
                if (this.Logintoken != null)
                    hashCode = hashCode * 59 + this.Logintoken.GetHashCode();
                if (this.XSubjectLoginToken != null)
                    hashCode = hashCode * 59 + this.XSubjectLoginToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
