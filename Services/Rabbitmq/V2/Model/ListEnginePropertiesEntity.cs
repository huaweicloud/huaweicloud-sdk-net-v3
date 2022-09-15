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
    /// 当前规格实例的属性。
    /// </summary>
    public class ListEnginePropertiesEntity 
    {

        /// <summary>
        /// 节点增长步长。
        /// </summary>
        [JsonProperty("step_length", NullValueHandling = NullValueHandling.Ignore)]
        public string StepLength { get; set; }

        /// <summary>
        /// 每个Broker的最大对列。
        /// </summary>
        [JsonProperty("max_queue_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxQueuePerBroker { get; set; }

        /// <summary>
        /// 每个Broker的最大连接数。
        /// </summary>
        [JsonProperty("max_connection_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConnectionPerBroker { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnginePropertiesEntity {\n");
            sb.Append("  stepLength: ").Append(StepLength).Append("\n");
            sb.Append("  maxQueuePerBroker: ").Append(MaxQueuePerBroker).Append("\n");
            sb.Append("  maxConnectionPerBroker: ").Append(MaxConnectionPerBroker).Append("\n");
            sb.Append("  maxPartitionPerBroker: ").Append(MaxPartitionPerBroker).Append("\n");
            sb.Append("  maxBroker: ").Append(MaxBroker).Append("\n");
            sb.Append("  maxStoragePerNode: ").Append(MaxStoragePerNode).Append("\n");
            sb.Append("  maxConsumerPerBroker: ").Append(MaxConsumerPerBroker).Append("\n");
            sb.Append("  minBroker: ").Append(MinBroker).Append("\n");
            sb.Append("  maxBandwidthPerBroker: ").Append(MaxBandwidthPerBroker).Append("\n");
            sb.Append("  minStoragePerNode: ").Append(MinStoragePerNode).Append("\n");
            sb.Append("  maxTpsPerBroker: ").Append(MaxTpsPerBroker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnginePropertiesEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnginePropertiesEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StepLength == input.StepLength ||
                    (this.StepLength != null &&
                    this.StepLength.Equals(input.StepLength))
                ) && 
                (
                    this.MaxQueuePerBroker == input.MaxQueuePerBroker ||
                    (this.MaxQueuePerBroker != null &&
                    this.MaxQueuePerBroker.Equals(input.MaxQueuePerBroker))
                ) && 
                (
                    this.MaxConnectionPerBroker == input.MaxConnectionPerBroker ||
                    (this.MaxConnectionPerBroker != null &&
                    this.MaxConnectionPerBroker.Equals(input.MaxConnectionPerBroker))
                ) && 
                (
                    this.MaxPartitionPerBroker == input.MaxPartitionPerBroker ||
                    (this.MaxPartitionPerBroker != null &&
                    this.MaxPartitionPerBroker.Equals(input.MaxPartitionPerBroker))
                ) && 
                (
                    this.MaxBroker == input.MaxBroker ||
                    (this.MaxBroker != null &&
                    this.MaxBroker.Equals(input.MaxBroker))
                ) && 
                (
                    this.MaxStoragePerNode == input.MaxStoragePerNode ||
                    (this.MaxStoragePerNode != null &&
                    this.MaxStoragePerNode.Equals(input.MaxStoragePerNode))
                ) && 
                (
                    this.MaxConsumerPerBroker == input.MaxConsumerPerBroker ||
                    (this.MaxConsumerPerBroker != null &&
                    this.MaxConsumerPerBroker.Equals(input.MaxConsumerPerBroker))
                ) && 
                (
                    this.MinBroker == input.MinBroker ||
                    (this.MinBroker != null &&
                    this.MinBroker.Equals(input.MinBroker))
                ) && 
                (
                    this.MaxBandwidthPerBroker == input.MaxBandwidthPerBroker ||
                    (this.MaxBandwidthPerBroker != null &&
                    this.MaxBandwidthPerBroker.Equals(input.MaxBandwidthPerBroker))
                ) && 
                (
                    this.MinStoragePerNode == input.MinStoragePerNode ||
                    (this.MinStoragePerNode != null &&
                    this.MinStoragePerNode.Equals(input.MinStoragePerNode))
                ) && 
                (
                    this.MaxTpsPerBroker == input.MaxTpsPerBroker ||
                    (this.MaxTpsPerBroker != null &&
                    this.MaxTpsPerBroker.Equals(input.MaxTpsPerBroker))
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
                if (this.StepLength != null)
                    hashCode = hashCode * 59 + this.StepLength.GetHashCode();
                if (this.MaxQueuePerBroker != null)
                    hashCode = hashCode * 59 + this.MaxQueuePerBroker.GetHashCode();
                if (this.MaxConnectionPerBroker != null)
                    hashCode = hashCode * 59 + this.MaxConnectionPerBroker.GetHashCode();
                if (this.MaxPartitionPerBroker != null)
                    hashCode = hashCode * 59 + this.MaxPartitionPerBroker.GetHashCode();
                if (this.MaxBroker != null)
                    hashCode = hashCode * 59 + this.MaxBroker.GetHashCode();
                if (this.MaxStoragePerNode != null)
                    hashCode = hashCode * 59 + this.MaxStoragePerNode.GetHashCode();
                if (this.MaxConsumerPerBroker != null)
                    hashCode = hashCode * 59 + this.MaxConsumerPerBroker.GetHashCode();
                if (this.MinBroker != null)
                    hashCode = hashCode * 59 + this.MinBroker.GetHashCode();
                if (this.MaxBandwidthPerBroker != null)
                    hashCode = hashCode * 59 + this.MaxBandwidthPerBroker.GetHashCode();
                if (this.MinStoragePerNode != null)
                    hashCode = hashCode * 59 + this.MinStoragePerNode.GetHashCode();
                if (this.MaxTpsPerBroker != null)
                    hashCode = hashCode * 59 + this.MaxTpsPerBroker.GetHashCode();
                return hashCode;
            }
        }
    }
}
