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
    public class TopicAssignment 
    {

        /// <summary>
        /// 手动指定分配方案时的分区号。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 手动指定某个分区将要分配的broker列表
        /// </summary>
        [JsonProperty("partition_brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PartitionBrokers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicAssignment {\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  partitionBrokers: ").Append(PartitionBrokers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopicAssignment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopicAssignment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))
                ) && 
                (
                    this.PartitionBrokers == input.PartitionBrokers ||
                    this.PartitionBrokers != null &&
                    input.PartitionBrokers != null &&
                    this.PartitionBrokers.SequenceEqual(input.PartitionBrokers)
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
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.PartitionBrokers != null)
                    hashCode = hashCode * 59 + this.PartitionBrokers.GetHashCode();
                return hashCode;
            }
        }
    }
}
