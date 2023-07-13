using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 创建floatingip对象
    /// </summary>
    public class CreateFloatingIpOption 
    {

        /// <summary>
        /// 浮动IP地址。
        /// </summary>
        [JsonProperty("floating_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpAddress { get; set; }

        /// <summary>
        /// 外部网络的id。只能使用固定的外网，外部网络的信息请通过GET /v2.0/networks?router:external&#x3D;True或GET /v2.0/networks?name&#x3D;{floating_network}或neutron net-external-list方式查询。
        /// </summary>
        [JsonProperty("floating_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingNetworkId { get; set; }

        /// <summary>
        /// 端口id
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 关联端口的私有IP地址。
        /// </summary>
        [JsonProperty("fixed_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedIpAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFloatingIpOption {\n");
            sb.Append("  floatingIpAddress: ").Append(FloatingIpAddress).Append("\n");
            sb.Append("  floatingNetworkId: ").Append(FloatingNetworkId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  fixedIpAddress: ").Append(FixedIpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFloatingIpOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFloatingIpOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FloatingIpAddress == input.FloatingIpAddress ||
                    (this.FloatingIpAddress != null &&
                    this.FloatingIpAddress.Equals(input.FloatingIpAddress))
                ) && 
                (
                    this.FloatingNetworkId == input.FloatingNetworkId ||
                    (this.FloatingNetworkId != null &&
                    this.FloatingNetworkId.Equals(input.FloatingNetworkId))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.FixedIpAddress == input.FixedIpAddress ||
                    (this.FixedIpAddress != null &&
                    this.FixedIpAddress.Equals(input.FixedIpAddress))
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
                if (this.FloatingIpAddress != null)
                    hashCode = hashCode * 59 + this.FloatingIpAddress.GetHashCode();
                if (this.FloatingNetworkId != null)
                    hashCode = hashCode * 59 + this.FloatingNetworkId.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.FixedIpAddress != null)
                    hashCode = hashCode * 59 + this.FixedIpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
