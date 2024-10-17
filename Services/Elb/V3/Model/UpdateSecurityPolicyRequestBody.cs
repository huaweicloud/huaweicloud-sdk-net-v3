using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class UpdateSecurityPolicyRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_policy", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSecurityPolicyOption SecurityPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSecurityPolicyRequestBody {\n");
            sb.Append("  securityPolicy: ").Append(SecurityPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSecurityPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSecurityPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.SecurityPolicy != input.SecurityPolicy || (this.SecurityPolicy != null && !this.SecurityPolicy.Equals(input.SecurityPolicy))) return false;

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
                if (this.SecurityPolicy != null) hashCode = hashCode * 59 + this.SecurityPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
