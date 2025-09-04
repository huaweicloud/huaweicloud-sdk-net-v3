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
    public class ListMultiAccountRetrieveCouponsResponse : SdkResponse
    {

        /// <summary>
        /// 记录条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 可回收余额信息，如果是余额账户，只会有一条记录。 具体请参见表2。
        /// </summary>
        [JsonProperty("avail_retrieve_coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvailRetrieveCoupons> AvailRetrieveCoupons { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMultiAccountRetrieveCouponsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  availRetrieveCoupons: ").Append(AvailRetrieveCoupons).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMultiAccountRetrieveCouponsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMultiAccountRetrieveCouponsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.AvailRetrieveCoupons != input.AvailRetrieveCoupons || (this.AvailRetrieveCoupons != null && input.AvailRetrieveCoupons != null && !this.AvailRetrieveCoupons.SequenceEqual(input.AvailRetrieveCoupons))) return false;

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
                if (this.AvailRetrieveCoupons != null) hashCode = hashCode * 59 + this.AvailRetrieveCoupons.GetHashCode();
                return hashCode;
            }
        }
    }
}
