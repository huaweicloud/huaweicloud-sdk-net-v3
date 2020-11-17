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
    public class NeutronUpdateFirewallRuleRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("firewall_rule_id", IsPath = true)]
        [JsonProperty("firewall_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallRuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public NeutronUpdateFirewallRuleRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateFirewallRuleRequest {\n");
            sb.Append("  firewallRuleId: ").Append(FirewallRuleId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateFirewallRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateFirewallRuleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallRuleId == input.FirewallRuleId ||
                    (this.FirewallRuleId != null &&
                    this.FirewallRuleId.Equals(input.FirewallRuleId))
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
                if (this.FirewallRuleId != null)
                    hashCode = hashCode * 59 + this.FirewallRuleId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
