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
    public class AlarmTemplatePolicies 
    {
        /// <summary>
        /// 告警条件判断周期,单位为秒
        /// </summary>
        /// <value>告警条件判断周期,单位为秒</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodEnum>))]
        public class PeriodEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly PeriodEnum NUMBER_1 = new PeriodEnum(1);

            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            public static readonly PeriodEnum NUMBER_300 = new PeriodEnum(300);

            /// <summary>
            /// Enum NUMBER_1200 for value: 1200
            /// </summary>
            public static readonly PeriodEnum NUMBER_1200 = new PeriodEnum(1200);

            /// <summary>
            /// Enum NUMBER_3600 for value: 3600
            /// </summary>
            public static readonly PeriodEnum NUMBER_3600 = new PeriodEnum(3600);

            /// <summary>
            /// Enum NUMBER_14400 for value: 14400
            /// </summary>
            public static readonly PeriodEnum NUMBER_14400 = new PeriodEnum(14400);

            /// <summary>
            /// Enum NUMBER_86400 for value: 86400
            /// </summary>
            public static readonly PeriodEnum NUMBER_86400 = new PeriodEnum(86400);

            private static readonly Dictionary<int?, PeriodEnum> StaticFields =
            new Dictionary<int?, PeriodEnum>()
            {
                { 1, NUMBER_1 },
                { 300, NUMBER_300 },
                { 1200, NUMBER_1200 },
                { 3600, NUMBER_3600 },
                { 14400, NUMBER_14400 },
                { 86400, NUMBER_86400 },
            };

            private int? Value;

            public PeriodEnum(int? value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 告警抑制周期，单位为秒，当告警抑制周期为0时，仅发送一次告警
        /// </summary>
        /// <value>告警抑制周期，单位为秒，当告警抑制周期为0时，仅发送一次告警</value>
        [JsonConverter(typeof(EnumClassConverter<SuppressDurationEnum>))]
        public class SuppressDurationEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_0 = new SuppressDurationEnum(0);

            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_300 = new SuppressDurationEnum(300);

            /// <summary>
            /// Enum NUMBER_600 for value: 600
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_600 = new SuppressDurationEnum(600);

            /// <summary>
            /// Enum NUMBER_900 for value: 900
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_900 = new SuppressDurationEnum(900);

            /// <summary>
            /// Enum NUMBER_1800 for value: 1800
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_1800 = new SuppressDurationEnum(1800);

            /// <summary>
            /// Enum NUMBER_3600 for value: 3600
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_3600 = new SuppressDurationEnum(3600);

            /// <summary>
            /// Enum NUMBER_10800 for value: 10800
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_10800 = new SuppressDurationEnum(10800);

            /// <summary>
            /// Enum NUMBER_21600 for value: 21600
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_21600 = new SuppressDurationEnum(21600);

            /// <summary>
            /// Enum NUMBER_43200 for value: 43200
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_43200 = new SuppressDurationEnum(43200);

            /// <summary>
            /// Enum NUMBER_86400 for value: 86400
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_86400 = new SuppressDurationEnum(86400);

            private static readonly Dictionary<int?, SuppressDurationEnum> StaticFields =
            new Dictionary<int?, SuppressDurationEnum>()
            {
                { 0, NUMBER_0 },
                { 300, NUMBER_300 },
                { 600, NUMBER_600 },
                { 900, NUMBER_900 },
                { 1800, NUMBER_1800 },
                { 3600, NUMBER_3600 },
                { 10800, NUMBER_10800 },
                { 21600, NUMBER_21600 },
                { 43200, NUMBER_43200 },
                { 86400, NUMBER_86400 },
            };

            private int? Value;

            public SuppressDurationEnum(int? value)
            {
                Value = value;
            }

            public static SuppressDurationEnum FromValue(int? value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as SuppressDurationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SuppressDurationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(SuppressDurationEnum a, SuppressDurationEnum b)
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

            public static bool operator !=(SuppressDurationEnum a, SuppressDurationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 资源维度，必须以字母开头，多维度用\&quot;,\&quot;分割，只能包含0-9/a-z/A-Z/_/-，每个维度的最大长度为32
        /// </summary>
        [JsonProperty("dimension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionName { get; set; }

        /// <summary>
        /// 资源的监控指标名称，必须以字母开头，只能包含0-9/a-z/A-Z/_，字符长度最短为1，最大为64；如：弹性云服务器中的监控指标cpu_util，表示弹性服务器的CPU使用率；文档数据库中的指标mongo001_command_ps，表示command执行频率；各服务的指标名称可查看：“[服务指标名称](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 告警条件判断周期,单位为秒
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }
        /// <summary>
        /// 数据聚合方式
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 告警阈值的比较条件
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 告警阈值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Value { get; set; }

        /// <summary>
        /// 数据的单位字符串，长度不超过32
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 告警连续触发次数，正整数[1, 5]
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 告警级别，1为紧急，2为重要，3为次要，4为提示
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        /// <summary>
        /// 告警抑制周期，单位为秒，当告警抑制周期为0时，仅发送一次告警
        /// </summary>
        [JsonProperty("suppress_duration", NullValueHandling = NullValueHandling.Ignore)]
        public SuppressDurationEnum SuppressDuration { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmTemplatePolicies {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dimensionName: ").Append(DimensionName).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  suppressDuration: ").Append(SuppressDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmTemplatePolicies);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmTemplatePolicies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.DimensionName == input.DimensionName ||
                    (this.DimensionName != null &&
                    this.DimensionName.Equals(input.DimensionName))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.ComparisonOperator == input.ComparisonOperator ||
                    (this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(input.ComparisonOperator))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
                ) && 
                (
                    this.SuppressDuration == input.SuppressDuration ||
                    (this.SuppressDuration != null &&
                    this.SuppressDuration.Equals(input.SuppressDuration))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.DimensionName != null)
                    hashCode = hashCode * 59 + this.DimensionName.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ComparisonOperator != null)
                    hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.SuppressDuration != null)
                    hashCode = hashCode * 59 + this.SuppressDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
