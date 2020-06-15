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
    public class Port 
    {
        /// <summary>
        /// 功能说明：设备所属 取值范围：合法设备所属，如network:dhcp、network:VIP_PORT、network:router_interface_distributed、network:router_centralized_snat 约束：不支持设置和更新，由系统自动维护
        /// </summary>
        /// <value>功能说明：设备所属 取值范围：合法设备所属，如network:dhcp、network:VIP_PORT、network:router_interface_distributed、network:router_centralized_snat 约束：不支持设置和更新，由系统自动维护</value>
        [JsonConverter(typeof(EnumClassConverter<DeviceOwnerEnum>))]
        public class DeviceOwnerEnum
        {
            /// <summary>
            /// Enum NETWORK_DHCP for value: network:dhcp
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_DHCP = new DeviceOwnerEnum("network:dhcp");

            /// <summary>
            /// Enum NETWORK_VIP_PORT for value: network:VIP_PORT
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_VIP_PORT = new DeviceOwnerEnum("network:VIP_PORT");

            /// <summary>
            /// Enum NETWORK_ROUTER_INTERFACE_DISTRIBUTED for value: network:router_interface_distributed
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_ROUTER_INTERFACE_DISTRIBUTED = new DeviceOwnerEnum("network:router_interface_distributed");

            /// <summary>
            /// Enum NETWORK_ROUTER_CENTRALIZED_SNAT for value: network:router_centralized_snat
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_ROUTER_CENTRALIZED_SNAT = new DeviceOwnerEnum("network:router_centralized_snat");

            public static readonly Dictionary<string, DeviceOwnerEnum> StaticFields =
            new Dictionary<string, DeviceOwnerEnum>()
            {
                {"network:dhcp", NETWORK_DHCP},
                {"network:VIP_PORT", NETWORK_VIP_PORT},
                {"network:router_interface_distributed", NETWORK_ROUTER_INTERFACE_DISTRIBUTED},
                {"network:router_centralized_snat", NETWORK_ROUTER_CENTRALIZED_SNAT},
            };

            private string Value;

            public DeviceOwnerEnum(string Value)
            {
                this.Value = Value;
            }

            public static DeviceOwnerEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as DeviceOwnerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeviceOwnerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeviceOwnerEnum a, DeviceOwnerEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DeviceOwnerEnum a, DeviceOwnerEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：端口状态，Hana硬直通虚拟机端口状态总为DOWN 取值范围：ACTIVE、BUILD、DOWN
        /// </summary>
        /// <value>功能说明：端口状态，Hana硬直通虚拟机端口状态总为DOWN 取值范围：ACTIVE、BUILD、DOWN</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum BUILD for value: BUILD
            /// </summary>
            public static readonly StatusEnum BUILD = new StatusEnum("BUILD");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            public static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                {"ACTIVE", ACTIVE},
                {"BUILD", BUILD},
                {"DOWN", DOWN},
            };

            private string Value;

            public StatusEnum(string Value)
            {
                this.Value = Value;
            }

            public static StatusEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 端口ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：端口名称 取值范围：0~255个字符，支持中文、英文、字母、_(下划线)、-（中划线）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 端口所属网络的ID
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// 功能说明：管理状态 约束：只支持true，默认为true 
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 功能描述：端口MAC地址 约束：由系统分配，不支持指定
        /// </summary>
        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddress { get; set; }

        /// <summary>
        /// 功能说明：端口IP 例如：\&quot;fixed_ips\&quot;: [{\&quot;subnet_id\&quot;: \&quot;4dc70db6-cb7f-4200-9790-a6a910776bba\&quot;, \&quot;ip_address\&quot;: \&quot;192.169.25.79\&quot;}] 约束：一个端口只支持一个fixed_ip，且不支持更新。
        /// </summary>
        [JsonProperty("fixed_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<FixedIp> FixedIps { get; set; }

        /// <summary>
        /// 功能说明：端口所属设备ID 约束：不支持设置和更新，由系统自动维护
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 功能说明：设备所属 取值范围：合法设备所属，如network:dhcp、network:VIP_PORT、network:router_interface_distributed、network:router_centralized_snat 约束：不支持设置和更新，由系统自动维护
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceOwnerEnum DeviceOwner { get; set; }
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：端口状态，Hana硬直通虚拟机端口状态总为DOWN 取值范围：ACTIVE、BUILD、DOWN
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 安全组的ID列表
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// 功能说明：IP/Mac对列表 约束：IP地址不允许为 “0.0.0.0” 如果配置地址池较大（CIDR掩码小于24位），建议为该port配置一个单独的安全组。
        /// </summary>
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedAddressPair> AllowedAddressPairs { get; set; }

        /// <summary>
        /// 功能说明：DHCP的扩展Option(扩展属性)
        /// </summary>
        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOpt> ExtraDhcpOpts { get; set; }

        /// <summary>
        /// 功能说明：绑定的vNIC类型 取值范围：  - normal（软交换）  - direct: SRIOV硬直通（不支持） 
        /// </summary>
        [JsonProperty("binding:vnic_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingvnicType { get; set; }

        /// <summary>
        /// 功能说明：主网卡默认内网域名信息 约束：不支持设置和更新，由系统自动维护
        /// </summary>
        [JsonProperty("dns_assignment", NullValueHandling = NullValueHandling.Ignore)]
        public List<DnsAssignMent> DnsAssignment { get; set; }

        /// <summary>
        /// 功能说明：主网卡默认内网DNS名称 约束：不支持设置和更新，由系统自动维护
        /// </summary>
        [JsonProperty("dns_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsName { get; set; }

        /// <summary>
        /// 功能说明：vif的详细信息，  \&quot;ovs_hybrid_plug\&quot;: 是否为ovs/bridge混合模式 约束：管理员权限，普通租户不可指定
        /// </summary>
        [JsonProperty("binding:vif_details", NullValueHandling = NullValueHandling.Ignore)]
        public Object BindingvifDetails { get; set; }

        /// <summary>
        /// 功能说明：提供用户设置自定义信息(扩展属性)
        /// </summary>
        [JsonProperty("binding:profile", NullValueHandling = NullValueHandling.Ignore)]
        public Object Bindingprofile { get; set; }

        /// <summary>
        /// 功能说明：端口所属实例ID，例如RDS实例ID 约束：不支持设置和更新，由系统自动维护
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 功能说明：端口所属实例类型，例如“RDS” 约束：不支持设置和更新，由系统自动维护
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 功能说明：端口安全使能标记，如果不使能则安全组和dhcp防欺骗不生效 取值范围：启用（true）或禁用（false）
        /// </summary>
        [JsonProperty("port_security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortSecurityEnabled { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("  bindingvnicType: ").Append(BindingvnicType).Append("\n");
            sb.Append("  dnsAssignment: ").Append(DnsAssignment).Append("\n");
            sb.Append("  dnsName: ").Append(DnsName).Append("\n");
            sb.Append("  bindingvifDetails: ").Append(BindingvifDetails).Append("\n");
            sb.Append("  bindingprofile: ").Append(Bindingprofile).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  portSecurityEnabled: ").Append(PortSecurityEnabled).Append("\n");
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
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
                ) && 
                (
                    this.FixedIps == input.FixedIps ||
                    this.FixedIps != null &&
                    input.FixedIps != null &&
                    this.FixedIps.SequenceEqual(input.FixedIps)
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.DeviceOwner == input.DeviceOwner ||
                    (this.DeviceOwner != null &&
                    this.DeviceOwner.Equals(input.DeviceOwner))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.AllowedAddressPairs == input.AllowedAddressPairs ||
                    this.AllowedAddressPairs != null &&
                    input.AllowedAddressPairs != null &&
                    this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs)
                ) && 
                (
                    this.ExtraDhcpOpts == input.ExtraDhcpOpts ||
                    this.ExtraDhcpOpts != null &&
                    input.ExtraDhcpOpts != null &&
                    this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts)
                ) && 
                (
                    this.BindingvnicType == input.BindingvnicType ||
                    (this.BindingvnicType != null &&
                    this.BindingvnicType.Equals(input.BindingvnicType))
                ) && 
                (
                    this.DnsAssignment == input.DnsAssignment ||
                    this.DnsAssignment != null &&
                    input.DnsAssignment != null &&
                    this.DnsAssignment.SequenceEqual(input.DnsAssignment)
                ) && 
                (
                    this.DnsName == input.DnsName ||
                    (this.DnsName != null &&
                    this.DnsName.Equals(input.DnsName))
                ) && 
                (
                    this.BindingvifDetails == input.BindingvifDetails ||
                    (this.BindingvifDetails != null &&
                    this.BindingvifDetails.Equals(input.BindingvifDetails))
                ) && 
                (
                    this.Bindingprofile == input.Bindingprofile ||
                    (this.Bindingprofile != null &&
                    this.Bindingprofile.Equals(input.Bindingprofile))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.PortSecurityEnabled == input.PortSecurityEnabled ||
                    (this.PortSecurityEnabled != null &&
                    this.PortSecurityEnabled.Equals(input.PortSecurityEnabled))
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
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.FixedIps != null)
                    hashCode = hashCode * 59 + this.FixedIps.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceOwner != null)
                    hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.AllowedAddressPairs != null)
                    hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                if (this.ExtraDhcpOpts != null)
                    hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                if (this.BindingvnicType != null)
                    hashCode = hashCode * 59 + this.BindingvnicType.GetHashCode();
                if (this.DnsAssignment != null)
                    hashCode = hashCode * 59 + this.DnsAssignment.GetHashCode();
                if (this.DnsName != null)
                    hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                if (this.BindingvifDetails != null)
                    hashCode = hashCode * 59 + this.BindingvifDetails.GetHashCode();
                if (this.Bindingprofile != null)
                    hashCode = hashCode * 59 + this.Bindingprofile.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.PortSecurityEnabled != null)
                    hashCode = hashCode * 59 + this.PortSecurityEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
