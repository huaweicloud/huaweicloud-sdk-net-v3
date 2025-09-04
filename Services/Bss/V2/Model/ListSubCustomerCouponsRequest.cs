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
    /// Request Object
    /// </summary>
    public class ListSubCustomerCouponsRequest 
    {

        /// <summary>
        /// 优惠券ID。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("coupon_id", IsQuery = true)]
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// 订单ID。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("order_id", IsQuery = true)]
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 促销计划ID。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("promotion_plan_id", IsQuery = true)]
        [JsonProperty("promotion_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 优惠券类型：1：代金券2：折扣券3：产品券4：现金券。此参数不携带或携带值为空或携带值为null时，不作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("coupon_type", IsQuery = true)]
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponType { get; set; }

        /// <summary>
        /// 客户优惠券实例状态：1：未激活2：待使用3：已使用4：已过期5：已回收。此参数不携带或携带值为空时，不作为筛选条件。 说明： 已使用、已过期和已回收优惠券，只返回12个月以内的数据。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 激活时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。此参数不携带或携带值为空时，不作为筛选条件；不支持携带值为空串或携带值为null。
        /// </summary>
        [SDKProperty("active_start_time", IsQuery = true)]
        [JsonProperty("active_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveStartTime { get; set; }

        /// <summary>
        /// 结束时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。此参数不携带或携带值为空时，不作为筛选条件；不支持携带值为空串或携带值为null。
        /// </summary>
        [SDKProperty("active_end_time", IsQuery = true)]
        [JsonProperty("active_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveEndTime { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。此参数需与limit联合使用，不支持单独使用。说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的优惠券数量，默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 发券来源，如果是合作伙伴发送的券，此处为伙伴ID。如果需要查询某个伙伴发放的券，可以在此处输入该伙伴ID。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("source_id", IsQuery = true)]
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 云经销商（二级经销商）ID。华为云总经销商（一级经销商）查询云经销商名下的优惠券时，需要携带该参数；除此之外，此参数不做处理。否则只能查询自己的优惠券列表。
        /// </summary>
        [SDKProperty("indirect_partner_id", IsQuery = true)]
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubCustomerCouponsRequest {\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  promotionPlanId: ").Append(PromotionPlanId).Append("\n");
            sb.Append("  couponType: ").Append(CouponType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  activeStartTime: ").Append(ActiveStartTime).Append("\n");
            sb.Append("  activeEndTime: ").Append(ActiveEndTime).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubCustomerCouponsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubCustomerCouponsRequest input)
        {
            if (input == null) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.PromotionPlanId != input.PromotionPlanId || (this.PromotionPlanId != null && !this.PromotionPlanId.Equals(input.PromotionPlanId))) return false;
            if (this.CouponType != input.CouponType || (this.CouponType != null && !this.CouponType.Equals(input.CouponType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ActiveStartTime != input.ActiveStartTime || (this.ActiveStartTime != null && !this.ActiveStartTime.Equals(input.ActiveStartTime))) return false;
            if (this.ActiveEndTime != input.ActiveEndTime || (this.ActiveEndTime != null && !this.ActiveEndTime.Equals(input.ActiveEndTime))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;

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
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PromotionPlanId != null) hashCode = hashCode * 59 + this.PromotionPlanId.GetHashCode();
                if (this.CouponType != null) hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ActiveStartTime != null) hashCode = hashCode * 59 + this.ActiveStartTime.GetHashCode();
                if (this.ActiveEndTime != null) hashCode = hashCode * 59 + this.ActiveEndTime.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
