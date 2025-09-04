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
    public class CouponInfoV2 
    {

        /// <summary>
        /// 优惠券实例ID。
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// 优惠券编码。
        /// </summary>
        [JsonProperty("coupon_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponCode { get; set; }

        /// <summary>
        /// 优惠券状态： 1：未激活2：待使用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 优惠券类型。 1：代金券2：折扣券3：产品券4：现金券
        /// </summary>
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponType { get; set; }

        /// <summary>
        /// 面额单位： 1：元。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 面值。
        /// </summary>
        [JsonProperty("face_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? FaceValue { get; set; }

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
        /// 促销计划名称。
        /// </summary>
        [JsonProperty("plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanName { get; set; }

        /// <summary>
        /// 促销计划描述。
        /// </summary>
        [JsonProperty("plan_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanDesc { get; set; }

        /// <summary>
        /// 优惠券限制。 具体请参见表3。
        /// </summary>
        [JsonProperty("use_limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<LimitInfoV2> UseLimits { get; set; }

        /// <summary>
        /// 激活时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("active_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 上一次使用时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("last_used_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUsedTime { get; set; }

        /// <summary>
        /// 创建时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 优惠券版本。 1：老版本（包含三种：代金券、折扣券和奖金券）2：新版本（只有代金券）
        /// </summary>
        [JsonProperty("coupon_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponVersion { get; set; }

        /// <summary>
        /// 余额。
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Balance { get; set; }

        /// <summary>
        /// 使用优惠券的订单ID。表示有订单正在使用这个优惠券，优惠券已被锁定，只有锁定优惠券的订单才能使用这个优惠券，其他订单不能使用该优惠券。
        /// </summary>
        [JsonProperty("used_by_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedByOrderId { get; set; }

        /// <summary>
        /// 优惠券用途。
        /// </summary>
        [JsonProperty("coupon_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponUsage { get; set; }

        /// <summary>
        /// 优惠券分组。 1：云商店发放的券2：华为云券-1024-专用代金券3：华为云券-使用限制-抵扣硬件的券0：华为云服务券（排除上述取值之外的券）
        /// </summary>
        [JsonProperty("coupon_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponInfoV2 {\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  couponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  couponType: ").Append(CouponType).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  faceValue: ").Append(FaceValue).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  planName: ").Append(PlanName).Append("\n");
            sb.Append("  planDesc: ").Append(PlanDesc).Append("\n");
            sb.Append("  useLimits: ").Append(UseLimits).Append("\n");
            sb.Append("  activeTime: ").Append(ActiveTime).Append("\n");
            sb.Append("  lastUsedTime: ").Append(LastUsedTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  couponVersion: ").Append(CouponVersion).Append("\n");
            sb.Append("  balance: ").Append(Balance).Append("\n");
            sb.Append("  usedByOrderId: ").Append(UsedByOrderId).Append("\n");
            sb.Append("  couponUsage: ").Append(CouponUsage).Append("\n");
            sb.Append("  couponGroup: ").Append(CouponGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CouponInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CouponInfoV2 input)
        {
            if (input == null) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.CouponCode != input.CouponCode || (this.CouponCode != null && !this.CouponCode.Equals(input.CouponCode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CouponType != input.CouponType || (this.CouponType != null && !this.CouponType.Equals(input.CouponType))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.FaceValue != input.FaceValue || (this.FaceValue != null && !this.FaceValue.Equals(input.FaceValue))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.PlanName != input.PlanName || (this.PlanName != null && !this.PlanName.Equals(input.PlanName))) return false;
            if (this.PlanDesc != input.PlanDesc || (this.PlanDesc != null && !this.PlanDesc.Equals(input.PlanDesc))) return false;
            if (this.UseLimits != input.UseLimits || (this.UseLimits != null && input.UseLimits != null && !this.UseLimits.SequenceEqual(input.UseLimits))) return false;
            if (this.ActiveTime != input.ActiveTime || (this.ActiveTime != null && !this.ActiveTime.Equals(input.ActiveTime))) return false;
            if (this.LastUsedTime != input.LastUsedTime || (this.LastUsedTime != null && !this.LastUsedTime.Equals(input.LastUsedTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CouponVersion != input.CouponVersion || (this.CouponVersion != null && !this.CouponVersion.Equals(input.CouponVersion))) return false;
            if (this.Balance != input.Balance || (this.Balance != null && !this.Balance.Equals(input.Balance))) return false;
            if (this.UsedByOrderId != input.UsedByOrderId || (this.UsedByOrderId != null && !this.UsedByOrderId.Equals(input.UsedByOrderId))) return false;
            if (this.CouponUsage != input.CouponUsage || (this.CouponUsage != null && !this.CouponUsage.Equals(input.CouponUsage))) return false;
            if (this.CouponGroup != input.CouponGroup || (this.CouponGroup != null && !this.CouponGroup.Equals(input.CouponGroup))) return false;

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
                if (this.CouponCode != null) hashCode = hashCode * 59 + this.CouponCode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CouponType != null) hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.FaceValue != null) hashCode = hashCode * 59 + this.FaceValue.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.PlanName != null) hashCode = hashCode * 59 + this.PlanName.GetHashCode();
                if (this.PlanDesc != null) hashCode = hashCode * 59 + this.PlanDesc.GetHashCode();
                if (this.UseLimits != null) hashCode = hashCode * 59 + this.UseLimits.GetHashCode();
                if (this.ActiveTime != null) hashCode = hashCode * 59 + this.ActiveTime.GetHashCode();
                if (this.LastUsedTime != null) hashCode = hashCode * 59 + this.LastUsedTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CouponVersion != null) hashCode = hashCode * 59 + this.CouponVersion.GetHashCode();
                if (this.Balance != null) hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.UsedByOrderId != null) hashCode = hashCode * 59 + this.UsedByOrderId.GetHashCode();
                if (this.CouponUsage != null) hashCode = hashCode * 59 + this.CouponUsage.GetHashCode();
                if (this.CouponGroup != null) hashCode = hashCode * 59 + this.CouponGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
