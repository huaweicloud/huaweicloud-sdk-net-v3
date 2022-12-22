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
    /// 
    /// </summary>
    public class NeutronInsertFirewallRuleRequestBody 
    {

        /// <summary>
        /// 功能说明：网络ACL规则ID
        /// </summary>
        [JsonProperty("firewall_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallRuleId { get; set; }

        /// <summary>
        /// insert_after参数表示已经和某个policy关联的rule，新的rule将会直接被插入到insert_after参数指定的rule后面。如果insert_after和insert_before都被指定了，insert_after参数值将被忽略。
        /// </summary>
        [JsonProperty("insert_after", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertAfter { get; set; }

        /// <summary>
        /// insert_before参数表示已经和某个policy关联的rule，新的firewall rule将会直接被插入到insert_ before参数指定的firewall rule前面。如果insert_after和insert_before都被指定了，insert_after参数值将被忽略。
        /// </summary>
        [JsonProperty("insert_before", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertBefore { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronInsertFirewallRuleRequestBody {\n");
            sb.Append("  firewallRuleId: ").Append(FirewallRuleId).Append("\n");
            sb.Append("  insertAfter: ").Append(InsertAfter).Append("\n");
            sb.Append("  insertBefore: ").Append(InsertBefore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronInsertFirewallRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronInsertFirewallRuleRequestBody input)
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
                    this.InsertAfter == input.InsertAfter ||
                    (this.InsertAfter != null &&
                    this.InsertAfter.Equals(input.InsertAfter))
                ) && 
                (
                    this.InsertBefore == input.InsertBefore ||
                    (this.InsertBefore != null &&
                    this.InsertBefore.Equals(input.InsertBefore))
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
                if (this.InsertAfter != null)
                    hashCode = hashCode * 59 + this.InsertAfter.GetHashCode();
                if (this.InsertBefore != null)
                    hashCode = hashCode * 59 + this.InsertBefore.GetHashCode();
                return hashCode;
            }
        }
    }
}
