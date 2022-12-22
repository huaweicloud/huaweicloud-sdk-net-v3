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
        /// 规则id列表
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
            if (input == null)
                return false;

            return 
                (
                    this.RuleIds == input.RuleIds ||
                    this.RuleIds != null &&
                    input.RuleIds != null &&
                    this.RuleIds.SequenceEqual(input.RuleIds)
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
                if (this.RuleIds != null)
                    hashCode = hashCode * 59 + this.RuleIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
