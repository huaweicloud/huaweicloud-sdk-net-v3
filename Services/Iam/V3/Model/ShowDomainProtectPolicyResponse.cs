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
    public class ShowDomainProtectPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("protect_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ShowDomainProtectPolicyResponseBodyProtectPolicy ProtectPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainProtectPolicyResponse {\n");
            sb.Append("  protectPolicy: ").Append(ProtectPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainProtectPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainProtectPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectPolicy == input.ProtectPolicy ||
                    (this.ProtectPolicy != null &&
                    this.ProtectPolicy.Equals(input.ProtectPolicy))
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
                if (this.ProtectPolicy != null)
                    hashCode = hashCode * 59 + this.ProtectPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
