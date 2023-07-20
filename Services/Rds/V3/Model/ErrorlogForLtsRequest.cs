using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 查询实例的错误日志对象
    /// </summary>
    public class ErrorlogForLtsRequest 
    {
        /// <summary>
        /// 日志级别，默认为ALL。
        /// </summary>
        /// <value>日志级别，默认为ALL。</value>
        [JsonConverter(typeof(EnumClassConverter<LevelEnum>))]
        public class LevelEnum
        {
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly LevelEnum ALL = new LevelEnum("ALL");

            /// <summary>
            /// Enum INFO for value: INFO
            /// </summary>
            public static readonly LevelEnum INFO = new LevelEnum("INFO");

            /// <summary>
            /// Enum LOG for value: LOG
            /// </summary>
            public static readonly LevelEnum LOG = new LevelEnum("LOG");

            /// <summary>
            /// Enum WARNING for value: WARNING
            /// </summary>
            public static readonly LevelEnum WARNING = new LevelEnum("WARNING");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly LevelEnum ERROR = new LevelEnum("ERROR");

            /// <summary>
            /// Enum FATAL for value: FATAL
            /// </summary>
            public static readonly LevelEnum FATAL = new LevelEnum("FATAL");

            /// <summary>
            /// Enum PANIC for value: PANIC
            /// </summary>
            public static readonly LevelEnum PANIC = new LevelEnum("PANIC");

            /// <summary>
            /// Enum NOTE for value: NOTE
            /// </summary>
            public static readonly LevelEnum NOTE = new LevelEnum("NOTE");

            private static readonly Dictionary<string, LevelEnum> StaticFields =
            new Dictionary<string, LevelEnum>()
            {
                { "ALL", ALL },
                { "INFO", INFO },
                { "LOG", LOG },
                { "WARNING", WARNING },
                { "ERROR", ERROR },
                { "FATAL", FATAL },
                { "PANIC", PANIC },
                { "NOTE", NOTE },
            };

            private string _value;

            public LevelEnum()
            {

            }

            public LevelEnum(string value)
            {
                _value = value;
            }

            public static LevelEnum FromValue(string value)
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

                if (this.Equals(obj as LevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LevelEnum a, LevelEnum b)
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

            public static bool operator !=(LevelEnum a, LevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 开始日期，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。只能查询当前时间前一个月内的慢日志。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 日志级别，默认为ALL。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public LevelEnum Level { get; set; }
        /// <summary>
        /// 日志单行序列号，第一次查询时不需要此参数，后续分页查询时需要使用，可从上次查询的返回信息中获取。line_num应在start_time和end_time之间。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 每页多少条记录（查询结果），取值范围是1~100，不填时默认为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 搜索方式。默认forwards。配合line_num使用，以line_num为起点，向前搜索或向后搜索。
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorlogForLtsRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorlogForLtsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ErrorlogForLtsRequest input)
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
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.LineNum == input.LineNum ||
                    (this.LineNum != null &&
                    this.LineNum.Equals(input.LineNum))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.SearchType == input.SearchType ||
                    (this.SearchType != null &&
                    this.SearchType.Equals(input.SearchType))
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
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.LineNum != null)
                    hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                return hashCode;
            }
        }
    }
}
