using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Node节点指标项。
    /// </summary>
    public class QueryMetricResult 
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 上报时间。
        /// </summary>
        [JsonProperty("time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// CPU使用率。
        /// </summary>
        [JsonProperty("cpu_util", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuUtil { get; set; }

        /// <summary>
        /// 内存使用率。
        /// </summary>
        [JsonProperty("mem_util", NullValueHandling = NullValueHandling.Ignore)]
        public string MemUtil { get; set; }

        /// <summary>
        /// 网络输入吞吐量。
        /// </summary>
        [JsonProperty("network_incoming_bytes_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkIncomingBytesRate { get; set; }

        /// <summary>
        /// 网络输出吞吐量。
        /// </summary>
        [JsonProperty("network_outgoing_bytes_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkOutgoingBytesRate { get; set; }

        /// <summary>
        /// 磁盘读吞吐量。
        /// </summary>
        [JsonProperty("disk_read_bytes_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskReadBytesRate { get; set; }

        /// <summary>
        /// 磁盘写吞吐量。
        /// </summary>
        [JsonProperty("disk_write_bytes_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskWriteBytesRate { get; set; }

        /// <summary>
        /// 写目标库频率。
        /// </summary>
        [JsonProperty("apply_rows_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyRowsRate { get; set; }

        /// <summary>
        /// DML TPS。
        /// </summary>
        [JsonProperty("apply_transactions_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyTransactionsRate { get; set; }

        /// <summary>
        /// DDL TPS。
        /// </summary>
        [JsonProperty("apply_ddl_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyDdlRate { get; set; }

        /// <summary>
        /// 事务平均执行时间。
        /// </summary>
        [JsonProperty("apply_average_execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyAverageExecuteTime { get; set; }

        /// <summary>
        /// 事务平均提交时间。
        /// </summary>
        [JsonProperty("apply_average_commit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyAverageCommitTime { get; set; }

        /// <summary>
        /// 同步状态。
        /// </summary>
        [JsonProperty("apply_current_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyCurrentState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryMetricResult {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  timeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  cpuUtil: ").Append(CpuUtil).Append("\n");
            sb.Append("  memUtil: ").Append(MemUtil).Append("\n");
            sb.Append("  networkIncomingBytesRate: ").Append(NetworkIncomingBytesRate).Append("\n");
            sb.Append("  networkOutgoingBytesRate: ").Append(NetworkOutgoingBytesRate).Append("\n");
            sb.Append("  diskReadBytesRate: ").Append(DiskReadBytesRate).Append("\n");
            sb.Append("  diskWriteBytesRate: ").Append(DiskWriteBytesRate).Append("\n");
            sb.Append("  applyRowsRate: ").Append(ApplyRowsRate).Append("\n");
            sb.Append("  applyTransactionsRate: ").Append(ApplyTransactionsRate).Append("\n");
            sb.Append("  applyDdlRate: ").Append(ApplyDdlRate).Append("\n");
            sb.Append("  applyAverageExecuteTime: ").Append(ApplyAverageExecuteTime).Append("\n");
            sb.Append("  applyAverageCommitTime: ").Append(ApplyAverageCommitTime).Append("\n");
            sb.Append("  applyCurrentState: ").Append(ApplyCurrentState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryMetricResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryMetricResult input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.TimeStamp != input.TimeStamp || (this.TimeStamp != null && !this.TimeStamp.Equals(input.TimeStamp))) return false;
            if (this.CpuUtil != input.CpuUtil || (this.CpuUtil != null && !this.CpuUtil.Equals(input.CpuUtil))) return false;
            if (this.MemUtil != input.MemUtil || (this.MemUtil != null && !this.MemUtil.Equals(input.MemUtil))) return false;
            if (this.NetworkIncomingBytesRate != input.NetworkIncomingBytesRate || (this.NetworkIncomingBytesRate != null && !this.NetworkIncomingBytesRate.Equals(input.NetworkIncomingBytesRate))) return false;
            if (this.NetworkOutgoingBytesRate != input.NetworkOutgoingBytesRate || (this.NetworkOutgoingBytesRate != null && !this.NetworkOutgoingBytesRate.Equals(input.NetworkOutgoingBytesRate))) return false;
            if (this.DiskReadBytesRate != input.DiskReadBytesRate || (this.DiskReadBytesRate != null && !this.DiskReadBytesRate.Equals(input.DiskReadBytesRate))) return false;
            if (this.DiskWriteBytesRate != input.DiskWriteBytesRate || (this.DiskWriteBytesRate != null && !this.DiskWriteBytesRate.Equals(input.DiskWriteBytesRate))) return false;
            if (this.ApplyRowsRate != input.ApplyRowsRate || (this.ApplyRowsRate != null && !this.ApplyRowsRate.Equals(input.ApplyRowsRate))) return false;
            if (this.ApplyTransactionsRate != input.ApplyTransactionsRate || (this.ApplyTransactionsRate != null && !this.ApplyTransactionsRate.Equals(input.ApplyTransactionsRate))) return false;
            if (this.ApplyDdlRate != input.ApplyDdlRate || (this.ApplyDdlRate != null && !this.ApplyDdlRate.Equals(input.ApplyDdlRate))) return false;
            if (this.ApplyAverageExecuteTime != input.ApplyAverageExecuteTime || (this.ApplyAverageExecuteTime != null && !this.ApplyAverageExecuteTime.Equals(input.ApplyAverageExecuteTime))) return false;
            if (this.ApplyAverageCommitTime != input.ApplyAverageCommitTime || (this.ApplyAverageCommitTime != null && !this.ApplyAverageCommitTime.Equals(input.ApplyAverageCommitTime))) return false;
            if (this.ApplyCurrentState != input.ApplyCurrentState || (this.ApplyCurrentState != null && !this.ApplyCurrentState.Equals(input.ApplyCurrentState))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.TimeStamp != null) hashCode = hashCode * 59 + this.TimeStamp.GetHashCode();
                if (this.CpuUtil != null) hashCode = hashCode * 59 + this.CpuUtil.GetHashCode();
                if (this.MemUtil != null) hashCode = hashCode * 59 + this.MemUtil.GetHashCode();
                if (this.NetworkIncomingBytesRate != null) hashCode = hashCode * 59 + this.NetworkIncomingBytesRate.GetHashCode();
                if (this.NetworkOutgoingBytesRate != null) hashCode = hashCode * 59 + this.NetworkOutgoingBytesRate.GetHashCode();
                if (this.DiskReadBytesRate != null) hashCode = hashCode * 59 + this.DiskReadBytesRate.GetHashCode();
                if (this.DiskWriteBytesRate != null) hashCode = hashCode * 59 + this.DiskWriteBytesRate.GetHashCode();
                if (this.ApplyRowsRate != null) hashCode = hashCode * 59 + this.ApplyRowsRate.GetHashCode();
                if (this.ApplyTransactionsRate != null) hashCode = hashCode * 59 + this.ApplyTransactionsRate.GetHashCode();
                if (this.ApplyDdlRate != null) hashCode = hashCode * 59 + this.ApplyDdlRate.GetHashCode();
                if (this.ApplyAverageExecuteTime != null) hashCode = hashCode * 59 + this.ApplyAverageExecuteTime.GetHashCode();
                if (this.ApplyAverageCommitTime != null) hashCode = hashCode * 59 + this.ApplyAverageCommitTime.GetHashCode();
                if (this.ApplyCurrentState != null) hashCode = hashCode * 59 + this.ApplyCurrentState.GetHashCode();
                return hashCode;
            }
        }
    }
}
