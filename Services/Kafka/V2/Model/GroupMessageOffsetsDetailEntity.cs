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
    /// 消费组消息位点详情
    /// </summary>
    public class GroupMessageOffsetsDetailEntity 
    {

        /// <summary>
        /// 分区
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public string Partition { get; set; }

        /// <summary>
        /// 消息当前位点
        /// </summary>
        [JsonProperty("message_current_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageCurrentOffset { get; set; }

        /// <summary>
        /// topic名称
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 消息开始位点
        /// </summary>
        [JsonProperty("message_log_start_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageLogStartOffset { get; set; }

        /// <summary>
        /// 剩余可消费消息数，即消息堆积数
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lag { get; set; }

        /// <summary>
        /// 消息结束位点
        /// </summary>
        [JsonProperty("message_log_end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageLogEndOffset { get; set; }

        /// <summary>
        /// 消费者Id
        /// </summary>
        [JsonProperty("consumer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// host名称
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// 客户端Id
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMessageOffsetsDetailEntity {\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  messageCurrentOffset: ").Append(MessageCurrentOffset).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  messageLogStartOffset: ").Append(MessageLogStartOffset).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("  messageLogEndOffset: ").Append(MessageLogEndOffset).Append("\n");
            sb.Append("  consumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMessageOffsetsDetailEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupMessageOffsetsDetailEntity input)
        {
            if (input == null) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;
            if (this.MessageCurrentOffset != input.MessageCurrentOffset || (this.MessageCurrentOffset != null && !this.MessageCurrentOffset.Equals(input.MessageCurrentOffset))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.MessageLogStartOffset != input.MessageLogStartOffset || (this.MessageLogStartOffset != null && !this.MessageLogStartOffset.Equals(input.MessageLogStartOffset))) return false;
            if (this.Lag != input.Lag || (this.Lag != null && !this.Lag.Equals(input.Lag))) return false;
            if (this.MessageLogEndOffset != input.MessageLogEndOffset || (this.MessageLogEndOffset != null && !this.MessageLogEndOffset.Equals(input.MessageLogEndOffset))) return false;
            if (this.ConsumerId != input.ConsumerId || (this.ConsumerId != null && !this.ConsumerId.Equals(input.ConsumerId))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;

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
                if (this.MessageCurrentOffset != null) hashCode = hashCode * 59 + this.MessageCurrentOffset.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.MessageLogStartOffset != null) hashCode = hashCode * 59 + this.MessageLogStartOffset.GetHashCode();
                if (this.Lag != null) hashCode = hashCode * 59 + this.Lag.GetHashCode();
                if (this.MessageLogEndOffset != null) hashCode = hashCode * 59 + this.MessageLogEndOffset.GetHashCode();
                if (this.ConsumerId != null) hashCode = hashCode * 59 + this.ConsumerId.GetHashCode();
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                return hashCode;
            }
        }
    }
}
