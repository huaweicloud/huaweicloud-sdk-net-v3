using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 事件通知记录。
    /// </summary>
    public class Record 
    {

        /// <summary>
        /// 凭据名称。
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 凭据类型  取值 ： COMMON ：通用凭据 RDS ：RDS凭据 
        /// </summary>
        [JsonProperty("trigger_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerEventType { get; set; }

        /// <summary>
        /// 事件通知记录的创建时间，时间戳，即从1970年1月1日至该时间的总秒数。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 凭据名称。
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// 凭据类型  取值 ： COMMON ：通用凭据(默认)。用于应用系统中的各种敏感信息储存。         RDS ：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。 
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretType { get; set; }

        /// <summary>
        /// 事件通知的对象名称。
        /// </summary>
        [JsonProperty("notification_target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationTargetName { get; set; }

        /// <summary>
        /// 事件通知的对象ID。
        /// </summary>
        [JsonProperty("notification_target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationTargetId { get; set; }

        /// <summary>
        /// 凭据的描述信息。
        /// </summary>
        [JsonProperty("notification_content", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationContent { get; set; }

        /// <summary>
        /// 凭据类型  取值 ： SUCCESS ：事件通知成功。         FAIL ：事件通知失败。         INVALID ：事件通知配置主题信息无效或不正确，无法触发通知。 
        /// </summary>
        [JsonProperty("notification_status", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Record {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  triggerEventType: ").Append(TriggerEventType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  notificationTargetName: ").Append(NotificationTargetName).Append("\n");
            sb.Append("  notificationTargetId: ").Append(NotificationTargetId).Append("\n");
            sb.Append("  notificationContent: ").Append(NotificationContent).Append("\n");
            sb.Append("  notificationStatus: ").Append(NotificationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Record);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Record input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.TriggerEventType == input.TriggerEventType ||
                    (this.TriggerEventType != null &&
                    this.TriggerEventType.Equals(input.TriggerEventType))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.SecretName == input.SecretName ||
                    (this.SecretName != null &&
                    this.SecretName.Equals(input.SecretName))
                ) && 
                (
                    this.SecretType == input.SecretType ||
                    (this.SecretType != null &&
                    this.SecretType.Equals(input.SecretType))
                ) && 
                (
                    this.NotificationTargetName == input.NotificationTargetName ||
                    (this.NotificationTargetName != null &&
                    this.NotificationTargetName.Equals(input.NotificationTargetName))
                ) && 
                (
                    this.NotificationTargetId == input.NotificationTargetId ||
                    (this.NotificationTargetId != null &&
                    this.NotificationTargetId.Equals(input.NotificationTargetId))
                ) && 
                (
                    this.NotificationContent == input.NotificationContent ||
                    (this.NotificationContent != null &&
                    this.NotificationContent.Equals(input.NotificationContent))
                ) && 
                (
                    this.NotificationStatus == input.NotificationStatus ||
                    (this.NotificationStatus != null &&
                    this.NotificationStatus.Equals(input.NotificationStatus))
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
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.TriggerEventType != null)
                    hashCode = hashCode * 59 + this.TriggerEventType.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.SecretName != null)
                    hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.SecretType != null)
                    hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.NotificationTargetName != null)
                    hashCode = hashCode * 59 + this.NotificationTargetName.GetHashCode();
                if (this.NotificationTargetId != null)
                    hashCode = hashCode * 59 + this.NotificationTargetId.GetHashCode();
                if (this.NotificationContent != null)
                    hashCode = hashCode * 59 + this.NotificationContent.GetHashCode();
                if (this.NotificationStatus != null)
                    hashCode = hashCode * 59 + this.NotificationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
