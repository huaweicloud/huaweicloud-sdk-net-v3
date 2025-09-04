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
    public class IQueryUserPartnerCouponsResultV2 
    {

        /// <summary>
        /// 优惠券ID。
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// 优惠券状态： 1：未激活2：可使用3：已使用4：已过期5：已回收
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 优惠券类别： 1：代金券4：现金券
        /// </summary>
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponType { get; set; }

        /// <summary>
        /// 优惠券面额单位。 1：元。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 优惠券面值。
        /// </summary>
        [JsonProperty("face_value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FaceValue { get; set; }

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
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 促销计划ID。
        /// </summary>
        [JsonProperty("promotion_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 促销计划名称。
        /// </summary>
        [JsonProperty("promotion_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionPlanName { get; set; }

        /// <summary>
        /// 促销计划描述。
        /// </summary>
        [JsonProperty("promotion_plan_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionPlanDesc { get; set; }

        /// <summary>
        /// 介质类型。 1：电子券2：纸质券
        /// </summary>
        [JsonProperty("media_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MediaType { get; set; }

        /// <summary>
        /// 获取方式。 1：线上领取2：线上兑换3：线上发放4：线下获取5：事件赠送
        /// </summary>
        [JsonProperty("fetch_method", NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchMethod { get; set; }

        /// <summary>
        /// 优惠券限制。 具体请参见表3。
        /// </summary>
        [JsonProperty("use_limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<ICouponUseLimitInfoV2> UseLimits { get; set; }

        /// <summary>
        /// 优惠券的激活时间。
        /// </summary>
        [JsonProperty("active_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 优惠券的使用时间。
        /// </summary>
        [JsonProperty("last_used_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUsedTime { get; set; }

        /// <summary>
        /// 促销活动ID。
        /// </summary>
        [JsonProperty("promotion_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionId { get; set; }

        /// <summary>
        /// 优惠券的创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 优惠券余额。
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Balance { get; set; }

        /// <summary>
        /// 锁定优惠券的订单ID。 如果为老版本优惠券，该值为空。
        /// </summary>
        [JsonProperty("lock_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LockOrderId { get; set; }

        /// <summary>
        /// 优惠券是否冻结。 0：否1：是 可用优惠券接口返回时不包括冻结状态的优惠券。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public string IsFrozen { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IQueryUserPartnerCouponsResultV2 {\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  couponType: ").Append(CouponType).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  faceValue: ").Append(FaceValue).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  promotionPlanId: ").Append(PromotionPlanId).Append("\n");
            sb.Append("  promotionPlanName: ").Append(PromotionPlanName).Append("\n");
            sb.Append("  promotionPlanDesc: ").Append(PromotionPlanDesc).Append("\n");
            sb.Append("  mediaType: ").Append(MediaType).Append("\n");
            sb.Append("  fetchMethod: ").Append(FetchMethod).Append("\n");
            sb.Append("  useLimits: ").Append(UseLimits).Append("\n");
            sb.Append("  activeTime: ").Append(ActiveTime).Append("\n");
            sb.Append("  lastUsedTime: ").Append(LastUsedTime).Append("\n");
            sb.Append("  promotionId: ").Append(PromotionId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  balance: ").Append(Balance).Append("\n");
            sb.Append("  lockOrderId: ").Append(LockOrderId).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IQueryUserPartnerCouponsResultV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IQueryUserPartnerCouponsResultV2 input)
        {
            if (input == null) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.CouponType != input.CouponType || (this.CouponType != null && !this.CouponType.Equals(input.CouponType))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.FaceValue != input.FaceValue || (this.FaceValue != null && !this.FaceValue.Equals(input.FaceValue))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.PromotionPlanId != input.PromotionPlanId || (this.PromotionPlanId != null && !this.PromotionPlanId.Equals(input.PromotionPlanId))) return false;
            if (this.PromotionPlanName != input.PromotionPlanName || (this.PromotionPlanName != null && !this.PromotionPlanName.Equals(input.PromotionPlanName))) return false;
            if (this.PromotionPlanDesc != input.PromotionPlanDesc || (this.PromotionPlanDesc != null && !this.PromotionPlanDesc.Equals(input.PromotionPlanDesc))) return false;
            if (this.MediaType != input.MediaType || (this.MediaType != null && !this.MediaType.Equals(input.MediaType))) return false;
            if (this.FetchMethod != input.FetchMethod || (this.FetchMethod != null && !this.FetchMethod.Equals(input.FetchMethod))) return false;
            if (this.UseLimits != input.UseLimits || (this.UseLimits != null && input.UseLimits != null && !this.UseLimits.SequenceEqual(input.UseLimits))) return false;
            if (this.ActiveTime != input.ActiveTime || (this.ActiveTime != null && !this.ActiveTime.Equals(input.ActiveTime))) return false;
            if (this.LastUsedTime != input.LastUsedTime || (this.LastUsedTime != null && !this.LastUsedTime.Equals(input.LastUsedTime))) return false;
            if (this.PromotionId != input.PromotionId || (this.PromotionId != null && !this.PromotionId.Equals(input.PromotionId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Balance != input.Balance || (this.Balance != null && !this.Balance.Equals(input.Balance))) return false;
            if (this.LockOrderId != input.LockOrderId || (this.LockOrderId != null && !this.LockOrderId.Equals(input.LockOrderId))) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CouponType != null) hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.FaceValue != null) hashCode = hashCode * 59 + this.FaceValue.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PromotionPlanId != null) hashCode = hashCode * 59 + this.PromotionPlanId.GetHashCode();
                if (this.PromotionPlanName != null) hashCode = hashCode * 59 + this.PromotionPlanName.GetHashCode();
                if (this.PromotionPlanDesc != null) hashCode = hashCode * 59 + this.PromotionPlanDesc.GetHashCode();
                if (this.MediaType != null) hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.FetchMethod != null) hashCode = hashCode * 59 + this.FetchMethod.GetHashCode();
                if (this.UseLimits != null) hashCode = hashCode * 59 + this.UseLimits.GetHashCode();
                if (this.ActiveTime != null) hashCode = hashCode * 59 + this.ActiveTime.GetHashCode();
                if (this.LastUsedTime != null) hashCode = hashCode * 59 + this.LastUsedTime.GetHashCode();
                if (this.PromotionId != null) hashCode = hashCode * 59 + this.PromotionId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Balance != null) hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.LockOrderId != null) hashCode = hashCode * 59 + this.LockOrderId.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                return hashCode;
            }
        }
    }
}
