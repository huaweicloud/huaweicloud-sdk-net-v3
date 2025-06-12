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
    /// 直播使用互动规则配置信息
    /// </summary>
    public class LiveRoomInteractionRuleInfo 
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
        /// **参数解释**： 互动规则库ID。从互动库导入时携带互动库ID。 **约束限制**： 不涉及。 **取值范围**： 字符长度1-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 互动规则库名称。从互动库导入时携带互动库名称。 **约束限制**： 不涉及。 **取值范围**： 字符长度1-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**： 规则启用场景。启用部分场景时填写。如果不填写则适用所有场景。 **约束限制**： 不涉及。 **取值范围**： 对应直播间场景列表，最大100个场景，这边也对应100个。 条目填写场景名称，字符长度1-256。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("enabled_scenes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnabledScenes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveRoomInteractionRuleInfo {\n");
            sb.Append("  ruleIndex: ").Append(RuleIndex).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  hitCondition: ").Append(HitCondition).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  enabledScenes: ").Append(EnabledScenes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveRoomInteractionRuleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveRoomInteractionRuleInfo input)
        {
            if (input == null) return false;
            if (this.RuleIndex != input.RuleIndex || (this.RuleIndex != null && !this.RuleIndex.Equals(input.RuleIndex))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.HitCondition != input.HitCondition || (this.HitCondition != null && !this.HitCondition.Equals(input.HitCondition))) return false;
            if (this.Trigger != input.Trigger || (this.Trigger != null && !this.Trigger.Equals(input.Trigger))) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.EnabledScenes != input.EnabledScenes || (this.EnabledScenes != null && input.EnabledScenes != null && !this.EnabledScenes.SequenceEqual(input.EnabledScenes))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.EnabledScenes != null) hashCode = hashCode * 59 + this.EnabledScenes.GetHashCode();
                return hashCode;
            }
        }
    }
}
