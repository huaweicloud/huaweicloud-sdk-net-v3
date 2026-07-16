using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 资源池metadata的注释信息。
    /// </summary>
    public class PoolMetaAnnotations 
    {

        /// <summary>
        /// **参数解释**：资源池的描述信息。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/description", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsDescription { get; set; }

        /// <summary>
        /// **参数解释**：计费模式。 **约束限制**：不涉及。 **取值范围**：可选值如下： - 0：按需计费 - 1：包周期计费 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/billing.mode", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsBillingMode { get; set; }

        /// <summary>
        /// **参数解释**：包周期资源池的订购周期。 **约束限制**：和os.modelarts/period.type字段配合使用。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/period.num", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPeriodNum { get; set; }

        /// <summary>
        /// **参数解释**：包周期资源池的订购类型。 **约束限制**：和os.modelarts/period.num字段配合使用。 **取值范围**：可选值如下： - 2：包月。 - 3：包年。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/period.type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPeriodType { get; set; }

        /// <summary>
        /// **参数解释**：包周期资源池的自动续费类型。 **约束限制**：不涉及。 **取值范围**：可选值如下： - 0：不自动续费。 - 1：自动续费。 **默认取值**：0。
        /// </summary>
        [JsonProperty("os.modelarts/auto.renew", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsAutoRenew { get; set; }

        /// <summary>
        /// **参数解释**：包周期资源池购买时选择的折扣信息。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/promotion.info", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPromotionInfo { get; set; }

        /// <summary>
        /// **参数解释**：购买包周期资源在订单支付完成后跳转地址。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/service.console.url", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsServiceConsoleUrl { get; set; }

        /// <summary>
        /// **参数解释**：包周期资源池购买时传递的订单ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/order.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsOrderId { get; set; }

        /// <summary>
        /// **参数解释**：包周期资源池中资源规格对应的资源ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/flavor.resource.ids", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsFlavorResourceIds { get; set; }

        /// <summary>
        /// **参数解释**：资源池上的资源标签。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/tms.tags", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsTmsTags { get; set; }

        /// <summary>
        /// **参数解释**：资源池调度队列的策略，用于定义任务调度的规则。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.pool/scheduler.queue.strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPoolSchedulerQueueStrategy { get; set; }

        /// <summary>
        /// **参数解释**：资源池包含的逻辑子池的数量。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.pool/subpools.count", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPoolSubpoolsCount { get; set; }

        /// <summary>
        /// **参数解释**：资源池的租户账号 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/tenant.domain.name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsTenantDomainName { get; set; }

        /// <summary>
        /// **参数解释**：训练外部依赖标识 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.pool/scope.external.dependency.train", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPoolScopeExternalDependencyTrain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolMetaAnnotations {\n");
            sb.Append("  osModelartsDescription: ").Append(OsModelartsDescription).Append("\n");
            sb.Append("  osModelartsBillingMode: ").Append(OsModelartsBillingMode).Append("\n");
            sb.Append("  osModelartsPeriodNum: ").Append(OsModelartsPeriodNum).Append("\n");
            sb.Append("  osModelartsPeriodType: ").Append(OsModelartsPeriodType).Append("\n");
            sb.Append("  osModelartsAutoRenew: ").Append(OsModelartsAutoRenew).Append("\n");
            sb.Append("  osModelartsPromotionInfo: ").Append(OsModelartsPromotionInfo).Append("\n");
            sb.Append("  osModelartsServiceConsoleUrl: ").Append(OsModelartsServiceConsoleUrl).Append("\n");
            sb.Append("  osModelartsOrderId: ").Append(OsModelartsOrderId).Append("\n");
            sb.Append("  osModelartsFlavorResourceIds: ").Append(OsModelartsFlavorResourceIds).Append("\n");
            sb.Append("  osModelartsTmsTags: ").Append(OsModelartsTmsTags).Append("\n");
            sb.Append("  osModelartsPoolSchedulerQueueStrategy: ").Append(OsModelartsPoolSchedulerQueueStrategy).Append("\n");
            sb.Append("  osModelartsPoolSubpoolsCount: ").Append(OsModelartsPoolSubpoolsCount).Append("\n");
            sb.Append("  osModelartsTenantDomainName: ").Append(OsModelartsTenantDomainName).Append("\n");
            sb.Append("  osModelartsPoolScopeExternalDependencyTrain: ").Append(OsModelartsPoolScopeExternalDependencyTrain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolMetaAnnotations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolMetaAnnotations input)
        {
            if (input == null) return false;
            if (this.OsModelartsDescription != input.OsModelartsDescription || (this.OsModelartsDescription != null && !this.OsModelartsDescription.Equals(input.OsModelartsDescription))) return false;
            if (this.OsModelartsBillingMode != input.OsModelartsBillingMode || (this.OsModelartsBillingMode != null && !this.OsModelartsBillingMode.Equals(input.OsModelartsBillingMode))) return false;
            if (this.OsModelartsPeriodNum != input.OsModelartsPeriodNum || (this.OsModelartsPeriodNum != null && !this.OsModelartsPeriodNum.Equals(input.OsModelartsPeriodNum))) return false;
            if (this.OsModelartsPeriodType != input.OsModelartsPeriodType || (this.OsModelartsPeriodType != null && !this.OsModelartsPeriodType.Equals(input.OsModelartsPeriodType))) return false;
            if (this.OsModelartsAutoRenew != input.OsModelartsAutoRenew || (this.OsModelartsAutoRenew != null && !this.OsModelartsAutoRenew.Equals(input.OsModelartsAutoRenew))) return false;
            if (this.OsModelartsPromotionInfo != input.OsModelartsPromotionInfo || (this.OsModelartsPromotionInfo != null && !this.OsModelartsPromotionInfo.Equals(input.OsModelartsPromotionInfo))) return false;
            if (this.OsModelartsServiceConsoleUrl != input.OsModelartsServiceConsoleUrl || (this.OsModelartsServiceConsoleUrl != null && !this.OsModelartsServiceConsoleUrl.Equals(input.OsModelartsServiceConsoleUrl))) return false;
            if (this.OsModelartsOrderId != input.OsModelartsOrderId || (this.OsModelartsOrderId != null && !this.OsModelartsOrderId.Equals(input.OsModelartsOrderId))) return false;
            if (this.OsModelartsFlavorResourceIds != input.OsModelartsFlavorResourceIds || (this.OsModelartsFlavorResourceIds != null && !this.OsModelartsFlavorResourceIds.Equals(input.OsModelartsFlavorResourceIds))) return false;
            if (this.OsModelartsTmsTags != input.OsModelartsTmsTags || (this.OsModelartsTmsTags != null && !this.OsModelartsTmsTags.Equals(input.OsModelartsTmsTags))) return false;
            if (this.OsModelartsPoolSchedulerQueueStrategy != input.OsModelartsPoolSchedulerQueueStrategy || (this.OsModelartsPoolSchedulerQueueStrategy != null && !this.OsModelartsPoolSchedulerQueueStrategy.Equals(input.OsModelartsPoolSchedulerQueueStrategy))) return false;
            if (this.OsModelartsPoolSubpoolsCount != input.OsModelartsPoolSubpoolsCount || (this.OsModelartsPoolSubpoolsCount != null && !this.OsModelartsPoolSubpoolsCount.Equals(input.OsModelartsPoolSubpoolsCount))) return false;
            if (this.OsModelartsTenantDomainName != input.OsModelartsTenantDomainName || (this.OsModelartsTenantDomainName != null && !this.OsModelartsTenantDomainName.Equals(input.OsModelartsTenantDomainName))) return false;
            if (this.OsModelartsPoolScopeExternalDependencyTrain != input.OsModelartsPoolScopeExternalDependencyTrain || (this.OsModelartsPoolScopeExternalDependencyTrain != null && !this.OsModelartsPoolScopeExternalDependencyTrain.Equals(input.OsModelartsPoolScopeExternalDependencyTrain))) return false;

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
                if (this.OsModelartsDescription != null) hashCode = hashCode * 59 + this.OsModelartsDescription.GetHashCode();
                if (this.OsModelartsBillingMode != null) hashCode = hashCode * 59 + this.OsModelartsBillingMode.GetHashCode();
                if (this.OsModelartsPeriodNum != null) hashCode = hashCode * 59 + this.OsModelartsPeriodNum.GetHashCode();
                if (this.OsModelartsPeriodType != null) hashCode = hashCode * 59 + this.OsModelartsPeriodType.GetHashCode();
                if (this.OsModelartsAutoRenew != null) hashCode = hashCode * 59 + this.OsModelartsAutoRenew.GetHashCode();
                if (this.OsModelartsPromotionInfo != null) hashCode = hashCode * 59 + this.OsModelartsPromotionInfo.GetHashCode();
                if (this.OsModelartsServiceConsoleUrl != null) hashCode = hashCode * 59 + this.OsModelartsServiceConsoleUrl.GetHashCode();
                if (this.OsModelartsOrderId != null) hashCode = hashCode * 59 + this.OsModelartsOrderId.GetHashCode();
                if (this.OsModelartsFlavorResourceIds != null) hashCode = hashCode * 59 + this.OsModelartsFlavorResourceIds.GetHashCode();
                if (this.OsModelartsTmsTags != null) hashCode = hashCode * 59 + this.OsModelartsTmsTags.GetHashCode();
                if (this.OsModelartsPoolSchedulerQueueStrategy != null) hashCode = hashCode * 59 + this.OsModelartsPoolSchedulerQueueStrategy.GetHashCode();
                if (this.OsModelartsPoolSubpoolsCount != null) hashCode = hashCode * 59 + this.OsModelartsPoolSubpoolsCount.GetHashCode();
                if (this.OsModelartsTenantDomainName != null) hashCode = hashCode * 59 + this.OsModelartsTenantDomainName.GetHashCode();
                if (this.OsModelartsPoolScopeExternalDependencyTrain != null) hashCode = hashCode * 59 + this.OsModelartsPoolScopeExternalDependencyTrain.GetHashCode();
                return hashCode;
            }
        }
    }
}
