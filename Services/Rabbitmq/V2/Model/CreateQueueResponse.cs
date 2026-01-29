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
    /// Response Object
    /// </summary>
    public class CreateQueueResponse : SdkResponse
    {

        /// <summary>
        /// Queue名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否自动删除
        /// </summary>
        [JsonProperty("auto_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoDelete { get; set; }

        /// <summary>
        /// 是否持久化[（AMQP版本默认持久化，不涉及此字段）](tag:hws,hws_hk,hws_eu,srg)
        /// </summary>
        [JsonProperty("durable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Durable { get; set; }

        /// <summary>
        /// 死信Exchange名称，消息被拒绝或过期时将重新发布到该Exchange。
        /// </summary>
        [JsonProperty("dead_letter_exchange", NullValueHandling = NullValueHandling.Ignore)]
        public string DeadLetterExchange { get; set; }

        /// <summary>
        /// 死信Exchange的RoutingKey，死信Exchange会发送死信消息到绑定对应RoutingKey的Queue上。
        /// </summary>
        [JsonProperty("dead_letter_routing_key", NullValueHandling = NullValueHandling.Ignore)]
        public string DeadLetterRoutingKey { get; set; }

        /// <summary>
        /// 发布到Queue的消息在被丢弃之前可以存活多长时间
        /// </summary>
        [JsonProperty("message_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public long? MessageTtl { get; set; }

        /// <summary>
        /// 若设置惰性队列，请输入lazy。惰性队列模式会在磁盘上存储尽可能多的消息以减少内存使用；若不设置，队列将消息存储在内存缓存以尽可能快地传递消息。[（AMQP版本默认将消息存储到磁盘，不涉及此字段）](tag:hws,hws_hk,hws_eu,srg)
        /// </summary>
        [JsonProperty("lazy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string LazyMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateQueueResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  autoDelete: ").Append(AutoDelete).Append("\n");
            sb.Append("  durable: ").Append(Durable).Append("\n");
            sb.Append("  deadLetterExchange: ").Append(DeadLetterExchange).Append("\n");
            sb.Append("  deadLetterRoutingKey: ").Append(DeadLetterRoutingKey).Append("\n");
            sb.Append("  messageTtl: ").Append(MessageTtl).Append("\n");
            sb.Append("  lazyMode: ").Append(LazyMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateQueueResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateQueueResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AutoDelete != input.AutoDelete || (this.AutoDelete != null && !this.AutoDelete.Equals(input.AutoDelete))) return false;
            if (this.Durable != input.Durable || (this.Durable != null && !this.Durable.Equals(input.Durable))) return false;
            if (this.DeadLetterExchange != input.DeadLetterExchange || (this.DeadLetterExchange != null && !this.DeadLetterExchange.Equals(input.DeadLetterExchange))) return false;
            if (this.DeadLetterRoutingKey != input.DeadLetterRoutingKey || (this.DeadLetterRoutingKey != null && !this.DeadLetterRoutingKey.Equals(input.DeadLetterRoutingKey))) return false;
            if (this.MessageTtl != input.MessageTtl || (this.MessageTtl != null && !this.MessageTtl.Equals(input.MessageTtl))) return false;
            if (this.LazyMode != input.LazyMode || (this.LazyMode != null && !this.LazyMode.Equals(input.LazyMode))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AutoDelete != null) hashCode = hashCode * 59 + this.AutoDelete.GetHashCode();
                if (this.Durable != null) hashCode = hashCode * 59 + this.Durable.GetHashCode();
                if (this.DeadLetterExchange != null) hashCode = hashCode * 59 + this.DeadLetterExchange.GetHashCode();
                if (this.DeadLetterRoutingKey != null) hashCode = hashCode * 59 + this.DeadLetterRoutingKey.GetHashCode();
                if (this.MessageTtl != null) hashCode = hashCode * 59 + this.MessageTtl.GetHashCode();
                if (this.LazyMode != null) hashCode = hashCode * 59 + this.LazyMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
