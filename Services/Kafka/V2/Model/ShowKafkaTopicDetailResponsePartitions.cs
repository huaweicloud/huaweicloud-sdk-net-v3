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
    public class ShowKafkaTopicDetailResponsePartitions 
    {

        /// <summary>
        /// **参数解释**： 分区编号。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// **参数解释**： leader副本所在节点的ID。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("leader", NullValueHandling = NullValueHandling.Ignore)]
        public int? Leader { get; set; }

        /// <summary>
        /// **参数解释**： 副本列表。
        /// </summary>
        [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Replicas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKafkaTopicDetailResponsePartitions {\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  leader: ").Append(Leader).Append("\n");
            sb.Append("  replicas: ").Append(Replicas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKafkaTopicDetailResponsePartitions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaTopicDetailResponsePartitions input)
        {
            if (input == null) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;
            if (this.Leader != input.Leader || (this.Leader != null && !this.Leader.Equals(input.Leader))) return false;
            if (this.Replicas != input.Replicas || (this.Replicas != null && input.Replicas != null && !this.Replicas.SequenceEqual(input.Replicas))) return false;

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
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.Leader != null) hashCode = hashCode * 59 + this.Leader.GetHashCode();
                if (this.Replicas != null) hashCode = hashCode * 59 + this.Replicas.GetHashCode();
                return hashCode;
            }
        }
    }
}
