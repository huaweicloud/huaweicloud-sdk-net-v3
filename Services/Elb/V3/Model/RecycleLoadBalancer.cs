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
    public class RecycleLoadBalancer 
    {
        /// <summary>
        /// 参数解释：下联面子网类型。  取值范围： - ipv4：ipv4 - dualstack：双栈
        /// </summary>
        /// <value>参数解释：下联面子网类型。  取值范围： - ipv4：ipv4 - dualstack：双栈</value>
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

            private string _value;

            public ElbVirsubnetTypeEnum()
            {

            }

            public ElbVirsubnetTypeEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 参数解释：修改保护状态。  取值范围： - nonProtection: 不保护。 - consoleProtection: 控制台修改保护。  默认取值：nonProtection
        /// </summary>
        /// <value>参数解释：修改保护状态。  取值范围： - nonProtection: 不保护。 - consoleProtection: 控制台修改保护。  默认取值：nonProtection</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectionStatusEnum>))]
        public class ProtectionStatusEnum
        {
            /// <summary>
            /// Enum NONPROTECTION for value: nonProtection
            /// </summary>
            public static readonly ProtectionStatusEnum NONPROTECTION = new ProtectionStatusEnum("nonProtection");

            /// <summary>
            /// Enum CONSOLEPROTECTION for value: consoleProtection
            /// </summary>
            public static readonly ProtectionStatusEnum CONSOLEPROTECTION = new ProtectionStatusEnum("consoleProtection");

            private static readonly Dictionary<string, ProtectionStatusEnum> StaticFields =
            new Dictionary<string, ProtectionStatusEnum>()
            {
                { "nonProtection", NONPROTECTION },
                { "consoleProtection", CONSOLEPROTECTION },
            };

            private string _value;

            public ProtectionStatusEnum()
            {

            }

            public ProtectionStatusEnum(string value)
            {
                _value = value;
            }

            public static ProtectionStatusEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as ProtectionStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectionStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectionStatusEnum a, ProtectionStatusEnum b)
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

            public static bool operator !=(ProtectionStatusEnum a, ProtectionStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数解释：负载均衡器ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 回收站elb的自动到期销毁时间。格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("auto_terminate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoTerminateTime { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的配置状态。  取值范围： - RECYCLING：处于回收站用中。
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的启用状态。  取值范围： - true ：启用。 - false：停用。  [不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的生产者名称。固定为vlb。
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器直接关联的后端服务器组的ID列表。
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolRef> Pools { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器关联的监听器的ID列表。
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListenerRef> Listeners { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的操作状态。  取值范围： - ONLINE：在线。 - FROZEN：已冻结。
        /// </summary>
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatingStatus { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器所属的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器所在子网的IPv4子网ID，也称为该负载均衡器实例的前端子网。
        /// </summary>
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetCidrId { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的IPv4虚拟IP地址。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的IPv4对应的port ID。 [创建弹性负载均衡时，会自动为负载均衡创建一个port并关联一个默认的安全组，这个安全组对所有流量不生效。 ](tag:dt,hcso_dt)
        /// </summary>
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipPortId { get; set; }

        /// <summary>
        /// 参数解释：负载均衡的标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的创建时间。  取值范围： 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的更新时间。  取值范围; 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 参数解释：是否独享型LB。  取值范围： - false：共享型。 - true：独享型。
        /// </summary>
        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器所在VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器绑定的EIP。  约束限制：只支持绑定一个EIP。  注：该字段与publicips一致。
        /// </summary>
        [JsonProperty("eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<EipInfo> Eips { get; set; }

        /// <summary>
        /// 参数解释：双栈类型负载均衡器的IPv6地址。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }

        /// <summary>
        /// 参数解释：双栈类型负载均衡器所在子网的IPv6网络ID，也称为该负载均衡器实例的前端子网。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// 参数解释：双栈类型负载均衡器的IPv6对应的port ID。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipPortId { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器所在的可用区列表。
        /// </summary>
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// 参数解释：企业项目ID。创建时不传则返回\&quot;0\&quot;，表示资源属于default企业项目。  注意：\&quot;0\&quot;并不是真实存在的企业项目ID，在创建、更新和查询时不能作为请求参数传入。  [不支持该字段，请勿使用](tag:dt,hcso_dt)
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 参数解释：资源账单信息。  取值范围： - 空：按需计费。 [- 非空：包周期计费，  包周期计费billing_info字段的格式为：order_id:product_id:region_id:project_id，如：  CS2107161019CDJZZ:OFFI569702121789763584: az:057ef081eb00d2732fd1c01a9be75e6f  不支持该字段，请勿使用](tag:hws_eu,g42,hk_g42,dt,hcso_dt,hcso,hk_vdf,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// 参数解释：网络型规格ID。  对于弹性扩缩容实例，表示上限规格。  约束限制： - 当传入的规格类型为L4，表示该实例为固定规格实例，按规格计费； - 当传入的规格类型为L4_elastic_max，表示该实例为弹性实例，按LCU计费  [hsco场景下所有LB实例共享带宽，该字段无效，请勿使用。](tag:hcso,hk_vdf,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
        /// </summary>
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        /// <summary>
        /// 参数解释：四层弹性Flavor ID。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("l4_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4ScaleFlavorId { get; set; }

        /// <summary>
        /// 参数解释：应用型ID。 对于弹性扩缩容实例，表示上限规格ID。  约束限制： - 当传入的规格类型为L7，表示该实例为固定规格实例，按规格计费； - 当传入的规格类型为L7_elastic_max，表示该实例为弹性实例，按LCU计费  [hsco场景下所有LB实例共享带宽，该字段无效，请勿使用。](tag:hcso,hk_vdf,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
        /// </summary>
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// 参数解释：七层弹性Flavor ID。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("l7_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7ScaleFlavorId { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器绑定的公网IP。只支持绑定一个公网IP。  注：该字段与eips一致。
        /// </summary>
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpInfo> Publicips { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器绑定的global eip。  约束限制：只支持绑定一个globaleip。  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42,dt,hcso_dt,hk_vdf,fcs,ctc,ocb,hws_ocb)
        /// </summary>
        [JsonProperty("global_eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<GlobalEipInfo> GlobalEips { get; set; }

        /// <summary>
        /// 参数解释：下联面子网的网络ID列表。
        /// </summary>
        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }

        /// <summary>
        /// 参数解释：下联面子网类型。  取值范围： - ipv4：ipv4 - dualstack：双栈
        /// </summary>
        [JsonProperty("elb_virsubnet_type", NullValueHandling = NullValueHandling.Ignore)]
        public ElbVirsubnetTypeEnum ElbVirsubnetType { get; set; }
        /// <summary>
        /// 参数解释：是否启用跨VPC后端转发。 [开启跨VPC后端转发后，后端服务器组不仅支持添加云上VPC内的服务器，还支持添加其他VPC、其他公有云、云下数据中心的服务器。](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,dt,hcso_dt,hws_eu) [开启跨VPC后端转发后，后端服务器组不仅支持添加云上VPC内的服务器，还支持添加其他VPC、其他云、云下数据中心的服务器。](tag:fcs)  约束限制： - 开启后不能关闭。 - 使用共享VPC的实例使用此特性时，需确保共享资源所有者已开通VPC对等连接，否则通信异常。 [- 仅独享型负载均衡器支持该特性。](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs,dt) [- 网关型LB不支持该特性。](tag:hws_eu)  取值范围： - true：开启。 - false：不开启。  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器的冻结场景。 [若负载均衡器有多个冻结场景，用逗号分隔。  取值范围： - POLICE：公安冻结场景。 - ILLEGAL：违规冻结场景。 - VERIFY：客户未实名认证冻结场景。 - PARTNER：合作伙伴冻结（合作伙伴冻结子客户资源）。 - AREAR：欠费冻结场景。](tag:hws,hws_hk)  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42,dt,hcso_dt,ocb,hws_ocb)
        /// </summary>
        [JsonProperty("frozen_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenScene { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipv6_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthRef Ipv6Bandwidth { get; set; }

        /// <summary>
        /// 参数解释：是否开启删除保护。  约束限制： - 仅当前局点启用删除保护特性后才会返回该字段。 - 退场时需要先关闭所有资源的删除保护开关。  取值范围： - false：不开启。 - true：开启。  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42)  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public AutoscalingRef Autoscaling { get; set; }

        /// <summary>
        /// 参数解释：LB所属AZ组。
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 参数解释：负载均衡器实例的计费模式。  取值范围： - flavor：按规格计费 - lcu：按使用量计费 - 空值：若是共享型表示免费实例。若是独享型则与flavor模式一致，都是按规格计费。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 参数解释：WAF故障时的流量处理策略。  约束限制：只有绑定了waf的LB实例，该字段才会生效。  取值范围：discard:丢弃，forward: 转发到后端。  默认取值：forward  [不支持该字段，请勿使用。](tag:hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,ct,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)
        /// </summary>
        [JsonProperty("waf_failure_action", NullValueHandling = NullValueHandling.Ignore)]
        public string WafFailureAction { get; set; }

        /// <summary>
        /// 参数解释：修改保护状态。  取值范围： - nonProtection: 不保护。 - consoleProtection: 控制台修改保护。  默认取值：nonProtection
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// 参数解释：设置保护的原因。作为protection_status的转态设置的原因。  约束限制：仅当protection_status为consoleProtection时有效。  取值范围：除&lt;和&gt;外通用Unicode字符集字符，最大255个字符。
        /// </summary>
        [JsonProperty("protection_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectionReason { get; set; }

        /// <summary>
        /// 参数解释：LB所绑定的logtank对应的group id
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 参数解释：LB所绑定的logtank对应的topic id
        /// </summary>
        [JsonProperty("log_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleLoadBalancer {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  autoTerminateTime: ").Append(AutoTerminateTime).Append("\n");
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
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
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
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  wafFailureAction: ").Append(WafFailureAction).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  protectionReason: ").Append(ProtectionReason).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logTopicId: ").Append(LogTopicId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecycleLoadBalancer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecycleLoadBalancer input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AutoTerminateTime != input.AutoTerminateTime || (this.AutoTerminateTime != null && !this.AutoTerminateTime.Equals(input.AutoTerminateTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ProvisioningStatus != input.ProvisioningStatus || (this.ProvisioningStatus != null && !this.ProvisioningStatus.Equals(input.ProvisioningStatus))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.Pools != input.Pools || (this.Pools != null && input.Pools != null && !this.Pools.SequenceEqual(input.Pools))) return false;
            if (this.Listeners != input.Listeners || (this.Listeners != null && input.Listeners != null && !this.Listeners.SequenceEqual(input.Listeners))) return false;
            if (this.OperatingStatus != input.OperatingStatus || (this.OperatingStatus != null && !this.OperatingStatus.Equals(input.OperatingStatus))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.VipSubnetCidrId != input.VipSubnetCidrId || (this.VipSubnetCidrId != null && !this.VipSubnetCidrId.Equals(input.VipSubnetCidrId))) return false;
            if (this.VipAddress != input.VipAddress || (this.VipAddress != null && !this.VipAddress.Equals(input.VipAddress))) return false;
            if (this.VipPortId != input.VipPortId || (this.VipPortId != null && !this.VipPortId.Equals(input.VipPortId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Guaranteed != input.Guaranteed || (this.Guaranteed != null && !this.Guaranteed.Equals(input.Guaranteed))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.Eips != input.Eips || (this.Eips != null && input.Eips != null && !this.Eips.SequenceEqual(input.Eips))) return false;
            if (this.Ipv6VipAddress != input.Ipv6VipAddress || (this.Ipv6VipAddress != null && !this.Ipv6VipAddress.Equals(input.Ipv6VipAddress))) return false;
            if (this.Ipv6VipVirsubnetId != input.Ipv6VipVirsubnetId || (this.Ipv6VipVirsubnetId != null && !this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))) return false;
            if (this.Ipv6VipPortId != input.Ipv6VipPortId || (this.Ipv6VipPortId != null && !this.Ipv6VipPortId.Equals(input.Ipv6VipPortId))) return false;
            if (this.AvailabilityZoneList != input.AvailabilityZoneList || (this.AvailabilityZoneList != null && input.AvailabilityZoneList != null && !this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.BillingInfo != input.BillingInfo || (this.BillingInfo != null && !this.BillingInfo.Equals(input.BillingInfo))) return false;
            if (this.L4FlavorId != input.L4FlavorId || (this.L4FlavorId != null && !this.L4FlavorId.Equals(input.L4FlavorId))) return false;
            if (this.L4ScaleFlavorId != input.L4ScaleFlavorId || (this.L4ScaleFlavorId != null && !this.L4ScaleFlavorId.Equals(input.L4ScaleFlavorId))) return false;
            if (this.L7FlavorId != input.L7FlavorId || (this.L7FlavorId != null && !this.L7FlavorId.Equals(input.L7FlavorId))) return false;
            if (this.L7ScaleFlavorId != input.L7ScaleFlavorId || (this.L7ScaleFlavorId != null && !this.L7ScaleFlavorId.Equals(input.L7ScaleFlavorId))) return false;
            if (this.Publicips != input.Publicips || (this.Publicips != null && input.Publicips != null && !this.Publicips.SequenceEqual(input.Publicips))) return false;
            if (this.GlobalEips != input.GlobalEips || (this.GlobalEips != null && input.GlobalEips != null && !this.GlobalEips.SequenceEqual(input.GlobalEips))) return false;
            if (this.ElbVirsubnetIds != input.ElbVirsubnetIds || (this.ElbVirsubnetIds != null && input.ElbVirsubnetIds != null && !this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds))) return false;
            if (this.ElbVirsubnetType != input.ElbVirsubnetType) return false;
            if (this.IpTargetEnable != input.IpTargetEnable || (this.IpTargetEnable != null && !this.IpTargetEnable.Equals(input.IpTargetEnable))) return false;
            if (this.FrozenScene != input.FrozenScene || (this.FrozenScene != null && !this.FrozenScene.Equals(input.FrozenScene))) return false;
            if (this.Ipv6Bandwidth != input.Ipv6Bandwidth || (this.Ipv6Bandwidth != null && !this.Ipv6Bandwidth.Equals(input.Ipv6Bandwidth))) return false;
            if (this.DeletionProtectionEnable != input.DeletionProtectionEnable || (this.DeletionProtectionEnable != null && !this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && !this.Autoscaling.Equals(input.Autoscaling))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.WafFailureAction != input.WafFailureAction || (this.WafFailureAction != null && !this.WafFailureAction.Equals(input.WafFailureAction))) return false;
            if (this.ProtectionStatus != input.ProtectionStatus) return false;
            if (this.ProtectionReason != input.ProtectionReason || (this.ProtectionReason != null && !this.ProtectionReason.Equals(input.ProtectionReason))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogTopicId != input.LogTopicId || (this.LogTopicId != null && !this.LogTopicId.Equals(input.LogTopicId))) return false;

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
                if (this.AutoTerminateTime != null) hashCode = hashCode * 59 + this.AutoTerminateTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProvisioningStatus != null) hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Pools != null) hashCode = hashCode * 59 + this.Pools.GetHashCode();
                if (this.Listeners != null) hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                if (this.OperatingStatus != null) hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.VipSubnetCidrId != null) hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.VipAddress != null) hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.VipPortId != null) hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Guaranteed != null) hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Eips != null) hashCode = hashCode * 59 + this.Eips.GetHashCode();
                if (this.Ipv6VipAddress != null) hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null) hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Ipv6VipPortId != null) hashCode = hashCode * 59 + this.Ipv6VipPortId.GetHashCode();
                if (this.AvailabilityZoneList != null) hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.BillingInfo != null) hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.L4FlavorId != null) hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L4ScaleFlavorId != null) hashCode = hashCode * 59 + this.L4ScaleFlavorId.GetHashCode();
                if (this.L7FlavorId != null) hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.L7ScaleFlavorId != null) hashCode = hashCode * 59 + this.L7ScaleFlavorId.GetHashCode();
                if (this.Publicips != null) hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                if (this.GlobalEips != null) hashCode = hashCode * 59 + this.GlobalEips.GetHashCode();
                if (this.ElbVirsubnetIds != null) hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                hashCode = hashCode * 59 + this.ElbVirsubnetType.GetHashCode();
                if (this.IpTargetEnable != null) hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.FrozenScene != null) hashCode = hashCode * 59 + this.FrozenScene.GetHashCode();
                if (this.Ipv6Bandwidth != null) hashCode = hashCode * 59 + this.Ipv6Bandwidth.GetHashCode();
                if (this.DeletionProtectionEnable != null) hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.WafFailureAction != null) hashCode = hashCode * 59 + this.WafFailureAction.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null) hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogTopicId != null) hashCode = hashCode * 59 + this.LogTopicId.GetHashCode();
                return hashCode;
            }
        }
    }
}
