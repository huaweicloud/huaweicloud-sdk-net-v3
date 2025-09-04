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
    public class ListMultiAccountTransferCouponsResponse : SdkResponse
    {

        /// <summary>
        /// 记录条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 可拨款优惠券记录。 具体请参见表2。
        /// </summary>
        [JsonProperty("avail_transfer_coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvailTransferCoupon> AvailTransferCoupons { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMultiAccountTransferCouponsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  availTransferCoupons: ").Append(AvailTransferCoupons).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMultiAccountTransferCouponsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMultiAccountTransferCouponsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.AvailTransferCoupons != input.AvailTransferCoupons || (this.AvailTransferCoupons != null && input.AvailTransferCoupons != null && !this.AvailTransferCoupons.SequenceEqual(input.AvailTransferCoupons))) return false;

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
                if (this.AvailTransferCoupons != null) hashCode = hashCode * 59 + this.AvailTransferCoupons.GetHashCode();
                return hashCode;
            }
        }
    }
}
