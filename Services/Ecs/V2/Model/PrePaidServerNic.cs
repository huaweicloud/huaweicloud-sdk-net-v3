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
    /// 待创建云服务器的网卡信息。
    /// </summary>
    public class PrePaidServerNic 
    {

        /// <summary>
        /// 待创建云服务器所在的子网信息，需要指定vpcid对应VPC下的子网ID，UUID格式。  可以通过VPC服务 [查询子网](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;VPC&amp;api&#x3D;ListSubnets) 接口查询，该接口支持通过创建云服务器填写的vpcid进行过滤查询。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 网卡ID，UUID格式。 当该字段不为空时，表示挂载指定的网卡。port_id和subnet_id不能同时为空。 网卡ID可以从虚拟私有云的“查询端口列表”章节查询到。 约束： 网卡状态必须为DOWN。 网卡的vpcid必须和传入的vpcid一致。 当port_id和subnet_id同时存在的时候，优先使用port_id。当选择port_id不为空时，代表此时使用的是弹性网卡，此时security_groups和ip_address等参数不生效。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 待创建云服务器网卡的IP地址，IPv4格式。  约束：  - 不填或空字符串，默认在子网（subnet）中自动分配一个未使用的IP作网卡的IP地址。 - 若指定IP地址，该IP地址必须在子网（subnet）对应的网段内，且未被使用。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 是否支持ipv6。  取值为true时，标识此网卡支持ipv6。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipv6_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public PrePaidServerIpv6Bandwidth Ipv6Bandwidth { get; set; }

        /// <summary>
        /// IP/Mac对列表， 约束：IP地址不允许为 “0.0.0.0/0” 如果allowed_address_pairs配置地址池较大的CIDR（掩码小于24位），建议为该port配置一个单独的安全组 如果allowed_address_pairs为“1.1.1.1/0”，表示关闭源目地址检查开关 被绑定的云服务器网卡allowed_address_pairs填“1.1.1.1/0”
        /// </summary>
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateServerNicAllowedAddressPairs> AllowedAddressPairs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePaidServerNic {\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  ipv6Bandwidth: ").Append(Ipv6Bandwidth).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrePaidServerNic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrePaidServerNic input)
        {
            if (input == null) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.PortId != input.PortId || (this.PortId != null && !this.PortId.Equals(input.PortId))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.Ipv6Bandwidth != input.Ipv6Bandwidth || (this.Ipv6Bandwidth != null && !this.Ipv6Bandwidth.Equals(input.Ipv6Bandwidth))) return false;
            if (this.AllowedAddressPairs != input.AllowedAddressPairs || (this.AllowedAddressPairs != null && input.AllowedAddressPairs != null && !this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs))) return false;

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
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.PortId != null) hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.Ipv6Bandwidth != null) hashCode = hashCode * 59 + this.Ipv6Bandwidth.GetHashCode();
                if (this.AllowedAddressPairs != null) hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
