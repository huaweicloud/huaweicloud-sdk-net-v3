using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RocketMQExtendProductInfoEntity 
    {

        /// <summary>
        /// **参数解释**： 实例类型。 **约束限制**： 不涉及。 **取值范围**： [- single：4.8.0单机。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- cluster：4.8.0集群。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- single.basic：5.x单机基础版。](tag:hws,hws_eu,hws_hk,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,srg) [- cluster.basic：5.x集群基础版。](tag:hws,hws_eu,hws_hk,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,srg) [- cluster.professional：5.x集群专业版。](tag:hws,hws_eu,hws_hk,ctc,srg) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： RocketMQ实例规格。 [x86环境后缀为.x86，arm环境为.arm。single表示单机，cluster表示集群。](tag:hcs,fcs,hcs_oemout)  **约束限制**： 不涉及。  **取值范围**： [当“type”为“single.basic”选择单机规格；当“type”为“cluster.basic”选择集群规格。](tag:dt) [- c6.2u8g.cluster.x86或c6.2u8g.cluster.arm：单个代理最大分区数50，单个代理最大消费组数100](tag:fcs) [- c6.4u8g.cluster.small：单个代理最大Topic数2000，单个代理最大消费组数2000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.4u8g.cluster：单个代理最大Topic数4000，单个代理最大消费组数4000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.4u16g.cluster.x86或c6.4u16g.cluster.arm：单个代理最大分区数100，单个代理最大消费组数200](tag:hcs,hcs_oemout) [- c6.8u16g.cluster：单个代理最大Topic数8000，单个代理最大消费组数8000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.8u32g.cluster.x86或c6.8u32g.cluster.arm：单个代理最大Topic数200，单个代理最大消费组数400](tag:hcs,fcs,hcs_oemout) [- c6.12u24g.cluster：单个代理最大Topic数12000，单个代理最大消费组数12000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.16u64g.cluster.x86或c6.16u64g.cluster.arm：单个代理最大Topic数300，单个代理最大消费组数600](tag:hcs,fcs,hcs_oemout) [- c6.16u32g.cluster：单个代理最大Topic数16000，单个代理最大消费组数16000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.32u128g.cluster.x86或c6.32u128g.cluster.arm：单个代理最大Topic数400，单个代理最大消费组数800](tag:hcs,fcs,hcs_oemout) [- rocketmq.b1.large.1：RocketMQ 5.x 基础版单机规格，实例TPS 500](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,srg) [- rocketmq.b2.large.4：RocketMQ 5.x 基础版集群规格，实例TPS 2000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,srg) [- rocketmq.b2.large.8：RocketMQ 5.x 基础版集群规格，实例TPS 4000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,srg) [- rocketmq.b2.large.12：RocketMQ 5.x 基础版集群规格，实例TPS 6000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,srg) [- rocketmq.p1.large.1：RocketMQ 5.x 专业版单机规格，实例TPS 500](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.8：RocketMQ 5.x 专业版集群规格，实例TPS 4000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.12：RocketMQ 5.x 专业版集群规格，实例TPS 6000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.20：RocketMQ 5.x 专业版集群规格，实例TPS 10000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.40：RocketMQ 5.x 专业版集群规格，实例TPS 20000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.100：RocketMQ 5.x 专业版集群规格，实例TPS 50000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.150：RocketMQ 5.x 专业版集群规格，实例TPS 75000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.200：RocketMQ 5.x 专业版集群规格，实例TPS 100000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.300：RocketMQ 5.x 专业版集群规格，实例TPS 150000](tag:hws,hws_eu,hws_hk,ctc,srg)  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释**： ECS的Flavor ID。可参考ECS服务实例规格中的规格清单，DMS服务可适配，取通用计算增强型C6系列及上，RocketMQ 5.x CPU/内存配比为1:4。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ecs_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsFlavorId { get; set; }

        /// <summary>
        /// **参数解释**： 账单计费类型。 **约束限制**： 不涉及。 **取值范围**： [- dms.platinum.c6：华为云账单计费类型。](tag:hws,hws_hk)[账单计费类型。](tag:ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,cmcc,hk_tm,hcs,fcs,hcs_oemout,ax,srg) [- dms.rocketmq.basic.single.tps：RocketMQ 5.x基础版单机计费类型。](tag:ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,hcs,fcs,dt,hcs_oemout,ax,srg) [- dms.rocketmq.basic.cluster.tps：RocketMQ 5.x基础版集群计费类型。](tag:ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,hcs,fcs,dt,hcs_oemout,ax,srg) [- dms.rocketmq.pro.single.tps：RocketMQ 5.x专业版单机计费类型。](tag:hws,hws_eu,hws_hk,ctc,srg) [- dms.rocketmq.pro.cluster.tps：RocketMQ 5.x专业版集群计费类型。](tag:hws,hws_eu,hws_hk,ctc,srg) [- dms.platinum.c6.dec：专属云账单计费类型。](tag:hws,hws_hk) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("billing_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCode { get; set; }

        /// <summary>
        /// **参数解释**： 支持的CPU架构类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("arch_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ArchTypes { get; set; }

        /// <summary>
        /// **参数解释**： 支持的计费模式类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChargingMode { get; set; }

        /// <summary>
        /// **参数解释**： 磁盘IO对象信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ios", NullValueHandling = NullValueHandling.Ignore)]
        public List<RocketMQExtendProductIosEntity> Ios { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public RocketMQExtendProductPropertiesEntity Properties { get; set; }

        /// <summary>
        /// **参数解释**： 可用分区列表。RocketMQ 5.X基础版部署架构为单机时，请选择1个可用区，为集群时可选择1个或2个可用区。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 不可用区列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("unavailable_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 支持的特性功能列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public List<RocketMQProductSupportFeaturesEntity> SupportFeatures { get; set; }

        /// <summary>
        /// **参数解释**： 是否为擎天实例。 **约束限制**： 不涉及。 **取值范围**： - true：是擎天实例。 - false：不是擎天实例。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("qingtian_incompatible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QingtianIncompatible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RocketMQExtendProductInfoEntity {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  ecsFlavorId: ").Append(EcsFlavorId).Append("\n");
            sb.Append("  billingCode: ").Append(BillingCode).Append("\n");
            sb.Append("  archTypes: ").Append(ArchTypes).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  ios: ").Append(Ios).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  qingtianIncompatible: ").Append(QingtianIncompatible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RocketMQExtendProductInfoEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RocketMQExtendProductInfoEntity input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.EcsFlavorId != input.EcsFlavorId || (this.EcsFlavorId != null && !this.EcsFlavorId.Equals(input.EcsFlavorId))) return false;
            if (this.BillingCode != input.BillingCode || (this.BillingCode != null && !this.BillingCode.Equals(input.BillingCode))) return false;
            if (this.ArchTypes != input.ArchTypes || (this.ArchTypes != null && input.ArchTypes != null && !this.ArchTypes.SequenceEqual(input.ArchTypes))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && input.ChargingMode != null && !this.ChargingMode.SequenceEqual(input.ChargingMode))) return false;
            if (this.Ios != input.Ios || (this.Ios != null && input.Ios != null && !this.Ios.SequenceEqual(input.Ios))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.UnavailableZones != input.UnavailableZones || (this.UnavailableZones != null && input.UnavailableZones != null && !this.UnavailableZones.SequenceEqual(input.UnavailableZones))) return false;
            if (this.SupportFeatures != input.SupportFeatures || (this.SupportFeatures != null && input.SupportFeatures != null && !this.SupportFeatures.SequenceEqual(input.SupportFeatures))) return false;
            if (this.QingtianIncompatible != input.QingtianIncompatible || (this.QingtianIncompatible != null && !this.QingtianIncompatible.Equals(input.QingtianIncompatible))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.EcsFlavorId != null) hashCode = hashCode * 59 + this.EcsFlavorId.GetHashCode();
                if (this.BillingCode != null) hashCode = hashCode * 59 + this.BillingCode.GetHashCode();
                if (this.ArchTypes != null) hashCode = hashCode * 59 + this.ArchTypes.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.Ios != null) hashCode = hashCode * 59 + this.Ios.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.UnavailableZones != null) hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                if (this.SupportFeatures != null) hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.QingtianIncompatible != null) hashCode = hashCode * 59 + this.QingtianIncompatible.GetHashCode();
                return hashCode;
            }
        }
    }
}
