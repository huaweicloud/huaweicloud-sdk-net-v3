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
    public class RetrieveAmountInfoV2 
    {

        /// <summary>
        /// 可回收的金额。
        /// </summary>
        [JsonProperty("avail_retrieve_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AvailRetrieveAmount { get; set; }

        /// <summary>
        /// 金额单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 币种。 CNY：人民币
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 账户余额（仅balance_type&#x3D;信用账户时这个字段才有值）。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 信用额度（仅balance_type&#x3D;信用账户时这个字段才有值）。
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreditAmount { get; set; }

        /// <summary>
        /// 信用额度过期时间。 UTC时间，格式为：2016-03-28T14:45:38Z。 如果查询信用账户可回收余额的查询结果没有失效时间，表示永久有效。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveAmountInfoV2 {\n");
            sb.Append("  availRetrieveAmount: ").Append(AvailRetrieveAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetrieveAmountInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetrieveAmountInfoV2 input)
        {
            if (input == null) return false;
            if (this.AvailRetrieveAmount != input.AvailRetrieveAmount || (this.AvailRetrieveAmount != null && !this.AvailRetrieveAmount.Equals(input.AvailRetrieveAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.AvailRetrieveAmount != null) hashCode = hashCode * 59 + this.AvailRetrieveAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
