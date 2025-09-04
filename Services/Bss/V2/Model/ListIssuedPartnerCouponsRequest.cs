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
    public class ListIssuedPartnerCouponsRequest 
    {

        /// <summary>
        /// 优惠券ID。此参数不携带或携带值为空时，不作为筛选条件；携带值为null时，作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("coupon_id", IsQuery = true)]
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/api-bpconsole/mc_00021.html)接口获取customer_id。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("customer_id", IsQuery = true)]
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 订单ID。此参数不携带或携带值为空时，不作为筛选条件；携带值为null时，作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("order_id", IsQuery = true)]
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 优惠券类型。1：代金券4：现金券此参数不携带或携带值为空或携带值为null时，不作为筛选条件。
        /// </summary>
        [SDKProperty("coupon_type", IsQuery = true)]
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponType { get; set; }

        /// <summary>
        /// 客户优惠券实例状态：1：未激活2：可使用3：已使用4：已过期5：已回收此参数不携带或携带值为空或携带值为null时，不作为筛选条件。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 创建时间（开始）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出创建时间大于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("create_time_begin", IsQuery = true)]
        [JsonProperty("create_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// 创建时间（结束）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出创建时间小于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("create_time_end", IsQuery = true)]
        [JsonProperty("create_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// 生效时间（开始）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出生效时间大于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("effective_time_begin", IsQuery = true)]
        [JsonProperty("effective_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimeBegin { get; set; }

        /// <summary>
        /// 生效时间（结束）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出生效时间小于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("effective_time_end", IsQuery = true)]
        [JsonProperty("effective_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimeEnd { get; set; }

        /// <summary>
        /// 失效时间（开始）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出失效时间大于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("expire_time_begin", IsQuery = true)]
        [JsonProperty("expire_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeBegin { get; set; }

        /// <summary>
        /// 失效时间（结束）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出失效时间小于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("expire_time_end", IsQuery = true)]
        [JsonProperty("expire_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeEnd { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的每页数量。默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。华为云总经销商（一级经销商）查询云经销商发放给子客户的优惠券时，需要携带该参数；否则只能查询发放给自己子客户的优惠券。
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
            sb.Append("class ListIssuedPartnerCouponsRequest {\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  couponType: ").Append(CouponType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTimeBegin: ").Append(CreateTimeBegin).Append("\n");
            sb.Append("  createTimeEnd: ").Append(CreateTimeEnd).Append("\n");
            sb.Append("  effectiveTimeBegin: ").Append(EffectiveTimeBegin).Append("\n");
            sb.Append("  effectiveTimeEnd: ").Append(EffectiveTimeEnd).Append("\n");
            sb.Append("  expireTimeBegin: ").Append(ExpireTimeBegin).Append("\n");
            sb.Append("  expireTimeEnd: ").Append(ExpireTimeEnd).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIssuedPartnerCouponsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIssuedPartnerCouponsRequest input)
        {
            if (input == null) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.CouponType != input.CouponType || (this.CouponType != null && !this.CouponType.Equals(input.CouponType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTimeBegin != input.CreateTimeBegin || (this.CreateTimeBegin != null && !this.CreateTimeBegin.Equals(input.CreateTimeBegin))) return false;
            if (this.CreateTimeEnd != input.CreateTimeEnd || (this.CreateTimeEnd != null && !this.CreateTimeEnd.Equals(input.CreateTimeEnd))) return false;
            if (this.EffectiveTimeBegin != input.EffectiveTimeBegin || (this.EffectiveTimeBegin != null && !this.EffectiveTimeBegin.Equals(input.EffectiveTimeBegin))) return false;
            if (this.EffectiveTimeEnd != input.EffectiveTimeEnd || (this.EffectiveTimeEnd != null && !this.EffectiveTimeEnd.Equals(input.EffectiveTimeEnd))) return false;
            if (this.ExpireTimeBegin != input.ExpireTimeBegin || (this.ExpireTimeBegin != null && !this.ExpireTimeBegin.Equals(input.ExpireTimeBegin))) return false;
            if (this.ExpireTimeEnd != input.ExpireTimeEnd || (this.ExpireTimeEnd != null && !this.ExpireTimeEnd.Equals(input.ExpireTimeEnd))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.CouponType != null) hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTimeBegin != null) hashCode = hashCode * 59 + this.CreateTimeBegin.GetHashCode();
                if (this.CreateTimeEnd != null) hashCode = hashCode * 59 + this.CreateTimeEnd.GetHashCode();
                if (this.EffectiveTimeBegin != null) hashCode = hashCode * 59 + this.EffectiveTimeBegin.GetHashCode();
                if (this.EffectiveTimeEnd != null) hashCode = hashCode * 59 + this.EffectiveTimeEnd.GetHashCode();
                if (this.ExpireTimeBegin != null) hashCode = hashCode * 59 + this.ExpireTimeBegin.GetHashCode();
                if (this.ExpireTimeEnd != null) hashCode = hashCode * 59 + this.ExpireTimeEnd.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
