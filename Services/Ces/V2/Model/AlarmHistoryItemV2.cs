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
    /// 告警记录详细信息
    /// </summary>
    public class AlarmHistoryItemV2 
    {
        /// <summary>
        /// 告警记录的状态，取值为ok，alarm，invalid, ok_manual； ok为正常，alarm为告警，invalid为已失效,ok_manual为手动恢复。
        /// </summary>
        /// <value>告警记录的状态，取值为ok，alarm，invalid, ok_manual； ok为正常，alarm为告警，invalid为已失效,ok_manual为手动恢复。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum OK for value: ok
            /// </summary>
            public static readonly StatusEnum OK = new StatusEnum("ok");

            /// <summary>
            /// Enum ALARM for value: alarm
            /// </summary>
            public static readonly StatusEnum ALARM = new StatusEnum("alarm");

            /// <summary>
            /// Enum INVALID for value: invalid
            /// </summary>
            public static readonly StatusEnum INVALID = new StatusEnum("invalid");

            /// <summary>
            /// Enum OK_MANUAL for value: ok_manual
            /// </summary>
            public static readonly StatusEnum OK_MANUAL = new StatusEnum("ok_manual");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ok", OK },
                { "alarm", ALARM },
                { "invalid", INVALID },
                { "ok_manual", OK_MANUAL },
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
        /// 告警记录的告警级别，值为1,2,3,4；1为紧急，2为重要，3为次要，4为提示。
        /// </summary>
        /// <value>告警记录的告警级别，值为1,2,3,4；1为紧急，2为重要，3为次要，4为提示。</value>
        [JsonConverter(typeof(EnumClassConverter<LevelEnum>))]
        public class LevelEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly LevelEnum NUMBER_1 = new LevelEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly LevelEnum NUMBER_2 = new LevelEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly LevelEnum NUMBER_3 = new LevelEnum(3);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly LevelEnum NUMBER_4 = new LevelEnum(4);

            private static readonly Dictionary<int?, LevelEnum> StaticFields =
            new Dictionary<int?, LevelEnum>()
            {
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
                { 4, NUMBER_4 },
            };

            private int? _value;

            public LevelEnum()
            {

            }

            public LevelEnum(int? value)
            {
                _value = value;
            }

            public static LevelEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as LevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LevelEnum a, LevelEnum b)
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

            public static bool operator !=(LevelEnum a, LevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警记录ID
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// 告警规则的ID，如：al1603131199286dzxpqK3Ez。
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警规则的名称，如：alarm-test01。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 告警记录的状态，取值为ok，alarm，invalid, ok_manual； ok为正常，alarm为告警，invalid为已失效,ok_manual为手动恢复。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 告警记录的告警级别，值为1,2,3,4；1为紧急，2为重要，3为次要，4为提示。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public LevelEnum Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmType Type { get; set; }
        /// <summary>
        /// 是否发送通知，值为true或者false。
        /// </summary>
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEnabled { get; set; }

        /// <summary>
        /// 产生时间,UTC时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 结束时间，UTC时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 第一次告警时间，UTC时间
        /// </summary>
        [JsonProperty("first_alarm_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstAlarmTime { get; set; }

        /// <summary>
        /// 最后一次告警时间，UTC时间
        /// </summary>
        [JsonProperty("last_alarm_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastAlarmTime { get; set; }

        /// <summary>
        /// 告警恢复时间，UTC时间
        /// </summary>
        [JsonProperty("alarm_recovery_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AlarmRecoveryTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public Metric Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmCondition Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalInfo AdditionalInfo { get; set; }

        /// <summary>
        /// 告警触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notification_list\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  }  type取值： notification：通知。 autoscaling：弹性伸缩。 notification_list：告警状态发生变化时，被通知对象的列表。
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> AlarmActions { get; set; }

        /// <summary>
        /// 告警恢复触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notification_list\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } type取值：  notification：通知。  notification_list：告警状态发生变化时，被通知对象的列表。
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> OkActions { get; set; }

        /// <summary>
        /// 计算出该条告警记录的资源监控数据上报时间和监控数值。
        /// </summary>
        [JsonProperty("data_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPointInfo> DataPoints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmHistoryItemV2 {\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  actionEnabled: ").Append(ActionEnabled).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  firstAlarmTime: ").Append(FirstAlarmTime).Append("\n");
            sb.Append("  lastAlarmTime: ").Append(LastAlarmTime).Append("\n");
            sb.Append("  alarmRecoveryTime: ").Append(AlarmRecoveryTime).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  additionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  dataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmHistoryItemV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmHistoryItemV2 input)
        {
            if (input == null) return false;
            if (this.RecordId != input.RecordId || (this.RecordId != null && !this.RecordId.Equals(input.RecordId))) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status) return false;
            if (this.Level != input.Level) return false;
            if (this.Type != input.Type) return false;
            if (this.ActionEnabled != input.ActionEnabled || (this.ActionEnabled != null && !this.ActionEnabled.Equals(input.ActionEnabled))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.FirstAlarmTime != input.FirstAlarmTime || (this.FirstAlarmTime != null && !this.FirstAlarmTime.Equals(input.FirstAlarmTime))) return false;
            if (this.LastAlarmTime != input.LastAlarmTime || (this.LastAlarmTime != null && !this.LastAlarmTime.Equals(input.LastAlarmTime))) return false;
            if (this.AlarmRecoveryTime != input.AlarmRecoveryTime || (this.AlarmRecoveryTime != null && !this.AlarmRecoveryTime.Equals(input.AlarmRecoveryTime))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.AdditionalInfo != input.AdditionalInfo || (this.AdditionalInfo != null && !this.AdditionalInfo.Equals(input.AdditionalInfo))) return false;
            if (this.AlarmActions != input.AlarmActions || (this.AlarmActions != null && input.AlarmActions != null && !this.AlarmActions.SequenceEqual(input.AlarmActions))) return false;
            if (this.OkActions != input.OkActions || (this.OkActions != null && input.OkActions != null && !this.OkActions.SequenceEqual(input.OkActions))) return false;
            if (this.DataPoints != input.DataPoints || (this.DataPoints != null && input.DataPoints != null && !this.DataPoints.SequenceEqual(input.DataPoints))) return false;

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
                if (this.RecordId != null) hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Level.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ActionEnabled != null) hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.FirstAlarmTime != null) hashCode = hashCode * 59 + this.FirstAlarmTime.GetHashCode();
                if (this.LastAlarmTime != null) hashCode = hashCode * 59 + this.LastAlarmTime.GetHashCode();
                if (this.AlarmRecoveryTime != null) hashCode = hashCode * 59 + this.AlarmRecoveryTime.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AdditionalInfo != null) hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
                if (this.AlarmActions != null) hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null) hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.DataPoints != null) hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
