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
    public class NeutronCreateFirewallPolicyOption 
    {

        /// <summary>
        /// 审计标记。
        /// </summary>
        [JsonProperty("audited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Audited { get; set; }

        /// <summary>
        /// 功能说明：网络ACL防火墙策略描述 取值范围：最长255个字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 策略引用的网络ACL防火墙规则链。
        /// </summary>
        [JsonProperty("firewall_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FirewallRules { get; set; }

        /// <summary>
        /// 功能说明：网络ACL防火墙策略名称 取值范围：最长255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateFirewallPolicyOption {\n");
            sb.Append("  audited: ").Append(Audited).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  firewallRules: ").Append(FirewallRules).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateFirewallPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateFirewallPolicyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Audited == input.Audited ||
                    (this.Audited != null &&
                    this.Audited.Equals(input.Audited))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FirewallRules == input.FirewallRules ||
                    this.FirewallRules != null &&
                    input.FirewallRules != null &&
                    this.FirewallRules.SequenceEqual(input.FirewallRules)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Audited != null)
                    hashCode = hashCode * 59 + this.Audited.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FirewallRules != null)
                    hashCode = hashCode * 59 + this.FirewallRules.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
