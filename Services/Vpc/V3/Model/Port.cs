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
    /// 功能说明：端口对象。
    /// </summary>
    public class Port 
    {

        /// <summary>
        /// **参数解释**： 端口的管理状态。 **取值范围**： true，false，默认值true。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在的主机ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("binding:host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BindinghostId { get; set; }

        /// <summary>
        /// **参数解释**： 端口的用户自定义信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("binding:profile", NullValueHandling = NullValueHandling.Ignore)]
        public Object Bindingprofile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("binding:vif_details", NullValueHandling = NullValueHandling.Ignore)]
        public BindingVifDetails BindingvifDetails { get; set; }

        /// <summary>
        /// **参数解释**： 端口绑定的虚拟接口类型 (ovs/hw_veb等)，扩展属性。 **取值范围**： - ovs：表示使用 Open vSwitch（OVS）作为虚拟交换机 - bridge：表示使用 Linux 内核桥接（bridge）实现虚拟网络 - hw_veb：表示硬件虚拟以太网桥（Hardware Virtual Ethernet Bridge），通常用于支持 SR-IOV 的硬件网卡 - vhostuser：表示使用 vhost-user 协议（基于 Unix 域套接字）与外部虚拟交换机通信 - distributed：表示用于分布式虚拟交换机 - binding_failed：表示端口绑定失败 - unbound：表示该端口未绑定到任何网络后端
        /// </summary>
        [JsonProperty("binding:vif_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingvifType { get; set; }

        /// <summary>
        /// **参数解释**： 绑定的vNIC类型。 **取值范围**： - normal: 软交换。 - direct: SRIOV硬直通（不支持）。 - baremetal：用于裸金属服务器。
        /// </summary>
        [JsonProperty("binding:vnic_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingvnicType { get; set; }

        /// <summary>
        /// **参数解释**： 端口的创建时间。 **取值范围**： UTC时间，格式: yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 端口的最近一次更新的时间。 **取值范围**： UTC时间，格式: yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 端口的描述信息。 **取值范围**： 0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的设备ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的设备名称。 **取值范围**： - network:dhcp, 表示DHCP服务 - network:router_interface_distributed, 表示子网网关地址 - compute:xxx, 表示云服务器网卡私有IP地址，其中XXX对应具体的可用区名称，例如compute:aa-bb-cc表示私有IP地址被可用区aa-bb-cc内的云服务器使用 - neutron:VIP_PORT, 表示虚拟IP地址 - neutron:LOADBALANCERV2, 表示共享型ELB - neutron:LOADBALANCERV3, 表示独享型ELB - network:endpoint_interface, 表示VPC终端节点 - network:nat_gateway, 表示NAT网关 - network:ucmp, 表示UCMP端口，为企业路由器服务所用
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceOwner { get; set; }

        /// <summary>
        /// **参数解释**： 标识此端口所属云服务器的flavor。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ecs_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsFlavor { get; set; }

        /// <summary>
        /// **参数解释**： 端口的资源ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的云服务实例ID，例如RDS实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的云服务实例类型，例如“RDS”。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// **参数解释**： 端口的MAC地址。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddress { get; set; }

        /// <summary>
        /// **参数解释**： 端口的名称。 **取值范围**： 默认为空，最大长度不超过255。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 端口的安全使能标记，如果不使能，则安全组和DHCP防欺骗不生效。 **取值范围**： - true：使能端口安全。 - false：未使能端口安全。
        /// </summary>
        [JsonProperty("port_security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortSecurityEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 端口的私有IP地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("private_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivateIpInfo> PrivateIps { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的项目ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 端口绑定的安全组列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// **参数解释**： 端口的状态。 **取值范围**： - ACTIVE：端口处于活动状态，可以正常进行网络通信。 - BUILD：端口正在创建或配置中。 - DOWN：端口处于非活动状态，不能进行网络通信。Hana 硬直通虚拟机端口状态总为DOWN。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的租户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在的虚拟子网ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在的VPC的ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在的VPC的租户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("vpc_tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcTenantId { get; set; }

        /// <summary>
        /// **参数解释**： 端口的VTEP IP地址，即虚拟隧道端点的 IP 地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("vtep_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VtepIp { get; set; }

        /// <summary>
        /// **参数解释**： 是否使能efi，使能则表示端口支持vRoCE能力。 **取值范围**： - true：使能efi。 - false：未使能efi。
        /// </summary>
        [JsonProperty("enable_efi", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEfi { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在子网的作用域（边缘云场景）。 **取值范围**： - center：表示作用域为中心。 - {publicBorderGroup}：表示作用域为具体的公网边界组。公网边界组限制子网的可用区范围，可关联多个边缘可用区。
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的可用分区的ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        /// <summary>
        /// **参数解释**： 端口迁移的目的节点信息，包括目的节点的binding:vif_details和binding:vif_type。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("binding:migration_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object BindingmigrationInfo { get; set; }

        /// <summary>
        /// **参数解释**： DHCP的扩展属性。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortExtraDhcpOpt> ExtraDhcpOpts { get; set; }

        /// <summary>
        /// **参数解释**： 边缘场景端口的位置类型。 **取值范围**： 默认值center。
        /// </summary>
        [JsonProperty("position_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionType { get; set; }

        /// <summary>
        /// **参数解释**： 端口绑定的实例信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object InstanceInfo { get; set; }

        /// <summary>
        /// **参数解释**： 端口的标签信息，包括标签键和标签值，可用来分类和标识资源。详情请参见Tag对象。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResponseTag> Tags { get; set; }

        /// <summary>
        /// **参数解释**： 端口的IP/Mac对列表。 **取值范围**： - IP地址不允许为 “0.0.0.0/0”。 - 如果allowed_address_pairs配置地址池较大的IP网段（掩码小于24位），建议为该端口配置一个单独的安全组。 - 如果allowed_address_pairs的IP地址为“1.1.1.1/0”，表示关闭源目地址检查开关。 - 被绑定的云服务器网卡allowed_address_pairs的IP地址填“1.1.1.1/0”。
        /// </summary>
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedAddressPair> AllowedAddressPairs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  bindinghostId: ").Append(BindinghostId).Append("\n");
            sb.Append("  bindingprofile: ").Append(Bindingprofile).Append("\n");
            sb.Append("  bindingvifDetails: ").Append(BindingvifDetails).Append("\n");
            sb.Append("  bindingvifType: ").Append(BindingvifType).Append("\n");
            sb.Append("  bindingvnicType: ").Append(BindingvnicType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  ecsFlavor: ").Append(EcsFlavor).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  portSecurityEnabled: ").Append(PortSecurityEnabled).Append("\n");
            sb.Append("  privateIps: ").Append(PrivateIps).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vpcTenantId: ").Append(VpcTenantId).Append("\n");
            sb.Append("  vtepIp: ").Append(VtepIp).Append("\n");
            sb.Append("  enableEfi: ").Append(EnableEfi).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  zoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  bindingmigrationInfo: ").Append(BindingmigrationInfo).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("  positionType: ").Append(PositionType).Append("\n");
            sb.Append("  instanceInfo: ").Append(InstanceInfo).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Port);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Port input)
        {
            if (input == null) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.BindinghostId != input.BindinghostId || (this.BindinghostId != null && !this.BindinghostId.Equals(input.BindinghostId))) return false;
            if (this.Bindingprofile != input.Bindingprofile || (this.Bindingprofile != null && !this.Bindingprofile.Equals(input.Bindingprofile))) return false;
            if (this.BindingvifDetails != input.BindingvifDetails || (this.BindingvifDetails != null && !this.BindingvifDetails.Equals(input.BindingvifDetails))) return false;
            if (this.BindingvifType != input.BindingvifType || (this.BindingvifType != null && !this.BindingvifType.Equals(input.BindingvifType))) return false;
            if (this.BindingvnicType != input.BindingvnicType || (this.BindingvnicType != null && !this.BindingvnicType.Equals(input.BindingvnicType))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.DeviceOwner != input.DeviceOwner || (this.DeviceOwner != null && !this.DeviceOwner.Equals(input.DeviceOwner))) return false;
            if (this.EcsFlavor != input.EcsFlavor || (this.EcsFlavor != null && !this.EcsFlavor.Equals(input.EcsFlavor))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && !this.InstanceType.Equals(input.InstanceType))) return false;
            if (this.MacAddress != input.MacAddress || (this.MacAddress != null && !this.MacAddress.Equals(input.MacAddress))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PortSecurityEnabled != input.PortSecurityEnabled || (this.PortSecurityEnabled != null && !this.PortSecurityEnabled.Equals(input.PortSecurityEnabled))) return false;
            if (this.PrivateIps != input.PrivateIps || (this.PrivateIps != null && input.PrivateIps != null && !this.PrivateIps.SequenceEqual(input.PrivateIps))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && !this.VirsubnetId.Equals(input.VirsubnetId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VpcTenantId != input.VpcTenantId || (this.VpcTenantId != null && !this.VpcTenantId.Equals(input.VpcTenantId))) return false;
            if (this.VtepIp != input.VtepIp || (this.VtepIp != null && !this.VtepIp.Equals(input.VtepIp))) return false;
            if (this.EnableEfi != input.EnableEfi || (this.EnableEfi != null && !this.EnableEfi.Equals(input.EnableEfi))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.ZoneId != input.ZoneId || (this.ZoneId != null && !this.ZoneId.Equals(input.ZoneId))) return false;
            if (this.BindingmigrationInfo != input.BindingmigrationInfo || (this.BindingmigrationInfo != null && !this.BindingmigrationInfo.Equals(input.BindingmigrationInfo))) return false;
            if (this.ExtraDhcpOpts != input.ExtraDhcpOpts || (this.ExtraDhcpOpts != null && input.ExtraDhcpOpts != null && !this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts))) return false;
            if (this.PositionType != input.PositionType || (this.PositionType != null && !this.PositionType.Equals(input.PositionType))) return false;
            if (this.InstanceInfo != input.InstanceInfo || (this.InstanceInfo != null && !this.InstanceInfo.Equals(input.InstanceInfo))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
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
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.BindinghostId != null) hashCode = hashCode * 59 + this.BindinghostId.GetHashCode();
                if (this.Bindingprofile != null) hashCode = hashCode * 59 + this.Bindingprofile.GetHashCode();
                if (this.BindingvifDetails != null) hashCode = hashCode * 59 + this.BindingvifDetails.GetHashCode();
                if (this.BindingvifType != null) hashCode = hashCode * 59 + this.BindingvifType.GetHashCode();
                if (this.BindingvnicType != null) hashCode = hashCode * 59 + this.BindingvnicType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceOwner != null) hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.EcsFlavor != null) hashCode = hashCode * 59 + this.EcsFlavor.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null) hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.MacAddress != null) hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PortSecurityEnabled != null) hashCode = hashCode * 59 + this.PortSecurityEnabled.GetHashCode();
                if (this.PrivateIps != null) hashCode = hashCode * 59 + this.PrivateIps.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VpcTenantId != null) hashCode = hashCode * 59 + this.VpcTenantId.GetHashCode();
                if (this.VtepIp != null) hashCode = hashCode * 59 + this.VtepIp.GetHashCode();
                if (this.EnableEfi != null) hashCode = hashCode * 59 + this.EnableEfi.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.ZoneId != null) hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                if (this.BindingmigrationInfo != null) hashCode = hashCode * 59 + this.BindingmigrationInfo.GetHashCode();
                if (this.ExtraDhcpOpts != null) hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                if (this.PositionType != null) hashCode = hashCode * 59 + this.PositionType.GetHashCode();
                if (this.InstanceInfo != null) hashCode = hashCode * 59 + this.InstanceInfo.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AllowedAddressPairs != null) hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
