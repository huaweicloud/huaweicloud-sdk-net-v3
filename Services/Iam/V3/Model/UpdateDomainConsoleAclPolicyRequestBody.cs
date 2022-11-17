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
    public class UpdateDomainConsoleAclPolicyRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("console_acl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AclPolicyOption ConsoleAclPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainConsoleAclPolicyRequestBody {\n");
            sb.Append("  consoleAclPolicy: ").Append(ConsoleAclPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainConsoleAclPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainConsoleAclPolicyRequestBody input)
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
