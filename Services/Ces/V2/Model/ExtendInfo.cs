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
    /// 看板相关拓展信息
    /// </summary>
    public class ExtendInfo 
    {
        /// <summary>
        /// 表示指标聚合方式，average表示平均值，min表示最小值，max表示最大值，sum表示求合
        /// </summary>
        /// <value>表示指标聚合方式，average表示平均值，min表示最小值，max表示最大值，sum表示求合</value>
        [JsonConverter(typeof(EnumClassConverter<FilterEnum>))]
        public class FilterEnum
        {
            /// <summary>
            /// Enum AVERAGE for value: average
            /// </summary>
            public static readonly FilterEnum AVERAGE = new FilterEnum("average");

            /// <summary>
            /// Enum MIN for value: min
            /// </summary>
            public static readonly FilterEnum MIN = new FilterEnum("min");

            /// <summary>
            /// Enum MAX for value: max
            /// </summary>
            public static readonly FilterEnum MAX = new FilterEnum("max");

            /// <summary>
            /// Enum SUM for value: sum
            /// </summary>
            public static readonly FilterEnum SUM = new FilterEnum("sum");

            private static readonly Dictionary<string, FilterEnum> StaticFields =
            new Dictionary<string, FilterEnum>()
            {
                { "average", AVERAGE },
                { "min", MIN },
                { "max", MAX },
                { "sum", SUM },
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

            public static bool operator !=(FilterEnum a, FilterEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 展示时间，0表示使用自定义时间展示， 5分钟，15分钟，30分钟，1小时，2小时，3小时，12小时，24小时，7天，30天
        /// </summary>
        /// <value>展示时间，0表示使用自定义时间展示， 5分钟，15分钟，30分钟，1小时，2小时，3小时，12小时，24小时，7天，30天</value>
        [JsonConverter(typeof(EnumClassConverter<DisplayTimeEnum>))]
        public class DisplayTimeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_0 = new DisplayTimeEnum(0);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_5 = new DisplayTimeEnum(5);

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_15 = new DisplayTimeEnum(15);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_30 = new DisplayTimeEnum(30);

            /// <summary>
            /// Enum NUMBER_60 for value: 60
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_60 = new DisplayTimeEnum(60);

            /// <summary>
            /// Enum NUMBER_120 for value: 120
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_120 = new DisplayTimeEnum(120);

            /// <summary>
            /// Enum NUMBER_180 for value: 180
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_180 = new DisplayTimeEnum(180);

            /// <summary>
            /// Enum NUMBER_720 for value: 720
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_720 = new DisplayTimeEnum(720);

            /// <summary>
            /// Enum NUMBER_1440 for value: 1440
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_1440 = new DisplayTimeEnum(1440);

            /// <summary>
            /// Enum NUMBER_10080 for value: 10080
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_10080 = new DisplayTimeEnum(10080);

            /// <summary>
            /// Enum NUMBER_43200 for value: 43200
            /// </summary>
            public static readonly DisplayTimeEnum NUMBER_43200 = new DisplayTimeEnum(43200);

            private static readonly Dictionary<int?, DisplayTimeEnum> StaticFields =
            new Dictionary<int?, DisplayTimeEnum>()
            {
                { 0, NUMBER_0 },
                { 5, NUMBER_5 },
                { 15, NUMBER_15 },
                { 30, NUMBER_30 },
                { 60, NUMBER_60 },
                { 120, NUMBER_120 },
                { 180, NUMBER_180 },
                { 720, NUMBER_720 },
                { 1440, NUMBER_1440 },
                { 10080, NUMBER_10080 },
                { 43200, NUMBER_43200 },
            };

            private int? _value;

            public DisplayTimeEnum()
            {

            }

            public DisplayTimeEnum(int? value)
            {
                _value = value;
            }

            public static DisplayTimeEnum FromValue(int? value)
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

                if (this.Equals(obj as DisplayTimeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DisplayTimeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DisplayTimeEnum a, DisplayTimeEnum b)
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

            public static bool operator !=(DisplayTimeEnum a, DisplayTimeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 刷新时间 0秒表示不刷新,10秒，1分钟，5分钟，20分钟
        /// </summary>
        /// <value>刷新时间 0秒表示不刷新,10秒，1分钟，5分钟，20分钟</value>
        [JsonConverter(typeof(EnumClassConverter<RefreshTimeEnum>))]
        public class RefreshTimeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly RefreshTimeEnum NUMBER_0 = new RefreshTimeEnum(0);

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            public static readonly RefreshTimeEnum NUMBER_10 = new RefreshTimeEnum(10);

            /// <summary>
            /// Enum NUMBER_60 for value: 60
            /// </summary>
            public static readonly RefreshTimeEnum NUMBER_60 = new RefreshTimeEnum(60);

            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            public static readonly RefreshTimeEnum NUMBER_300 = new RefreshTimeEnum(300);

            /// <summary>
            /// Enum NUMBER_1200 for value: 1200
            /// </summary>
            public static readonly RefreshTimeEnum NUMBER_1200 = new RefreshTimeEnum(1200);

            private static readonly Dictionary<int?, RefreshTimeEnum> StaticFields =
            new Dictionary<int?, RefreshTimeEnum>()
            {
                { 0, NUMBER_0 },
                { 10, NUMBER_10 },
                { 60, NUMBER_60 },
                { 300, NUMBER_300 },
                { 1200, NUMBER_1200 },
            };

            private int? _value;

            public RefreshTimeEnum()
            {

            }

            public RefreshTimeEnum(int? value)
            {
                _value = value;
            }

            public static RefreshTimeEnum FromValue(int? value)
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

                if (this.Equals(obj as RefreshTimeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RefreshTimeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RefreshTimeEnum a, RefreshTimeEnum b)
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

            public static bool operator !=(RefreshTimeEnum a, RefreshTimeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 监控大屏自动切换时间间隔，10000代表10s，30000代表30s，60000代表1min
        /// </summary>
        /// <value>监控大屏自动切换时间间隔，10000代表10s，30000代表30s，60000代表1min</value>
        [JsonConverter(typeof(EnumClassConverter<TimeIntervalEnum>))]
        public class TimeIntervalEnum
        {
            /// <summary>
            /// Enum NUMBER_10000 for value: 10000
            /// </summary>
            public static readonly TimeIntervalEnum NUMBER_10000 = new TimeIntervalEnum(10000);

            /// <summary>
            /// Enum NUMBER_30000 for value: 30000
            /// </summary>
            public static readonly TimeIntervalEnum NUMBER_30000 = new TimeIntervalEnum(30000);

            /// <summary>
            /// Enum NUMBER_60000 for value: 60000
            /// </summary>
            public static readonly TimeIntervalEnum NUMBER_60000 = new TimeIntervalEnum(60000);

            private static readonly Dictionary<int?, TimeIntervalEnum> StaticFields =
            new Dictionary<int?, TimeIntervalEnum>()
            {
                { 10000, NUMBER_10000 },
                { 30000, NUMBER_30000 },
                { 60000, NUMBER_60000 },
            };

            private int? _value;

            public TimeIntervalEnum()
            {

            }

            public TimeIntervalEnum(int? value)
            {
                _value = value;
            }

            public static TimeIntervalEnum FromValue(int? value)
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

                if (this.Equals(obj as TimeIntervalEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TimeIntervalEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TimeIntervalEnum a, TimeIntervalEnum b)
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

            public static bool operator !=(TimeIntervalEnum a, TimeIntervalEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 表示指标聚合方式，average表示平均值，min表示最小值，max表示最大值，sum表示求合
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public FilterEnum Filter { get; set; }
        /// <summary>
        /// &#39;表示指标聚合周期，{1:表示原始值，60:表示一分钟，300:表示5分钟，1200:表示20分钟，3600:表示1小时，14400:表示4小时，86400:表示1天}&#39;&#39; 
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 展示时间，0表示使用自定义时间展示， 5分钟，15分钟，30分钟，1小时，2小时，3小时，12小时，24小时，7天，30天
        /// </summary>
        [JsonProperty("display_time", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayTimeEnum DisplayTime { get; set; }
        /// <summary>
        /// 刷新时间 0秒表示不刷新,10秒，1分钟，5分钟，20分钟
        /// </summary>
        [JsonProperty("refresh_time", NullValueHandling = NullValueHandling.Ignore)]
        public RefreshTimeEnum RefreshTime { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }

        /// <summary>
        /// 监控大屏背景颜色
        /// </summary>
        [JsonProperty("screen_color", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenColor { get; set; }

        /// <summary>
        /// 监控大屏是否自动切换
        /// </summary>
        [JsonProperty("enable_screen_auto_play", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableScreenAutoPlay { get; set; }

        /// <summary>
        /// 监控大屏自动切换时间间隔，10000代表10s，30000代表30s，60000代表1min
        /// </summary>
        [JsonProperty("time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public TimeIntervalEnum TimeInterval { get; set; }
        /// <summary>
        /// 是否开启图例
        /// </summary>
        [JsonProperty("enable_legend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLegend { get; set; }

        /// <summary>
        /// 大屏展示视图数量, 可以取得值必须与console页面可选值保持一致
        /// </summary>
        [JsonProperty("full_screen_widget_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FullScreenWidgetNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendInfo {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  displayTime: ").Append(DisplayTime).Append("\n");
            sb.Append("  refreshTime: ").Append(RefreshTime).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  screenColor: ").Append(ScreenColor).Append("\n");
            sb.Append("  enableScreenAutoPlay: ").Append(EnableScreenAutoPlay).Append("\n");
            sb.Append("  timeInterval: ").Append(TimeInterval).Append("\n");
            sb.Append("  enableLegend: ").Append(EnableLegend).Append("\n");
            sb.Append("  fullScreenWidgetNum: ").Append(FullScreenWidgetNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtendInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtendInfo input)
        {
            if (input == null) return false;
            if (this.Filter != input.Filter) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.DisplayTime != input.DisplayTime) return false;
            if (this.RefreshTime != input.RefreshTime) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
            if (this.ScreenColor != input.ScreenColor || (this.ScreenColor != null && !this.ScreenColor.Equals(input.ScreenColor))) return false;
            if (this.EnableScreenAutoPlay != input.EnableScreenAutoPlay || (this.EnableScreenAutoPlay != null && !this.EnableScreenAutoPlay.Equals(input.EnableScreenAutoPlay))) return false;
            if (this.TimeInterval != input.TimeInterval) return false;
            if (this.EnableLegend != input.EnableLegend || (this.EnableLegend != null && !this.EnableLegend.Equals(input.EnableLegend))) return false;
            if (this.FullScreenWidgetNum != input.FullScreenWidgetNum || (this.FullScreenWidgetNum != null && !this.FullScreenWidgetNum.Equals(input.FullScreenWidgetNum))) return false;

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
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                hashCode = hashCode * 59 + this.DisplayTime.GetHashCode();
                hashCode = hashCode * 59 + this.RefreshTime.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.ScreenColor != null) hashCode = hashCode * 59 + this.ScreenColor.GetHashCode();
                if (this.EnableScreenAutoPlay != null) hashCode = hashCode * 59 + this.EnableScreenAutoPlay.GetHashCode();
                hashCode = hashCode * 59 + this.TimeInterval.GetHashCode();
                if (this.EnableLegend != null) hashCode = hashCode * 59 + this.EnableLegend.GetHashCode();
                if (this.FullScreenWidgetNum != null) hashCode = hashCode * 59 + this.FullScreenWidgetNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
