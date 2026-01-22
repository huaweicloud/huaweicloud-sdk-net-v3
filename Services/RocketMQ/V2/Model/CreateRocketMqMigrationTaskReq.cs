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
    public class CreateRocketMqMigrationTaskReq 
    {

        /// <summary>
        /// **参数解释**： RocketMQ Topic 元数据，键为Topic名，值为topic配置，迁移任务类型为自建RocketMQ上云(rocketmq)时必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("topic_config_table", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, MigrationRocketMqTopicConfig> TopicConfigTable { get; set; }

        /// <summary>
        /// **参数解释**： RocketMQ消费组元数据，键为消费组名，值为消费组配置，迁移任务类型为自建RocketMQ上云(rocketmq)时必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("subscription_group_table", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, MigrationRocketMqSubscriptionGroup> SubscriptionGroupTable { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ vhost元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("vhosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationRabbitVhostMetadata> Vhosts { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ队列元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("queues", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationRabbitQueueMetadata> Queues { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ交换机元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("exchanges", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationRabbitExchangeMetadata> Exchanges { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ binding元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("bindings", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationRabbitBindingMetadata> Bindings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRocketMqMigrationTaskReq {\n");
            sb.Append("  topicConfigTable: ").Append(TopicConfigTable).Append("\n");
            sb.Append("  subscriptionGroupTable: ").Append(SubscriptionGroupTable).Append("\n");
            sb.Append("  vhosts: ").Append(Vhosts).Append("\n");
            sb.Append("  queues: ").Append(Queues).Append("\n");
            sb.Append("  exchanges: ").Append(Exchanges).Append("\n");
            sb.Append("  bindings: ").Append(Bindings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRocketMqMigrationTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRocketMqMigrationTaskReq input)
        {
            if (input == null) return false;
            if (this.TopicConfigTable != input.TopicConfigTable || (this.TopicConfigTable != null && input.TopicConfigTable != null && !this.TopicConfigTable.SequenceEqual(input.TopicConfigTable))) return false;
            if (this.SubscriptionGroupTable != input.SubscriptionGroupTable || (this.SubscriptionGroupTable != null && input.SubscriptionGroupTable != null && !this.SubscriptionGroupTable.SequenceEqual(input.SubscriptionGroupTable))) return false;
            if (this.Vhosts != input.Vhosts || (this.Vhosts != null && input.Vhosts != null && !this.Vhosts.SequenceEqual(input.Vhosts))) return false;
            if (this.Queues != input.Queues || (this.Queues != null && input.Queues != null && !this.Queues.SequenceEqual(input.Queues))) return false;
            if (this.Exchanges != input.Exchanges || (this.Exchanges != null && input.Exchanges != null && !this.Exchanges.SequenceEqual(input.Exchanges))) return false;
            if (this.Bindings != input.Bindings || (this.Bindings != null && input.Bindings != null && !this.Bindings.SequenceEqual(input.Bindings))) return false;

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
                if (this.TopicConfigTable != null) hashCode = hashCode * 59 + this.TopicConfigTable.GetHashCode();
                if (this.SubscriptionGroupTable != null) hashCode = hashCode * 59 + this.SubscriptionGroupTable.GetHashCode();
                if (this.Vhosts != null) hashCode = hashCode * 59 + this.Vhosts.GetHashCode();
                if (this.Queues != null) hashCode = hashCode * 59 + this.Queues.GetHashCode();
                if (this.Exchanges != null) hashCode = hashCode * 59 + this.Exchanges.GetHashCode();
                if (this.Bindings != null) hashCode = hashCode * 59 + this.Bindings.GetHashCode();
                return hashCode;
            }
        }
    }
}
