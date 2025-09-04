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
    public class BalanceTypeDeductSumV2 
    {

        /// <summary>
        /// 账户类型。 BALANCE_TYPE_DEBIT：现金BALANCE_TYPE_CREDIT：信用BALANCE_TYPE_BONUS：奖励BALANCE_TYPE_COUPON：代金券BALANCE_TYPE_RCASH_COUPON 现金券。BALANCE_TYPE_STORED_VALUE_CARD：储值卡消费
        /// </summary>
        [JsonProperty("balance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceType { get; set; }

        /// <summary>
        /// 金额。 对于billType&#x3D;1或者2的账单，该金额为负值。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 账单类型。 0：正常1：退订2：华为核销
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BillType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceTypeDeductSumV2 {\n");
            sb.Append("  balanceType: ").Append(BalanceType).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BalanceTypeDeductSumV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BalanceTypeDeductSumV2 input)
        {
            if (input == null) return false;
            if (this.BalanceType != input.BalanceType || (this.BalanceType != null && !this.BalanceType.Equals(input.BalanceType))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;

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
                if (this.BalanceType != null) hashCode = hashCode * 59 + this.BalanceType.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                return hashCode;
            }
        }
    }
}
