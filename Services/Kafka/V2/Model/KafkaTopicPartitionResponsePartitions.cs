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
    public class KafkaTopicPartitionResponsePartitions 
    {

        /// <summary>
        /// 分区ID
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 起始偏移量
        /// </summary>
        [JsonProperty("start_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartOffset { get; set; }

        /// <summary>
        /// 最后偏移量
        /// </summary>
        [JsonProperty("last_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastOffset { get; set; }

        /// <summary>
        /// 分区消息数
        /// </summary>
        [JsonProperty("message_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? MessageCount { get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastUpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KafkaTopicPartitionResponsePartitions {\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  startOffset: ").Append(StartOffset).Append("\n");
            sb.Append("  lastOffset: ").Append(LastOffset).Append("\n");
            sb.Append("  messageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KafkaTopicPartitionResponsePartitions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KafkaTopicPartitionResponsePartitions input)
        {
            if (input == null) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;
            if (this.StartOffset != input.StartOffset || (this.StartOffset != null && !this.StartOffset.Equals(input.StartOffset))) return false;
            if (this.LastOffset != input.LastOffset || (this.LastOffset != null && !this.LastOffset.Equals(input.LastOffset))) return false;
            if (this.MessageCount != input.MessageCount || (this.MessageCount != null && !this.MessageCount.Equals(input.MessageCount))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;

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
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.StartOffset != null) hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                if (this.LastOffset != null) hashCode = hashCode * 59 + this.LastOffset.GetHashCode();
                if (this.MessageCount != null) hashCode = hashCode * 59 + this.MessageCount.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
