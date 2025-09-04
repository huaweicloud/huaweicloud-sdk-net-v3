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
    public class CouponMaxUseQuantity 
    {

        /// <summary>
        /// 优惠券类型。 1：代金券2：折扣券3：产品券4：现金券
        /// </summary>
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponType { get; set; }

        /// <summary>
        /// 优惠券分组。 1：云商店发放的券2：华为云券-1024-专用代金券3：华为云券-使用限制-抵扣硬件的券0：华为云服务券（排除上述取值之外的券）
        /// </summary>
        [JsonProperty("coupon_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponGroup { get; set; }

        /// <summary>
        /// 优惠券使用数量。
        /// </summary>
        [JsonProperty("use_quantity_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? UseQuantityValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponMaxUseQuantity {\n");
            sb.Append("  couponType: ").Append(CouponType).Append("\n");
            sb.Append("  couponGroup: ").Append(CouponGroup).Append("\n");
            sb.Append("  useQuantityValue: ").Append(UseQuantityValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CouponMaxUseQuantity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CouponMaxUseQuantity input)
        {
            if (input == null) return false;
            if (this.CouponType != input.CouponType || (this.CouponType != null && !this.CouponType.Equals(input.CouponType))) return false;
            if (this.CouponGroup != input.CouponGroup || (this.CouponGroup != null && !this.CouponGroup.Equals(input.CouponGroup))) return false;
            if (this.UseQuantityValue != input.UseQuantityValue || (this.UseQuantityValue != null && !this.UseQuantityValue.Equals(input.UseQuantityValue))) return false;

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
                if (this.CouponType != null) hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.CouponGroup != null) hashCode = hashCode * 59 + this.CouponGroup.GetHashCode();
                if (this.UseQuantityValue != null) hashCode = hashCode * 59 + this.UseQuantityValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
