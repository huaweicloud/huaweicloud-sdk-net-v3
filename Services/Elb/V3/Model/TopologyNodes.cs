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
    public class TopologyNodes 
    {

        /// <summary>
        /// **取值范围**：拓扑LB节点信息。
        /// </summary>
        [JsonProperty("loadbalancers", NullValueHandling = NullValueHandling.Ignore)]
        public List<LoadBalancerNode> Loadbalancers { get; set; }

        /// <summary>
        /// **取值范围**：拓扑EIP节点信息。
        /// </summary>
        [JsonProperty("eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<EipNode> Eips { get; set; }

        /// <summary>
        /// **取值范围**：拓扑监听器节点信息。
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListenerNode> Listeners { get; set; }

        /// <summary>
        /// **取值范围**：拓扑后端服务器组节点信息。
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolNode> Pools { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopologyNodes {\n");
            sb.Append("  loadbalancers: ").Append(Loadbalancers).Append("\n");
            sb.Append("  eips: ").Append(Eips).Append("\n");
            sb.Append("  listeners: ").Append(Listeners).Append("\n");
            sb.Append("  pools: ").Append(Pools).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopologyNodes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopologyNodes input)
        {
            if (input == null) return false;
            if (this.Loadbalancers != input.Loadbalancers || (this.Loadbalancers != null && input.Loadbalancers != null && !this.Loadbalancers.SequenceEqual(input.Loadbalancers))) return false;
            if (this.Eips != input.Eips || (this.Eips != null && input.Eips != null && !this.Eips.SequenceEqual(input.Eips))) return false;
            if (this.Listeners != input.Listeners || (this.Listeners != null && input.Listeners != null && !this.Listeners.SequenceEqual(input.Listeners))) return false;
            if (this.Pools != input.Pools || (this.Pools != null && input.Pools != null && !this.Pools.SequenceEqual(input.Pools))) return false;

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
                if (this.Loadbalancers != null) hashCode = hashCode * 59 + this.Loadbalancers.GetHashCode();
                if (this.Eips != null) hashCode = hashCode * 59 + this.Eips.GetHashCode();
                if (this.Listeners != null) hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                if (this.Pools != null) hashCode = hashCode * 59 + this.Pools.GetHashCode();
                return hashCode;
            }
        }
    }
}
