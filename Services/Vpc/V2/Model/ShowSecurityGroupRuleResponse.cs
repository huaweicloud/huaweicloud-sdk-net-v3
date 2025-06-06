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
    public class ShowSecurityGroupRuleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityGroupRule SecurityGroupRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSecurityGroupRuleResponse {\n");
            sb.Append("  securityGroupRule: ").Append(SecurityGroupRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSecurityGroupRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSecurityGroupRuleResponse input)
        {
            if (input == null) return false;
            if (this.SecurityGroupRule != input.SecurityGroupRule || (this.SecurityGroupRule != null && !this.SecurityGroupRule.Equals(input.SecurityGroupRule))) return false;

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
                if (this.SecurityGroupRule != null) hashCode = hashCode * 59 + this.SecurityGroupRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
