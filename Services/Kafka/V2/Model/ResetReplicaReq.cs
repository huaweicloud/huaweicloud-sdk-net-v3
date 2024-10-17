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
    /// 期望调整的分区副本分配情况。
    /// </summary>
    public class ResetReplicaReq 
    {

        /// <summary>
        /// 期望调整的分区副本分配情况。
        /// </summary>
        [JsonProperty("partitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResetReplicaReqPartitions> Partitions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetReplicaReq {\n");
            sb.Append("  partitions: ").Append(Partitions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetReplicaReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetReplicaReq input)
        {
            if (input == null) return false;
            if (this.Partitions != input.Partitions || (this.Partitions != null && input.Partitions != null && !this.Partitions.SequenceEqual(input.Partitions))) return false;

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
                if (this.Partitions != null) hashCode = hashCode * 59 + this.Partitions.GetHashCode();
                return hashCode;
            }
        }
    }
}
