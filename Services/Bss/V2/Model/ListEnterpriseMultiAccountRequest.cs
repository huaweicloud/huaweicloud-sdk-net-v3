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
    /// Request Object
    /// </summary>
    public class ListEnterpriseMultiAccountRequest 
    {

        /// <summary>
        /// 企业子账户的账号ID。
        /// </summary>
        [SDKProperty("sub_customer_id", IsQuery = true)]
        [JsonProperty("sub_customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCustomerId { get; set; }

        /// <summary>
        /// 账户类型：BALANCE_TYPE_DEBIT：余额账户（默认）BALANCE_TYPE_CREDIT：信用账户
        /// </summary>
        [SDKProperty("balance_type", IsQuery = true)]
        [JsonProperty("balance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceType { get; set; }

        /// <summary>
        /// 偏移量，默认值为0。只有信用账户有效。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询条数，默认值为10。只有信用账户有效。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnterpriseMultiAccountRequest {\n");
            sb.Append("  subCustomerId: ").Append(SubCustomerId).Append("\n");
            sb.Append("  balanceType: ").Append(BalanceType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnterpriseMultiAccountRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnterpriseMultiAccountRequest input)
        {
            if (input == null) return false;
            if (this.SubCustomerId != input.SubCustomerId || (this.SubCustomerId != null && !this.SubCustomerId.Equals(input.SubCustomerId))) return false;
            if (this.BalanceType != input.BalanceType || (this.BalanceType != null && !this.BalanceType.Equals(input.BalanceType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.SubCustomerId != null) hashCode = hashCode * 59 + this.SubCustomerId.GetHashCode();
                if (this.BalanceType != null) hashCode = hashCode * 59 + this.BalanceType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
