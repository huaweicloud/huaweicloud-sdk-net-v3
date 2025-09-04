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
    public class ListPartnerBalancesResponse : SdkResponse
    {

        /// <summary>
        /// 账户余额列表。 具体请参见表2
        /// </summary>
        [JsonProperty("account_balances", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountBalanceV2> AccountBalances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPartnerBalancesResponse {\n");
            sb.Append("  accountBalances: ").Append(AccountBalances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPartnerBalancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPartnerBalancesResponse input)
        {
            if (input == null) return false;
            if (this.AccountBalances != input.AccountBalances || (this.AccountBalances != null && input.AccountBalances != null && !this.AccountBalances.SequenceEqual(input.AccountBalances))) return false;

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
                return hashCode;
            }
        }
    }
}
