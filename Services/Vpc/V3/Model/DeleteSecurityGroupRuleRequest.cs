using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteSecurityGroupRuleRequest 
    {

        /// <summary>
        /// 安全组规则ID
        /// </summary>
        [SDKProperty("security_group_rule_id", IsPath = true)]
        [JsonProperty("security_group_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupRuleId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSecurityGroupRuleRequest {\n");
            sb.Append("  securityGroupRuleId: ").Append(SecurityGroupRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSecurityGroupRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSecurityGroupRuleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityGroupRuleId == input.SecurityGroupRuleId ||
                    (this.SecurityGroupRuleId != null &&
                    this.SecurityGroupRuleId.Equals(input.SecurityGroupRuleId))
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
                if (this.SecurityGroupRuleId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
