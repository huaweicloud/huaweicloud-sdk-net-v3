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
    /// 
    /// </summary>
    public class LoginTokenAuth 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("securitytoken", NullValueHandling = NullValueHandling.Ignore)]
        public LoginTokenSecurityToken Securitytoken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginTokenAuth {\n");
            sb.Append("  securitytoken: ").Append(Securitytoken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoginTokenAuth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoginTokenAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Securitytoken == input.Securitytoken ||
                    (this.Securitytoken != null &&
                    this.Securitytoken.Equals(input.Securitytoken))
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
                if (this.Securitytoken != null)
                    hashCode = hashCode * 59 + this.Securitytoken.GetHashCode();
                return hashCode;
            }
        }
    }
}
