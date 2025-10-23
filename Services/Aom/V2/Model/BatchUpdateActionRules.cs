using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchUpdateActionRules 
    {

        /// <summary>
        /// 告警规则id。
        /// </summary>
        [JsonProperty("alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmRuleId { get; set; }

        /// <summary>
        /// 告警规则名称。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }

        /// <summary>
        /// 告警规则类型。
        /// </summary>
        [JsonProperty("alarm_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleType { get; set; }

        /// <summary>
        /// 待绑定的告警行动规则名称。
        /// </summary>
        [JsonProperty("bind_notification_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BindNotificationRuleId { get; set; }

        /// <summary>
        /// 通知频率 - 当通知类型为“alarm_policy”时，填“-1” - 当通知类型为“direct”时，    - “0”：只告警一次    - “300”：每5分钟    - “600”：每10分钟    - “900”：每15分钟    - “1800”：每30分钟    - “3600”：每1小时    - “10800”：每3小时    - “21600”：每6小时    - “43200”：每12小时    - “86400”：每天
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string Frequency { get; set; }

        /// <summary>
        /// 是否启用告警通知规则。 - 当通知类型为“direct”时，填true - 当通知类型为“alarm_policy”时，填false 如果告警触发“notify_triggered”或告警恢复“notify_resolved”都设置为false（即都不进行告警通知），则notification_enable需设置为false。
        /// </summary>
        [JsonProperty("notification_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotificationEnable { get; set; }

        /// <summary>
        /// 通知类型。 - “direct”：直接告警 - “alarm_policy”：告警降噪
        /// </summary>
        [JsonProperty("notification_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationType { get; set; }

        /// <summary>
        /// 告警解决是否通知。 - true：通知 - false：不通知
        /// </summary>
        [JsonProperty("notify_resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyResolved { get; set; }

        /// <summary>
        /// 告警触发是否通知。 - true：通知 - false：不通知
        /// </summary>
        [JsonProperty("notify_triggered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyTriggered { get; set; }

        /// <summary>
        /// 启用告警分组规则。 - 当通知类型为“alarm_policy”时：true - 当通知类型为“direct”时：false 如果告警触发“notify_triggered”或告警恢复“notify_resolved”都设置为false（即都不进行告警通知），则route_group_enable需设置为false。
        /// </summary>
        [JsonProperty("route_group_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RouteGroupEnable { get; set; }

        /// <summary>
        /// 告警分组规则名称。 - 当route_group_enable 为true时，填告警分组规则名称 - 当route_group_enable 为false时，填“”
        /// </summary>
        [JsonProperty("route_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteGroupRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateActionRules {\n");
            sb.Append("  alarmRuleId: ").Append(AlarmRuleId).Append("\n");
            sb.Append("  alarmRuleName: ").Append(AlarmRuleName).Append("\n");
            sb.Append("  alarmRuleType: ").Append(AlarmRuleType).Append("\n");
            sb.Append("  bindNotificationRuleId: ").Append(BindNotificationRuleId).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  notificationEnable: ").Append(NotificationEnable).Append("\n");
            sb.Append("  notificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  notifyResolved: ").Append(NotifyResolved).Append("\n");
            sb.Append("  notifyTriggered: ").Append(NotifyTriggered).Append("\n");
            sb.Append("  routeGroupEnable: ").Append(RouteGroupEnable).Append("\n");
            sb.Append("  routeGroupRule: ").Append(RouteGroupRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateActionRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateActionRules input)
        {
            if (input == null) return false;
            if (this.AlarmRuleId != input.AlarmRuleId || (this.AlarmRuleId != null && !this.AlarmRuleId.Equals(input.AlarmRuleId))) return false;
            if (this.AlarmRuleName != input.AlarmRuleName || (this.AlarmRuleName != null && !this.AlarmRuleName.Equals(input.AlarmRuleName))) return false;
            if (this.AlarmRuleType != input.AlarmRuleType || (this.AlarmRuleType != null && !this.AlarmRuleType.Equals(input.AlarmRuleType))) return false;
            if (this.BindNotificationRuleId != input.BindNotificationRuleId || (this.BindNotificationRuleId != null && !this.BindNotificationRuleId.Equals(input.BindNotificationRuleId))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;
            if (this.NotificationEnable != input.NotificationEnable || (this.NotificationEnable != null && !this.NotificationEnable.Equals(input.NotificationEnable))) return false;
            if (this.NotificationType != input.NotificationType || (this.NotificationType != null && !this.NotificationType.Equals(input.NotificationType))) return false;
            if (this.NotifyResolved != input.NotifyResolved || (this.NotifyResolved != null && !this.NotifyResolved.Equals(input.NotifyResolved))) return false;
            if (this.NotifyTriggered != input.NotifyTriggered || (this.NotifyTriggered != null && !this.NotifyTriggered.Equals(input.NotifyTriggered))) return false;
            if (this.RouteGroupEnable != input.RouteGroupEnable || (this.RouteGroupEnable != null && !this.RouteGroupEnable.Equals(input.RouteGroupEnable))) return false;
            if (this.RouteGroupRule != input.RouteGroupRule || (this.RouteGroupRule != null && !this.RouteGroupRule.Equals(input.RouteGroupRule))) return false;

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
                if (this.AlarmRuleId != null) hashCode = hashCode * 59 + this.AlarmRuleId.GetHashCode();
                if (this.AlarmRuleName != null) hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                if (this.AlarmRuleType != null) hashCode = hashCode * 59 + this.AlarmRuleType.GetHashCode();
                if (this.BindNotificationRuleId != null) hashCode = hashCode * 59 + this.BindNotificationRuleId.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.NotificationEnable != null) hashCode = hashCode * 59 + this.NotificationEnable.GetHashCode();
                if (this.NotificationType != null) hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                if (this.NotifyResolved != null) hashCode = hashCode * 59 + this.NotifyResolved.GetHashCode();
                if (this.NotifyTriggered != null) hashCode = hashCode * 59 + this.NotifyTriggered.GetHashCode();
                if (this.RouteGroupEnable != null) hashCode = hashCode * 59 + this.RouteGroupEnable.GetHashCode();
                if (this.RouteGroupRule != null) hashCode = hashCode * 59 + this.RouteGroupRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
