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
    public class RealTimeSessionResult 
    {

        /// <summary>
        /// **参数解释**： 会话ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// **参数解释**： 线程ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        /// **参数解释**： SQL ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("unique_sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSqlId { get; set; }

        /// <summary>
        /// **参数解释**： 数据库名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**： 客户端IP。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// **参数解释**： 用户名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**： 是否等待。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("wait", NullValueHandling = NullValueHandling.Ignore)]
        public string Wait { get; set; }

        /// <summary>
        /// **参数解释**： 阻塞会话。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("block_session", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockSession { get; set; }

        /// <summary>
        /// **参数解释**： 等待事件。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("wait_event", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitEvent { get; set; }

        /// <summary>
        /// **参数解释**： 状态。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**： 语句执行时长。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("query_runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryRuntime { get; set; }

        /// <summary>
        /// **参数解释**： SQL文本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// **参数解释**： 会话开始时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("back_end_start", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackEndStart { get; set; }

        /// <summary>
        /// **参数解释**： 事务开始时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("transaction_start", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionStart { get; set; }

        /// <summary>
        /// **参数解释**： 语句开始时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("query_start", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryStart { get; set; }

        /// <summary>
        /// **参数解释**： 应用名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("application_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// **参数解释**： 会话执行时长（单位：秒）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecTime { get; set; }

        /// <summary>
        /// **参数解释**： 会话建立事务的数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("trans_num", NullValueHandling = NullValueHandling.Ignore)]
        public string TransNum { get; set; }

        /// <summary>
        /// **参数解释**： 会话中事务回滚的次数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("rollback_num", NullValueHandling = NullValueHandling.Ignore)]
        public string RollbackNum { get; set; }

        /// <summary>
        /// **参数解释**： 会话执行的sql数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("sql_num", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlNum { get; set; }

        /// <summary>
        /// **参数解释**： 客户端用于与后台通讯的TCP端口号，如果使用Unix套接字，则为-1。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPort { get; set; }

        /// <summary>
        /// **参数解释**： 会话执行的sql数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// **参数解释**： 当前用户上一次执行的事务持续时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("transaction_time_cost", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionTimeCost { get; set; }

        /// <summary>
        /// **参数解释**： 驱动传入的trace id，用于标识应用的一次请求。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// **参数解释**： 当前用户上次执行的全局会话ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("global_session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalSessionId { get; set; }

        /// <summary>
        /// **参数解释**： 当前用户上次执行的顶层事务ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("top_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TopTransactionId { get; set; }

        /// <summary>
        /// **参数解释**： 当前用户上次执行的事务ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("current_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTransactionId { get; set; }

        /// <summary>
        /// **参数解释**： 当前用户上次执行的事务使用的XLOG量，易读格式。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("xlog_quantity_pretty", NullValueHandling = NullValueHandling.Ignore)]
        public string XlogQuantityPretty { get; set; }

        /// <summary>
        /// **参数解释**： 实例线程等待状态。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("wait_status", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitStatus { get; set; }

        /// <summary>
        /// **参数解释**： 实例线程的轻量级线程号。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("lwt_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LwtId { get; set; }

        /// <summary>
        /// **参数解释**： 实例线程名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("thread_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreadName { get; set; }

        /// <summary>
        /// **参数解释**： 实例等锁模式。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("lock_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string LockMode { get; set; }

        /// <summary>
        /// **参数解释**： 实例父会话ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("parent_session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentSessionId { get; set; }

        /// <summary>
        /// **参数解释**： 实例并行线程的ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("smp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SmpId { get; set; }

        /// <summary>
        /// **参数解释**： 实例线程正等待获取的锁的信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("lock_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTag { get; set; }

        /// <summary>
        /// **参数解释**： 组件名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeSessionResult {\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  pid: ").Append(Pid).Append("\n");
            sb.Append("  uniqueSqlId: ").Append(UniqueSqlId).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  wait: ").Append(Wait).Append("\n");
            sb.Append("  blockSession: ").Append(BlockSession).Append("\n");
            sb.Append("  waitEvent: ").Append(WaitEvent).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  queryRuntime: ").Append(QueryRuntime).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  backEndStart: ").Append(BackEndStart).Append("\n");
            sb.Append("  transactionStart: ").Append(TransactionStart).Append("\n");
            sb.Append("  queryStart: ").Append(QueryStart).Append("\n");
            sb.Append("  applicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  execTime: ").Append(ExecTime).Append("\n");
            sb.Append("  transNum: ").Append(TransNum).Append("\n");
            sb.Append("  rollbackNum: ").Append(RollbackNum).Append("\n");
            sb.Append("  sqlNum: ").Append(SqlNum).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  transactionTimeCost: ").Append(TransactionTimeCost).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  globalSessionId: ").Append(GlobalSessionId).Append("\n");
            sb.Append("  topTransactionId: ").Append(TopTransactionId).Append("\n");
            sb.Append("  currentTransactionId: ").Append(CurrentTransactionId).Append("\n");
            sb.Append("  xlogQuantityPretty: ").Append(XlogQuantityPretty).Append("\n");
            sb.Append("  waitStatus: ").Append(WaitStatus).Append("\n");
            sb.Append("  lwtId: ").Append(LwtId).Append("\n");
            sb.Append("  threadName: ").Append(ThreadName).Append("\n");
            sb.Append("  lockMode: ").Append(LockMode).Append("\n");
            sb.Append("  parentSessionId: ").Append(ParentSessionId).Append("\n");
            sb.Append("  smpId: ").Append(SmpId).Append("\n");
            sb.Append("  lockTag: ").Append(LockTag).Append("\n");
            sb.Append("  componentName: ").Append(ComponentName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealTimeSessionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealTimeSessionResult input)
        {
            if (input == null) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.Pid != input.Pid || (this.Pid != null && !this.Pid.Equals(input.Pid))) return false;
            if (this.UniqueSqlId != input.UniqueSqlId || (this.UniqueSqlId != null && !this.UniqueSqlId.Equals(input.UniqueSqlId))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.ClientIp != input.ClientIp || (this.ClientIp != null && !this.ClientIp.Equals(input.ClientIp))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Wait != input.Wait || (this.Wait != null && !this.Wait.Equals(input.Wait))) return false;
            if (this.BlockSession != input.BlockSession || (this.BlockSession != null && !this.BlockSession.Equals(input.BlockSession))) return false;
            if (this.WaitEvent != input.WaitEvent || (this.WaitEvent != null && !this.WaitEvent.Equals(input.WaitEvent))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.QueryRuntime != input.QueryRuntime || (this.QueryRuntime != null && !this.QueryRuntime.Equals(input.QueryRuntime))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.BackEndStart != input.BackEndStart || (this.BackEndStart != null && !this.BackEndStart.Equals(input.BackEndStart))) return false;
            if (this.TransactionStart != input.TransactionStart || (this.TransactionStart != null && !this.TransactionStart.Equals(input.TransactionStart))) return false;
            if (this.QueryStart != input.QueryStart || (this.QueryStart != null && !this.QueryStart.Equals(input.QueryStart))) return false;
            if (this.ApplicationName != input.ApplicationName || (this.ApplicationName != null && !this.ApplicationName.Equals(input.ApplicationName))) return false;
            if (this.ExecTime != input.ExecTime || (this.ExecTime != null && !this.ExecTime.Equals(input.ExecTime))) return false;
            if (this.TransNum != input.TransNum || (this.TransNum != null && !this.TransNum.Equals(input.TransNum))) return false;
            if (this.RollbackNum != input.RollbackNum || (this.RollbackNum != null && !this.RollbackNum.Equals(input.RollbackNum))) return false;
            if (this.SqlNum != input.SqlNum || (this.SqlNum != null && !this.SqlNum.Equals(input.SqlNum))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.TransactionTimeCost != input.TransactionTimeCost || (this.TransactionTimeCost != null && !this.TransactionTimeCost.Equals(input.TransactionTimeCost))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.GlobalSessionId != input.GlobalSessionId || (this.GlobalSessionId != null && !this.GlobalSessionId.Equals(input.GlobalSessionId))) return false;
            if (this.TopTransactionId != input.TopTransactionId || (this.TopTransactionId != null && !this.TopTransactionId.Equals(input.TopTransactionId))) return false;
            if (this.CurrentTransactionId != input.CurrentTransactionId || (this.CurrentTransactionId != null && !this.CurrentTransactionId.Equals(input.CurrentTransactionId))) return false;
            if (this.XlogQuantityPretty != input.XlogQuantityPretty || (this.XlogQuantityPretty != null && !this.XlogQuantityPretty.Equals(input.XlogQuantityPretty))) return false;
            if (this.WaitStatus != input.WaitStatus || (this.WaitStatus != null && !this.WaitStatus.Equals(input.WaitStatus))) return false;
            if (this.LwtId != input.LwtId || (this.LwtId != null && !this.LwtId.Equals(input.LwtId))) return false;
            if (this.ThreadName != input.ThreadName || (this.ThreadName != null && !this.ThreadName.Equals(input.ThreadName))) return false;
            if (this.LockMode != input.LockMode || (this.LockMode != null && !this.LockMode.Equals(input.LockMode))) return false;
            if (this.ParentSessionId != input.ParentSessionId || (this.ParentSessionId != null && !this.ParentSessionId.Equals(input.ParentSessionId))) return false;
            if (this.SmpId != input.SmpId || (this.SmpId != null && !this.SmpId.Equals(input.SmpId))) return false;
            if (this.LockTag != input.LockTag || (this.LockTag != null && !this.LockTag.Equals(input.LockTag))) return false;
            if (this.ComponentName != input.ComponentName || (this.ComponentName != null && !this.ComponentName.Equals(input.ComponentName))) return false;

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
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.Pid != null) hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.UniqueSqlId != null) hashCode = hashCode * 59 + this.UniqueSqlId.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.ClientIp != null) hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Wait != null) hashCode = hashCode * 59 + this.Wait.GetHashCode();
                if (this.BlockSession != null) hashCode = hashCode * 59 + this.BlockSession.GetHashCode();
                if (this.WaitEvent != null) hashCode = hashCode * 59 + this.WaitEvent.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.QueryRuntime != null) hashCode = hashCode * 59 + this.QueryRuntime.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.BackEndStart != null) hashCode = hashCode * 59 + this.BackEndStart.GetHashCode();
                if (this.TransactionStart != null) hashCode = hashCode * 59 + this.TransactionStart.GetHashCode();
                if (this.QueryStart != null) hashCode = hashCode * 59 + this.QueryStart.GetHashCode();
                if (this.ApplicationName != null) hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ExecTime != null) hashCode = hashCode * 59 + this.ExecTime.GetHashCode();
                if (this.TransNum != null) hashCode = hashCode * 59 + this.TransNum.GetHashCode();
                if (this.RollbackNum != null) hashCode = hashCode * 59 + this.RollbackNum.GetHashCode();
                if (this.SqlNum != null) hashCode = hashCode * 59 + this.SqlNum.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.TransactionTimeCost != null) hashCode = hashCode * 59 + this.TransactionTimeCost.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.GlobalSessionId != null) hashCode = hashCode * 59 + this.GlobalSessionId.GetHashCode();
                if (this.TopTransactionId != null) hashCode = hashCode * 59 + this.TopTransactionId.GetHashCode();
                if (this.CurrentTransactionId != null) hashCode = hashCode * 59 + this.CurrentTransactionId.GetHashCode();
                if (this.XlogQuantityPretty != null) hashCode = hashCode * 59 + this.XlogQuantityPretty.GetHashCode();
                if (this.WaitStatus != null) hashCode = hashCode * 59 + this.WaitStatus.GetHashCode();
                if (this.LwtId != null) hashCode = hashCode * 59 + this.LwtId.GetHashCode();
                if (this.ThreadName != null) hashCode = hashCode * 59 + this.ThreadName.GetHashCode();
                if (this.LockMode != null) hashCode = hashCode * 59 + this.LockMode.GetHashCode();
                if (this.ParentSessionId != null) hashCode = hashCode * 59 + this.ParentSessionId.GetHashCode();
                if (this.SmpId != null) hashCode = hashCode * 59 + this.SmpId.GetHashCode();
                if (this.LockTag != null) hashCode = hashCode * 59 + this.LockTag.GetHashCode();
                if (this.ComponentName != null) hashCode = hashCode * 59 + this.ComponentName.GetHashCode();
                return hashCode;
            }
        }
    }
}
