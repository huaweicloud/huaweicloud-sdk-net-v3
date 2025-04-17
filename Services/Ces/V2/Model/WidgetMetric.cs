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
    public class WidgetMetric 
    {
        /// <summary>
        /// 排序字段，asc正序，desc倒序
        /// </summary>
        /// <value>排序字段，asc正序，desc倒序</value>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("desc");

            private static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public OrderEnum()
            {

            }

            public OrderEnum(string value)
            {
                _value = value;
            }

            public static OrderEnum FromValue(string value)
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

                if (this.Equals(obj as OrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderEnum a, OrderEnum b)
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

            public static bool operator !=(OrderEnum a, OrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 服务维度
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public DimensionInfo Dimensions { get; set; }

        /// <summary>
        /// 多个指标名称，用逗号隔开
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 监控视图的指标别名列表
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 是否开启聚合
        /// </summary>
        [JsonProperty("rollup_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RollupEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rollup_filter", NullValueHandling = NullValueHandling.Ignore)]
        public RollupFilter RollupFilter { get; set; }
        /// <summary>
        /// 聚合维度
        /// </summary>
        [JsonProperty("rollup_dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string RollupDimension { get; set; }

        /// <summary>
        /// 是否展示同比（上周同一时间）数据，true:展示，false:不展示
        /// </summary>
        [JsonProperty("last_week_compare_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LastWeekCompareEnable { get; set; }

        /// <summary>
        /// 是否展示环比（昨天同一时间）数据，true:展示，false:不展示
        /// </summary>
        [JsonProperty("yesterday_compare_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? YesterdayCompareEnable { get; set; }

        /// <summary>
        /// 维度名称，多维度用逗号分隔，各服务支持的维度可参考：“[服务维度名称](ces_03_0059.xml)”
        /// </summary>
        [JsonProperty("metric_dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricDimension { get; set; }

        /// <summary>
        /// 展示数据数量
        /// </summary>
        [JsonProperty("top_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopNum { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 排序字段，asc正序，desc倒序
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// 资源的监控指标名称，必须以字母开头，只能包含0-9/a-z/A-Z/_，字符长度最短为1，最大为64；如：弹性云服务器中的监控指标cpu_util，表示弹性服务器的CPU使用率；文档数据库中的指标mongo001_command_ps，表示command执行频率；各服务的指标名称可查看：“[服务指标名称](ces_03_0059.xml)”。
        /// </summary>
        [JsonProperty("topn_metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopnMetricName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WidgetMetric {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  rollupEnable: ").Append(RollupEnable).Append("\n");
            sb.Append("  rollupFilter: ").Append(RollupFilter).Append("\n");
            sb.Append("  rollupDimension: ").Append(RollupDimension).Append("\n");
            sb.Append("  lastWeekCompareEnable: ").Append(LastWeekCompareEnable).Append("\n");
            sb.Append("  yesterdayCompareEnable: ").Append(YesterdayCompareEnable).Append("\n");
            sb.Append("  metricDimension: ").Append(MetricDimension).Append("\n");
            sb.Append("  topNum: ").Append(TopNum).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  topnMetricName: ").Append(TopnMetricName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WidgetMetric);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WidgetMetric input)
        {
            if (input == null) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && !this.Dimensions.Equals(input.Dimensions))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && input.Alias != null && !this.Alias.SequenceEqual(input.Alias))) return false;
            if (this.ExtraInfo != input.ExtraInfo || (this.ExtraInfo != null && !this.ExtraInfo.Equals(input.ExtraInfo))) return false;
            if (this.RollupEnable != input.RollupEnable || (this.RollupEnable != null && !this.RollupEnable.Equals(input.RollupEnable))) return false;
            if (this.RollupFilter != input.RollupFilter) return false;
            if (this.RollupDimension != input.RollupDimension || (this.RollupDimension != null && !this.RollupDimension.Equals(input.RollupDimension))) return false;
            if (this.LastWeekCompareEnable != input.LastWeekCompareEnable || (this.LastWeekCompareEnable != null && !this.LastWeekCompareEnable.Equals(input.LastWeekCompareEnable))) return false;
            if (this.YesterdayCompareEnable != input.YesterdayCompareEnable || (this.YesterdayCompareEnable != null && !this.YesterdayCompareEnable.Equals(input.YesterdayCompareEnable))) return false;
            if (this.MetricDimension != input.MetricDimension || (this.MetricDimension != null && !this.MetricDimension.Equals(input.MetricDimension))) return false;
            if (this.TopNum != input.TopNum || (this.TopNum != null && !this.TopNum.Equals(input.TopNum))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Order != input.Order) return false;
            if (this.TopnMetricName != input.TopnMetricName || (this.TopnMetricName != null && !this.TopnMetricName.Equals(input.TopnMetricName))) return false;

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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.ExtraInfo != null) hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.RollupEnable != null) hashCode = hashCode * 59 + this.RollupEnable.GetHashCode();
                hashCode = hashCode * 59 + this.RollupFilter.GetHashCode();
                if (this.RollupDimension != null) hashCode = hashCode * 59 + this.RollupDimension.GetHashCode();
                if (this.LastWeekCompareEnable != null) hashCode = hashCode * 59 + this.LastWeekCompareEnable.GetHashCode();
                if (this.YesterdayCompareEnable != null) hashCode = hashCode * 59 + this.YesterdayCompareEnable.GetHashCode();
                if (this.MetricDimension != null) hashCode = hashCode * 59 + this.MetricDimension.GetHashCode();
                if (this.TopNum != null) hashCode = hashCode * 59 + this.TopNum.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.TopnMetricName != null) hashCode = hashCode * 59 + this.TopnMetricName.GetHashCode();
                return hashCode;
            }
        }
    }
}
