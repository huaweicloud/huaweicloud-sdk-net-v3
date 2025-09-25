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
    public class WaitEventResult 
    {

        /// <summary>
        /// **参数解释**: 会话ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// **参数解释**: 线程ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        /// **参数解释**: 等待事件。 参见“开发指南 &gt; 系统表和系统视图 &gt; 系统视图 &gt; 其他系统视图 &gt; PG_THREAD_WAIT_STATUS”中的wait_event字段。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("wait_event", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitEvent { get; set; }

        /// <summary>
        /// **参数解释**: 等待状态。 参见“开发指南 &gt; 系统表和系统视图 &gt; 系统视图 &gt; 其他系统视图 &gt; PG_THREAD_WAIT_STATUS”中的等待状态列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("wait_status", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitStatus { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**: 用户名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: 客户端地址。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientAddr { get; set; }

        /// <summary>
        /// **参数解释**: 客户端用于与后台通讯的TCP端口号。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPort { get; set; }

        /// <summary>
        /// **参数解释**: 会话持续时间，单位：秒。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("session_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionTime { get; set; }

        /// <summary>
        /// **参数解释**: 会话开始时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("xact_start", NullValueHandling = NullValueHandling.Ignore)]
        public string XactStart { get; set; }

        /// <summary>
        /// **参数解释**: 事务持续时间，单位秒。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionTime { get; set; }

        /// <summary>
        /// **参数解释**: 查询开始时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_start", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryStart { get; set; }

        /// <summary>
        /// **参数解释**: 上次状态改变的时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("state_change", NullValueHandling = NullValueHandling.Ignore)]
        public string StateChange { get; set; }

        /// <summary>
        /// **参数解释**: 查询持续时间，单位秒。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryTime { get; set; }

        /// <summary>
        /// **参数解释**: 会话开始时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("backend_start", NullValueHandling = NullValueHandling.Ignore)]
        public string BackendStart { get; set; }

        /// <summary>
        /// **参数解释**: 是否在等待锁。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("waiting", NullValueHandling = NullValueHandling.Ignore)]
        public string Waiting { get; set; }

        /// <summary>
        /// **参数解释**: （等待获取的）锁模式。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lockmode", NullValueHandling = NullValueHandling.Ignore)]
        public string Lockmode { get; set; }

        /// <summary>
        /// **参数解释**: 阻塞会话ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("block_sessionid", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockSessionid { get; set; }

        /// <summary>
        /// **参数解释**: 阻塞会话数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("block_count", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockCount { get; set; }

        /// <summary>
        /// **参数解释**: 归一化SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("unique_sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSqlId { get; set; }

        /// <summary>
        /// **参数解释**: 查询 ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// **参数解释**: SQL文本。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// **参数解释**: 当前事务ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("current_xid", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentXid { get; set; }

        /// <summary>
        /// **参数解释**: 顶层事务ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("top_xid", NullValueHandling = NullValueHandling.Ignore)]
        public string TopXid { get; set; }

        /// <summary>
        /// **参数解释**: 事务当前使用的XLOG量，单位为字节。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("xlog_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string XlogQuantity { get; set; }

        /// <summary>
        /// **参数解释**: 该会话当前总体状态。 **取值范围**: -active：后台正在执行一个查询。 -idle：后台正在等待一个新的客户端命令。 -idle in transaction：后台在事务中，但事务中没有语句在执行。 -fastpath function call：后台正在执行一个fast-path函数。 -disabled：如果后台禁用track_activities，则事务显示此状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**: 应用名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("application_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// **参数解释**: 连接信息。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("connection_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitEventResult {\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  pid: ").Append(Pid).Append("\n");
            sb.Append("  waitEvent: ").Append(WaitEvent).Append("\n");
            sb.Append("  waitStatus: ").Append(WaitStatus).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  sessionTime: ").Append(SessionTime).Append("\n");
            sb.Append("  xactStart: ").Append(XactStart).Append("\n");
            sb.Append("  transactionTime: ").Append(TransactionTime).Append("\n");
            sb.Append("  queryStart: ").Append(QueryStart).Append("\n");
            sb.Append("  stateChange: ").Append(StateChange).Append("\n");
            sb.Append("  queryTime: ").Append(QueryTime).Append("\n");
            sb.Append("  backendStart: ").Append(BackendStart).Append("\n");
            sb.Append("  waiting: ").Append(Waiting).Append("\n");
            sb.Append("  lockmode: ").Append(Lockmode).Append("\n");
            sb.Append("  blockSessionid: ").Append(BlockSessionid).Append("\n");
            sb.Append("  blockCount: ").Append(BlockCount).Append("\n");
            sb.Append("  uniqueSqlId: ").Append(UniqueSqlId).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  currentXid: ").Append(CurrentXid).Append("\n");
            sb.Append("  topXid: ").Append(TopXid).Append("\n");
            sb.Append("  xlogQuantity: ").Append(XlogQuantity).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  applicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  connectionInfo: ").Append(ConnectionInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WaitEventResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WaitEventResult input)
        {
            if (input == null) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.Pid != input.Pid || (this.Pid != null && !this.Pid.Equals(input.Pid))) return false;
            if (this.WaitEvent != input.WaitEvent || (this.WaitEvent != null && !this.WaitEvent.Equals(input.WaitEvent))) return false;
            if (this.WaitStatus != input.WaitStatus || (this.WaitStatus != null && !this.WaitStatus.Equals(input.WaitStatus))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.SessionTime != input.SessionTime || (this.SessionTime != null && !this.SessionTime.Equals(input.SessionTime))) return false;
            if (this.XactStart != input.XactStart || (this.XactStart != null && !this.XactStart.Equals(input.XactStart))) return false;
            if (this.TransactionTime != input.TransactionTime || (this.TransactionTime != null && !this.TransactionTime.Equals(input.TransactionTime))) return false;
            if (this.QueryStart != input.QueryStart || (this.QueryStart != null && !this.QueryStart.Equals(input.QueryStart))) return false;
            if (this.StateChange != input.StateChange || (this.StateChange != null && !this.StateChange.Equals(input.StateChange))) return false;
            if (this.QueryTime != input.QueryTime || (this.QueryTime != null && !this.QueryTime.Equals(input.QueryTime))) return false;
            if (this.BackendStart != input.BackendStart || (this.BackendStart != null && !this.BackendStart.Equals(input.BackendStart))) return false;
            if (this.Waiting != input.Waiting || (this.Waiting != null && !this.Waiting.Equals(input.Waiting))) return false;
            if (this.Lockmode != input.Lockmode || (this.Lockmode != null && !this.Lockmode.Equals(input.Lockmode))) return false;
            if (this.BlockSessionid != input.BlockSessionid || (this.BlockSessionid != null && !this.BlockSessionid.Equals(input.BlockSessionid))) return false;
            if (this.BlockCount != input.BlockCount || (this.BlockCount != null && !this.BlockCount.Equals(input.BlockCount))) return false;
            if (this.UniqueSqlId != input.UniqueSqlId || (this.UniqueSqlId != null && !this.UniqueSqlId.Equals(input.UniqueSqlId))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.CurrentXid != input.CurrentXid || (this.CurrentXid != null && !this.CurrentXid.Equals(input.CurrentXid))) return false;
            if (this.TopXid != input.TopXid || (this.TopXid != null && !this.TopXid.Equals(input.TopXid))) return false;
            if (this.XlogQuantity != input.XlogQuantity || (this.XlogQuantity != null && !this.XlogQuantity.Equals(input.XlogQuantity))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.ApplicationName != input.ApplicationName || (this.ApplicationName != null && !this.ApplicationName.Equals(input.ApplicationName))) return false;
            if (this.ConnectionInfo != input.ConnectionInfo || (this.ConnectionInfo != null && !this.ConnectionInfo.Equals(input.ConnectionInfo))) return false;

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
                if (this.WaitEvent != null) hashCode = hashCode * 59 + this.WaitEvent.GetHashCode();
                if (this.WaitStatus != null) hashCode = hashCode * 59 + this.WaitStatus.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.SessionTime != null) hashCode = hashCode * 59 + this.SessionTime.GetHashCode();
                if (this.XactStart != null) hashCode = hashCode * 59 + this.XactStart.GetHashCode();
                if (this.TransactionTime != null) hashCode = hashCode * 59 + this.TransactionTime.GetHashCode();
                if (this.QueryStart != null) hashCode = hashCode * 59 + this.QueryStart.GetHashCode();
                if (this.StateChange != null) hashCode = hashCode * 59 + this.StateChange.GetHashCode();
                if (this.QueryTime != null) hashCode = hashCode * 59 + this.QueryTime.GetHashCode();
                if (this.BackendStart != null) hashCode = hashCode * 59 + this.BackendStart.GetHashCode();
                if (this.Waiting != null) hashCode = hashCode * 59 + this.Waiting.GetHashCode();
                if (this.Lockmode != null) hashCode = hashCode * 59 + this.Lockmode.GetHashCode();
                if (this.BlockSessionid != null) hashCode = hashCode * 59 + this.BlockSessionid.GetHashCode();
                if (this.BlockCount != null) hashCode = hashCode * 59 + this.BlockCount.GetHashCode();
                if (this.UniqueSqlId != null) hashCode = hashCode * 59 + this.UniqueSqlId.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.CurrentXid != null) hashCode = hashCode * 59 + this.CurrentXid.GetHashCode();
                if (this.TopXid != null) hashCode = hashCode * 59 + this.TopXid.GetHashCode();
                if (this.XlogQuantity != null) hashCode = hashCode * 59 + this.XlogQuantity.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ApplicationName != null) hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ConnectionInfo != null) hashCode = hashCode * 59 + this.ConnectionInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
