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
    /// **参数解释**： 告警记录详细信息 
    /// </summary>
    public class AlarmHistoryItemV2 
    {
        /// <summary>
        /// **参数解释**： 告警规则状态 **取值范围**： 枚举值。 - ok：正常 - alarm：告警 - invalid：已失效 - insufficient_data: 数据不足 - ok_manual: 手动恢复 
        /// </summary>
        /// <value>**参数解释**： 告警规则状态 **取值范围**： 枚举值。 - ok：正常 - alarm：告警 - invalid：已失效 - insufficient_data: 数据不足 - ok_manual: 手动恢复 </value>
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
            /// Enum INSUFFICIENT_DATA for value: insufficient_data
            /// </summary>
            public static readonly StatusEnum INSUFFICIENT_DATA = new StatusEnum("insufficient_data");

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
                { "insufficient_data", INSUFFICIENT_DATA },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 告警记录的告警级别。 **取值范围**： 值为1,2,3,4 - 1：紧急 - 2：重要 - 3：次要 - 4：提示 
        /// </summary>
        /// <value>**参数解释**： 告警记录的告警级别。 **取值范围**： 值为1,2,3,4 - 1：紧急 - 2：重要 - 3：次要 - 4：提示 </value>
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

            public static bool operator !=(LevelEnum a, LevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 告警规则类型。 **取值范围**： 枚举值 - ALL_INSTANCE：全部资源指标告警 - RESOURCE_GROUP：资源分组指标告警 - MULTI_INSTANCE：指定资源指标告警 - EVENT.SYS：系统事件告警 - EVENT.CUSTOM：自定义事件告警 - DNSHealthCheck：健康检查告警 
        /// </summary>
        /// <value>**参数解释**： 告警规则类型。 **取值范围**： 枚举值 - ALL_INSTANCE：全部资源指标告警 - RESOURCE_GROUP：资源分组指标告警 - MULTI_INSTANCE：指定资源指标告警 - EVENT.SYS：系统事件告警 - EVENT.CUSTOM：自定义事件告警 - DNSHealthCheck：健康检查告警 </value>
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
        /// **参数解释**： 告警屏蔽状态。 **取值范围**： - MASKED：已屏蔽 - UN_MASKED：未屏蔽 
        /// </summary>
        /// <value>**参数解释**： 告警屏蔽状态。 **取值范围**： - MASKED：已屏蔽 - UN_MASKED：未屏蔽 </value>
        [JsonConverter(typeof(EnumClassConverter<MaskStatusEnum>))]
        public class MaskStatusEnum
        {
            /// <summary>
            /// Enum MASKED for value: MASKED
            /// </summary>
            public static readonly MaskStatusEnum MASKED = new MaskStatusEnum("MASKED");

            /// <summary>
            /// Enum UN_MASKED for value: UN_MASKED
            /// </summary>
            public static readonly MaskStatusEnum UN_MASKED = new MaskStatusEnum("UN_MASKED");

            private static readonly Dictionary<string, MaskStatusEnum> StaticFields =
            new Dictionary<string, MaskStatusEnum>()
            {
                { "MASKED", MASKED },
                { "UN_MASKED", UN_MASKED },
            };

            private string _value;

            public MaskStatusEnum()
            {

            }

            public MaskStatusEnum(string value)
            {
                _value = value;
            }

            public static MaskStatusEnum FromValue(string value)
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

                if (this.Equals(obj as MaskStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MaskStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MaskStatusEnum a, MaskStatusEnum b)
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

            public static bool operator !=(MaskStatusEnum a, MaskStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 告警流水号。优化告警流水号生成规则，由 ah1655717086704DEnBrJ999 更改为 ah251222T092004SAD2yARym **取值范围**： 以ah开头，后跟22位由字母或数字组成的字符串，字符串长度为24。 
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则ID。 **取值范围**： 以al开头，后跟22位的字母或数字。 
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// **参数解释**： 告警名称。 **取值范围**： 只能包含0-9/a-z/A-Z/_/-或汉字，长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则状态 **取值范围**： 枚举值。 - ok：正常 - alarm：告警 - invalid：已失效 - insufficient_data: 数据不足 - ok_manual: 手动恢复 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**： 告警记录的告警级别。 **取值范围**： 值为1,2,3,4 - 1：紧急 - 2：重要 - 3：次要 - 4：提示 
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public LevelEnum Level { get; set; }
        /// <summary>
        /// **参数解释**： 告警规则类型。 **取值范围**： 枚举值 - ALL_INSTANCE：全部资源指标告警 - RESOURCE_GROUP：资源分组指标告警 - MULTI_INSTANCE：指定资源指标告警 - EVENT.SYS：系统事件告警 - EVENT.CUSTOM：自定义事件告警 - DNSHealthCheck：健康检查告警 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**： 是否发送通知 **取值范围**： - true：发送通知 - false：不发送通知 
        /// </summary>
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 产生时间,UTC时间 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间，UTC时间 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 第一次告警时间，UTC时间 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("first_alarm_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstAlarmTime { get; set; }

        /// <summary>
        /// **参数解释**： 最后一次告警时间，UTC时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("last_alarm_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastAlarmTime { get; set; }

        /// <summary>
        /// **参数解释**： 告警恢复时间，UTC时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("alarm_recovery_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AlarmRecoveryTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmHistoryItemV2Metric Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmHistoryItemV2Condition Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalInfo AdditionalInfo { get; set; }

        /// <summary>
        /// **参数解释**： 告警触发时，通知组/主题订阅的信息。结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notification_list\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } 
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmHistoryItemV2AlarmActions> AlarmActions { get; set; }

        /// <summary>
        /// **参数解释**： 告警恢复时，通知组/主题订阅的信息。结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notification_list\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } 
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmHistoryItemV2AlarmActions> OkActions { get; set; }

        /// <summary>
        /// **参数解释**： 计算出该条告警记录的资源监控数据上报时间和监控数值。 
        /// </summary>
        [JsonProperty("data_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPointInfo> DataPoints { get; set; }

        /// <summary>
        /// **参数解释**： 告警屏蔽状态。 **取值范围**： - MASKED：已屏蔽 - UN_MASKED：未屏蔽 
        /// </summary>
        [JsonProperty("mask_status", NullValueHandling = NullValueHandling.Ignore)]
        public MaskStatusEnum MaskStatus { get; set; }


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
            sb.Append("  maskStatus: ").Append(MaskStatus).Append("\n");
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
            if (this.MaskStatus != input.MaskStatus) return false;

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
                hashCode = hashCode * 59 + this.MaskStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
