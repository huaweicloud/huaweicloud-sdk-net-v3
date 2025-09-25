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
    public class SlowSqlDetailResult 
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
        /// **参数解释**: 客户端IP。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// **参数解释**: 客户端端口。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPort { get; set; }

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
        /// **参数解释**: SQL模版。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlText { get; set; }

        /// <summary>
        /// **参数解释**: 执行计划。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_plan", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryPlan { get; set; }

        /// <summary>
        /// **参数解释**: 开始时间UTC时间。 **取值范围**: 格式为yyyy-mm-ddThh:mm:ss+0000。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTime { get; set; }

        /// <summary>
        /// **参数解释**: 结束时间UTC时间。 **取值范围**: 格式为yyyy-mm-ddThh:mm:ss+0000。
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? FinishTime { get; set; }

        /// <summary>
        /// **参数解释**: 返回行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("returned_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReturnedRows { get; set; }

        /// <summary>
        /// **参数解释**: 扫描行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("fetched_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchedRows { get; set; }

        /// <summary>
        /// **参数解释**: 扫描页。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("fetched_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchedPages { get; set; }

        /// <summary>
        /// **参数解释**: 命中页。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("hit_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? HitPages { get; set; }

        /// <summary>
        /// **参数解释**: 总耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTime { get; set; }

        /// <summary>
        /// **参数解释**: CPU耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuTime { get; set; }

        /// <summary>
        /// **参数解释**: 计划耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("plan_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlanTime { get; set; }

        /// <summary>
        /// **参数解释**: IO耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("io_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? IoTime { get; set; }

        /// <summary>
        /// **参数解释**: 加锁次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lock_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LockCount { get; set; }

        /// <summary>
        /// **参数解释**: 加锁耗时(单位：微秒)。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? LockTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlowSqlDetailResult {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  sqlText: ").Append(SqlText).Append("\n");
            sb.Append("  queryPlan: ").Append(QueryPlan).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  returnedRows: ").Append(ReturnedRows).Append("\n");
            sb.Append("  fetchedRows: ").Append(FetchedRows).Append("\n");
            sb.Append("  fetchedPages: ").Append(FetchedPages).Append("\n");
            sb.Append("  hitPages: ").Append(HitPages).Append("\n");
            sb.Append("  totalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  cpuTime: ").Append(CpuTime).Append("\n");
            sb.Append("  planTime: ").Append(PlanTime).Append("\n");
            sb.Append("  ioTime: ").Append(IoTime).Append("\n");
            sb.Append("  lockCount: ").Append(LockCount).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlowSqlDetailResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlowSqlDetailResult input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ClientIp != input.ClientIp || (this.ClientIp != null && !this.ClientIp.Equals(input.ClientIp))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;
            if (this.SqlText != input.SqlText || (this.SqlText != null && !this.SqlText.Equals(input.SqlText))) return false;
            if (this.QueryPlan != input.QueryPlan || (this.QueryPlan != null && !this.QueryPlan.Equals(input.QueryPlan))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.ReturnedRows != input.ReturnedRows || (this.ReturnedRows != null && !this.ReturnedRows.Equals(input.ReturnedRows))) return false;
            if (this.FetchedRows != input.FetchedRows || (this.FetchedRows != null && !this.FetchedRows.Equals(input.FetchedRows))) return false;
            if (this.FetchedPages != input.FetchedPages || (this.FetchedPages != null && !this.FetchedPages.Equals(input.FetchedPages))) return false;
            if (this.HitPages != input.HitPages || (this.HitPages != null && !this.HitPages.Equals(input.HitPages))) return false;
            if (this.TotalTime != input.TotalTime || (this.TotalTime != null && !this.TotalTime.Equals(input.TotalTime))) return false;
            if (this.CpuTime != input.CpuTime || (this.CpuTime != null && !this.CpuTime.Equals(input.CpuTime))) return false;
            if (this.PlanTime != input.PlanTime || (this.PlanTime != null && !this.PlanTime.Equals(input.PlanTime))) return false;
            if (this.IoTime != input.IoTime || (this.IoTime != null && !this.IoTime.Equals(input.IoTime))) return false;
            if (this.LockCount != input.LockCount || (this.LockCount != null && !this.LockCount.Equals(input.LockCount))) return false;
            if (this.LockTime != input.LockTime || (this.LockTime != null && !this.LockTime.Equals(input.LockTime))) return false;

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
                if (this.ClientIp != null) hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.SqlText != null) hashCode = hashCode * 59 + this.SqlText.GetHashCode();
                if (this.QueryPlan != null) hashCode = hashCode * 59 + this.QueryPlan.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.ReturnedRows != null) hashCode = hashCode * 59 + this.ReturnedRows.GetHashCode();
                if (this.FetchedRows != null) hashCode = hashCode * 59 + this.FetchedRows.GetHashCode();
                if (this.FetchedPages != null) hashCode = hashCode * 59 + this.FetchedPages.GetHashCode();
                if (this.HitPages != null) hashCode = hashCode * 59 + this.HitPages.GetHashCode();
                if (this.TotalTime != null) hashCode = hashCode * 59 + this.TotalTime.GetHashCode();
                if (this.CpuTime != null) hashCode = hashCode * 59 + this.CpuTime.GetHashCode();
                if (this.PlanTime != null) hashCode = hashCode * 59 + this.PlanTime.GetHashCode();
                if (this.IoTime != null) hashCode = hashCode * 59 + this.IoTime.GetHashCode();
                if (this.LockCount != null) hashCode = hashCode * 59 + this.LockCount.GetHashCode();
                if (this.LockTime != null) hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
