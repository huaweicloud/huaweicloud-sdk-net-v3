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
    public class UpdateDomainConsoleAclPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("console_acl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AclPolicyResult ConsoleAclPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainConsoleAclPolicyResponse {\n");
            sb.Append("  consoleAclPolicy: ").Append(ConsoleAclPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainConsoleAclPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainConsoleAclPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsoleAclPolicy == input.ConsoleAclPolicy ||
                    (this.ConsoleAclPolicy != null &&
                    this.ConsoleAclPolicy.Equals(input.ConsoleAclPolicy))
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
                if (this.ConsoleAclPolicy != null)
                    hashCode = hashCode * 59 + this.ConsoleAclPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
