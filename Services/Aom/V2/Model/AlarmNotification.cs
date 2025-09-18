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
    /// 告警规则通知模块。
    /// </summary>
    public class AlarmNotification 
    {
        /// <summary>
        /// 通知类型。 - “direct”：直接告警 - “alarm_policy”：告警降噪
        /// </summary>
        /// <value>通知类型。 - “direct”：直接告警 - “alarm_policy”：告警降噪</value>
        [JsonConverter(typeof(EnumClassConverter<NotificationTypeEnum>))]
        public class NotificationTypeEnum
        {
            /// <summary>
            /// Enum DIRECT for value: direct
            /// </summary>
            public static readonly NotificationTypeEnum DIRECT = new NotificationTypeEnum("direct");

            /// <summary>
            /// Enum ALARM_POLICY for value: alarm_policy
            /// </summary>
            public static readonly NotificationTypeEnum ALARM_POLICY = new NotificationTypeEnum("alarm_policy");

            private static readonly Dictionary<string, NotificationTypeEnum> StaticFields =
            new Dictionary<string, NotificationTypeEnum>()
            {
                { "direct", DIRECT },
                { "alarm_policy", ALARM_POLICY },
            };

            private string _value;

            public NotificationTypeEnum()
            {

            }

            public NotificationTypeEnum(string value)
            {
                _value = value;
            }

            public static NotificationTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as NotificationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotificationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotificationTypeEnum a, NotificationTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(NotificationTypeEnum a, NotificationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 通知类型。 - “direct”：直接告警 - “alarm_policy”：告警降噪
        /// </summary>
        [JsonProperty("notification_type", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationTypeEnum NotificationType { get; set; }
        /// <summary>
        /// 启用分组规则。 - 当通知类型为“alarm_policy”时：true - 当通知类型为“direct”时：false
        /// </summary>
        [JsonProperty("route_group_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RouteGroupEnable { get; set; }

        /// <summary>
        /// 分组规则名称。 - 当route_group_enable 为true时，填分组规则名称 - 当route_group_enable 为false时，填“”
        /// </summary>
        [JsonProperty("route_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteGroupRule { get; set; }

        /// <summary>
        /// 是否启用告警行动规则。 - 当通知类型为“direct”时，填true - 当通知类型为“alarm_policy”时，填false
        /// </summary>
        [JsonProperty("notification_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotificationEnable { get; set; }

        /// <summary>
        /// 告警行动策略id。 - 当notification_enable为true时，填告警行动策略id - 当notification_enable为false时，填“”
        /// </summary>
        [JsonProperty("bind_notification_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BindNotificationRuleId { get; set; }

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
        /// 通知频率 - 当通知类型为“alarm_policy”时，填“-1” - 当通知类型为“direct”时，    - “0”：只告警一次    - “300”：每5分钟    - “600”：每10分钟    - “900”：每15分钟    - “1800”：每30分钟    - “3600”：每1小时    - “10800”：每3小时    - “21600”：每6小时    - “43200”：每12小时    - “86400”：每天
        /// </summary>
        [JsonProperty("notify_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotifyFrequency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmNotification {\n");
            sb.Append("  notificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  routeGroupEnable: ").Append(RouteGroupEnable).Append("\n");
            sb.Append("  routeGroupRule: ").Append(RouteGroupRule).Append("\n");
            sb.Append("  notificationEnable: ").Append(NotificationEnable).Append("\n");
            sb.Append("  bindNotificationRuleId: ").Append(BindNotificationRuleId).Append("\n");
            sb.Append("  notifyResolved: ").Append(NotifyResolved).Append("\n");
            sb.Append("  notifyTriggered: ").Append(NotifyTriggered).Append("\n");
            sb.Append("  notifyFrequency: ").Append(NotifyFrequency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmNotification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmNotification input)
        {
            if (input == null) return false;
            if (this.NotificationType != input.NotificationType) return false;
            if (this.RouteGroupEnable != input.RouteGroupEnable || (this.RouteGroupEnable != null && !this.RouteGroupEnable.Equals(input.RouteGroupEnable))) return false;
            if (this.RouteGroupRule != input.RouteGroupRule || (this.RouteGroupRule != null && !this.RouteGroupRule.Equals(input.RouteGroupRule))) return false;
            if (this.NotificationEnable != input.NotificationEnable || (this.NotificationEnable != null && !this.NotificationEnable.Equals(input.NotificationEnable))) return false;
            if (this.BindNotificationRuleId != input.BindNotificationRuleId || (this.BindNotificationRuleId != null && !this.BindNotificationRuleId.Equals(input.BindNotificationRuleId))) return false;
            if (this.NotifyResolved != input.NotifyResolved || (this.NotifyResolved != null && !this.NotifyResolved.Equals(input.NotifyResolved))) return false;
            if (this.NotifyTriggered != input.NotifyTriggered || (this.NotifyTriggered != null && !this.NotifyTriggered.Equals(input.NotifyTriggered))) return false;
            if (this.NotifyFrequency != input.NotifyFrequency || (this.NotifyFrequency != null && !this.NotifyFrequency.Equals(input.NotifyFrequency))) return false;

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
                hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                if (this.RouteGroupEnable != null) hashCode = hashCode * 59 + this.RouteGroupEnable.GetHashCode();
                if (this.RouteGroupRule != null) hashCode = hashCode * 59 + this.RouteGroupRule.GetHashCode();
                if (this.NotificationEnable != null) hashCode = hashCode * 59 + this.NotificationEnable.GetHashCode();
                if (this.BindNotificationRuleId != null) hashCode = hashCode * 59 + this.BindNotificationRuleId.GetHashCode();
                if (this.NotifyResolved != null) hashCode = hashCode * 59 + this.NotifyResolved.GetHashCode();
                if (this.NotifyTriggered != null) hashCode = hashCode * 59 + this.NotifyTriggered.GetHashCode();
                if (this.NotifyFrequency != null) hashCode = hashCode * 59 + this.NotifyFrequency.GetHashCode();
                return hashCode;
            }
        }
    }
}
