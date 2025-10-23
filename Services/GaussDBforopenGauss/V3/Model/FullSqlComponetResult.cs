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
    /// 全量SQL组件信息
    /// </summary>
    public class FullSqlComponetResult 
    {

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
        /// **参数解释**: 原始节点。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("origin_node", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginNode { get; set; }

        /// <summary>
        /// **参数解释**: 用户名。 **取值范围**: 不涉及。
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
        /// **参数解释**: 当前语句的外层SQL的归一化SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("parent_sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentSqlId { get; set; }

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
        /// **参数解释**: 线程ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreadId { get; set; }

        /// <summary>
        /// **参数解释**: 会话ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

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
        /// **参数解释**: 慢SQL阈值。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("slow_query_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? SlowQueryThreshold { get; set; }

        /// <summary>
        /// **参数解释**: 软解析次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_soft_parse", NullValueHandling = NullValueHandling.Ignore)]
        public long? NSoftParse { get; set; }

        /// <summary>
        /// **参数解释**: 硬解析次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_hard_parse", NullValueHandling = NullValueHandling.Ignore)]
        public long? NHardParse { get; set; }

        /// <summary>
        /// **参数解释**: 执行计划。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_plan", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryPlan { get; set; }

        /// <summary>
        /// **参数解释**: SELECT语句的返回结果集行数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_return_rows", NullValueHandling = NullValueHandling.Ignore)]
        public long? NReturnRows { get; set; }

        /// <summary>
        /// **参数解释**: 随机扫描行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_tuples_fetched", NullValueHandling = NullValueHandling.Ignore)]
        public long? NTuplesFetched { get; set; }

        /// <summary>
        /// **参数解释**: 顺序扫描行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_tuples_returned", NullValueHandling = NullValueHandling.Ignore)]
        public long? NTuplesReturned { get; set; }

        /// <summary>
        /// **参数解释**: 插入行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_tuples_inserted", NullValueHandling = NullValueHandling.Ignore)]
        public long? NTuplesInserted { get; set; }

        /// <summary>
        /// **参数解释**: 更新行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_tuples_updated", NullValueHandling = NullValueHandling.Ignore)]
        public long? NTuplesUpdated { get; set; }

        /// <summary>
        /// **参数解释**: 删除行。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_tuples_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public long? NTuplesDeleted { get; set; }

        /// <summary>
        /// **参数解释**: buffer的块访问次数。 **取值范围**: 不涉及。\&quot;\&quot;
        /// </summary>
        [JsonProperty("n_blocks_fetched", NullValueHandling = NullValueHandling.Ignore)]
        public long? NBlocksFetched { get; set; }

        /// <summary>
        /// **参数解释**: buffer的块命中次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("n_blocks_hit", NullValueHandling = NullValueHandling.Ignore)]
        public long? NBlocksHit { get; set; }

        /// <summary>
        /// **参数解释**: 有效DB时间花费。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("db_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DbTime { get; set; }

        /// <summary>
        /// **参数解释**: CPU时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CpuTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行器内执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: SQL解析时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("parse_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParseTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行器内执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("plan_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanTime { get; set; }

        /// <summary>
        /// **参数解释**: SQL重写时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("rewrite_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RewriteTime { get; set; }

        /// <summary>
        /// **参数解释**: plpgsql上的执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("pl_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: plpgsql上的编译时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("pl_compilation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlCompilationTime { get; set; }

        /// <summary>
        /// **参数解释**: IO时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("data_io_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DataIoTime { get; set; }

        /// <summary>
        /// **参数解释**: 加锁次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lock_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? LockCount { get; set; }

        /// <summary>
        /// **参数解释**: 加锁耗时。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LockTime { get; set; }

        /// <summary>
        /// **参数解释**: 加锁等待次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lock_wait_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? LockWaitCount { get; set; }

        /// <summary>
        /// **参数解释**: 加锁等待时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lock_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LockWaitTime { get; set; }

        /// <summary>
        /// **参数解释**: 详细列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// **参数解释**: 是否慢SQL。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("is_slow_sql", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSlowSql { get; set; }

        /// <summary>
        /// **参数解释**: 可能导致该SQL为慢SQL的风险信息。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("advise", NullValueHandling = NullValueHandling.Ignore)]
        public string Advise { get; set; }

        /// <summary>
        /// **参数解释**: 语句完成状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("finish_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishStatus { get; set; }

        /// <summary>
        /// **参数解释**: 通过物理连接发送消息的网络状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("net_send_info", NullValueHandling = NullValueHandling.Ignore)]
        public string NetSendInfo { get; set; }

        /// <summary>
        /// **参数解释**: 通过物理连接接收消息的网络状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("net_recv_info", NullValueHandling = NullValueHandling.Ignore)]
        public string NetRecvInfo { get; set; }

        /// <summary>
        /// **参数解释**: 通过逻辑连接发送消息的网络状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("net_stream_send_info", NullValueHandling = NullValueHandling.Ignore)]
        public string NetStreamSendInfo { get; set; }

        /// <summary>
        /// **参数解释**: 通过逻辑连接接收消息的网络状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("net_stream_recv_info", NullValueHandling = NullValueHandling.Ignore)]
        public string NetStreamRecvInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullSqlComponetResult {\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  originNode: ").Append(OriginNode).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  applicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  parentSqlId: ").Append(ParentSqlId).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlExecId: ").Append(SqlExecId).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  threadId: ").Append(ThreadId).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  slowQueryThreshold: ").Append(SlowQueryThreshold).Append("\n");
            sb.Append("  nSoftParse: ").Append(NSoftParse).Append("\n");
            sb.Append("  nHardParse: ").Append(NHardParse).Append("\n");
            sb.Append("  queryPlan: ").Append(QueryPlan).Append("\n");
            sb.Append("  nReturnRows: ").Append(NReturnRows).Append("\n");
            sb.Append("  nTuplesFetched: ").Append(NTuplesFetched).Append("\n");
            sb.Append("  nTuplesReturned: ").Append(NTuplesReturned).Append("\n");
            sb.Append("  nTuplesInserted: ").Append(NTuplesInserted).Append("\n");
            sb.Append("  nTuplesUpdated: ").Append(NTuplesUpdated).Append("\n");
            sb.Append("  nTuplesDeleted: ").Append(NTuplesDeleted).Append("\n");
            sb.Append("  nBlocksFetched: ").Append(NBlocksFetched).Append("\n");
            sb.Append("  nBlocksHit: ").Append(NBlocksHit).Append("\n");
            sb.Append("  dbTime: ").Append(DbTime).Append("\n");
            sb.Append("  cpuTime: ").Append(CpuTime).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  parseTime: ").Append(ParseTime).Append("\n");
            sb.Append("  planTime: ").Append(PlanTime).Append("\n");
            sb.Append("  rewriteTime: ").Append(RewriteTime).Append("\n");
            sb.Append("  plExecutionTime: ").Append(PlExecutionTime).Append("\n");
            sb.Append("  plCompilationTime: ").Append(PlCompilationTime).Append("\n");
            sb.Append("  dataIoTime: ").Append(DataIoTime).Append("\n");
            sb.Append("  lockCount: ").Append(LockCount).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  lockWaitCount: ").Append(LockWaitCount).Append("\n");
            sb.Append("  lockWaitTime: ").Append(LockWaitTime).Append("\n");
            sb.Append("  details: ").Append(Details).Append("\n");
            sb.Append("  isSlowSql: ").Append(IsSlowSql).Append("\n");
            sb.Append("  advise: ").Append(Advise).Append("\n");
            sb.Append("  finishStatus: ").Append(FinishStatus).Append("\n");
            sb.Append("  netSendInfo: ").Append(NetSendInfo).Append("\n");
            sb.Append("  netRecvInfo: ").Append(NetRecvInfo).Append("\n");
            sb.Append("  netStreamSendInfo: ").Append(NetStreamSendInfo).Append("\n");
            sb.Append("  netStreamRecvInfo: ").Append(NetStreamRecvInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullSqlComponetResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullSqlComponetResult input)
        {
            if (input == null) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.OriginNode != input.OriginNode || (this.OriginNode != null && !this.OriginNode.Equals(input.OriginNode))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.ApplicationName != input.ApplicationName || (this.ApplicationName != null && !this.ApplicationName.Equals(input.ApplicationName))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.ParentSqlId != input.ParentSqlId || (this.ParentSqlId != null && !this.ParentSqlId.Equals(input.ParentSqlId))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlExecId != input.SqlExecId || (this.SqlExecId != null && !this.SqlExecId.Equals(input.SqlExecId))) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.ThreadId != input.ThreadId || (this.ThreadId != null && !this.ThreadId.Equals(input.ThreadId))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.SlowQueryThreshold != input.SlowQueryThreshold || (this.SlowQueryThreshold != null && !this.SlowQueryThreshold.Equals(input.SlowQueryThreshold))) return false;
            if (this.NSoftParse != input.NSoftParse || (this.NSoftParse != null && !this.NSoftParse.Equals(input.NSoftParse))) return false;
            if (this.NHardParse != input.NHardParse || (this.NHardParse != null && !this.NHardParse.Equals(input.NHardParse))) return false;
            if (this.QueryPlan != input.QueryPlan || (this.QueryPlan != null && !this.QueryPlan.Equals(input.QueryPlan))) return false;
            if (this.NReturnRows != input.NReturnRows || (this.NReturnRows != null && !this.NReturnRows.Equals(input.NReturnRows))) return false;
            if (this.NTuplesFetched != input.NTuplesFetched || (this.NTuplesFetched != null && !this.NTuplesFetched.Equals(input.NTuplesFetched))) return false;
            if (this.NTuplesReturned != input.NTuplesReturned || (this.NTuplesReturned != null && !this.NTuplesReturned.Equals(input.NTuplesReturned))) return false;
            if (this.NTuplesInserted != input.NTuplesInserted || (this.NTuplesInserted != null && !this.NTuplesInserted.Equals(input.NTuplesInserted))) return false;
            if (this.NTuplesUpdated != input.NTuplesUpdated || (this.NTuplesUpdated != null && !this.NTuplesUpdated.Equals(input.NTuplesUpdated))) return false;
            if (this.NTuplesDeleted != input.NTuplesDeleted || (this.NTuplesDeleted != null && !this.NTuplesDeleted.Equals(input.NTuplesDeleted))) return false;
            if (this.NBlocksFetched != input.NBlocksFetched || (this.NBlocksFetched != null && !this.NBlocksFetched.Equals(input.NBlocksFetched))) return false;
            if (this.NBlocksHit != input.NBlocksHit || (this.NBlocksHit != null && !this.NBlocksHit.Equals(input.NBlocksHit))) return false;
            if (this.DbTime != input.DbTime || (this.DbTime != null && !this.DbTime.Equals(input.DbTime))) return false;
            if (this.CpuTime != input.CpuTime || (this.CpuTime != null && !this.CpuTime.Equals(input.CpuTime))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.ParseTime != input.ParseTime || (this.ParseTime != null && !this.ParseTime.Equals(input.ParseTime))) return false;
            if (this.PlanTime != input.PlanTime || (this.PlanTime != null && !this.PlanTime.Equals(input.PlanTime))) return false;
            if (this.RewriteTime != input.RewriteTime || (this.RewriteTime != null && !this.RewriteTime.Equals(input.RewriteTime))) return false;
            if (this.PlExecutionTime != input.PlExecutionTime || (this.PlExecutionTime != null && !this.PlExecutionTime.Equals(input.PlExecutionTime))) return false;
            if (this.PlCompilationTime != input.PlCompilationTime || (this.PlCompilationTime != null && !this.PlCompilationTime.Equals(input.PlCompilationTime))) return false;
            if (this.DataIoTime != input.DataIoTime || (this.DataIoTime != null && !this.DataIoTime.Equals(input.DataIoTime))) return false;
            if (this.LockCount != input.LockCount || (this.LockCount != null && !this.LockCount.Equals(input.LockCount))) return false;
            if (this.LockTime != input.LockTime || (this.LockTime != null && !this.LockTime.Equals(input.LockTime))) return false;
            if (this.LockWaitCount != input.LockWaitCount || (this.LockWaitCount != null && !this.LockWaitCount.Equals(input.LockWaitCount))) return false;
            if (this.LockWaitTime != input.LockWaitTime || (this.LockWaitTime != null && !this.LockWaitTime.Equals(input.LockWaitTime))) return false;
            if (this.Details != input.Details || (this.Details != null && !this.Details.Equals(input.Details))) return false;
            if (this.IsSlowSql != input.IsSlowSql || (this.IsSlowSql != null && !this.IsSlowSql.Equals(input.IsSlowSql))) return false;
            if (this.Advise != input.Advise || (this.Advise != null && !this.Advise.Equals(input.Advise))) return false;
            if (this.FinishStatus != input.FinishStatus || (this.FinishStatus != null && !this.FinishStatus.Equals(input.FinishStatus))) return false;
            if (this.NetSendInfo != input.NetSendInfo || (this.NetSendInfo != null && !this.NetSendInfo.Equals(input.NetSendInfo))) return false;
            if (this.NetRecvInfo != input.NetRecvInfo || (this.NetRecvInfo != null && !this.NetRecvInfo.Equals(input.NetRecvInfo))) return false;
            if (this.NetStreamSendInfo != input.NetStreamSendInfo || (this.NetStreamSendInfo != null && !this.NetStreamSendInfo.Equals(input.NetStreamSendInfo))) return false;
            if (this.NetStreamRecvInfo != input.NetStreamRecvInfo || (this.NetStreamRecvInfo != null && !this.NetStreamRecvInfo.Equals(input.NetStreamRecvInfo))) return false;

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
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.OriginNode != null) hashCode = hashCode * 59 + this.OriginNode.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.ApplicationName != null) hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.ParentSqlId != null) hashCode = hashCode * 59 + this.ParentSqlId.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlExecId != null) hashCode = hashCode * 59 + this.SqlExecId.GetHashCode();
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.ThreadId != null) hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SlowQueryThreshold != null) hashCode = hashCode * 59 + this.SlowQueryThreshold.GetHashCode();
                if (this.NSoftParse != null) hashCode = hashCode * 59 + this.NSoftParse.GetHashCode();
                if (this.NHardParse != null) hashCode = hashCode * 59 + this.NHardParse.GetHashCode();
                if (this.QueryPlan != null) hashCode = hashCode * 59 + this.QueryPlan.GetHashCode();
                if (this.NReturnRows != null) hashCode = hashCode * 59 + this.NReturnRows.GetHashCode();
                if (this.NTuplesFetched != null) hashCode = hashCode * 59 + this.NTuplesFetched.GetHashCode();
                if (this.NTuplesReturned != null) hashCode = hashCode * 59 + this.NTuplesReturned.GetHashCode();
                if (this.NTuplesInserted != null) hashCode = hashCode * 59 + this.NTuplesInserted.GetHashCode();
                if (this.NTuplesUpdated != null) hashCode = hashCode * 59 + this.NTuplesUpdated.GetHashCode();
                if (this.NTuplesDeleted != null) hashCode = hashCode * 59 + this.NTuplesDeleted.GetHashCode();
                if (this.NBlocksFetched != null) hashCode = hashCode * 59 + this.NBlocksFetched.GetHashCode();
                if (this.NBlocksHit != null) hashCode = hashCode * 59 + this.NBlocksHit.GetHashCode();
                if (this.DbTime != null) hashCode = hashCode * 59 + this.DbTime.GetHashCode();
                if (this.CpuTime != null) hashCode = hashCode * 59 + this.CpuTime.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.ParseTime != null) hashCode = hashCode * 59 + this.ParseTime.GetHashCode();
                if (this.PlanTime != null) hashCode = hashCode * 59 + this.PlanTime.GetHashCode();
                if (this.RewriteTime != null) hashCode = hashCode * 59 + this.RewriteTime.GetHashCode();
                if (this.PlExecutionTime != null) hashCode = hashCode * 59 + this.PlExecutionTime.GetHashCode();
                if (this.PlCompilationTime != null) hashCode = hashCode * 59 + this.PlCompilationTime.GetHashCode();
                if (this.DataIoTime != null) hashCode = hashCode * 59 + this.DataIoTime.GetHashCode();
                if (this.LockCount != null) hashCode = hashCode * 59 + this.LockCount.GetHashCode();
                if (this.LockTime != null) hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.LockWaitCount != null) hashCode = hashCode * 59 + this.LockWaitCount.GetHashCode();
                if (this.LockWaitTime != null) hashCode = hashCode * 59 + this.LockWaitTime.GetHashCode();
                if (this.Details != null) hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.IsSlowSql != null) hashCode = hashCode * 59 + this.IsSlowSql.GetHashCode();
                if (this.Advise != null) hashCode = hashCode * 59 + this.Advise.GetHashCode();
                if (this.FinishStatus != null) hashCode = hashCode * 59 + this.FinishStatus.GetHashCode();
                if (this.NetSendInfo != null) hashCode = hashCode * 59 + this.NetSendInfo.GetHashCode();
                if (this.NetRecvInfo != null) hashCode = hashCode * 59 + this.NetRecvInfo.GetHashCode();
                if (this.NetStreamSendInfo != null) hashCode = hashCode * 59 + this.NetStreamSendInfo.GetHashCode();
                if (this.NetStreamRecvInfo != null) hashCode = hashCode * 59 + this.NetStreamRecvInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
