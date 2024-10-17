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
        /// 超限条件。&lt;：小于阈值。&gt;：大于阈值。&lt;&#x3D;：小于等于阈值。&gt;&#x3D;：大于等于阈值。
        /// </summary>
        /// <value>超限条件。&lt;：小于阈值。&gt;：大于阈值。&lt;&#x3D;：小于等于阈值。&gt;&#x3D;：大于等于阈值。</value>
        [JsonConverter(typeof(EnumClassConverter<ComparisonOperatorEnum>))]
        public class ComparisonOperatorEnum
        {
            /// <summary>
            /// Enum LessThan for value: <
            /// </summary>
            public static readonly ComparisonOperatorEnum LessThan = new ComparisonOperatorEnum("<");

            /// <summary>
            /// Enum GreaterThan for value: >
            /// </summary>
            public static readonly ComparisonOperatorEnum GreaterThan = new ComparisonOperatorEnum(">");

            /// <summary>
            /// Enum LessThanOrEqualTo for value: <=
            /// </summary>
            public static readonly ComparisonOperatorEnum LessThanOrEqualTo = new ComparisonOperatorEnum("<=");

            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: >=
            /// </summary>
            public static readonly ComparisonOperatorEnum GreaterThanOrEqualTo = new ComparisonOperatorEnum(">=");

            private static readonly Dictionary<string, ComparisonOperatorEnum> StaticFields =
            new Dictionary<string, ComparisonOperatorEnum>()
            {
                { "<", LessThan },
                { ">", GreaterThan },
                { "<=", LessThanOrEqualTo },
                { ">=", GreaterThanOrEqualTo },
            };

            private string _value;

            public ComparisonOperatorEnum()
            {

            }

            public ComparisonOperatorEnum(string value)
            {
                _value = value;
            }

            public static ComparisonOperatorEnum FromValue(string value)
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

                if (this.Equals(obj as ComparisonOperatorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ComparisonOperatorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ComparisonOperatorEnum a, ComparisonOperatorEnum b)
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

            public static bool operator !=(ComparisonOperatorEnum a, ComparisonOperatorEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 统计周期。60000：一分钟。300000：五分钟。900000：十五分钟。3600000：一小时。
        /// </summary>
        /// <value>统计周期。60000：一分钟。300000：五分钟。900000：十五分钟。3600000：一小时。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodEnum>))]
        public class PeriodEnum
        {
            /// <summary>
            /// Enum NUMBER_60000 for value: 60000
            /// </summary>
            public static readonly PeriodEnum NUMBER_60000 = new PeriodEnum(60000);

            /// <summary>
            /// Enum NUMBER_300000 for value: 300000
            /// </summary>
            public static readonly PeriodEnum NUMBER_300000 = new PeriodEnum(300000);

            /// <summary>
            /// Enum NUMBER_900000 for value: 900000
            /// </summary>
            public static readonly PeriodEnum NUMBER_900000 = new PeriodEnum(900000);

            /// <summary>
            /// Enum NUMBER_3600000 for value: 3600000
            /// </summary>
            public static readonly PeriodEnum NUMBER_3600000 = new PeriodEnum(3600000);

            private static readonly Dictionary<int?, PeriodEnum> StaticFields =
            new Dictionary<int?, PeriodEnum>()
            {
                { 60000, NUMBER_60000 },
                { 300000, NUMBER_300000 },
                { 900000, NUMBER_900000 },
                { 3600000, NUMBER_3600000 },
            };

            private int? _value;

            public PeriodEnum()
            {

            }

            public PeriodEnum(int? value)
            {
                _value = value;
            }

            public static PeriodEnum FromValue(int? value)
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

                if (this.Equals(obj as PeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodEnum a, PeriodEnum b)
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

            public static bool operator !=(PeriodEnum a, PeriodEnum b)
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
        /// 阈值规则名称。规则名称包含大小写字母、数字、特殊字符（-_）和汉字组成，不能以特殊字符开头或结尾，最大长度为100。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }

        /// <summary>
        /// 超限条件。&lt;：小于阈值。&gt;：大于阈值。&lt;&#x3D;：小于等于阈值。&gt;&#x3D;：大于等于阈值。
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public ComparisonOperatorEnum ComparisonOperator { get; set; }
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
        [JsonProperty("is_turn_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTurnOn { get; set; }

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
        /// 统计周期。60000：一分钟。300000：五分钟。900000：十五分钟。3600000：一小时。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }
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
            sb.Append("  isTurnOn: ").Append(IsTurnOn).Append("\n");
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
            if (input == null) return false;
            if (this.ActionEnabled != input.ActionEnabled || (this.ActionEnabled != null && !this.ActionEnabled.Equals(input.ActionEnabled))) return false;
            if (this.AlarmActions != input.AlarmActions || (this.AlarmActions != null && input.AlarmActions != null && !this.AlarmActions.SequenceEqual(input.AlarmActions))) return false;
            if (this.AlarmAdvice != input.AlarmAdvice || (this.AlarmAdvice != null && !this.AlarmAdvice.Equals(input.AlarmAdvice))) return false;
            if (this.AlarmDescription != input.AlarmDescription || (this.AlarmDescription != null && !this.AlarmDescription.Equals(input.AlarmDescription))) return false;
            if (this.AlarmLevel != input.AlarmLevel) return false;
            if (this.AlarmRuleName != input.AlarmRuleName || (this.AlarmRuleName != null && !this.AlarmRuleName.Equals(input.AlarmRuleName))) return false;
            if (this.ComparisonOperator != input.ComparisonOperator) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;
            if (this.EvaluationPeriods != input.EvaluationPeriods || (this.EvaluationPeriods != null && !this.EvaluationPeriods.Equals(input.EvaluationPeriods))) return false;
            if (this.IsTurnOn != input.IsTurnOn || (this.IsTurnOn != null && !this.IsTurnOn.Equals(input.IsTurnOn))) return false;
            if (this.InsufficientDataActions != input.InsufficientDataActions || (this.InsufficientDataActions != null && input.InsufficientDataActions != null && !this.InsufficientDataActions.SequenceEqual(input.InsufficientDataActions))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.OkActions != input.OkActions || (this.OkActions != null && input.OkActions != null && !this.OkActions.SequenceEqual(input.OkActions))) return false;
            if (this.Period != input.Period) return false;
            if (this.Statistic != input.Statistic) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;

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
                if (this.ActionEnabled != null) hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                if (this.AlarmActions != null) hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.AlarmAdvice != null) hashCode = hashCode * 59 + this.AlarmAdvice.GetHashCode();
                if (this.AlarmDescription != null) hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmRuleName != null) hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.EvaluationPeriods != null) hashCode = hashCode * 59 + this.EvaluationPeriods.GetHashCode();
                if (this.IsTurnOn != null) hashCode = hashCode * 59 + this.IsTurnOn.GetHashCode();
                if (this.InsufficientDataActions != null) hashCode = hashCode * 59 + this.InsufficientDataActions.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.OkActions != null) hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                hashCode = hashCode * 59 + this.Statistic.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
