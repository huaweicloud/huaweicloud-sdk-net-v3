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
    /// SQL链路节点执行信息
    /// </summary>
    public class NodeExecutionInfoResult 
    {

        /// <summary>
        /// **参数解释**: 组件ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**: 节点ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: 事务ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// **参数解释**: 归一化SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: 唯一SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_exec_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlExecId { get; set; }

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
        /// **参数解释**: 语句启动的时间，格式为“yyyy-mm-ddThh:mm: ssssssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**: 语句结束的时间，格式为“yyyy-mm-ddThh:mm: ssssssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行总耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("all_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllTime { get; set; }

        /// <summary>
        /// **参数解释**: 用户名。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起的请求的客户端地址。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientAddr { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起的请求的客户端端口。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientPort { get; set; }

        /// <summary>
        /// **参数解释**: 驱动传入的trace id，与应用的一次请求相关联。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起的请求的应用程序名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("application_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// **参数解释**: 用户session id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// **参数解释**: 该SQL是否为slow SQL。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("is_slow_sql", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSlowSql { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execution_time_details", NullValueHandling = NullValueHandling.Ignore)]
        public ExecutionTimeDetailsInfo ExecutionTimeDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeExecutionInfoResult {\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlExecId: ").Append(SqlExecId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  allTime: ").Append(AllTime).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  applicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  isSlowSql: ").Append(IsSlowSql).Append("\n");
            sb.Append("  executionTimeDetails: ").Append(ExecutionTimeDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeExecutionInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeExecutionInfoResult input)
        {
            if (input == null) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlExecId != input.SqlExecId || (this.SqlExecId != null && !this.SqlExecId.Equals(input.SqlExecId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.AllTime != input.AllTime || (this.AllTime != null && !this.AllTime.Equals(input.AllTime))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.ApplicationName != input.ApplicationName || (this.ApplicationName != null && !this.ApplicationName.Equals(input.ApplicationName))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.IsSlowSql != input.IsSlowSql || (this.IsSlowSql != null && !this.IsSlowSql.Equals(input.IsSlowSql))) return false;
            if (this.ExecutionTimeDetails != input.ExecutionTimeDetails || (this.ExecutionTimeDetails != null && !this.ExecutionTimeDetails.Equals(input.ExecutionTimeDetails))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlExecId != null) hashCode = hashCode * 59 + this.SqlExecId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.AllTime != null) hashCode = hashCode * 59 + this.AllTime.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.ApplicationName != null) hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.IsSlowSql != null) hashCode = hashCode * 59 + this.IsSlowSql.GetHashCode();
                if (this.ExecutionTimeDetails != null) hashCode = hashCode * 59 + this.ExecutionTimeDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
