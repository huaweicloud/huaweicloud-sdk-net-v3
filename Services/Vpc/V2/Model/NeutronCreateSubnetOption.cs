using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NeutronCreateSubnetOption 
    {

        /// <summary>
        /// 功能说明：子网的名称 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：子网网段 取值范围：必须是cidr格式，只支持10.0.0.0/8,172.16.0.0/12,192.168.0.0/16三个网段内的地址，掩码长度不能大于28
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 功能说明：子网所属网络ID
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// 功能说明：子网网关 取值范围：子网网段中的IP地址 约束：必须是ip格式
        /// </summary>
        [JsonProperty("gateway_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIp { get; set; }

        /// <summary>
        /// 功能说明：IP版本信息 取值范围：4或者6(特定局点)
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 功能说明：可用的IP池，allocation_pool对象参见allocation_pool对象 例如：[ { \&quot;start\&quot;: \&quot;10.0.0.2\&quot;, \&quot;end\&quot;: \&quot;10.0.0.251\&quot;} ]每个子网的第1个和最后4个IP地址为系统保留地址。以192.168.1.0/24为例，192.168.1.0、 192.168.1.252、192.168.1.253、192.168.1.254和192.168.1.255这些地址是系统保留地址。系统预留地址默认不在allocation_pool范围内。 约束：更新时allocation_pool范围不能包含网关和广播地址的所有IP。
        /// </summary>
        [JsonProperty("allocation_pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllocationPool> AllocationPools { get; set; }

        /// <summary>
        /// 功能说明：子网关联的DNS名称服务器列表 取值范围：IP地址格式例如：\&quot;dns_nameservers\&quot;: [\&quot;8.xx.xx.8\&quot;,\&quot;8.xx.xx.4\&quot;] 默认值：不填时为空，无法使用云内网DNS功能 [内网DNS地址请参见](https://support.huaweicloud.com/dns_faq/dns_faq_002.html) [通过API获取请参见](https://support.huaweicloud.com/api-dns/dns_api_69001.html)
        /// </summary>
        [JsonProperty("dns_nameservers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsNameservers { get; set; }

        /// <summary>
        /// 功能说明：虚拟机静态路由，参见“host_route对象”表 约束：不支持设置
        /// </summary>
        [JsonProperty("host_routes", NullValueHandling = NullValueHandling.Ignore)]
        public List<HostRoute> HostRoutes { get; set; }

        /// <summary>
        /// 功能说明：是否启动dhcp，false表示不提供dhcp服务的能力 约束：只支持true
        /// </summary>
        [JsonProperty("enable_dhcp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDhcp { get; set; }

        /// <summary>
        /// 功能说明：IPv6寻址模式 取值范围：dhcpv6-stateful
        /// </summary>
        [JsonProperty("ipv6_address_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6AddressMode { get; set; }

        /// <summary>
        /// 功能说明：IPv6路由广播模式 取值范围：dhcpv6-stateful
        /// </summary>
        [JsonProperty("ipv6_ra_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6RaMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateSubnetOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  gatewayIp: ").Append(GatewayIp).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  allocationPools: ").Append(AllocationPools).Append("\n");
            sb.Append("  dnsNameservers: ").Append(DnsNameservers).Append("\n");
            sb.Append("  hostRoutes: ").Append(HostRoutes).Append("\n");
            sb.Append("  enableDhcp: ").Append(EnableDhcp).Append("\n");
            sb.Append("  ipv6AddressMode: ").Append(Ipv6AddressMode).Append("\n");
            sb.Append("  ipv6RaMode: ").Append(Ipv6RaMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateSubnetOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateSubnetOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.NetworkId != input.NetworkId || (this.NetworkId != null && !this.NetworkId.Equals(input.NetworkId))) return false;
            if (this.GatewayIp != input.GatewayIp || (this.GatewayIp != null && !this.GatewayIp.Equals(input.GatewayIp))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
            if (this.AllocationPools != input.AllocationPools || (this.AllocationPools != null && input.AllocationPools != null && !this.AllocationPools.SequenceEqual(input.AllocationPools))) return false;
            if (this.DnsNameservers != input.DnsNameservers || (this.DnsNameservers != null && input.DnsNameservers != null && !this.DnsNameservers.SequenceEqual(input.DnsNameservers))) return false;
            if (this.HostRoutes != input.HostRoutes || (this.HostRoutes != null && input.HostRoutes != null && !this.HostRoutes.SequenceEqual(input.HostRoutes))) return false;
            if (this.EnableDhcp != input.EnableDhcp || (this.EnableDhcp != null && !this.EnableDhcp.Equals(input.EnableDhcp))) return false;
            if (this.Ipv6AddressMode != input.Ipv6AddressMode || (this.Ipv6AddressMode != null && !this.Ipv6AddressMode.Equals(input.Ipv6AddressMode))) return false;
            if (this.Ipv6RaMode != input.Ipv6RaMode || (this.Ipv6RaMode != null && !this.Ipv6RaMode.Equals(input.Ipv6RaMode))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.NetworkId != null) hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.GatewayIp != null) hashCode = hashCode * 59 + this.GatewayIp.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.AllocationPools != null) hashCode = hashCode * 59 + this.AllocationPools.GetHashCode();
                if (this.DnsNameservers != null) hashCode = hashCode * 59 + this.DnsNameservers.GetHashCode();
                if (this.HostRoutes != null) hashCode = hashCode * 59 + this.HostRoutes.GetHashCode();
                if (this.EnableDhcp != null) hashCode = hashCode * 59 + this.EnableDhcp.GetHashCode();
                if (this.Ipv6AddressMode != null) hashCode = hashCode * 59 + this.Ipv6AddressMode.GetHashCode();
                if (this.Ipv6RaMode != null) hashCode = hashCode * 59 + this.Ipv6RaMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
