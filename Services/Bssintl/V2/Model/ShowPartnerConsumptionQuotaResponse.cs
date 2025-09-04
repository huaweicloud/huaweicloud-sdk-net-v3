using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPartnerConsumptionQuotaResponse : SdkResponse
    {

        /// <summary>
        /// |参数名称：总消费配额| |参数约束及描述：非必填|
        /// </summary>
        [JsonProperty("consumption_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumptionQuota { get; set; }

        /// <summary>
        /// |参数名称：账户余额| |参数约束及描述：非必填|
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// |参数名称：代金券余额| |参数约束及描述：非必填|
        /// </summary>
        [JsonProperty("coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponAmount { get; set; }

        /// <summary>
        /// |参数名称：应还金额| |参数约束及描述：非必填|
        /// </summary>
        [JsonProperty("due_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DueAmount { get; set; }

        /// <summary>
        /// |参数名称：未出账预估金额| |参数约束及描述：非必填|
        /// </summary>
        [JsonProperty("unbilled_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string UnbilledAmount { get; set; }

        /// <summary>
        /// |参数名称：已使用消费配额| |参数约束及描述：非必填，used_consumption_quota &#x3D; due_amount + unbilled_amount - amount - coupon_amount|
        /// </summary>
        [JsonProperty("used_consumption_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedConsumptionQuota { get; set; }

        /// <summary>
        /// |参数名称：金额单位| |参数约束及描述：金额单位，1：元|
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// |参数名称：货币单位| |参数约束及描述：货币单位 |
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPartnerConsumptionQuotaResponse {\n");
            sb.Append("  consumptionQuota: ").Append(ConsumptionQuota).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  dueAmount: ").Append(DueAmount).Append("\n");
            sb.Append("  unbilledAmount: ").Append(UnbilledAmount).Append("\n");
            sb.Append("  usedConsumptionQuota: ").Append(UsedConsumptionQuota).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPartnerConsumptionQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPartnerConsumptionQuotaResponse input)
        {
            if (input == null) return false;
            if (this.ConsumptionQuota != input.ConsumptionQuota || (this.ConsumptionQuota != null && !this.ConsumptionQuota.Equals(input.ConsumptionQuota))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.DueAmount != input.DueAmount || (this.DueAmount != null && !this.DueAmount.Equals(input.DueAmount))) return false;
            if (this.UnbilledAmount != input.UnbilledAmount || (this.UnbilledAmount != null && !this.UnbilledAmount.Equals(input.UnbilledAmount))) return false;
            if (this.UsedConsumptionQuota != input.UsedConsumptionQuota || (this.UsedConsumptionQuota != null && !this.UsedConsumptionQuota.Equals(input.UsedConsumptionQuota))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;

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
                if (this.ConsumptionQuota != null) hashCode = hashCode * 59 + this.ConsumptionQuota.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.DueAmount != null) hashCode = hashCode * 59 + this.DueAmount.GetHashCode();
                if (this.UnbilledAmount != null) hashCode = hashCode * 59 + this.UnbilledAmount.GetHashCode();
                if (this.UsedConsumptionQuota != null) hashCode = hashCode * 59 + this.UsedConsumptionQuota.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
