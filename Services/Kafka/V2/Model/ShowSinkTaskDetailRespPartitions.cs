using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowSinkTaskDetailRespPartitions 
    {

        /// <summary>
        /// 分区ID。
        /// </summary>
        [JsonProperty("partition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionId { get; set; }

        /// <summary>
        /// 运行状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 已转储的消息偏移量。
        /// </summary>
        [JsonProperty("last_transfer_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string LastTransferOffset { get; set; }

        /// <summary>
        /// 消息偏移量。
        /// </summary>
        [JsonProperty("log_end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string LogEndOffset { get; set; }

        /// <summary>
        /// 积压的消息数。
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public string Lag { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSinkTaskDetailRespPartitions {\n");
            sb.Append("  partitionId: ").Append(PartitionId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastTransferOffset: ").Append(LastTransferOffset).Append("\n");
            sb.Append("  logEndOffset: ").Append(LogEndOffset).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSinkTaskDetailRespPartitions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSinkTaskDetailRespPartitions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PartitionId == input.PartitionId ||
                    (this.PartitionId != null &&
                    this.PartitionId.Equals(input.PartitionId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LastTransferOffset == input.LastTransferOffset ||
                    (this.LastTransferOffset != null &&
                    this.LastTransferOffset.Equals(input.LastTransferOffset))
                ) && 
                (
                    this.LogEndOffset == input.LogEndOffset ||
                    (this.LogEndOffset != null &&
                    this.LogEndOffset.Equals(input.LogEndOffset))
                ) && 
                (
                    this.Lag == input.Lag ||
                    (this.Lag != null &&
                    this.Lag.Equals(input.Lag))
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
                if (this.PartitionId != null)
                    hashCode = hashCode * 59 + this.PartitionId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastTransferOffset != null)
                    hashCode = hashCode * 59 + this.LastTransferOffset.GetHashCode();
                if (this.LogEndOffset != null)
                    hashCode = hashCode * 59 + this.LogEndOffset.GetHashCode();
                if (this.Lag != null)
                    hashCode = hashCode * 59 + this.Lag.GetHashCode();
                return hashCode;
            }
        }
    }
}
