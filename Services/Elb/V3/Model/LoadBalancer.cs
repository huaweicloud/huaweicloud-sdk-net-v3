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
    /// 负载均衡器的详细信息。
    /// </summary>
    public class LoadBalancer 
    {
        /// <summary>
        /// 下联面子网类型 - ipv4：ipv4 - dualstack：双栈
        /// </summary>
        /// <value>下联面子网类型 - ipv4：ipv4 - dualstack：双栈</value>
        [JsonConverter(typeof(EnumClassConverter<ElbVirsubnetTypeEnum>))]
        public class ElbVirsubnetTypeEnum
        {
            /// <summary>
            /// Enum IPV4 for value: ipv4
            /// </summary>
            public static readonly ElbVirsubnetTypeEnum IPV4 = new ElbVirsubnetTypeEnum("ipv4");

            /// <summary>
            /// Enum DUALSTACK for value: dualstack
            /// </summary>
            public static readonly ElbVirsubnetTypeEnum DUALSTACK = new ElbVirsubnetTypeEnum("dualstack");

            private static readonly Dictionary<string, ElbVirsubnetTypeEnum> StaticFields =
            new Dictionary<string, ElbVirsubnetTypeEnum>()
            {
                { "ipv4", IPV4 },
                { "dualstack", DUALSTACK },
            };

            private string Value;

            public ElbVirsubnetTypeEnum(string value)
            {
                Value = value;
            }

            public static ElbVirsubnetTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as ElbVirsubnetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ElbVirsubnetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ElbVirsubnetTypeEnum a, ElbVirsubnetTypeEnum b)
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

            public static bool operator !=(ElbVirsubnetTypeEnum a, ElbVirsubnetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 负载均衡器ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 负载均衡器描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 负载均衡器的配置状态。取值： - ACTIVE：使用中。 - PENDING_DELETE：删除中。
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// 负载均衡器的管理状态。固定为true。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 负载均衡器的生产者名称。固定为vlb。
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 负载均衡器直接关联的后端云服务器组的ID列表。
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolRef> Pools { get; set; }

        /// <summary>
        /// 负载均衡器关联的监听器的ID列表。
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListenerRef> Listeners { get; set; }

        /// <summary>
        /// 负载均衡器的操作状态。取值： - ONLINE：在线。
        /// </summary>
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatingStatus { get; set; }

        /// <summary>
        /// 负载均衡器的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 负载均衡器所属的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 负载均衡器所在子网的IPv4子网ID。
        /// </summary>
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetCidrId { get; set; }

        /// <summary>
        /// 负载均衡器的IPv4虚拟IP地址。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// 负载均衡器的IPv4对应的port ID。[创建弹性负载均衡时，会自动为负载均衡创建一个port并关联一个默认的安全组，这个安全组对所有流量不生效。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipPortId { get; set; }

        /// <summary>
        /// 负载均衡的标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 负载均衡器的创建时间。格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 负载均衡器的更新时间。格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 是否独享型LB，取值： - false：共享型。 - true：独享型。
        /// </summary>
        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }

        /// <summary>
        /// 负载均衡器所在VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 负载均衡器绑定的EIP。只支持绑定一个EIP。  注：该字段与publicips一致。
        /// </summary>
        [JsonProperty("eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<EipInfo> Eips { get; set; }

        /// <summary>
        /// 双栈类型负载均衡器的IPv6地址。 [ 不支持IPv6，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }

        /// <summary>
        /// 双栈类型负载均衡器所在子网的IPv6网络ID。 [ 不支持IPv6，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// 双栈类型负载均衡器的IPv6对应的port ID。 [ 不支持IPv6，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("ipv6_vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipPortId { get; set; }

        /// <summary>
        /// 负载均衡器所在的可用区列表。
        /// </summary>
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// 企业项目ID。创建时不传则返回\&quot;0\&quot;，表示资源属于default企业项目。  注：\&quot;0\&quot;并不是真实存在的企业项目ID，在创建、更新和查询时不能作为请求参数传入。  [不支持该字段，请勿使用](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 四层Flavor ID。  对于弹性扩缩容实例，表示上限规格。  [hsco场景下所有LB实例共享带宽，该字段无效，请勿使用。](tag:hcso)
        /// </summary>
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        /// <summary>
        /// 四层弹性Flavor ID。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("l4_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4ScaleFlavorId { get; set; }

        /// <summary>
        /// 七层Flavor ID。 对于弹性扩缩容实例，表示上限规格ID。  [hsco场景下所有LB实例共享带宽，该字段无效，请勿使用。](tag:hcso)
        /// </summary>
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// 七层弹性Flavor ID。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("l7_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7ScaleFlavorId { get; set; }

        /// <summary>
        /// 负载均衡器绑定的公网IP。只支持绑定一个公网IP。  注：该字段与eips一致。
        /// </summary>
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpInfo> Publicips { get; set; }

        /// <summary>
        /// 负载均衡器绑定的global eip。只支持绑定一个global eip。
        /// </summary>
        [JsonProperty("global_eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<GlobalEipInfo> GlobalEips { get; set; }

        /// <summary>
        /// 下联面子网的网络ID列表。
        /// </summary>
        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }

        /// <summary>
        /// 下联面子网类型 - ipv4：ipv4 - dualstack：双栈
        /// </summary>
        [JsonProperty("elb_virsubnet_type", NullValueHandling = NullValueHandling.Ignore)]
        public ElbVirsubnetTypeEnum ElbVirsubnetType { get; set; }
        /// <summary>
        /// 是否启用跨VPC后端转发。取值： - true：开启、 - false：不开启。  仅独享型负载均衡器支持该特性。  开启跨VPC后端转发后，后端服务器组不仅支持添加云上VPC内的服务器，还支持添加其他VPC、其他公有云、云下数据中心的服务器。 [ 不支持该字段，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// 负载均衡器的冻结场景。若负载均衡器有多个冻结场景，用逗号分隔。取值： - POLICE：公安冻结场景。 - ILLEGAL：违规冻结场景。 - VERIFY：客户未实名认证冻结场景。 - RTNER：合作伙伴冻结（合作伙伴冻结子客户资源）。 - REAR：欠费冻结场景。  [不支持该字段，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("frozen_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenScene { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipv6_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthRef Ipv6Bandwidth { get; set; }

        /// <summary>
        /// 是否开启删除保护，取值： - false：不开启。 - true：开启。 &gt;退场时需要先关闭所有资源的删除保护开关。  仅当前局点启用删除保护特性后才会返回该字段。
        /// </summary>
        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public AutoscalingRef Autoscaling { get; set; }

        /// <summary>
        /// LB所属AZ组
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// WAF故障时的流量处理策略。discard:丢弃，forward: 转发到后端（默认）   使用说明：只有绑定了waf的LB实例，该字段才会生效。
        /// </summary>
        [JsonProperty("waf_failure_action", NullValueHandling = NullValueHandling.Ignore)]
        public string WafFailureAction { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadBalancer {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  pools: ").Append(Pools).Append("\n");
            sb.Append("  listeners: ").Append(Listeners).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  eips: ").Append(Eips).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  ipv6VipPortId: ").Append(Ipv6VipPortId).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l4ScaleFlavorId: ").Append(L4ScaleFlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  l7ScaleFlavorId: ").Append(L7ScaleFlavorId).Append("\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("  globalEips: ").Append(GlobalEips).Append("\n");
            sb.Append("  elbVirsubnetIds: ").Append(ElbVirsubnetIds).Append("\n");
            sb.Append("  elbVirsubnetType: ").Append(ElbVirsubnetType).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  frozenScene: ").Append(FrozenScene).Append("\n");
            sb.Append("  ipv6Bandwidth: ").Append(Ipv6Bandwidth).Append("\n");
            sb.Append("  deletionProtectionEnable: ").Append(DeletionProtectionEnable).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  wafFailureAction: ").Append(WafFailureAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadBalancer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadBalancer input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Pools == input.Pools ||
                    this.Pools != null &&
                    input.Pools != null &&
                    this.Pools.SequenceEqual(input.Pools)
                ) && 
                (
                    this.Listeners == input.Listeners ||
                    this.Listeners != null &&
                    input.Listeners != null &&
                    this.Listeners.SequenceEqual(input.Listeners)
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    (this.OperatingStatus != null &&
                    this.OperatingStatus.Equals(input.OperatingStatus))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.VipSubnetCidrId == input.VipSubnetCidrId ||
                    (this.VipSubnetCidrId != null &&
                    this.VipSubnetCidrId.Equals(input.VipSubnetCidrId))
                ) && 
                (
                    this.VipAddress == input.VipAddress ||
                    (this.VipAddress != null &&
                    this.VipAddress.Equals(input.VipAddress))
                ) && 
                (
                    this.VipPortId == input.VipPortId ||
                    (this.VipPortId != null &&
                    this.VipPortId.Equals(input.VipPortId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Guaranteed == input.Guaranteed ||
                    (this.Guaranteed != null &&
                    this.Guaranteed.Equals(input.Guaranteed))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Eips == input.Eips ||
                    this.Eips != null &&
                    input.Eips != null &&
                    this.Eips.SequenceEqual(input.Eips)
                ) && 
                (
                    this.Ipv6VipAddress == input.Ipv6VipAddress ||
                    (this.Ipv6VipAddress != null &&
                    this.Ipv6VipAddress.Equals(input.Ipv6VipAddress))
                ) && 
                (
                    this.Ipv6VipVirsubnetId == input.Ipv6VipVirsubnetId ||
                    (this.Ipv6VipVirsubnetId != null &&
                    this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))
                ) && 
                (
                    this.Ipv6VipPortId == input.Ipv6VipPortId ||
                    (this.Ipv6VipPortId != null &&
                    this.Ipv6VipPortId.Equals(input.Ipv6VipPortId))
                ) && 
                (
                    this.AvailabilityZoneList == input.AvailabilityZoneList ||
                    this.AvailabilityZoneList != null &&
                    input.AvailabilityZoneList != null &&
                    this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.L4FlavorId == input.L4FlavorId ||
                    (this.L4FlavorId != null &&
                    this.L4FlavorId.Equals(input.L4FlavorId))
                ) && 
                (
                    this.L4ScaleFlavorId == input.L4ScaleFlavorId ||
                    (this.L4ScaleFlavorId != null &&
                    this.L4ScaleFlavorId.Equals(input.L4ScaleFlavorId))
                ) && 
                (
                    this.L7FlavorId == input.L7FlavorId ||
                    (this.L7FlavorId != null &&
                    this.L7FlavorId.Equals(input.L7FlavorId))
                ) && 
                (
                    this.L7ScaleFlavorId == input.L7ScaleFlavorId ||
                    (this.L7ScaleFlavorId != null &&
                    this.L7ScaleFlavorId.Equals(input.L7ScaleFlavorId))
                ) && 
                (
                    this.Publicips == input.Publicips ||
                    this.Publicips != null &&
                    input.Publicips != null &&
                    this.Publicips.SequenceEqual(input.Publicips)
                ) && 
                (
                    this.GlobalEips == input.GlobalEips ||
                    this.GlobalEips != null &&
                    input.GlobalEips != null &&
                    this.GlobalEips.SequenceEqual(input.GlobalEips)
                ) && 
                (
                    this.ElbVirsubnetIds == input.ElbVirsubnetIds ||
                    this.ElbVirsubnetIds != null &&
                    input.ElbVirsubnetIds != null &&
                    this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds)
                ) && 
                (
                    this.ElbVirsubnetType == input.ElbVirsubnetType ||
                    (this.ElbVirsubnetType != null &&
                    this.ElbVirsubnetType.Equals(input.ElbVirsubnetType))
                ) && 
                (
                    this.IpTargetEnable == input.IpTargetEnable ||
                    (this.IpTargetEnable != null &&
                    this.IpTargetEnable.Equals(input.IpTargetEnable))
                ) && 
                (
                    this.FrozenScene == input.FrozenScene ||
                    (this.FrozenScene != null &&
                    this.FrozenScene.Equals(input.FrozenScene))
                ) && 
                (
                    this.Ipv6Bandwidth == input.Ipv6Bandwidth ||
                    (this.Ipv6Bandwidth != null &&
                    this.Ipv6Bandwidth.Equals(input.Ipv6Bandwidth))
                ) && 
                (
                    this.DeletionProtectionEnable == input.DeletionProtectionEnable ||
                    (this.DeletionProtectionEnable != null &&
                    this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))
                ) && 
                (
                    this.Autoscaling == input.Autoscaling ||
                    (this.Autoscaling != null &&
                    this.Autoscaling.Equals(input.Autoscaling))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
                ) && 
                (
                    this.WafFailureAction == input.WafFailureAction ||
                    (this.WafFailureAction != null &&
                    this.WafFailureAction.Equals(input.WafFailureAction))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Pools != null)
                    hashCode = hashCode * 59 + this.Pools.GetHashCode();
                if (this.Listeners != null)
                    hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.VipSubnetCidrId != null)
                    hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.VipAddress != null)
                    hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.VipPortId != null)
                    hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Guaranteed != null)
                    hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Eips != null)
                    hashCode = hashCode * 59 + this.Eips.GetHashCode();
                if (this.Ipv6VipAddress != null)
                    hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null)
                    hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Ipv6VipPortId != null)
                    hashCode = hashCode * 59 + this.Ipv6VipPortId.GetHashCode();
                if (this.AvailabilityZoneList != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.L4FlavorId != null)
                    hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L4ScaleFlavorId != null)
                    hashCode = hashCode * 59 + this.L4ScaleFlavorId.GetHashCode();
                if (this.L7FlavorId != null)
                    hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.L7ScaleFlavorId != null)
                    hashCode = hashCode * 59 + this.L7ScaleFlavorId.GetHashCode();
                if (this.Publicips != null)
                    hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                if (this.GlobalEips != null)
                    hashCode = hashCode * 59 + this.GlobalEips.GetHashCode();
                if (this.ElbVirsubnetIds != null)
                    hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                if (this.ElbVirsubnetType != null)
                    hashCode = hashCode * 59 + this.ElbVirsubnetType.GetHashCode();
                if (this.IpTargetEnable != null)
                    hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.FrozenScene != null)
                    hashCode = hashCode * 59 + this.FrozenScene.GetHashCode();
                if (this.Ipv6Bandwidth != null)
                    hashCode = hashCode * 59 + this.Ipv6Bandwidth.GetHashCode();
                if (this.DeletionProtectionEnable != null)
                    hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.Autoscaling != null)
                    hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.WafFailureAction != null)
                    hashCode = hashCode * 59 + this.WafFailureAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
