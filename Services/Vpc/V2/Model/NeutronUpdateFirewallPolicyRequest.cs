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
    public class NeutronUpdateFirewallPolicyRequest 
    {

        /// <summary>
        /// 网络ACL防火墙策略ID
        /// </summary>
        [SDKProperty("firewall_policy_id", IsPath = true)]
        [JsonProperty("firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallPolicyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public NeutronUpdateFirewallPolicyRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateFirewallPolicyRequest {\n");
            sb.Append("  firewallPolicyId: ").Append(FirewallPolicyId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateFirewallPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateFirewallPolicyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallPolicyId == input.FirewallPolicyId ||
                    (this.FirewallPolicyId != null &&
                    this.FirewallPolicyId.Equals(input.FirewallPolicyId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.FirewallPolicyId != null)
                    hashCode = hashCode * 59 + this.FirewallPolicyId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
