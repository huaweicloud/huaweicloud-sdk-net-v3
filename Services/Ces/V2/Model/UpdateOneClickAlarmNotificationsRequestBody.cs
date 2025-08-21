using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateOneClickAlarmNotificationsRequestBody 
    {
        /// <summary>
        /// NOTIFICATION_GROUP(通知组)/TOPIC_SUBSCRIPTION(主题订阅)/NOTIFICATION_POLICY(通知策略)
        /// </summary>
        /// <value>NOTIFICATION_GROUP(通知组)/TOPIC_SUBSCRIPTION(主题订阅)/NOTIFICATION_POLICY(通知策略)</value>
        [JsonConverter(typeof(EnumClassConverter<NotificationMannerEnum>))]
        public class NotificationMannerEnum
        {
            /// <summary>
            /// Enum NOTIFICATION_GROUP for value: NOTIFICATION_GROUP
            /// </summary>
            public static readonly NotificationMannerEnum NOTIFICATION_GROUP = new NotificationMannerEnum("NOTIFICATION_GROUP");

            /// <summary>
            /// Enum TOPIC_SUBSCRIPTION for value: TOPIC_SUBSCRIPTION
            /// </summary>
            public static readonly NotificationMannerEnum TOPIC_SUBSCRIPTION = new NotificationMannerEnum("TOPIC_SUBSCRIPTION");

            /// <summary>
            /// Enum NOTIFICATION_POLICY for value: NOTIFICATION_POLICY
            /// </summary>
            public static readonly NotificationMannerEnum NOTIFICATION_POLICY = new NotificationMannerEnum("NOTIFICATION_POLICY");

            private static readonly Dictionary<string, NotificationMannerEnum> StaticFields =
            new Dictionary<string, NotificationMannerEnum>()
            {
                { "NOTIFICATION_GROUP", NOTIFICATION_GROUP },
                { "TOPIC_SUBSCRIPTION", TOPIC_SUBSCRIPTION },
                { "NOTIFICATION_POLICY", NOTIFICATION_POLICY },
            };

            private string _value;

            public NotificationMannerEnum()
            {

            }

            public NotificationMannerEnum(string value)
            {
                _value = value;
            }

            public static NotificationMannerEnum FromValue(string value)
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

                if (this.Equals(obj as NotificationMannerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotificationMannerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotificationMannerEnum a, NotificationMannerEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(NotificationMannerEnum a, NotificationMannerEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 是否开启告警通知。 **约束限制**： 值为true时，其他必选字段均需填，值为false时，其他所有字段不可选。 **取值范围**： - true：开启告警通知。 - false：不开启告警通知。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotificationEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 触发告警时，通知组/主题订阅的信息。 **约束限制**： 不涉及。 **取值范围**： 告警触发的动作数量最多为10个。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("alarm_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> AlarmNotifications { get; set; }

        /// <summary>
        /// **参数解释**： 告警恢复时，通知组/主题订阅的信息。 **约束限制**： 不涉及。 **取值范围**： 告警恢复触发的动作数量最多为10个。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("ok_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> OkNotifications { get; set; }

        /// <summary>
        /// **参数解释**： 每天告警通知的开始时间。 **约束限制**： 不涉及。 **取值范围**： 长度为[1,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("notification_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationBeginTime { get; set; }

        /// <summary>
        /// **参数解释**： 每天告警通知的结束时间。 **约束限制**： 不涉及。 **取值范围**： 长度为[1,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("notification_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationEndTime { get; set; }

        /// <summary>
        /// 时区，形如：\&quot;GMT-08:00\&quot;、\&quot;GMT+08:00\&quot;、\&quot;GMT+0:00\&quot;
        /// </summary>
        [JsonProperty("effective_timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimezone { get; set; }

        /// <summary>
        /// NOTIFICATION_GROUP(通知组)/TOPIC_SUBSCRIPTION(主题订阅)/NOTIFICATION_POLICY(通知策略)
        /// </summary>
        [JsonProperty("notification_manner", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationMannerEnum NotificationManner { get; set; }
        /// <summary>
        /// 关联的通知策略ID列表
        /// </summary>
        [JsonProperty("notification_policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationPolicyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOneClickAlarmNotificationsRequestBody {\n");
            sb.Append("  notificationEnabled: ").Append(NotificationEnabled).Append("\n");
            sb.Append("  alarmNotifications: ").Append(AlarmNotifications).Append("\n");
            sb.Append("  okNotifications: ").Append(OkNotifications).Append("\n");
            sb.Append("  notificationBeginTime: ").Append(NotificationBeginTime).Append("\n");
            sb.Append("  notificationEndTime: ").Append(NotificationEndTime).Append("\n");
            sb.Append("  effectiveTimezone: ").Append(EffectiveTimezone).Append("\n");
            sb.Append("  notificationManner: ").Append(NotificationManner).Append("\n");
            sb.Append("  notificationPolicyIds: ").Append(NotificationPolicyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOneClickAlarmNotificationsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateOneClickAlarmNotificationsRequestBody input)
        {
            if (input == null) return false;
            if (this.NotificationEnabled != input.NotificationEnabled || (this.NotificationEnabled != null && !this.NotificationEnabled.Equals(input.NotificationEnabled))) return false;
            if (this.AlarmNotifications != input.AlarmNotifications || (this.AlarmNotifications != null && input.AlarmNotifications != null && !this.AlarmNotifications.SequenceEqual(input.AlarmNotifications))) return false;
            if (this.OkNotifications != input.OkNotifications || (this.OkNotifications != null && input.OkNotifications != null && !this.OkNotifications.SequenceEqual(input.OkNotifications))) return false;
            if (this.NotificationBeginTime != input.NotificationBeginTime || (this.NotificationBeginTime != null && !this.NotificationBeginTime.Equals(input.NotificationBeginTime))) return false;
            if (this.NotificationEndTime != input.NotificationEndTime || (this.NotificationEndTime != null && !this.NotificationEndTime.Equals(input.NotificationEndTime))) return false;
            if (this.EffectiveTimezone != input.EffectiveTimezone || (this.EffectiveTimezone != null && !this.EffectiveTimezone.Equals(input.EffectiveTimezone))) return false;
            if (this.NotificationManner != input.NotificationManner) return false;
            if (this.NotificationPolicyIds != input.NotificationPolicyIds || (this.NotificationPolicyIds != null && input.NotificationPolicyIds != null && !this.NotificationPolicyIds.SequenceEqual(input.NotificationPolicyIds))) return false;

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
                if (this.NotificationEnabled != null) hashCode = hashCode * 59 + this.NotificationEnabled.GetHashCode();
                if (this.AlarmNotifications != null) hashCode = hashCode * 59 + this.AlarmNotifications.GetHashCode();
                if (this.OkNotifications != null) hashCode = hashCode * 59 + this.OkNotifications.GetHashCode();
                if (this.NotificationBeginTime != null) hashCode = hashCode * 59 + this.NotificationBeginTime.GetHashCode();
                if (this.NotificationEndTime != null) hashCode = hashCode * 59 + this.NotificationEndTime.GetHashCode();
                if (this.EffectiveTimezone != null) hashCode = hashCode * 59 + this.EffectiveTimezone.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationManner.GetHashCode();
                if (this.NotificationPolicyIds != null) hashCode = hashCode * 59 + this.NotificationPolicyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
