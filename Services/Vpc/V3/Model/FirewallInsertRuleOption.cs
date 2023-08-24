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
    public class FirewallInsertRuleOption 
    {

        /// <summary>
        /// 功能说明：ACL添加入方向规则列表
        /// </summary>
        [JsonProperty("ingress_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<FirewallInsertRuleItemOption> IngressRules { get; set; }

        /// <summary>
        /// 功能说明：ACL添加出方向规则列表
        /// </summary>
        [JsonProperty("egress_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<FirewallInsertRuleItemOption> EgressRules { get; set; }

        /// <summary>
        /// 功能说明：插入ACL的规则在入方向或者出方向某条规则位置后，不指定则在入方向或者出方向规则列表最前面插入规则 约束：指定了insert_after_rule，ingress_rules和egress_rules只能同时设置一个，且该规则在入方向或者出方向规则中存在
        /// </summary>
        [JsonProperty("insert_after_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertAfterRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallInsertRuleOption {\n");
            sb.Append("  ingressRules: ").Append(IngressRules).Append("\n");
            sb.Append("  egressRules: ").Append(EgressRules).Append("\n");
            sb.Append("  insertAfterRule: ").Append(InsertAfterRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FirewallInsertRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FirewallInsertRuleOption input)
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
                ) && 
                (
                    this.InsertAfterRule == input.InsertAfterRule ||
                    (this.InsertAfterRule != null &&
                    this.InsertAfterRule.Equals(input.InsertAfterRule))
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
                if (this.InsertAfterRule != null)
                    hashCode = hashCode * 59 + this.InsertAfterRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
