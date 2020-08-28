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
    public class UpdateDomainLoginPolicyRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login_policy", NullValueHandling = NullValueHandling.Ignore)]
        public LoginPolicyOption LoginPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainLoginPolicyRequestBody {\n");
            sb.Append("  loginPolicy: ").Append(LoginPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainLoginPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainLoginPolicyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoginPolicy == input.LoginPolicy ||
                    (this.LoginPolicy != null &&
                    this.LoginPolicy.Equals(input.LoginPolicy))
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
                if (this.LoginPolicy != null)
                    hashCode = hashCode * 59 + this.LoginPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
