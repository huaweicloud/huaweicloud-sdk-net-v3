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
    public class ListRecycleBinLoadBalancersRequest 
    {

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 参数解释：每页返回的个数。  取值范围：0-2000  默认取值：2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 是否反向查询。  取值： - true：查询上一页。 - false：查询下一页，默认。  使用说明： - 必须与limit一起使用。 - 当page_reverse&#x3D;true时，若要查询上一页，marker取值为当前页返回值的previous_marker。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 负载均衡器ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 负载均衡器名称。  支持多值查询，查询条件格式：*name&#x3D;xxx&amp;name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 负载均衡器的描述信息。  支持多值查询，查询条件格式：*description&#x3D;xxx&amp;description&#x3D;xxx*。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的启用状态。  取值范围： - true ：启用。 - false：停用。  [不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 负载均衡器的操作状态。  取值： - ONLINE：正常运行。 - FROZEN：已冻结。  支持多值查询，查询条件格式：*operating_status&#x3D;xxx&amp;operating_status&#x3D;xxx*。
        /// </summary>
        [SDKProperty("operating_status", IsQuery = true)]
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OperatingStatus { get; set; }

        /// <summary>
        /// 是否独享型LB。  取值： - false：共享型 - true：独享型  [仅支持独享型，固定为true。](tag:hws_eu,hcso_dt)
        /// </summary>
        [SDKProperty("guaranteed", IsQuery = true)]
        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }

        /// <summary>
        /// 负载均衡器所在的VPC ID。  支持多值查询，查询条件格式：*vpc_id&#x3D;xxx&amp;vpc_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VpcId { get; set; }

        /// <summary>
        /// 负载均衡器的IPv4对应的port ID。  支持多值查询，查询条件格式：*vip_port_id&#x3D;xxx&amp;vip_port_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("vip_port_id", IsQuery = true)]
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VipPortId { get; set; }

        /// <summary>
        /// 负载均衡器的IPv4虚拟IP地址。  支持多值查询，查询条件格式：*vip_address&#x3D;xxx&amp;vip_address&#x3D;xxx*。
        /// </summary>
        [SDKProperty("vip_address", IsQuery = true)]
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VipAddress { get; set; }

        /// <summary>
        /// 负载均衡器所在子网的IPv4子网ID，也称为该负载均衡器实例的前端子网。  支持多值查询，查询条件格式：*vip_subnet_cidr_id&#x3D;xxx&amp;vip_subnet_cidr_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("vip_subnet_cidr_id", IsQuery = true)]
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VipSubnetCidrId { get; set; }

        /// <summary>
        /// 双栈类型负载均衡器的IPv6对应的port ID。  支持多值查询，查询条件格式：*ipv6_vip_port_id&#x3D;xxx&amp;ipv6_vip_port_id&#x3D;xxx*。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("ipv6_vip_port_id", IsQuery = true)]
        [JsonProperty("ipv6_vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6VipPortId { get; set; }

        /// <summary>
        /// 双栈类型负载均衡器的IPv6地址。  支持多值查询，查询条件格式：*ipv6_vip_address&#x3D;xxx&amp;ipv6_vip_address&#x3D;xxx*。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("ipv6_vip_address", IsQuery = true)]
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6VipAddress { get; set; }

        /// <summary>
        /// 双栈类型负载均衡器所在的子网IPv6网络ID，也称为该负载均衡器实例的前端子网。  支持多值查询，查询条件格式：*ipv6_vip_virsubnet_id&#x3D;xxx&amp;ipv6_vip_virsubnet_id&#x3D;xxx*。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("ipv6_vip_virsubnet_id", IsQuery = true)]
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// 负载均衡器绑定的EIP。例如要查询绑定以下EIP的LB： \&quot;eips\&quot;: [     {         \&quot;eip_id\&quot;: \&quot;e9b72a9d-4275-455e-a724-853504e4d9c6\&quot;,         \&quot;eip_address\&quot;: \&quot;88.88.14.122\&quot;,         \&quot;ip_version\&quot;: 4     } ] 可以通如下查询： eips&#x3D;ip_version%3D4&amp;eips&#x3D;eip_address%3D88.88.14.122&amp;eips&#x3D;eip_id%3De9b72a9d-4275-455e-a724-853504e4d9c6  支持多值查询，查询条件格式： - eip_id作为查询条件：*eips&#x3D;eip_id&#x3D;xxx&amp;eips&#x3D;eip_id&#x3D;xxx*。 - eip_address作为查询条件：*eips&#x3D;eip_address&#x3D;xxx&amp;eips&#x3D;eip_address&#x3D;xxx*。 - ip_version作为查询条件：*eips&#x3D;ip_version&#x3D;xxx&amp;eips&#x3D;ip_version&#x3D;xxx*。  注：该字段与publicips字段一致。
        /// </summary>
        [SDKProperty("eips", IsQuery = true)]
        [JsonProperty("eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Eips { get; set; }

        /// <summary>
        /// 负载均衡器绑定的公网IP。例如要查询绑定以下公网IP的LB： \&quot;publicips&#x3D;\&quot;: [     {         \&quot;public_id\&quot;: \&quot;e9b72a9d-4275-455e-a724-853504e4d9c6\&quot;,         \&quot;public_address\&quot;: \&quot;88.88.14.122\&quot;,         \&quot;ip_version\&quot;: 4     } ] 可以通如下查询： publicips&#x3D;ip_version%3D4&amp;publicips&#x3D;public_address%3D88.88.14.122&amp;publicips&#x3D;public_id%3De9b72a9d-4275-455e-a724-853504e4d9c6   支持多值查询，查询条件格式： - publicip_id作为查询条件： *publicips&#x3D;publicip_id&#x3D;xxx&amp;publicips&#x3D;publicip_id&#x3D;xxx* - publicip_address作为查询条件： *publicips&#x3D;publicip_address&#x3D;xxx&amp;publicips&#x3D;publicip_address&#x3D;xxx* - ip_version作为查询条件： *publicips&#x3D;ip_version&#x3D;xxx&amp;publicips&#x3D;ip_version&#x3D;xxx*  注：该字段与eips字段一致。
        /// </summary>
        [SDKProperty("publicips", IsQuery = true)]
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Publicips { get; set; }

        /// <summary>
        /// 负载均衡器所在可用区列表。  支持多值查询，查询条件格式： *availability_zone_list&#x3D;xxx&amp;availability_zone_list&#x3D;xxx*。
        /// </summary>
        [SDKProperty("availability_zone_list", IsQuery = true)]
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// 网络型规格ID。  支持多值查询，查询条件格式：*l4_flavor_id&#x3D;xxx&amp;l4_flavor_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:hcso,hk_vdf,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
        /// </summary>
        [SDKProperty("l4_flavor_id", IsQuery = true)]
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> L4FlavorId { get; set; }

        /// <summary>
        /// 应用型规格ID。  支持多值查询，查询条件格式：*l7_flavor_id&#x3D;xxx&amp;l7_flavor_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:hcso,hk_vdf,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
        /// </summary>
        [SDKProperty("l7_flavor_id", IsQuery = true)]
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> L7FlavorId { get; set; }

        /// <summary>
        /// 资源账单信息。  支持多值查询，查询条件格式：*billing_info&#x3D;xxx&amp;billing_info&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:hws_hk,hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)
        /// </summary>
        [SDKProperty("billing_info", IsQuery = true)]
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BillingInfo { get; set; }

        /// <summary>
        /// 负载均衡器中的后端服务器对应的弹性云服务器的ID。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_device_id&#x3D;xxx&amp;member_device_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_device_id", IsQuery = true)]
        [JsonProperty("member_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberDeviceId { get; set; }

        /// <summary>
        /// 负载均衡器中的后端服务器对应的弹性云服务器的IP地址。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_address&#x3D;xxx&amp;member_address&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_address", IsQuery = true)]
        [JsonProperty("member_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberAddress { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器所属的企业项目ID。 如果enterprise_project_id不传值，默认查询所有企业项目下的资源，鉴权按照细粒度权限鉴权，必须在用户组下分配elb:loadbalancers:list权限。 如果enterprise_project_id传值，鉴权按照企业项目权限鉴权，分为传入具体eps_id和all_granted_eps两种场景，前者查询指定eps_id的eps下的资源，后者查询的是所有有list权限的eps下的资源。  支持多值查询，查询条件格式： *enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:dt,hcso_dt)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// IP版本信息。  取值：4代表IPv4，6代表IPv6。  支持多值查询，查询条件格式：*ip_version&#x3D;xxx&amp;ip_version&#x3D;xxx*。  [不支持IPv6，请勿设置为6。](tag:dt)
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> IpVersion { get; set; }

        /// <summary>
        /// 是否开启删除保护，false不开启，true开启。[不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42)  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("deletion_protection_enable", IsQuery = true)]
        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        /// <summary>
        /// 下联面子网类型。  取值： - ipv4：ipv4。 - dualstack：双栈。  支持多值查询，查询条件格式： *elb_virsubnet_type&#x3D;ipv4&amp;elb_virsubnet_type&#x3D;dualstack*。
        /// </summary>
        [SDKProperty("elb_virsubnet_type", IsQuery = true)]
        [JsonProperty("elb_virsubnet_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetType { get; set; }

        /// <summary>
        /// 是否开启弹性扩缩容。示例如下： \&quot;autoscaling\&quot;: {             \&quot;enable\&quot;: \&quot;true\&quot;         }  支持多值查询，查询条件格式：  *autoscaling&#x3D;enable&#x3D;true&amp;autoscaling&#x3D;enable&#x3D;false*。  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42,hcso,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
        /// </summary>
        [SDKProperty("autoscaling", IsQuery = true)]
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Autoscaling { get; set; }

        /// <summary>
        /// 修改保护状态, 取值： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护
        /// </summary>
        [SDKProperty("protection_status", IsQuery = true)]
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProtectionStatus { get; set; }

        /// <summary>
        /// 负载均衡器绑定的公网IP。示例如下：  {     \&quot;global_eips\&quot;: [         {             \&quot;global_eip_id\&quot;: \&quot;24000000-0000-0000-0000-100000000001\&quot;,             \&quot;global_eip_address\&quot;: \&quot;10.10.10.10\&quot;,             \&quot;ip_version\&quot;: 4         }     ] }   支持多值查询，查询条件格式：  - global_eip_id作为查询条件：*global_eips&#x3D;global_eip_id&#x3D;xxx&amp;global_eips&#x3D;global_eip_id&#x3D;xxx*。  - global_eip_address作为查询条件：*global_eips&#x3D;global_eip_address&#x3D;xxx&amp;global_eips&#x3D;global_eip_address&#x3D;xxx*。  - ip_version作为查询条件：*global_eips&#x3D;ip_version&#x3D;xxx&amp;global_eips&#x3D;ip_version&#x3D;xxx*。
        /// </summary>
        [SDKProperty("global_eips", IsQuery = true)]
        [JsonProperty("global_eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GlobalEips { get; set; }

        /// <summary>
        /// LB实例绑定的logtank的topic id信息，支持多值查询，查询条件格式：*log_topic_id&#x3D;xxx&amp;log_topic_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("log_topic_id", IsQuery = true)]
        [JsonProperty("log_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicId { get; set; }

        /// <summary>
        /// LB实例绑定的logtank的group id信息，支持多值查询，查询条件格式：*log_group_id&#x3D;xxx&amp;log_group_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("log_group_id", IsQuery = true)]
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecycleBinLoadBalancersRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  ipv6VipPortId: ").Append(Ipv6VipPortId).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  eips: ").Append(Eips).Append("\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  memberDeviceId: ").Append(MemberDeviceId).Append("\n");
            sb.Append("  memberAddress: ").Append(MemberAddress).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  deletionProtectionEnable: ").Append(DeletionProtectionEnable).Append("\n");
            sb.Append("  elbVirsubnetType: ").Append(ElbVirsubnetType).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  globalEips: ").Append(GlobalEips).Append("\n");
            sb.Append("  logTopicId: ").Append(LogTopicId).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecycleBinLoadBalancersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecycleBinLoadBalancersRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.OperatingStatus != input.OperatingStatus || (this.OperatingStatus != null && input.OperatingStatus != null && !this.OperatingStatus.SequenceEqual(input.OperatingStatus))) return false;
            if (this.Guaranteed != input.Guaranteed || (this.Guaranteed != null && !this.Guaranteed.Equals(input.Guaranteed))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && input.VpcId != null && !this.VpcId.SequenceEqual(input.VpcId))) return false;
            if (this.VipPortId != input.VipPortId || (this.VipPortId != null && input.VipPortId != null && !this.VipPortId.SequenceEqual(input.VipPortId))) return false;
            if (this.VipAddress != input.VipAddress || (this.VipAddress != null && input.VipAddress != null && !this.VipAddress.SequenceEqual(input.VipAddress))) return false;
            if (this.VipSubnetCidrId != input.VipSubnetCidrId || (this.VipSubnetCidrId != null && input.VipSubnetCidrId != null && !this.VipSubnetCidrId.SequenceEqual(input.VipSubnetCidrId))) return false;
            if (this.Ipv6VipPortId != input.Ipv6VipPortId || (this.Ipv6VipPortId != null && input.Ipv6VipPortId != null && !this.Ipv6VipPortId.SequenceEqual(input.Ipv6VipPortId))) return false;
            if (this.Ipv6VipAddress != input.Ipv6VipAddress || (this.Ipv6VipAddress != null && input.Ipv6VipAddress != null && !this.Ipv6VipAddress.SequenceEqual(input.Ipv6VipAddress))) return false;
            if (this.Ipv6VipVirsubnetId != input.Ipv6VipVirsubnetId || (this.Ipv6VipVirsubnetId != null && input.Ipv6VipVirsubnetId != null && !this.Ipv6VipVirsubnetId.SequenceEqual(input.Ipv6VipVirsubnetId))) return false;
            if (this.Eips != input.Eips || (this.Eips != null && input.Eips != null && !this.Eips.SequenceEqual(input.Eips))) return false;
            if (this.Publicips != input.Publicips || (this.Publicips != null && input.Publicips != null && !this.Publicips.SequenceEqual(input.Publicips))) return false;
            if (this.AvailabilityZoneList != input.AvailabilityZoneList || (this.AvailabilityZoneList != null && input.AvailabilityZoneList != null && !this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList))) return false;
            if (this.L4FlavorId != input.L4FlavorId || (this.L4FlavorId != null && input.L4FlavorId != null && !this.L4FlavorId.SequenceEqual(input.L4FlavorId))) return false;
            if (this.L7FlavorId != input.L7FlavorId || (this.L7FlavorId != null && input.L7FlavorId != null && !this.L7FlavorId.SequenceEqual(input.L7FlavorId))) return false;
            if (this.BillingInfo != input.BillingInfo || (this.BillingInfo != null && input.BillingInfo != null && !this.BillingInfo.SequenceEqual(input.BillingInfo))) return false;
            if (this.MemberDeviceId != input.MemberDeviceId || (this.MemberDeviceId != null && input.MemberDeviceId != null && !this.MemberDeviceId.SequenceEqual(input.MemberDeviceId))) return false;
            if (this.MemberAddress != input.MemberAddress || (this.MemberAddress != null && input.MemberAddress != null && !this.MemberAddress.SequenceEqual(input.MemberAddress))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && input.IpVersion != null && !this.IpVersion.SequenceEqual(input.IpVersion))) return false;
            if (this.DeletionProtectionEnable != input.DeletionProtectionEnable || (this.DeletionProtectionEnable != null && !this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))) return false;
            if (this.ElbVirsubnetType != input.ElbVirsubnetType || (this.ElbVirsubnetType != null && input.ElbVirsubnetType != null && !this.ElbVirsubnetType.SequenceEqual(input.ElbVirsubnetType))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && input.Autoscaling != null && !this.Autoscaling.SequenceEqual(input.Autoscaling))) return false;
            if (this.ProtectionStatus != input.ProtectionStatus || (this.ProtectionStatus != null && input.ProtectionStatus != null && !this.ProtectionStatus.SequenceEqual(input.ProtectionStatus))) return false;
            if (this.GlobalEips != input.GlobalEips || (this.GlobalEips != null && input.GlobalEips != null && !this.GlobalEips.SequenceEqual(input.GlobalEips))) return false;
            if (this.LogTopicId != input.LogTopicId || (this.LogTopicId != null && !this.LogTopicId.Equals(input.LogTopicId))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.OperatingStatus != null) hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.Guaranteed != null) hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VipPortId != null) hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.VipAddress != null) hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.VipSubnetCidrId != null) hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.Ipv6VipPortId != null) hashCode = hashCode * 59 + this.Ipv6VipPortId.GetHashCode();
                if (this.Ipv6VipAddress != null) hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null) hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Eips != null) hashCode = hashCode * 59 + this.Eips.GetHashCode();
                if (this.Publicips != null) hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                if (this.AvailabilityZoneList != null) hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.L4FlavorId != null) hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L7FlavorId != null) hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.BillingInfo != null) hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.MemberDeviceId != null) hashCode = hashCode * 59 + this.MemberDeviceId.GetHashCode();
                if (this.MemberAddress != null) hashCode = hashCode * 59 + this.MemberAddress.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.DeletionProtectionEnable != null) hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.ElbVirsubnetType != null) hashCode = hashCode * 59 + this.ElbVirsubnetType.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.ProtectionStatus != null) hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.GlobalEips != null) hashCode = hashCode * 59 + this.GlobalEips.GetHashCode();
                if (this.LogTopicId != null) hashCode = hashCode * 59 + this.LogTopicId.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
