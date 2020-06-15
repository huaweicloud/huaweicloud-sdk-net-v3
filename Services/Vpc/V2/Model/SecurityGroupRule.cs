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
    public class SecurityGroupRule 
    {

        /// <summary>
        /// 安全组规则ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：安全组规则描述 取值范围：0-255个字符，支持数字、字母、中文字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 功能说明：出入控制方向 取值范围： - egress：出方向 - ingress：入方向
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 功能说明：IP协议类型 取值范围：IPv4,IPv6
        /// </summary>
        [JsonProperty("ethertype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethertype { get; set; }

        /// <summary>
        /// 功能说明：协议类型 取值范围：tcp、udp、icmp或IP协议编号（0~255） 约束：为空表示支持所有协议
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 功能说明：起始端口值 取值范围：1~65535 约束：不能大于port_range_max的值，为空表示所有端口，如果协议是icmp类型，取值范围请参见 [安全组规则icmp协议名称对应关系表](https://support.huaweicloud.com/api-vpc/vpc_api_0009.html)
        /// </summary>
        [JsonProperty("port_range_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMin { get; set; }

        /// <summary>
        /// 功能说明：结束端口值 取值范围：1~65535 约束：取值不能小于port_range_min的值，为空表示所有端口，如果协议是icmp类型，取值范围请参见 [安全组规则icmp协议名称对应关系表](https://support.huaweicloud.com/api-vpc/vpc_api_0009.html)
        /// </summary>
        [JsonProperty("port_range_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMax { get; set; }

        /// <summary>
        /// 功能说明：远端IP地址，当direction是egress时为虚拟机访问端的地址，当direction是ingress时为访问虚拟机的地址 取值范围：IP地址，或者cidr格式 约束：和remote_group_id互斥
        /// </summary>
        [JsonProperty("remote_ip_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteIpPrefix { get; set; }

        /// <summary>
        /// 功能说明：对端安全组ID 约束：和remote_ip_prefix互斥
        /// </summary>
        [JsonProperty("remote_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteGroupId { get; set; }

        /// <summary>
        /// 安全组所属项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityGroupRule {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  ethertype: ").Append(Ethertype).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  portRangeMin: ").Append(PortRangeMin).Append("\n");
            sb.Append("  portRangeMax: ").Append(PortRangeMax).Append("\n");
            sb.Append("  remoteIpPrefix: ").Append(RemoteIpPrefix).Append("\n");
            sb.Append("  remoteGroupId: ").Append(RemoteGroupId).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecurityGroupRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecurityGroupRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Ethertype == input.Ethertype ||
                    (this.Ethertype != null &&
                    this.Ethertype.Equals(input.Ethertype))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.PortRangeMin == input.PortRangeMin ||
                    (this.PortRangeMin != null &&
                    this.PortRangeMin.Equals(input.PortRangeMin))
                ) && 
                (
                    this.PortRangeMax == input.PortRangeMax ||
                    (this.PortRangeMax != null &&
                    this.PortRangeMax.Equals(input.PortRangeMax))
                ) && 
                (
                    this.RemoteIpPrefix == input.RemoteIpPrefix ||
                    (this.RemoteIpPrefix != null &&
                    this.RemoteIpPrefix.Equals(input.RemoteIpPrefix))
                ) && 
                (
                    this.RemoteGroupId == input.RemoteGroupId ||
                    (this.RemoteGroupId != null &&
                    this.RemoteGroupId.Equals(input.RemoteGroupId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Ethertype != null)
                    hashCode = hashCode * 59 + this.Ethertype.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.PortRangeMin != null)
                    hashCode = hashCode * 59 + this.PortRangeMin.GetHashCode();
                if (this.PortRangeMax != null)
                    hashCode = hashCode * 59 + this.PortRangeMax.GetHashCode();
                if (this.RemoteIpPrefix != null)
                    hashCode = hashCode * 59 + this.RemoteIpPrefix.GetHashCode();
                if (this.RemoteGroupId != null)
                    hashCode = hashCode * 59 + this.RemoteGroupId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }
    }
}
