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
    public class RetrieveEnterpriseMultiAccountCouponReq 
    {

        /// <summary>
        /// 企业子账号的客户ID。您可以调用查询企业子账号列表接口，获取响应参数“id”的返回值。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 优惠券ID。您可以调用查询企业子账号可回收优惠券列表接口，获取响应参数“coupon_id”的返回值。
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// 子优惠券ID。您可以调用查询企业子账号可回收优惠券列表接口，获取响应参数“sub_coupon_id”的返回值。
        /// </summary>
        [JsonProperty("sub_coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCouponId { get; set; }

        /// <summary>
        /// 交易序列号，用于防止重复提交。 如果接口调用方不传，则企业管理微服务后台生成如果接口调用方传入，则请采用UUID保证全局唯一 此参数不携带或携带值为null或携带值为空串时，由系统自动生成。
        /// </summary>
        [JsonProperty("trans_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveEnterpriseMultiAccountCouponReq {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  subCouponId: ").Append(SubCouponId).Append("\n");
            sb.Append("  transId: ").Append(TransId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetrieveEnterpriseMultiAccountCouponReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetrieveEnterpriseMultiAccountCouponReq input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.SubCouponId != input.SubCouponId || (this.SubCouponId != null && !this.SubCouponId.Equals(input.SubCouponId))) return false;
            if (this.TransId != input.TransId || (this.TransId != null && !this.TransId.Equals(input.TransId))) return false;

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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CouponId != null) hashCode = hashCode * 59 + this.CouponId.GetHashCode();
                if (this.SubCouponId != null) hashCode = hashCode * 59 + this.SubCouponId.GetHashCode();
                if (this.TransId != null) hashCode = hashCode * 59 + this.TransId.GetHashCode();
                return hashCode;
            }
        }
    }
}
