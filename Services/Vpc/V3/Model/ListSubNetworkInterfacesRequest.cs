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
    /// Request Object
    /// </summary>
    public class ListSubNetworkInterfacesRequest 
    {

        /// <summary>
        /// 功能说明：每页返回的个数 取值范围：0-2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询起始的资源ID，为空时查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡ID，支持多ID过滤 使用场景：查询需要的多个辅助弹性网卡信息
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡所属虚拟子网的ID，支持多个ID过滤 使用场景：过滤需要的单个或者多个虚拟子网下的辅助弹性网卡
        /// </summary>
        [SDKProperty("virsubnet_id", IsQuery = true)]
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VirsubnetId { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的私有IPv4地址，支持多个地址同时过滤 使用场景：通过单个或者多个ip地址过滤查询辅助弹性网卡
        /// </summary>
        [SDKProperty("private_ip_address", IsQuery = true)]
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的mac地址，支持多个同时过滤 使用场景：使用mac地址精确过滤辅助弹性网卡
        /// </summary>
        [SDKProperty("mac_address", IsQuery = true)]
        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MacAddress { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡所属的VPC_ID，支持多ID过滤 使用场景：过滤单个或多个VPC下的辅助弹性网卡信息
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VpcId { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的描述信息，支持多个同时过滤 使用场景：通过描述信息过滤辅助弹性网卡
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 功能说明：辅助弹性网卡的宿主网卡的ID，支持多ID过滤 使用场景：过滤单个或多个宿主网卡下存在的辅助弹性网卡
        /// </summary>
        [SDKProperty("parent_id", IsQuery = true)]
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡是否关联EIP，可以通过此字段过滤辅助弹性网卡，不支持传入多个值进行过滤。 **取值范围**：   - true：辅助弹性网卡已关联EIP   - false：辅助弹性网卡未关联EIP **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("enable_eip", IsQuery = true)]
        [JsonProperty("enable_eip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEip { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所在站点的公网出口信息，可以通过此字段过滤辅助弹性网卡。 **取值范围**： 不涉及。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("scope", IsQuery = true)]
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡关联的安全组ID，可以通过此字段过滤辅助弹性网卡，支持传入多个安全组ID过滤。[获取方式请参见[查询安全组列表](vpc_apiv3_0011.xml)。](tag:hws,hws_hk,hws_test) **取值范围**： 不涉及。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("security_groups", IsQuery = true)]
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所属企业项目的ID。可以使用该字段过滤某个企业项目下的辅助弹性网卡。 **取值范围**： - 最大长度36字节，带“-”连字符的UUID格式，或者是字符串“0”。“0”表示默认企业项目。 - 若需要查询当前用户所有企业项目绑定的辅助弹性网卡，请传参all_granted_eps。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的宿主网卡所属的设备ID，可以通过此字段过滤辅助弹性网卡，支持传入多个ID过滤。 **取值范围**： 不涉及。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("parent_device_id", IsQuery = true)]
        [JsonProperty("parent_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentDeviceId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的VLAN ID，可以通过此字段过滤辅助弹性网卡，支持传入多个VLAN ID过滤。 **取值范围**： 1-4094。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("vlan_id", IsQuery = true)]
        [JsonProperty("vlan_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> VlanId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的状态，可以通过此字段过滤辅助弹性网卡，支持传入多个状态过滤。 **取值范围**： NORMAL：过滤出已挂载在弹性网卡上的辅助弹性网卡 UNBOUND：过滤出未挂载在弹性网卡上的辅助弹性网卡 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> State { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的IPv6地址，可以通过此字段过滤辅助弹性网卡，支持传入多个IP地址过滤。 **取值范围**： 不涉及。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("ipv6_ip_address", IsQuery = true)]
        [JsonProperty("ipv6_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6IpAddress { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所属云服务实例的ID，例如RDS实例的ID，可以通过此字段过滤辅助弹性网卡，支持传入多个ID过滤。 **取值范围**： 不涉及。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所属云服务实例的类型，例如“RDS”，可以通过此字段过滤辅助弹性网卡，支持传入多个实例类型过滤。 **取值范围**： 不涉及。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("instance_type", IsQuery = true)]
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubNetworkInterfacesRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  enableEip: ").Append(EnableEip).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  parentDeviceId: ").Append(ParentDeviceId).Append("\n");
            sb.Append("  vlanId: ").Append(VlanId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  ipv6IpAddress: ").Append(Ipv6IpAddress).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubNetworkInterfacesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubNetworkInterfacesRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && input.VirsubnetId != null && !this.VirsubnetId.SequenceEqual(input.VirsubnetId))) return false;
            if (this.PrivateIpAddress != input.PrivateIpAddress || (this.PrivateIpAddress != null && input.PrivateIpAddress != null && !this.PrivateIpAddress.SequenceEqual(input.PrivateIpAddress))) return false;
            if (this.MacAddress != input.MacAddress || (this.MacAddress != null && input.MacAddress != null && !this.MacAddress.SequenceEqual(input.MacAddress))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && input.VpcId != null && !this.VpcId.SequenceEqual(input.VpcId))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && input.ParentId != null && !this.ParentId.SequenceEqual(input.ParentId))) return false;
            if (this.EnableEip != input.EnableEip || (this.EnableEip != null && !this.EnableEip.Equals(input.EnableEip))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ParentDeviceId != input.ParentDeviceId || (this.ParentDeviceId != null && input.ParentDeviceId != null && !this.ParentDeviceId.SequenceEqual(input.ParentDeviceId))) return false;
            if (this.VlanId != input.VlanId || (this.VlanId != null && input.VlanId != null && !this.VlanId.SequenceEqual(input.VlanId))) return false;
            if (this.State != input.State || (this.State != null && input.State != null && !this.State.SequenceEqual(input.State))) return false;
            if (this.Ipv6IpAddress != input.Ipv6IpAddress || (this.Ipv6IpAddress != null && input.Ipv6IpAddress != null && !this.Ipv6IpAddress.SequenceEqual(input.Ipv6IpAddress))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && input.InstanceId != null && !this.InstanceId.SequenceEqual(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && input.InstanceType != null && !this.InstanceType.SequenceEqual(input.InstanceType))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.PrivateIpAddress != null) hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.MacAddress != null) hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.EnableEip != null) hashCode = hashCode * 59 + this.EnableEip.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ParentDeviceId != null) hashCode = hashCode * 59 + this.ParentDeviceId.GetHashCode();
                if (this.VlanId != null) hashCode = hashCode * 59 + this.VlanId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Ipv6IpAddress != null) hashCode = hashCode * 59 + this.Ipv6IpAddress.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null) hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
