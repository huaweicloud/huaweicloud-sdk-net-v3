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
    public class ListOrderCouponsByOrderIdResponse : SdkResponse
    {

        /// <summary>
        /// 查询总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 可用的优惠券列表。 具体请参见表2。
        /// </summary>
        [JsonProperty("user_coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<CouponInfoV2> UserCoupons { get; set; }

        /// <summary>
        /// 优惠券使用的最大数量。 具体请参见表4。
        /// </summary>
        [JsonProperty("coupon_max_use_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public List<CouponMaxUseQuantity> CouponMaxUseQuantity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOrderCouponsByOrderIdResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  userCoupons: ").Append(UserCoupons).Append("\n");
            sb.Append("  couponMaxUseQuantity: ").Append(CouponMaxUseQuantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOrderCouponsByOrderIdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOrderCouponsByOrderIdResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.UserCoupons != input.UserCoupons || (this.UserCoupons != null && input.UserCoupons != null && !this.UserCoupons.SequenceEqual(input.UserCoupons))) return false;
            if (this.CouponMaxUseQuantity != input.CouponMaxUseQuantity || (this.CouponMaxUseQuantity != null && input.CouponMaxUseQuantity != null && !this.CouponMaxUseQuantity.SequenceEqual(input.CouponMaxUseQuantity))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.UserCoupons != null) hashCode = hashCode * 59 + this.UserCoupons.GetHashCode();
                if (this.CouponMaxUseQuantity != null) hashCode = hashCode * 59 + this.CouponMaxUseQuantity.GetHashCode();
                return hashCode;
            }
        }
    }
}
