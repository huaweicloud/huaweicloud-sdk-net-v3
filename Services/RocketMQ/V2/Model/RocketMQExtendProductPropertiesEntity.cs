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
    /// **参数解释**： 功能特性的键值对。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
    /// </summary>
    public class RocketMQExtendProductPropertiesEntity 
    {

        /// <summary>
        /// **参数解释**： Broker的最大个数（仅RocketMQ 4.8.0版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxBroker { get; set; }

        /// <summary>
        /// **参数解释**： 每个节点最多能创建的Topic个数（仅RocketMQ 4.8.0版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_topic_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxTopicPerBroker { get; set; }

        /// <summary>
        /// **参数解释**： 每个节点的最大消费者数（仅RocketMQ 4.8.0版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_consumer_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConsumerPerBroker { get; set; }

        /// <summary>
        /// **参数解释**： Broker的最小个数（仅RocketMQ 4.8.0版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("min_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MinBroker { get; set; }

        /// <summary>
        /// **参数解释**： 消息引擎版本。 **约束限制**： 不涉及。 **取值范围**： [- 4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- 5.x](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,srg) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("engine_versions", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersions { get; set; }

        /// <summary>
        /// **参数解释**： 每个节点的最大存储。单位为GB  **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_storage_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxStoragePerNode { get; set; }

        /// <summary>
        /// **参数解释**： 每个节点的最小存储。单位为GB。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("min_storage_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MinStoragePerNode { get; set; }

        /// <summary>
        /// **参数解释**： product_id的别名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("product_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAlias { get; set; }

        /// <summary>
        /// **参数解释**： 该规格对应特性开关。（仅RocketMQ 5.x版本会显示此字段） **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }

        /// <summary>
        /// **参数解释**： 实例Topic的最大数（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxTopic { get; set; }

        /// <summary>
        /// **参数解释**： broker数量（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerNum { get; set; }

        /// <summary>
        /// **参数解释**： 整个实例的计费核数（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("core", NullValueHandling = NullValueHandling.Ignore)]
        public string Core { get; set; }

        /// <summary>
        /// **参数解释**： 实例消费者的最大数（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_consumer", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConsumer { get; set; }

        /// <summary>
        /// **参数解释**： 流量单元，rcu * max_tpc_per_rcu &#x3D; 规格最大TPS（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("rcu", NullValueHandling = NullValueHandling.Ignore)]
        public string Rcu { get; set; }

        /// <summary>
        /// **参数解释**： 最大存储空间（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_storage", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxStorage { get; set; }

        /// <summary>
        /// **参数解释**： 最小存储空间（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("min_storage", NullValueHandling = NullValueHandling.Ignore)]
        public string MinStorage { get; set; }

        /// <summary>
        /// **参数解释**： 单个rcu最大TPS（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_tps_per_rcu", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxTpsPerRcu { get; set; }

        /// <summary>
        /// **参数解释**： 弹性TPS（仅RocketMQ 5.x版本会显示此字段）。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("elastic_tps", NullValueHandling = NullValueHandling.Ignore)]
        public string ElasticTps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RocketMQExtendProductPropertiesEntity {\n");
            sb.Append("  maxBroker: ").Append(MaxBroker).Append("\n");
            sb.Append("  maxTopicPerBroker: ").Append(MaxTopicPerBroker).Append("\n");
            sb.Append("  maxConsumerPerBroker: ").Append(MaxConsumerPerBroker).Append("\n");
            sb.Append("  minBroker: ").Append(MinBroker).Append("\n");
            sb.Append("  engineVersions: ").Append(EngineVersions).Append("\n");
            sb.Append("  maxStoragePerNode: ").Append(MaxStoragePerNode).Append("\n");
            sb.Append("  minStoragePerNode: ").Append(MinStoragePerNode).Append("\n");
            sb.Append("  productAlias: ").Append(ProductAlias).Append("\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("  maxTopic: ").Append(MaxTopic).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("  core: ").Append(Core).Append("\n");
            sb.Append("  maxConsumer: ").Append(MaxConsumer).Append("\n");
            sb.Append("  rcu: ").Append(Rcu).Append("\n");
            sb.Append("  maxStorage: ").Append(MaxStorage).Append("\n");
            sb.Append("  minStorage: ").Append(MinStorage).Append("\n");
            sb.Append("  maxTpsPerRcu: ").Append(MaxTpsPerRcu).Append("\n");
            sb.Append("  elasticTps: ").Append(ElasticTps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RocketMQExtendProductPropertiesEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RocketMQExtendProductPropertiesEntity input)
        {
            if (input == null) return false;
            if (this.MaxBroker != input.MaxBroker || (this.MaxBroker != null && !this.MaxBroker.Equals(input.MaxBroker))) return false;
            if (this.MaxTopicPerBroker != input.MaxTopicPerBroker || (this.MaxTopicPerBroker != null && !this.MaxTopicPerBroker.Equals(input.MaxTopicPerBroker))) return false;
            if (this.MaxConsumerPerBroker != input.MaxConsumerPerBroker || (this.MaxConsumerPerBroker != null && !this.MaxConsumerPerBroker.Equals(input.MaxConsumerPerBroker))) return false;
            if (this.MinBroker != input.MinBroker || (this.MinBroker != null && !this.MinBroker.Equals(input.MinBroker))) return false;
            if (this.EngineVersions != input.EngineVersions || (this.EngineVersions != null && !this.EngineVersions.Equals(input.EngineVersions))) return false;
            if (this.MaxStoragePerNode != input.MaxStoragePerNode || (this.MaxStoragePerNode != null && !this.MaxStoragePerNode.Equals(input.MaxStoragePerNode))) return false;
            if (this.MinStoragePerNode != input.MinStoragePerNode || (this.MinStoragePerNode != null && !this.MinStoragePerNode.Equals(input.MinStoragePerNode))) return false;
            if (this.ProductAlias != input.ProductAlias || (this.ProductAlias != null && !this.ProductAlias.Equals(input.ProductAlias))) return false;
            if (this.Feature != input.Feature || (this.Feature != null && !this.Feature.Equals(input.Feature))) return false;
            if (this.MaxTopic != input.MaxTopic || (this.MaxTopic != null && !this.MaxTopic.Equals(input.MaxTopic))) return false;
            if (this.BrokerNum != input.BrokerNum || (this.BrokerNum != null && !this.BrokerNum.Equals(input.BrokerNum))) return false;
            if (this.Core != input.Core || (this.Core != null && !this.Core.Equals(input.Core))) return false;
            if (this.MaxConsumer != input.MaxConsumer || (this.MaxConsumer != null && !this.MaxConsumer.Equals(input.MaxConsumer))) return false;
            if (this.Rcu != input.Rcu || (this.Rcu != null && !this.Rcu.Equals(input.Rcu))) return false;
            if (this.MaxStorage != input.MaxStorage || (this.MaxStorage != null && !this.MaxStorage.Equals(input.MaxStorage))) return false;
            if (this.MinStorage != input.MinStorage || (this.MinStorage != null && !this.MinStorage.Equals(input.MinStorage))) return false;
            if (this.MaxTpsPerRcu != input.MaxTpsPerRcu || (this.MaxTpsPerRcu != null && !this.MaxTpsPerRcu.Equals(input.MaxTpsPerRcu))) return false;
            if (this.ElasticTps != input.ElasticTps || (this.ElasticTps != null && !this.ElasticTps.Equals(input.ElasticTps))) return false;

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
                if (this.MaxBroker != null) hashCode = hashCode * 59 + this.MaxBroker.GetHashCode();
                if (this.MaxTopicPerBroker != null) hashCode = hashCode * 59 + this.MaxTopicPerBroker.GetHashCode();
                if (this.MaxConsumerPerBroker != null) hashCode = hashCode * 59 + this.MaxConsumerPerBroker.GetHashCode();
                if (this.MinBroker != null) hashCode = hashCode * 59 + this.MinBroker.GetHashCode();
                if (this.EngineVersions != null) hashCode = hashCode * 59 + this.EngineVersions.GetHashCode();
                if (this.MaxStoragePerNode != null) hashCode = hashCode * 59 + this.MaxStoragePerNode.GetHashCode();
                if (this.MinStoragePerNode != null) hashCode = hashCode * 59 + this.MinStoragePerNode.GetHashCode();
                if (this.ProductAlias != null) hashCode = hashCode * 59 + this.ProductAlias.GetHashCode();
                if (this.Feature != null) hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.MaxTopic != null) hashCode = hashCode * 59 + this.MaxTopic.GetHashCode();
                if (this.BrokerNum != null) hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.Core != null) hashCode = hashCode * 59 + this.Core.GetHashCode();
                if (this.MaxConsumer != null) hashCode = hashCode * 59 + this.MaxConsumer.GetHashCode();
                if (this.Rcu != null) hashCode = hashCode * 59 + this.Rcu.GetHashCode();
                if (this.MaxStorage != null) hashCode = hashCode * 59 + this.MaxStorage.GetHashCode();
                if (this.MinStorage != null) hashCode = hashCode * 59 + this.MinStorage.GetHashCode();
                if (this.MaxTpsPerRcu != null) hashCode = hashCode * 59 + this.MaxTpsPerRcu.GetHashCode();
                if (this.ElasticTps != null) hashCode = hashCode * 59 + this.ElasticTps.GetHashCode();
                return hashCode;
            }
        }
    }
}
