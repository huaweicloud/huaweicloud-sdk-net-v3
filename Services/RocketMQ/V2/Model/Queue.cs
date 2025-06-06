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
    public class Queue 
    {

        /// <summary>
        /// **参数解释**： 队列ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释**： 队列消费堆积总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lag { get; set; }

        /// <summary>
        /// **参数解释**： 队列消息总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("broker_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? BrokerOffset { get; set; }

        /// <summary>
        /// **参数解释**： 已消费消息数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("consumer_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConsumerOffset { get; set; }

        /// <summary>
        /// **参数解释**： 最新消费消息的存储时间，Unix毫秒时间戳格式。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("last_message_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastMessageTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Queue {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("  brokerOffset: ").Append(BrokerOffset).Append("\n");
            sb.Append("  consumerOffset: ").Append(ConsumerOffset).Append("\n");
            sb.Append("  lastMessageTime: ").Append(LastMessageTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Queue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Queue input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Lag != input.Lag || (this.Lag != null && !this.Lag.Equals(input.Lag))) return false;
            if (this.BrokerOffset != input.BrokerOffset || (this.BrokerOffset != null && !this.BrokerOffset.Equals(input.BrokerOffset))) return false;
            if (this.ConsumerOffset != input.ConsumerOffset || (this.ConsumerOffset != null && !this.ConsumerOffset.Equals(input.ConsumerOffset))) return false;
            if (this.LastMessageTime != input.LastMessageTime || (this.LastMessageTime != null && !this.LastMessageTime.Equals(input.LastMessageTime))) return false;

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
                if (this.Lag != null) hashCode = hashCode * 59 + this.Lag.GetHashCode();
                if (this.BrokerOffset != null) hashCode = hashCode * 59 + this.BrokerOffset.GetHashCode();
                if (this.ConsumerOffset != null) hashCode = hashCode * 59 + this.ConsumerOffset.GetHashCode();
                if (this.LastMessageTime != null) hashCode = hashCode * 59 + this.LastMessageTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
