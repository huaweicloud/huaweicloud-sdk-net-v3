using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LoadBalancerTopologyResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public TopologyNodes Nodes { get; set; }

        /// <summary>
        /// **参数解释**：拓扑边的信息
        /// </summary>
        [JsonProperty("edges", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyEdge> Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public TopologyLabels Labels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadBalancerTopologyResult {\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  edges: ").Append(Edges).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadBalancerTopologyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadBalancerTopologyResult input)
        {
            if (input == null) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && !this.Nodes.Equals(input.Nodes))) return false;
            if (this.Edges != input.Edges || (this.Edges != null && input.Edges != null && !this.Edges.SequenceEqual(input.Edges))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && !this.Labels.Equals(input.Labels))) return false;

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
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Edges != null) hashCode = hashCode * 59 + this.Edges.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                return hashCode;
            }
        }
    }
}
