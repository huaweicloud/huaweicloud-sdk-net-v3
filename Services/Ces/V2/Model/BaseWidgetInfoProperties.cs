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
    /// **参数解释** 额外信息 **约束限制** 不涉及 
    /// </summary>
    public class BaseWidgetInfoProperties 
    {
        /// <summary>
        /// **参数解释** 聚合类型 **约束限制** 折线图不支持该参数 **取值范围** 目前只有TopN这一种类型 **默认取值** 不涉及 
        /// </summary>
        /// <value>**参数解释** 聚合类型 **约束限制** 折线图不支持该参数 **取值范围** 目前只有TopN这一种类型 **默认取值** 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<FilterEnum>))]
        public class FilterEnum
        {
            /// <summary>
            /// Enum TOPN for value: topN
            /// </summary>
            public static readonly FilterEnum TOPN = new FilterEnum("topN");

            private static readonly Dictionary<string, FilterEnum> StaticFields =
            new Dictionary<string, FilterEnum>()
            {
                { "topN", TOPN },
            };

            private string _value;

            public FilterEnum()
            {

            }

            public FilterEnum(string value)
            {
                _value = value;
            }

            public static FilterEnum FromValue(string value)
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

                if (this.Equals(obj as FilterEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilterEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FilterEnum a, FilterEnum b)
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

            public static bool operator !=(FilterEnum a, FilterEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 排序字段 **约束限制** 折线图不支持该参数   **取值范围** - asc:正序 - desc:倒序 **默认取值** 不涉及 
        /// </summary>
        /// <value>**参数解释** 排序字段 **约束限制** 折线图不支持该参数   **取值范围** - asc:正序 - desc:倒序 **默认取值** 不涉及 </value>
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
        /// **参数解释** 图例位置标记 **约束限制** 表格不支持该参数                 **取值范围** - hide:表示隐藏图例 - right:表示图例放在监控视图右侧 - bottom:表示图例放在监控视图底部 **默认取值** 不涉及 
        /// </summary>
        /// <value>**参数解释** 图例位置标记 **约束限制** 表格不支持该参数                 **取值范围** - hide:表示隐藏图例 - right:表示图例放在监控视图右侧 - bottom:表示图例放在监控视图底部 **默认取值** 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<LegendLocationEnum>))]
        public class LegendLocationEnum
        {
            /// <summary>
            /// Enum HIDE for value: hide
            /// </summary>
            public static readonly LegendLocationEnum HIDE = new LegendLocationEnum("hide");

            /// <summary>
            /// Enum RIGHT for value: right
            /// </summary>
            public static readonly LegendLocationEnum RIGHT = new LegendLocationEnum("right");

            /// <summary>
            /// Enum BOTTOM for value: bottom
            /// </summary>
            public static readonly LegendLocationEnum BOTTOM = new LegendLocationEnum("bottom");

            private static readonly Dictionary<string, LegendLocationEnum> StaticFields =
            new Dictionary<string, LegendLocationEnum>()
            {
                { "hide", HIDE },
                { "right", RIGHT },
                { "bottom", BOTTOM },
            };

            private string _value;

            public LegendLocationEnum()
            {

            }

            public LegendLocationEnum(string value)
            {
                _value = value;
            }

            public static LegendLocationEnum FromValue(string value)
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

                if (this.Equals(obj as LegendLocationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LegendLocationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LegendLocationEnum a, LegendLocationEnum b)
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

            public static bool operator !=(LegendLocationEnum a, LegendLocationEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 统计值名称 **约束限制** 不涉及 **取值范围** - last:当前值 - max:最大值 - min:最小值 - avg:平均值 - sum:求和值 **默认取值** 不涉及 
        /// </summary>
        /// <value>**参数解释** 统计值名称 **约束限制** 不涉及 **取值范围** - last:当前值 - max:最大值 - min:最小值 - avg:平均值 - sum:求和值 **默认取值** 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<LegendValuesEnum>))]
        public class LegendValuesEnum
        {
            /// <summary>
            /// Enum LAST for value: last
            /// </summary>
            public static readonly LegendValuesEnum LAST = new LegendValuesEnum("last");

            /// <summary>
            /// Enum MAX for value: max
            /// </summary>
            public static readonly LegendValuesEnum MAX = new LegendValuesEnum("max");

            /// <summary>
            /// Enum MIN for value: min
            /// </summary>
            public static readonly LegendValuesEnum MIN = new LegendValuesEnum("min");

            /// <summary>
            /// Enum AVG for value: avg
            /// </summary>
            public static readonly LegendValuesEnum AVG = new LegendValuesEnum("avg");

            /// <summary>
            /// Enum SUM for value: sum
            /// </summary>
            public static readonly LegendValuesEnum SUM = new LegendValuesEnum("sum");

            private static readonly Dictionary<string, LegendValuesEnum> StaticFields =
            new Dictionary<string, LegendValuesEnum>()
            {
                { "last", LAST },
                { "max", MAX },
                { "min", MIN },
                { "avg", AVG },
                { "sum", SUM },
            };

            private string _value;

            public LegendValuesEnum()
            {

            }

            public LegendValuesEnum(string value)
            {
                _value = value;
            }

            public static LegendValuesEnum FromValue(string value)
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

                if (this.Equals(obj as LegendValuesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LegendValuesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LegendValuesEnum a, LegendValuesEnum b)
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

            public static bool operator !=(LegendValuesEnum a, LegendValuesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// **参数解释** 聚合类型 **约束限制** 折线图不支持该参数 **取值范围** 目前只有TopN这一种类型 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public FilterEnum Filter { get; set; }
        /// <summary>
        /// **参数解释** Top前N个；折线图时为随机展示的时序数据条数 **约束限制** 不涉及               **取值范围** 最小值为1，最大值为2147483647 **默认取值** 100 
        /// </summary>
        [JsonProperty("topN", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopN { get; set; }

        /// <summary>
        /// **参数解释** 排序字段 **约束限制** 折线图不支持该参数   **取值范围** - asc:正序 - desc:倒序 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// **参数解释** 监控视图的描述信息 **约束限制** 不涉及                 **取值范围** 长度为[0,200]个字符 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释** 是否展示同比（上周同一时间）数据 **约束限制** 不涉及                 **取值范围** - true:展示 - false:不展示 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("last_week_compare_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LastWeekCompareEnable { get; set; }

        /// <summary>
        /// **参数解释** 是否展示环比（昨天同一时间）数据 **约束限制** 不涉及                 **取值范围** - true:展示 - false:不展示 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("yesterday_compare_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? YesterdayCompareEnable { get; set; }

        /// <summary>
        /// **参数解释** 图例位置标记 **约束限制** 表格不支持该参数                 **取值范围** - hide:表示隐藏图例 - right:表示图例放在监控视图右侧 - bottom:表示图例放在监控视图底部 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("legend_location", NullValueHandling = NullValueHandling.Ignore)]
        public LegendLocationEnum LegendLocation { get; set; }
        /// <summary>
        /// **参数解释** 当前时序数据需要在图例中展示的统计值名称列表 **约束限制** 表格不支持该参数；条形图和柱状图仅支持配置当前值 
        /// </summary>
        [JsonProperty("legend_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<LegendValuesEnum> LegendValues { get; set; }
        /// <summary>
        /// **参数解释** 监控视图的阈值辅助线配置 **约束限制** 不涉及 
        /// </summary>
        [JsonProperty("thresholds", NullValueHandling = NullValueHandling.Ignore)]
        public List<ThresholdInfo> Thresholds { get; set; }

        /// <summary>
        /// **参数解释** 同比环比总开关是否生效 **约束限制** 不涉及               **取值范围** - true:生效 - false:不生效 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("is_all_compare_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAllCompareEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseWidgetInfoProperties {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  topN: ").Append(TopN).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  lastWeekCompareEnable: ").Append(LastWeekCompareEnable).Append("\n");
            sb.Append("  yesterdayCompareEnable: ").Append(YesterdayCompareEnable).Append("\n");
            sb.Append("  legendLocation: ").Append(LegendLocation).Append("\n");
            sb.Append("  legendValues: ").Append(LegendValues).Append("\n");
            sb.Append("  thresholds: ").Append(Thresholds).Append("\n");
            sb.Append("  isAllCompareEnable: ").Append(IsAllCompareEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseWidgetInfoProperties);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseWidgetInfoProperties input)
        {
            if (input == null) return false;
            if (this.Filter != input.Filter) return false;
            if (this.TopN != input.TopN || (this.TopN != null && !this.TopN.Equals(input.TopN))) return false;
            if (this.Order != input.Order) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LastWeekCompareEnable != input.LastWeekCompareEnable || (this.LastWeekCompareEnable != null && !this.LastWeekCompareEnable.Equals(input.LastWeekCompareEnable))) return false;
            if (this.YesterdayCompareEnable != input.YesterdayCompareEnable || (this.YesterdayCompareEnable != null && !this.YesterdayCompareEnable.Equals(input.YesterdayCompareEnable))) return false;
            if (this.LegendLocation != input.LegendLocation) return false;
            if (this.LegendValues != input.LegendValues || (this.LegendValues != null && input.LegendValues != null && !this.LegendValues.SequenceEqual(input.LegendValues))) return false;
            if (this.Thresholds != input.Thresholds || (this.Thresholds != null && input.Thresholds != null && !this.Thresholds.SequenceEqual(input.Thresholds))) return false;
            if (this.IsAllCompareEnable != input.IsAllCompareEnable || (this.IsAllCompareEnable != null && !this.IsAllCompareEnable.Equals(input.IsAllCompareEnable))) return false;

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
                hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.TopN != null) hashCode = hashCode * 59 + this.TopN.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastWeekCompareEnable != null) hashCode = hashCode * 59 + this.LastWeekCompareEnable.GetHashCode();
                if (this.YesterdayCompareEnable != null) hashCode = hashCode * 59 + this.YesterdayCompareEnable.GetHashCode();
                hashCode = hashCode * 59 + this.LegendLocation.GetHashCode();
                hashCode = hashCode * 59 + this.LegendValues.GetHashCode();
                if (this.Thresholds != null) hashCode = hashCode * 59 + this.Thresholds.GetHashCode();
                if (this.IsAllCompareEnable != null) hashCode = hashCode * 59 + this.IsAllCompareEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
