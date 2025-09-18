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
    /// 指标类告警结构。
    /// </summary>
    public class MetricAlarmSpec 
    {
        /// <summary>
        /// 监控类型。 - “all_metric”：全量指标 - “promql”：PromQL - “resource”：（日落）资源类型
        /// </summary>
        /// <value>监控类型。 - “all_metric”：全量指标 - “promql”：PromQL - “resource”：（日落）资源类型</value>
        [JsonConverter(typeof(EnumClassConverter<MonitorTypeEnum>))]
        public class MonitorTypeEnum
        {
            /// <summary>
            /// Enum ALL_METRIC for value: all_metric
            /// </summary>
            public static readonly MonitorTypeEnum ALL_METRIC = new MonitorTypeEnum("all_metric");

            /// <summary>
            /// Enum PROMQL for value: promql
            /// </summary>
            public static readonly MonitorTypeEnum PROMQL = new MonitorTypeEnum("promql");

            /// <summary>
            /// Enum RESOURCE for value: resource
            /// </summary>
            public static readonly MonitorTypeEnum RESOURCE = new MonitorTypeEnum("resource");

            private static readonly Dictionary<string, MonitorTypeEnum> StaticFields =
            new Dictionary<string, MonitorTypeEnum>()
            {
                { "all_metric", ALL_METRIC },
                { "promql", PROMQL },
                { "resource", RESOURCE },
            };

            private string _value;

            public MonitorTypeEnum()
            {

            }

            public MonitorTypeEnum(string value)
            {
                _value = value;
            }

            public static MonitorTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MonitorTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MonitorTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MonitorTypeEnum a, MonitorTypeEnum b)
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

            public static bool operator !=(MonitorTypeEnum a, MonitorTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 监控类型。 - “all_metric”：全量指标 - “promql”：PromQL - “resource”：（日落）资源类型
        /// </summary>
        [JsonProperty("monitor_type", NullValueHandling = NullValueHandling.Ignore)]
        public MonitorTypeEnum MonitorType { get; set; }
        /// <summary>
        /// 无数据处理。
        /// </summary>
        [JsonProperty("no_data_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NoDataCondition> NoDataConditions { get; set; }

        /// <summary>
        /// 告警标签。
        /// </summary>
        [JsonProperty("alarm_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmTags> AlarmTags { get; set; }

        /// <summary>
        /// 监控对象列表。
        /// </summary>
        [JsonProperty("monitor_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> MonitorObjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recovery_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public RecoveryCondition RecoveryConditions { get; set; }

        /// <summary>
        /// 触发条件。
        /// </summary>
        [JsonProperty("trigger_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TriggerCondition> TriggerConditions { get; set; }

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
            sb.Append("class MetricAlarmSpec {\n");
            sb.Append("  monitorType: ").Append(MonitorType).Append("\n");
            sb.Append("  noDataConditions: ").Append(NoDataConditions).Append("\n");
            sb.Append("  alarmTags: ").Append(AlarmTags).Append("\n");
            sb.Append("  monitorObjects: ").Append(MonitorObjects).Append("\n");
            sb.Append("  recoveryConditions: ").Append(RecoveryConditions).Append("\n");
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
            return this.Equals(input as MetricAlarmSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricAlarmSpec input)
        {
            if (input == null) return false;
            if (this.MonitorType != input.MonitorType) return false;
            if (this.NoDataConditions != input.NoDataConditions || (this.NoDataConditions != null && input.NoDataConditions != null && !this.NoDataConditions.SequenceEqual(input.NoDataConditions))) return false;
            if (this.AlarmTags != input.AlarmTags || (this.AlarmTags != null && input.AlarmTags != null && !this.AlarmTags.SequenceEqual(input.AlarmTags))) return false;
            if (this.MonitorObjects != input.MonitorObjects || (this.MonitorObjects != null && input.MonitorObjects != null && !this.MonitorObjects.SequenceEqual(input.MonitorObjects))) return false;
            if (this.RecoveryConditions != input.RecoveryConditions || (this.RecoveryConditions != null && !this.RecoveryConditions.Equals(input.RecoveryConditions))) return false;
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
                hashCode = hashCode * 59 + this.MonitorType.GetHashCode();
                if (this.NoDataConditions != null) hashCode = hashCode * 59 + this.NoDataConditions.GetHashCode();
                if (this.AlarmTags != null) hashCode = hashCode * 59 + this.AlarmTags.GetHashCode();
                if (this.MonitorObjects != null) hashCode = hashCode * 59 + this.MonitorObjects.GetHashCode();
                if (this.RecoveryConditions != null) hashCode = hashCode * 59 + this.RecoveryConditions.GetHashCode();
                if (this.TriggerConditions != null) hashCode = hashCode * 59 + this.TriggerConditions.GetHashCode();
                if (this.AlarmRuleTemplateBindEnable != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateBindEnable.GetHashCode();
                if (this.AlarmRuleTemplateId != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
