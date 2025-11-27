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
    public class ResourceBindingSpec 
    {

        /// <summary>
        /// 要传播的Kubernetes资源引用
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public Object Resource { get; set; }

        /// <summary>
        /// 是否自动传播相关资源
        /// </summary>
        [JsonProperty("propagateDeps", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PropagateDeps { get; set; }

        /// <summary>
        /// 定义每个副本的需求
        /// </summary>
        [JsonProperty("replicaRequirements", NullValueHandling = NullValueHandling.Ignore)]
        public Object ReplicaRequirements { get; set; }

        /// <summary>
        /// 要创建的副本数量
        /// </summary>
        [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("placement", NullValueHandling = NullValueHandling.Ignore)]
        public Placement Placement { get; set; }

        /// <summary>
        /// 目标成员集群列表
        /// </summary>
        [JsonProperty("clusters", NullValueHandling = NullValueHandling.Ignore)]
        public List<TargetCluster> Clusters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceBindingSpec {\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  propagateDeps: ").Append(PropagateDeps).Append("\n");
            sb.Append("  replicaRequirements: ").Append(ReplicaRequirements).Append("\n");
            sb.Append("  replicas: ").Append(Replicas).Append("\n");
            sb.Append("  placement: ").Append(Placement).Append("\n");
            sb.Append("  clusters: ").Append(Clusters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceBindingSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceBindingSpec input)
        {
            if (input == null) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.PropagateDeps != input.PropagateDeps || (this.PropagateDeps != null && !this.PropagateDeps.Equals(input.PropagateDeps))) return false;
            if (this.ReplicaRequirements != input.ReplicaRequirements || (this.ReplicaRequirements != null && !this.ReplicaRequirements.Equals(input.ReplicaRequirements))) return false;
            if (this.Replicas != input.Replicas || (this.Replicas != null && !this.Replicas.Equals(input.Replicas))) return false;
            if (this.Placement != input.Placement || (this.Placement != null && !this.Placement.Equals(input.Placement))) return false;
            if (this.Clusters != input.Clusters || (this.Clusters != null && input.Clusters != null && !this.Clusters.SequenceEqual(input.Clusters))) return false;

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
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.PropagateDeps != null) hashCode = hashCode * 59 + this.PropagateDeps.GetHashCode();
                if (this.ReplicaRequirements != null) hashCode = hashCode * 59 + this.ReplicaRequirements.GetHashCode();
                if (this.Replicas != null) hashCode = hashCode * 59 + this.Replicas.GetHashCode();
                if (this.Placement != null) hashCode = hashCode * 59 + this.Placement.GetHashCode();
                if (this.Clusters != null) hashCode = hashCode * 59 + this.Clusters.GetHashCode();
                return hashCode;
            }
        }
    }
}
