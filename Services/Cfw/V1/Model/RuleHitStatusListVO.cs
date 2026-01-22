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
    public class RuleHitStatusListVO 
    {

        /// <summary>
        /// **参数解释**： 规则ID **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// **参数解释**： 规则命中次数 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("rule_hit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RuleHitCount { get; set; }

        /// <summary>
        /// **参数解释**： 命中时间 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("rule_last_hit_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RuleLastHitTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleHitStatusListVO {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleHitCount: ").Append(RuleHitCount).Append("\n");
            sb.Append("  ruleLastHitTime: ").Append(RuleLastHitTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleHitStatusListVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleHitStatusListVO input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleHitCount != input.RuleHitCount || (this.RuleHitCount != null && !this.RuleHitCount.Equals(input.RuleHitCount))) return false;
            if (this.RuleLastHitTime != input.RuleLastHitTime || (this.RuleLastHitTime != null && !this.RuleLastHitTime.Equals(input.RuleLastHitTime))) return false;

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
                if (this.RuleLastHitTime != null) hashCode = hashCode * 59 + this.RuleLastHitTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
