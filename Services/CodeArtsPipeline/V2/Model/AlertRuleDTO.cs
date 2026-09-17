using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 告警规则DTO
    /// </summary>
    public class AlertRuleDTO 
    {

        /// <summary>
        /// **参数解释**： 规则类型。 **约束限制**： 不涉及。 **取值范围**： - CONCURRENCY：并发数。 - FAIL_COUNT：失败次数。 - QUEUE_BACKLOG：队列积压。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("ruleType", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleType { get; set; }

        /// <summary>
        /// **参数解释**： 阈值。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("thresholdValue", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThresholdValue { get; set; }

        /// <summary>
        /// **参数解释**： 严重级别。 **约束限制**： 不涉及。 **取值范围**： - GENERAL：一般。 - WARNING：警告。 - MAJOR：严重。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// **参数解释**： 是否启用。 **约束限制**： 不涉及。 **取值范围**： - true：启用。 - false：禁用。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("isEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertRuleDTO {\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  thresholdValue: ").Append(ThresholdValue).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  isEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertRuleDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlertRuleDTO input)
        {
            if (input == null) return false;
            if (this.RuleType != input.RuleType || (this.RuleType != null && !this.RuleType.Equals(input.RuleType))) return false;
            if (this.ThresholdValue != input.ThresholdValue || (this.ThresholdValue != null && !this.ThresholdValue.Equals(input.ThresholdValue))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.IsEnabled != input.IsEnabled || (this.IsEnabled != null && !this.IsEnabled.Equals(input.IsEnabled))) return false;

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
                if (this.ThresholdValue != null) hashCode = hashCode * 59 + this.ThresholdValue.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.IsEnabled != null) hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
