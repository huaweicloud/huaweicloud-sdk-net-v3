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
    public class NeutronListFirewallGroupsResponse : SdkResponse
    {

        /// <summary>
        /// firewall_group对象列表
        /// </summary>
        [JsonProperty("firewall_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronFirewallGroup> FirewallGroups { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("firewall_groups_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> FirewallGroupsLinks { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListFirewallGroupsResponse {\n");
            sb.Append("  firewallGroups: ").Append(FirewallGroups).Append("\n");
            sb.Append("  firewallGroupsLinks: ").Append(FirewallGroupsLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListFirewallGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListFirewallGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallGroups == input.FirewallGroups ||
                    this.FirewallGroups != null &&
                    input.FirewallGroups != null &&
                    this.FirewallGroups.SequenceEqual(input.FirewallGroups)
                ) && 
                (
                    this.FirewallGroupsLinks == input.FirewallGroupsLinks ||
                    this.FirewallGroupsLinks != null &&
                    input.FirewallGroupsLinks != null &&
                    this.FirewallGroupsLinks.SequenceEqual(input.FirewallGroupsLinks)
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
                if (this.FirewallGroups != null)
                    hashCode = hashCode * 59 + this.FirewallGroups.GetHashCode();
                if (this.FirewallGroupsLinks != null)
                    hashCode = hashCode * 59 + this.FirewallGroupsLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
