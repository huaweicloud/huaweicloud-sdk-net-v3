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
    public class ShowGroupsRespGroupGroupMessageOffsets 
    {

        /// <summary>
        /// 分区编号。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 剩余可消费消息数，即消息堆积数。
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lag { get; set; }

        /// <summary>
        /// topic名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 当前消费进度。
        /// </summary>
        [JsonProperty("message_current_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageCurrentOffset { get; set; }

        /// <summary>
        /// 最大消息位置（LEO）。
        /// </summary>
        [JsonProperty("message_log_end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageLogEndOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupsRespGroupGroupMessageOffsets {\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  messageCurrentOffset: ").Append(MessageCurrentOffset).Append("\n");
            sb.Append("  messageLogEndOffset: ").Append(MessageLogEndOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupsRespGroupGroupMessageOffsets);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupsRespGroupGroupMessageOffsets input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))
                ) && 
                (
                    this.Lag == input.Lag ||
                    (this.Lag != null &&
                    this.Lag.Equals(input.Lag))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.MessageCurrentOffset == input.MessageCurrentOffset ||
                    (this.MessageCurrentOffset != null &&
                    this.MessageCurrentOffset.Equals(input.MessageCurrentOffset))
                ) && 
                (
                    this.MessageLogEndOffset == input.MessageLogEndOffset ||
                    (this.MessageLogEndOffset != null &&
                    this.MessageLogEndOffset.Equals(input.MessageLogEndOffset))
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
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.Lag != null)
                    hashCode = hashCode * 59 + this.Lag.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.MessageCurrentOffset != null)
                    hashCode = hashCode * 59 + this.MessageCurrentOffset.GetHashCode();
                if (this.MessageLogEndOffset != null)
                    hashCode = hashCode * 59 + this.MessageLogEndOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
