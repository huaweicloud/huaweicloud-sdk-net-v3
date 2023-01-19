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
    public class ResetMessageOffsetReq 
    {

        /// <summary>
        /// topic名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 分区编号，默认值为-1，若传入值为-1，则重置所有分区。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 重置消费进度到指定偏移量。 - 如果传入offset小于当前最小的offset，则重置到最小的offset。 - 如果大于最大的offset，则重置到最大的offset。  **message_offset、timestamp二者必选其一。** 
        /// </summary>
        [JsonProperty("message_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageOffset { get; set; }

        /// <summary>
        /// 重置消费进度到指定时间，格式为unix时间戳，单位为毫秒。 - 如果传入timestamp早于当前最早的timestamp，则重置到最早的timestamp。 - 如果晚于最晚的timestamp，则重置到最晚的timestamp。  **message_offset、timestamp二者必选其一。** 
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetMessageOffsetReq {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  messageOffset: ").Append(MessageOffset).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetMessageOffsetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetMessageOffsetReq input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.MessageOffset != null)
                    hashCode = hashCode * 59 + this.MessageOffset.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
