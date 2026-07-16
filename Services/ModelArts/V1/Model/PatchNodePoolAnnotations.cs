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
    /// 更新节点池metadata的注释信息。
    /// </summary>
    public class PatchNodePoolAnnotations 
    {

        /// <summary>
        /// **参数解释**：计费模式，不指定时新创节点沿用资源池计费模式。 **取值范围**：可选值如下： - 0：按需计费 - [1：包周期计费](tag:hc)
        /// </summary>
        [JsonProperty("os.modelarts/billing.mode", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsBillingMode { get; set; }

        /// <summary>
        /// **参数解释**：包周期订购周期，比如2。当计费模式为包周期时该参数必传。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/period.num", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPeriodNum { get; set; }

        /// <summary>
        /// **参数解释**：包周期订购类型。当计费模式为包周期时该参数必传。 **取值范围**：可选值如下： - 2：月 - 3：年
        /// </summary>
        [JsonProperty("os.modelarts/period.type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPeriodType { get; set; }

        /// <summary>
        /// **参数解释**：是否自动续费，不指定时新创节点沿用资源池自动续费属性。 **取值范围**：可选值如下： - 0：不自动续费，默认值 - 1：自动续费
        /// </summary>
        [JsonProperty("os.modelarts/auto.renew", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsAutoRenew { get; set; }

        /// <summary>
        /// **参数解释**：用户在运营平台选择的折扣信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/promotion.info", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsPromotionInfo { get; set; }

        /// <summary>
        /// **参数解释**：订购订单支付完成后跳转的url地址。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/service.console.url", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsServiceConsoleUrl { get; set; }

        /// <summary>
        /// **参数解释**：订单id，包周期资源创建或者计费模式变更的时候该参数必需。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/order.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsOrderId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchNodePoolAnnotations {\n");
            sb.Append("  osModelartsBillingMode: ").Append(OsModelartsBillingMode).Append("\n");
            sb.Append("  osModelartsPeriodNum: ").Append(OsModelartsPeriodNum).Append("\n");
            sb.Append("  osModelartsPeriodType: ").Append(OsModelartsPeriodType).Append("\n");
            sb.Append("  osModelartsAutoRenew: ").Append(OsModelartsAutoRenew).Append("\n");
            sb.Append("  osModelartsPromotionInfo: ").Append(OsModelartsPromotionInfo).Append("\n");
            sb.Append("  osModelartsServiceConsoleUrl: ").Append(OsModelartsServiceConsoleUrl).Append("\n");
            sb.Append("  osModelartsOrderId: ").Append(OsModelartsOrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PatchNodePoolAnnotations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PatchNodePoolAnnotations input)
        {
            if (input == null) return false;
            if (this.OsModelartsBillingMode != input.OsModelartsBillingMode || (this.OsModelartsBillingMode != null && !this.OsModelartsBillingMode.Equals(input.OsModelartsBillingMode))) return false;
            if (this.OsModelartsPeriodNum != input.OsModelartsPeriodNum || (this.OsModelartsPeriodNum != null && !this.OsModelartsPeriodNum.Equals(input.OsModelartsPeriodNum))) return false;
            if (this.OsModelartsPeriodType != input.OsModelartsPeriodType || (this.OsModelartsPeriodType != null && !this.OsModelartsPeriodType.Equals(input.OsModelartsPeriodType))) return false;
            if (this.OsModelartsAutoRenew != input.OsModelartsAutoRenew || (this.OsModelartsAutoRenew != null && !this.OsModelartsAutoRenew.Equals(input.OsModelartsAutoRenew))) return false;
            if (this.OsModelartsPromotionInfo != input.OsModelartsPromotionInfo || (this.OsModelartsPromotionInfo != null && !this.OsModelartsPromotionInfo.Equals(input.OsModelartsPromotionInfo))) return false;
            if (this.OsModelartsServiceConsoleUrl != input.OsModelartsServiceConsoleUrl || (this.OsModelartsServiceConsoleUrl != null && !this.OsModelartsServiceConsoleUrl.Equals(input.OsModelartsServiceConsoleUrl))) return false;
            if (this.OsModelartsOrderId != input.OsModelartsOrderId || (this.OsModelartsOrderId != null && !this.OsModelartsOrderId.Equals(input.OsModelartsOrderId))) return false;

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
                if (this.OsModelartsBillingMode != null) hashCode = hashCode * 59 + this.OsModelartsBillingMode.GetHashCode();
                if (this.OsModelartsPeriodNum != null) hashCode = hashCode * 59 + this.OsModelartsPeriodNum.GetHashCode();
                if (this.OsModelartsPeriodType != null) hashCode = hashCode * 59 + this.OsModelartsPeriodType.GetHashCode();
                if (this.OsModelartsAutoRenew != null) hashCode = hashCode * 59 + this.OsModelartsAutoRenew.GetHashCode();
                if (this.OsModelartsPromotionInfo != null) hashCode = hashCode * 59 + this.OsModelartsPromotionInfo.GetHashCode();
                if (this.OsModelartsServiceConsoleUrl != null) hashCode = hashCode * 59 + this.OsModelartsServiceConsoleUrl.GetHashCode();
                if (this.OsModelartsOrderId != null) hashCode = hashCode * 59 + this.OsModelartsOrderId.GetHashCode();
                return hashCode;
            }
        }
    }
}
