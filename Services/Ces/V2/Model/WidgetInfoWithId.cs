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
    public class WidgetInfoWithId 
    {
        /// <summary>
        /// 监控视图图表类型, bar柱状图，line折线图
        /// </summary>
        /// <value>监控视图图表类型, bar柱状图，line折线图</value>
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

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "bar", BAR },
                { "line", LINE },
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
        /// 指标展示类型，single 单指标展示，multiple 多指标展示
        /// </summary>
        /// <value>指标展示类型，single 单指标展示，multiple 多指标展示</value>
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
        /// 视图id
        /// </summary>
        [JsonProperty("widget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WidgetId { get; set; }

        /// <summary>
        /// 指标列表
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<WidgetMetric> Metrics { get; set; }

        /// <summary>
        /// 监控视图标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 监控视图指标的阈值
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? Threshold { get; set; }

        /// <summary>
        /// 阈值是否展示，true:展示，false:不展示
        /// </summary>
        [JsonProperty("threshold_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThresholdEnabled { get; set; }

        /// <summary>
        /// 监控视图图表类型, bar柱状图，line折线图
        /// </summary>
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// 指标展示类型，single 单指标展示，multiple 多指标展示
        /// </summary>
        [JsonProperty("metric_display_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MetricDisplayModeEnum MetricDisplayMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public BaseWidgetInfoProperties Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public BaseWidgetInfoLocation Location { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 监控看板创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WidgetInfoWithId {\n");
            sb.Append("  widgetId: ").Append(WidgetId).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  thresholdEnabled: ").Append(ThresholdEnabled).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  metricDisplayMode: ").Append(MetricDisplayMode).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WidgetInfoWithId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WidgetInfoWithId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WidgetId == input.WidgetId ||
                    (this.WidgetId != null &&
                    this.WidgetId.Equals(input.WidgetId))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.ThresholdEnabled == input.ThresholdEnabled ||
                    (this.ThresholdEnabled != null &&
                    this.ThresholdEnabled.Equals(input.ThresholdEnabled))
                ) && 
                (
                    this.View == input.View ||
                    (this.View != null &&
                    this.View.Equals(input.View))
                ) && 
                (
                    this.MetricDisplayMode == input.MetricDisplayMode ||
                    (this.MetricDisplayMode != null &&
                    this.MetricDisplayMode.Equals(input.MetricDisplayMode))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
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
                if (this.WidgetId != null)
                    hashCode = hashCode * 59 + this.WidgetId.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.ThresholdEnabled != null)
                    hashCode = hashCode * 59 + this.ThresholdEnabled.GetHashCode();
                if (this.View != null)
                    hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.MetricDisplayMode != null)
                    hashCode = hashCode * 59 + this.MetricDisplayMode.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
