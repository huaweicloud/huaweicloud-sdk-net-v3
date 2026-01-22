using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// clear access log rule hit counts dto
    /// </summary>
    public class ClearAccessLogRuleHitCountsDto 
    {

        /// <summary>
        /// **参数解释**： 删除规则击中次数请求的规则列表，规则ID可通过[查询防护规则接口](ListAclRules.xml)查询获得，通过返回值中的data.records.rule_id（.表示各对象之间层级的区分）获得。 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("rule_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RuleIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClearAccessLogRuleHitCountsDto {\n");
            sb.Append("  ruleIds: ").Append(RuleIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClearAccessLogRuleHitCountsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClearAccessLogRuleHitCountsDto input)
        {
            if (input == null) return false;
            if (this.RuleIds != input.RuleIds || (this.RuleIds != null && input.RuleIds != null && !this.RuleIds.SequenceEqual(input.RuleIds))) return false;

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
                if (this.RuleIds != null) hashCode = hashCode * 59 + this.RuleIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
