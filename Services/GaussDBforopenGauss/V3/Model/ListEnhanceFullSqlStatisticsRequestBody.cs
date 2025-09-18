using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListEnhanceFullSqlStatisticsRequestBody 
    {
        /// <summary>
        /// **参数解释**: 排序字段。 **约束限制**: 不涉及。 **取值范围**: - sql_id - sql_count - avg_db_time - avg_cpu_time - avg_execution_time - avg_data_io_time - start_time_stamp  **默认取值**: sql_count
        /// </summary>
        /// <value>**参数解释**: 排序字段。 **约束限制**: 不涉及。 **取值范围**: - sql_id - sql_count - avg_db_time - avg_cpu_time - avg_execution_time - avg_data_io_time - start_time_stamp  **默认取值**: sql_count</value>
        [JsonConverter(typeof(EnumClassConverter<OrderByEnum>))]
        public class OrderByEnum
        {
            /// <summary>
            /// Enum SQL_ID for value: sql_id
            /// </summary>
            public static readonly OrderByEnum SQL_ID = new OrderByEnum("sql_id");

            /// <summary>
            /// Enum SQL_COUNT for value: sql_count
            /// </summary>
            public static readonly OrderByEnum SQL_COUNT = new OrderByEnum("sql_count");

            /// <summary>
            /// Enum AVG_DB_TIME for value: avg_db_time
            /// </summary>
            public static readonly OrderByEnum AVG_DB_TIME = new OrderByEnum("avg_db_time");

            /// <summary>
            /// Enum AVG_CPU_TIME for value: avg_cpu_time
            /// </summary>
            public static readonly OrderByEnum AVG_CPU_TIME = new OrderByEnum("avg_cpu_time");

            /// <summary>
            /// Enum AVG_EXECUTION_TIME for value: avg_execution_time
            /// </summary>
            public static readonly OrderByEnum AVG_EXECUTION_TIME = new OrderByEnum("avg_execution_time");

            /// <summary>
            /// Enum AVG_DATA_IO_TIME for value: avg_data_io_time
            /// </summary>
            public static readonly OrderByEnum AVG_DATA_IO_TIME = new OrderByEnum("avg_data_io_time");

            /// <summary>
            /// Enum START_TIME_STAMP for value: start_time_stamp
            /// </summary>
            public static readonly OrderByEnum START_TIME_STAMP = new OrderByEnum("start_time_stamp");

            private static readonly Dictionary<string, OrderByEnum> StaticFields =
            new Dictionary<string, OrderByEnum>()
            {
                { "sql_id", SQL_ID },
                { "sql_count", SQL_COUNT },
                { "avg_db_time", AVG_DB_TIME },
                { "avg_cpu_time", AVG_CPU_TIME },
                { "avg_execution_time", AVG_EXECUTION_TIME },
                { "avg_data_io_time", AVG_DATA_IO_TIME },
                { "start_time_stamp", START_TIME_STAMP },
            };

            private string _value;

            public OrderByEnum()
            {

            }

            public OrderByEnum(string value)
            {
                _value = value;
            }

            public static OrderByEnum FromValue(string value)
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

                if (this.Equals(obj as OrderByEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderByEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderByEnum a, OrderByEnum b)
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

            public static bool operator !=(OrderByEnum a, OrderByEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 排序方式，支持升序和降序。 **约束限制**: 不涉及。 **取值范围**: - DESC：降序。 - ASC：升序。  **默认取值**: DESC
        /// </summary>
        /// <value>**参数解释**: 排序方式，支持升序和降序。 **约束限制**: 不涉及。 **取值范围**: - DESC：降序。 - ASC：升序。  **默认取值**: DESC</value>
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

            public static bool operator !=(OrderEnum a, OrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 查询记录数。例如该参数设定为10，则查询结果最多只显示10条记录。 **约束限制**: 不涉及。 **取值范围**: [1, 1000] **默认取值**: 默认为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**: 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询。例如：该参数指定为0，limit指定为10，则只展示第1~10条数据。 **约束限制**: 不涉及。 **取值范围**: [0, 9223372036854774807] **默认取值**: 默认为0（偏移0条数据，表示从第一条数据开始查询）。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**: 节点ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: 查询开始时间。 **约束限制**: ISO 8601 UTC格式。模式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量。时区中的+号需要进行URL编码，编码为%2B，时区中的-号无需编码。例如：北京时间偏移显示为+0800，begin_time&#x3D;2024-03-15T17:20:33+0800，传参时编码为begin_time&#x3D;2024-03-15T17:20:33%2B0800。 **取值范围**: 时间区间（begin_time ~ end_time）不能超过30天。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**: 查询结束时间。 **约束限制**: ISO 8601 UTC格式。模式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量。时区中的+号需要进行URL编码，编码为%2B，时区中的-号无需编码。例如：北京时间偏移显示为+0800，end_time&#x3D;2024-03-16T17:20:33+0800，传参时编码为end_time&#x3D;2024-03-16T17:20:33%2B0800。 **取值范围**: 时间区间（begin_time ~ end_time）不能超过30天。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**: SQL文本。 **约束限制**: 不涉及。 **取值范围**: 长度1~4096。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// **参数解释**: 归一化SQL ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: 唯一SQL ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("sql_exec_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlExecId { get; set; }

        /// <summary>
        /// **参数解释**: 事务ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// **参数解释**: 链路ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**: schema名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// **参数解释**: 用户名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数解释**: 客户端地址。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("client_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientAddr { get; set; }

        /// <summary>
        /// **参数解释**: 客户端端口。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPort { get; set; }

        /// <summary>
        /// **参数解释**: 排序字段。 **约束限制**: 不涉及。 **取值范围**: - sql_id - sql_count - avg_db_time - avg_cpu_time - avg_execution_time - avg_data_io_time - start_time_stamp  **默认取值**: sql_count
        /// </summary>
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }
        /// <summary>
        /// **参数解释**: 是否是慢SQL。 **约束限制**: 不涉及。 **取值范围**: - true：是慢SQL。 - false：不是慢SQL。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("is_slow_sql", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSlowSql { get; set; }

        /// <summary>
        /// **参数解释**: 排序方式，支持升序和降序。 **约束限制**: 不涉及。 **取值范围**: - DESC：降序。 - ASC：升序。  **默认取值**: DESC
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// **参数解释**: 应用名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("application_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// **参数解释**: 组件ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**: 字段汇聚查询条件列表。 **约束限制**: 只支持针对query字段全与或者全或的查询。
        /// </summary>
        [JsonProperty("multi_queries", NullValueHandling = NullValueHandling.Ignore)]
        public List<MultiQueryConditionOption> MultiQueries { get; set; }

        /// <summary>
        /// **参数解释**: 组合比较查询条件，可针对某个给定过滤字段，进行区间范围、大小、小于等条件合并查询。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("compare_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareConditionOption> CompareConditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnhanceFullSqlStatisticsRequestBody {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlExecId: ").Append(SqlExecId).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  isSlowSql: ").Append(IsSlowSql).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  applicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  multiQueries: ").Append(MultiQueries).Append("\n");
            sb.Append("  compareConditions: ").Append(CompareConditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnhanceFullSqlStatisticsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnhanceFullSqlStatisticsRequestBody input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlExecId != input.SqlExecId || (this.SqlExecId != null && !this.SqlExecId.Equals(input.SqlExecId))) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.OrderBy != input.OrderBy) return false;
            if (this.IsSlowSql != input.IsSlowSql || (this.IsSlowSql != null && !this.IsSlowSql.Equals(input.IsSlowSql))) return false;
            if (this.Order != input.Order) return false;
            if (this.ApplicationName != input.ApplicationName || (this.ApplicationName != null && !this.ApplicationName.Equals(input.ApplicationName))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.MultiQueries != input.MultiQueries || (this.MultiQueries != null && input.MultiQueries != null && !this.MultiQueries.SequenceEqual(input.MultiQueries))) return false;
            if (this.CompareConditions != input.CompareConditions || (this.CompareConditions != null && input.CompareConditions != null && !this.CompareConditions.SequenceEqual(input.CompareConditions))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlExecId != null) hashCode = hashCode * 59 + this.SqlExecId.GetHashCode();
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.IsSlowSql != null) hashCode = hashCode * 59 + this.IsSlowSql.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.ApplicationName != null) hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.MultiQueries != null) hashCode = hashCode * 59 + this.MultiQueries.GetHashCode();
                if (this.CompareConditions != null) hashCode = hashCode * 59 + this.CompareConditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
