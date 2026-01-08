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
    public class ListTransactionResponseBodyRows 
    {

        /// <summary>
        /// **参数解释**: 事务ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sessionid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sessionid { get; set; }

        /// <summary>
        /// **参数解释**: 线程ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pid { get; set; }

        /// <summary>
        /// **参数解释**: SQL查询ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryId { get; set; }

        /// <summary>
        /// **参数解释**: 数据库。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("datname", NullValueHandling = NullValueHandling.Ignore)]
        public string Datname { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起事务请求的客户端地址。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientAddr { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起事务请求的客户端端口。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientPort { get; set; }

        /// <summary>
        /// **参数解释**: 用户名。 **取值范围**: 不涉及。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("usename", NullValueHandling = NullValueHandling.Ignore)]
        public string Usename { get; set; }

        /// <summary>
        /// **参数解释**: 查询的SQL语句。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// **参数解释**: 会话开始时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("backend_start", NullValueHandling = NullValueHandling.Ignore)]
        public string BackendStart { get; set; }

        /// <summary>
        /// **参数解释**: 事务开始时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("xact_start", NullValueHandling = NullValueHandling.Ignore)]
        public string XactStart { get; set; }

        /// <summary>
        /// **参数解释**: 应用名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("application_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// **参数解释**: 事务状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**: 事务变更时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("state_change", NullValueHandling = NullValueHandling.Ignore)]
        public string StateChange { get; set; }

        /// <summary>
        /// **参数解释**: 查询开始时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("query_start", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryStart { get; set; }

        /// <summary>
        /// **参数解释**: 是否等待。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("waiting", NullValueHandling = NullValueHandling.Ignore)]
        public string Waiting { get; set; }

        /// <summary>
        /// **参数解释**: 归一化ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("unique_sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UniqueSqlId { get; set; }

        /// <summary>
        /// **参数解释**: 顶层事务ID。
        /// </summary>
        [JsonProperty("top_xid", NullValueHandling = NullValueHandling.Ignore)]
        public string TopXid { get; set; }

        /// <summary>
        /// **参数解释**: 当前事务ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("current_xid", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentXid { get; set; }

        /// <summary>
        /// **参数解释**: 事务执行时长。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecTime { get; set; }

        /// <summary>
        /// **参数解释**: 事务xlog量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("xlog_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? XlogQuantity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransactionResponseBodyRows {\n");
            sb.Append("  sessionid: ").Append(Sessionid).Append("\n");
            sb.Append("  pid: ").Append(Pid).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  datname: ").Append(Datname).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  usename: ").Append(Usename).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  backendStart: ").Append(BackendStart).Append("\n");
            sb.Append("  xactStart: ").Append(XactStart).Append("\n");
            sb.Append("  applicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  stateChange: ").Append(StateChange).Append("\n");
            sb.Append("  queryStart: ").Append(QueryStart).Append("\n");
            sb.Append("  waiting: ").Append(Waiting).Append("\n");
            sb.Append("  uniqueSqlId: ").Append(UniqueSqlId).Append("\n");
            sb.Append("  topXid: ").Append(TopXid).Append("\n");
            sb.Append("  currentXid: ").Append(CurrentXid).Append("\n");
            sb.Append("  execTime: ").Append(ExecTime).Append("\n");
            sb.Append("  xlogQuantity: ").Append(XlogQuantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTransactionResponseBodyRows);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTransactionResponseBodyRows input)
        {
            if (input == null) return false;
            if (this.Sessionid != input.Sessionid || (this.Sessionid != null && !this.Sessionid.Equals(input.Sessionid))) return false;
            if (this.Pid != input.Pid || (this.Pid != null && !this.Pid.Equals(input.Pid))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.Datname != input.Datname || (this.Datname != null && !this.Datname.Equals(input.Datname))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.Usename != input.Usename || (this.Usename != null && !this.Usename.Equals(input.Usename))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.BackendStart != input.BackendStart || (this.BackendStart != null && !this.BackendStart.Equals(input.BackendStart))) return false;
            if (this.XactStart != input.XactStart || (this.XactStart != null && !this.XactStart.Equals(input.XactStart))) return false;
            if (this.ApplicationName != input.ApplicationName || (this.ApplicationName != null && !this.ApplicationName.Equals(input.ApplicationName))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.StateChange != input.StateChange || (this.StateChange != null && !this.StateChange.Equals(input.StateChange))) return false;
            if (this.QueryStart != input.QueryStart || (this.QueryStart != null && !this.QueryStart.Equals(input.QueryStart))) return false;
            if (this.Waiting != input.Waiting || (this.Waiting != null && !this.Waiting.Equals(input.Waiting))) return false;
            if (this.UniqueSqlId != input.UniqueSqlId || (this.UniqueSqlId != null && !this.UniqueSqlId.Equals(input.UniqueSqlId))) return false;
            if (this.TopXid != input.TopXid || (this.TopXid != null && !this.TopXid.Equals(input.TopXid))) return false;
            if (this.CurrentXid != input.CurrentXid || (this.CurrentXid != null && !this.CurrentXid.Equals(input.CurrentXid))) return false;
            if (this.ExecTime != input.ExecTime || (this.ExecTime != null && !this.ExecTime.Equals(input.ExecTime))) return false;
            if (this.XlogQuantity != input.XlogQuantity || (this.XlogQuantity != null && !this.XlogQuantity.Equals(input.XlogQuantity))) return false;

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
                if (this.Sessionid != null) hashCode = hashCode * 59 + this.Sessionid.GetHashCode();
                if (this.Pid != null) hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.Datname != null) hashCode = hashCode * 59 + this.Datname.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.Usename != null) hashCode = hashCode * 59 + this.Usename.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.BackendStart != null) hashCode = hashCode * 59 + this.BackendStart.GetHashCode();
                if (this.XactStart != null) hashCode = hashCode * 59 + this.XactStart.GetHashCode();
                if (this.ApplicationName != null) hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateChange != null) hashCode = hashCode * 59 + this.StateChange.GetHashCode();
                if (this.QueryStart != null) hashCode = hashCode * 59 + this.QueryStart.GetHashCode();
                if (this.Waiting != null) hashCode = hashCode * 59 + this.Waiting.GetHashCode();
                if (this.UniqueSqlId != null) hashCode = hashCode * 59 + this.UniqueSqlId.GetHashCode();
                if (this.TopXid != null) hashCode = hashCode * 59 + this.TopXid.GetHashCode();
                if (this.CurrentXid != null) hashCode = hashCode * 59 + this.CurrentXid.GetHashCode();
                if (this.ExecTime != null) hashCode = hashCode * 59 + this.ExecTime.GetHashCode();
                if (this.XlogQuantity != null) hashCode = hashCode * 59 + this.XlogQuantity.GetHashCode();
                return hashCode;
            }
        }
    }
}
