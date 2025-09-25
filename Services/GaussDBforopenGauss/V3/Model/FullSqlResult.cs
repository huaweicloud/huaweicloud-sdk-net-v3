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
    /// **参数解释**: 全量SQL。
    /// </summary>
    public class FullSqlResult 
    {

        /// <summary>
        /// **参数解释**: SQL记录唯一键ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**: 实例ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**: 节点ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: 组件ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**: schema名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// **参数解释**: 用户名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起的请求的应用程序名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("application_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起的请求的客户端地址。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientAddr { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起请求的客户端端口。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPort { get; set; }

        /// <summary>
        /// **参数解释**: 归一化SQL ID，对应内核字段：unique_sql_id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: 唯一SQL ID，对应内核字段：debug_query_id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_exec_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlExecId { get; set; }

        /// <summary>
        /// **参数解释**: 事务ID，对应内核字段：debug_query_id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// **参数解释**: 链路ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// **参数解释**: 归一化SQL。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// **参数解释**: 解析后的原始SQL文本。 **取值范围**: 开启track_stmt_parameter参数后，会把SQL文本中的变量替换成真实值，展示原始的SQL。对于track_stmt_parameter参数关闭时采集的SQL文本，无法获取到SQL参数变量的值，展示的内容为空。
        /// </summary>
        [JsonProperty("sql", NullValueHandling = NullValueHandling.Ignore)]
        public string Sql { get; set; }

        /// <summary>
        /// **参数解释**: 开始时间，格式为“yyyy-mm-ddThh:mm:ss.SSSSSZ”。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**: 结束时间，格式为“yyyy-mm-ddThh:mm:ss.SSSSSZ”。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行总时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("all_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllTime { get; set; }

        /// <summary>
        /// **参数解释**: 有效DB时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("db_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DbTime { get; set; }

        /// <summary>
        /// **参数解释**: CPU时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CpuTime { get; set; }

        /// <summary>
        /// **参数解释**: IO时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("data_io_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DataIoTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行器内执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: 扫描行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("scan_lines", NullValueHandling = NullValueHandling.Ignore)]
        public long? ScanLines { get; set; }

        /// <summary>
        /// **参数解释**: 插入行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("insert_rows", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsertRows { get; set; }

        /// <summary>
        /// **参数解释**: 更新行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("update_rows", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateRows { get; set; }

        /// <summary>
        /// **参数解释**: 删除行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("delete_rows", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeleteRows { get; set; }

        /// <summary>
        /// **参数解释**: 是否慢SQL。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("is_slow_sql", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSlowSql { get; set; }

        /// <summary>
        /// **参数解释**: SQL开始时间。格式为13位标准时间戳，如1754647168354。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// **参数解释**: SQL结束时间，格式为13位标准时间戳，如1754647168355。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("finish_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? FinishTimestamp { get; set; }

        /// <summary>
        /// **参数解释**: SQL命中率。 计划即将下线，请勿使用。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("hit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? HitRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullSqlResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  applicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlExecId: ").Append(SqlExecId).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  allTime: ").Append(AllTime).Append("\n");
            sb.Append("  dbTime: ").Append(DbTime).Append("\n");
            sb.Append("  cpuTime: ").Append(CpuTime).Append("\n");
            sb.Append("  dataIoTime: ").Append(DataIoTime).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  scanLines: ").Append(ScanLines).Append("\n");
            sb.Append("  insertRows: ").Append(InsertRows).Append("\n");
            sb.Append("  updateRows: ").Append(UpdateRows).Append("\n");
            sb.Append("  deleteRows: ").Append(DeleteRows).Append("\n");
            sb.Append("  isSlowSql: ").Append(IsSlowSql).Append("\n");
            sb.Append("  startTimestamp: ").Append(StartTimestamp).Append("\n");
            sb.Append("  finishTimestamp: ").Append(FinishTimestamp).Append("\n");
            sb.Append("  hitRate: ").Append(HitRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullSqlResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullSqlResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.ApplicationName != input.ApplicationName || (this.ApplicationName != null && !this.ApplicationName.Equals(input.ApplicationName))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlExecId != input.SqlExecId || (this.SqlExecId != null && !this.SqlExecId.Equals(input.SqlExecId))) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.AllTime != input.AllTime || (this.AllTime != null && !this.AllTime.Equals(input.AllTime))) return false;
            if (this.DbTime != input.DbTime || (this.DbTime != null && !this.DbTime.Equals(input.DbTime))) return false;
            if (this.CpuTime != input.CpuTime || (this.CpuTime != null && !this.CpuTime.Equals(input.CpuTime))) return false;
            if (this.DataIoTime != input.DataIoTime || (this.DataIoTime != null && !this.DataIoTime.Equals(input.DataIoTime))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.ScanLines != input.ScanLines || (this.ScanLines != null && !this.ScanLines.Equals(input.ScanLines))) return false;
            if (this.InsertRows != input.InsertRows || (this.InsertRows != null && !this.InsertRows.Equals(input.InsertRows))) return false;
            if (this.UpdateRows != input.UpdateRows || (this.UpdateRows != null && !this.UpdateRows.Equals(input.UpdateRows))) return false;
            if (this.DeleteRows != input.DeleteRows || (this.DeleteRows != null && !this.DeleteRows.Equals(input.DeleteRows))) return false;
            if (this.IsSlowSql != input.IsSlowSql || (this.IsSlowSql != null && !this.IsSlowSql.Equals(input.IsSlowSql))) return false;
            if (this.StartTimestamp != input.StartTimestamp || (this.StartTimestamp != null && !this.StartTimestamp.Equals(input.StartTimestamp))) return false;
            if (this.FinishTimestamp != input.FinishTimestamp || (this.FinishTimestamp != null && !this.FinishTimestamp.Equals(input.FinishTimestamp))) return false;
            if (this.HitRate != input.HitRate || (this.HitRate != null && !this.HitRate.Equals(input.HitRate))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.ApplicationName != null) hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlExecId != null) hashCode = hashCode * 59 + this.SqlExecId.GetHashCode();
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Sql != null) hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.AllTime != null) hashCode = hashCode * 59 + this.AllTime.GetHashCode();
                if (this.DbTime != null) hashCode = hashCode * 59 + this.DbTime.GetHashCode();
                if (this.CpuTime != null) hashCode = hashCode * 59 + this.CpuTime.GetHashCode();
                if (this.DataIoTime != null) hashCode = hashCode * 59 + this.DataIoTime.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.ScanLines != null) hashCode = hashCode * 59 + this.ScanLines.GetHashCode();
                if (this.InsertRows != null) hashCode = hashCode * 59 + this.InsertRows.GetHashCode();
                if (this.UpdateRows != null) hashCode = hashCode * 59 + this.UpdateRows.GetHashCode();
                if (this.DeleteRows != null) hashCode = hashCode * 59 + this.DeleteRows.GetHashCode();
                if (this.IsSlowSql != null) hashCode = hashCode * 59 + this.IsSlowSql.GetHashCode();
                if (this.StartTimestamp != null) hashCode = hashCode * 59 + this.StartTimestamp.GetHashCode();
                if (this.FinishTimestamp != null) hashCode = hashCode * 59 + this.FinishTimestamp.GetHashCode();
                if (this.HitRate != null) hashCode = hashCode * 59 + this.HitRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
