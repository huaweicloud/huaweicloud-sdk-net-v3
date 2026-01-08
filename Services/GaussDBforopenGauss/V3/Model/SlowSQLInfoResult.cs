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
    public class SlowSQLInfoResult 
    {

        /// <summary>
        /// **参数解释**: 数据库名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**: SCHEMA名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// **参数解释**: 变量替换后的完整SQL。当sql_text不返回变量值时，sql返回空字符串。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql", NullValueHandling = NullValueHandling.Ignore)]
        public string Sql { get; set; }

        /// <summary>
        /// **参数解释**: SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: 用户名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: SQL文本。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlText { get; set; }

        /// <summary>
        /// **参数解释**: SQL计划。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_plan", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryPlan { get; set; }

        /// <summary>
        /// **参数解释**: 执行次数（次）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("calls", NullValueHandling = NullValueHandling.Ignore)]
        public int? Calls { get; set; }

        /// <summary>
        /// **参数解释**: 平均执行时间（us）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgExecTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均CPU耗时（us）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgCpuTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均IO耗时（us）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_io_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgIoTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均返回行数（行）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_returned_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvgReturnedRows { get; set; }

        /// <summary>
        /// **参数解释**: 平均扫描行数（行）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_fetched_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvgFetchedRows { get; set; }

        /// <summary>
        /// **参数解释**: buffer命中率。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("buffer_hit_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string BufferHitRatio { get; set; }

        /// <summary>
        /// **参数解释**: SQL命中率。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_hit_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlHitRatio { get; set; }

        /// <summary>
        /// **参数解释**: 节点ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: 节点名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlowSQLInfoResult {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  sqlText: ").Append(SqlText).Append("\n");
            sb.Append("  queryPlan: ").Append(QueryPlan).Append("\n");
            sb.Append("  calls: ").Append(Calls).Append("\n");
            sb.Append("  avgExecTime: ").Append(AvgExecTime).Append("\n");
            sb.Append("  avgCpuTime: ").Append(AvgCpuTime).Append("\n");
            sb.Append("  avgIoTime: ").Append(AvgIoTime).Append("\n");
            sb.Append("  avgReturnedRows: ").Append(AvgReturnedRows).Append("\n");
            sb.Append("  avgFetchedRows: ").Append(AvgFetchedRows).Append("\n");
            sb.Append("  bufferHitRatio: ").Append(BufferHitRatio).Append("\n");
            sb.Append("  sqlHitRatio: ").Append(SqlHitRatio).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlowSQLInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlowSQLInfoResult input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.SqlText != input.SqlText || (this.SqlText != null && !this.SqlText.Equals(input.SqlText))) return false;
            if (this.QueryPlan != input.QueryPlan || (this.QueryPlan != null && !this.QueryPlan.Equals(input.QueryPlan))) return false;
            if (this.Calls != input.Calls || (this.Calls != null && !this.Calls.Equals(input.Calls))) return false;
            if (this.AvgExecTime != input.AvgExecTime || (this.AvgExecTime != null && !this.AvgExecTime.Equals(input.AvgExecTime))) return false;
            if (this.AvgCpuTime != input.AvgCpuTime || (this.AvgCpuTime != null && !this.AvgCpuTime.Equals(input.AvgCpuTime))) return false;
            if (this.AvgIoTime != input.AvgIoTime || (this.AvgIoTime != null && !this.AvgIoTime.Equals(input.AvgIoTime))) return false;
            if (this.AvgReturnedRows != input.AvgReturnedRows || (this.AvgReturnedRows != null && !this.AvgReturnedRows.Equals(input.AvgReturnedRows))) return false;
            if (this.AvgFetchedRows != input.AvgFetchedRows || (this.AvgFetchedRows != null && !this.AvgFetchedRows.Equals(input.AvgFetchedRows))) return false;
            if (this.BufferHitRatio != input.BufferHitRatio || (this.BufferHitRatio != null && !this.BufferHitRatio.Equals(input.BufferHitRatio))) return false;
            if (this.SqlHitRatio != input.SqlHitRatio || (this.SqlHitRatio != null && !this.SqlHitRatio.Equals(input.SqlHitRatio))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;

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
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.Sql != null) hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SqlText != null) hashCode = hashCode * 59 + this.SqlText.GetHashCode();
                if (this.QueryPlan != null) hashCode = hashCode * 59 + this.QueryPlan.GetHashCode();
                if (this.Calls != null) hashCode = hashCode * 59 + this.Calls.GetHashCode();
                if (this.AvgExecTime != null) hashCode = hashCode * 59 + this.AvgExecTime.GetHashCode();
                if (this.AvgCpuTime != null) hashCode = hashCode * 59 + this.AvgCpuTime.GetHashCode();
                if (this.AvgIoTime != null) hashCode = hashCode * 59 + this.AvgIoTime.GetHashCode();
                if (this.AvgReturnedRows != null) hashCode = hashCode * 59 + this.AvgReturnedRows.GetHashCode();
                if (this.AvgFetchedRows != null) hashCode = hashCode * 59 + this.AvgFetchedRows.GetHashCode();
                if (this.BufferHitRatio != null) hashCode = hashCode * 59 + this.BufferHitRatio.GetHashCode();
                if (this.SqlHitRatio != null) hashCode = hashCode * 59 + this.SqlHitRatio.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
