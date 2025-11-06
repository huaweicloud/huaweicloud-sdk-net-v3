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
    /// 
    /// </summary>
    public class TemplateTriggerCondition 
    {
        /// <summary>
        /// 指标查询模式。 - “AOM”：AOM原生 - “PROM”：AOM Prometheus - “NATIVE_PROM”：原生Prometheus
        /// </summary>
        /// <value>指标查询模式。 - “AOM”：AOM原生 - “PROM”：AOM Prometheus - “NATIVE_PROM”：原生Prometheus</value>
        [JsonConverter(typeof(EnumClassConverter<MetricQueryModeEnum>))]
        public class MetricQueryModeEnum
        {
            /// <summary>
            /// Enum AOM for value: AOM
            /// </summary>
            public static readonly MetricQueryModeEnum AOM = new MetricQueryModeEnum("AOM");

            /// <summary>
            /// Enum PROM for value: PROM
            /// </summary>
            public static readonly MetricQueryModeEnum PROM = new MetricQueryModeEnum("PROM");

            /// <summary>
            /// Enum NATIVE_PROM for value: NATIVE_PROM
            /// </summary>
            public static readonly MetricQueryModeEnum NATIVE_PROM = new MetricQueryModeEnum("NATIVE_PROM");

            private static readonly Dictionary<string, MetricQueryModeEnum> StaticFields =
            new Dictionary<string, MetricQueryModeEnum>()
            {
                { "AOM", AOM },
                { "PROM", PROM },
                { "NATIVE_PROM", NATIVE_PROM },
            };

            private string _value;

            public MetricQueryModeEnum()
            {

            }

            public MetricQueryModeEnum(string value)
            {
                _value = value;
            }

            public static MetricQueryModeEnum FromValue(string value)
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

                if (this.Equals(obj as MetricQueryModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MetricQueryModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MetricQueryModeEnum a, MetricQueryModeEnum b)
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

            public static bool operator !=(MetricQueryModeEnum a, MetricQueryModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 触发频率的类型： - “FIXED_RATE”：固定间隔 - “HOURLY”：每小时 - “DAILY”：每天 - “WEEKLY”：每周 - “CRON”：Cron表达式
        /// </summary>
        /// <value>触发频率的类型： - “FIXED_RATE”：固定间隔 - “HOURLY”：每小时 - “DAILY”：每天 - “WEEKLY”：每周 - “CRON”：Cron表达式</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerTypeEnum>))]
        public class TriggerTypeEnum
        {
            /// <summary>
            /// Enum FIXED_RATE for value: FIXED_RATE
            /// </summary>
            public static readonly TriggerTypeEnum FIXED_RATE = new TriggerTypeEnum("FIXED_RATE");

            /// <summary>
            /// Enum HOURLY for value: HOURLY
            /// </summary>
            public static readonly TriggerTypeEnum HOURLY = new TriggerTypeEnum("HOURLY");

            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            public static readonly TriggerTypeEnum DAILY = new TriggerTypeEnum("DAILY");

            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            public static readonly TriggerTypeEnum WEEKLY = new TriggerTypeEnum("WEEKLY");

            /// <summary>
            /// Enum CRON for value: CRON
            /// </summary>
            public static readonly TriggerTypeEnum CRON = new TriggerTypeEnum("CRON");

            private static readonly Dictionary<string, TriggerTypeEnum> StaticFields =
            new Dictionary<string, TriggerTypeEnum>()
            {
                { "FIXED_RATE", FIXED_RATE },
                { "HOURLY", HOURLY },
                { "DAILY", DAILY },
                { "WEEKLY", WEEKLY },
                { "CRON", CRON },
            };

            private string _value;

            public TriggerTypeEnum()
            {

            }

            public TriggerTypeEnum(string value)
            {
                _value = value;
            }

            public static TriggerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerTypeEnum a, TriggerTypeEnum b)
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

            public static bool operator !=(TriggerTypeEnum a, TriggerTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 聚合方式。 - “by”：不分组 - “avg” - “max” - “min” - “sum”
        /// </summary>
        /// <value>聚合方式。 - “by”：不分组 - “avg” - “max” - “min” - “sum”</value>
        [JsonConverter(typeof(EnumClassConverter<AggregateTypeEnum>))]
        public class AggregateTypeEnum
        {
            /// <summary>
            /// Enum BY for value: by
            /// </summary>
            public static readonly AggregateTypeEnum BY = new AggregateTypeEnum("by");

            /// <summary>
            /// Enum AVG for value: avg
            /// </summary>
            public static readonly AggregateTypeEnum AVG = new AggregateTypeEnum("avg");

            /// <summary>
            /// Enum MAX for value: max
            /// </summary>
            public static readonly AggregateTypeEnum MAX = new AggregateTypeEnum("max");

            /// <summary>
            /// Enum MIN for value: min
            /// </summary>
            public static readonly AggregateTypeEnum MIN = new AggregateTypeEnum("min");

            /// <summary>
            /// Enum SUM for value: sum
            /// </summary>
            public static readonly AggregateTypeEnum SUM = new AggregateTypeEnum("sum");

            private static readonly Dictionary<string, AggregateTypeEnum> StaticFields =
            new Dictionary<string, AggregateTypeEnum>()
            {
                { "by", BY },
                { "avg", AVG },
                { "max", MAX },
                { "min", MIN },
                { "sum", SUM },
            };

            private string _value;

            public AggregateTypeEnum()
            {

            }

            public AggregateTypeEnum(string value)
            {
                _value = value;
            }

            public static AggregateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AggregateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AggregateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AggregateTypeEnum a, AggregateTypeEnum b)
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

            public static bool operator !=(AggregateTypeEnum a, AggregateTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 当配置方式为全量指标时可选择的指标运算方式。 - “single”：单个指标进行运算 - “mix”：多个指标进行混合运算
        /// </summary>
        /// <value>当配置方式为全量指标时可选择的指标运算方式。 - “single”：单个指标进行运算 - “mix”：多个指标进行混合运算</value>
        [JsonConverter(typeof(EnumClassConverter<MetricStatisticMethodEnum>))]
        public class MetricStatisticMethodEnum
        {
            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly MetricStatisticMethodEnum SINGLE = new MetricStatisticMethodEnum("single");

            /// <summary>
            /// Enum MIX for value: mix
            /// </summary>
            public static readonly MetricStatisticMethodEnum MIX = new MetricStatisticMethodEnum("mix");

            private static readonly Dictionary<string, MetricStatisticMethodEnum> StaticFields =
            new Dictionary<string, MetricStatisticMethodEnum>()
            {
                { "single", SINGLE },
                { "mix", MIX },
            };

            private string _value;

            public MetricStatisticMethodEnum()
            {

            }

            public MetricStatisticMethodEnum(string value)
            {
                _value = value;
            }

            public static MetricStatisticMethodEnum FromValue(string value)
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

                if (this.Equals(obj as MetricStatisticMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MetricStatisticMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MetricStatisticMethodEnum a, MetricStatisticMethodEnum b)
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

            public static bool operator !=(MetricStatisticMethodEnum a, MetricStatisticMethodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指标查询模式。 - “AOM”：AOM原生 - “PROM”：AOM Prometheus - “NATIVE_PROM”：原生Prometheus
        /// </summary>
        [JsonProperty("metric_query_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MetricQueryModeEnum MetricQueryMode { get; set; }
        /// <summary>
        /// 指标命名空间。
        /// </summary>
        [JsonProperty("metric_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricNamespace { get; set; }

        /// <summary>
        /// 指标名称。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标单位。
        /// </summary>
        [JsonProperty("metric_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricUnit { get; set; }

        /// <summary>
        /// 指标维度。
        /// </summary>
        [JsonProperty("metric_labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MetricLabels { get; set; }

        /// <summary>
        /// Prometheus语句。
        /// </summary>
        [JsonProperty("promql", NullValueHandling = NullValueHandling.Ignore)]
        public string Promql { get; set; }

        /// <summary>
        /// Prometheus语句模板。
        /// </summary>
        [JsonProperty("promql_expr", NullValueHandling = NullValueHandling.Ignore)]
        public string PromqlExpr { get; set; }

        /// <summary>
        /// 连续周期个数。
        /// </summary>
        [JsonProperty("trigger_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerTimes { get; set; }

        /// <summary>
        /// 检查频率周期。 - 当trigger_type 为“HOURLY”时，填“” - 当trigger_type为“DAILY”时，格式为：“小时” 。例如每天凌晨三点\&quot;03:00\&quot;。 - 当trigger_type为“WEEKLY”时，格式为：“星期 小时”。例如每周一凌晨三点 “1 03:00”。 - 当trigger_type为“CRON”时，格式为标准CRON表达式。 - 当trigger_type为“FIXED_RATE”时，秒的取值为15s，30s，分钟为 1~59，小时为 1~24。例如“15s”，“30s”，“1min”，“1h”。
        /// </summary>
        [JsonProperty("trigger_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerInterval { get; set; }

        /// <summary>
        /// 触发频率的类型： - “FIXED_RATE”：固定间隔 - “HOURLY”：每小时 - “DAILY”：每天 - “WEEKLY”：每周 - “CRON”：Cron表达式
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeEnum TriggerType { get; set; }
        /// <summary>
        /// 持续时间。 持续时间范围： - “0”：立即 - “15s”：15秒 - “30s”：30秒 - “1m”：1分钟
        /// </summary>
        [JsonProperty("promql_for", NullValueHandling = NullValueHandling.Ignore)]
        public string PromqlFor { get; set; }

        /// <summary>
        /// 检测规则： - average：平均值 - minimum：最小值 - maximum：最大值 - sum：总计 - sampleCount：样本
        /// </summary>
        [JsonProperty("aggregation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregationType { get; set; }

        /// <summary>
        /// 判断条件：“&gt;”,“&lt;”,“&#x3D;”,“&gt;&#x3D;”,“&lt;&#x3D;”
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 键值对形式，键为告警级别，值为告警阈值
        /// </summary>
        [JsonProperty("thresholds", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Thresholds { get; set; }

        /// <summary>
        /// 统计周期。 - “15s”：15秒 - “30s”：30秒 - “1m”：1分钟 - “5m”：5分钟 - “15m”：15分钟 - “1h”：1小时
        /// </summary>
        [JsonProperty("aggregation_window", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregationWindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cmdb", NullValueHandling = NullValueHandling.Ignore)]
        public CmdbInfo Cmdb { get; set; }

        /// <summary>
        /// 查询筛选条件。
        /// </summary>
        [JsonProperty("query_match", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryMatch { get; set; }

        /// <summary>
        /// 监控层级。
        /// </summary>
        [JsonProperty("aom_monitor_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AomMonitorLevel { get; set; }

        /// <summary>
        /// 聚合方式。 - “by”：不分组 - “avg” - “max” - “min” - “sum”
        /// </summary>
        [JsonProperty("aggregate_type", NullValueHandling = NullValueHandling.Ignore)]
        public AggregateTypeEnum AggregateType { get; set; }
        /// <summary>
        /// 当配置方式为全量指标时可选择的指标运算方式。 - “single”：单个指标进行运算 - “mix”：多个指标进行混合运算
        /// </summary>
        [JsonProperty("metric_statistic_method", NullValueHandling = NullValueHandling.Ignore)]
        public MetricStatisticMethodEnum MetricStatisticMethod { get; set; }
        /// <summary>
        /// 混合运算的表达式。
        /// </summary>
        [JsonProperty("expression", NullValueHandling = NullValueHandling.Ignore)]
        public string Expression { get; set; }

        /// <summary>
        /// 混合运算的promQL。
        /// </summary>
        [JsonProperty("mix_promql", NullValueHandling = NullValueHandling.Ignore)]
        public string MixPromql { get; set; }

        /// <summary>
        /// 通知内容。
        /// </summary>
        [JsonProperty("alarm_message_template", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmMessageTemplate { get; set; }

        /// <summary>
        /// Prometheus监控模板。默认为cluster。
        /// </summary>
        [JsonProperty("promql_monitor_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PromqlMonitorTemplates { get; set; }

        /// <summary>
        /// - PromQL告警规则，该参数为\&quot;{\\\&quot;defaultRule\\\&quot;:{\\\&quot;label\\\&quot;:\\\&quot;自定义\\\&quot;,\\\&quot;id\\\&quot;:\\\&quot;custom\\\&quot;},\\\&quot;templateSelectd\\\&quot;:null,\\\&quot;dimensionsList\\\&quot;:[]}\&quot; - 阈值告警规则，该参数为空。
        /// </summary>
        [JsonProperty("query_param", NullValueHandling = NullValueHandling.Ignore)]
        public Object QueryParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateTriggerCondition {\n");
            sb.Append("  metricQueryMode: ").Append(MetricQueryMode).Append("\n");
            sb.Append("  metricNamespace: ").Append(MetricNamespace).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  metricUnit: ").Append(MetricUnit).Append("\n");
            sb.Append("  metricLabels: ").Append(MetricLabels).Append("\n");
            sb.Append("  promql: ").Append(Promql).Append("\n");
            sb.Append("  promqlExpr: ").Append(PromqlExpr).Append("\n");
            sb.Append("  triggerTimes: ").Append(TriggerTimes).Append("\n");
            sb.Append("  triggerInterval: ").Append(TriggerInterval).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  promqlFor: ").Append(PromqlFor).Append("\n");
            sb.Append("  aggregationType: ").Append(AggregationType).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  thresholds: ").Append(Thresholds).Append("\n");
            sb.Append("  aggregationWindow: ").Append(AggregationWindow).Append("\n");
            sb.Append("  cmdb: ").Append(Cmdb).Append("\n");
            sb.Append("  queryMatch: ").Append(QueryMatch).Append("\n");
            sb.Append("  aomMonitorLevel: ").Append(AomMonitorLevel).Append("\n");
            sb.Append("  aggregateType: ").Append(AggregateType).Append("\n");
            sb.Append("  metricStatisticMethod: ").Append(MetricStatisticMethod).Append("\n");
            sb.Append("  expression: ").Append(Expression).Append("\n");
            sb.Append("  mixPromql: ").Append(MixPromql).Append("\n");
            sb.Append("  alarmMessageTemplate: ").Append(AlarmMessageTemplate).Append("\n");
            sb.Append("  promqlMonitorTemplates: ").Append(PromqlMonitorTemplates).Append("\n");
            sb.Append("  queryParam: ").Append(QueryParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateTriggerCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateTriggerCondition input)
        {
            if (input == null) return false;
            if (this.MetricQueryMode != input.MetricQueryMode) return false;
            if (this.MetricNamespace != input.MetricNamespace || (this.MetricNamespace != null && !this.MetricNamespace.Equals(input.MetricNamespace))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.MetricUnit != input.MetricUnit || (this.MetricUnit != null && !this.MetricUnit.Equals(input.MetricUnit))) return false;
            if (this.MetricLabels != input.MetricLabels || (this.MetricLabels != null && input.MetricLabels != null && !this.MetricLabels.SequenceEqual(input.MetricLabels))) return false;
            if (this.Promql != input.Promql || (this.Promql != null && !this.Promql.Equals(input.Promql))) return false;
            if (this.PromqlExpr != input.PromqlExpr || (this.PromqlExpr != null && !this.PromqlExpr.Equals(input.PromqlExpr))) return false;
            if (this.TriggerTimes != input.TriggerTimes || (this.TriggerTimes != null && !this.TriggerTimes.Equals(input.TriggerTimes))) return false;
            if (this.TriggerInterval != input.TriggerInterval || (this.TriggerInterval != null && !this.TriggerInterval.Equals(input.TriggerInterval))) return false;
            if (this.TriggerType != input.TriggerType) return false;
            if (this.PromqlFor != input.PromqlFor || (this.PromqlFor != null && !this.PromqlFor.Equals(input.PromqlFor))) return false;
            if (this.AggregationType != input.AggregationType || (this.AggregationType != null && !this.AggregationType.Equals(input.AggregationType))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.Thresholds != input.Thresholds || (this.Thresholds != null && input.Thresholds != null && !this.Thresholds.SequenceEqual(input.Thresholds))) return false;
            if (this.AggregationWindow != input.AggregationWindow || (this.AggregationWindow != null && !this.AggregationWindow.Equals(input.AggregationWindow))) return false;
            if (this.Cmdb != input.Cmdb || (this.Cmdb != null && !this.Cmdb.Equals(input.Cmdb))) return false;
            if (this.QueryMatch != input.QueryMatch || (this.QueryMatch != null && !this.QueryMatch.Equals(input.QueryMatch))) return false;
            if (this.AomMonitorLevel != input.AomMonitorLevel || (this.AomMonitorLevel != null && !this.AomMonitorLevel.Equals(input.AomMonitorLevel))) return false;
            if (this.AggregateType != input.AggregateType) return false;
            if (this.MetricStatisticMethod != input.MetricStatisticMethod) return false;
            if (this.Expression != input.Expression || (this.Expression != null && !this.Expression.Equals(input.Expression))) return false;
            if (this.MixPromql != input.MixPromql || (this.MixPromql != null && !this.MixPromql.Equals(input.MixPromql))) return false;
            if (this.AlarmMessageTemplate != input.AlarmMessageTemplate || (this.AlarmMessageTemplate != null && !this.AlarmMessageTemplate.Equals(input.AlarmMessageTemplate))) return false;
            if (this.PromqlMonitorTemplates != input.PromqlMonitorTemplates || (this.PromqlMonitorTemplates != null && input.PromqlMonitorTemplates != null && !this.PromqlMonitorTemplates.SequenceEqual(input.PromqlMonitorTemplates))) return false;
            if (this.QueryParam != input.QueryParam || (this.QueryParam != null && !this.QueryParam.Equals(input.QueryParam))) return false;

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
                hashCode = hashCode * 59 + this.MetricQueryMode.GetHashCode();
                if (this.MetricNamespace != null) hashCode = hashCode * 59 + this.MetricNamespace.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.MetricUnit != null) hashCode = hashCode * 59 + this.MetricUnit.GetHashCode();
                if (this.MetricLabels != null) hashCode = hashCode * 59 + this.MetricLabels.GetHashCode();
                if (this.Promql != null) hashCode = hashCode * 59 + this.Promql.GetHashCode();
                if (this.PromqlExpr != null) hashCode = hashCode * 59 + this.PromqlExpr.GetHashCode();
                if (this.TriggerTimes != null) hashCode = hashCode * 59 + this.TriggerTimes.GetHashCode();
                if (this.TriggerInterval != null) hashCode = hashCode * 59 + this.TriggerInterval.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.PromqlFor != null) hashCode = hashCode * 59 + this.PromqlFor.GetHashCode();
                if (this.AggregationType != null) hashCode = hashCode * 59 + this.AggregationType.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Thresholds != null) hashCode = hashCode * 59 + this.Thresholds.GetHashCode();
                if (this.AggregationWindow != null) hashCode = hashCode * 59 + this.AggregationWindow.GetHashCode();
                if (this.Cmdb != null) hashCode = hashCode * 59 + this.Cmdb.GetHashCode();
                if (this.QueryMatch != null) hashCode = hashCode * 59 + this.QueryMatch.GetHashCode();
                if (this.AomMonitorLevel != null) hashCode = hashCode * 59 + this.AomMonitorLevel.GetHashCode();
                hashCode = hashCode * 59 + this.AggregateType.GetHashCode();
                hashCode = hashCode * 59 + this.MetricStatisticMethod.GetHashCode();
                if (this.Expression != null) hashCode = hashCode * 59 + this.Expression.GetHashCode();
                if (this.MixPromql != null) hashCode = hashCode * 59 + this.MixPromql.GetHashCode();
                if (this.AlarmMessageTemplate != null) hashCode = hashCode * 59 + this.AlarmMessageTemplate.GetHashCode();
                if (this.PromqlMonitorTemplates != null) hashCode = hashCode * 59 + this.PromqlMonitorTemplates.GetHashCode();
                if (this.QueryParam != null) hashCode = hashCode * 59 + this.QueryParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
