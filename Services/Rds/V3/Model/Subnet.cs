using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 子网信息
    /// </summary>
    public class Subnet 
    {

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 子网名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否是IPV6子网
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// 子网的CIDR信息
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// IPV6子网的CIDR信息
        /// </summary>
        [JsonProperty("cidr_v6", NullValueHandling = NullValueHandling.Ignore)]
        public string CidrV6 { get; set; }

        /// <summary>
        /// 子网的网关
        /// </summary>
        [JsonProperty("gateway_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIp { get; set; }

        /// <summary>
        /// IPV6子网的网关
        /// </summary>
        [JsonProperty("gateway_ip_v6", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIpV6 { get; set; }

        /// <summary>
        /// 子网的可用区
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subnet {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  cidrV6: ").Append(CidrV6).Append("\n");
            sb.Append("  gatewayIp: ").Append(GatewayIp).Append("\n");
            sb.Append("  gatewayIpV6: ").Append(GatewayIpV6).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Subnet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Subnet input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.CidrV6 != input.CidrV6 || (this.CidrV6 != null && !this.CidrV6.Equals(input.CidrV6))) return false;
            if (this.GatewayIp != input.GatewayIp || (this.GatewayIp != null && !this.GatewayIp.Equals(input.GatewayIp))) return false;
            if (this.GatewayIpV6 != input.GatewayIpV6 || (this.GatewayIpV6 != null && !this.GatewayIpV6.Equals(input.GatewayIpV6))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.CidrV6 != null) hashCode = hashCode * 59 + this.CidrV6.GetHashCode();
                if (this.GatewayIp != null) hashCode = hashCode * 59 + this.GatewayIp.GetHashCode();
                if (this.GatewayIpV6 != null) hashCode = hashCode * 59 + this.GatewayIpV6.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
