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
    public class ResetReplicaReqPartitions 
    {

        /// <summary>
        /// 分区ID。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 副本期望所在的broker ID。其中Array首位为leader副本，所有分区需要有同样数量的副本，副本数不能大于总broker的数量。
        /// </summary>
        [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Replicas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetReplicaReqPartitions {\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  replicas: ").Append(Replicas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetReplicaReqPartitions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetReplicaReqPartitions input)
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
                    this.Replicas == input.Replicas ||
                    this.Replicas != null &&
                    input.Replicas != null &&
                    this.Replicas.SequenceEqual(input.Replicas)
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
                if (this.Replicas != null)
                    hashCode = hashCode * 59 + this.Replicas.GetHashCode();
                return hashCode;
            }
        }
    }
}
