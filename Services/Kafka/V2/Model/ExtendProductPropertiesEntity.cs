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
    /// 产品规格属性描述。
    /// </summary>
    public class ExtendProductPropertiesEntity 
    {

        /// <summary>
        /// 每个Broker的最大分区数。
        /// </summary>
        [JsonProperty("max_partition_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxPartitionPerBroker { get; set; }

        /// <summary>
        /// Broker的最大个数。
        /// </summary>
        [JsonProperty("max_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxBroker { get; set; }

        /// <summary>
        /// 每个节点的最大存储。单位为GB。
        /// </summary>
        [JsonProperty("max_storage_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxStoragePerNode { get; set; }

        /// <summary>
        /// 每个Broker的最大消费者数。
        /// </summary>
        [JsonProperty("max_consumer_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConsumerPerBroker { get; set; }

        /// <summary>
        /// Broker的最小个数。
        /// </summary>
        [JsonProperty("min_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MinBroker { get; set; }

        /// <summary>
        /// 每个Broker的最大带宽。
        /// </summary>
        [JsonProperty("max_bandwidth_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxBandwidthPerBroker { get; set; }

        /// <summary>
        /// 每个节点的最小存储。单位为GB。
        /// </summary>
        [JsonProperty("min_storage_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MinStoragePerNode { get; set; }

        /// <summary>
        /// 每个Broker的最大TPS。
        /// </summary>
        [JsonProperty("max_tps_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxTpsPerBroker { get; set; }

        /// <summary>
        /// product_id的别名。
        /// </summary>
        [JsonProperty("product_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAlias { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendProductPropertiesEntity {\n");
            sb.Append("  maxPartitionPerBroker: ").Append(MaxPartitionPerBroker).Append("\n");
            sb.Append("  maxBroker: ").Append(MaxBroker).Append("\n");
            sb.Append("  maxStoragePerNode: ").Append(MaxStoragePerNode).Append("\n");
            sb.Append("  maxConsumerPerBroker: ").Append(MaxConsumerPerBroker).Append("\n");
            sb.Append("  minBroker: ").Append(MinBroker).Append("\n");
            sb.Append("  maxBandwidthPerBroker: ").Append(MaxBandwidthPerBroker).Append("\n");
            sb.Append("  minStoragePerNode: ").Append(MinStoragePerNode).Append("\n");
            sb.Append("  maxTpsPerBroker: ").Append(MaxTpsPerBroker).Append("\n");
            sb.Append("  productAlias: ").Append(ProductAlias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtendProductPropertiesEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtendProductPropertiesEntity input)
        {
            if (input == null) return false;
            if (this.MaxPartitionPerBroker != input.MaxPartitionPerBroker || (this.MaxPartitionPerBroker != null && !this.MaxPartitionPerBroker.Equals(input.MaxPartitionPerBroker))) return false;
            if (this.MaxBroker != input.MaxBroker || (this.MaxBroker != null && !this.MaxBroker.Equals(input.MaxBroker))) return false;
            if (this.MaxStoragePerNode != input.MaxStoragePerNode || (this.MaxStoragePerNode != null && !this.MaxStoragePerNode.Equals(input.MaxStoragePerNode))) return false;
            if (this.MaxConsumerPerBroker != input.MaxConsumerPerBroker || (this.MaxConsumerPerBroker != null && !this.MaxConsumerPerBroker.Equals(input.MaxConsumerPerBroker))) return false;
            if (this.MinBroker != input.MinBroker || (this.MinBroker != null && !this.MinBroker.Equals(input.MinBroker))) return false;
            if (this.MaxBandwidthPerBroker != input.MaxBandwidthPerBroker || (this.MaxBandwidthPerBroker != null && !this.MaxBandwidthPerBroker.Equals(input.MaxBandwidthPerBroker))) return false;
            if (this.MinStoragePerNode != input.MinStoragePerNode || (this.MinStoragePerNode != null && !this.MinStoragePerNode.Equals(input.MinStoragePerNode))) return false;
            if (this.MaxTpsPerBroker != input.MaxTpsPerBroker || (this.MaxTpsPerBroker != null && !this.MaxTpsPerBroker.Equals(input.MaxTpsPerBroker))) return false;
            if (this.ProductAlias != input.ProductAlias || (this.ProductAlias != null && !this.ProductAlias.Equals(input.ProductAlias))) return false;

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
                if (this.MaxPartitionPerBroker != null) hashCode = hashCode * 59 + this.MaxPartitionPerBroker.GetHashCode();
                if (this.MaxBroker != null) hashCode = hashCode * 59 + this.MaxBroker.GetHashCode();
                if (this.MaxStoragePerNode != null) hashCode = hashCode * 59 + this.MaxStoragePerNode.GetHashCode();
                if (this.MaxConsumerPerBroker != null) hashCode = hashCode * 59 + this.MaxConsumerPerBroker.GetHashCode();
                if (this.MinBroker != null) hashCode = hashCode * 59 + this.MinBroker.GetHashCode();
                if (this.MaxBandwidthPerBroker != null) hashCode = hashCode * 59 + this.MaxBandwidthPerBroker.GetHashCode();
                if (this.MinStoragePerNode != null) hashCode = hashCode * 59 + this.MinStoragePerNode.GetHashCode();
                if (this.MaxTpsPerBroker != null) hashCode = hashCode * 59 + this.MaxTpsPerBroker.GetHashCode();
                if (this.ProductAlias != null) hashCode = hashCode * 59 + this.ProductAlias.GetHashCode();
                return hashCode;
            }
        }
    }
}
