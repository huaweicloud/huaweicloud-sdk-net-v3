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
    /// 
    /// </summary>
    public class KeywordsRequest 
    {
        /// <summary>
        /// 条件
        /// </summary>
        /// <value>条件</value>
        [JsonConverter(typeof(EnumClassConverter<ConditionEnum>))]
        public class ConditionEnum
        {
            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: >=
            /// </summary>
            public static readonly ConditionEnum GreaterThanOrEqualTo = new ConditionEnum(">=");

            /// <summary>
            /// Enum LessThanOrEqualTo for value: <=
            /// </summary>
            public static readonly ConditionEnum LessThanOrEqualTo = new ConditionEnum("<=");

            /// <summary>
            /// Enum LessThan for value: <
            /// </summary>
            public static readonly ConditionEnum LessThan = new ConditionEnum("<");

            /// <summary>
            /// Enum GreaterThan for value: >
            /// </summary>
            public static readonly ConditionEnum GreaterThan = new ConditionEnum(">");

            private static readonly Dictionary<string, ConditionEnum> StaticFields =
            new Dictionary<string, ConditionEnum>()
            {
                { ">=", GreaterThanOrEqualTo },
                { "<=", LessThanOrEqualTo },
                { "<", LessThan },
                { ">", GreaterThan },
            };

            private string _value;

            public ConditionEnum()
            {

            }

            public ConditionEnum(string value)
            {
                _value = value;
            }

            public static ConditionEnum FromValue(string value)
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

                if (this.Equals(obj as ConditionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConditionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConditionEnum a, ConditionEnum b)
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

            public static bool operator !=(ConditionEnum a, ConditionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 查询时间单位
        /// </summary>
        /// <value>查询时间单位</value>
        [JsonConverter(typeof(EnumClassConverter<SearchTimeRangeUnitEnum>))]
        public class SearchTimeRangeUnitEnum
        {
            /// <summary>
            /// Enum MINUTE for value: minute
            /// </summary>
            public static readonly SearchTimeRangeUnitEnum MINUTE = new SearchTimeRangeUnitEnum("minute");

            private static readonly Dictionary<string, SearchTimeRangeUnitEnum> StaticFields =
            new Dictionary<string, SearchTimeRangeUnitEnum>()
            {
                { "minute", MINUTE },
            };

            private string _value;

            public SearchTimeRangeUnitEnum()
            {

            }

            public SearchTimeRangeUnitEnum(string value)
            {
                _value = value;
            }

            public static SearchTimeRangeUnitEnum FromValue(string value)
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

                if (this.Equals(obj as SearchTimeRangeUnitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SearchTimeRangeUnitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SearchTimeRangeUnitEnum a, SearchTimeRangeUnitEnum b)
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

            public static bool operator !=(SearchTimeRangeUnitEnum a, SearchTimeRangeUnitEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// 日志组id
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志组名称
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public string Keywords { get; set; }

        /// <summary>
        /// 条件
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionEnum Condition { get; set; }
        /// <summary>
        /// 行数
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// 查询执行任务时最近数据的时间范围，最大值为60
        /// </summary>
        [JsonProperty("search_time_range", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchTimeRange { get; set; }

        /// <summary>
        /// 查询时间单位
        /// </summary>
        [JsonProperty("search_time_range_unit", NullValueHandling = NullValueHandling.Ignore)]
        public SearchTimeRangeUnitEnum SearchTimeRangeUnit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeywordsRequest {\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  searchTimeRange: ").Append(SearchTimeRange).Append("\n");
            sb.Append("  searchTimeRangeUnit: ").Append(SearchTimeRangeUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeywordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeywordsRequest input)
        {
            if (input == null) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && !this.Keywords.Equals(input.Keywords))) return false;
            if (this.Condition != input.Condition) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.SearchTimeRange != input.SearchTimeRange || (this.SearchTimeRange != null && !this.SearchTimeRange.Equals(input.SearchTimeRange))) return false;
            if (this.SearchTimeRangeUnit != input.SearchTimeRangeUnit) return false;

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
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.SearchTimeRange != null) hashCode = hashCode * 59 + this.SearchTimeRange.GetHashCode();
                hashCode = hashCode * 59 + this.SearchTimeRangeUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
