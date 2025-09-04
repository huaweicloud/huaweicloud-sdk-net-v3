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
    public class ListPostpaidBillSumResponse : SdkResponse
    {

        /// <summary>
        /// 账单所归属的月份。只有成功才返回这个参数。 格式：YYYY-MM
        /// </summary>
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 账单中的应还金额（含税）。 应还金额（包含销项税）&#x3D;消费金额+退款金额+调账金额
        /// </summary>
        [JsonProperty("initial_amount_due", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? InitialAmountDue { get; set; }

        /// <summary>
        /// 账单中的消费金额。
        /// </summary>
        [JsonProperty("consume_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsumeAmount { get; set; }

        /// <summary>
        /// 账单中的退款金额。
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Refunds { get; set; }

        /// <summary>
        /// 账单中的调账金额，即伙伴在账期内的调账信息如：欠款核销金额等。
        /// </summary>
        [JsonProperty("adjustments", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Adjustments { get; set; }

        /// <summary>
        /// 账单中的销项税金额，销项税不计入应还金额。
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// 只有成功才返回这个参数。 美金：USD
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPostpaidBillSumResponse {\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  initialAmountDue: ").Append(InitialAmountDue).Append("\n");
            sb.Append("  consumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  refunds: ").Append(Refunds).Append("\n");
            sb.Append("  adjustments: ").Append(Adjustments).Append("\n");
            sb.Append("  taxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPostpaidBillSumResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPostpaidBillSumResponse input)
        {
            if (input == null) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.InitialAmountDue != input.InitialAmountDue || (this.InitialAmountDue != null && !this.InitialAmountDue.Equals(input.InitialAmountDue))) return false;
            if (this.ConsumeAmount != input.ConsumeAmount || (this.ConsumeAmount != null && !this.ConsumeAmount.Equals(input.ConsumeAmount))) return false;
            if (this.Refunds != input.Refunds || (this.Refunds != null && !this.Refunds.Equals(input.Refunds))) return false;
            if (this.Adjustments != input.Adjustments || (this.Adjustments != null && !this.Adjustments.Equals(input.Adjustments))) return false;
            if (this.TaxAmount != input.TaxAmount || (this.TaxAmount != null && !this.TaxAmount.Equals(input.TaxAmount))) return false;
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
                if (this.BillCycle != null) hashCode = hashCode * 59 + this.BillCycle.GetHashCode();
                if (this.InitialAmountDue != null) hashCode = hashCode * 59 + this.InitialAmountDue.GetHashCode();
                if (this.ConsumeAmount != null) hashCode = hashCode * 59 + this.ConsumeAmount.GetHashCode();
                if (this.Refunds != null) hashCode = hashCode * 59 + this.Refunds.GetHashCode();
                if (this.Adjustments != null) hashCode = hashCode * 59 + this.Adjustments.GetHashCode();
                if (this.TaxAmount != null) hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
