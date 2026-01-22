using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 计费类型信息，支持包年/包月和按需，默认为按需。 **约束限制**： 不涉及
    /// </summary>
    public class CreateFirewallReqChargeInfo 
    {

        /// <summary>
        /// **参数解释**： 计费模式 **约束限制**： 不涉及 **取值范围**： - prePaid：预付费，即包年/包月。 - postPaid：后付费，即按需付费 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// **参数解释**： 订购周期类型 **约束限制**： “charge_mode”为“prePaid”时生效，且为必选值。 **取值范围**： - month：包月。 - year：包年 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// **参数解释**： 订购时间 **约束限制**： “charge_mode”为“prePaid”时，“period_num”必填。 **取值范围**： - 当“period_type”为“month”时，此处取值为1~9。 - 当“period_type”为“year”时，此处取值为1~3。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// **参数解释**： 是否自动续订，续订的周期和原周期相同，且续订时会自动支付。 **约束限制**： 创建包周期实例时可指定 **取值范围**： - true，为自动续订。 - false，为不自动续订 **默认取值**： false
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoRenew { get; set; }

        /// <summary>
        /// **参数解释**： 是否自动从客户的账户中支付，此字段不影响自动续订的支付方式。 **约束限制**： 创建包周期时可指定 **取值范围**： - true：自动支付（会自动选择折扣和优惠券进行优惠，并自动从客户账户中支付），自动支付失败会生成订单、但订单状态为“待支付”，等待客户手动支付（手动支付时，可以修改系统自动选择的折扣和优惠券） - false：手动支付，默认该方式。（需要客户手动去支付，客户可以选择折扣和优惠券） **默认取值**： false
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoPay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFirewallReqChargeInfo {\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFirewallReqChargeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFirewallReqChargeInfo input)
        {
            if (input == null) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.IsAutoPay != input.IsAutoPay || (this.IsAutoPay != null && !this.IsAutoPay.Equals(input.IsAutoPay))) return false;

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
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null) hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
