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
    /// 
    /// </summary>
    public class InstanceDrInfo 
    {

        /// <summary>
        /// 容灾关系id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 容灾搭建状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 失败消息
        /// </summary>
        [JsonProperty("failed_message", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedMessage { get; set; }

        /// <summary>
        /// 同步状态，取值范围是0或-1，0表示正常，-1表示异常。
        /// </summary>
        [JsonProperty("replica_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicaState { get; set; }

        /// <summary>
        /// 发送延迟大小（MB），即主实例当前wal日志写入位点与灾备实例当前接收wal日志位点的差值。
        /// </summary>
        [JsonProperty("wal_write_receive_delay_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public string WalWriteReceiveDelayInMb { get; set; }

        /// <summary>
        /// 端到端延迟大小（MB），即主实例当前wal日志写入位点与灾备实例当前回放wal日志位点的差值。
        /// </summary>
        [JsonProperty("wal_write_replay_delay_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public string WalWriteReplayDelayInMb { get; set; }

        /// <summary>
        /// 回放延迟时间（ms），即数据在灾备上回放的延迟时间。
        /// </summary>
        [JsonProperty("wal_receive_replay_delay_in_ms", NullValueHandling = NullValueHandling.Ignore)]
        public string WalReceiveReplayDelayInMs { get; set; }

        /// <summary>
        /// 主实例ID
        /// </summary>
        [JsonProperty("master_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterInstanceId { get; set; }

        /// <summary>
        /// 主实例所在region
        /// </summary>
        [JsonProperty("master_region", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterRegion { get; set; }

        /// <summary>
        /// 灾备实例ID
        /// </summary>
        [JsonProperty("slave_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveInstanceId { get; set; }

        /// <summary>
        /// 灾备实例所在region
        /// </summary>
        [JsonProperty("slave_region", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveRegion { get; set; }

        /// <summary>
        /// 搭建流程。master表示配置主实例容灾能力流程。slave表示配置灾备实例容灾能力流程。
        /// </summary>
        [JsonProperty("build_process", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildProcess { get; set; }

        /// <summary>
        /// 灾备搭建时间
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDrInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  failedMessage: ").Append(FailedMessage).Append("\n");
            sb.Append("  replicaState: ").Append(ReplicaState).Append("\n");
            sb.Append("  walWriteReceiveDelayInMb: ").Append(WalWriteReceiveDelayInMb).Append("\n");
            sb.Append("  walWriteReplayDelayInMb: ").Append(WalWriteReplayDelayInMb).Append("\n");
            sb.Append("  walReceiveReplayDelayInMs: ").Append(WalReceiveReplayDelayInMs).Append("\n");
            sb.Append("  masterInstanceId: ").Append(MasterInstanceId).Append("\n");
            sb.Append("  masterRegion: ").Append(MasterRegion).Append("\n");
            sb.Append("  slaveInstanceId: ").Append(SlaveInstanceId).Append("\n");
            sb.Append("  slaveRegion: ").Append(SlaveRegion).Append("\n");
            sb.Append("  buildProcess: ").Append(BuildProcess).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDrInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDrInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.FailedMessage != input.FailedMessage || (this.FailedMessage != null && !this.FailedMessage.Equals(input.FailedMessage))) return false;
            if (this.ReplicaState != input.ReplicaState || (this.ReplicaState != null && !this.ReplicaState.Equals(input.ReplicaState))) return false;
            if (this.WalWriteReceiveDelayInMb != input.WalWriteReceiveDelayInMb || (this.WalWriteReceiveDelayInMb != null && !this.WalWriteReceiveDelayInMb.Equals(input.WalWriteReceiveDelayInMb))) return false;
            if (this.WalWriteReplayDelayInMb != input.WalWriteReplayDelayInMb || (this.WalWriteReplayDelayInMb != null && !this.WalWriteReplayDelayInMb.Equals(input.WalWriteReplayDelayInMb))) return false;
            if (this.WalReceiveReplayDelayInMs != input.WalReceiveReplayDelayInMs || (this.WalReceiveReplayDelayInMs != null && !this.WalReceiveReplayDelayInMs.Equals(input.WalReceiveReplayDelayInMs))) return false;
            if (this.MasterInstanceId != input.MasterInstanceId || (this.MasterInstanceId != null && !this.MasterInstanceId.Equals(input.MasterInstanceId))) return false;
            if (this.MasterRegion != input.MasterRegion || (this.MasterRegion != null && !this.MasterRegion.Equals(input.MasterRegion))) return false;
            if (this.SlaveInstanceId != input.SlaveInstanceId || (this.SlaveInstanceId != null && !this.SlaveInstanceId.Equals(input.SlaveInstanceId))) return false;
            if (this.SlaveRegion != input.SlaveRegion || (this.SlaveRegion != null && !this.SlaveRegion.Equals(input.SlaveRegion))) return false;
            if (this.BuildProcess != input.BuildProcess || (this.BuildProcess != null && !this.BuildProcess.Equals(input.BuildProcess))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FailedMessage != null) hashCode = hashCode * 59 + this.FailedMessage.GetHashCode();
                if (this.ReplicaState != null) hashCode = hashCode * 59 + this.ReplicaState.GetHashCode();
                if (this.WalWriteReceiveDelayInMb != null) hashCode = hashCode * 59 + this.WalWriteReceiveDelayInMb.GetHashCode();
                if (this.WalWriteReplayDelayInMb != null) hashCode = hashCode * 59 + this.WalWriteReplayDelayInMb.GetHashCode();
                if (this.WalReceiveReplayDelayInMs != null) hashCode = hashCode * 59 + this.WalReceiveReplayDelayInMs.GetHashCode();
                if (this.MasterInstanceId != null) hashCode = hashCode * 59 + this.MasterInstanceId.GetHashCode();
                if (this.MasterRegion != null) hashCode = hashCode * 59 + this.MasterRegion.GetHashCode();
                if (this.SlaveInstanceId != null) hashCode = hashCode * 59 + this.SlaveInstanceId.GetHashCode();
                if (this.SlaveRegion != null) hashCode = hashCode * 59 + this.SlaveRegion.GetHashCode();
                if (this.BuildProcess != null) hashCode = hashCode * 59 + this.BuildProcess.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
