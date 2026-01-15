using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SingleSubnetInfo 
    {

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否未被workspace真正使用。如果未使用，则表示可以从workspace中删除。
        /// </summary>
        [JsonProperty("unused", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unused { get; set; }

        /// <summary>
        /// 是否已被workspace选择使用。
        /// </summary>
        [JsonProperty("checked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checked { get; set; }

        /// <summary>
        /// VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 子网网段。
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 子网网关。
        /// </summary>
        [JsonProperty("gateway_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIp { get; set; }

        /// <summary>
        /// 是否支持DHCP。
        /// </summary>
        [JsonProperty("dhcp_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DhcpEnable { get; set; }

        /// <summary>
        /// 是否支持IPV6。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// 主DNS。
        /// </summary>
        [JsonProperty("primary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryDns { get; set; }

        /// <summary>
        /// 备DNS。
        /// </summary>
        [JsonProperty("secondary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryDns { get; set; }

        /// <summary>
        /// 子网状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 网络id。
        /// </summary>
        [JsonProperty("neutron_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NeutronSubnetId { get; set; }

        /// <summary>
        /// ipv6网络id。
        /// </summary>
        [JsonProperty("neutron_ipv6_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NeutronIpv6SubnetId { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleSubnetInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  unused: ").Append(Unused).Append("\n");
            sb.Append("  Checked: ").Append(Checked).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  gatewayIp: ").Append(GatewayIp).Append("\n");
            sb.Append("  dhcpEnable: ").Append(DhcpEnable).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  primaryDns: ").Append(PrimaryDns).Append("\n");
            sb.Append("  secondaryDns: ").Append(SecondaryDns).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  neutronSubnetId: ").Append(NeutronSubnetId).Append("\n");
            sb.Append("  neutronIpv6SubnetId: ").Append(NeutronIpv6SubnetId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SingleSubnetInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SingleSubnetInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Unused != input.Unused || (this.Unused != null && !this.Unused.Equals(input.Unused))) return false;
            if (this.Checked != input.Checked || (this.Checked != null && !this.Checked.Equals(input.Checked))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.GatewayIp != input.GatewayIp || (this.GatewayIp != null && !this.GatewayIp.Equals(input.GatewayIp))) return false;
            if (this.DhcpEnable != input.DhcpEnable || (this.DhcpEnable != null && !this.DhcpEnable.Equals(input.DhcpEnable))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.PrimaryDns != input.PrimaryDns || (this.PrimaryDns != null && !this.PrimaryDns.Equals(input.PrimaryDns))) return false;
            if (this.SecondaryDns != input.SecondaryDns || (this.SecondaryDns != null && !this.SecondaryDns.Equals(input.SecondaryDns))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.NeutronSubnetId != input.NeutronSubnetId || (this.NeutronSubnetId != null && !this.NeutronSubnetId.Equals(input.NeutronSubnetId))) return false;
            if (this.NeutronIpv6SubnetId != input.NeutronIpv6SubnetId || (this.NeutronIpv6SubnetId != null && !this.NeutronIpv6SubnetId.Equals(input.NeutronIpv6SubnetId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Unused != null) hashCode = hashCode * 59 + this.Unused.GetHashCode();
                if (this.Checked != null) hashCode = hashCode * 59 + this.Checked.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.GatewayIp != null) hashCode = hashCode * 59 + this.GatewayIp.GetHashCode();
                if (this.DhcpEnable != null) hashCode = hashCode * 59 + this.DhcpEnable.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.PrimaryDns != null) hashCode = hashCode * 59 + this.PrimaryDns.GetHashCode();
                if (this.SecondaryDns != null) hashCode = hashCode * 59 + this.SecondaryDns.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.NeutronSubnetId != null) hashCode = hashCode * 59 + this.NeutronSubnetId.GetHashCode();
                if (this.NeutronIpv6SubnetId != null) hashCode = hashCode * 59 + this.NeutronIpv6SubnetId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
