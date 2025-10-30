using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Annotations 
    {

        /// <summary>
        /// 告警列表详情
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 日志组/流id,名称
        /// </summary>
        [JsonProperty("log_info", NullValueHandling = NullValueHandling.Ignore)]
        public string LogInfo { get; set; }

        /// <summary>
        /// 当前值
        /// </summary>
        [JsonProperty("current_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentValue { get; set; }

        /// <summary>
        /// (sql/关键词)告警详情原始数据
        /// </summary>
        [JsonProperty("old_annotations", NullValueHandling = NullValueHandling.Ignore)]
        public string OldAnnotations { get; set; }

        /// <summary>
        /// **参数解释：** 告警行动规则名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("alarm_action_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmActionRuleName { get; set; }

        /// <summary>
        /// **参数解释：** 告警规则别名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("alarm_rule_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleAlias { get; set; }

        /// <summary>
        /// **参数解释：** 告警规则url。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("alarm_rule_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleUrl { get; set; }

        /// <summary>
        /// **参数解释：** 告警触发状态。 **取值范围：** - 触发(firing) - 恢复(resolved)
        /// </summary>
        [JsonProperty("alarm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStatus { get; set; }

        /// <summary>
        /// **参数解释：** 告警触发条件表达式。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("condition_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionExpression { get; set; }

        /// <summary>
        /// **参数解释：** 告警触发表达式带值。例如：条件表达式为pv &gt; 0，则condition_expression_with_value取值为：100 &gt; 0。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("condition_expression_with_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionExpressionWithValue { get; set; }

        /// <summary>
        /// **参数解释：** 通知频率。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("notification_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationFrequency { get; set; }

        /// <summary>
        /// **参数解释：** 告警ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启告警恢复开关。 **取值范围：** - true： 开启告警恢复 - false： 关闭告警恢复
        /// </summary>
        [JsonProperty("recovery_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecoveryPolicy { get; set; }

        /// <summary>
        /// **参数解释：** 告警通知的详细信息。
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Results> Results { get; set; }

        /// <summary>
        /// **参数解释：** 告警统计周期。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string Frequency { get; set; }

        /// <summary>
        /// **参数解释：** 告警规则类型。 **取值范围：** - sql： sql告警 - keywords： 关键词告警
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Annotations {\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  logInfo: ").Append(LogInfo).Append("\n");
            sb.Append("  currentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  oldAnnotations: ").Append(OldAnnotations).Append("\n");
            sb.Append("  alarmActionRuleName: ").Append(AlarmActionRuleName).Append("\n");
            sb.Append("  alarmRuleAlias: ").Append(AlarmRuleAlias).Append("\n");
            sb.Append("  alarmRuleUrl: ").Append(AlarmRuleUrl).Append("\n");
            sb.Append("  alarmStatus: ").Append(AlarmStatus).Append("\n");
            sb.Append("  conditionExpression: ").Append(ConditionExpression).Append("\n");
            sb.Append("  conditionExpressionWithValue: ").Append(ConditionExpressionWithValue).Append("\n");
            sb.Append("  notificationFrequency: ").Append(NotificationFrequency).Append("\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  recoveryPolicy: ").Append(RecoveryPolicy).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Annotations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Annotations input)
        {
            if (input == null) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.LogInfo != input.LogInfo || (this.LogInfo != null && !this.LogInfo.Equals(input.LogInfo))) return false;
            if (this.CurrentValue != input.CurrentValue || (this.CurrentValue != null && !this.CurrentValue.Equals(input.CurrentValue))) return false;
            if (this.OldAnnotations != input.OldAnnotations || (this.OldAnnotations != null && !this.OldAnnotations.Equals(input.OldAnnotations))) return false;
            if (this.AlarmActionRuleName != input.AlarmActionRuleName || (this.AlarmActionRuleName != null && !this.AlarmActionRuleName.Equals(input.AlarmActionRuleName))) return false;
            if (this.AlarmRuleAlias != input.AlarmRuleAlias || (this.AlarmRuleAlias != null && !this.AlarmRuleAlias.Equals(input.AlarmRuleAlias))) return false;
            if (this.AlarmRuleUrl != input.AlarmRuleUrl || (this.AlarmRuleUrl != null && !this.AlarmRuleUrl.Equals(input.AlarmRuleUrl))) return false;
            if (this.AlarmStatus != input.AlarmStatus || (this.AlarmStatus != null && !this.AlarmStatus.Equals(input.AlarmStatus))) return false;
            if (this.ConditionExpression != input.ConditionExpression || (this.ConditionExpression != null && !this.ConditionExpression.Equals(input.ConditionExpression))) return false;
            if (this.ConditionExpressionWithValue != input.ConditionExpressionWithValue || (this.ConditionExpressionWithValue != null && !this.ConditionExpressionWithValue.Equals(input.ConditionExpressionWithValue))) return false;
            if (this.NotificationFrequency != input.NotificationFrequency || (this.NotificationFrequency != null && !this.NotificationFrequency.Equals(input.NotificationFrequency))) return false;
            if (this.RecordId != input.RecordId || (this.RecordId != null && !this.RecordId.Equals(input.RecordId))) return false;
            if (this.RecoveryPolicy != input.RecoveryPolicy || (this.RecoveryPolicy != null && !this.RecoveryPolicy.Equals(input.RecoveryPolicy))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.LogInfo != null) hashCode = hashCode * 59 + this.LogInfo.GetHashCode();
                if (this.CurrentValue != null) hashCode = hashCode * 59 + this.CurrentValue.GetHashCode();
                if (this.OldAnnotations != null) hashCode = hashCode * 59 + this.OldAnnotations.GetHashCode();
                if (this.AlarmActionRuleName != null) hashCode = hashCode * 59 + this.AlarmActionRuleName.GetHashCode();
                if (this.AlarmRuleAlias != null) hashCode = hashCode * 59 + this.AlarmRuleAlias.GetHashCode();
                if (this.AlarmRuleUrl != null) hashCode = hashCode * 59 + this.AlarmRuleUrl.GetHashCode();
                if (this.AlarmStatus != null) hashCode = hashCode * 59 + this.AlarmStatus.GetHashCode();
                if (this.ConditionExpression != null) hashCode = hashCode * 59 + this.ConditionExpression.GetHashCode();
                if (this.ConditionExpressionWithValue != null) hashCode = hashCode * 59 + this.ConditionExpressionWithValue.GetHashCode();
                if (this.NotificationFrequency != null) hashCode = hashCode * 59 + this.NotificationFrequency.GetHashCode();
                if (this.RecordId != null) hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.RecoveryPolicy != null) hashCode = hashCode * 59 + this.RecoveryPolicy.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
