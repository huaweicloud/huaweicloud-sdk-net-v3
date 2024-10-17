using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListLtsErrorLogsRequestBody 
    {
        /// <summary>
        /// 日志级别，取空值表示查询所有日志级别。
        /// </summary>
        /// <value>日志级别，取空值表示查询所有日志级别。</value>
        [JsonConverter(typeof(EnumClassConverter<SeverityEnum>))]
        public class SeverityEnum
        {
            /// <summary>
            /// Enum WARNING for value: Warning
            /// </summary>
            public static readonly SeverityEnum WARNING = new SeverityEnum("Warning");

            /// <summary>
            /// Enum ERROR for value: Error
            /// </summary>
            public static readonly SeverityEnum ERROR = new SeverityEnum("Error");

            private static readonly Dictionary<string, SeverityEnum> StaticFields =
            new Dictionary<string, SeverityEnum>()
            {
                { "Warning", WARNING },
                { "Error", ERROR },
            };

            private string _value;

            public SeverityEnum()
            {

            }

            public SeverityEnum(string value)
            {
                _value = value;
            }

            public static SeverityEnum FromValue(string value)
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

                if (this.Equals(obj as SeverityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SeverityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SeverityEnum a, SeverityEnum b)
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

            public static bool operator !=(SeverityEnum a, SeverityEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 日志查询方式，需结合line_num使用, 以line_num的日志为起始点: - 取值\&quot;backwards\&quot;时，表示查询上一页limit大小的日志 - 取值\&quot;forwards\&quot;时，表示查询下一页limit大小的日志 - 不传默认\&quot;forwards\&quot;
        /// </summary>
        /// <value>日志查询方式，需结合line_num使用, 以line_num的日志为起始点: - 取值\&quot;backwards\&quot;时，表示查询上一页limit大小的日志 - 取值\&quot;forwards\&quot;时，表示查询下一页limit大小的日志 - 不传默认\&quot;forwards\&quot;</value>
        [JsonConverter(typeof(EnumClassConverter<SearchTypeEnum>))]
        public class SearchTypeEnum
        {
            /// <summary>
            /// Enum BACKWARDS for value: backwards
            /// </summary>
            public static readonly SearchTypeEnum BACKWARDS = new SearchTypeEnum("backwards");

            /// <summary>
            /// Enum FORWARDS for value: forwards
            /// </summary>
            public static readonly SearchTypeEnum FORWARDS = new SearchTypeEnum("forwards");

            private static readonly Dictionary<string, SearchTypeEnum> StaticFields =
            new Dictionary<string, SearchTypeEnum>()
            {
                { "backwards", BACKWARDS },
                { "forwards", FORWARDS },
            };

            private string _value;

            public SearchTypeEnum()
            {

            }

            public SearchTypeEnum(string value)
            {
                _value = value;
            }

            public static SearchTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SearchTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SearchTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SearchTypeEnum a, SearchTypeEnum b)
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

            public static bool operator !=(SearchTypeEnum a, SearchTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。注：开始时间不得早于当前时间30天。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。注：结束时间不能晚于当前时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 表示每次查询的日志条数，最大限制100条。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 日志单行序列号，第一次查询时不需要此参数，下一页查询时需要使用，可从上一次查询的返回信息中获取。 说明：当次查询从line_num的下一条日志开始查询，不包含当前line_num日志。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 日志级别，取空值表示查询所有日志级别。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// 日志查询方式，需结合line_num使用, 以line_num的日志为起始点: - 取值\&quot;backwards\&quot;时，表示查询上一页limit大小的日志 - 取值\&quot;forwards\&quot;时，表示查询下一页limit大小的日志 - 不传默认\&quot;forwards\&quot;
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public SearchTypeEnum SearchType { get; set; }
        /// <summary>
        /// 节点ID，取空值，表示查询实例下所有允许查询的节点。 使用请参考《DDS API参考》的“查询实例列表和详情”响应消息表“nodes 数据结构说明”的“id”。允许查询的节点如下： - 集群实例下面的 shard节点 - 副本集、单节点实例下面的所有节点
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 根据多个关键字搜索日志全文，表示同时匹配所有关键字。 - 只支持关键字前缀模糊搜索，最多支持10个关键字。 - 每个关键字最大长度不超过512个字符。
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLtsErrorLogsRequestBody {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLtsErrorLogsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLtsErrorLogsRequestBody input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.LineNum != input.LineNum || (this.LineNum != null && !this.LineNum.Equals(input.LineNum))) return false;
            if (this.Severity != input.Severity) return false;
            if (this.SearchType != input.SearchType) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && input.Keywords != null && !this.Keywords.SequenceEqual(input.Keywords))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.LineNum != null) hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                return hashCode;
            }
        }
    }
}
