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
    public class CreatePartnerCouponsResponse : SdkResponse
    {

        /// <summary>
        /// 错误的客户列表和错误信息，只有HTTP 200的时候才会返回这个结构体，具体参见表1。
        /// </summary>
        [JsonProperty("error_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorDetail> ErrorDetails { get; set; }

        /// <summary>
        /// 成功的客户ID和对应的券ID列表，只有HTTP 200的时候才会返回这个结构体，具体参见表2。
        /// </summary>
        [JsonProperty("coupon_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CouponSimpleInfo> CouponInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePartnerCouponsResponse {\n");
            sb.Append("  errorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  couponInfos: ").Append(CouponInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePartnerCouponsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePartnerCouponsResponse input)
        {
            if (input == null) return false;
            if (this.ErrorDetails != input.ErrorDetails || (this.ErrorDetails != null && input.ErrorDetails != null && !this.ErrorDetails.SequenceEqual(input.ErrorDetails))) return false;
            if (this.CouponInfos != input.CouponInfos || (this.CouponInfos != null && input.CouponInfos != null && !this.CouponInfos.SequenceEqual(input.CouponInfos))) return false;

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
                if (this.ErrorDetails != null) hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                if (this.CouponInfos != null) hashCode = hashCode * 59 + this.CouponInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
