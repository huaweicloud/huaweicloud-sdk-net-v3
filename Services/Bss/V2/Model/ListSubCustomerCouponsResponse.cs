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
    public class ListSubCustomerCouponsResponse : SdkResponse
    {

        /// <summary>
        /// 符合查询条件的总条数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 优惠券记录。 具体请参见表2。
        /// </summary>
        [JsonProperty("user_coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<IQueryUserCouponsResultV2> UserCoupons { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubCustomerCouponsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  userCoupons: ").Append(UserCoupons).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubCustomerCouponsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubCustomerCouponsResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.UserCoupons != input.UserCoupons || (this.UserCoupons != null && input.UserCoupons != null && !this.UserCoupons.SequenceEqual(input.UserCoupons))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.UserCoupons != null) hashCode = hashCode * 59 + this.UserCoupons.GetHashCode();
                return hashCode;
            }
        }
    }
}
