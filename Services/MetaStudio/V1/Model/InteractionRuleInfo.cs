using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 互动规则配置信息
    /// </summary>
    public class InteractionRuleInfo 
    {

        /// <summary>
        /// **参数解释**： 规则索引。用于触发规则时索引具体规则。 **约束限制**： 无需用户填写。 **取值范围**： 字符0-64位 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("rule_index", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleIndex { get; set; }

        /// <summary>
        /// **参数解释**： 规则名称。 **约束限制**： 不涉及。 **取值范围**： 字符0-256位 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// **参数解释**： 是否启用。 **约束限制**： 不涉及。 **取值范围**： * true：启用 * fasle：不启用  **默认取值**： true
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释**： 规则匹配直播事件类型。接口的取值范围[0,100]，实际业务取值如下所示： * 1：弹幕事件  * 2：用户入场事件  * 3：用户点赞事件 * 4：用户送礼事件  * 10: 预置话术事件  请以实际业务取值为准。 &gt; * 1,2,3,4：与LiveEventReport中的event.type对应。 &gt; * 10：匹配预置剧本  **约束限制**： 不涉及。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hit_condition", NullValueHandling = NullValueHandling.Ignore)]
        public HitCondition HitCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerProcess Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_config", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewConfig ReviewConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractionRuleInfo {\n");
            sb.Append("  ruleIndex: ").Append(RuleIndex).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  hitCondition: ").Append(HitCondition).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InteractionRuleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InteractionRuleInfo input)
        {
            if (input == null) return false;
            if (this.RuleIndex != input.RuleIndex || (this.RuleIndex != null && !this.RuleIndex.Equals(input.RuleIndex))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.HitCondition != input.HitCondition || (this.HitCondition != null && !this.HitCondition.Equals(input.HitCondition))) return false;
            if (this.Trigger != input.Trigger || (this.Trigger != null && !this.Trigger.Equals(input.Trigger))) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;

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
                if (this.RuleIndex != null) hashCode = hashCode * 59 + this.RuleIndex.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.HitCondition != null) hashCode = hashCode * 59 + this.HitCondition.GetHashCode();
                if (this.Trigger != null) hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
