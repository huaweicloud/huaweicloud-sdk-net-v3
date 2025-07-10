using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NetworkInterfaces 
    {

        /// <summary>
        /// 网卡端口id
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 是否是主网卡
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        /// <summary>
        /// ipv4地址
        /// </summary>
        [JsonProperty("ip_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// ipv6地址
        /// </summary>
        [JsonProperty("ipv6_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6Addresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("association", NullValueHandling = NullValueHandling.Ignore)]
        public Association Association { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkInterfaces {\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  primary: ").Append(Primary).Append("\n");
            sb.Append("  ipAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  ipv6Addresses: ").Append(Ipv6Addresses).Append("\n");
            sb.Append("  association: ").Append(Association).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkInterfaces);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkInterfaces input)
        {
            if (input == null) return false;
            if (this.PortId != input.PortId || (this.PortId != null && !this.PortId.Equals(input.PortId))) return false;
            if (this.Primary != input.Primary || (this.Primary != null && !this.Primary.Equals(input.Primary))) return false;
            if (this.IpAddresses != input.IpAddresses || (this.IpAddresses != null && input.IpAddresses != null && !this.IpAddresses.SequenceEqual(input.IpAddresses))) return false;
            if (this.Ipv6Addresses != input.Ipv6Addresses || (this.Ipv6Addresses != null && input.Ipv6Addresses != null && !this.Ipv6Addresses.SequenceEqual(input.Ipv6Addresses))) return false;
            if (this.Association != input.Association || (this.Association != null && !this.Association.Equals(input.Association))) return false;

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
                if (this.PortId != null) hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.Primary != null) hashCode = hashCode * 59 + this.Primary.GetHashCode();
                if (this.IpAddresses != null) hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.Ipv6Addresses != null) hashCode = hashCode * 59 + this.Ipv6Addresses.GetHashCode();
                if (this.Association != null) hashCode = hashCode * 59 + this.Association.GetHashCode();
                return hashCode;
            }
        }
    }
}
