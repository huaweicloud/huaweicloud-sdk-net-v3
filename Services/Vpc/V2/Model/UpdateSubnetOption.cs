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
    public class UpdateSubnetOption 
    {

        /// <summary>
        /// 功能说明：子网名称 取值范围：1-64，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：子网描述 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：是否创建ipv6子网 取值范围：true（开启），false（关闭）
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// 功能说明：子网是否开启dhcp功能 取值范围：true（开启），false（关闭） 约束：不填时默认为true。当设置为false时，会导致新创建的ECS无法获取IP地址，cloudinit无法注入账号密码，请谨慎操作。
        /// </summary>
        [JsonProperty("dhcp_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DhcpEnable { get; set; }

        /// <summary>
        /// 功能说明：子网dns服务器地址1 约束：ip格式 默认值：不填时为空 [内网DNS地址请参见](https://support.huaweicloud.com/dns_faq/dns_faq_002.html) [通过API获取请参见](https://support.huaweicloud.com/api-dns/dns_api_69001.html)
        /// </summary>
        [JsonProperty("primary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryDns { get; set; }

        /// <summary>
        /// 功能说明：子网dns服务器地址2 约束：ip格式 默认值：不填时为空 [内网DNS地址请参见](https://support.huaweicloud.com/dns_faq/dns_faq_002.html) [通过API获取请参见](https://support.huaweicloud.com/api-dns/dns_api_69001.html)
        /// </summary>
        [JsonProperty("secondary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryDns { get; set; }

        /// <summary>
        /// 功能说明：子网dns服务器地址的集合；如果想使用两个以上dns服务器，请使用该字段。 约束：是子网dns服务器地址1跟子网dns服务器地址2的合集的父集 默认值：不填时为空，无法使用云内网DNS功能 [内网DNS地址请参见](https://support.huaweicloud.com/dns_faq/dns_faq_002.html) [通过API获取请参见](https://support.huaweicloud.com/api-dns/dns_api_69001.html)
        /// </summary>
        [JsonProperty("dnsList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsList { get; set; }

        /// <summary>
        /// 子网配置的NTP地址或租约时间
        /// </summary>
        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOption> ExtraDhcpOpts { get; set; }

        /// <summary>
        /// 功能说明：是否开启当前子网的IPv4地址使用量指标监控。 取值范围： true：开启 false：不开启
        /// </summary>
        [JsonProperty("enable_network_address_usage_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableNetworkAddressUsageMetrics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubnetOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  dhcpEnable: ").Append(DhcpEnable).Append("\n");
            sb.Append("  primaryDns: ").Append(PrimaryDns).Append("\n");
            sb.Append("  secondaryDns: ").Append(SecondaryDns).Append("\n");
            sb.Append("  dnsList: ").Append(DnsList).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("  enableNetworkAddressUsageMetrics: ").Append(EnableNetworkAddressUsageMetrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubnetOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubnetOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.DhcpEnable != input.DhcpEnable || (this.DhcpEnable != null && !this.DhcpEnable.Equals(input.DhcpEnable))) return false;
            if (this.PrimaryDns != input.PrimaryDns || (this.PrimaryDns != null && !this.PrimaryDns.Equals(input.PrimaryDns))) return false;
            if (this.SecondaryDns != input.SecondaryDns || (this.SecondaryDns != null && !this.SecondaryDns.Equals(input.SecondaryDns))) return false;
            if (this.DnsList != input.DnsList || (this.DnsList != null && input.DnsList != null && !this.DnsList.SequenceEqual(input.DnsList))) return false;
            if (this.ExtraDhcpOpts != input.ExtraDhcpOpts || (this.ExtraDhcpOpts != null && input.ExtraDhcpOpts != null && !this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts))) return false;
            if (this.EnableNetworkAddressUsageMetrics != input.EnableNetworkAddressUsageMetrics || (this.EnableNetworkAddressUsageMetrics != null && !this.EnableNetworkAddressUsageMetrics.Equals(input.EnableNetworkAddressUsageMetrics))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.DhcpEnable != null) hashCode = hashCode * 59 + this.DhcpEnable.GetHashCode();
                if (this.PrimaryDns != null) hashCode = hashCode * 59 + this.PrimaryDns.GetHashCode();
                if (this.SecondaryDns != null) hashCode = hashCode * 59 + this.SecondaryDns.GetHashCode();
                if (this.DnsList != null) hashCode = hashCode * 59 + this.DnsList.GetHashCode();
                if (this.ExtraDhcpOpts != null) hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                if (this.EnableNetworkAddressUsageMetrics != null) hashCode = hashCode * 59 + this.EnableNetworkAddressUsageMetrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
