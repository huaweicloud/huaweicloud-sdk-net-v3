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
    /// 功能特性的键值对。
    /// </summary>
    public class RocketMQExtendProductPropertiesEntity 
    {

        /// <summary>
        /// Broker的最大个数。
        /// </summary>
        [JsonProperty("max_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxBroker { get; set; }

        /// <summary>
        /// 每个节点最多能创建的Topic个数。
        /// </summary>
        [JsonProperty("max_topic_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxTopicPerBroker { get; set; }

        /// <summary>
        /// 每个节点的最大消费者数。
        /// </summary>
        [JsonProperty("max_consumer_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConsumerPerBroker { get; set; }

        /// <summary>
        /// 每个节点的最大存储。单位为GB
        /// </summary>
        [JsonProperty("max_storage_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxStoragePerNode { get; set; }

        /// <summary>
        /// Broker的最小个数。
        /// </summary>
        [JsonProperty("min_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MinBroker { get; set; }

        /// <summary>
        /// 消息引擎版本。
        /// </summary>
        [JsonProperty("engine_versions", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersions { get; set; }

        /// <summary>
        /// 每个节点的最小存储。单位为GB
        /// </summary>
        [JsonProperty("min_storage_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MinStoragePerNode { get; set; }

        /// <summary>
        /// product_id的别名
        /// </summary>
        [JsonProperty("product_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAlias { get; set; }



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
            sb.Append("  maxStoragePerNode: ").Append(MaxStoragePerNode).Append("\n");
            sb.Append("  minBroker: ").Append(MinBroker).Append("\n");
            sb.Append("  engineVersions: ").Append(EngineVersions).Append("\n");
            sb.Append("  minStoragePerNode: ").Append(MinStoragePerNode).Append("\n");
            sb.Append("  productAlias: ").Append(ProductAlias).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.MaxBroker == input.MaxBroker ||
                    (this.MaxBroker != null &&
                    this.MaxBroker.Equals(input.MaxBroker))
                ) && 
                (
                    this.MaxTopicPerBroker == input.MaxTopicPerBroker ||
                    (this.MaxTopicPerBroker != null &&
                    this.MaxTopicPerBroker.Equals(input.MaxTopicPerBroker))
                ) && 
                (
                    this.MaxConsumerPerBroker == input.MaxConsumerPerBroker ||
                    (this.MaxConsumerPerBroker != null &&
                    this.MaxConsumerPerBroker.Equals(input.MaxConsumerPerBroker))
                ) && 
                (
                    this.MaxStoragePerNode == input.MaxStoragePerNode ||
                    (this.MaxStoragePerNode != null &&
                    this.MaxStoragePerNode.Equals(input.MaxStoragePerNode))
                ) && 
                (
                    this.MinBroker == input.MinBroker ||
                    (this.MinBroker != null &&
                    this.MinBroker.Equals(input.MinBroker))
                ) && 
                (
                    this.EngineVersions == input.EngineVersions ||
                    (this.EngineVersions != null &&
                    this.EngineVersions.Equals(input.EngineVersions))
                ) && 
                (
                    this.MinStoragePerNode == input.MinStoragePerNode ||
                    (this.MinStoragePerNode != null &&
                    this.MinStoragePerNode.Equals(input.MinStoragePerNode))
                ) && 
                (
                    this.ProductAlias == input.ProductAlias ||
                    (this.ProductAlias != null &&
                    this.ProductAlias.Equals(input.ProductAlias))
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
                if (this.MaxBroker != null)
                    hashCode = hashCode * 59 + this.MaxBroker.GetHashCode();
                if (this.MaxTopicPerBroker != null)
                    hashCode = hashCode * 59 + this.MaxTopicPerBroker.GetHashCode();
                if (this.MaxConsumerPerBroker != null)
                    hashCode = hashCode * 59 + this.MaxConsumerPerBroker.GetHashCode();
                if (this.MaxStoragePerNode != null)
                    hashCode = hashCode * 59 + this.MaxStoragePerNode.GetHashCode();
                if (this.MinBroker != null)
                    hashCode = hashCode * 59 + this.MinBroker.GetHashCode();
                if (this.EngineVersions != null)
                    hashCode = hashCode * 59 + this.EngineVersions.GetHashCode();
                if (this.MinStoragePerNode != null)
                    hashCode = hashCode * 59 + this.MinStoragePerNode.GetHashCode();
                if (this.ProductAlias != null)
                    hashCode = hashCode * 59 + this.ProductAlias.GetHashCode();
                return hashCode;
            }
        }
    }
}
