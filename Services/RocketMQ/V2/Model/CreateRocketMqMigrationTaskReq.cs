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
        /// RocketMQ topic 元数据，键为topic名，值为topic配置，迁移任务类型为自建RocketMQ上云(rocketmq)时必填。
        /// </summary>
        [JsonProperty("topicConfigTable", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, MigrationRocketMqTopicConfig> TopicConfigTable { get; set; }

        /// <summary>
        /// RocketMQ消费组元数据，键为消费组名，值为消费组配置，迁移任务类型为自建RocketMQ上云(rocketmq)时必填。
        /// </summary>
        [JsonProperty("subscriptionGroupTable", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, MigrationRocketMqSubscriptionGroup> SubscriptionGroupTable { get; set; }

        /// <summary>
        /// RabbitMQ vhost元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。
        /// </summary>
        [JsonProperty("vhosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationRabbitVhostMetadata> Vhosts { get; set; }

        /// <summary>
        /// RabbitMQ队列元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。
        /// </summary>
        [JsonProperty("queues", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationRabbitQueueMetadata> Queues { get; set; }

        /// <summary>
        /// RabbitMQ交换机元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。
        /// </summary>
        [JsonProperty("exchanges", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationRabbitExchangeMetadata> Exchanges { get; set; }

        /// <summary>
        /// RabbitMQ binding元数据列表，迁移任务类型为自建RabbitMQ上云(rabbitToRocket)时必填。
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
            if (input == null)
                return false;

            return 
                (
                    this.TopicConfigTable == input.TopicConfigTable ||
                    this.TopicConfigTable != null &&
                    input.TopicConfigTable != null &&
                    this.TopicConfigTable.SequenceEqual(input.TopicConfigTable)
                ) && 
                (
                    this.SubscriptionGroupTable == input.SubscriptionGroupTable ||
                    this.SubscriptionGroupTable != null &&
                    input.SubscriptionGroupTable != null &&
                    this.SubscriptionGroupTable.SequenceEqual(input.SubscriptionGroupTable)
                ) && 
                (
                    this.Vhosts == input.Vhosts ||
                    this.Vhosts != null &&
                    input.Vhosts != null &&
                    this.Vhosts.SequenceEqual(input.Vhosts)
                ) && 
                (
                    this.Queues == input.Queues ||
                    this.Queues != null &&
                    input.Queues != null &&
                    this.Queues.SequenceEqual(input.Queues)
                ) && 
                (
                    this.Exchanges == input.Exchanges ||
                    this.Exchanges != null &&
                    input.Exchanges != null &&
                    this.Exchanges.SequenceEqual(input.Exchanges)
                ) && 
                (
                    this.Bindings == input.Bindings ||
                    this.Bindings != null &&
                    input.Bindings != null &&
                    this.Bindings.SequenceEqual(input.Bindings)
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
                if (this.TopicConfigTable != null)
                    hashCode = hashCode * 59 + this.TopicConfigTable.GetHashCode();
                if (this.SubscriptionGroupTable != null)
                    hashCode = hashCode * 59 + this.SubscriptionGroupTable.GetHashCode();
                if (this.Vhosts != null)
                    hashCode = hashCode * 59 + this.Vhosts.GetHashCode();
                if (this.Queues != null)
                    hashCode = hashCode * 59 + this.Queues.GetHashCode();
                if (this.Exchanges != null)
                    hashCode = hashCode * 59 + this.Exchanges.GetHashCode();
                if (this.Bindings != null)
                    hashCode = hashCode * 59 + this.Bindings.GetHashCode();
                return hashCode;
            }
        }
    }
}
