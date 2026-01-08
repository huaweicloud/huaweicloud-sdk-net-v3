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
    /// **参数解释**：更新负载均衡器参数对象。  **约束限制**：不涉及
    /// </summary>
    public class UpdateLoadBalancerOption 
    {
        /// <summary>
        /// **参数解释**：WAF故障时的流量处理策略。  **约束限制**：只有绑定了waf的LB实例，该字段才会生效。  **取值范围**：discard:丢弃，forward: 转发到后端。  **默认取值**：forward  [不支持该字段，请勿使用。](tag:hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,srg,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,ct,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)
        /// </summary>
        /// <value>**参数解释**：WAF故障时的流量处理策略。  **约束限制**：只有绑定了waf的LB实例，该字段才会生效。  **取值范围**：discard:丢弃，forward: 转发到后端。  **默认取值**：forward  [不支持该字段，请勿使用。](tag:hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,srg,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,ct,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)</value>
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
        /// **参数解释**：修改保护状态。  **约束限制**：不涉及  **取值范围**： - nonProtection: 不保护 - consoleProtection: 控制台修改保护。  **默认取值**：不涉及
        /// </summary>
        /// <value>**参数解释**：修改保护状态。  **约束限制**：不涉及  **取值范围**： - nonProtection: 不保护 - consoleProtection: 控制台修改保护。  **默认取值**：不涉及</value>
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
        /// **参数解释**：负载均衡器的名称。  **约束限制**：不涉及  **取值范围**：支持中文字符、英文字符等unicode字符，且长度为[0-255]个字符。可以为空。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的启用状态。  **取值范围**： - true ：启用。 - false：停用。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及  [不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的描述。  **约束限制**：不涉及  **取值范围**：支持中文字符、英文字符等unicode字符，且长度为[0-255]个字符。可以为空。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：双栈类型负载均衡器所在子网的IPv6网络ID，也称为该负载均衡器实例的前端子网。 可以通过GET https://{VPC_Endpoint}/v1/{project_id}/subnets 响应参数中的neutron_network_id得到。 更新ipv6_vip_virsubnet_id可以更新负载均衡器所在IPv6子网，且负载均衡器的内网IPv6地址将发生变化，但不会导致IPv4子网发生变化。  **约束限制**： - ipv6_vip_virsubnet_id 对应的子网必须属于当前负载均衡器所在VPC，且子网需开启支持IPv6。 - 只有guaranteed是true的负载均衡器才支持更新ipv6_vip_virsubnet_id。  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及  [不支持IPv6，请勿使用。](tag:dt) &gt; *传入为null表示解绑IPv6子网。不变更IPv6子网，请勿传入该字段。*
        /// </summary>
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器所在的IPv4子网ID，也称为该负载均衡器实例的前端子网。 可以通过GET https://{VPC_Endpoint}/v1/{project_id}/subnets 响应参数中的neutron_subnet_id得到。 更新vip_subnet_cidr_id可以更新负载均衡器所在IPv4子网，并且负载均衡器的**私网IPv4**地址将发生变化，但不会导致IPv6子网发生变化。  **约束限制**： - 若同时设置了vip_address，则必须保证vip_address对应的IP在vip_subnet_cidr_id的子网网段中。 - vip_subnet_cidr_id对应的子网必须属于当前负载均衡器vpc_id对应的VPC。 - 只有guaranteed是true的负载均衡器才支持更新vip_subnet_cidr_id。  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及  &gt;*传入null表示解绑IPv4子网。不变更IPv4子网，请勿传入该字段。*
        /// </summary>
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetCidrId { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器的IPv4私网IP。  **约束限制**：该地址必须包含在所在子网的IPv4网段内，且未被占用。  **取值范围**：满足IPv4的地址格式，[0-255].[0-255].[0-255].[0-255]. 如192.168.1.1。  **默认取值**：不涉及  注：仅当guaranteed是true的场合，才支持更新。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// **参数解释**：网络型规格ID。 可以通过GET https://{ELB_Endpoint}/v3/{project_id}/elb/flavors?type&#x3D;L4 响应参数中的id得到。  **约束限制**： - 仅当guaranteed是true的场合，才支持更新。 - 可以支持规格改大改小，注意改小过程中可能会造成部分长连接中断，影响部分连接的新建。 - autoscaling.enable&#x3D;true时，修改无意义，不生效。 - 当传入的规格类型为L4，表示该实例为固定规格实例，按规格计费。 - 当传入的规格类型为L4_elastic_max，表示该实例为弹性实例，按LCU计费。 - 网关型LB不支持指定l4_flavor_id。 [- 只支持设置为l4_flavor.elb.shared。](tag:hcso_dt)  **取值范围**：不涉及  **默认取值**：不涉及  [当前场景下所有LB实例共享带宽，该字段无效，请勿使用。](tag:hk_vdf,srg,fcs)
        /// </summary>
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：应用型ID。 可以通过GET https://{ELB_Endpoint}/v3/{project_id}/elb/flavors?type&#x3D;L7 响应参数中的id得到。  **约束限制**： - 仅当guaranteed是true的场合，才支持更新。 - 可以支持规格改大改小，注意改小过程中可能会造成部分长连接中断，影响部分连接的新建， - autoscaling.enable&#x3D;true时，修改无意义，不生效。 - 当传入的规格类型为L7，表示该实例为固定规格实例，按规格计费。 - 当传入的规格类型为L7_elastic_max，表示该实例为弹性实例，按LCU计费。 - 网关型LB不支持指定l7_flavor_id。 [- 只支持设置为l7_flavor.elb.shared。](tag:hcso_dt)  **取值范围**：不涉及  **默认取值**：不涉及  [所有LB实例共享带宽，该字段无效，请勿使用。](tag:hk_vdf,srg,fcs)
        /// </summary>
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipv6_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthRef Ipv6Bandwidth { get; set; }

        /// <summary>
        /// **参数解释**：是否启用IP类型后端转发。 [开启IP类型后端转发后，后端服务器组不仅支持添加云上VPC内的服务器，还支持添加其他VPC、其他公有云、云下数据中心的服务器。](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,dt,hcso_dt,hws_eu) [开启IP类型后端转发后，后端服务器组不仅支持添加云上VPC内的服务器，还支持添加其他VPC、云下数据中心的服务器。](tag:srg,fcs)  **约束限制**： - 开启IP类型后端，ELB需要占用后端子网中的IP地址与后端服务器进行通信，请确保预留足够的IP地址。 - 使用共享VPC的实例使用此特性时，需确保共享资源所有者已开通VPC对等连接，否则通信异常。 [- 仅独享型负载均衡器支持该特性。](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt) - 网关型LB不支持该特性。  **取值范围**： - true：开启。 - false：不开启。 **默认取值**：不涉及  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// **参数解释**：下联面子网的网络ID列表。 可以通过GET https://{VPC_Endpoint}/v1/{project_id}/subnets 响应参数中的neutron_network_id得到。  **约束限制**： - 已绑定的下联面子网也在传参elb_virsubnet_ids列表中，则绑定关系保留。 - 已绑定的下联面子网若不在传参elb_virsubnet_ids列表中，则将移除LB与该下联面子网的关联关系。但不允许移除已被ELB使用的子网，否则将报错，不做任何修改。 - 在传参elb_virsubnet_ids列表中但不在已绑定的下联面子网列表中，则将新增LB与下联面的绑定关系。 - 所有elb_virsubnet_ids中的ID同属于该LB所在的VPC。 - 不支持边缘云子网。  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }

        /// <summary>
        /// **参数解释**：是否开启删除保护。  **约束限制**：退场时需要先关闭所有资源的删除保护开关。  **取值范围**：false不开启，true开启。  **默认取值**：不涉及  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42) [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prepaid_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrepaidUpdateOption PrepaidOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateLoadbalancerAutoscalingOption Autoscaling { get; set; }

        /// <summary>
        /// **参数解释**：计费模式。  **约束限制**：不涉及  **取值范围**： - flavor：按规格计费  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// **参数解释**：WAF故障时的流量处理策略。  **约束限制**：只有绑定了waf的LB实例，该字段才会生效。  **取值范围**：discard:丢弃，forward: 转发到后端。  **默认取值**：forward  [不支持该字段，请勿使用。](tag:hws_eu,hws_test,hcs,hcs_sm,hcso,hk_vdf,srg,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b,hcso_dt,dt,ocb,ctc,cmcc,tm,ct,sbc,g42,hws_ocb,hk_sbc,hk_tm,hk_g42)
        /// </summary>
        [JsonProperty("waf_failure_action", NullValueHandling = NullValueHandling.Ignore)]
        public WafFailureActionEnum WafFailureAction { get; set; }
        /// <summary>
        /// **参数解释**：修改保护状态。  **约束限制**：不涉及  **取值范围**： - nonProtection: 不保护 - consoleProtection: 控制台修改保护。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// **参数解释**：设置保护的原因。作为protection_status的转态设置的原因。  **约束限制**：仅当protection_status为consoleProtection时有效。  **取值范围**：除&#39;&lt;&#39;和&#39;&gt;&#39;外通用Unicode字符集字符，最大255个字符。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("protection_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectionReason { get; set; }

        /// <summary>
        /// **参数解释**：双栈类型负载均衡器的IPv6地址。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及 [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoadBalancerOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  ipv6Bandwidth: ").Append(Ipv6Bandwidth).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  elbVirsubnetIds: ").Append(ElbVirsubnetIds).Append("\n");
            sb.Append("  deletionProtectionEnable: ").Append(DeletionProtectionEnable).Append("\n");
            sb.Append("  prepaidOptions: ").Append(PrepaidOptions).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  wafFailureAction: ").Append(WafFailureAction).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  protectionReason: ").Append(ProtectionReason).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLoadBalancerOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLoadBalancerOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Ipv6VipVirsubnetId != input.Ipv6VipVirsubnetId || (this.Ipv6VipVirsubnetId != null && !this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))) return false;
            if (this.VipSubnetCidrId != input.VipSubnetCidrId || (this.VipSubnetCidrId != null && !this.VipSubnetCidrId.Equals(input.VipSubnetCidrId))) return false;
            if (this.VipAddress != input.VipAddress || (this.VipAddress != null && !this.VipAddress.Equals(input.VipAddress))) return false;
            if (this.L4FlavorId != input.L4FlavorId || (this.L4FlavorId != null && !this.L4FlavorId.Equals(input.L4FlavorId))) return false;
            if (this.L7FlavorId != input.L7FlavorId || (this.L7FlavorId != null && !this.L7FlavorId.Equals(input.L7FlavorId))) return false;
            if (this.Ipv6Bandwidth != input.Ipv6Bandwidth || (this.Ipv6Bandwidth != null && !this.Ipv6Bandwidth.Equals(input.Ipv6Bandwidth))) return false;
            if (this.IpTargetEnable != input.IpTargetEnable || (this.IpTargetEnable != null && !this.IpTargetEnable.Equals(input.IpTargetEnable))) return false;
            if (this.ElbVirsubnetIds != input.ElbVirsubnetIds || (this.ElbVirsubnetIds != null && input.ElbVirsubnetIds != null && !this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds))) return false;
            if (this.DeletionProtectionEnable != input.DeletionProtectionEnable || (this.DeletionProtectionEnable != null && !this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))) return false;
            if (this.PrepaidOptions != input.PrepaidOptions || (this.PrepaidOptions != null && !this.PrepaidOptions.Equals(input.PrepaidOptions))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && !this.Autoscaling.Equals(input.Autoscaling))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.WafFailureAction != input.WafFailureAction) return false;
            if (this.ProtectionStatus != input.ProtectionStatus) return false;
            if (this.ProtectionReason != input.ProtectionReason || (this.ProtectionReason != null && !this.ProtectionReason.Equals(input.ProtectionReason))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null) hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.VipSubnetCidrId != null) hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.VipAddress != null) hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.L4FlavorId != null) hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L7FlavorId != null) hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.Ipv6Bandwidth != null) hashCode = hashCode * 59 + this.Ipv6Bandwidth.GetHashCode();
                if (this.IpTargetEnable != null) hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.ElbVirsubnetIds != null) hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                if (this.DeletionProtectionEnable != null) hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.PrepaidOptions != null) hashCode = hashCode * 59 + this.PrepaidOptions.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                hashCode = hashCode * 59 + this.WafFailureAction.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null) hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                if (this.Ipv6VipAddress != null) hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
