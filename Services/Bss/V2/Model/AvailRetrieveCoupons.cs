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
    public class AvailRetrieveCoupons 
    {

        /// <summary>
        /// 主优惠券ID。
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// 促销计划名称。
        /// </summary>
        [JsonProperty("plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanName { get; set; }

        /// <summary>
        /// 子优惠券ID。主优惠券拨款后生成的子优惠券ID。
        /// </summary>
        [JsonProperty("sub_coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCouponId { get; set; }

        /// <summary>
        /// 优惠券余额。单位为元
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// 生效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 优惠券限制。 具体请参见表3。
        /// </summary>
        [JsonProperty("use_limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<ICouponUseLimitInfoV2> UseLimits { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailRetrieveCoupons {\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  planName: ").Append(PlanName).Append("\n");
            sb.Append("  subCouponId: ").Append(SubCouponId).Append("\n");
            sb.Append("  balance: ").Append(Balance).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  useLimits: ").Append(UseLimits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AvailRetrieveCoupons);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AvailRetrieveCoupons input)
        {
            if (input == null) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.PlanName != input.PlanName || (this.PlanName != null && !this.PlanName.Equals(input.PlanName))) return false;
            if (this.SubCouponId != input.SubCouponId || (this.SubCouponId != null && !this.SubCouponId.Equals(input.SubCouponId))) return false;
            if (this.Balance != input.Balance || (this.Balance != null && !this.Balance.Equals(input.Balance))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.UseLimits != input.UseLimits || (this.UseLimits != null && input.UseLimits != null && !this.UseLimits.SequenceEqual(input.UseLimits))) return false;

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
                if (this.CouponId != null) hashCode = hashCode * 59 + this.CouponId.GetHashCode();
                if (this.PlanName != null) hashCode = hashCode * 59 + this.PlanName.GetHashCode();
                if (this.SubCouponId != null) hashCode = hashCode * 59 + this.SubCouponId.GetHashCode();
                if (this.Balance != null) hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.UseLimits != null) hashCode = hashCode * 59 + this.UseLimits.GetHashCode();
                return hashCode;
            }
        }
    }
}
