using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResetConsumeOffsetRespQueues 
    {

        /// <summary>
        /// 队列所在的broker。
        /// </summary>
        [JsonProperty("broker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerName { get; set; }

        /// <summary>
        /// 队列ID。
        /// </summary>
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueueId { get; set; }

        /// <summary>
        /// 重置消费进度。
        /// </summary>
        [JsonProperty("timestamp_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimestampOffset { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetConsumeOffsetRespQueues {\n");
            sb.Append("  brokerName: ").Append(BrokerName).Append("\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  timestampOffset: ").Append(TimestampOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetConsumeOffsetRespQueues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetConsumeOffsetRespQueues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BrokerName == input.BrokerName ||
                    (this.BrokerName != null &&
                    this.BrokerName.Equals(input.BrokerName))
                ) && 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.TimestampOffset == input.TimestampOffset ||
                    (this.TimestampOffset != null &&
                    this.TimestampOffset.Equals(input.TimestampOffset))
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
                if (this.BrokerName != null)
                    hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.TimestampOffset != null)
                    hashCode = hashCode * 59 + this.TimestampOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
