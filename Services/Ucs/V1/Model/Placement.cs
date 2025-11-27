using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Placement 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clusterAffinity", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterAffinity ClusterAffinity { get; set; }

        /// <summary>
        /// 集群容忍规则
        /// </summary>
        [JsonProperty("clusterTolerations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Toleration> ClusterTolerations { get; set; }

        /// <summary>
        /// 定义如何在成员集群间分配副本
        /// </summary>
        [JsonProperty("replicaScheduling", NullValueHandling = NullValueHandling.Ignore)]
        public Object ReplicaScheduling { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Placement {\n");
            sb.Append("  clusterAffinity: ").Append(ClusterAffinity).Append("\n");
            sb.Append("  clusterTolerations: ").Append(ClusterTolerations).Append("\n");
            sb.Append("  replicaScheduling: ").Append(ReplicaScheduling).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Placement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Placement input)
        {
            if (input == null) return false;
            if (this.ClusterAffinity != input.ClusterAffinity || (this.ClusterAffinity != null && !this.ClusterAffinity.Equals(input.ClusterAffinity))) return false;
            if (this.ClusterTolerations != input.ClusterTolerations || (this.ClusterTolerations != null && input.ClusterTolerations != null && !this.ClusterTolerations.SequenceEqual(input.ClusterTolerations))) return false;
            if (this.ReplicaScheduling != input.ReplicaScheduling || (this.ReplicaScheduling != null && !this.ReplicaScheduling.Equals(input.ReplicaScheduling))) return false;

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
                if (this.ClusterAffinity != null) hashCode = hashCode * 59 + this.ClusterAffinity.GetHashCode();
                if (this.ClusterTolerations != null) hashCode = hashCode * 59 + this.ClusterTolerations.GetHashCode();
                if (this.ReplicaScheduling != null) hashCode = hashCode * 59 + this.ReplicaScheduling.GetHashCode();
                return hashCode;
            }
        }
    }
}
