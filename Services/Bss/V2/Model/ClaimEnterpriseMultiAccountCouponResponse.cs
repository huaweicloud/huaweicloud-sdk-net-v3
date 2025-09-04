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
    public class ClaimEnterpriseMultiAccountCouponResponse : SdkResponse
    {

        /// <summary>
        /// |参数名称：实际回收金额。| |参数的约束及描述：成功时返回|
        /// </summary>
        [JsonProperty("sub_coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCouponId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClaimEnterpriseMultiAccountCouponResponse {\n");
            sb.Append("  subCouponId: ").Append(SubCouponId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClaimEnterpriseMultiAccountCouponResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClaimEnterpriseMultiAccountCouponResponse input)
        {
            if (input == null) return false;
            if (this.SubCouponId != input.SubCouponId || (this.SubCouponId != null && !this.SubCouponId.Equals(input.SubCouponId))) return false;

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
                if (this.SubCouponId != null) hashCode = hashCode * 59 + this.SubCouponId.GetHashCode();
                return hashCode;
            }
        }
    }
}
