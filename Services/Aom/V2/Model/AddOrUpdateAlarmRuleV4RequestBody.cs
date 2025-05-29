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
    /// 新增或修改告警规则请求体。
    /// </summary>
    public class AddOrUpdateAlarmRuleV4RequestBody 
    {
        /// <summary>
        /// 告警规则类型。 - “metric”：指标告警规则 - “event”：事件告警规则
        /// </summary>
        /// <value>告警规则类型。 - “metric”：指标告警规则 - “event”：事件告警规则</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmRuleTypeEnum>))]
        public class AlarmRuleTypeEnum
        {
            /// <summary>
            /// Enum METRIC for value: metric
            /// </summary>
            public static readonly AlarmRuleTypeEnum METRIC = new AlarmRuleTypeEnum("metric");

            /// <summary>
            /// Enum EVENT for value: event
            /// </summary>
            public static readonly AlarmRuleTypeEnum EVENT = new AlarmRuleTypeEnum("event");

            private static readonly Dictionary<string, AlarmRuleTypeEnum> StaticFields =
            new Dictionary<string, AlarmRuleTypeEnum>()
            {
                { "metric", METRIC },
                { "event", EVENT },
            };

            private string _value;

            public AlarmRuleTypeEnum()
            {

            }

            public AlarmRuleTypeEnum(string value)
            {
                _value = value;
            }

            public static AlarmRuleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmRuleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmRuleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmRuleTypeEnum a, AlarmRuleTypeEnum b)
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

            public static bool operator !=(AlarmRuleTypeEnum a, AlarmRuleTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmNotification AlarmNotifications { get; set; }

        /// <summary>
        /// 告警规则描述。
        /// </summary>
        [JsonProperty("alarm_rule_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleDescription { get; set; }

        /// <summary>
        /// 是否启用。
        /// </summary>
        [JsonProperty("alarm_rule_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmRuleEnable { get; set; }

        /// <summary>
        /// 告警规则名称。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }

        /// <summary>
        /// 告警规则类型。 - “metric”：指标告警规则 - “event”：事件告警规则
        /// </summary>
        [JsonProperty("alarm_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmRuleTypeEnum AlarmRuleType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event_alarm_spec", NullValueHandling = NullValueHandling.Ignore)]
        public EventAlarmSpec EventAlarmSpec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric_alarm_spec", NullValueHandling = NullValueHandling.Ignore)]
        public MetricAlarmSpec MetricAlarmSpec { get; set; }

        /// <summary>
        /// Prometheus实例id。
        /// </summary>
        [JsonProperty("prom_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromInstanceId { get; set; }

        /// <summary>
        /// 告警规则别名。最多可输入256个字符，只能包含中文、字母、数字、特殊字符（_-【】），开头、结尾不允许输入中划线、下划线。
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrUpdateAlarmRuleV4RequestBody {\n");
            sb.Append("  alarmNotifications: ").Append(AlarmNotifications).Append("\n");
            sb.Append("  alarmRuleDescription: ").Append(AlarmRuleDescription).Append("\n");
            sb.Append("  alarmRuleEnable: ").Append(AlarmRuleEnable).Append("\n");
            sb.Append("  alarmRuleName: ").Append(AlarmRuleName).Append("\n");
            sb.Append("  alarmRuleType: ").Append(AlarmRuleType).Append("\n");
            sb.Append("  eventAlarmSpec: ").Append(EventAlarmSpec).Append("\n");
            sb.Append("  metricAlarmSpec: ").Append(MetricAlarmSpec).Append("\n");
            sb.Append("  promInstanceId: ").Append(PromInstanceId).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddOrUpdateAlarmRuleV4RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddOrUpdateAlarmRuleV4RequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmNotifications != input.AlarmNotifications || (this.AlarmNotifications != null && !this.AlarmNotifications.Equals(input.AlarmNotifications))) return false;
            if (this.AlarmRuleDescription != input.AlarmRuleDescription || (this.AlarmRuleDescription != null && !this.AlarmRuleDescription.Equals(input.AlarmRuleDescription))) return false;
            if (this.AlarmRuleEnable != input.AlarmRuleEnable || (this.AlarmRuleEnable != null && !this.AlarmRuleEnable.Equals(input.AlarmRuleEnable))) return false;
            if (this.AlarmRuleName != input.AlarmRuleName || (this.AlarmRuleName != null && !this.AlarmRuleName.Equals(input.AlarmRuleName))) return false;
            if (this.AlarmRuleType != input.AlarmRuleType) return false;
            if (this.EventAlarmSpec != input.EventAlarmSpec || (this.EventAlarmSpec != null && !this.EventAlarmSpec.Equals(input.EventAlarmSpec))) return false;
            if (this.MetricAlarmSpec != input.MetricAlarmSpec || (this.MetricAlarmSpec != null && !this.MetricAlarmSpec.Equals(input.MetricAlarmSpec))) return false;
            if (this.PromInstanceId != input.PromInstanceId || (this.PromInstanceId != null && !this.PromInstanceId.Equals(input.PromInstanceId))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;

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
                if (this.AlarmNotifications != null) hashCode = hashCode * 59 + this.AlarmNotifications.GetHashCode();
                if (this.AlarmRuleDescription != null) hashCode = hashCode * 59 + this.AlarmRuleDescription.GetHashCode();
                if (this.AlarmRuleEnable != null) hashCode = hashCode * 59 + this.AlarmRuleEnable.GetHashCode();
                if (this.AlarmRuleName != null) hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmRuleType.GetHashCode();
                if (this.EventAlarmSpec != null) hashCode = hashCode * 59 + this.EventAlarmSpec.GetHashCode();
                if (this.MetricAlarmSpec != null) hashCode = hashCode * 59 + this.MetricAlarmSpec.GetHashCode();
                if (this.PromInstanceId != null) hashCode = hashCode * 59 + this.PromInstanceId.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                return hashCode;
            }
        }
    }
}
