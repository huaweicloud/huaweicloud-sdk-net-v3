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
    public class ShowCustomerMonthlySumResponse : SdkResponse
    {

        /// <summary>
        /// 总条数，必须大于等于0。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 账单记录，具体参考BillSumRecordInfoV2。
        /// </summary>
        [JsonProperty("bill_sums", NullValueHandling = NullValueHandling.Ignore)]
        public List<BillSumRecordInfoV2> BillSums { get; set; }

        /// <summary>
        /// 总金额（包含退订）。
        /// </summary>
        [JsonProperty("consume_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsumeAmount { get; set; }

        /// <summary>
        /// 总欠费金额。
        /// </summary>
        [JsonProperty("debt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DebtAmount { get; set; }

        /// <summary>
        /// 代金券金额。
        /// </summary>
        [JsonProperty("coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CouponAmount { get; set; }

        /// <summary>
        /// 现金券金额，预留。
        /// </summary>
        [JsonProperty("flexipurchase_coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FlexipurchaseCouponAmount { get; set; }

        /// <summary>
        /// 储值卡金额，预留。
        /// </summary>
        [JsonProperty("stored_value_card_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StoredValueCardAmount { get; set; }

        /// <summary>
        /// 现金账户金额。
        /// </summary>
        [JsonProperty("cash_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CashAmount { get; set; }

        /// <summary>
        /// 信用账户金额。
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreditAmount { get; set; }

        /// <summary>
        /// 欠费核销金额。
        /// </summary>
        [JsonProperty("writeoff_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WriteoffAmount { get; set; }

        /// <summary>
        /// 金额单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 币种。 USD：美元。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCustomerMonthlySumResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  billSums: ").Append(BillSums).Append("\n");
            sb.Append("  consumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  flexipurchaseCouponAmount: ").Append(FlexipurchaseCouponAmount).Append("\n");
            sb.Append("  storedValueCardAmount: ").Append(StoredValueCardAmount).Append("\n");
            sb.Append("  cashAmount: ").Append(CashAmount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  writeoffAmount: ").Append(WriteoffAmount).Append("\n");
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
            return this.Equals(input as ShowCustomerMonthlySumResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCustomerMonthlySumResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.BillSums != input.BillSums || (this.BillSums != null && input.BillSums != null && !this.BillSums.SequenceEqual(input.BillSums))) return false;
            if (this.ConsumeAmount != input.ConsumeAmount || (this.ConsumeAmount != null && !this.ConsumeAmount.Equals(input.ConsumeAmount))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.FlexipurchaseCouponAmount != input.FlexipurchaseCouponAmount || (this.FlexipurchaseCouponAmount != null && !this.FlexipurchaseCouponAmount.Equals(input.FlexipurchaseCouponAmount))) return false;
            if (this.StoredValueCardAmount != input.StoredValueCardAmount || (this.StoredValueCardAmount != null && !this.StoredValueCardAmount.Equals(input.StoredValueCardAmount))) return false;
            if (this.CashAmount != input.CashAmount || (this.CashAmount != null && !this.CashAmount.Equals(input.CashAmount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.WriteoffAmount != input.WriteoffAmount || (this.WriteoffAmount != null && !this.WriteoffAmount.Equals(input.WriteoffAmount))) return false;
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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.BillSums != null) hashCode = hashCode * 59 + this.BillSums.GetHashCode();
                if (this.ConsumeAmount != null) hashCode = hashCode * 59 + this.ConsumeAmount.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.FlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.FlexipurchaseCouponAmount.GetHashCode();
                if (this.StoredValueCardAmount != null) hashCode = hashCode * 59 + this.StoredValueCardAmount.GetHashCode();
                if (this.CashAmount != null) hashCode = hashCode * 59 + this.CashAmount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.WriteoffAmount != null) hashCode = hashCode * 59 + this.WriteoffAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
