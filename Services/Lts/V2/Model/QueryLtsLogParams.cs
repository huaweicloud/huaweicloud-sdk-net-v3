using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 此参数在请求实体中，采用json字符串格式
    /// </summary>
    public class QueryLtsLogParams 
    {
        /// <summary>
        /// 首次查询为 “init”, 分页查询时为 “forwards”或者“backwards”, 默认为首次查询“init”, 与 is_desc 参数配合进行分页查询。
        /// </summary>
        /// <value>首次查询为 “init”, 分页查询时为 “forwards”或者“backwards”, 默认为首次查询“init”, 与 is_desc 参数配合进行分页查询。</value>
        [JsonConverter(typeof(EnumClassConverter<SearchTypeEnum>))]
        public class SearchTypeEnum
        {
            /// <summary>
            /// Enum FORWARDS for value: forwards
            /// </summary>
            public static readonly SearchTypeEnum FORWARDS = new SearchTypeEnum("forwards");

            /// <summary>
            /// Enum BACKWARDS for value: backwards
            /// </summary>
            public static readonly SearchTypeEnum BACKWARDS = new SearchTypeEnum("backwards");

            private static readonly Dictionary<string, SearchTypeEnum> StaticFields =
            new Dictionary<string, SearchTypeEnum>()
            {
                { "forwards", FORWARDS },
                { "backwards", BACKWARDS },
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
        /// 搜索起始时间（UTC时间，毫秒级）。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 搜索结束时间（UTC时间，毫秒级）。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 日志过滤条件集合，不同日志来源所需字段不同。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 日志条数统计。默认为false(不统计)，true为统计日志条数。
        /// </summary>
        [JsonProperty("is_count", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCount { get; set; }

        /// <summary>
        /// 支持关键词精确搜索。关键词指相邻两个分词符之间的单词,例：error
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public string Keywords { get; set; }

        /// <summary>
        /// 日志单行序列号，第一次查询时不需要此参数，后续分页查询时需要使用，可从上次查询的返回信息中获取。line_num应在start_time 和 end_time 之间。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 若已开启自定义时间功能，需要使用该字段进行分页查询。
        /// </summary>
        [JsonProperty("__time__", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 顺序或者倒序查询, 默认为false(顺序查询)
        /// </summary>
        [JsonProperty("is_desc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDesc { get; set; }

        /// <summary>
        /// 首次查询为 “init”, 分页查询时为 “forwards”或者“backwards”, 默认为首次查询“init”, 与 is_desc 参数配合进行分页查询。
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public SearchTypeEnum SearchType { get; set; }
        /// <summary>
        /// 表示每次查询的日志条数，不填时默认为50，建议您设置为100。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 日志关键词高亮显示，默认为true（高亮显示），false为取消高亮显示。
        /// </summary>
        [JsonProperty("highlight", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Highlight { get; set; }

        /// <summary>
        /// 日志迭代查询，默认为false（不开启迭代），true为开启迭代。
        /// </summary>
        [JsonProperty("is_iterative", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIterative { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryLtsLogParams {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  isCount: ").Append(IsCount).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  isDesc: ").Append(IsDesc).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  highlight: ").Append(Highlight).Append("\n");
            sb.Append("  isIterative: ").Append(IsIterative).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryLtsLogParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryLtsLogParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.IsCount == input.IsCount ||
                    (this.IsCount != null &&
                    this.IsCount.Equals(input.IsCount))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.LineNum == input.LineNum ||
                    (this.LineNum != null &&
                    this.LineNum.Equals(input.LineNum))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.IsDesc == input.IsDesc ||
                    (this.IsDesc != null &&
                    this.IsDesc.Equals(input.IsDesc))
                ) && 
                (
                    this.SearchType == input.SearchType ||
                    (this.SearchType != null &&
                    this.SearchType.Equals(input.SearchType))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Highlight == input.Highlight ||
                    (this.Highlight != null &&
                    this.Highlight.Equals(input.Highlight))
                ) && 
                (
                    this.IsIterative == input.IsIterative ||
                    (this.IsIterative != null &&
                    this.IsIterative.Equals(input.IsIterative))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.IsCount != null)
                    hashCode = hashCode * 59 + this.IsCount.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.LineNum != null)
                    hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.IsDesc != null)
                    hashCode = hashCode * 59 + this.IsDesc.GetHashCode();
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Highlight != null)
                    hashCode = hashCode * 59 + this.Highlight.GetHashCode();
                if (this.IsIterative != null)
                    hashCode = hashCode * 59 + this.IsIterative.GetHashCode();
                return hashCode;
            }
        }
    }
}
