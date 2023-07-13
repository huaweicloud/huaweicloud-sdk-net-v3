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
    public class ListSecurityGroupRulesResponse : SdkResponse
    {

        /// <summary>
        /// 安全组规则对象列表
        /// </summary>
        [JsonProperty("security_group_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroupRule> SecurityGroupRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSecurityGroupRulesResponse {\n");
            sb.Append("  securityGroupRules: ").Append(SecurityGroupRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSecurityGroupRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSecurityGroupRulesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityGroupRules == input.SecurityGroupRules ||
                    this.SecurityGroupRules != null &&
                    input.SecurityGroupRules != null &&
                    this.SecurityGroupRules.SequenceEqual(input.SecurityGroupRules)
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
                if (this.SecurityGroupRules != null)
                    hashCode = hashCode * 59 + this.SecurityGroupRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
