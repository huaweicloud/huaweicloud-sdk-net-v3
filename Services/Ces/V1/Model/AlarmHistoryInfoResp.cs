using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// **参数解释**： 告警历史详细信息 
    /// </summary>
    public class AlarmHistoryInfoResp 
    {
        /// <summary>
        /// **参数解释** 通知方式 **取值范围**： 枚举值： - NOTIFICATION_POLICY：通知策略 - NOTIFICATION_GROUP：通知组 - TOPIC_SUBSCRIPTION：主题订阅 
        /// </summary>
        /// <value>**参数解释** 通知方式 **取值范围**： 枚举值： - NOTIFICATION_POLICY：通知策略 - NOTIFICATION_GROUP：通知组 - TOPIC_SUBSCRIPTION：主题订阅 </value>
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
        /// **参数解释**： 告警规则的ID，如：al1603131199286dzxpqK3Ez。 **取值范围**： 字符串长度为24 
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则的名称，如：alarm-test01 **取值范围**： 字符串长度在 1 到 128 之间 
        /// </summary>
        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则的描述 **取值范围**： 字符串长度在 0 到 256 之间 
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public MetricInfoResp Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionResp Condition { get; set; }

        /// <summary>
        /// **参数解释**： 告警记录的告警级别。 **取值范围**： 枚举值： - 1：紧急 - 2：重要 - 3：次要 - 4：提示 
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则类型 **取值范围**： 枚举值: - ALL_INSTANCE：全部资源指标告警 - RESOURCE_GROUP：资源分组指标告警 - MULTI_INSTANCE：指定资源指标告警 - EVENT.SYS：系统事件告警 - EVENT.CUSTOM：自定义事件告警 - DNSHealthCheck：健康检查告警 
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmType { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则是否被启用 **取值范围**： 值为true或者false - true：开启 - false：关闭 
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 是否发送通知 **取值范围**： 值为true或者false - true：发送通知 - false：不发送通知 
        /// </summary>
        [JsonProperty("alarm_action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmActionEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 告警触发时，通知组/主题订阅的信息。结构如下：{  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } 
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<NotificationResp>> AlarmActions { get; set; }

        /// <summary>
        /// **参数解释**： 告警恢复时，通知组/主题订阅的信息。结构如下：{  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } 
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<NotificationResp>> OkActions { get; set; }

        /// <summary>
        /// **参数解释**： 数据不足时触发告警时，通知组/主题订阅的信息。结构如下：{  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } 
        /// </summary>
        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<NotificationResp>> InsufficientdataActions { get; set; }

        /// <summary>
        /// **参数解释**： 告警状态变更的时间，UNIX时间戳，单位毫秒，如：1603131199000 **取值范围**： 不涉及 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID **取值范围**： 只能包含小写字母、数字、“-”、“_”，可以自定义企业项目ID，长度为36个字符。也可以为0（代表默认企业项目ID），all_granted_eps（代表所有企业项目ID） 
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 计算出该条告警历史的时间，UNIX时间戳，单位毫秒，如：1603131199469 **取值范围**： 不涉及 
        /// </summary>
        [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TriggerTime { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则的状态 **取值范围**： 枚举值： - ok：正常 - alarm：告警 - insufficient_data：数据不足 - invalid：已失效 
        /// </summary>
        [JsonProperty("alarm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStatus { get; set; }

        /// <summary>
        /// **参数解释**： 计算出该条告警历史的资源监控数据的一组数据上报时间和监控数值 
        /// </summary>
        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPointForAlarmHistoryResp> Datapoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalInfoResp AdditionalInfo { get; set; }

        /// <summary>
        /// **参数解释** 通知方式 **取值范围**： 枚举值： - NOTIFICATION_POLICY：通知策略 - NOTIFICATION_GROUP：通知组 - TOPIC_SUBSCRIPTION：主题订阅 
        /// </summary>
        [JsonProperty("notification_manner", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationMannerEnum NotificationManner { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmHistoryInfoResp {\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  alarmActionEnabled: ").Append(AlarmActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  triggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("  alarmStatus: ").Append(AlarmStatus).Append("\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  additionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  notificationManner: ").Append(NotificationManner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmHistoryInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmHistoryInfoResp input)
        {
            if (input == null) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.AlarmName != input.AlarmName || (this.AlarmName != null && !this.AlarmName.Equals(input.AlarmName))) return false;
            if (this.AlarmDescription != input.AlarmDescription || (this.AlarmDescription != null && !this.AlarmDescription.Equals(input.AlarmDescription))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;
            if (this.AlarmType != input.AlarmType || (this.AlarmType != null && !this.AlarmType.Equals(input.AlarmType))) return false;
            if (this.AlarmEnabled != input.AlarmEnabled || (this.AlarmEnabled != null && !this.AlarmEnabled.Equals(input.AlarmEnabled))) return false;
            if (this.AlarmActionEnabled != input.AlarmActionEnabled || (this.AlarmActionEnabled != null && !this.AlarmActionEnabled.Equals(input.AlarmActionEnabled))) return false;
            if (this.AlarmActions != input.AlarmActions || (this.AlarmActions != null && input.AlarmActions != null && !this.AlarmActions.SequenceEqual(input.AlarmActions))) return false;
            if (this.OkActions != input.OkActions || (this.OkActions != null && input.OkActions != null && !this.OkActions.SequenceEqual(input.OkActions))) return false;
            if (this.InsufficientdataActions != input.InsufficientdataActions || (this.InsufficientdataActions != null && input.InsufficientdataActions != null && !this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.TriggerTime != input.TriggerTime || (this.TriggerTime != null && !this.TriggerTime.Equals(input.TriggerTime))) return false;
            if (this.AlarmStatus != input.AlarmStatus || (this.AlarmStatus != null && !this.AlarmStatus.Equals(input.AlarmStatus))) return false;
            if (this.Datapoints != input.Datapoints || (this.Datapoints != null && input.Datapoints != null && !this.Datapoints.SequenceEqual(input.Datapoints))) return false;
            if (this.AdditionalInfo != input.AdditionalInfo || (this.AdditionalInfo != null && !this.AdditionalInfo.Equals(input.AdditionalInfo))) return false;
            if (this.NotificationManner != input.NotificationManner) return false;

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
                if (this.AlarmName != null) hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmDescription != null) hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmType != null) hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmEnabled != null) hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.AlarmActionEnabled != null) hashCode = hashCode * 59 + this.AlarmActionEnabled.GetHashCode();
                if (this.AlarmActions != null) hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null) hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.InsufficientdataActions != null) hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.TriggerTime != null) hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                if (this.AlarmStatus != null) hashCode = hashCode * 59 + this.AlarmStatus.GetHashCode();
                if (this.Datapoints != null) hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.AdditionalInfo != null) hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationManner.GetHashCode();
                return hashCode;
            }
        }
    }
}
