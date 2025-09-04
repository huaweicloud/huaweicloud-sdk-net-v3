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
    public class TransferEnterpriseMultiAccountReq 
    {

        /// <summary>
        /// 企业子账号的客户ID。您可以调用查询企业子账号列表接口，获取响应参数“id”的返回值。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 现金账户总划拨金额。 单位：元。取值大于0且精确到小数点后2位。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 交易序列号，用于防止重复提交。 如果接口调用方不传此参数的值，则系统自动生成。如果接口调用方传入此参数的值，请采用UUID保证全局唯一。
        /// </summary>
        [JsonProperty("trans_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransId { get; set; }

        /// <summary>
        /// 账户类型： BALANCE_TYPE_DEBIT：余额账户（默认）BALANCE_TYPE_CREDIT：信用账户
        /// </summary>
        [JsonProperty("balance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceType { get; set; }

        /// <summary>
        /// 账户到期时间，UTC时间，格式为：2016-03-28T14:45:38Z。 只对信用账户有效，用于限制针对有效期到期时间等于该时间的信用账户余额进行拨款，精确到秒。如果查询信用账户可拨款余额的查询结果没有失效时间，表示永久有效，对于这种账本拨款的情况无需填写。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferEnterpriseMultiAccountReq {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  transId: ").Append(TransId).Append("\n");
            sb.Append("  balanceType: ").Append(BalanceType).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferEnterpriseMultiAccountReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferEnterpriseMultiAccountReq input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.TransId != input.TransId || (this.TransId != null && !this.TransId.Equals(input.TransId))) return false;
            if (this.BalanceType != input.BalanceType || (this.BalanceType != null && !this.BalanceType.Equals(input.BalanceType))) return false;
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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TransId != null) hashCode = hashCode * 59 + this.TransId.GetHashCode();
                if (this.BalanceType != null) hashCode = hashCode * 59 + this.BalanceType.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
