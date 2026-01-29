using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// **参数解释**： Queue参数，如果未配置则不返回。
    /// </summary>
    public class QueueArguments 
    {

        /// <summary>
        /// **参数解释**： 消息过期时间，发布到Queue的消息在被丢弃之前可以存活多长时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("x-message-ttl", NullValueHandling = NullValueHandling.Ignore)]
        public long? XMessageTtl { get; set; }

        /// <summary>
        /// **参数解释**： 死信Exchange名称，消息被拒绝或过期时将重新发布到该Exchange。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("x-dead-letter-exchange", NullValueHandling = NullValueHandling.Ignore)]
        public string XDeadLetterExchange { get; set; }

        /// <summary>
        /// **参数解释**： 死信的RoutingKey，死信Exchange会发送死信消息到绑定对应RoutingKey的Queue上。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("x-dead-letter-routing-key", NullValueHandling = NullValueHandling.Ignore)]
        public string XDeadLetterRoutingKey { get; set; }

        /// <summary>
        /// **参数解释**： 惰性队列[（AMQP版本默认持久化所有消息，不涉及此参数）](tag:hws,hws_hk,hws_eu,srg)。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("x-queue-mode", NullValueHandling = NullValueHandling.Ignore)]
        public string XQueueMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueArguments {\n");
            sb.Append("  xMessageTtl: ").Append(XMessageTtl).Append("\n");
            sb.Append("  xDeadLetterExchange: ").Append(XDeadLetterExchange).Append("\n");
            sb.Append("  xDeadLetterRoutingKey: ").Append(XDeadLetterRoutingKey).Append("\n");
            sb.Append("  xQueueMode: ").Append(XQueueMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueueArguments);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueueArguments input)
        {
            if (input == null) return false;
            if (this.XMessageTtl != input.XMessageTtl || (this.XMessageTtl != null && !this.XMessageTtl.Equals(input.XMessageTtl))) return false;
            if (this.XDeadLetterExchange != input.XDeadLetterExchange || (this.XDeadLetterExchange != null && !this.XDeadLetterExchange.Equals(input.XDeadLetterExchange))) return false;
            if (this.XDeadLetterRoutingKey != input.XDeadLetterRoutingKey || (this.XDeadLetterRoutingKey != null && !this.XDeadLetterRoutingKey.Equals(input.XDeadLetterRoutingKey))) return false;
            if (this.XQueueMode != input.XQueueMode || (this.XQueueMode != null && !this.XQueueMode.Equals(input.XQueueMode))) return false;

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
                if (this.XMessageTtl != null) hashCode = hashCode * 59 + this.XMessageTtl.GetHashCode();
                if (this.XDeadLetterExchange != null) hashCode = hashCode * 59 + this.XDeadLetterExchange.GetHashCode();
                if (this.XDeadLetterRoutingKey != null) hashCode = hashCode * 59 + this.XDeadLetterRoutingKey.GetHashCode();
                if (this.XQueueMode != null) hashCode = hashCode * 59 + this.XQueueMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
