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
    /// 查询实例的慢日志对象
    /// </summary>
    public class SlowlogForLtsRequest 
    {
        /// <summary>
        /// 语句类型，取空值，表示查询所有语句类型。
        /// </summary>
        /// <value>语句类型，取空值，表示查询所有语句类型。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum INSERT for value: INSERT
            /// </summary>
            public static readonly TypeEnum INSERT = new TypeEnum("INSERT");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly TypeEnum UPDATE = new TypeEnum("UPDATE");

            /// <summary>
            /// Enum SELECT for value: SELECT
            /// </summary>
            public static readonly TypeEnum SELECT = new TypeEnum("SELECT");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly TypeEnum DELETE = new TypeEnum("DELETE");

            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            public static readonly TypeEnum CREATE = new TypeEnum("CREATE");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "INSERT", INSERT },
                { "UPDATE", UPDATE },
                { "SELECT", SELECT },
                { "DELETE", DELETE },
                { "CREATE", CREATE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 搜索方式。默认forwards。配合line_num使用，以line_num为起点，向前搜索或向后搜索。
        /// </summary>
        /// <value>搜索方式。默认forwards。配合line_num使用，以line_num为起点，向前搜索或向后搜索。</value>
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
        /// 语句类型，取空值，表示查询所有语句类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
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
        public SearchTypeEnum SearchType { get; set; }
        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlowlogForLtsRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlowlogForLtsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlowlogForLtsRequest input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                ) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LineNum != null)
                    hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                return hashCode;
            }
        }
    }
}
