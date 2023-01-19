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
    public class NeutronListFirewallRulesResponse : SdkResponse
    {

        /// <summary>
        /// firewall_rule对象列表
        /// </summary>
        [JsonProperty("firewall_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronFirewallRule> FirewallRules { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("firewall_rules_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> FirewallRulesLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListFirewallRulesResponse {\n");
            sb.Append("  firewallRules: ").Append(FirewallRules).Append("\n");
            sb.Append("  firewallRulesLinks: ").Append(FirewallRulesLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListFirewallRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListFirewallRulesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallRules == input.FirewallRules ||
                    this.FirewallRules != null &&
                    input.FirewallRules != null &&
                    this.FirewallRules.SequenceEqual(input.FirewallRules)
                ) && 
                (
                    this.FirewallRulesLinks == input.FirewallRulesLinks ||
                    this.FirewallRulesLinks != null &&
                    input.FirewallRulesLinks != null &&
                    this.FirewallRulesLinks.SequenceEqual(input.FirewallRulesLinks)
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
                if (this.FirewallRules != null)
                    hashCode = hashCode * 59 + this.FirewallRules.GetHashCode();
                if (this.FirewallRulesLinks != null)
                    hashCode = hashCode * 59 + this.FirewallRulesLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
