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
    /// Request Object
    /// </summary>
    public class ListInstancesResourceMetricsRequest 
    {
        /// <summary>
        /// 引擎类型
        /// </summary>
        /// <value>引擎类型</value>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly EngineEnum MYSQL = new EngineEnum("mysql");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly EngineEnum POSTGRESQL = new EngineEnum("postgresql");

            /// <summary>
            /// Enum SQLSERVER for value: sqlserver
            /// </summary>
            public static readonly EngineEnum SQLSERVER = new EngineEnum("sqlserver");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "mysql", MYSQL },
                { "postgresql", POSTGRESQL },
                { "sqlserver", SQLSERVER },
            };

            private string _value;

            public EngineEnum()
            {

            }

            public EngineEnum(string value)
            {
                _value = value;
            }

            public static EngineEnum FromValue(string value)
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

                if (this.Equals(obj as EngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineEnum a, EngineEnum b)
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序方式
        /// </summary>
        /// <value>排序方式</value>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("DESC");

            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("ASC");

            private static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                { "DESC", DESC },
                { "ASC", ASC },
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
        /// 排序字段
        /// </summary>
        /// <value>排序字段</value>
        [JsonConverter(typeof(EnumClassConverter<SortFieldEnum>))]
        public class SortFieldEnum
        {
            /// <summary>
            /// Enum INSTANCE_NAME for value: instance_name
            /// </summary>
            public static readonly SortFieldEnum INSTANCE_NAME = new SortFieldEnum("instance_name");

            /// <summary>
            /// Enum STATUS for value: status
            /// </summary>
            public static readonly SortFieldEnum STATUS = new SortFieldEnum("status");

            /// <summary>
            /// Enum TYPE for value: type
            /// </summary>
            public static readonly SortFieldEnum TYPE = new SortFieldEnum("type");

            /// <summary>
            /// Enum CPU_USAGE for value: cpu_usage
            /// </summary>
            public static readonly SortFieldEnum CPU_USAGE = new SortFieldEnum("cpu_usage");

            /// <summary>
            /// Enum MEMORY_USAGE for value: memory_usage
            /// </summary>
            public static readonly SortFieldEnum MEMORY_USAGE = new SortFieldEnum("memory_usage");

            /// <summary>
            /// Enum DISK_USAGE for value: disk_usage
            /// </summary>
            public static readonly SortFieldEnum DISK_USAGE = new SortFieldEnum("disk_usage");

            /// <summary>
            /// Enum TPS for value: tps
            /// </summary>
            public static readonly SortFieldEnum TPS = new SortFieldEnum("tps");

            /// <summary>
            /// Enum QPS for value: qps
            /// </summary>
            public static readonly SortFieldEnum QPS = new SortFieldEnum("qps");

            /// <summary>
            /// Enum IOPS for value: iops
            /// </summary>
            public static readonly SortFieldEnum IOPS = new SortFieldEnum("iops");

            /// <summary>
            /// Enum ACTIVE_CONNECTIONS for value: active_connections
            /// </summary>
            public static readonly SortFieldEnum ACTIVE_CONNECTIONS = new SortFieldEnum("active_connections");

            /// <summary>
            /// Enum SLOW_SQL for value: slow_sql
            /// </summary>
            public static readonly SortFieldEnum SLOW_SQL = new SortFieldEnum("slow_sql");

            private static readonly Dictionary<string, SortFieldEnum> StaticFields =
            new Dictionary<string, SortFieldEnum>()
            {
                { "instance_name", INSTANCE_NAME },
                { "status", STATUS },
                { "type", TYPE },
                { "cpu_usage", CPU_USAGE },
                { "memory_usage", MEMORY_USAGE },
                { "disk_usage", DISK_USAGE },
                { "tps", TPS },
                { "qps", QPS },
                { "iops", IOPS },
                { "active_connections", ACTIVE_CONNECTIONS },
                { "slow_sql", SLOW_SQL },
            };

            private string _value;

            public SortFieldEnum()
            {

            }

            public SortFieldEnum(string value)
            {
                _value = value;
            }

            public static SortFieldEnum FromValue(string value)
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

                if (this.Equals(obj as SortFieldEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortFieldEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortFieldEnum a, SortFieldEnum b)
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

            public static bool operator !=(SortFieldEnum a, SortFieldEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 引擎类型
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// 搜索字段
        /// </summary>
        [SDKProperty("search_field", IsQuery = true)]
        [JsonProperty("search_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchField { get; set; }

        /// <summary>
        /// 索引位置，偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 查询数据条数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public SortFieldEnum SortField { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesResourceMetricsRequest {\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  searchField: ").Append(SearchField).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesResourceMetricsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesResourceMetricsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.SearchField == input.SearchField ||
                    (this.SearchField != null &&
                    this.SearchField.Equals(input.SearchField))
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
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.SortField == input.SortField ||
                    (this.SortField != null &&
                    this.SortField.Equals(input.SortField))
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
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.SearchField != null)
                    hashCode = hashCode * 59 + this.SearchField.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.SortField != null)
                    hashCode = hashCode * 59 + this.SortField.GetHashCode();
                return hashCode;
            }
        }
    }
}
