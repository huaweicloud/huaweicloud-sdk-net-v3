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
    public class EnableOneClickAlarmRequestBodyOneClickUpdateAlarms 
    {
        /// <summary>
        /// **参数解释**： 此字段已废弃。告警规则类型 **约束限制**： 不涉及。 **取值范围**： 枚举值。 - ALL_INSTANCE：全部资源指标告警。 - RESOURCE_GROUP：资源分组指标告警。 - MULTI_INSTANCE：指定资源指标告警。 - EVENT.SYS：系统事件告警。 - EVENT.CUSTOM：自定义事件告警。 - DNSHealthCheck：健康检查告警。 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 此字段已废弃。告警规则类型 **约束限制**： 不涉及。 **取值范围**： 枚举值。 - ALL_INSTANCE：全部资源指标告警。 - RESOURCE_GROUP：资源分组指标告警。 - MULTI_INSTANCE：指定资源指标告警。 - EVENT.SYS：系统事件告警。 - EVENT.CUSTOM：自定义事件告警。 - DNSHealthCheck：健康检查告警。 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum EVENT_SYS for value: EVENT.SYS
            /// </summary>
            public static readonly TypeEnum EVENT_SYS = new TypeEnum("EVENT.SYS");

            /// <summary>
            /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
            /// </summary>
            public static readonly TypeEnum EVENT_CUSTOM = new TypeEnum("EVENT.CUSTOM");

            /// <summary>
            /// Enum DNSHEALTHCHECK for value: DNSHealthCheck
            /// </summary>
            public static readonly TypeEnum DNSHEALTHCHECK = new TypeEnum("DNSHealthCheck");

            /// <summary>
            /// Enum RESOURCE_GROUP for value: RESOURCE_GROUP
            /// </summary>
            public static readonly TypeEnum RESOURCE_GROUP = new TypeEnum("RESOURCE_GROUP");

            /// <summary>
            /// Enum MULTI_INSTANCE for value: MULTI_INSTANCE
            /// </summary>
            public static readonly TypeEnum MULTI_INSTANCE = new TypeEnum("MULTI_INSTANCE");

            /// <summary>
            /// Enum ALL_INSTANCE for value: ALL_INSTANCE
            /// </summary>
            public static readonly TypeEnum ALL_INSTANCE = new TypeEnum("ALL_INSTANCE");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EVENT.SYS", EVENT_SYS },
                { "EVENT.CUSTOM", EVENT_CUSTOM },
                { "DNSHealthCheck", DNSHEALTHCHECK },
                { "RESOURCE_GROUP", RESOURCE_GROUP },
                { "MULTI_INSTANCE", MULTI_INSTANCE },
                { "ALL_INSTANCE", ALL_INSTANCE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 此字段已废弃。通知方式。NOTIFICATION_POLICY表示通知策略，NOTIFICATION_GROUP表示通知组，TOPIC_SUBSCRIPTION表示主题订阅。一键告警是否开启告警通知，以外层notification_manner参数为准，内层字段废弃。 **约束限制**： 不涉及。 **取值范围**： 枚举值：NOTIFICATION_POLICY、NOTIFICATION_GROUP、TOPIC_SUBSCRIPTION。长度为[1,64]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 此字段已废弃。通知方式。NOTIFICATION_POLICY表示通知策略，NOTIFICATION_GROUP表示通知组，TOPIC_SUBSCRIPTION表示主题订阅。一键告警是否开启告警通知，以外层notification_manner参数为准，内层字段废弃。 **约束限制**： 不涉及。 **取值范围**： 枚举值：NOTIFICATION_POLICY、NOTIFICATION_GROUP、TOPIC_SUBSCRIPTION。长度为[1,64]个字符。           **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<NotificationMannerEnum>))]
        public class NotificationMannerEnum
        {
            /// <summary>
            /// Enum NOTIFICATION_POLICY for value: NOTIFICATION_POLICY
            /// </summary>
            public static readonly NotificationMannerEnum NOTIFICATION_POLICY = new NotificationMannerEnum("NOTIFICATION_POLICY");

            /// <summary>
            /// Enum NOTIFICATION_GROUP for value: NOTIFICATION_GROUP
            /// </summary>
            public static readonly NotificationMannerEnum NOTIFICATION_GROUP = new NotificationMannerEnum("NOTIFICATION_GROUP");

            /// <summary>
            /// Enum TOPIC_SUBSCRIPTION for value: TOPIC_SUBSCRIPTION
            /// </summary>
            public static readonly NotificationMannerEnum TOPIC_SUBSCRIPTION = new NotificationMannerEnum("TOPIC_SUBSCRIPTION");

            private static readonly Dictionary<string, NotificationMannerEnum> StaticFields =
            new Dictionary<string, NotificationMannerEnum>()
            {
                { "NOTIFICATION_POLICY", NOTIFICATION_POLICY },
                { "NOTIFICATION_GROUP", NOTIFICATION_GROUP },
                { "TOPIC_SUBSCRIPTION", TOPIC_SUBSCRIPTION },
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

            public static bool operator !=(NotificationMannerEnum a, NotificationMannerEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 告警规则id。     **约束限制**： 不涉及。 **取值范围**： 以al开头，后跟22个数字或字母。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// **参数解释**： 此字段已废弃。告警名称。      **约束限制**： 不涉及。 **取值范围**： 只能包含0-9/a-z/A-Z/_/-或汉字，长度[1，128]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 此字段已废弃。告警描述。     **约束限制**： 不涉及。 **取值范围**： 长度为[0,256]个字符。        **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 告警策略
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> Policies { get; set; }

        /// <summary>
        /// 此字段已废弃。资源列表，关联资源需要使用查询告警规则资源接口获取
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<Dimension>> Resources { get; set; }

        /// <summary>
        /// **参数解释**： 此字段已废弃。告警规则类型 **约束限制**： 不涉及。 **取值范围**： 枚举值。 - ALL_INSTANCE：全部资源指标告警。 - RESOURCE_GROUP：资源分组指标告警。 - MULTI_INSTANCE：指定资源指标告警。 - EVENT.SYS：系统事件告警。 - EVENT.CUSTOM：自定义事件告警。 - DNSHealthCheck：健康检查告警。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**： 是否开启告警规则。     **约束限制**： 不涉及。 **取值范围**： 布尔值。 - true:开启。 - false:关闭。 **默认取值**： true 
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启告警通知。     **约束限制**： 不涉及。 **取值范围**： 布尔值。 - true:开启。 - false:关闭。 **默认取值**： true 
        /// </summary>
        [JsonProperty("notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotificationEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 触发告警时，通知组/主题订阅的信息。 **约束限制**： 包含的通知信息的数量最多为10个，最少为0个。 
        /// </summary>
        [JsonProperty("alarm_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> AlarmNotifications { get; set; }

        /// <summary>
        /// **参数解释**： 告警恢复时，通知组/主题订阅的信息。 **约束限制**： 包含的通知信息的数量最多为10个，最少为0个。 
        /// </summary>
        [JsonProperty("ok_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> OkNotifications { get; set; }

        /// <summary>
        /// **参数解释**： 告警通知开启时间。    **约束限制**： 不涉及。 **取值范围**： 只能包含数字、“:”，长度为[1,64]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("notification_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationBeginTime { get; set; }

        /// <summary>
        /// **参数解释**： 告警通知关闭时间。    **约束限制**： 不涉及。 **取值范围**： 只能包含数字、“:”，长度为[1,64]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("notification_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationEndTime { get; set; }

        /// <summary>
        /// **参数解释**： 此字段已废弃。通知方式。NOTIFICATION_POLICY表示通知策略，NOTIFICATION_GROUP表示通知组，TOPIC_SUBSCRIPTION表示主题订阅。一键告警是否开启告警通知，以外层notification_manner参数为准，内层字段废弃。 **约束限制**： 不涉及。 **取值范围**： 枚举值：NOTIFICATION_POLICY、NOTIFICATION_GROUP、TOPIC_SUBSCRIPTION。长度为[1,64]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("notification_manner", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationMannerEnum NotificationManner { get; set; }
        /// <summary>
        /// **参数解释**： 此字段已废弃。关联的通知策略ID列表。一键告警是否开启告警通知，以外层notification_policy_ids参数为准，内层字段废弃。 **约束限制**： 不涉及。 **取值范围**： ^([a-z]|[A-Z]|[0-9]|-){2,64}$。长度为[2,64]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("notification_policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationPolicyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableOneClickAlarmRequestBodyOneClickUpdateAlarms {\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  notificationEnabled: ").Append(NotificationEnabled).Append("\n");
            sb.Append("  alarmNotifications: ").Append(AlarmNotifications).Append("\n");
            sb.Append("  okNotifications: ").Append(OkNotifications).Append("\n");
            sb.Append("  notificationBeginTime: ").Append(NotificationBeginTime).Append("\n");
            sb.Append("  notificationEndTime: ").Append(NotificationEndTime).Append("\n");
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
            return this.Equals(input as EnableOneClickAlarmRequestBodyOneClickUpdateAlarms);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableOneClickAlarmRequestBodyOneClickUpdateAlarms input)
        {
            if (input == null) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && input.Policies != null && !this.Policies.SequenceEqual(input.Policies))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.Type != input.Type) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.NotificationEnabled != input.NotificationEnabled || (this.NotificationEnabled != null && !this.NotificationEnabled.Equals(input.NotificationEnabled))) return false;
            if (this.AlarmNotifications != input.AlarmNotifications || (this.AlarmNotifications != null && input.AlarmNotifications != null && !this.AlarmNotifications.SequenceEqual(input.AlarmNotifications))) return false;
            if (this.OkNotifications != input.OkNotifications || (this.OkNotifications != null && input.OkNotifications != null && !this.OkNotifications.SequenceEqual(input.OkNotifications))) return false;
            if (this.NotificationBeginTime != input.NotificationBeginTime || (this.NotificationBeginTime != null && !this.NotificationBeginTime.Equals(input.NotificationBeginTime))) return false;
            if (this.NotificationEndTime != input.NotificationEndTime || (this.NotificationEndTime != null && !this.NotificationEndTime.Equals(input.NotificationEndTime))) return false;
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
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.NotificationEnabled != null) hashCode = hashCode * 59 + this.NotificationEnabled.GetHashCode();
                if (this.AlarmNotifications != null) hashCode = hashCode * 59 + this.AlarmNotifications.GetHashCode();
                if (this.OkNotifications != null) hashCode = hashCode * 59 + this.OkNotifications.GetHashCode();
                if (this.NotificationBeginTime != null) hashCode = hashCode * 59 + this.NotificationBeginTime.GetHashCode();
                if (this.NotificationEndTime != null) hashCode = hashCode * 59 + this.NotificationEndTime.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationManner.GetHashCode();
                if (this.NotificationPolicyIds != null) hashCode = hashCode * 59 + this.NotificationPolicyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
