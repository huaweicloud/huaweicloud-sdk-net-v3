using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 券的退订金额（降配存在）。
    /// </summary>
    public class CouponUnsubscribeResult 
    {

        /// <summary>
        /// 券ID。
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// 券类型 302：现金券 303：储值卡。
        /// </summary>
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponType { get; set; }

        /// <summary>
        /// 券退的金额。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// 度量单位。&#39;
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponUnsubscribeResult {\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  couponType: ").Append(CouponType).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CouponUnsubscribeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CouponUnsubscribeResult input)
        {
            if (input == null) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.CouponType != input.CouponType || (this.CouponType != null && !this.CouponType.Equals(input.CouponType))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;

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
                if (this.CouponType != null) hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
