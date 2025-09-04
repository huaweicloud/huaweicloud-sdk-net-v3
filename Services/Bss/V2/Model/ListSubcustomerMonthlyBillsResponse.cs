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
    public class ListSubcustomerMonthlyBillsResponse : SdkResponse
    {

        /// <summary>
        /// 账单记录，具体参考表2。
        /// </summary>
        [JsonProperty("bill_sums", NullValueHandling = NullValueHandling.Ignore)]
        public List<BillSumInfoV2> BillSums { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 货币编码。 CNY：人民币。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubcustomerMonthlyBillsResponse {\n");
            sb.Append("  billSums: ").Append(BillSums).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubcustomerMonthlyBillsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubcustomerMonthlyBillsResponse input)
        {
            if (input == null) return false;
            if (this.BillSums != input.BillSums || (this.BillSums != null && input.BillSums != null && !this.BillSums.SequenceEqual(input.BillSums))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
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
                if (this.BillSums != null) hashCode = hashCode * 59 + this.BillSums.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
