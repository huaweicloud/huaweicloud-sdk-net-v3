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
    public class NeutronPort 
    {

        /// <summary>
        /// 功能说明：端口管理状态 约束：目前支持true
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 功能说明：扩展属性：IP/Mac对列表，详情参见“allow_address_pair对象”表 约束：IP地址不允许为 “0.0.0.0”如果allowed_address_pairs配置地址池较大的CIDR（掩码小于24位），建议为该port配置一个单独的安全组硬件SDN环境不支持ip_address属性配置为CIDR格式。
        /// </summary>
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedAddressPair> AllowedAddressPairs { get; set; }

        /// <summary>
        /// 扩展属性：提供用户设置自定义信息 【使用说明】  internal_elb字段，布尔类型，普通租户可见。只有在创建内网ELB的虚拟IP的网卡时设置为true。普通租户没有权限更改该字段，由系统维护。 举例：{\&quot;internal_elb\&quot;: true}  disable_security_groups字段，布尔类型，普通租户可见。默认为false高性能通信场景下，允许指定为true普通租户可见。仅支持创建port和读取时指定。当前仅支持指定为true，不支持指定为false 举例：{\&quot;disable_security_groups\&quot;：true }， 当前仅支持指定为true，不支持指定为false，指定为true时，FWaaS功能不生效。  仅对于“华北-北京二”：udp_srvports和tcp_srvports，字段，字符串类型，默认不设置udp_srvports和tcp_srvports字段。允许指定udp_srvports和tcp_srvports字段为端口号，表示这些端口的tcp报文和udp报文可支持高并发连接，但是此类报文不受ACL和安全组规则的限制。udp_srvports和tcp_srvports字段同时支持更新操作。 − 格式： {\&quot;tcp_srvports\&quot;: \&quot;port1 port2 port3\&quot;, \&quot;udp_srvports\&quot;: \&quot;port1 port2 port3\&quot;} 端口号之间以空格间隔，最多允许指定的端口号总共为15个，端口号范围是1到65535。 − 示例：{\&quot;tcp_srvports\&quot;: \&quot;80 443\&quot;, \&quot;udp_srvports\&quot;: \&quot;53\&quot;} 示例表示入方向目的端口为80或者443的tcp报文可支持高并发连接。入方向目的端口为53的udp报文可支持高并发连接。但是此类报文不受ACL和安全组规则的限制。 
        /// </summary>
        [JsonProperty("binding:profile", NullValueHandling = NullValueHandling.Ignore)]
        public Object Bindingprofile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("binding:vif_details", NullValueHandling = NullValueHandling.Ignore)]
        public BindingVifDetails BindingvifDetails { get; set; }

        /// <summary>
        /// 功能说明：绑定的vNIC类型  - normal：软交换
        /// </summary>
        [JsonProperty("binding:vnic_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingvnicType { get; set; }

        /// <summary>
        /// 功能说明：端口设备ID 约束：不支持设置和更新，由系统自动维护，该字段非空的端口不允许删除。
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 功能说明：端口设备所属（DHCP/Router/ Nova等） 约束：不支持更新，只允许用户在创建虚拟IP端口时，为虚拟IP端口设置device_owner为neutron:VIP_PORT，当端口的该字段不为空时，仅支持该字段为neutron:VIP_PORT时的端口删除。该字段非空的端口不允许删除。
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceOwner { get; set; }

        /// <summary>
        /// 功能说明：扩展属性：主网卡默认内网域名信息 约束：不支持设置和更新，由系统自动维护  - hostname：与端口dns_name一致  - ip_address：端口ipv4私有地址  - fqdn：为端口创建默认内网fqdn
        /// </summary>
        [JsonProperty("dns_assignment", NullValueHandling = NullValueHandling.Ignore)]
        public List<DnsAssignMent> DnsAssignment { get; set; }

        /// <summary>
        /// 功能说明：扩展属性：主网卡默认内网DNS名称 约束：不支持设置和更新，由系统自动维护,访问该默认内网域名前，请确保子网使用当前系统提供的DNS
        /// </summary>
        [JsonProperty("dns_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsName { get; set; }

        /// <summary>
        /// 功能说明：扩展属性：DHCP的扩展Option，详情参见“ExtraDhcpOpt对象”表
        /// </summary>
        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOpt> ExtraDhcpOpts { get; set; }

        /// <summary>
        /// 功能说明：端口的IP地址，参见“FixedIp对象”表 约束：device_owner为neutron: VIP_PORT时最多指定一个fixed_ip，给云服务器创建IPv6端口时，必须具备一个IPv4 subnet_id和一个IPv6 subnet_id 。
        /// </summary>
        [JsonProperty("fixed_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<FixedIp> FixedIps { get; set; }

        /// <summary>
        /// 端口ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：端口mac地址 约束：只支持系统动态分配，不支持指定
        /// </summary>
        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddress { get; set; }

        /// <summary>
        /// 功能说明：端口的名称 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 端口所属网络ID
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// 功能说明：端口安全使能标记，如果不使能则安全组和dhcp防欺骗不生效 取值范围：启用（true）或禁用（false）
        /// </summary>
        [JsonProperty("port_security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortSecurityEnabled { get; set; }

        /// <summary>
        /// 功能说明：作用在该端口上的安全组的ID列表 约束：不支持更新为空
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// 功能说明：端口状态 取值范围：ACTIVE，BUILD，DOWN 约束：Hana硬直通虚拟机端口状态总为DOWN
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 功能说明：资源创建UTC时间 格式：yyyy-MM-ddTHH:mm:ss
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 功能说明：资源更新UTC时间 格式：yyyy-MM-ddTHH:mm:ss
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronPort {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("  bindingprofile: ").Append(Bindingprofile).Append("\n");
            sb.Append("  bindingvifDetails: ").Append(BindingvifDetails).Append("\n");
            sb.Append("  bindingvnicType: ").Append(BindingvnicType).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  dnsAssignment: ").Append(DnsAssignment).Append("\n");
            sb.Append("  dnsName: ").Append(DnsName).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  portSecurityEnabled: ").Append(PortSecurityEnabled).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronPort);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronPort input)
        {
            if (input == null) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.AllowedAddressPairs != input.AllowedAddressPairs || (this.AllowedAddressPairs != null && input.AllowedAddressPairs != null && !this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs))) return false;
            if (this.Bindingprofile != input.Bindingprofile || (this.Bindingprofile != null && !this.Bindingprofile.Equals(input.Bindingprofile))) return false;
            if (this.BindingvifDetails != input.BindingvifDetails || (this.BindingvifDetails != null && !this.BindingvifDetails.Equals(input.BindingvifDetails))) return false;
            if (this.BindingvnicType != input.BindingvnicType || (this.BindingvnicType != null && !this.BindingvnicType.Equals(input.BindingvnicType))) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.DeviceOwner != input.DeviceOwner || (this.DeviceOwner != null && !this.DeviceOwner.Equals(input.DeviceOwner))) return false;
            if (this.DnsAssignment != input.DnsAssignment || (this.DnsAssignment != null && input.DnsAssignment != null && !this.DnsAssignment.SequenceEqual(input.DnsAssignment))) return false;
            if (this.DnsName != input.DnsName || (this.DnsName != null && !this.DnsName.Equals(input.DnsName))) return false;
            if (this.ExtraDhcpOpts != input.ExtraDhcpOpts || (this.ExtraDhcpOpts != null && input.ExtraDhcpOpts != null && !this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts))) return false;
            if (this.FixedIps != input.FixedIps || (this.FixedIps != null && input.FixedIps != null && !this.FixedIps.SequenceEqual(input.FixedIps))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MacAddress != input.MacAddress || (this.MacAddress != null && !this.MacAddress.Equals(input.MacAddress))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NetworkId != input.NetworkId || (this.NetworkId != null && !this.NetworkId.Equals(input.NetworkId))) return false;
            if (this.PortSecurityEnabled != input.PortSecurityEnabled || (this.PortSecurityEnabled != null && !this.PortSecurityEnabled.Equals(input.PortSecurityEnabled))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.AllowedAddressPairs != null) hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                if (this.Bindingprofile != null) hashCode = hashCode * 59 + this.Bindingprofile.GetHashCode();
                if (this.BindingvifDetails != null) hashCode = hashCode * 59 + this.BindingvifDetails.GetHashCode();
                if (this.BindingvnicType != null) hashCode = hashCode * 59 + this.BindingvnicType.GetHashCode();
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceOwner != null) hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.DnsAssignment != null) hashCode = hashCode * 59 + this.DnsAssignment.GetHashCode();
                if (this.DnsName != null) hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                if (this.ExtraDhcpOpts != null) hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                if (this.FixedIps != null) hashCode = hashCode * 59 + this.FixedIps.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MacAddress != null) hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkId != null) hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.PortSecurityEnabled != null) hashCode = hashCode * 59 + this.PortSecurityEnabled.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
