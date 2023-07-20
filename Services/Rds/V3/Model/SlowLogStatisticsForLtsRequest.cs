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
    public class SlowLogStatisticsForLtsRequest 
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

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly TypeEnum ALL = new TypeEnum("ALL");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "INSERT", INSERT },
                { "UPDATE", UPDATE },
                { "SELECT", SELECT },
                { "DELETE", DELETE },
                { "CREATE", CREATE },
                { "ALL", ALL },
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
        /// 排序顺序。默认desc。
        /// </summary>
        /// <value>排序顺序。默认desc。</value>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("desc");

            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("asc");

            private static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                { "desc", DESC },
                { "asc", ASC },
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
        /// 索引位置，偏移量。默认为0，表示从第一条数据开始查询。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页多少条记录（查询结果），取值范围是1~100，不填时默认为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 语句类型，取空值，表示查询所有语句类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// 指定排序字段。\&quot;executeTime\&quot;，表示按照执行时间降序排序。字段为空或传入其他值，表示按照执行次数降序排序。
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// 排序顺序。默认desc。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlowLogStatisticsForLtsRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlowLogStatisticsForLtsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlowLogStatisticsForLtsRequest input)
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
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                return hashCode;
            }
        }
    }
}
