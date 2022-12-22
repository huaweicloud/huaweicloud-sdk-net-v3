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
    /// 
    /// </summary>
    public class MetricAlarms 
    {
        /// <summary>
        /// 告警类型。 仅针对事件告警的参数，枚举类型：EVENT.SYS或者EVENT.CUSTOM
        /// </summary>
        /// <value>告警类型。 仅针对事件告警的参数，枚举类型：EVENT.SYS或者EVENT.CUSTOM</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmTypeEnum>))]
        public class AlarmTypeEnum
        {
            /// <summary>
            /// Enum EVENT_SYS for value: EVENT.SYS
            /// </summary>
            public static readonly AlarmTypeEnum EVENT_SYS = new AlarmTypeEnum("EVENT.SYS");

            /// <summary>
            /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
            /// </summary>
            public static readonly AlarmTypeEnum EVENT_CUSTOM = new AlarmTypeEnum("EVENT.CUSTOM");

            private static readonly Dictionary<string, AlarmTypeEnum> StaticFields =
            new Dictionary<string, AlarmTypeEnum>()
            {
                { "EVENT.SYS", EVENT_SYS },
                { "EVENT.CUSTOM", EVENT_CUSTOM },
            };

            private string _value;

            public AlarmTypeEnum()
            {

            }

            public AlarmTypeEnum(string value)
            {
                _value = value;
            }

            public static AlarmTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmTypeEnum a, AlarmTypeEnum b)
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

            public static bool operator !=(AlarmTypeEnum a, AlarmTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警名称。
        /// </summary>
        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        /// <summary>
        /// 告警描述。
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public MetricInfoForAlarm Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Condition Condition { get; set; }

        /// <summary>
        /// 是否启用该条告警。
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }

        /// <summary>
        /// 告警级别，默认为2，级别为1、2、3、4。分别对应紧急、重要、次要、提示。
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        /// <summary>
        /// 告警类型。 仅针对事件告警的参数，枚举类型：EVENT.SYS或者EVENT.CUSTOM
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTypeEnum AlarmType { get; set; }
        /// <summary>
        /// 是否启用该条告警触发的动作。
        /// </summary>
        [JsonProperty("alarm_action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmActionEnabled { get; set; }

        /// <summary>
        /// 告警触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  }  type取值： notification：通知。 autoscaling：弹性伸缩。 notificationList：告警状态发生变化时，被通知对象的列表。
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> AlarmActions { get; set; }

        /// <summary>
        /// 告警恢复触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } type取值：  notification：通知。  notificationList：告警状态发生变化时，被通知对象的列表。
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> OkActions { get; set; }

        /// <summary>
        /// 数据不足触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  }  type取值： 数据不足触发告警通知类型，取值为notification。 notificationList：数据不足触发告警通知时，被通知对象的ID列表。
        /// </summary>
        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> InsufficientdataActions { get; set; }

        /// <summary>
        /// 告警规则生效的开始时间，告警规则仅在生效时间内发送通知消息。例如alarm_action_begin_time为8:00，alarm_action_end_time为20:00时，则对应的告警规则仅在08:00-20:00发送通知消息。
        /// </summary>
        [JsonProperty("alarm_action_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmActionBeginTime { get; set; }

        /// <summary>
        /// 告警规则生效的结束时间，告警规则仅在生效时间内发送通知消息。例如alarm_action_begin_time为8:00，alarm_action_end_time为20:00时，则对应的告警规则仅在08:00-20:00发送通知消息。
        /// </summary>
        [JsonProperty("alarm_action_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmActionEndTime { get; set; }

        /// <summary>
        /// 告警规则的ID。
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警状态变更的时间，UNIX时间戳，单位毫秒。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 告警状态，取值说明：  ok，正常 alarm，告警 insufficient_data，数据不足
        /// </summary>
        [JsonProperty("alarm_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmState { get; set; }

        /// <summary>
        /// 企业项目ID。 取值为all_granted_eps时，表示所有企业项目; 取值为0时，表示默认的企业项目default。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricAlarms {\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmActionEnabled: ").Append(AlarmActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  alarmActionBeginTime: ").Append(AlarmActionBeginTime).Append("\n");
            sb.Append("  alarmActionEndTime: ").Append(AlarmActionEndTime).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  alarmState: ").Append(AlarmState).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricAlarms);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricAlarms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmName == input.AlarmName ||
                    (this.AlarmName != null &&
                    this.AlarmName.Equals(input.AlarmName))
                ) && 
                (
                    this.AlarmDescription == input.AlarmDescription ||
                    (this.AlarmDescription != null &&
                    this.AlarmDescription.Equals(input.AlarmDescription))
                ) && 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.AlarmEnabled == input.AlarmEnabled ||
                    (this.AlarmEnabled != null &&
                    this.AlarmEnabled.Equals(input.AlarmEnabled))
                ) && 
                (
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
                ) && 
                (
                    this.AlarmType == input.AlarmType ||
                    (this.AlarmType != null &&
                    this.AlarmType.Equals(input.AlarmType))
                ) && 
                (
                    this.AlarmActionEnabled == input.AlarmActionEnabled ||
                    (this.AlarmActionEnabled != null &&
                    this.AlarmActionEnabled.Equals(input.AlarmActionEnabled))
                ) && 
                (
                    this.AlarmActions == input.AlarmActions ||
                    this.AlarmActions != null &&
                    input.AlarmActions != null &&
                    this.AlarmActions.SequenceEqual(input.AlarmActions)
                ) && 
                (
                    this.OkActions == input.OkActions ||
                    this.OkActions != null &&
                    input.OkActions != null &&
                    this.OkActions.SequenceEqual(input.OkActions)
                ) && 
                (
                    this.InsufficientdataActions == input.InsufficientdataActions ||
                    this.InsufficientdataActions != null &&
                    input.InsufficientdataActions != null &&
                    this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions)
                ) && 
                (
                    this.AlarmActionBeginTime == input.AlarmActionBeginTime ||
                    (this.AlarmActionBeginTime != null &&
                    this.AlarmActionBeginTime.Equals(input.AlarmActionBeginTime))
                ) && 
                (
                    this.AlarmActionEndTime == input.AlarmActionEndTime ||
                    (this.AlarmActionEndTime != null &&
                    this.AlarmActionEndTime.Equals(input.AlarmActionEndTime))
                ) && 
                (
                    this.AlarmId == input.AlarmId ||
                    (this.AlarmId != null &&
                    this.AlarmId.Equals(input.AlarmId))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.AlarmState == input.AlarmState ||
                    (this.AlarmState != null &&
                    this.AlarmState.Equals(input.AlarmState))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.AlarmName != null)
                    hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmDescription != null)
                    hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmType != null)
                    hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmActionEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmActionEnabled.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.InsufficientdataActions != null)
                    hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.AlarmActionBeginTime != null)
                    hashCode = hashCode * 59 + this.AlarmActionBeginTime.GetHashCode();
                if (this.AlarmActionEndTime != null)
                    hashCode = hashCode * 59 + this.AlarmActionEndTime.GetHashCode();
                if (this.AlarmId != null)
                    hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.AlarmState != null)
                    hashCode = hashCode * 59 + this.AlarmState.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
