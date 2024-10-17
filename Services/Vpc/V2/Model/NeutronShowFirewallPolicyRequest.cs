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
    /// Request Object
    /// </summary>
    public class NeutronShowFirewallPolicyRequest 
    {

        /// <summary>
        /// 网络ACL防火墙策略ID
        /// </summary>
        [SDKProperty("firewall_policy_id", IsPath = true)]
        [JsonProperty("firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronShowFirewallPolicyRequest {\n");
            sb.Append("  firewallPolicyId: ").Append(FirewallPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronShowFirewallPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronShowFirewallPolicyRequest input)
        {
            if (input == null) return false;
            if (this.FirewallPolicyId != input.FirewallPolicyId || (this.FirewallPolicyId != null && !this.FirewallPolicyId.Equals(input.FirewallPolicyId))) return false;

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
                if (this.FirewallPolicyId != null) hashCode = hashCode * 59 + this.FirewallPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
