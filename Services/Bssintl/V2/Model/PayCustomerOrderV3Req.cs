using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PayCustomerOrderV3Req 
    {

        /// <summary>
        /// 订单编号。 取值为调用“查询订单列表”接口时响应消息中的“order_id”字段的值或调用“续订包年/包月资源”接口时响应消息“order_ids”中的订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 本次订单支付是否使用优惠券。传递“YES”时，coupon_infos字段必选，传递“NO”时，会忽略coupon_infos字段的传值。 使用优惠券：YES，不使用优惠券：NO
        /// </summary>
        [JsonProperty("use_coupon", NullValueHandling = NullValueHandling.Ignore)]
        public string UseCoupon { get; set; }

        /// <summary>
        /// 本次订单支付是否使用折扣。传递“YES”时，discount_infos字段必选，传递“NO”时，会忽略discount_infos字段的传值。 使用折扣：YES，不使用折扣：NO
        /// </summary>
        [JsonProperty("use_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string UseDiscount { get; set; }

        /// <summary>
        /// 优惠券ID列表，目前支持传递最多三个优惠券ID。 请从“查询订单可用优惠券”接口的响应参数中获取。 具体参见表1。 当use_coupon参数取值为“YES”，本字段必填；当use_coupon参数取值为“NO”，本字段不可填写，否则报参数错误。
        /// </summary>
        [JsonProperty("coupon_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CouponSimpleInfoOrderPayV3> CouponInfos { get; set; }

        /// <summary>
        /// 折扣ID列表，目前仅支持传递一个折扣ID。 请从“查询订单可用折扣”接口的响应参数中获取。 具体参见表2。 当use_discount参数取值为“YES”，本字段必填；当use_discount参数取值为“NO”，本字段不可填写，否则报参数错误。
        /// </summary>
        [JsonProperty("discount_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiscountSimpleInfoV3> DiscountInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayCustomerOrderV3Req {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  useCoupon: ").Append(UseCoupon).Append("\n");
            sb.Append("  useDiscount: ").Append(UseDiscount).Append("\n");
            sb.Append("  couponInfos: ").Append(CouponInfos).Append("\n");
            sb.Append("  discountInfos: ").Append(DiscountInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayCustomerOrderV3Req);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PayCustomerOrderV3Req input)
        {
            if (input == null) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.UseCoupon != input.UseCoupon || (this.UseCoupon != null && !this.UseCoupon.Equals(input.UseCoupon))) return false;
            if (this.UseDiscount != input.UseDiscount || (this.UseDiscount != null && !this.UseDiscount.Equals(input.UseDiscount))) return false;
            if (this.CouponInfos != input.CouponInfos || (this.CouponInfos != null && input.CouponInfos != null && !this.CouponInfos.SequenceEqual(input.CouponInfos))) return false;
            if (this.DiscountInfos != input.DiscountInfos || (this.DiscountInfos != null && input.DiscountInfos != null && !this.DiscountInfos.SequenceEqual(input.DiscountInfos))) return false;

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
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.UseCoupon != null) hashCode = hashCode * 59 + this.UseCoupon.GetHashCode();
                if (this.UseDiscount != null) hashCode = hashCode * 59 + this.UseDiscount.GetHashCode();
                if (this.CouponInfos != null) hashCode = hashCode * 59 + this.CouponInfos.GetHashCode();
                if (this.DiscountInfos != null) hashCode = hashCode * 59 + this.DiscountInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
