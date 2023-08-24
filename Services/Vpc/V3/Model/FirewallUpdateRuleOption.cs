using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FirewallUpdateRuleOption 
    {

        /// <summary>
        /// 功能说明：ACL更新入方向规则列表 约束：ingress_rules和egress_rules仅能同时设置一个，且当前只支持同时更新一条规则
        /// </summary>
        [JsonProperty("ingress_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<FirewallUpdateRuleItemOption> IngressRules { get; set; }

        /// <summary>
        /// 功能说明：ACL更新出方向规则列表 约束：ingress_rules和egress_rules仅能同时设置一个，且当前只支持同时更新一条规则
        /// </summary>
        [JsonProperty("egress_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<FirewallUpdateRuleItemOption> EgressRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallUpdateRuleOption {\n");
            sb.Append("  ingressRules: ").Append(IngressRules).Append("\n");
            sb.Append("  egressRules: ").Append(EgressRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FirewallUpdateRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FirewallUpdateRuleOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IngressRules == input.IngressRules ||
                    this.IngressRules != null &&
                    input.IngressRules != null &&
                    this.IngressRules.SequenceEqual(input.IngressRules)
                ) && 
                (
                    this.EgressRules == input.EgressRules ||
                    this.EgressRules != null &&
                    input.EgressRules != null &&
                    this.EgressRules.SequenceEqual(input.EgressRules)
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
                if (this.IngressRules != null)
                    hashCode = hashCode * 59 + this.IngressRules.GetHashCode();
                if (this.EgressRules != null)
                    hashCode = hashCode * 59 + this.EgressRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
