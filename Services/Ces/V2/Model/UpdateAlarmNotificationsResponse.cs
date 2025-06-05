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
    /// Response Object
    /// </summary>
    public class UpdateAlarmNotificationsResponse : SdkResponse
    {

        /// <summary>
        /// 是否开启告警通知。true:开启，false:关闭。
        /// </summary>
        [JsonProperty("notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotificationEnabled { get; set; }

        /// <summary>
        /// 告警触发的动作
        /// </summary>
        [JsonProperty("alarm_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> AlarmNotifications { get; set; }

        /// <summary>
        /// 告警恢复触发的动作
        /// </summary>
        [JsonProperty("ok_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> OkNotifications { get; set; }

        /// <summary>
        /// 告警通知开启时间
        /// </summary>
        [JsonProperty("notification_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationBeginTime { get; set; }

        /// <summary>
        /// 告警通知关闭时间
        /// </summary>
        [JsonProperty("notification_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAlarmNotificationsResponse {\n");
            sb.Append("  notificationEnabled: ").Append(NotificationEnabled).Append("\n");
            sb.Append("  alarmNotifications: ").Append(AlarmNotifications).Append("\n");
            sb.Append("  okNotifications: ").Append(OkNotifications).Append("\n");
            sb.Append("  notificationBeginTime: ").Append(NotificationBeginTime).Append("\n");
            sb.Append("  notificationEndTime: ").Append(NotificationEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAlarmNotificationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAlarmNotificationsResponse input)
        {
            if (input == null) return false;
            if (this.NotificationEnabled != input.NotificationEnabled || (this.NotificationEnabled != null && !this.NotificationEnabled.Equals(input.NotificationEnabled))) return false;
            if (this.AlarmNotifications != input.AlarmNotifications || (this.AlarmNotifications != null && input.AlarmNotifications != null && !this.AlarmNotifications.SequenceEqual(input.AlarmNotifications))) return false;
            if (this.OkNotifications != input.OkNotifications || (this.OkNotifications != null && input.OkNotifications != null && !this.OkNotifications.SequenceEqual(input.OkNotifications))) return false;
            if (this.NotificationBeginTime != input.NotificationBeginTime || (this.NotificationBeginTime != null && !this.NotificationBeginTime.Equals(input.NotificationBeginTime))) return false;
            if (this.NotificationEndTime != input.NotificationEndTime || (this.NotificationEndTime != null && !this.NotificationEndTime.Equals(input.NotificationEndTime))) return false;

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
                return hashCode;
            }
        }
    }
}
