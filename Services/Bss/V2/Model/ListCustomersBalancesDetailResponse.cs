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
    public class ListCustomersBalancesDetailResponse : SdkResponse
    {

        /// <summary>
        /// 账户余额列表。只有成功的时候才返回。 此列表不包含非代售类子客户的数据。批量查询客户余额时，若入参携带了非代售类子客户，会被过滤。 具体请参见表2。
        /// </summary>
        [JsonProperty("customer_balances", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomerBalancesV2> CustomerBalances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomersBalancesDetailResponse {\n");
            sb.Append("  customerBalances: ").Append(CustomerBalances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCustomersBalancesDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomersBalancesDetailResponse input)
        {
            if (input == null) return false;
            if (this.CustomerBalances != input.CustomerBalances || (this.CustomerBalances != null && input.CustomerBalances != null && !this.CustomerBalances.SequenceEqual(input.CustomerBalances))) return false;

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
                if (this.CustomerBalances != null) hashCode = hashCode * 59 + this.CustomerBalances.GetHashCode();
                return hashCode;
            }
        }
    }
}
