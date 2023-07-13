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
    public class NeutronUpdateSubnetOption 
    {

        /// <summary>
        /// 功能说明：dns服务器 取值范围：IP地址格式例如：\&quot;dns_nameservers\&quot;: [\&quot;8.xx.xx.8\&quot;,\&quot;8.xx.xx.4\&quot;]，最多5个 默认值：不填时为空，无法使用云内网DNS功能 [内网DNS地址请参见](https://support.huaweicloud.com/dns_faq/dns_faq_002.html) [通过API获取请参见](https://support.huaweicloud.com/api-dns/dns_api_69001.html)
        /// </summary>
        [JsonProperty("dns_nameservers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsNameservers { get; set; }

        /// <summary>
        /// 功能说明：是否启动dhcp，false表示不提供dhcp服务的能力 约束：只支持true
        /// </summary>
        [JsonProperty("enable_dhcp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDhcp { get; set; }

        /// <summary>
        /// 功能说明：虚拟机静态路由，参见“host_route对象”表 约束：不支持，忽略输入信息
        /// </summary>
        [JsonProperty("host_routes", NullValueHandling = NullValueHandling.Ignore)]
        public List<HostRoute> HostRoutes { get; set; }

        /// <summary>
        /// 子网的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：可用的IP池，allocation_pool对象参见表 allocation_pool对象 例如：[ { \&quot;start\&quot;: \&quot;10.0.0.2\&quot;, \&quot;end\&quot;: \&quot;10.0.0.251\&quot;} ]每个子网的第1个和最后3个IP地址为系统保留地址。以192.168.1.0/24为例，192.168.1.0、 192.168.1.253、192.168.1.254和192.168.1.255这些地址是系统保留地址。系统预留地址默认不在allocation_pool范围内。 约束：更新时allocation_pool范围不能包含网关和广播地址的所有IP。
        /// </summary>
        [JsonProperty("allocation_pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllocationPool> AllocationPools { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateSubnetOption {\n");
            sb.Append("  dnsNameservers: ").Append(DnsNameservers).Append("\n");
            sb.Append("  enableDhcp: ").Append(EnableDhcp).Append("\n");
            sb.Append("  hostRoutes: ").Append(HostRoutes).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  allocationPools: ").Append(AllocationPools).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateSubnetOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateSubnetOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnsNameservers == input.DnsNameservers ||
                    this.DnsNameservers != null &&
                    input.DnsNameservers != null &&
                    this.DnsNameservers.SequenceEqual(input.DnsNameservers)
                ) && 
                (
                    this.EnableDhcp == input.EnableDhcp ||
                    (this.EnableDhcp != null &&
                    this.EnableDhcp.Equals(input.EnableDhcp))
                ) && 
                (
                    this.HostRoutes == input.HostRoutes ||
                    this.HostRoutes != null &&
                    input.HostRoutes != null &&
                    this.HostRoutes.SequenceEqual(input.HostRoutes)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AllocationPools == input.AllocationPools ||
                    this.AllocationPools != null &&
                    input.AllocationPools != null &&
                    this.AllocationPools.SequenceEqual(input.AllocationPools)
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
                if (this.DnsNameservers != null)
                    hashCode = hashCode * 59 + this.DnsNameservers.GetHashCode();
                if (this.EnableDhcp != null)
                    hashCode = hashCode * 59 + this.EnableDhcp.GetHashCode();
                if (this.HostRoutes != null)
                    hashCode = hashCode * 59 + this.HostRoutes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AllocationPools != null)
                    hashCode = hashCode * 59 + this.AllocationPools.GetHashCode();
                return hashCode;
            }
        }
    }
}
