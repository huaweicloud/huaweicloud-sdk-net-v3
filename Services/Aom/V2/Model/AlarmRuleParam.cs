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
    /// 阈值规则实体
    /// </summary>
    public class AlarmRuleParam 
    {
        /// <summary>
        /// 告警级别。1：紧急，2：重要，3：一般，4：提示。
        /// </summary>
        /// <value>告警级别。1：紧急，2：重要，3：一般，4：提示。</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmLevelEnum>))]
        public class AlarmLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AlarmLevelEnum NUMBER_1 = new AlarmLevelEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly AlarmLevelEnum NUMBER_2 = new AlarmLevelEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly AlarmLevelEnum NUMBER_3 = new AlarmLevelEnum(3);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly AlarmLevelEnum NUMBER_4 = new AlarmLevelEnum(4);

            private static readonly Dictionary<int?, AlarmLevelEnum> StaticFields =
            new Dictionary<int?, AlarmLevelEnum>()
            {
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
                { 4, NUMBER_4 },
            };

            private int? _value;

            public AlarmLevelEnum()
            {

            }

            public AlarmLevelEnum(int? value)
            {
                _value = value;
            }

            public static AlarmLevelEnum FromValue(int? value)
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

                if (this.Equals(obj as AlarmLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmLevelEnum a, AlarmLevelEnum b)
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

            public static bool operator !=(AlarmLevelEnum a, AlarmLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 统计方式。
        /// </summary>
        /// <value>统计方式。</value>
        [JsonConverter(typeof(EnumClassConverter<StatisticEnum>))]
        public class StatisticEnum
        {
            /// <summary>
            /// Enum MAXIMUM for value: maximum
            /// </summary>
            public static readonly StatisticEnum MAXIMUM = new StatisticEnum("maximum");

            /// <summary>
            /// Enum MINIMUM for value: minimum
            /// </summary>
            public static readonly StatisticEnum MINIMUM = new StatisticEnum("minimum");

            /// <summary>
            /// Enum AVERAGE for value: average
            /// </summary>
            public static readonly StatisticEnum AVERAGE = new StatisticEnum("average");

            /// <summary>
            /// Enum SUM for value: sum
            /// </summary>
            public static readonly StatisticEnum SUM = new StatisticEnum("sum");

            /// <summary>
            /// Enum SAMPLECOUNT for value: sampleCount
            /// </summary>
            public static readonly StatisticEnum SAMPLECOUNT = new StatisticEnum("sampleCount");

            private static readonly Dictionary<string, StatisticEnum> StaticFields =
            new Dictionary<string, StatisticEnum>()
            {
                { "maximum", MAXIMUM },
                { "minimum", MINIMUM },
                { "average", AVERAGE },
                { "sum", SUM },
                { "sampleCount", SAMPLECOUNT },
            };

            private string _value;

            public StatisticEnum()
            {

            }

            public StatisticEnum(string value)
            {
                _value = value;
            }

            public static StatisticEnum FromValue(string value)
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

                if (this.Equals(obj as StatisticEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatisticEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatisticEnum a, StatisticEnum b)
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

            public static bool operator !=(StatisticEnum a, StatisticEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否启用通知。
        /// </summary>
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEnabled { get; set; }

        /// <summary>
        /// 告警状态通知列表。
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmActions { get; set; }

        /// <summary>
        /// 告警清除建议。
        /// </summary>
        [JsonProperty("alarm_advice", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmAdvice { get; set; }

        /// <summary>
        /// 阈值规则描述。
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// 告警级别。1：紧急，2：重要，3：一般，4：提示。
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmLevelEnum AlarmLevel { get; set; }
        /// <summary>
        /// 阈值规则名称。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }

        /// <summary>
        /// 超限条件。
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 时间序列维度。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// 间隔周期。
        /// </summary>
        [JsonProperty("evaluation_periods", NullValueHandling = NullValueHandling.Ignore)]
        public int? EvaluationPeriods { get; set; }

        /// <summary>
        /// 阈值规则是否启用。
        /// </summary>
        [JsonProperty("id_turn_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IdTurnOn { get; set; }

        /// <summary>
        /// 数据不足通知列表。
        /// </summary>
        [JsonProperty("insufficient_data_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InsufficientDataActions { get; set; }

        /// <summary>
        /// 时间序列名称。名称长度取值范围为1~255个字符。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 时间序列命名空间。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 正常状态通知列表。
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OkActions { get; set; }

        /// <summary>
        /// 统计周期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 统计方式。
        /// </summary>
        [JsonProperty("statistic", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticEnum Statistic { get; set; }
        /// <summary>
        /// 超限值。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string Threshold { get; set; }

        /// <summary>
        /// 时间序列单位
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmRuleParam {\n");
            sb.Append("  actionEnabled: ").Append(ActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  alarmAdvice: ").Append(AlarmAdvice).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmRuleName: ").Append(AlarmRuleName).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  evaluationPeriods: ").Append(EvaluationPeriods).Append("\n");
            sb.Append("  idTurnOn: ").Append(IdTurnOn).Append("\n");
            sb.Append("  insufficientDataActions: ").Append(InsufficientDataActions).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  statistic: ").Append(Statistic).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmRuleParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmRuleParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionEnabled == input.ActionEnabled ||
                    (this.ActionEnabled != null &&
                    this.ActionEnabled.Equals(input.ActionEnabled))
                ) && 
                (
                    this.AlarmActions == input.AlarmActions ||
                    this.AlarmActions != null &&
                    input.AlarmActions != null &&
                    this.AlarmActions.SequenceEqual(input.AlarmActions)
                ) && 
                (
                    this.AlarmAdvice == input.AlarmAdvice ||
                    (this.AlarmAdvice != null &&
                    this.AlarmAdvice.Equals(input.AlarmAdvice))
                ) && 
                (
                    this.AlarmDescription == input.AlarmDescription ||
                    (this.AlarmDescription != null &&
                    this.AlarmDescription.Equals(input.AlarmDescription))
                ) && 
                (
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
                ) && 
                (
                    this.AlarmRuleName == input.AlarmRuleName ||
                    (this.AlarmRuleName != null &&
                    this.AlarmRuleName.Equals(input.AlarmRuleName))
                ) && 
                (
                    this.ComparisonOperator == input.ComparisonOperator ||
                    (this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(input.ComparisonOperator))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.EvaluationPeriods == input.EvaluationPeriods ||
                    (this.EvaluationPeriods != null &&
                    this.EvaluationPeriods.Equals(input.EvaluationPeriods))
                ) && 
                (
                    this.IdTurnOn == input.IdTurnOn ||
                    (this.IdTurnOn != null &&
                    this.IdTurnOn.Equals(input.IdTurnOn))
                ) && 
                (
                    this.InsufficientDataActions == input.InsufficientDataActions ||
                    this.InsufficientDataActions != null &&
                    input.InsufficientDataActions != null &&
                    this.InsufficientDataActions.SequenceEqual(input.InsufficientDataActions)
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.OkActions == input.OkActions ||
                    this.OkActions != null &&
                    input.OkActions != null &&
                    this.OkActions.SequenceEqual(input.OkActions)
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Statistic == input.Statistic ||
                    (this.Statistic != null &&
                    this.Statistic.Equals(input.Statistic))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.ActionEnabled != null)
                    hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.AlarmAdvice != null)
                    hashCode = hashCode * 59 + this.AlarmAdvice.GetHashCode();
                if (this.AlarmDescription != null)
                    hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmRuleName != null)
                    hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                if (this.ComparisonOperator != null)
                    hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.EvaluationPeriods != null)
                    hashCode = hashCode * 59 + this.EvaluationPeriods.GetHashCode();
                if (this.IdTurnOn != null)
                    hashCode = hashCode * 59 + this.IdTurnOn.GetHashCode();
                if (this.InsufficientDataActions != null)
                    hashCode = hashCode * 59 + this.InsufficientDataActions.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Statistic != null)
                    hashCode = hashCode * 59 + this.Statistic.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
