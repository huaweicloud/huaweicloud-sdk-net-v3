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
    /// 集群基本信息。
    /// </summary>
    public class ShowClusterRespCluster 
    {

        /// <summary>
        /// 控制器ID。
        /// </summary>
        [JsonProperty("controller", NullValueHandling = NullValueHandling.Ignore)]
        public string Controller { get; set; }

        /// <summary>
        /// 节点列表。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowClusterRespClusterBrokers> Brokers { get; set; }

        /// <summary>
        /// 主题数量。
        /// </summary>
        [JsonProperty("topics_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopicsCount { get; set; }

        /// <summary>
        /// 分区数量。
        /// </summary>
        [JsonProperty("partitions_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PartitionsCount { get; set; }

        /// <summary>
        /// 在线分区数量。
        /// </summary>
        [JsonProperty("online_partitions_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlinePartitionsCount { get; set; }

        /// <summary>
        /// 副本数量。
        /// </summary>
        [JsonProperty("replicas_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicasCount { get; set; }

        /// <summary>
        /// ISR（In-Sync Replicas） 副本总数。
        /// </summary>
        [JsonProperty("isr_replicas_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsrReplicasCount { get; set; }

        /// <summary>
        /// 消费组数量。
        /// </summary>
        [JsonProperty("consumers_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConsumersCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterRespCluster {\n");
            sb.Append("  controller: ").Append(Controller).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("  topicsCount: ").Append(TopicsCount).Append("\n");
            sb.Append("  partitionsCount: ").Append(PartitionsCount).Append("\n");
            sb.Append("  onlinePartitionsCount: ").Append(OnlinePartitionsCount).Append("\n");
            sb.Append("  replicasCount: ").Append(ReplicasCount).Append("\n");
            sb.Append("  isrReplicasCount: ").Append(IsrReplicasCount).Append("\n");
            sb.Append("  consumersCount: ").Append(ConsumersCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterRespCluster);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterRespCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Controller == input.Controller ||
                    (this.Controller != null &&
                    this.Controller.Equals(input.Controller))
                ) && 
                (
                    this.Brokers == input.Brokers ||
                    this.Brokers != null &&
                    input.Brokers != null &&
                    this.Brokers.SequenceEqual(input.Brokers)
                ) && 
                (
                    this.TopicsCount == input.TopicsCount ||
                    (this.TopicsCount != null &&
                    this.TopicsCount.Equals(input.TopicsCount))
                ) && 
                (
                    this.PartitionsCount == input.PartitionsCount ||
                    (this.PartitionsCount != null &&
                    this.PartitionsCount.Equals(input.PartitionsCount))
                ) && 
                (
                    this.OnlinePartitionsCount == input.OnlinePartitionsCount ||
                    (this.OnlinePartitionsCount != null &&
                    this.OnlinePartitionsCount.Equals(input.OnlinePartitionsCount))
                ) && 
                (
                    this.ReplicasCount == input.ReplicasCount ||
                    (this.ReplicasCount != null &&
                    this.ReplicasCount.Equals(input.ReplicasCount))
                ) && 
                (
                    this.IsrReplicasCount == input.IsrReplicasCount ||
                    (this.IsrReplicasCount != null &&
                    this.IsrReplicasCount.Equals(input.IsrReplicasCount))
                ) && 
                (
                    this.ConsumersCount == input.ConsumersCount ||
                    (this.ConsumersCount != null &&
                    this.ConsumersCount.Equals(input.ConsumersCount))
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
                if (this.Controller != null)
                    hashCode = hashCode * 59 + this.Controller.GetHashCode();
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                if (this.TopicsCount != null)
                    hashCode = hashCode * 59 + this.TopicsCount.GetHashCode();
                if (this.PartitionsCount != null)
                    hashCode = hashCode * 59 + this.PartitionsCount.GetHashCode();
                if (this.OnlinePartitionsCount != null)
                    hashCode = hashCode * 59 + this.OnlinePartitionsCount.GetHashCode();
                if (this.ReplicasCount != null)
                    hashCode = hashCode * 59 + this.ReplicasCount.GetHashCode();
                if (this.IsrReplicasCount != null)
                    hashCode = hashCode * 59 + this.IsrReplicasCount.GetHashCode();
                if (this.ConsumersCount != null)
                    hashCode = hashCode * 59 + this.ConsumersCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
