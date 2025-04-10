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
    public class ShowDomainConsoleAclPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("console_acl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ConsoleAclPolicyResult ConsoleAclPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainConsoleAclPolicyResponse {\n");
            sb.Append("  consoleAclPolicy: ").Append(ConsoleAclPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainConsoleAclPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainConsoleAclPolicyResponse input)
        {
            if (input == null) return false;
            if (this.ConsoleAclPolicy != input.ConsoleAclPolicy || (this.ConsoleAclPolicy != null && !this.ConsoleAclPolicy.Equals(input.ConsoleAclPolicy))) return false;

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
                if (this.ConsoleAclPolicy != null) hashCode = hashCode * 59 + this.ConsoleAclPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
