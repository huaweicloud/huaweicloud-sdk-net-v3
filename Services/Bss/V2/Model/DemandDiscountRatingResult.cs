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
    public class DemandDiscountRatingResult 
    {

        /// <summary>
        /// 优惠标识ID。
        /// </summary>
        [JsonProperty("discount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountId { get; set; }

        /// <summary>
        /// 折扣优惠类型。商务授权折扣：605(华为云BE场景下的合同商务折扣)、伙伴授予折扣：606(分销商BE场景下的合同商务折扣)、伙伴设置折扣：607(合作伙伴设置折扣-折扣率)
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscountType { get; set; }

        /// <summary>
        /// 折扣的金额。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 度量单位标识。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 折扣名称。
        /// </summary>
        [JsonProperty("discount_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemandDiscountRatingResult {\n");
            sb.Append("  discountId: ").Append(DiscountId).Append("\n");
            sb.Append("  discountType: ").Append(DiscountType).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  discountName: ").Append(DiscountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DemandDiscountRatingResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DemandDiscountRatingResult input)
        {
            if (input == null) return false;
            if (this.DiscountId != input.DiscountId || (this.DiscountId != null && !this.DiscountId.Equals(input.DiscountId))) return false;
            if (this.DiscountType != input.DiscountType || (this.DiscountType != null && !this.DiscountType.Equals(input.DiscountType))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.DiscountName != input.DiscountName || (this.DiscountName != null && !this.DiscountName.Equals(input.DiscountName))) return false;

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
                if (this.DiscountId != null) hashCode = hashCode * 59 + this.DiscountId.GetHashCode();
                if (this.DiscountType != null) hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.DiscountName != null) hashCode = hashCode * 59 + this.DiscountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
