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
    /// Response Object
    /// </summary>
    public class ShowDrReplicaStatusResponse : SdkResponse
    {

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDrReplicaStatusResponse {\n");
            sb.Append("  replicaState: ").Append(ReplicaState).Append("\n");
            sb.Append("  walWriteReceiveDelayInMb: ").Append(WalWriteReceiveDelayInMb).Append("\n");
            sb.Append("  walWriteReplayDelayInMb: ").Append(WalWriteReplayDelayInMb).Append("\n");
            sb.Append("  walReceiveReplayDelayInMs: ").Append(WalReceiveReplayDelayInMs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDrReplicaStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDrReplicaStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReplicaState == input.ReplicaState ||
                    (this.ReplicaState != null &&
                    this.ReplicaState.Equals(input.ReplicaState))
                ) && 
                (
                    this.WalWriteReceiveDelayInMb == input.WalWriteReceiveDelayInMb ||
                    (this.WalWriteReceiveDelayInMb != null &&
                    this.WalWriteReceiveDelayInMb.Equals(input.WalWriteReceiveDelayInMb))
                ) && 
                (
                    this.WalWriteReplayDelayInMb == input.WalWriteReplayDelayInMb ||
                    (this.WalWriteReplayDelayInMb != null &&
                    this.WalWriteReplayDelayInMb.Equals(input.WalWriteReplayDelayInMb))
                ) && 
                (
                    this.WalReceiveReplayDelayInMs == input.WalReceiveReplayDelayInMs ||
                    (this.WalReceiveReplayDelayInMs != null &&
                    this.WalReceiveReplayDelayInMs.Equals(input.WalReceiveReplayDelayInMs))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ReplicaState != null)
                    hashCode = hashCode * 59 + this.ReplicaState.GetHashCode();
                if (this.WalWriteReceiveDelayInMb != null)
                    hashCode = hashCode * 59 + this.WalWriteReceiveDelayInMb.GetHashCode();
                if (this.WalWriteReplayDelayInMb != null)
                    hashCode = hashCode * 59 + this.WalWriteReplayDelayInMb.GetHashCode();
                if (this.WalReceiveReplayDelayInMs != null)
                    hashCode = hashCode * 59 + this.WalReceiveReplayDelayInMs.GetHashCode();
                return hashCode;
            }
        }
    }
}
