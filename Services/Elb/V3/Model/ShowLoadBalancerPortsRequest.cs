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
    /// Request Object
    /// </summary>
    public class ShowLoadBalancerPortsRequest 
    {

        /// <summary>
        /// 负载均衡器ID。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsPath = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// port id。  支持多值查询，查询条件格式：*port_id&#x3D;xxx&amp;port_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("port_id", IsQuery = true)]
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PortId { get; set; }

        /// <summary>
        /// ipv4 地址。  支持多值查询，查询条件格式：*ip_address&#x3D;xxx&amp;ip_address&#x3D;xxx*。
        /// </summary>
        [SDKProperty("ip_address", IsQuery = true)]
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddress { get; set; }

        /// <summary>
        /// ipv6 地址。  支持多值查询，查询条件格式：*ipv6_address&#x3D;xxx&amp;ipv6_address&#x3D;xxx*。
        /// </summary>
        [SDKProperty("ipv6_address", IsQuery = true)]
        [JsonProperty("ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// port类型。  支持多值查询，查询条件格式：*type&#x3D;xxx&amp;type&#x3D;xxx*。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 虚拟网络id。  支持多值查询，查询条件格式：*virsubnet_id&#x3D;xxx&amp;virsubnet_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("virsubnet_id", IsQuery = true)]
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VirsubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLoadBalancerPortsRequest {\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLoadBalancerPortsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLoadBalancerPortsRequest input)
        {
            if (input == null) return false;
            if (this.LoadbalancerId != input.LoadbalancerId || (this.LoadbalancerId != null && !this.LoadbalancerId.Equals(input.LoadbalancerId))) return false;
            if (this.PortId != input.PortId || (this.PortId != null && input.PortId != null && !this.PortId.SequenceEqual(input.PortId))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && input.IpAddress != null && !this.IpAddress.SequenceEqual(input.IpAddress))) return false;
            if (this.Ipv6Address != input.Ipv6Address || (this.Ipv6Address != null && input.Ipv6Address != null && !this.Ipv6Address.SequenceEqual(input.Ipv6Address))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && input.VirsubnetId != null && !this.VirsubnetId.SequenceEqual(input.VirsubnetId))) return false;

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
                if (this.LoadbalancerId != null) hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.PortId != null) hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Ipv6Address != null) hashCode = hashCode * 59 + this.Ipv6Address.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
