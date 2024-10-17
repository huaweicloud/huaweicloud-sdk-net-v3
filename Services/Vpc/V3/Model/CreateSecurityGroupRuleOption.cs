using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSecurityGroupRuleOption 
    {

        /// <summary>
        /// 功能说明：安全组规则所属的安全组ID
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 功能说明：安全组的描述信息 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：安全组规则的出入控制方向 取值范围：ingress 表示入方向；egress 表示出方向
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 功能说明：IP地址协议类型 取值范围：IPv4，IPv6 约束：不填默认值为IPv4
        /// </summary>
        [JsonProperty("ethertype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethertype { get; set; }

        /// <summary>
        /// 功能说明：协议类型 取值范围：icmp、tcp、udp、icmpv6或IP协议号(0~255) 约束：为空表示支持所有协议。协议为icmpv6时，网络类型应该为IPv6；协议为icmp时，网络类型应该为IPv4
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 功能说明：端口取值范围 取值范围：支持单端口(80)，连续端口(1-30)以及不连续端口(22,3389,80) 约束：端口值的范围1~65535
        /// </summary>
        [JsonProperty("multiport", NullValueHandling = NullValueHandling.Ignore)]
        public string Multiport { get; set; }

        /// <summary>
        /// 功能说明：远端IP地址，当direction是egress时为虚拟机访问端的地址，当direction是ingress时为访问虚拟机的地址 取值范围：IP地址，或者cidr格式 约束：与remote_group_id、remote_address_group_id互斥
        /// </summary>
        [JsonProperty("remote_ip_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteIpPrefix { get; set; }

        /// <summary>
        /// 功能说明：远端安全组ID，表示该安全组内的流量允许或拒绝 取值范围：租户下存在的安全组ID 约束：与remote_ip_prefix，remote_address_group_id功能互斥
        /// </summary>
        [JsonProperty("remote_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteGroupId { get; set; }

        /// <summary>
        /// 功能说明：远端地址组ID 取值范围：租户下存在的地址组ID 约束：与remote_ip_prefix，remote_group_id功能互斥
        /// </summary>
        [JsonProperty("remote_address_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteAddressGroupId { get; set; }

        /// <summary>
        /// 功能说明：安全组规则生效策略 取值范围：allow 允许，deny 拒绝 约束：默认值为allow 
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 功能说明：规则在安全组中的优先级 取值范围：1~100，1代表最高优先级 约束：默认值为100
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecurityGroupRuleOption {\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  ethertype: ").Append(Ethertype).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  multiport: ").Append(Multiport).Append("\n");
            sb.Append("  remoteIpPrefix: ").Append(RemoteIpPrefix).Append("\n");
            sb.Append("  remoteGroupId: ").Append(RemoteGroupId).Append("\n");
            sb.Append("  remoteAddressGroupId: ").Append(RemoteAddressGroupId).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecurityGroupRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecurityGroupRuleOption input)
        {
            if (input == null) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Ethertype != input.Ethertype || (this.Ethertype != null && !this.Ethertype.Equals(input.Ethertype))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Multiport != input.Multiport || (this.Multiport != null && !this.Multiport.Equals(input.Multiport))) return false;
            if (this.RemoteIpPrefix != input.RemoteIpPrefix || (this.RemoteIpPrefix != null && !this.RemoteIpPrefix.Equals(input.RemoteIpPrefix))) return false;
            if (this.RemoteGroupId != input.RemoteGroupId || (this.RemoteGroupId != null && !this.RemoteGroupId.Equals(input.RemoteGroupId))) return false;
            if (this.RemoteAddressGroupId != input.RemoteAddressGroupId || (this.RemoteAddressGroupId != null && !this.RemoteAddressGroupId.Equals(input.RemoteAddressGroupId))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;

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
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Ethertype != null) hashCode = hashCode * 59 + this.Ethertype.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Multiport != null) hashCode = hashCode * 59 + this.Multiport.GetHashCode();
                if (this.RemoteIpPrefix != null) hashCode = hashCode * 59 + this.RemoteIpPrefix.GetHashCode();
                if (this.RemoteGroupId != null) hashCode = hashCode * 59 + this.RemoteGroupId.GetHashCode();
                if (this.RemoteAddressGroupId != null) hashCode = hashCode * 59 + this.RemoteAddressGroupId.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
