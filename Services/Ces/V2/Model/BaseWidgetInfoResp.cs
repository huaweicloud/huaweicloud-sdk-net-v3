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
    /// **参数解释** 监控视图信息 
    /// </summary>
    public class BaseWidgetInfoResp 
    {
        /// <summary>
        /// **参数解释** 监控视图图表类型 **取值范围** - bar:条形图 - line:折线图 - bar_chart:柱状图 - table:表格 - circular_bar:环形柱状图 - area_chart:面积图 
        /// </summary>
        /// <value>**参数解释** 监控视图图表类型 **取值范围** - bar:条形图 - line:折线图 - bar_chart:柱状图 - table:表格 - circular_bar:环形柱状图 - area_chart:面积图 </value>
        [JsonConverter(typeof(EnumClassConverter<ViewEnum>))]
        public class ViewEnum
        {
            /// <summary>
            /// Enum BAR for value: bar
            /// </summary>
            public static readonly ViewEnum BAR = new ViewEnum("bar");

            /// <summary>
            /// Enum LINE for value: line
            /// </summary>
            public static readonly ViewEnum LINE = new ViewEnum("line");

            /// <summary>
            /// Enum BAR_CHART for value: bar_chart
            /// </summary>
            public static readonly ViewEnum BAR_CHART = new ViewEnum("bar_chart");

            /// <summary>
            /// Enum TABLE for value: table
            /// </summary>
            public static readonly ViewEnum TABLE = new ViewEnum("table");

            /// <summary>
            /// Enum CIRCULAR_BAR for value: circular_bar
            /// </summary>
            public static readonly ViewEnum CIRCULAR_BAR = new ViewEnum("circular_bar");

            /// <summary>
            /// Enum AREA_CHART for value: area_chart
            /// </summary>
            public static readonly ViewEnum AREA_CHART = new ViewEnum("area_chart");

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "bar", BAR },
                { "line", LINE },
                { "bar_chart", BAR_CHART },
                { "table", TABLE },
                { "circular_bar", CIRCULAR_BAR },
                { "area_chart", AREA_CHART },
            };

            private string _value;

            public ViewEnum()
            {

            }

            public ViewEnum(string value)
            {
                _value = value;
            }

            public static ViewEnum FromValue(string value)
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

                if (this.Equals(obj as ViewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewEnum a, ViewEnum b)
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

            public static bool operator !=(ViewEnum a, ViewEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 指标展示类型 **取值范围** - single:单指标展示 - multiple:多指标展示 
        /// </summary>
        /// <value>**参数解释** 指标展示类型 **取值范围** - single:单指标展示 - multiple:多指标展示 </value>
        [JsonConverter(typeof(EnumClassConverter<MetricDisplayModeEnum>))]
        public class MetricDisplayModeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly MetricDisplayModeEnum SINGLE = new MetricDisplayModeEnum("single");

            /// <summary>
            /// Enum MULTIPLE for value: multiple
            /// </summary>
            public static readonly MetricDisplayModeEnum MULTIPLE = new MetricDisplayModeEnum("multiple");

            private static readonly Dictionary<string, MetricDisplayModeEnum> StaticFields =
            new Dictionary<string, MetricDisplayModeEnum>()
            {
                { "single", SINGLE },
                { "multiple", MULTIPLE },
            };

            private string _value;

            public MetricDisplayModeEnum()
            {

            }

            public MetricDisplayModeEnum(string value)
            {
                _value = value;
            }

            public static MetricDisplayModeEnum FromValue(string value)
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

                if (this.Equals(obj as MetricDisplayModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MetricDisplayModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MetricDisplayModeEnum a, MetricDisplayModeEnum b)
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

            public static bool operator !=(MetricDisplayModeEnum a, MetricDisplayModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释** 视图分组id **取值范围** 字符串必须以dg开头，包含22个字母和数字，长度为24个字符或者为default，default代表不分组 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释** 指标列表 
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<WidgetMetricResp> Metrics { get; set; }

        /// <summary>
        /// **参数解释** 监控视图标题 **取值范围** 长度为[1,128]个字符，允许包括以下内容：1、中文汉字；2、拉丁字母；3、英文大小写字母；4、数字(0-9)；5、符号： ” \&quot; ≤ &lt; &gt; &amp; % _ : / ; “ &#39; ? + , ~ ， （ ） º ( ) [ . - 
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释** 监控视图指标的阈值 **取值范围** 最小值为0，最大值为1.7976931348623157e+308 
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? Threshold { get; set; }

        /// <summary>
        /// **参数解释** 阈值是否展示 **取值范围** - true:展示 - false:不展示 
        /// </summary>
        [JsonProperty("threshold_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThresholdEnabled { get; set; }

        /// <summary>
        /// **参数解释** 监控视图图表类型 **取值范围** - bar:条形图 - line:折线图 - bar_chart:柱状图 - table:表格 - circular_bar:环形柱状图 - area_chart:面积图 
        /// </summary>
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// **参数解释** 指标展示类型 **取值范围** - single:单指标展示 - multiple:多指标展示 
        /// </summary>
        [JsonProperty("metric_display_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MetricDisplayModeEnum MetricDisplayMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public BaseWidgetInfoRespProperties Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public BaseWidgetInfoRespLocation Location { get; set; }

        /// <summary>
        /// **参数解释** 单位 **取值范围** 长度为[0,32]个字符 
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseWidgetInfoResp {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  thresholdEnabled: ").Append(ThresholdEnabled).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  metricDisplayMode: ").Append(MetricDisplayMode).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseWidgetInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseWidgetInfoResp input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.ThresholdEnabled != input.ThresholdEnabled || (this.ThresholdEnabled != null && !this.ThresholdEnabled.Equals(input.ThresholdEnabled))) return false;
            if (this.View != input.View) return false;
            if (this.MetricDisplayMode != input.MetricDisplayMode) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.ThresholdEnabled != null) hashCode = hashCode * 59 + this.ThresholdEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                hashCode = hashCode * 59 + this.MetricDisplayMode.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
