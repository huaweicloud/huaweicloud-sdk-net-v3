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
    public class ShowCustomerExpenditureQuotaResponse : SdkResponse
    {

        /// <summary>
        /// |参数名称：消费配额| |参数约束及描述：当前授予额度，消费配额。|
        /// </summary>
        [JsonProperty("granting_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? GrantingAmount { get; set; }

        /// <summary>
        /// |参数名称：已使用消费配额| |参数约束及描述：已使用消费配额。|
        /// </summary>
        [JsonProperty("granting_amount_used", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? GrantingAmountUsed { get; set; }

        /// <summary>
        /// |参数名称：已使用消费配额占比| |参数约束及描述：已使用消费配额占比。|
        /// </summary>
        [JsonProperty("percentage_granting_amount_used", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PercentageGrantingAmountUsed { get; set; }

        /// <summary>
        /// |参数名称：金额的度量单位。| |参数约束及描述：1：元|
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// |参数名称：币种。| |参数约束及描述：货币单位，USD：美元。|
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCustomerExpenditureQuotaResponse {\n");
            sb.Append("  grantingAmount: ").Append(GrantingAmount).Append("\n");
            sb.Append("  grantingAmountUsed: ").Append(GrantingAmountUsed).Append("\n");
            sb.Append("  percentageGrantingAmountUsed: ").Append(PercentageGrantingAmountUsed).Append("\n");
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
            return this.Equals(input as ShowCustomerExpenditureQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCustomerExpenditureQuotaResponse input)
        {
            if (input == null) return false;
            if (this.GrantingAmount != input.GrantingAmount || (this.GrantingAmount != null && !this.GrantingAmount.Equals(input.GrantingAmount))) return false;
            if (this.GrantingAmountUsed != input.GrantingAmountUsed || (this.GrantingAmountUsed != null && !this.GrantingAmountUsed.Equals(input.GrantingAmountUsed))) return false;
            if (this.PercentageGrantingAmountUsed != input.PercentageGrantingAmountUsed || (this.PercentageGrantingAmountUsed != null && !this.PercentageGrantingAmountUsed.Equals(input.PercentageGrantingAmountUsed))) return false;
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
                if (this.GrantingAmount != null) hashCode = hashCode * 59 + this.GrantingAmount.GetHashCode();
                if (this.GrantingAmountUsed != null) hashCode = hashCode * 59 + this.GrantingAmountUsed.GetHashCode();
                if (this.PercentageGrantingAmountUsed != null) hashCode = hashCode * 59 + this.PercentageGrantingAmountUsed.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
