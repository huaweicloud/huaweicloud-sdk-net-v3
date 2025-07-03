using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 视图配置信息。
    /// </summary>
    public class TrendView 
    {
        /// <summary>
        /// 视图类型。
        /// </summary>
        /// <value>视图类型。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewTypeEnum>))]
        public class ViewTypeEnum
        {
            /// <summary>
            /// Enum TREND for value: trend
            /// </summary>
            public static readonly ViewTypeEnum TREND = new ViewTypeEnum("trend");

            /// <summary>
            /// Enum SUMTABLE for value: sumtable
            /// </summary>
            public static readonly ViewTypeEnum SUMTABLE = new ViewTypeEnum("sumtable");

            /// <summary>
            /// Enum RAWTABLE for value: rawtable
            /// </summary>
            public static readonly ViewTypeEnum RAWTABLE = new ViewTypeEnum("rawtable");

            private static readonly Dictionary<string, ViewTypeEnum> StaticFields =
            new Dictionary<string, ViewTypeEnum>()
            {
                { "trend", TREND },
                { "sumtable", SUMTABLE },
                { "rawtable", RAWTABLE },
            };

            private string _value;

            public ViewTypeEnum()
            {

            }

            public ViewTypeEnum(string value)
            {
                _value = value;
            }

            public static ViewTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ViewTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewTypeEnum a, ViewTypeEnum b)
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

            public static bool operator !=(ViewTypeEnum a, ViewTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表格的方向，H：默认，表头横向，V：表头纵向。
        /// </summary>
        /// <value>表格的方向，H：默认，表头横向，V：表头纵向。</value>
        [JsonConverter(typeof(EnumClassConverter<TableDirectionEnum>))]
        public class TableDirectionEnum
        {
            /// <summary>
            /// Enum H for value: H
            /// </summary>
            public static readonly TableDirectionEnum H = new TableDirectionEnum("H");

            /// <summary>
            /// Enum V for value: V
            /// </summary>
            public static readonly TableDirectionEnum V = new TableDirectionEnum("V");

            private static readonly Dictionary<string, TableDirectionEnum> StaticFields =
            new Dictionary<string, TableDirectionEnum>()
            {
                { "H", H },
                { "V", V },
            };

            private string _value;

            public TableDirectionEnum()
            {

            }

            public TableDirectionEnum(string value)
            {
                _value = value;
            }

            public static TableDirectionEnum FromValue(string value)
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

                if (this.Equals(obj as TableDirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TableDirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TableDirectionEnum a, TableDirectionEnum b)
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

            public static bool operator !=(TableDirectionEnum a, TableDirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 视图类型。
        /// </summary>
        [JsonProperty("view_type", NullValueHandling = NullValueHandling.Ignore)]
        public ViewTypeEnum ViewType { get; set; }
        /// <summary>
        /// 采集器名称。
        /// </summary>
        [JsonProperty("collector_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectorName { get; set; }

        /// <summary>
        /// 视图对应的指标集名称。
        /// </summary>
        [JsonProperty("metric_set", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricSet { get; set; }

        /// <summary>
        /// 图标所需展示的标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 表格的方向，H：默认，表头横向，V：表头纵向。
        /// </summary>
        [JsonProperty("table_direction", NullValueHandling = NullValueHandling.Ignore)]
        public TableDirectionEnum TableDirection { get; set; }
        /// <summary>
        /// 分组。
        /// </summary>
        [JsonProperty("group_by", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupBy { get; set; }

        /// <summary>
        /// 过滤列表模型。
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 所需展示的字段列表模型列表。
        /// </summary>
        [JsonProperty("field_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldItem> FieldItemList { get; set; }

        /// <summary>
        /// 跨度。
        /// </summary>
        [JsonProperty("span", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Span { get; set; }

        /// <summary>
        /// span字段属性。
        /// </summary>
        [JsonProperty("span_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SpanField { get; set; }

        /// <summary>
        /// 排序。
        /// </summary>
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 是否只展示最近一笔数据。
        /// </summary>
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrendView {\n");
            sb.Append("  viewType: ").Append(ViewType).Append("\n");
            sb.Append("  collectorName: ").Append(CollectorName).Append("\n");
            sb.Append("  metricSet: ").Append(MetricSet).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  tableDirection: ").Append(TableDirection).Append("\n");
            sb.Append("  groupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  fieldItemList: ").Append(FieldItemList).Append("\n");
            sb.Append("  span: ").Append(Span).Append("\n");
            sb.Append("  spanField: ").Append(SpanField).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  latest: ").Append(Latest).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrendView);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrendView input)
        {
            if (input == null) return false;
            if (this.ViewType != input.ViewType) return false;
            if (this.CollectorName != input.CollectorName || (this.CollectorName != null && !this.CollectorName.Equals(input.CollectorName))) return false;
            if (this.MetricSet != input.MetricSet || (this.MetricSet != null && !this.MetricSet.Equals(input.MetricSet))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.TableDirection != input.TableDirection) return false;
            if (this.GroupBy != input.GroupBy || (this.GroupBy != null && !this.GroupBy.Equals(input.GroupBy))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.FieldItemList != input.FieldItemList || (this.FieldItemList != null && input.FieldItemList != null && !this.FieldItemList.SequenceEqual(input.FieldItemList))) return false;
            if (this.Span != input.Span || (this.Span != null && !this.Span.Equals(input.Span))) return false;
            if (this.SpanField != input.SpanField || (this.SpanField != null && !this.SpanField.Equals(input.SpanField))) return false;
            if (this.OrderBy != input.OrderBy || (this.OrderBy != null && !this.OrderBy.Equals(input.OrderBy))) return false;
            if (this.Latest != input.Latest || (this.Latest != null && !this.Latest.Equals(input.Latest))) return false;

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
                hashCode = hashCode * 59 + this.ViewType.GetHashCode();
                if (this.CollectorName != null) hashCode = hashCode * 59 + this.CollectorName.GetHashCode();
                if (this.MetricSet != null) hashCode = hashCode * 59 + this.MetricSet.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.TableDirection.GetHashCode();
                if (this.GroupBy != null) hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.FieldItemList != null) hashCode = hashCode * 59 + this.FieldItemList.GetHashCode();
                if (this.Span != null) hashCode = hashCode * 59 + this.Span.GetHashCode();
                if (this.SpanField != null) hashCode = hashCode * 59 + this.SpanField.GetHashCode();
                if (this.OrderBy != null) hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Latest != null) hashCode = hashCode * 59 + this.Latest.GetHashCode();
                return hashCode;
            }
        }
    }
}
