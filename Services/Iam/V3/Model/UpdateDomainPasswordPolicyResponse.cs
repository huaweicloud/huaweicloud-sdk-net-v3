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
    public class UpdateDomainPasswordPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("password_policy", NullValueHandling = NullValueHandling.Ignore)]
        public PasswordPolicyResult PasswordPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainPasswordPolicyResponse {\n");
            sb.Append("  passwordPolicy: ").Append(PasswordPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainPasswordPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainPasswordPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PasswordPolicy == input.PasswordPolicy ||
                    (this.PasswordPolicy != null &&
                    this.PasswordPolicy.Equals(input.PasswordPolicy))
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
                if (this.PasswordPolicy != null)
                    hashCode = hashCode * 59 + this.PasswordPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
