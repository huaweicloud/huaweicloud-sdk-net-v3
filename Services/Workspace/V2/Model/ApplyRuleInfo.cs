using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 认证应用对象信息，为null时代表对所有应用对象生效。
    /// </summary>
    public class ApplyRuleInfo 
    {

        /// <summary>
        /// 认证应用对象类型。 - ACCESS_MODE：接入类型
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleType { get; set; }

        /// <summary>
        /// 认证应用对象。 - INTERNET：互联网接入，rule_type为ACCESS_MODE时可选该值 - PRIVATE：专线接入，rule_type为ACCESS_MODE时可选该值
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public string Rule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyRuleInfo {\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  rule: ").Append(Rule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyRuleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyRuleInfo input)
        {
            if (input == null) return false;
            if (this.RuleType != input.RuleType || (this.RuleType != null && !this.RuleType.Equals(input.RuleType))) return false;
            if (this.Rule != input.Rule || (this.Rule != null && !this.Rule.Equals(input.Rule))) return false;

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
                if (this.RuleType != null) hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.Rule != null) hashCode = hashCode * 59 + this.Rule.GetHashCode();
                return hashCode;
            }
        }
    }
}
