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
    public class NeutronUpdateFirewallPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("firewall_policy", NullValueHandling = NullValueHandling.Ignore)]
        public NeutronFirewallPolicy FirewallPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateFirewallPolicyResponse {\n");
            sb.Append("  firewallPolicy: ").Append(FirewallPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateFirewallPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateFirewallPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallPolicy == input.FirewallPolicy ||
                    (this.FirewallPolicy != null &&
                    this.FirewallPolicy.Equals(input.FirewallPolicy))
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
                if (this.FirewallPolicy != null)
                    hashCode = hashCode * 59 + this.FirewallPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
