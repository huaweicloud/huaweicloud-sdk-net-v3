using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 规则配置 **约束限制：** 不涉及
    /// </summary>
    public class UpdateRuleStatusRequest 
    {

        /// <summary>
        /// **参数解释：** 规则ID，可以通过查询规则引擎列表接口获取 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启规则 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 此条规则的优先级，数值越大，优先级越高 **约束限制：** 优先级不能相同 **取值范围：** 1-100 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRuleStatusRequest {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRuleStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRuleStatusRequest input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
