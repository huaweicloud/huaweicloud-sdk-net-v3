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
    /// **参数解释**：创建负载均衡器实例的参数对象。  **约束限制**：不涉及
    /// </summary>
    public class CreateLoadBalancerOption 
    {
        /// <summary>
        /// **参数解释**：WAF故障时的流量处理策略。  **约束限制**：只有绑定了waf的LB实例，该字段才会生效。  **取值范围**： - discard:丢弃。 - forward: 转发到后端。  **默认取值**：forward  [不支持该字段，请勿使用。](tag:hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,srg,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,ct,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)
        /// </summary>
        /// <value>**参数解释**：WAF故障时的流量处理策略。  **约束限制**：只有绑定了waf的LB实例，该字段才会生效。  **取值范围**： - discard:丢弃。 - forward: 转发到后端。  **默认取值**：forward  [不支持该字段，请勿使用。](tag:hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,srg,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,ct,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)</value>
        [JsonConverter(typeof(EnumClassConverter<WafFailureActionEnum>))]
        public class WafFailureActionEnum
        {
            /// <summary>
            /// Enum DISCARD for value: discard
            /// </summary>
            public static readonly WafFailureActionEnum DISCARD = new WafFailureActionEnum("discard");

            /// <summary>
            /// Enum FORWARD for value: forward
            /// </summary>
            public static readonly WafFailureActionEnum FORWARD = new WafFailureActionEnum("forward");

            private static readonly Dictionary<string, WafFailureActionEnum> StaticFields =
            new Dictionary<string, WafFailureActionEnum>()
            {
                { "discard", DISCARD },
                { "forward", FORWARD },
            };

            private string _value;

            public WafFailureActionEnum()
            {

            }

            public WafFailureActionEnum(string value)
            {
                _value = value;
            }

            public static WafFailureActionEnum FromValue(string value)
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

                if (this.Equals(obj as WafFailureActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WafFailureActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WafFailureActionEnum a, WafFailureActionEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(WafFailureActionEnum a, WafFailureActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：修改保护状态。用于console控制台防误修改。console感知该状态为consoleProtection时，不允许用户直接修改资源其他配置属性。  **约束限制**：不影响通过API修改资源属性。类似资源标记，用于提升控制台等用户易用性场景，如防误修改。  **取值范围**： - nonProtection: 不保护。 - consoleProtection: 控制台修改保护。  **默认取值**：nonProtection
        /// </summary>
        /// <value>**参数解释**：修改保护状态。用于console控制台防误修改。console感知该状态为consoleProtection时，不允许用户直接修改资源其他配置属性。  **约束限制**：不影响通过API修改资源属性。类似资源标记，用于提升控制台等用户易用性场景，如防误修改。  **取值范围**： - nonProtection: 不保护。 - consoleProtection: 控制台修改保护。  **默认取值**：nonProtection</value>
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
                if (ReferenceEquals(a, b))
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
        /// **参数解释**：负载均衡器实例的计费模式。  **约束限制**：不建议用户传该字段。系统会基于用户传入的l4_flavor_id/l7_flavor_id的规格类型，自动识别计费模式。  **取值范围**： - flavor：固定规格计费。 - lcu：弹性规格计费（按用户实际使用的lcu个数计费）。  **默认取值**： - 若是创建共享型实例，不传默认创建固定规格计费实例。 - 若是创建独享型实例，则系统会忽略该字段，而是基于用户传入的l4_flavor_id/l7_flavor_id的规格类型，自动识别计费模式。
        /// </summary>
        /// <value>**参数解释**：负载均衡器实例的计费模式。  **约束限制**：不建议用户传该字段。系统会基于用户传入的l4_flavor_id/l7_flavor_id的规格类型，自动识别计费模式。  **取值范围**： - flavor：固定规格计费。 - lcu：弹性规格计费（按用户实际使用的lcu个数计费）。  **默认取值**： - 若是创建共享型实例，不传默认创建固定规格计费实例。 - 若是创建独享型实例，则系统会忽略该字段，而是基于用户传入的l4_flavor_id/l7_flavor_id的规格类型，自动识别计费模式。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum FLAVOR for value: flavor
            /// </summary>
            public static readonly ChargeModeEnum FLAVOR = new ChargeModeEnum("flavor");

            /// <summary>
            /// Enum LCU for value: lcu
            /// </summary>
            public static readonly ChargeModeEnum LCU = new ChargeModeEnum("lcu");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "flavor", FLAVOR },
                { "lcu", LCU },
            };

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
            }

            public static ChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：项目ID。获取方式请参见[获取项目ID](elb_fl_0008.xml)。  **约束限制**：不涉及  **取值范围**：长度为32个字符，由小写字母和数字组成。  **默认取值**：不涉及  &gt; 该字段实际无效，最终使用url中的project_id。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的名称。  **约束限制**：不涉及  **取值范围**：支持中文字符、英文字符等unicode字符，且长度为[0-255]个字符。可以为空。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的描述。  **约束限制**：不涉及  **取值范围**：支持中文字符、英文字符等unicode字符，且长度为[0-255]个字符。可以为空。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的IPv4私网IP。该地址必须包含在所在子网的IPv4网段内，且未被占用。  **约束限制**： - 传入vip_address时，必须传入vip_subnet_cidr_id。 - 不传入vip_address，但传入vip_subnet_cidr_id，则自动分配IPv4私网IP。 - 不传入vip_address，且不传vip_subnet_cidr_id，则不分配IPv4私网IP，vip_address&#x3D;null。 - 网关型LB不支持传入vip_address。  **取值范围**：满足IPv4的地址格式，[0-255].[0-255].[0-255].[0-255]. 如192.168.1.1。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器所在子网的IPv4子网ID，也称为该负载均衡器实例的前端子网。  **约束限制**： - 若创建带有IPv4私网IP的负载均衡实例，则字段必须传入。可以通过调用VPC的API, GET https://{VPC_Endpoint}/v1/{project_id}/subnets 响应参数中的neutron_subnet_id得到。 - vpc_id, vip_subnet_cidr_id, ipv6_vip_virsubnet_id不能同时为空，且需要在同一个vpc下。 - 若同时传入vpc_id和vip_subnet_cidr_id，则vip_subnet_cidr_id对应的子网必须属于vpc_id对应的VPC。 - 创建网关型LB，vip_subnet_cidr_id和ipv6_vip_virsubnet_id不能同时为空。若都传入则必须是同一个子网的IPv4子网ID和IPv6网络ID。  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetCidrId { get; set; }

        /// <summary>
        /// **参数解释**：双栈类型负载均衡器所在子网的IPv6网络ID，也称为该负载均衡器实例的前端子网。  **约束限制**： - 若创建带有IPv6 IP的负载均衡实例，则字段必须传入。可以通过GET https://{VPC_Endpoint}/v1/{project_id}/subnets 响应参数中的neutron_network_id得到。 - vpc_id，vip_subnet_cidr_id，ipv6_vip_virsubnet_id不能同时为空，且需要在同一个vpc下。 - 需要对应的子网开启IPv6。 - 创建网关型LB，vip_subnet_cidr_id和ipv6_vip_virsubnet_id不能同时为空。若都传入则必须是同一个子网的IPv4子网ID和IPv6网络ID。  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及 [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的生产者名称。  **约束限制**：不涉及  **取值范围**：固定为vlb，无需指定。  **默认取值**：vlb
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// **参数解释**：网络型规格ID。  **约束限制**： [- 可以通过GET https://{ELB_Endpoint}/v3/{project_id}/elb/flavors?type&#x3D;L4 响应参数中的id得到。 - 当l4_flavor_id和l7_flavor_id都不传的时，会使用默认flavor（默认flavor根据不同局点有所不同，具体以实际值为准）。 - 当传入的规格类型为L4，表示该实例为固定规格实例，按规格计费。 - 当传入的规格类型为L4_elastic_max，表示该实例为弹性实例，按LCU计费。](tag:hws,hws_hk,hws_eu,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb)  网关型LB不支持指定l4_flavor_id。 [只支持设置为l4_flavor.elb.shared。](tag:hcso_dt)  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及  [所有LB实例共享带宽，该字段无效，请勿使用。](tag:hk_vdf,srg,fcs)
        /// </summary>
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：应用型规格ID。  **约束限制**： [- 可以通过GET https://{ELB_Endpoint}/v3/{project_id}/elb/flavors?type&#x3D;L7 响应参数中的id得到。 - 当l4_flavor_id和l7_flavor_id都不传的时，会使用默认flavor（默认flavor根据不同局点有所不同，具体以实际值为准）。 - 当传入的规格类型为L7，表示该实例为固定规格实例，按规格计费。 - 当传入的规格类型为L7_elastic_max，表示该实例为弹性实例，按LCU计费。](tag:hws,hws_hk,hws_eu,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb) - 网关型LB不支持指定l7_flavor_id。 [- 只支持设置为l7_flavor.elb.shared。](tag:hcso_dt)  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及  [所有LB实例共享带宽，该字段无效，请勿使用。](tag:hk_vdf,srg,fcs)
        /// </summary>
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：是否为独享型负载均衡器实例。  **约束限制**：当前只支持设置为true，设置为false会返回400 Bad Request。  **取值范围**： - true：独享型。 - false：共享型。  **默认取值**：true
        /// </summary>
        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器所在的VPC ID。  **约束限制**: - 参数获取，可以通过 GET https://{VPC_Endpoint}/v1/{project_id}/vpcs 响应参数中的id得到。 - vpc_id，vip_subnet_cidr_id，ipv6_vip_virsubnet_id不能同时为空，且需要在同一个vpc下。  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器实例所在的可用区列表。 可通过GET https://{ELB_Endpoint}/v3/{project_id}/elb/availability-zones 接口来查询可用区集合列表。创建负载均衡器时，从查询结果选择某一个可用区集合，并从中选择一个或多个可用区。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及  &gt;为了支持可用区容灾，建议选取不少于2个可用区。
        /// </summary>
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// **参数解释**：资源所属的企业项目ID。创建时不传则资源属于default企业项目，返回enterprise_project_id&#x3D;\&quot;0\&quot;。  **约束限制**：不能传入空字符串\&quot;\&quot;、\&quot;0\&quot;或不存在的企业项目ID。  **取值范围**：不涉及  **默认取值**：\&quot;0\&quot;  [不支持该字段，请勿使用。](tag:dt,hcso_dt)
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡的标签列表。示例：\&quot;tags\&quot;:[{\&quot;key\&quot;:\&quot;my_tag\&quot;,\&quot;value\&quot;:\&quot;my_tag_value\&quot;}]  **约束限制**：不涉及
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的启用状态。  **约束限制**：不涉及  **取值范围**： - true ：启用。 - false：停用。  **默认取值**：true  [不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// **参数解释**: 预付费实例的订单信息。  **约束限制**：不涉及  **取值范围**： - 空：按需计费。 [- 非空：包周期计费，格式为：order_id:product_id:region_id:project_id。如：CS2107161019CDJZZ:OFFI569702121789763584:az1:057ef081eb00d2732fd1c01a9be75e6f](tag:hws)  **默认取值**：不涉及  [不支持该字段，请勿使用。](tag:hws_hk,hws_eu,hws_eu_wb,hws_test,srg,fcs,fcs_vm,dt,ctc,cmcc,tm,sbc,hk_sbc,hk_tm,hk_vdf,ct)
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipv6_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthRef Ipv6Bandwidth { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器绑定的公网IP的ID的数组。  **约束限制**： - 只支持绑定数组中的第一个EIP，其他将被忽略。 - 网关型LB不支持该字段。
        /// </summary>
        [JsonProperty("publicip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicipIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLoadBalancerPublicIpOption Publicip { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的后端子网的网络ID（OpenStack Neutron接口）列表。负载均衡器实例会预占用该子网中的部分IP， 用于负载均衡器网关与该实例后端服务器通信的源地址（典型场景，健康检查探测的源地址，FULLNAT场景的源地址等）。 使用负载均衡器所在VPC的ID查询可用子网 GET https://{VPC_Endpoint}/v1/{project_id}/subnets?vpc_id&#x3D;xxxx 获取响应参数中的neutron_network_id字段。  **约束限制**： - 后端子网必须属于该负载均衡器实例所在的VPC。 - 通常需要用户指定一个特殊的子网，方便用户在后端服务器关联的安全组中，放通该子网的地址段。 - 若指定多个下联面子网，则按顺序优先使用第一个子网来为负载均衡器下联面端口分配ip地址。 - 若不指定该字段，则按如下规则选择下联面网络：   1. 如果ELB实例开启ipv6，则选择ipv6_vip_virsubnet_id子网对应的网络ID。   2. 如果ELB实例没有开启ipv6，开启ipv4，则选择vip_subnet_cidr_id子网对应的网络ID。   3. 如果ELB实例没有选择私网，只开启公网，则会在当前负载均衡器所在的VPC中任意选一个子网，优选可用IP多的网络。 - 后端服务器安全组放通：由于负载均衡器网关会使用该子网中的预占的地址，作为源IP与后端服务器通信（健康检查探测，FULLNAT通信），为避免后端服务器关联的安全组拦截，建议将对应的子网地址段进行安全组放通。 - 预占地址变化：负载均衡实例，弹性扩缩场景，可能涉及到预占地址的变化，建议安全组对子网段放通，而不是具体预占地址的放通。 - 建议后端子网，使用一个独占的地址充足的子网，方便运维管理。  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }

        /// <summary>
        /// **参数解释**：是否启用IP类型后端转发。 [开启IP类型后端转发后，后端服务器组不仅支持添加云上VPC内的服务器，还支持添加其他VPC、其他公有云、云下数据中心的服务器。](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,dt,hcso_dt,hws_eu) [开启IP类型后端转发后，后端服务器组不仅支持添加云上VPC内的服务器，还支持添加其他VPC、云下数据中心的服务器。](tag:srg,fcs)  **约束限制**： - 开启后不能关闭。 - 使用共享VPC的实例使用此特性时，需确保共享资源所有者已开通VPC对等连接，否则通信异常。 [- 仅独享型负载均衡器支持该特性。](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt) - 网关型LB不支持该特性。  **取值范围**： - true：开启。 - false：不开启。  **默认取值**：false [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// **参数解释**：实例删除保护开关。  **约束限制**：实例删除前，需要先关闭该实例下所有资源的删除保护开关。  **取值范围**：  - false： 不开启。  - true： 开启。  **默认取值**：false
        /// </summary>
        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prepaid_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrepaidCreateOption PrepaidOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLoadbalancerAutoscalingOption Autoscaling { get; set; }

        /// <summary>
        /// **参数解释**：WAF故障时的流量处理策略。  **约束限制**：只有绑定了waf的LB实例，该字段才会生效。  **取值范围**： - discard:丢弃。 - forward: 转发到后端。  **默认取值**：forward  [不支持该字段，请勿使用。](tag:hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,srg,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,ct,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)
        /// </summary>
        [JsonProperty("waf_failure_action", NullValueHandling = NullValueHandling.Ignore)]
        public WafFailureActionEnum WafFailureAction { get; set; }
        /// <summary>
        /// **参数解释**：修改保护状态。用于console控制台防误修改。console感知该状态为consoleProtection时，不允许用户直接修改资源其他配置属性。  **约束限制**：不影响通过API修改资源属性。类似资源标记，用于提升控制台等用户易用性场景，如防误修改。  **取值范围**： - nonProtection: 不保护。 - consoleProtection: 控制台修改保护。  **默认取值**：nonProtection
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// **参数解释**：设置保护的原因。作为protection_status的转态设置的原因。  **约束限制**：仅当protection_status为consoleProtection时有效。  **取值范围**：除&#39;&lt;&#39;和&#39;&gt;&#39;外通用Unicode字符集字符，最大255个字符。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("protection_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectionReason { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器实例的计费模式。  **约束限制**：不建议用户传该字段。系统会基于用户传入的l4_flavor_id/l7_flavor_id的规格类型，自动识别计费模式。  **取值范围**： - flavor：固定规格计费。 - lcu：弹性规格计费（按用户实际使用的lcu个数计费）。  **默认取值**： - 若是创建共享型实例，不传默认创建固定规格计费实例。 - 若是创建独享型实例，则系统会忽略该字段，而是基于用户传入的l4_flavor_id/l7_flavor_id的规格类型，自动识别计费模式。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// **参数解释**：负载均衡器实例的IPv6地址。  **约束限制**：  - 必须属于ipv6_vip_virsubnet_id子网中地址。  - elb_virsubnet_ids中的后端子网必须支持双栈。  - 网关型LB不支持指定ipv6_vip_address。  **取值范围**：不涉及  **默认取值**：不涉及  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadBalancerOption {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  ipv6Bandwidth: ").Append(Ipv6Bandwidth).Append("\n");
            sb.Append("  publicipIds: ").Append(PublicipIds).Append("\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("  elbVirsubnetIds: ").Append(ElbVirsubnetIds).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  deletionProtectionEnable: ").Append(DeletionProtectionEnable).Append("\n");
            sb.Append("  prepaidOptions: ").Append(PrepaidOptions).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  wafFailureAction: ").Append(WafFailureAction).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  protectionReason: ").Append(ProtectionReason).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadBalancerOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadBalancerOption input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.VipAddress != input.VipAddress || (this.VipAddress != null && !this.VipAddress.Equals(input.VipAddress))) return false;
            if (this.VipSubnetCidrId != input.VipSubnetCidrId || (this.VipSubnetCidrId != null && !this.VipSubnetCidrId.Equals(input.VipSubnetCidrId))) return false;
            if (this.Ipv6VipVirsubnetId != input.Ipv6VipVirsubnetId || (this.Ipv6VipVirsubnetId != null && !this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.L4FlavorId != input.L4FlavorId || (this.L4FlavorId != null && !this.L4FlavorId.Equals(input.L4FlavorId))) return false;
            if (this.L7FlavorId != input.L7FlavorId || (this.L7FlavorId != null && !this.L7FlavorId.Equals(input.L7FlavorId))) return false;
            if (this.Guaranteed != input.Guaranteed || (this.Guaranteed != null && !this.Guaranteed.Equals(input.Guaranteed))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.AvailabilityZoneList != input.AvailabilityZoneList || (this.AvailabilityZoneList != null && input.AvailabilityZoneList != null && !this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.BillingInfo != input.BillingInfo || (this.BillingInfo != null && !this.BillingInfo.Equals(input.BillingInfo))) return false;
            if (this.Ipv6Bandwidth != input.Ipv6Bandwidth || (this.Ipv6Bandwidth != null && !this.Ipv6Bandwidth.Equals(input.Ipv6Bandwidth))) return false;
            if (this.PublicipIds != input.PublicipIds || (this.PublicipIds != null && input.PublicipIds != null && !this.PublicipIds.SequenceEqual(input.PublicipIds))) return false;
            if (this.Publicip != input.Publicip || (this.Publicip != null && !this.Publicip.Equals(input.Publicip))) return false;
            if (this.ElbVirsubnetIds != input.ElbVirsubnetIds || (this.ElbVirsubnetIds != null && input.ElbVirsubnetIds != null && !this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds))) return false;
            if (this.IpTargetEnable != input.IpTargetEnable || (this.IpTargetEnable != null && !this.IpTargetEnable.Equals(input.IpTargetEnable))) return false;
            if (this.DeletionProtectionEnable != input.DeletionProtectionEnable || (this.DeletionProtectionEnable != null && !this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))) return false;
            if (this.PrepaidOptions != input.PrepaidOptions || (this.PrepaidOptions != null && !this.PrepaidOptions.Equals(input.PrepaidOptions))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && !this.Autoscaling.Equals(input.Autoscaling))) return false;
            if (this.WafFailureAction != input.WafFailureAction) return false;
            if (this.ProtectionStatus != input.ProtectionStatus) return false;
            if (this.ProtectionReason != input.ProtectionReason || (this.ProtectionReason != null && !this.ProtectionReason.Equals(input.ProtectionReason))) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.Ipv6VipAddress != input.Ipv6VipAddress || (this.Ipv6VipAddress != null && !this.Ipv6VipAddress.Equals(input.Ipv6VipAddress))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VipAddress != null) hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.VipSubnetCidrId != null) hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null) hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.L4FlavorId != null) hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L7FlavorId != null) hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.Guaranteed != null) hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.AvailabilityZoneList != null) hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.BillingInfo != null) hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.Ipv6Bandwidth != null) hashCode = hashCode * 59 + this.Ipv6Bandwidth.GetHashCode();
                if (this.PublicipIds != null) hashCode = hashCode * 59 + this.PublicipIds.GetHashCode();
                if (this.Publicip != null) hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                if (this.ElbVirsubnetIds != null) hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                if (this.IpTargetEnable != null) hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.DeletionProtectionEnable != null) hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.PrepaidOptions != null) hashCode = hashCode * 59 + this.PrepaidOptions.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                hashCode = hashCode * 59 + this.WafFailureAction.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null) hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Ipv6VipAddress != null) hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
