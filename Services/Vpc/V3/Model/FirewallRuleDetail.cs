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
    public class FirewallRuleDetail 
    {

        /// <summary>
        /// 功能说明：ACL规则唯一标识 取值范围：合法UUID的字符串
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：ACL规则名称 取值范围：0-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：ACL规则描述信息 取值范围：0-255个字符 约束：不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：ACL规则对流量执行的操作放通或拒绝 取值范围：allow放通；deny拒绝
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 功能说明：资源所属项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 功能说明：ACL规则协议 取值范围：支持TCP,UDP,ICMP, ICMPV6或者IP协议号（0-255）
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 功能说明：ACL规则的ip版本 取值范围：4, 表示ipv4；6, 表示ipv6
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 功能说明：ACL规则源IP地址或者CIDR 约束：source_ip_address和source_address_group_id不能同时设置
        /// </summary>
        [JsonProperty("source_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// 功能说明：ACL规则目的IP地址或者CIDR 约束：destination_ip_address和destination_address_group_id不能同时设置
        /// </summary>
        [JsonProperty("destination_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationIpAddress { get; set; }

        /// <summary>
        /// 功能说明：ACL规则的源端口 取值范围：支持端口号，一段端口范围，多个以逗号分隔 约束：支持的端口组的数量默认为20
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePort { get; set; }

        /// <summary>
        /// 功能说明：ACL规则的目的端口 取值范围：支持端口号，一段端口范围，多个以逗号分隔 约束：支持的端口组的数量默认为20
        /// </summary>
        [JsonProperty("destination_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationPort { get; set; }

        /// <summary>
        /// 功能说明：ACL规则的源地址组ID 约束：source_ip_address和source_address_group_id不能同时设置
        /// </summary>
        [JsonProperty("source_address_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAddressGroupId { get; set; }

        /// <summary>
        /// 功能说明：ACL规则的目的地址组ID 约束：destination_ip_address和destination_address_group_id不能同时设置
        /// </summary>
        [JsonProperty("destination_address_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationAddressGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallRuleDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  sourceIpAddress: ").Append(SourceIpAddress).Append("\n");
            sb.Append("  destinationIpAddress: ").Append(DestinationIpAddress).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  destinationPort: ").Append(DestinationPort).Append("\n");
            sb.Append("  sourceAddressGroupId: ").Append(SourceAddressGroupId).Append("\n");
            sb.Append("  destinationAddressGroupId: ").Append(DestinationAddressGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FirewallRuleDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FirewallRuleDetail input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.SourceIpAddress == input.SourceIpAddress ||
                    (this.SourceIpAddress != null &&
                    this.SourceIpAddress.Equals(input.SourceIpAddress))
                ) && 
                (
                    this.DestinationIpAddress == input.DestinationIpAddress ||
                    (this.DestinationIpAddress != null &&
                    this.DestinationIpAddress.Equals(input.DestinationIpAddress))
                ) && 
                (
                    this.SourcePort == input.SourcePort ||
                    (this.SourcePort != null &&
                    this.SourcePort.Equals(input.SourcePort))
                ) && 
                (
                    this.DestinationPort == input.DestinationPort ||
                    (this.DestinationPort != null &&
                    this.DestinationPort.Equals(input.DestinationPort))
                ) && 
                (
                    this.SourceAddressGroupId == input.SourceAddressGroupId ||
                    (this.SourceAddressGroupId != null &&
                    this.SourceAddressGroupId.Equals(input.SourceAddressGroupId))
                ) && 
                (
                    this.DestinationAddressGroupId == input.DestinationAddressGroupId ||
                    (this.DestinationAddressGroupId != null &&
                    this.DestinationAddressGroupId.Equals(input.DestinationAddressGroupId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.SourceIpAddress != null)
                    hashCode = hashCode * 59 + this.SourceIpAddress.GetHashCode();
                if (this.DestinationIpAddress != null)
                    hashCode = hashCode * 59 + this.DestinationIpAddress.GetHashCode();
                if (this.SourcePort != null)
                    hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.DestinationPort != null)
                    hashCode = hashCode * 59 + this.DestinationPort.GetHashCode();
                if (this.SourceAddressGroupId != null)
                    hashCode = hashCode * 59 + this.SourceAddressGroupId.GetHashCode();
                if (this.DestinationAddressGroupId != null)
                    hashCode = hashCode * 59 + this.DestinationAddressGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
