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
        /// 事件类型。 - SECRET_VERSION_CREATED:版本创建 - SECRET_VERSION_EXPIRED:版本过期 - SECRET_ROTATED:凭据轮转成功 - SECRET_DELETED:凭据删除 - SECRET_ROTATED_FAILED:凭据轮转失败
        /// </summary>
        /// <value>事件类型。 - SECRET_VERSION_CREATED:版本创建 - SECRET_VERSION_EXPIRED:版本过期 - SECRET_ROTATED:凭据轮转成功 - SECRET_DELETED:凭据删除 - SECRET_ROTATED_FAILED:凭据轮转失败</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerEventTypeEnum>))]
        public class TriggerEventTypeEnum
        {
            /// <summary>
            /// Enum SECRET_VERSION_CREATED for value: SECRET_VERSION_CREATED
            /// </summary>
            public static readonly TriggerEventTypeEnum SECRET_VERSION_CREATED = new TriggerEventTypeEnum("SECRET_VERSION_CREATED");

            /// <summary>
            /// Enum SECRET_VERSION_EXPIRED for value: SECRET_VERSION_EXPIRED
            /// </summary>
            public static readonly TriggerEventTypeEnum SECRET_VERSION_EXPIRED = new TriggerEventTypeEnum("SECRET_VERSION_EXPIRED");

            /// <summary>
            /// Enum SECRET_ROTATED for value: SECRET_ROTATED
            /// </summary>
            public static readonly TriggerEventTypeEnum SECRET_ROTATED = new TriggerEventTypeEnum("SECRET_ROTATED");

            /// <summary>
            /// Enum SECRET_DELETED for value: SECRET_DELETED
            /// </summary>
            public static readonly TriggerEventTypeEnum SECRET_DELETED = new TriggerEventTypeEnum("SECRET_DELETED");

            /// <summary>
            /// Enum SECRET_ROTATED_FAILED for value: SECRET_ROTATED_FAILED
            /// </summary>
            public static readonly TriggerEventTypeEnum SECRET_ROTATED_FAILED = new TriggerEventTypeEnum("SECRET_ROTATED_FAILED");

            private static readonly Dictionary<string, TriggerEventTypeEnum> StaticFields =
            new Dictionary<string, TriggerEventTypeEnum>()
            {
                { "SECRET_VERSION_CREATED", SECRET_VERSION_CREATED },
                { "SECRET_VERSION_EXPIRED", SECRET_VERSION_EXPIRED },
                { "SECRET_ROTATED", SECRET_ROTATED },
                { "SECRET_DELETED", SECRET_DELETED },
                { "SECRET_ROTATED_FAILED", SECRET_ROTATED_FAILED },
            };

            private string _value;

            public TriggerEventTypeEnum()
            {

            }

            public TriggerEventTypeEnum(string value)
            {
                _value = value;
            }

            public static TriggerEventTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerEventTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerEventTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerEventTypeEnum a, TriggerEventTypeEnum b)
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

            public static bool operator !=(TriggerEventTypeEnum a, TriggerEventTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 凭据类型  - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。 - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代） - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。 - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。
        /// </summary>
        /// <value>凭据类型  - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。 - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代） - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。 - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。</value>
        [JsonConverter(typeof(EnumClassConverter<SecretTypeEnum>))]
        public class SecretTypeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly SecretTypeEnum COMMON = new SecretTypeEnum("COMMON");

            /// <summary>
            /// Enum RDS_FG for value: RDS-FG
            /// </summary>
            public static readonly SecretTypeEnum RDS_FG = new SecretTypeEnum("RDS-FG");

            /// <summary>
            /// Enum GAUSSDB_FG for value: GaussDB-FG
            /// </summary>
            public static readonly SecretTypeEnum GAUSSDB_FG = new SecretTypeEnum("GaussDB-FG");

            private static readonly Dictionary<string, SecretTypeEnum> StaticFields =
            new Dictionary<string, SecretTypeEnum>()
            {
                { "COMMON", COMMON },
                { "RDS-FG", RDS_FG },
                { "GaussDB-FG", GAUSSDB_FG },
            };

            private string _value;

            public SecretTypeEnum()
            {

            }

            public SecretTypeEnum(string value)
            {
                _value = value;
            }

            public static SecretTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SecretTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SecretTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SecretTypeEnum a, SecretTypeEnum b)
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

            public static bool operator !=(SecretTypeEnum a, SecretTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 事件通知状态。  - SUCCESS：事件通知成功。 - FAIL：事件通知失败。 - INVALID：事件通知配置主题信息无效或不正确，无法触发通知。
        /// </summary>
        /// <value>事件通知状态。  - SUCCESS：事件通知成功。 - FAIL：事件通知失败。 - INVALID：事件通知配置主题信息无效或不正确，无法触发通知。</value>
        [JsonConverter(typeof(EnumClassConverter<NotificationStatusEnum>))]
        public class NotificationStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly NotificationStatusEnum SUCCESS = new NotificationStatusEnum("SUCCESS");

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly NotificationStatusEnum FAIL = new NotificationStatusEnum("FAIL");

            /// <summary>
            /// Enum INVALID for value: INVALID
            /// </summary>
            public static readonly NotificationStatusEnum INVALID = new NotificationStatusEnum("INVALID");

            private static readonly Dictionary<string, NotificationStatusEnum> StaticFields =
            new Dictionary<string, NotificationStatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAIL", FAIL },
                { "INVALID", INVALID },
            };

            private string _value;

            public NotificationStatusEnum()
            {

            }

            public NotificationStatusEnum(string value)
            {
                _value = value;
            }

            public static NotificationStatusEnum FromValue(string value)
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

                if (this.Equals(obj as NotificationStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotificationStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotificationStatusEnum a, NotificationStatusEnum b)
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

            public static bool operator !=(NotificationStatusEnum a, NotificationStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 凭据名称。
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 事件类型。 - SECRET_VERSION_CREATED:版本创建 - SECRET_VERSION_EXPIRED:版本过期 - SECRET_ROTATED:凭据轮转成功 - SECRET_DELETED:凭据删除 - SECRET_ROTATED_FAILED:凭据轮转失败
        /// </summary>
        [JsonProperty("trigger_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerEventTypeEnum TriggerEventType { get; set; }
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
        /// 凭据类型  - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。 - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代） - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。 - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public SecretTypeEnum SecretType { get; set; }
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
        /// 事件通知的内容。
        /// </summary>
        [JsonProperty("notification_content", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationContent { get; set; }

        /// <summary>
        /// 事件通知状态。  - SUCCESS：事件通知成功。 - FAIL：事件通知失败。 - INVALID：事件通知配置主题信息无效或不正确，无法触发通知。
        /// </summary>
        [JsonProperty("notification_status", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationStatusEnum NotificationStatus { get; set; }


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
            if (input == null) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.TriggerEventType != input.TriggerEventType) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;
            if (this.SecretType != input.SecretType) return false;
            if (this.NotificationTargetName != input.NotificationTargetName || (this.NotificationTargetName != null && !this.NotificationTargetName.Equals(input.NotificationTargetName))) return false;
            if (this.NotificationTargetId != input.NotificationTargetId || (this.NotificationTargetId != null && !this.NotificationTargetId.Equals(input.NotificationTargetId))) return false;
            if (this.NotificationContent != input.NotificationContent || (this.NotificationContent != null && !this.NotificationContent.Equals(input.NotificationContent))) return false;
            if (this.NotificationStatus != input.NotificationStatus) return false;

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
                if (this.EventName != null) hashCode = hashCode * 59 + this.EventName.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerEventType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.NotificationTargetName != null) hashCode = hashCode * 59 + this.NotificationTargetName.GetHashCode();
                if (this.NotificationTargetId != null) hashCode = hashCode * 59 + this.NotificationTargetId.GetHashCode();
                if (this.NotificationContent != null) hashCode = hashCode * 59 + this.NotificationContent.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
