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
    /// 功能特性的键值对。
    /// </summary>
    public class RabbitMQExtendProductPropertiesEntity 
    {

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
        /// Broker的最小个数。
        /// </summary>
        [JsonProperty("min_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MinBroker { get; set; }

        /// <summary>
        /// 每个节点的最小存储。单位为GB。
        /// </summary>
        [JsonProperty("min_storage_per_node", NullValueHandling = NullValueHandling.Ignore)]
        public string MinStoragePerNode { get; set; }

        /// <summary>
        /// 最大连接数
        /// </summary>
        [JsonProperty("max_connection_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConnectionPerBroker { get; set; }

        /// <summary>
        /// 步长
        /// </summary>
        [JsonProperty("step_length", NullValueHandling = NullValueHandling.Ignore)]
        public string StepLength { get; set; }

        /// <summary>
        /// product_id的别名。
        /// </summary>
        [JsonProperty("product_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAlias { get; set; }

        /// <summary>
        /// 最大队列
        /// </summary>
        [JsonProperty("max_queue_per_broker", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxQueuePerBroker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RabbitMQExtendProductPropertiesEntity {\n");
            sb.Append("  maxBroker: ").Append(MaxBroker).Append("\n");
            sb.Append("  maxStoragePerNode: ").Append(MaxStoragePerNode).Append("\n");
            sb.Append("  minBroker: ").Append(MinBroker).Append("\n");
            sb.Append("  minStoragePerNode: ").Append(MinStoragePerNode).Append("\n");
            sb.Append("  maxConnectionPerBroker: ").Append(MaxConnectionPerBroker).Append("\n");
            sb.Append("  stepLength: ").Append(StepLength).Append("\n");
            sb.Append("  productAlias: ").Append(ProductAlias).Append("\n");
            sb.Append("  maxQueuePerBroker: ").Append(MaxQueuePerBroker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RabbitMQExtendProductPropertiesEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RabbitMQExtendProductPropertiesEntity input)
        {
            if (input == null) return false;
            if (this.MaxBroker != input.MaxBroker || (this.MaxBroker != null && !this.MaxBroker.Equals(input.MaxBroker))) return false;
            if (this.MaxStoragePerNode != input.MaxStoragePerNode || (this.MaxStoragePerNode != null && !this.MaxStoragePerNode.Equals(input.MaxStoragePerNode))) return false;
            if (this.MinBroker != input.MinBroker || (this.MinBroker != null && !this.MinBroker.Equals(input.MinBroker))) return false;
            if (this.MinStoragePerNode != input.MinStoragePerNode || (this.MinStoragePerNode != null && !this.MinStoragePerNode.Equals(input.MinStoragePerNode))) return false;
            if (this.MaxConnectionPerBroker != input.MaxConnectionPerBroker || (this.MaxConnectionPerBroker != null && !this.MaxConnectionPerBroker.Equals(input.MaxConnectionPerBroker))) return false;
            if (this.StepLength != input.StepLength || (this.StepLength != null && !this.StepLength.Equals(input.StepLength))) return false;
            if (this.ProductAlias != input.ProductAlias || (this.ProductAlias != null && !this.ProductAlias.Equals(input.ProductAlias))) return false;
            if (this.MaxQueuePerBroker != input.MaxQueuePerBroker || (this.MaxQueuePerBroker != null && !this.MaxQueuePerBroker.Equals(input.MaxQueuePerBroker))) return false;

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
                if (this.MaxStoragePerNode != null) hashCode = hashCode * 59 + this.MaxStoragePerNode.GetHashCode();
                if (this.MinBroker != null) hashCode = hashCode * 59 + this.MinBroker.GetHashCode();
                if (this.MinStoragePerNode != null) hashCode = hashCode * 59 + this.MinStoragePerNode.GetHashCode();
                if (this.MaxConnectionPerBroker != null) hashCode = hashCode * 59 + this.MaxConnectionPerBroker.GetHashCode();
                if (this.StepLength != null) hashCode = hashCode * 59 + this.StepLength.GetHashCode();
                if (this.ProductAlias != null) hashCode = hashCode * 59 + this.ProductAlias.GetHashCode();
                if (this.MaxQueuePerBroker != null) hashCode = hashCode * 59 + this.MaxQueuePerBroker.GetHashCode();
                return hashCode;
            }
        }
    }
}
