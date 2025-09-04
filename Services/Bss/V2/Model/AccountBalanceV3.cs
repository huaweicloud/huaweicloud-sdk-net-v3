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
    /// 
    /// </summary>
    public class AccountBalanceV3 
    {

        /// <summary>
        /// 账户标识。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 账户类型。 1：余额2：信用5：奖励金7：保证金
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountType { get; set; }

        /// <summary>
        /// 账户余额。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 币种。 CNY：人民币。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 专款专用余额。
        /// </summary>
        [JsonProperty("designated_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DesignatedAmount { get; set; }

        /// <summary>
        /// 总信用额度，仅信用账户存在该字段。
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreditAmount { get; set; }

        /// <summary>
        /// 度量单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountBalanceV3 {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  designatedAmount: ").Append(DesignatedAmount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountBalanceV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountBalanceV3 input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccountType != input.AccountType || (this.AccountType != null && !this.AccountType.Equals(input.AccountType))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.DesignatedAmount != input.DesignatedAmount || (this.DesignatedAmount != null && !this.DesignatedAmount.Equals(input.DesignatedAmount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountType != null) hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DesignatedAmount != null) hashCode = hashCode * 59 + this.DesignatedAmount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
