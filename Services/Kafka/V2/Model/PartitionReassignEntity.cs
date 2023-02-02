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
    /// 
    /// </summary>
    public class PartitionReassignEntity 
    {

        /// <summary>
        /// topic名称
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 分区重平衡到的broker列表，自动生成分配方案时需指定该参数。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Brokers { get; set; }

        /// <summary>
        /// 副本因子，自动生成分配方案时可指定。
        /// </summary>
        [JsonProperty("replication_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// 手动指定的分配方案。brokers 参数与该参数不能同时为空。
        /// </summary>
        [JsonProperty("assignment", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopicAssignment> Assignment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartitionReassignEntity {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("  replicationFactor: ").Append(ReplicationFactor).Append("\n");
            sb.Append("  assignment: ").Append(Assignment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartitionReassignEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PartitionReassignEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Brokers == input.Brokers ||
                    this.Brokers != null &&
                    input.Brokers != null &&
                    this.Brokers.SequenceEqual(input.Brokers)
                ) && 
                (
                    this.ReplicationFactor == input.ReplicationFactor ||
                    (this.ReplicationFactor != null &&
                    this.ReplicationFactor.Equals(input.ReplicationFactor))
                ) && 
                (
                    this.Assignment == input.Assignment ||
                    this.Assignment != null &&
                    input.Assignment != null &&
                    this.Assignment.SequenceEqual(input.Assignment)
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
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                if (this.ReplicationFactor != null)
                    hashCode = hashCode * 59 + this.ReplicationFactor.GetHashCode();
                if (this.Assignment != null)
                    hashCode = hashCode * 59 + this.Assignment.GetHashCode();
                return hashCode;
            }
        }
    }
}
