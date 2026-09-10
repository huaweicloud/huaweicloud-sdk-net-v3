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
    public class SubNetworkInterface 
    {

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的资源ID。辅助弹性网卡创建成功后，会生成一个辅助弹性网卡 ID，是辅助弹性网卡对应的唯一标识。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所在的虚拟子网ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的私有IPv4地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的私有IPv6地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ipv6_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6IpAddress { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的MAC地址。 **取值范围**： 合法的MAC地址，系统随机分配。
        /// </summary>
        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddress { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的宿主网卡所属的设备ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("parent_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentDeviceId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所挂载的弹性网卡的ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的描述信息。 **取值范围**： 0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所属VPC的ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的VLAN ID。 **取值范围**： 1-4094
        /// </summary>
        [JsonProperty("vlan_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? VlanId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡关联的安全组的ID列表。例如：\&quot;security_groups\&quot;: [\&quot;a0608cbf-d047-4f54-8b28-cd7b59853fff\&quot;]。 **取值范围**： 如果请求时不指定此参数，辅助弹性网卡创建后会自动关联默认安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的标签信息，包括标签键和标签值，可用来分类和标识资源。详情请参见Tag对象。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResponseTag> Tags { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所属的项目ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的创建时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的更新时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的IP/Mac对列表，详情请参见“AllowedAddressPair”对象表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedAddressPair> AllowedAddressPairs { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡的状态。 **取值范围**： - NORMAL：表示辅助弹性网卡已挂载在弹性网卡上。 - UNBOUND：表示辅助弹性网卡未挂载在弹性网卡上。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所属的云服务实例ID，例如RDS实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所属的云服务实例类型，例如“RDS”。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所在站点的公网出口信息。 **取值范围**： - center：默认值，表示作用域为中心。 - 某个AZ ID：表示作用域为具体的AZ。
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡安全使能标记，如果不使能则安全组不生效。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecurityEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubNetworkInterface {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  ipv6IpAddress: ").Append(Ipv6IpAddress).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  parentDeviceId: ").Append(ParentDeviceId).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vlanId: ").Append(VlanId).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  securityEnabled: ").Append(SecurityEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubNetworkInterface);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubNetworkInterface input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && !this.VirsubnetId.Equals(input.VirsubnetId))) return false;
            if (this.PrivateIpAddress != input.PrivateIpAddress || (this.PrivateIpAddress != null && !this.PrivateIpAddress.Equals(input.PrivateIpAddress))) return false;
            if (this.Ipv6IpAddress != input.Ipv6IpAddress || (this.Ipv6IpAddress != null && !this.Ipv6IpAddress.Equals(input.Ipv6IpAddress))) return false;
            if (this.MacAddress != input.MacAddress || (this.MacAddress != null && !this.MacAddress.Equals(input.MacAddress))) return false;
            if (this.ParentDeviceId != input.ParentDeviceId || (this.ParentDeviceId != null && !this.ParentDeviceId.Equals(input.ParentDeviceId))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VlanId != input.VlanId || (this.VlanId != null && !this.VlanId.Equals(input.VlanId))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.AllowedAddressPairs != input.AllowedAddressPairs || (this.AllowedAddressPairs != null && input.AllowedAddressPairs != null && !this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && !this.InstanceType.Equals(input.InstanceType))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.SecurityEnabled != input.SecurityEnabled || (this.SecurityEnabled != null && !this.SecurityEnabled.Equals(input.SecurityEnabled))) return false;

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
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.PrivateIpAddress != null) hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.Ipv6IpAddress != null) hashCode = hashCode * 59 + this.Ipv6IpAddress.GetHashCode();
                if (this.MacAddress != null) hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.ParentDeviceId != null) hashCode = hashCode * 59 + this.ParentDeviceId.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VlanId != null) hashCode = hashCode * 59 + this.VlanId.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.AllowedAddressPairs != null) hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null) hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.SecurityEnabled != null) hashCode = hashCode * 59 + this.SecurityEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
