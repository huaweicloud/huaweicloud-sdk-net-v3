using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowCustomerAccountBalancesResponse : SdkResponse
    {

        /// <summary>
        /// 账户余额列表。 具体请参见表1。
        /// </summary>
        [JsonProperty("account_balances", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountBalanceV3> AccountBalances { get; set; }

        /// <summary>
        /// 欠款总金额。
        /// </summary>
        [JsonProperty("debt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DebtAmount { get; set; }

        /// <summary>
        /// 度量单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 币种。 CNY：人民币。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCustomerAccountBalancesResponse {\n");
            sb.Append("  accountBalances: ").Append(AccountBalances).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
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
            return this.Equals(input as ShowCustomerAccountBalancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCustomerAccountBalancesResponse input)
        {
            if (input == null) return false;
            if (this.AccountBalances != input.AccountBalances || (this.AccountBalances != null && input.AccountBalances != null && !this.AccountBalances.SequenceEqual(input.AccountBalances))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
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
                if (this.AccountBalances != null) hashCode = hashCode * 59 + this.AccountBalances.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
