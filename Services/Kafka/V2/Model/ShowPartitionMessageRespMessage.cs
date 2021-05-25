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
    /// 消息体。
    /// </summary>
    public class ShowPartitionMessageRespMessage 
    {

        /// <summary>
        /// 消息的key。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 消息内容。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// Topic名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 分区编号。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 消息位置。
        /// </summary>
        [JsonProperty("message_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? MessageOffset { get; set; }

        /// <summary>
        /// 消息大小，单位字节。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 消息时间戳。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPartitionMessageRespMessage {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  messageOffset: ").Append(MessageOffset).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPartitionMessageRespMessage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPartitionMessageRespMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))
                ) && 
                (
                    this.MessageOffset == input.MessageOffset ||
                    (this.MessageOffset != null &&
                    this.MessageOffset.Equals(input.MessageOffset))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.MessageOffset != null)
                    hashCode = hashCode * 59 + this.MessageOffset.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
