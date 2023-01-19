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
    public class NeutronListFirewallPoliciesResponse : SdkResponse
    {

        /// <summary>
        /// firewall_policy对象列表
        /// </summary>
        [JsonProperty("firewall_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronFirewallPolicy> FirewallPolicies { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("firewall_policies_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> FirewallPoliciesLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListFirewallPoliciesResponse {\n");
            sb.Append("  firewallPolicies: ").Append(FirewallPolicies).Append("\n");
            sb.Append("  firewallPoliciesLinks: ").Append(FirewallPoliciesLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListFirewallPoliciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListFirewallPoliciesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallPolicies == input.FirewallPolicies ||
                    this.FirewallPolicies != null &&
                    input.FirewallPolicies != null &&
                    this.FirewallPolicies.SequenceEqual(input.FirewallPolicies)
                ) && 
                (
                    this.FirewallPoliciesLinks == input.FirewallPoliciesLinks ||
                    this.FirewallPoliciesLinks != null &&
                    input.FirewallPoliciesLinks != null &&
                    this.FirewallPoliciesLinks.SequenceEqual(input.FirewallPoliciesLinks)
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
                if (this.FirewallPolicies != null)
                    hashCode = hashCode * 59 + this.FirewallPolicies.GetHashCode();
                if (this.FirewallPoliciesLinks != null)
                    hashCode = hashCode * 59 + this.FirewallPoliciesLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
