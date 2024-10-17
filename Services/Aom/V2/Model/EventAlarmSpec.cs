using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 事件类告警结构。
    /// </summary>
    public class EventAlarmSpec 
    {
        /// <summary>
        /// 告警规则来源。 - “systemEvent”：系统事件 - “customEvent”：自定义事件
        /// </summary>
        /// <value>告警规则来源。 - “systemEvent”：系统事件 - “customEvent”：自定义事件</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmSourceEnum>))]
        public class AlarmSourceEnum
        {
            /// <summary>
            /// Enum SYSTEMEVENT for value: systemEvent
            /// </summary>
            public static readonly AlarmSourceEnum SYSTEMEVENT = new AlarmSourceEnum("systemEvent");

            /// <summary>
            /// Enum CUSTOMEVENT for value: customEvent
            /// </summary>
            public static readonly AlarmSourceEnum CUSTOMEVENT = new AlarmSourceEnum("customEvent");

            private static readonly Dictionary<string, AlarmSourceEnum> StaticFields =
            new Dictionary<string, AlarmSourceEnum>()
            {
                { "systemEvent", SYSTEMEVENT },
                { "customEvent", CUSTOMEVENT },
            };

            private string _value;

            public AlarmSourceEnum()
            {

            }

            public AlarmSourceEnum(string value)
            {
                _value = value;
            }

            public static AlarmSourceEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmSourceEnum a, AlarmSourceEnum b)
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

            public static bool operator !=(AlarmSourceEnum a, AlarmSourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警规则来源。 - “systemEvent”：系统事件 - “customEvent”：自定义事件
        /// </summary>
        [JsonProperty("alarm_source", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmSourceEnum AlarmSource { get; set; }
        /// <summary>
        /// 告警来源。 - “RDS” - “EVS” - “CCE” - “LTS” - “AOM”
        /// </summary>
        [JsonProperty("event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSource { get; set; }

        /// <summary>
        /// 监控对象列表。键值对形式，键值为： - “event_type”：通知类型 - “event_severity”：告警级别 - “event_name”：事件名称 - “namespace”：命名空间 - “clusterId”：集群id - “customField”：用户自定义字段
        /// </summary>
        [JsonProperty("monitor_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> MonitorObjects { get; set; }

        /// <summary>
        /// 触发条件。
        /// </summary>
        [JsonProperty("trigger_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventTriggerCondition> TriggerConditions { get; set; }

        /// <summary>
        /// 是否绑定告警规则模版（废弃）。
        /// </summary>
        [JsonProperty("alarm_rule_template_bind_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmRuleTemplateBindEnable { get; set; }

        /// <summary>
        /// 告警规则模版id（废弃）。
        /// </summary>
        [JsonProperty("alarm_rule_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventAlarmSpec {\n");
            sb.Append("  alarmSource: ").Append(AlarmSource).Append("\n");
            sb.Append("  eventSource: ").Append(EventSource).Append("\n");
            sb.Append("  monitorObjects: ").Append(MonitorObjects).Append("\n");
            sb.Append("  triggerConditions: ").Append(TriggerConditions).Append("\n");
            sb.Append("  alarmRuleTemplateBindEnable: ").Append(AlarmRuleTemplateBindEnable).Append("\n");
            sb.Append("  alarmRuleTemplateId: ").Append(AlarmRuleTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventAlarmSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventAlarmSpec input)
        {
            if (input == null) return false;
            if (this.AlarmSource != input.AlarmSource) return false;
            if (this.EventSource != input.EventSource || (this.EventSource != null && !this.EventSource.Equals(input.EventSource))) return false;
            if (this.MonitorObjects != input.MonitorObjects || (this.MonitorObjects != null && input.MonitorObjects != null && !this.MonitorObjects.SequenceEqual(input.MonitorObjects))) return false;
            if (this.TriggerConditions != input.TriggerConditions || (this.TriggerConditions != null && input.TriggerConditions != null && !this.TriggerConditions.SequenceEqual(input.TriggerConditions))) return false;
            if (this.AlarmRuleTemplateBindEnable != input.AlarmRuleTemplateBindEnable || (this.AlarmRuleTemplateBindEnable != null && !this.AlarmRuleTemplateBindEnable.Equals(input.AlarmRuleTemplateBindEnable))) return false;
            if (this.AlarmRuleTemplateId != input.AlarmRuleTemplateId || (this.AlarmRuleTemplateId != null && !this.AlarmRuleTemplateId.Equals(input.AlarmRuleTemplateId))) return false;

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
                hashCode = hashCode * 59 + this.AlarmSource.GetHashCode();
                if (this.EventSource != null) hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                if (this.MonitorObjects != null) hashCode = hashCode * 59 + this.MonitorObjects.GetHashCode();
                if (this.TriggerConditions != null) hashCode = hashCode * 59 + this.TriggerConditions.GetHashCode();
                if (this.AlarmRuleTemplateBindEnable != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateBindEnable.GetHashCode();
                if (this.AlarmRuleTemplateId != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
