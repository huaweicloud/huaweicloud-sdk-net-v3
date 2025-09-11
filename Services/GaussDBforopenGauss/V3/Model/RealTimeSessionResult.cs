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
                return hashCode;
            }
        }
    }
}
