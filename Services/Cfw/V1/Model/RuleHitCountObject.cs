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
    /// 
    /// </summary>
    public class RuleHitCountObject 
    {

        /// <summary>
        /// **参数解释**： 规则ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// **参数解释**： 规则击中次数，当acl规则被触发时，对应规则ID的击中次数会添加一次。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("rule_hit_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleHitCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleHitCountObject {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleHitCount: ").Append(RuleHitCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleHitCountObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleHitCountObject input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleHitCount != input.RuleHitCount || (this.RuleHitCount != null && !this.RuleHitCount.Equals(input.RuleHitCount))) return false;

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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleHitCount != null) hashCode = hashCode * 59 + this.RuleHitCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
