using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateNotificationResponse : SdkResponse
    {
        /// <summary>
        /// 操作类型，完整和自定义。
        /// </summary>
        /// <value>操作类型，完整和自定义。</value>
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum CUSTOMIZED for value: customized
            /// </summary>
            public static readonly OperationTypeEnum CUSTOMIZED = new OperationTypeEnum("customized");

            /// <summary>
            /// Enum COMPLETE for value: complete
            /// </summary>
            public static readonly OperationTypeEnum COMPLETE = new OperationTypeEnum("complete");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "customized", CUSTOMIZED },
                { "complete", COMPLETE },
            };

            private string _value;

            public OperationTypeEnum()
            {

            }

            public OperationTypeEnum(string value)
            {
                _value = value;
            }

            public static OperationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
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

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云服务委托名称。
        /// </summary>
        /// <value>云服务委托名称。</value>
        [JsonConverter(typeof(EnumClassConverter<AgencyNameEnum>))]
        public class AgencyNameEnum
        {
            /// <summary>
            /// Enum CTS_ADMIN_TRUST for value: cts_admin_trust
            /// </summary>
            public static readonly AgencyNameEnum CTS_ADMIN_TRUST = new AgencyNameEnum("cts_admin_trust");

            private static readonly Dictionary<string, AgencyNameEnum> StaticFields =
            new Dictionary<string, AgencyNameEnum>()
            {
                { "cts_admin_trust", CTS_ADMIN_TRUST },
            };

            private string _value;

            public AgencyNameEnum()
            {

            }

            public AgencyNameEnum(string value)
            {
                _value = value;
            }

            public static AgencyNameEnum FromValue(string value)
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

                if (this.Equals(obj as AgencyNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AgencyNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AgencyNameEnum a, AgencyNameEnum b)
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

            public static bool operator !=(AgencyNameEnum a, AgencyNameEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 通知状态，启用和停用。
        /// </summary>
        /// <value>通知状态，启用和停用。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: enabled
            /// </summary>
            public static readonly StatusEnum ENABLED = new StatusEnum("enabled");

            /// <summary>
            /// Enum DISABLED for value: disabled
            /// </summary>
            public static readonly StatusEnum DISABLED = new StatusEnum("disabled");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "enabled", ENABLED },
                { "disabled", DISABLED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 通知类型，消息通知，函数触发器。
        /// </summary>
        /// <value>通知类型，消息通知，函数触发器。</value>
        [JsonConverter(typeof(EnumClassConverter<NotificationTypeEnum>))]
        public class NotificationTypeEnum
        {
            /// <summary>
            /// Enum SMN for value: smn
            /// </summary>
            public static readonly NotificationTypeEnum SMN = new NotificationTypeEnum("smn");

            /// <summary>
            /// Enum FUN for value: fun
            /// </summary>
            public static readonly NotificationTypeEnum FUN = new NotificationTypeEnum("fun");

            private static readonly Dictionary<string, NotificationTypeEnum> StaticFields =
            new Dictionary<string, NotificationTypeEnum>()
            {
                { "smn", SMN },
                { "fun", FUN },
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

            public static bool operator !=(NotificationTypeEnum a, NotificationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 通知名称。
        /// </summary>
        [JsonProperty("notification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationName { get; set; }

        /// <summary>
        /// 操作类型，完整和自定义。
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 操作事件列表。
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Operations> Operations { get; set; }

        /// <summary>
        /// 通知用户列表，目前最多支持对10个用户组和50个用户发起的操作进行配置。
        /// </summary>
        [JsonProperty("notify_user_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotificationUsers> NotifyUserList { get; set; }

        /// <summary>
        /// 云服务委托名称。
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public AgencyNameEnum AgencyName { get; set; }
        /// <summary>
        /// 通知状态，启用和停用。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 消息通知服务(SMN)主题的唯一的资源标识，可通过查询主题列表获取该标识。
        /// </summary>
        [JsonProperty("topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicId { get; set; }

        /// <summary>
        /// 通知的唯一标识ID。
        /// </summary>
        [JsonProperty("notification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationId { get; set; }

        /// <summary>
        /// 通知类型，消息通知，函数触发器。
        /// </summary>
        [JsonProperty("notification_type", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationTypeEnum NotificationType { get; set; }
        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 通知规则创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNotificationResponse {\n");
            sb.Append("  notificationName: ").Append(NotificationName).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("  notifyUserList: ").Append(NotifyUserList).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  topicId: ").Append(TopicId).Append("\n");
            sb.Append("  notificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  notificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNotificationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNotificationResponse input)
        {
            if (input == null) return false;
            if (this.NotificationName != input.NotificationName || (this.NotificationName != null && !this.NotificationName.Equals(input.NotificationName))) return false;
            if (this.OperationType != input.OperationType) return false;
            if (this.Operations != input.Operations || (this.Operations != null && input.Operations != null && !this.Operations.SequenceEqual(input.Operations))) return false;
            if (this.NotifyUserList != input.NotifyUserList || (this.NotifyUserList != null && input.NotifyUserList != null && !this.NotifyUserList.SequenceEqual(input.NotifyUserList))) return false;
            if (this.AgencyName != input.AgencyName) return false;
            if (this.Status != input.Status) return false;
            if (this.TopicId != input.TopicId || (this.TopicId != null && !this.TopicId.Equals(input.TopicId))) return false;
            if (this.NotificationId != input.NotificationId || (this.NotificationId != null && !this.NotificationId.Equals(input.NotificationId))) return false;
            if (this.NotificationType != input.NotificationType) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;

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
                if (this.NotificationName != null) hashCode = hashCode * 59 + this.NotificationName.GetHashCode();
                hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.Operations != null) hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.NotifyUserList != null) hashCode = hashCode * 59 + this.NotifyUserList.GetHashCode();
                hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TopicId != null) hashCode = hashCode * 59 + this.TopicId.GetHashCode();
                if (this.NotificationId != null) hashCode = hashCode * 59 + this.NotificationId.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }
    }
}
