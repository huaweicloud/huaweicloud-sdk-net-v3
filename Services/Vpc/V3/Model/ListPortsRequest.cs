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
    public class ListPortsRequest 
    {

        /// <summary>
        /// **参数解释**： 端口的资源ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// **参数解释**： 端口的名称。 **取值范围**： 默认为空，最大长度不超过255。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// **参数解释**： 端口的管理状态。 **取值范围**： true，false，默认值true。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// **参数解释**： 端口的状态。 **取值范围**： - ACTIVE：端口处- 于活动状态，可以正常进行网络通信。 - BUILD：端口正在创建或配置中。 - DOWN：端口处于非活动状态，不能进行网络通信。Hana 硬直通虚拟机端口状态总为DOWN。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在的虚拟子网ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [SDKProperty("virsubnet_id", IsQuery = true)]
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的设备ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [SDKProperty("device_id", IsQuery = true)]
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceId { get; set; }

        /// <summary>
        /// **参数解释**： 端口的MAC地址。 **取值范围**： 不涉及
        /// </summary>
        [SDKProperty("mac_address", IsQuery = true)]
        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MacAddress { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的设备名称。 **取值范围**： - network:dhcp, 表示DHCP服务 - network:router_interface_distributed, 表示子网网关地址 - compute:xxx, 表示云服务器网卡私有IP地址，其中XXX对应具体的可用区名称，例如compute:aa-bb-cc表示私有IP地址被可用区aa-bb-cc内的云服务器使用 - neutron:VIP_PORT, 表示虚拟IP地址 - neutron:LOADBALANCERV2, 表示共享型ELB - neutron:LOADBALANCERV3, 表示独享型ELB - network:endpoint_interface, 表示VPC终端节点 - network:nat_gateway, 表示NAT网关 - network:ucmp, 表示UCMP端口，为企业路由器服务所用
        /// </summary>
        [SDKProperty("device_owner", IsQuery = true)]
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceOwner { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的设备名称前缀。 **取值范围**： - network：过滤出device_owner前缀是network的端口，如DHCP端口。 - compute：过滤出device_owner前缀是compute的端口，如云服务器网卡。 - neutron：过滤出device_owner前缀是compute的端口，如虚拟IP地址。
        /// </summary>
        [SDKProperty("device_owner_prefixlike", IsQuery = true)]
        [JsonProperty("device_owner_prefixlike", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceOwnerPrefixlike { get; set; }

        /// <summary>
        /// **参数解释**： 端口的描述信息。 **取值范围**： 0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在的主机ID。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("binding:host_id", IsQuery = true)]
        [JsonProperty("binding:host_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BindinghostId { get; set; }

        /// <summary>
        /// **参数解释**： 端口的私有IP地址。 **取值范围**： - private_ips&#x3D;ip_address&#x3D;{ip_address}，其中{ip_address}填IP地址，如192.168.21.22。 - private_ips&#x3D;subnet_cidr_id&#x3D;{subnet_id}，其中{subnet_id}填IPv4子网或IPv6子网的ID，如011fc878-5521-4654-a1ad-f5b0b5820302。
        /// </summary>
        [SDKProperty("private_ips", IsQuery = true)]
        [JsonProperty("private_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateIps { get; set; }

        /// <summary>
        /// **参数解释**： 端口绑定的安全组列表。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("security_groups", IsQuery = true)]
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// **参数解释**： 端口所在的VPC的ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VpcId { get; set; }

        /// <summary>
        /// **参数解释**： 端口的IP/Mac对列表。 **取值范围**： - allowed_address_pairs&#x3D;ip_address&#x3D;{ip_address}，其中{ip_address}填IP地址，如192.168.21.22。 - allowed_address_pairs&#x3D;mac_address&#x3D;{mac_address}，其中{mac_address}填MAC地址，如fa:16:3e:b1:da:62。
        /// </summary>
        [SDKProperty("allowed_address_pairs", IsQuery = true)]
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedAddressPairs { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的云服务实例ID，例如RDS实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 端口所属的云服务实例类型，例如“RDS”。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("instance_type", IsQuery = true)]
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPortsRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  deviceOwnerPrefixlike: ").Append(DeviceOwnerPrefixlike).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  bindinghostId: ").Append(BindinghostId).Append("\n");
            sb.Append("  privateIps: ").Append(PrivateIps).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
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
            return this.Equals(input as ListPortsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPortsRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && input.VirsubnetId != null && !this.VirsubnetId.SequenceEqual(input.VirsubnetId))) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && input.DeviceId != null && !this.DeviceId.SequenceEqual(input.DeviceId))) return false;
            if (this.MacAddress != input.MacAddress || (this.MacAddress != null && input.MacAddress != null && !this.MacAddress.SequenceEqual(input.MacAddress))) return false;
            if (this.DeviceOwner != input.DeviceOwner || (this.DeviceOwner != null && input.DeviceOwner != null && !this.DeviceOwner.SequenceEqual(input.DeviceOwner))) return false;
            if (this.DeviceOwnerPrefixlike != input.DeviceOwnerPrefixlike || (this.DeviceOwnerPrefixlike != null && !this.DeviceOwnerPrefixlike.Equals(input.DeviceOwnerPrefixlike))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.BindinghostId != input.BindinghostId || (this.BindinghostId != null && input.BindinghostId != null && !this.BindinghostId.SequenceEqual(input.BindinghostId))) return false;
            if (this.PrivateIps != input.PrivateIps || (this.PrivateIps != null && input.PrivateIps != null && !this.PrivateIps.SequenceEqual(input.PrivateIps))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && input.VpcId != null && !this.VpcId.SequenceEqual(input.VpcId))) return false;
            if (this.AllowedAddressPairs != input.AllowedAddressPairs || (this.AllowedAddressPairs != null && input.AllowedAddressPairs != null && !this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && !this.InstanceType.Equals(input.InstanceType))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.MacAddress != null) hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.DeviceOwner != null) hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.DeviceOwnerPrefixlike != null) hashCode = hashCode * 59 + this.DeviceOwnerPrefixlike.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.BindinghostId != null) hashCode = hashCode * 59 + this.BindinghostId.GetHashCode();
                if (this.PrivateIps != null) hashCode = hashCode * 59 + this.PrivateIps.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.AllowedAddressPairs != null) hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null) hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
