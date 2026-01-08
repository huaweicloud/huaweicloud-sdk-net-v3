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
    public class VpcQuotas 
    {

        /// <summary>
        /// **参数解释**： 网络ACL单方向规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("acl_policy_contain_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? AclPolicyContainRules { get; set; }

        /// <summary>
        /// **参数解释**： IP地址组数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("address_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressGroup { get; set; }

        /// <summary>
        /// **参数解释**： IP地址组包含的IP地址集数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("address_group_contain_ipset", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressGroupContainIpset { get; set; }

        /// <summary>
        /// **参数解释**： CloudDCN场景的网络ACL数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("clouddcn_firewall_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClouddcnFirewallGroup { get; set; }

        /// <summary>
        /// **参数解释**： CloudDCN场景的网络ACL单方向规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("clouddcn_acl_policy_contain_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClouddcnAclPolicyContainRules { get; set; }

        /// <summary>
        /// **参数解释**： 边缘网关数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("edge_gateway", NullValueHandling = NullValueHandling.Ignore)]
        public int? EdgeGateway { get; set; }

        /// <summary>
        /// **参数解释**： 弹性网卡关联的安全组数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("eni_contain_secgroup", NullValueHandling = NullValueHandling.Ignore)]
        public int? EniContainSecgroup { get; set; }

        /// <summary>
        /// **参数解释**： 网络ACL中配置了IP地址组或不连续端口的IPv4规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("firewall_policy_contain_ipv4_composite_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? FirewallPolicyContainIpv4CompositeRules { get; set; }

        /// <summary>
        /// **参数解释**： 网络ACL中配置了IP地址组或不连续端口的IPv6规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("firewall_policy_contain_ipv6_composite_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? FirewallPolicyContainIpv6CompositeRules { get; set; }

        /// <summary>
        /// **参数解释**： 云转发策略数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("forward_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForwardPolicy { get; set; }

        /// <summary>
        /// **参数解释**： 云转发策略关联端口数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("forward_policy_contain_ports", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForwardPolicyContainPorts { get; set; }

        /// <summary>
        /// **参数解释**： 云转发规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("forward_rule", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForwardRule { get; set; }

        /// <summary>
        /// **参数解释**： 对等连接数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("peering", NullValueHandling = NullValueHandling.Ignore)]
        public int? Peering { get; set; }

        /// <summary>
        /// **参数解释**： 一个physical_network下支持创建的roce网络数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("roce_cluster_contain_networks", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoceClusterContainNetworks { get; set; }

        /// <summary>
        /// **参数解释**： 路由表支持系统路由数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("rtb_allow_sys_cidr_routes", NullValueHandling = NullValueHandling.Ignore)]
        public int? RtbAllowSysCidrRoutes { get; set; }

        /// <summary>
        /// **参数解释**： 共享带宽组数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("shared_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? SharedBandwidth { get; set; }

        /// <summary>
        /// **参数解释**： 单个共享带宽关联的弹性公网IP数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("shared_bandwidth_contain_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public int? SharedBandwidthContainPublicip { get; set; }

        /// <summary>
        /// **参数解释**： 单个安全组包含的规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("secgroup_contain_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecgroupContainRules { get; set; }

        /// <summary>
        /// **参数解释**： 单个安全组关联的网卡数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("secgroup_referred_by_nic", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecgroupReferredByNic { get; set; }

        /// <summary>
        /// **参数解释**： 安全组数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("security_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityGroup { get; set; }

        /// <summary>
        /// **参数解释**： 安全组中配置了IP地址组、不连续端口或远端安全组的IPv4出方向规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("security_group_contain_egress_ipv4_composite_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityGroupContainEgressIpv4CompositeRules { get; set; }

        /// <summary>
        /// **参数解释**： 安全组中配置了IP地址组、不连续端口或远端安全组的IPv6出方向规则数配。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("security_group_contain_egress_ipv6_composite_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityGroupContainEgressIpv6CompositeRules { get; set; }

        /// <summary>
        /// **参数解释**： 安全组中配置了IP地址组、不连续端口或远端安全组的IPv4入方向规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("security_group_contain_ingress_ipv4_composite_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityGroupContainIngressIpv4CompositeRules { get; set; }

        /// <summary>
        /// **参数解释**： 安全组中配置了IP地址组、不连续端口或远端安全组的IPv6入方向规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("security_group_contain_ingress_ipv6_composite_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityGroupContainIngressIpv6CompositeRules { get; set; }

        /// <summary>
        /// **参数解释**： 安全组规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("security_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityGroupRule { get; set; }

        /// <summary>
        /// **参数解释**： 单个子网包含的弹性网卡数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("subnet_contain_eni", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubnetContainEni { get; set; }

        /// <summary>
        /// **参数解释**： 流量镜像筛选条件数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_filter", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorFilter { get; set; }

        /// <summary>
        /// **参数解释**： 单个流量镜像筛选条件被镜像会话引用数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_filter_referred_by_session", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorFilterReferredBySession { get; set; }

        /// <summary>
        /// **参数解释**： 流量镜像筛选条件单方向规则数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_filter_contain_rules_each_direction", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorFilterContainRulesEachDirection { get; set; }

        /// <summary>
        /// **参数解释**： 流量镜像会话数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_session", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorSession { get; set; }

        /// <summary>
        /// **参数解释**： 单个流量镜像会话关联的镜像源数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_session_contain_sources", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorSessionContainSources { get; set; }

        /// <summary>
        /// **参数解释**： 单个镜像源被流量镜像会话引用次数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_source_referred_by_session", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorSourceReferredBySession { get; set; }

        /// <summary>
        /// **参数解释**： 私网弹性负载均衡类型的镜像目的被会话引用次数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_target_elb_referred_by_session", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorTargetElbReferredBySession { get; set; }

        /// <summary>
        /// **参数解释**： 弹性网卡类型的镜像目的被会话引用次数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("traffic_mirror_target_eni_referred_by_session", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrafficMirrorTargetEniReferredBySession { get; set; }

        /// <summary>
        /// **参数解释**： 虚拟IP数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("vip", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vip { get; set; }

        /// <summary>
        /// **参数解释**： 子网数配额。 **取值范围**： 整数，-1表示此配额未上线，请通过[v1查询配额接口](vpc_quota_0001.xml)。
        /// </summary>
        [JsonProperty("virsubnet", NullValueHandling = NullValueHandling.Ignore)]
        public int? Virsubnet { get; set; }

        /// <summary>
        /// **参数解释**： 单子网包含IPv4子网预留网段数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("virsubnet_contain_ipv4_cidr_reservations", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirsubnetContainIpv4CidrReservations { get; set; }

        /// <summary>
        /// **参数解释**： 单子网包含IPv6子网预留网段数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("virsubnet_contain_ipv6_cidr_reservations", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirsubnetContainIpv6CidrReservations { get; set; }

        /// <summary>
        /// **参数解释**： VPC数配额。 **取值范围**： 整数，-1表示此配额未上线，请通过[v1查询配额接口](vpc_quota_0001.xml)。
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vpc { get; set; }

        /// <summary>
        /// **参数解释**： 单个VPC包含弹性网卡数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("vpc_contain_eni", NullValueHandling = NullValueHandling.Ignore)]
        public int? VpcContainEni { get; set; }

        /// <summary>
        /// **参数解释**： 单个VPC包含虚拟IP数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("vpc_contain_vip", NullValueHandling = NullValueHandling.Ignore)]
        public int? VpcContainVip { get; set; }

        /// <summary>
        /// **参数解释**： 单个VPC包含子网数配额。 **取值范围**： 整数，-1表示此配额未上线。
        /// </summary>
        [JsonProperty("vpc_contain_virsubnet", NullValueHandling = NullValueHandling.Ignore)]
        public int? VpcContainVirsubnet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpcQuotas {\n");
            sb.Append("  aclPolicyContainRules: ").Append(AclPolicyContainRules).Append("\n");
            sb.Append("  addressGroup: ").Append(AddressGroup).Append("\n");
            sb.Append("  addressGroupContainIpset: ").Append(AddressGroupContainIpset).Append("\n");
            sb.Append("  clouddcnFirewallGroup: ").Append(ClouddcnFirewallGroup).Append("\n");
            sb.Append("  clouddcnAclPolicyContainRules: ").Append(ClouddcnAclPolicyContainRules).Append("\n");
            sb.Append("  edgeGateway: ").Append(EdgeGateway).Append("\n");
            sb.Append("  eniContainSecgroup: ").Append(EniContainSecgroup).Append("\n");
            sb.Append("  firewallPolicyContainIpv4CompositeRules: ").Append(FirewallPolicyContainIpv4CompositeRules).Append("\n");
            sb.Append("  firewallPolicyContainIpv6CompositeRules: ").Append(FirewallPolicyContainIpv6CompositeRules).Append("\n");
            sb.Append("  forwardPolicy: ").Append(ForwardPolicy).Append("\n");
            sb.Append("  forwardPolicyContainPorts: ").Append(ForwardPolicyContainPorts).Append("\n");
            sb.Append("  forwardRule: ").Append(ForwardRule).Append("\n");
            sb.Append("  peering: ").Append(Peering).Append("\n");
            sb.Append("  roceClusterContainNetworks: ").Append(RoceClusterContainNetworks).Append("\n");
            sb.Append("  rtbAllowSysCidrRoutes: ").Append(RtbAllowSysCidrRoutes).Append("\n");
            sb.Append("  sharedBandwidth: ").Append(SharedBandwidth).Append("\n");
            sb.Append("  sharedBandwidthContainPublicip: ").Append(SharedBandwidthContainPublicip).Append("\n");
            sb.Append("  secgroupContainRules: ").Append(SecgroupContainRules).Append("\n");
            sb.Append("  secgroupReferredByNic: ").Append(SecgroupReferredByNic).Append("\n");
            sb.Append("  securityGroup: ").Append(SecurityGroup).Append("\n");
            sb.Append("  securityGroupContainEgressIpv4CompositeRules: ").Append(SecurityGroupContainEgressIpv4CompositeRules).Append("\n");
            sb.Append("  securityGroupContainEgressIpv6CompositeRules: ").Append(SecurityGroupContainEgressIpv6CompositeRules).Append("\n");
            sb.Append("  securityGroupContainIngressIpv4CompositeRules: ").Append(SecurityGroupContainIngressIpv4CompositeRules).Append("\n");
            sb.Append("  securityGroupContainIngressIpv6CompositeRules: ").Append(SecurityGroupContainIngressIpv6CompositeRules).Append("\n");
            sb.Append("  securityGroupRule: ").Append(SecurityGroupRule).Append("\n");
            sb.Append("  subnetContainEni: ").Append(SubnetContainEni).Append("\n");
            sb.Append("  trafficMirrorFilter: ").Append(TrafficMirrorFilter).Append("\n");
            sb.Append("  trafficMirrorFilterReferredBySession: ").Append(TrafficMirrorFilterReferredBySession).Append("\n");
            sb.Append("  trafficMirrorFilterContainRulesEachDirection: ").Append(TrafficMirrorFilterContainRulesEachDirection).Append("\n");
            sb.Append("  trafficMirrorSession: ").Append(TrafficMirrorSession).Append("\n");
            sb.Append("  trafficMirrorSessionContainSources: ").Append(TrafficMirrorSessionContainSources).Append("\n");
            sb.Append("  trafficMirrorSourceReferredBySession: ").Append(TrafficMirrorSourceReferredBySession).Append("\n");
            sb.Append("  trafficMirrorTargetElbReferredBySession: ").Append(TrafficMirrorTargetElbReferredBySession).Append("\n");
            sb.Append("  trafficMirrorTargetEniReferredBySession: ").Append(TrafficMirrorTargetEniReferredBySession).Append("\n");
            sb.Append("  vip: ").Append(Vip).Append("\n");
            sb.Append("  virsubnet: ").Append(Virsubnet).Append("\n");
            sb.Append("  virsubnetContainIpv4CidrReservations: ").Append(VirsubnetContainIpv4CidrReservations).Append("\n");
            sb.Append("  virsubnetContainIpv6CidrReservations: ").Append(VirsubnetContainIpv6CidrReservations).Append("\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  vpcContainEni: ").Append(VpcContainEni).Append("\n");
            sb.Append("  vpcContainVip: ").Append(VpcContainVip).Append("\n");
            sb.Append("  vpcContainVirsubnet: ").Append(VpcContainVirsubnet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpcQuotas);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VpcQuotas input)
        {
            if (input == null) return false;
            if (this.AclPolicyContainRules != input.AclPolicyContainRules || (this.AclPolicyContainRules != null && !this.AclPolicyContainRules.Equals(input.AclPolicyContainRules))) return false;
            if (this.AddressGroup != input.AddressGroup || (this.AddressGroup != null && !this.AddressGroup.Equals(input.AddressGroup))) return false;
            if (this.AddressGroupContainIpset != input.AddressGroupContainIpset || (this.AddressGroupContainIpset != null && !this.AddressGroupContainIpset.Equals(input.AddressGroupContainIpset))) return false;
            if (this.ClouddcnFirewallGroup != input.ClouddcnFirewallGroup || (this.ClouddcnFirewallGroup != null && !this.ClouddcnFirewallGroup.Equals(input.ClouddcnFirewallGroup))) return false;
            if (this.ClouddcnAclPolicyContainRules != input.ClouddcnAclPolicyContainRules || (this.ClouddcnAclPolicyContainRules != null && !this.ClouddcnAclPolicyContainRules.Equals(input.ClouddcnAclPolicyContainRules))) return false;
            if (this.EdgeGateway != input.EdgeGateway || (this.EdgeGateway != null && !this.EdgeGateway.Equals(input.EdgeGateway))) return false;
            if (this.EniContainSecgroup != input.EniContainSecgroup || (this.EniContainSecgroup != null && !this.EniContainSecgroup.Equals(input.EniContainSecgroup))) return false;
            if (this.FirewallPolicyContainIpv4CompositeRules != input.FirewallPolicyContainIpv4CompositeRules || (this.FirewallPolicyContainIpv4CompositeRules != null && !this.FirewallPolicyContainIpv4CompositeRules.Equals(input.FirewallPolicyContainIpv4CompositeRules))) return false;
            if (this.FirewallPolicyContainIpv6CompositeRules != input.FirewallPolicyContainIpv6CompositeRules || (this.FirewallPolicyContainIpv6CompositeRules != null && !this.FirewallPolicyContainIpv6CompositeRules.Equals(input.FirewallPolicyContainIpv6CompositeRules))) return false;
            if (this.ForwardPolicy != input.ForwardPolicy || (this.ForwardPolicy != null && !this.ForwardPolicy.Equals(input.ForwardPolicy))) return false;
            if (this.ForwardPolicyContainPorts != input.ForwardPolicyContainPorts || (this.ForwardPolicyContainPorts != null && !this.ForwardPolicyContainPorts.Equals(input.ForwardPolicyContainPorts))) return false;
            if (this.ForwardRule != input.ForwardRule || (this.ForwardRule != null && !this.ForwardRule.Equals(input.ForwardRule))) return false;
            if (this.Peering != input.Peering || (this.Peering != null && !this.Peering.Equals(input.Peering))) return false;
            if (this.RoceClusterContainNetworks != input.RoceClusterContainNetworks || (this.RoceClusterContainNetworks != null && !this.RoceClusterContainNetworks.Equals(input.RoceClusterContainNetworks))) return false;
            if (this.RtbAllowSysCidrRoutes != input.RtbAllowSysCidrRoutes || (this.RtbAllowSysCidrRoutes != null && !this.RtbAllowSysCidrRoutes.Equals(input.RtbAllowSysCidrRoutes))) return false;
            if (this.SharedBandwidth != input.SharedBandwidth || (this.SharedBandwidth != null && !this.SharedBandwidth.Equals(input.SharedBandwidth))) return false;
            if (this.SharedBandwidthContainPublicip != input.SharedBandwidthContainPublicip || (this.SharedBandwidthContainPublicip != null && !this.SharedBandwidthContainPublicip.Equals(input.SharedBandwidthContainPublicip))) return false;
            if (this.SecgroupContainRules != input.SecgroupContainRules || (this.SecgroupContainRules != null && !this.SecgroupContainRules.Equals(input.SecgroupContainRules))) return false;
            if (this.SecgroupReferredByNic != input.SecgroupReferredByNic || (this.SecgroupReferredByNic != null && !this.SecgroupReferredByNic.Equals(input.SecgroupReferredByNic))) return false;
            if (this.SecurityGroup != input.SecurityGroup || (this.SecurityGroup != null && !this.SecurityGroup.Equals(input.SecurityGroup))) return false;
            if (this.SecurityGroupContainEgressIpv4CompositeRules != input.SecurityGroupContainEgressIpv4CompositeRules || (this.SecurityGroupContainEgressIpv4CompositeRules != null && !this.SecurityGroupContainEgressIpv4CompositeRules.Equals(input.SecurityGroupContainEgressIpv4CompositeRules))) return false;
            if (this.SecurityGroupContainEgressIpv6CompositeRules != input.SecurityGroupContainEgressIpv6CompositeRules || (this.SecurityGroupContainEgressIpv6CompositeRules != null && !this.SecurityGroupContainEgressIpv6CompositeRules.Equals(input.SecurityGroupContainEgressIpv6CompositeRules))) return false;
            if (this.SecurityGroupContainIngressIpv4CompositeRules != input.SecurityGroupContainIngressIpv4CompositeRules || (this.SecurityGroupContainIngressIpv4CompositeRules != null && !this.SecurityGroupContainIngressIpv4CompositeRules.Equals(input.SecurityGroupContainIngressIpv4CompositeRules))) return false;
            if (this.SecurityGroupContainIngressIpv6CompositeRules != input.SecurityGroupContainIngressIpv6CompositeRules || (this.SecurityGroupContainIngressIpv6CompositeRules != null && !this.SecurityGroupContainIngressIpv6CompositeRules.Equals(input.SecurityGroupContainIngressIpv6CompositeRules))) return false;
            if (this.SecurityGroupRule != input.SecurityGroupRule || (this.SecurityGroupRule != null && !this.SecurityGroupRule.Equals(input.SecurityGroupRule))) return false;
            if (this.SubnetContainEni != input.SubnetContainEni || (this.SubnetContainEni != null && !this.SubnetContainEni.Equals(input.SubnetContainEni))) return false;
            if (this.TrafficMirrorFilter != input.TrafficMirrorFilter || (this.TrafficMirrorFilter != null && !this.TrafficMirrorFilter.Equals(input.TrafficMirrorFilter))) return false;
            if (this.TrafficMirrorFilterReferredBySession != input.TrafficMirrorFilterReferredBySession || (this.TrafficMirrorFilterReferredBySession != null && !this.TrafficMirrorFilterReferredBySession.Equals(input.TrafficMirrorFilterReferredBySession))) return false;
            if (this.TrafficMirrorFilterContainRulesEachDirection != input.TrafficMirrorFilterContainRulesEachDirection || (this.TrafficMirrorFilterContainRulesEachDirection != null && !this.TrafficMirrorFilterContainRulesEachDirection.Equals(input.TrafficMirrorFilterContainRulesEachDirection))) return false;
            if (this.TrafficMirrorSession != input.TrafficMirrorSession || (this.TrafficMirrorSession != null && !this.TrafficMirrorSession.Equals(input.TrafficMirrorSession))) return false;
            if (this.TrafficMirrorSessionContainSources != input.TrafficMirrorSessionContainSources || (this.TrafficMirrorSessionContainSources != null && !this.TrafficMirrorSessionContainSources.Equals(input.TrafficMirrorSessionContainSources))) return false;
            if (this.TrafficMirrorSourceReferredBySession != input.TrafficMirrorSourceReferredBySession || (this.TrafficMirrorSourceReferredBySession != null && !this.TrafficMirrorSourceReferredBySession.Equals(input.TrafficMirrorSourceReferredBySession))) return false;
            if (this.TrafficMirrorTargetElbReferredBySession != input.TrafficMirrorTargetElbReferredBySession || (this.TrafficMirrorTargetElbReferredBySession != null && !this.TrafficMirrorTargetElbReferredBySession.Equals(input.TrafficMirrorTargetElbReferredBySession))) return false;
            if (this.TrafficMirrorTargetEniReferredBySession != input.TrafficMirrorTargetEniReferredBySession || (this.TrafficMirrorTargetEniReferredBySession != null && !this.TrafficMirrorTargetEniReferredBySession.Equals(input.TrafficMirrorTargetEniReferredBySession))) return false;
            if (this.Vip != input.Vip || (this.Vip != null && !this.Vip.Equals(input.Vip))) return false;
            if (this.Virsubnet != input.Virsubnet || (this.Virsubnet != null && !this.Virsubnet.Equals(input.Virsubnet))) return false;
            if (this.VirsubnetContainIpv4CidrReservations != input.VirsubnetContainIpv4CidrReservations || (this.VirsubnetContainIpv4CidrReservations != null && !this.VirsubnetContainIpv4CidrReservations.Equals(input.VirsubnetContainIpv4CidrReservations))) return false;
            if (this.VirsubnetContainIpv6CidrReservations != input.VirsubnetContainIpv6CidrReservations || (this.VirsubnetContainIpv6CidrReservations != null && !this.VirsubnetContainIpv6CidrReservations.Equals(input.VirsubnetContainIpv6CidrReservations))) return false;
            if (this.Vpc != input.Vpc || (this.Vpc != null && !this.Vpc.Equals(input.Vpc))) return false;
            if (this.VpcContainEni != input.VpcContainEni || (this.VpcContainEni != null && !this.VpcContainEni.Equals(input.VpcContainEni))) return false;
            if (this.VpcContainVip != input.VpcContainVip || (this.VpcContainVip != null && !this.VpcContainVip.Equals(input.VpcContainVip))) return false;
            if (this.VpcContainVirsubnet != input.VpcContainVirsubnet || (this.VpcContainVirsubnet != null && !this.VpcContainVirsubnet.Equals(input.VpcContainVirsubnet))) return false;

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
                if (this.AclPolicyContainRules != null) hashCode = hashCode * 59 + this.AclPolicyContainRules.GetHashCode();
                if (this.AddressGroup != null) hashCode = hashCode * 59 + this.AddressGroup.GetHashCode();
                if (this.AddressGroupContainIpset != null) hashCode = hashCode * 59 + this.AddressGroupContainIpset.GetHashCode();
                if (this.ClouddcnFirewallGroup != null) hashCode = hashCode * 59 + this.ClouddcnFirewallGroup.GetHashCode();
                if (this.ClouddcnAclPolicyContainRules != null) hashCode = hashCode * 59 + this.ClouddcnAclPolicyContainRules.GetHashCode();
                if (this.EdgeGateway != null) hashCode = hashCode * 59 + this.EdgeGateway.GetHashCode();
                if (this.EniContainSecgroup != null) hashCode = hashCode * 59 + this.EniContainSecgroup.GetHashCode();
                if (this.FirewallPolicyContainIpv4CompositeRules != null) hashCode = hashCode * 59 + this.FirewallPolicyContainIpv4CompositeRules.GetHashCode();
                if (this.FirewallPolicyContainIpv6CompositeRules != null) hashCode = hashCode * 59 + this.FirewallPolicyContainIpv6CompositeRules.GetHashCode();
                if (this.ForwardPolicy != null) hashCode = hashCode * 59 + this.ForwardPolicy.GetHashCode();
                if (this.ForwardPolicyContainPorts != null) hashCode = hashCode * 59 + this.ForwardPolicyContainPorts.GetHashCode();
                if (this.ForwardRule != null) hashCode = hashCode * 59 + this.ForwardRule.GetHashCode();
                if (this.Peering != null) hashCode = hashCode * 59 + this.Peering.GetHashCode();
                if (this.RoceClusterContainNetworks != null) hashCode = hashCode * 59 + this.RoceClusterContainNetworks.GetHashCode();
                if (this.RtbAllowSysCidrRoutes != null) hashCode = hashCode * 59 + this.RtbAllowSysCidrRoutes.GetHashCode();
                if (this.SharedBandwidth != null) hashCode = hashCode * 59 + this.SharedBandwidth.GetHashCode();
                if (this.SharedBandwidthContainPublicip != null) hashCode = hashCode * 59 + this.SharedBandwidthContainPublicip.GetHashCode();
                if (this.SecgroupContainRules != null) hashCode = hashCode * 59 + this.SecgroupContainRules.GetHashCode();
                if (this.SecgroupReferredByNic != null) hashCode = hashCode * 59 + this.SecgroupReferredByNic.GetHashCode();
                if (this.SecurityGroup != null) hashCode = hashCode * 59 + this.SecurityGroup.GetHashCode();
                if (this.SecurityGroupContainEgressIpv4CompositeRules != null) hashCode = hashCode * 59 + this.SecurityGroupContainEgressIpv4CompositeRules.GetHashCode();
                if (this.SecurityGroupContainEgressIpv6CompositeRules != null) hashCode = hashCode * 59 + this.SecurityGroupContainEgressIpv6CompositeRules.GetHashCode();
                if (this.SecurityGroupContainIngressIpv4CompositeRules != null) hashCode = hashCode * 59 + this.SecurityGroupContainIngressIpv4CompositeRules.GetHashCode();
                if (this.SecurityGroupContainIngressIpv6CompositeRules != null) hashCode = hashCode * 59 + this.SecurityGroupContainIngressIpv6CompositeRules.GetHashCode();
                if (this.SecurityGroupRule != null) hashCode = hashCode * 59 + this.SecurityGroupRule.GetHashCode();
                if (this.SubnetContainEni != null) hashCode = hashCode * 59 + this.SubnetContainEni.GetHashCode();
                if (this.TrafficMirrorFilter != null) hashCode = hashCode * 59 + this.TrafficMirrorFilter.GetHashCode();
                if (this.TrafficMirrorFilterReferredBySession != null) hashCode = hashCode * 59 + this.TrafficMirrorFilterReferredBySession.GetHashCode();
                if (this.TrafficMirrorFilterContainRulesEachDirection != null) hashCode = hashCode * 59 + this.TrafficMirrorFilterContainRulesEachDirection.GetHashCode();
                if (this.TrafficMirrorSession != null) hashCode = hashCode * 59 + this.TrafficMirrorSession.GetHashCode();
                if (this.TrafficMirrorSessionContainSources != null) hashCode = hashCode * 59 + this.TrafficMirrorSessionContainSources.GetHashCode();
                if (this.TrafficMirrorSourceReferredBySession != null) hashCode = hashCode * 59 + this.TrafficMirrorSourceReferredBySession.GetHashCode();
                if (this.TrafficMirrorTargetElbReferredBySession != null) hashCode = hashCode * 59 + this.TrafficMirrorTargetElbReferredBySession.GetHashCode();
                if (this.TrafficMirrorTargetEniReferredBySession != null) hashCode = hashCode * 59 + this.TrafficMirrorTargetEniReferredBySession.GetHashCode();
                if (this.Vip != null) hashCode = hashCode * 59 + this.Vip.GetHashCode();
                if (this.Virsubnet != null) hashCode = hashCode * 59 + this.Virsubnet.GetHashCode();
                if (this.VirsubnetContainIpv4CidrReservations != null) hashCode = hashCode * 59 + this.VirsubnetContainIpv4CidrReservations.GetHashCode();
                if (this.VirsubnetContainIpv6CidrReservations != null) hashCode = hashCode * 59 + this.VirsubnetContainIpv6CidrReservations.GetHashCode();
                if (this.Vpc != null) hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.VpcContainEni != null) hashCode = hashCode * 59 + this.VpcContainEni.GetHashCode();
                if (this.VpcContainVip != null) hashCode = hashCode * 59 + this.VpcContainVip.GetHashCode();
                if (this.VpcContainVirsubnet != null) hashCode = hashCode * 59 + this.VpcContainVirsubnet.GetHashCode();
                return hashCode;
            }
        }
    }
}
