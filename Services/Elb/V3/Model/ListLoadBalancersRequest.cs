using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListLoadBalancersRequest 
    {

        /// <summary>
        /// 负载均衡器的管理状态。只支持设定为true。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 可用区。 注： 可用AZ的查询方式可用通过调用nova接口查询 /v2/{project_id}/os-availability-zone
        /// </summary>
        [SDKProperty("availability_zone_list", IsQuery = true)]
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// 预留资源账单信息，默认为空表示按需计费， 非空为包周期。admin权限才能更新此字段。
        /// </summary>
        [SDKProperty("billing_info", IsQuery = true)]
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BillingInfo { get; set; }

        /// <summary>
        /// 是否开启删除保护，false不开启，默认为空都查询
        /// </summary>
        [SDKProperty("deletion_protection_enable", IsQuery = true)]
        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        /// <summary>
        /// 负载均衡器的描述信息。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 公网ELB实例绑定EIP。 示例如下：  \&quot;eips\&quot;: [             {                 \&quot;eip_id\&quot;: \&quot;a6ded276-c88a-4c58-95e0-5b6d1d2297b3\&quot;,                 \&quot;eip_address\&quot;: \&quot;2001:db8:a583:86:cf24:5cc5:8117:6eaa\&quot;,                 \&quot;ip_version\&quot;: 6             }         ] 查询时指定：eips&#x3D;eip_id&#x3D;XXXX
        /// </summary>
        [SDKProperty("eips", IsQuery = true)]
        [JsonProperty("eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Eips { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 共享型：false 性能保障型：true
        /// </summary>
        [SDKProperty("guaranteed", IsQuery = true)]
        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }

        /// <summary>
        /// 负载均衡器ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// IP版本信息。 取值范围：4和6 4：IPv4 6：IPv6
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> IpVersion { get; set; }

        /// <summary>
        /// 双栈实例对应v6的ip地址。
        /// </summary>
        [SDKProperty("ipv6_vip_address", IsQuery = true)]
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6VipAddress { get; set; }

        /// <summary>
        /// 双栈实例对应v6的端口。
        /// </summary>
        [SDKProperty("ipv6_vip_port_id", IsQuery = true)]
        [JsonProperty("ipv6_vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6VipPortId { get; set; }

        /// <summary>
        /// 双栈实例对应v6的网络id 。 说明：vpc_id , vip_subnet_cidr_id, ipv6_vip_virsubnet_id不能同时为空。
        /// </summary>
        [SDKProperty("ipv6_vip_virsubnet_id", IsQuery = true)]
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// 四层Flavor， 按需计费不填， 包周期由用户设置。
        /// </summary>
        [SDKProperty("l4_flavor_id", IsQuery = true)]
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> L4FlavorId { get; set; }

        /// <summary>
        /// 预留弹性flavor。
        /// </summary>
        [SDKProperty("l4_scale_flavor_id", IsQuery = true)]
        [JsonProperty("l4_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> L4ScaleFlavorId { get; set; }

        /// <summary>
        /// 七层Flavor， 按需计费不填， 包周期由用户设置。
        /// </summary>
        [SDKProperty("l7_flavor_id", IsQuery = true)]
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> L7FlavorId { get; set; }

        /// <summary>
        /// 预留弹性flavor。
        /// </summary>
        [SDKProperty("l7_scale_flavor_id", IsQuery = true)]
        [JsonProperty("l7_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> L7ScaleFlavorId { get; set; }

        /// <summary>
        /// 每页返回的个数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明：  - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 后端云服务器的IP地址。
        /// </summary>
        [SDKProperty("member_address", IsQuery = true)]
        [JsonProperty("member_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberAddress { get; set; }

        /// <summary>
        /// 后端云服务器对应的弹性云服务器的ID。
        /// </summary>
        [SDKProperty("member_device_id", IsQuery = true)]
        [JsonProperty("member_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberDeviceId { get; set; }

        /// <summary>
        /// 负载均衡器名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 负载均衡器的操作状态。 可以为：ONLINE、OFFLINE、DEGRADED、DISABLED或NO_MONITOR。 说明 该字段为预留字段，暂未启用。
        /// </summary>
        [SDKProperty("operating_status", IsQuery = true)]
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OperatingStatus { get; set; }

        /// <summary>
        /// 分页的顺序，true表示从后往前分页，false表示从前往后分页，默认为false。 使用说明：必须与limit一起使用。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 负载均衡器的配置状态。 可以为：ACTIVE、PENDING_CREATE 或者ERROR。 说明 该字段为预留字段，暂未启用。
        /// </summary>
        [SDKProperty("provisioning_status", IsQuery = true)]
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProvisioningStatus { get; set; }

        /// <summary>
        /// 公网IP 示例如下：  \&quot;publicips\&quot;: [             {                 \&quot;publicip_id\&quot;: \&quot;a6ded276-c88a-4c58-95e0-5b6d1d2297b3\&quot;,                 \&quot;publicip_address\&quot;: \&quot;2001:db8:a583:86:cf24:5cc5:8117:6eaa\&quot;,                 \&quot;publicip_ip_version\&quot;: 6             }         ] 查询时指定：publicips&#x3D;publicip_id&#x3D;XXXX,YYYY
        /// </summary>
        [SDKProperty("publicips", IsQuery = true)]
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Publicips { get; set; }

        /// <summary>
        /// 负载均衡器的虚拟IP。
        /// </summary>
        [SDKProperty("vip_address", IsQuery = true)]
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VipAddress { get; set; }

        /// <summary>
        /// 负载均衡器虚拟IP对应的端口ID。
        /// </summary>
        [SDKProperty("vip_port_id", IsQuery = true)]
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VipPortId { get; set; }

        /// <summary>
        /// 负载均衡器所在的子网ID，仅支持内网类型。 说明：vpc_id , vip_subnet_cidr_id, ipv6_vip_virsubnet_id不能同时为空。
        /// </summary>
        [SDKProperty("vip_subnet_cidr_id", IsQuery = true)]
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VipSubnetCidrId { get; set; }

        /// <summary>
        /// 实例对应的vpc属性。 若无，则从vip_subnet_cidr_id获取。  说明：vpc_id , vip_subnet_cidr_id, ipv6_vip_virsubnet_id不能同时为空。
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VpcId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLoadBalancersRequest {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  deletionProtectionEnable: ").Append(DeletionProtectionEnable).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  eips: ").Append(Eips).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("  ipv6VipPortId: ").Append(Ipv6VipPortId).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l4ScaleFlavorId: ").Append(L4ScaleFlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  l7ScaleFlavorId: ").Append(L7ScaleFlavorId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  memberAddress: ").Append(MemberAddress).Append("\n");
            sb.Append("  memberDeviceId: ").Append(MemberDeviceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLoadBalancersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLoadBalancersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.AvailabilityZoneList == input.AvailabilityZoneList ||
                    this.AvailabilityZoneList != null &&
                    input.AvailabilityZoneList != null &&
                    this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList)
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    this.BillingInfo != null &&
                    input.BillingInfo != null &&
                    this.BillingInfo.SequenceEqual(input.BillingInfo)
                ) && 
                (
                    this.DeletionProtectionEnable == input.DeletionProtectionEnable ||
                    (this.DeletionProtectionEnable != null &&
                    this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.Eips == input.Eips ||
                    this.Eips != null &&
                    input.Eips != null &&
                    this.Eips.SequenceEqual(input.Eips)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.Guaranteed == input.Guaranteed ||
                    (this.Guaranteed != null &&
                    this.Guaranteed.Equals(input.Guaranteed))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    this.IpVersion != null &&
                    input.IpVersion != null &&
                    this.IpVersion.SequenceEqual(input.IpVersion)
                ) && 
                (
                    this.Ipv6VipAddress == input.Ipv6VipAddress ||
                    this.Ipv6VipAddress != null &&
                    input.Ipv6VipAddress != null &&
                    this.Ipv6VipAddress.SequenceEqual(input.Ipv6VipAddress)
                ) && 
                (
                    this.Ipv6VipPortId == input.Ipv6VipPortId ||
                    this.Ipv6VipPortId != null &&
                    input.Ipv6VipPortId != null &&
                    this.Ipv6VipPortId.SequenceEqual(input.Ipv6VipPortId)
                ) && 
                (
                    this.Ipv6VipVirsubnetId == input.Ipv6VipVirsubnetId ||
                    this.Ipv6VipVirsubnetId != null &&
                    input.Ipv6VipVirsubnetId != null &&
                    this.Ipv6VipVirsubnetId.SequenceEqual(input.Ipv6VipVirsubnetId)
                ) && 
                (
                    this.L4FlavorId == input.L4FlavorId ||
                    this.L4FlavorId != null &&
                    input.L4FlavorId != null &&
                    this.L4FlavorId.SequenceEqual(input.L4FlavorId)
                ) && 
                (
                    this.L4ScaleFlavorId == input.L4ScaleFlavorId ||
                    this.L4ScaleFlavorId != null &&
                    input.L4ScaleFlavorId != null &&
                    this.L4ScaleFlavorId.SequenceEqual(input.L4ScaleFlavorId)
                ) && 
                (
                    this.L7FlavorId == input.L7FlavorId ||
                    this.L7FlavorId != null &&
                    input.L7FlavorId != null &&
                    this.L7FlavorId.SequenceEqual(input.L7FlavorId)
                ) && 
                (
                    this.L7ScaleFlavorId == input.L7ScaleFlavorId ||
                    this.L7ScaleFlavorId != null &&
                    input.L7ScaleFlavorId != null &&
                    this.L7ScaleFlavorId.SequenceEqual(input.L7ScaleFlavorId)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.MemberAddress == input.MemberAddress ||
                    this.MemberAddress != null &&
                    input.MemberAddress != null &&
                    this.MemberAddress.SequenceEqual(input.MemberAddress)
                ) && 
                (
                    this.MemberDeviceId == input.MemberDeviceId ||
                    this.MemberDeviceId != null &&
                    input.MemberDeviceId != null &&
                    this.MemberDeviceId.SequenceEqual(input.MemberDeviceId)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    this.OperatingStatus != null &&
                    input.OperatingStatus != null &&
                    this.OperatingStatus.SequenceEqual(input.OperatingStatus)
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    this.ProvisioningStatus != null &&
                    input.ProvisioningStatus != null &&
                    this.ProvisioningStatus.SequenceEqual(input.ProvisioningStatus)
                ) && 
                (
                    this.Publicips == input.Publicips ||
                    this.Publicips != null &&
                    input.Publicips != null &&
                    this.Publicips.SequenceEqual(input.Publicips)
                ) && 
                (
                    this.VipAddress == input.VipAddress ||
                    this.VipAddress != null &&
                    input.VipAddress != null &&
                    this.VipAddress.SequenceEqual(input.VipAddress)
                ) && 
                (
                    this.VipPortId == input.VipPortId ||
                    this.VipPortId != null &&
                    input.VipPortId != null &&
                    this.VipPortId.SequenceEqual(input.VipPortId)
                ) && 
                (
                    this.VipSubnetCidrId == input.VipSubnetCidrId ||
                    this.VipSubnetCidrId != null &&
                    input.VipSubnetCidrId != null &&
                    this.VipSubnetCidrId.SequenceEqual(input.VipSubnetCidrId)
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    this.VpcId != null &&
                    input.VpcId != null &&
                    this.VpcId.SequenceEqual(input.VpcId)
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.AvailabilityZoneList != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.DeletionProtectionEnable != null)
                    hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Eips != null)
                    hashCode = hashCode * 59 + this.Eips.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Guaranteed != null)
                    hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Ipv6VipAddress != null)
                    hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.Ipv6VipPortId != null)
                    hashCode = hashCode * 59 + this.Ipv6VipPortId.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null)
                    hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.L4FlavorId != null)
                    hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L4ScaleFlavorId != null)
                    hashCode = hashCode * 59 + this.L4ScaleFlavorId.GetHashCode();
                if (this.L7FlavorId != null)
                    hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.L7ScaleFlavorId != null)
                    hashCode = hashCode * 59 + this.L7ScaleFlavorId.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.MemberAddress != null)
                    hashCode = hashCode * 59 + this.MemberAddress.GetHashCode();
                if (this.MemberDeviceId != null)
                    hashCode = hashCode * 59 + this.MemberDeviceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.Publicips != null)
                    hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                if (this.VipAddress != null)
                    hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.VipPortId != null)
                    hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.VipSubnetCidrId != null)
                    hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                return hashCode;
            }
        }
    }
}
