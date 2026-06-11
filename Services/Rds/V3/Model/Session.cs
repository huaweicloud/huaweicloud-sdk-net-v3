using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 会话信息
    /// </summary>
    public class Session 
    {

        /// <summary>
        /// 采样时间
        /// </summary>
        [JsonProperty("sample_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SampleTime { get; set; }

        /// <summary>
        /// 阻塞进程ID
        /// </summary>
        [JsonProperty("blocked_process_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockedProcessId { get; set; }

        /// <summary>
        /// 数据库OID
        /// </summary>
        [JsonProperty("database_oid", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatabaseOid { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionId { get; set; }

        /// <summary>
        /// 并行会话ID
        /// </summary>
        [JsonProperty("parallel_leader_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParallelLeaderId { get; set; }

        /// <summary>
        /// 后端用户OID
        /// </summary>
        [JsonProperty("backend_user_oid", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackendUserOid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 客户端地址
        /// </summary>
        [JsonProperty("client_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIpAddress { get; set; }

        /// <summary>
        /// 客户端名称
        /// </summary>
        [JsonProperty("client_host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientHostName { get; set; }

        /// <summary>
        /// 客户端端口
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientPort { get; set; }

        /// <summary>
        /// 会话建立时间
        /// </summary>
        [JsonProperty("session_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionStartTime { get; set; }

        /// <summary>
        /// 事务启动时间
        /// </summary>
        [JsonProperty("transaction_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionStartTime { get; set; }

        /// <summary>
        /// 事务执行时间(s)
        /// </summary>
        [JsonProperty("transaction_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionExecutionTime { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [JsonProperty("query_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryStartTime { get; set; }

        /// <summary>
        /// state改变时间
        /// </summary>
        [JsonProperty("state_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StateChangeTime { get; set; }

        /// <summary>
        /// 等待事件类型
        /// </summary>
        [JsonProperty("wait_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitEventType { get; set; }

        /// <summary>
        /// 等待事件名称
        /// </summary>
        [JsonProperty("wait_event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitEventName { get; set; }

        /// <summary>
        /// 会话状态
        /// </summary>
        [JsonProperty("session_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// Backend XID
        /// </summary>
        [JsonProperty("backend_xid", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackendXid { get; set; }

        /// <summary>
        /// Backend Xmin
        /// </summary>
        [JsonProperty("backend_xmin", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackendXmin { get; set; }

        /// <summary>
        /// Query ID
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// SQL语句
        /// </summary>
        [JsonProperty("sql_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlStatement { get; set; }

        /// <summary>
        /// 进程类型
        /// </summary>
        [JsonProperty("process_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessType { get; set; }

        /// <summary>
        /// 内存占比(%)
        /// </summary>
        [JsonProperty("memory_usage", NullValueHandling = NullValueHandling.Ignore)]
        public float? MemoryUsage { get; set; }

        /// <summary>
        /// 进程状态
        /// </summary>
        [JsonProperty("process_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 3秒内平均CPU占用率(%)
        /// </summary>
        [JsonProperty("cpu_usage", NullValueHandling = NullValueHandling.Ignore)]
        public float? CpuUsage { get; set; }

        /// <summary>
        /// I/O等待时间(s)
        /// </summary>
        [JsonProperty("io_wait_status", NullValueHandling = NullValueHandling.Ignore)]
        public float? IoWaitStatus { get; set; }

        /// <summary>
        /// 磁盘读速率(MB/s)
        /// </summary>
        [JsonProperty("disk_read_rate", NullValueHandling = NullValueHandling.Ignore)]
        public float? DiskReadRate { get; set; }

        /// <summary>
        /// 磁盘写速率(MB/s)
        /// </summary>
        [JsonProperty("disk_write_rate", NullValueHandling = NullValueHandling.Ignore)]
        public float? DiskWriteRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Session {\n");
            sb.Append("  sampleTime: ").Append(SampleTime).Append("\n");
            sb.Append("  blockedProcessId: ").Append(BlockedProcessId).Append("\n");
            sb.Append("  databaseOid: ").Append(DatabaseOid).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  parallelLeaderId: ").Append(ParallelLeaderId).Append("\n");
            sb.Append("  backendUserOid: ").Append(BackendUserOid).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  clientIpAddress: ").Append(ClientIpAddress).Append("\n");
            sb.Append("  clientHostName: ").Append(ClientHostName).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  sessionStartTime: ").Append(SessionStartTime).Append("\n");
            sb.Append("  transactionStartTime: ").Append(TransactionStartTime).Append("\n");
            sb.Append("  transactionExecutionTime: ").Append(TransactionExecutionTime).Append("\n");
            sb.Append("  queryStartTime: ").Append(QueryStartTime).Append("\n");
            sb.Append("  stateChangeTime: ").Append(StateChangeTime).Append("\n");
            sb.Append("  waitEventType: ").Append(WaitEventType).Append("\n");
            sb.Append("  waitEventName: ").Append(WaitEventName).Append("\n");
            sb.Append("  sessionStatus: ").Append(SessionStatus).Append("\n");
            sb.Append("  backendXid: ").Append(BackendXid).Append("\n");
            sb.Append("  backendXmin: ").Append(BackendXmin).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  sqlStatement: ").Append(SqlStatement).Append("\n");
            sb.Append("  processType: ").Append(ProcessType).Append("\n");
            sb.Append("  memoryUsage: ").Append(MemoryUsage).Append("\n");
            sb.Append("  processStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("  cpuUsage: ").Append(CpuUsage).Append("\n");
            sb.Append("  ioWaitStatus: ").Append(IoWaitStatus).Append("\n");
            sb.Append("  diskReadRate: ").Append(DiskReadRate).Append("\n");
            sb.Append("  diskWriteRate: ").Append(DiskWriteRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Session);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Session input)
        {
            if (input == null) return false;
            if (this.SampleTime != input.SampleTime || (this.SampleTime != null && !this.SampleTime.Equals(input.SampleTime))) return false;
            if (this.BlockedProcessId != input.BlockedProcessId || (this.BlockedProcessId != null && !this.BlockedProcessId.Equals(input.BlockedProcessId))) return false;
            if (this.DatabaseOid != input.DatabaseOid || (this.DatabaseOid != null && !this.DatabaseOid.Equals(input.DatabaseOid))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.ParallelLeaderId != input.ParallelLeaderId || (this.ParallelLeaderId != null && !this.ParallelLeaderId.Equals(input.ParallelLeaderId))) return false;
            if (this.BackendUserOid != input.BackendUserOid || (this.BackendUserOid != null && !this.BackendUserOid.Equals(input.BackendUserOid))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.ClientIpAddress != input.ClientIpAddress || (this.ClientIpAddress != null && !this.ClientIpAddress.Equals(input.ClientIpAddress))) return false;
            if (this.ClientHostName != input.ClientHostName || (this.ClientHostName != null && !this.ClientHostName.Equals(input.ClientHostName))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.SessionStartTime != input.SessionStartTime || (this.SessionStartTime != null && !this.SessionStartTime.Equals(input.SessionStartTime))) return false;
            if (this.TransactionStartTime != input.TransactionStartTime || (this.TransactionStartTime != null && !this.TransactionStartTime.Equals(input.TransactionStartTime))) return false;
            if (this.TransactionExecutionTime != input.TransactionExecutionTime || (this.TransactionExecutionTime != null && !this.TransactionExecutionTime.Equals(input.TransactionExecutionTime))) return false;
            if (this.QueryStartTime != input.QueryStartTime || (this.QueryStartTime != null && !this.QueryStartTime.Equals(input.QueryStartTime))) return false;
            if (this.StateChangeTime != input.StateChangeTime || (this.StateChangeTime != null && !this.StateChangeTime.Equals(input.StateChangeTime))) return false;
            if (this.WaitEventType != input.WaitEventType || (this.WaitEventType != null && !this.WaitEventType.Equals(input.WaitEventType))) return false;
            if (this.WaitEventName != input.WaitEventName || (this.WaitEventName != null && !this.WaitEventName.Equals(input.WaitEventName))) return false;
            if (this.SessionStatus != input.SessionStatus || (this.SessionStatus != null && !this.SessionStatus.Equals(input.SessionStatus))) return false;
            if (this.BackendXid != input.BackendXid || (this.BackendXid != null && !this.BackendXid.Equals(input.BackendXid))) return false;
            if (this.BackendXmin != input.BackendXmin || (this.BackendXmin != null && !this.BackendXmin.Equals(input.BackendXmin))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.SqlStatement != input.SqlStatement || (this.SqlStatement != null && !this.SqlStatement.Equals(input.SqlStatement))) return false;
            if (this.ProcessType != input.ProcessType || (this.ProcessType != null && !this.ProcessType.Equals(input.ProcessType))) return false;
            if (this.MemoryUsage != input.MemoryUsage || (this.MemoryUsage != null && !this.MemoryUsage.Equals(input.MemoryUsage))) return false;
            if (this.ProcessStatus != input.ProcessStatus || (this.ProcessStatus != null && !this.ProcessStatus.Equals(input.ProcessStatus))) return false;
            if (this.CpuUsage != input.CpuUsage || (this.CpuUsage != null && !this.CpuUsage.Equals(input.CpuUsage))) return false;
            if (this.IoWaitStatus != input.IoWaitStatus || (this.IoWaitStatus != null && !this.IoWaitStatus.Equals(input.IoWaitStatus))) return false;
            if (this.DiskReadRate != input.DiskReadRate || (this.DiskReadRate != null && !this.DiskReadRate.Equals(input.DiskReadRate))) return false;
            if (this.DiskWriteRate != input.DiskWriteRate || (this.DiskWriteRate != null && !this.DiskWriteRate.Equals(input.DiskWriteRate))) return false;

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
                if (this.SampleTime != null) hashCode = hashCode * 59 + this.SampleTime.GetHashCode();
                if (this.BlockedProcessId != null) hashCode = hashCode * 59 + this.BlockedProcessId.GetHashCode();
                if (this.DatabaseOid != null) hashCode = hashCode * 59 + this.DatabaseOid.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.ParallelLeaderId != null) hashCode = hashCode * 59 + this.ParallelLeaderId.GetHashCode();
                if (this.BackendUserOid != null) hashCode = hashCode * 59 + this.BackendUserOid.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.ClientIpAddress != null) hashCode = hashCode * 59 + this.ClientIpAddress.GetHashCode();
                if (this.ClientHostName != null) hashCode = hashCode * 59 + this.ClientHostName.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.SessionStartTime != null) hashCode = hashCode * 59 + this.SessionStartTime.GetHashCode();
                if (this.TransactionStartTime != null) hashCode = hashCode * 59 + this.TransactionStartTime.GetHashCode();
                if (this.TransactionExecutionTime != null) hashCode = hashCode * 59 + this.TransactionExecutionTime.GetHashCode();
                if (this.QueryStartTime != null) hashCode = hashCode * 59 + this.QueryStartTime.GetHashCode();
                if (this.StateChangeTime != null) hashCode = hashCode * 59 + this.StateChangeTime.GetHashCode();
                if (this.WaitEventType != null) hashCode = hashCode * 59 + this.WaitEventType.GetHashCode();
                if (this.WaitEventName != null) hashCode = hashCode * 59 + this.WaitEventName.GetHashCode();
                if (this.SessionStatus != null) hashCode = hashCode * 59 + this.SessionStatus.GetHashCode();
                if (this.BackendXid != null) hashCode = hashCode * 59 + this.BackendXid.GetHashCode();
                if (this.BackendXmin != null) hashCode = hashCode * 59 + this.BackendXmin.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.SqlStatement != null) hashCode = hashCode * 59 + this.SqlStatement.GetHashCode();
                if (this.ProcessType != null) hashCode = hashCode * 59 + this.ProcessType.GetHashCode();
                if (this.MemoryUsage != null) hashCode = hashCode * 59 + this.MemoryUsage.GetHashCode();
                if (this.ProcessStatus != null) hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                if (this.CpuUsage != null) hashCode = hashCode * 59 + this.CpuUsage.GetHashCode();
                if (this.IoWaitStatus != null) hashCode = hashCode * 59 + this.IoWaitStatus.GetHashCode();
                if (this.DiskReadRate != null) hashCode = hashCode * 59 + this.DiskReadRate.GetHashCode();
                if (this.DiskWriteRate != null) hashCode = hashCode * 59 + this.DiskWriteRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
