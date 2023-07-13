using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class NeutronCreateSecurityGroupRuleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public NeutronSecurityGroupRule SecurityGroupRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateSecurityGroupRuleResponse {\n");
            sb.Append("  securityGroupRule: ").Append(SecurityGroupRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateSecurityGroupRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateSecurityGroupRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityGroupRule == input.SecurityGroupRule ||
                    (this.SecurityGroupRule != null &&
                    this.SecurityGroupRule.Equals(input.SecurityGroupRule))
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
                if (this.SecurityGroupRule != null)
                    hashCode = hashCode * 59 + this.SecurityGroupRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
