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
    public class DiscountItemV2 
    {

        /// <summary>
        /// 折扣类型： 200：促销产品折扣300：促销折扣券301：促销代金券302：促销现金券500：代理订购指定折扣501：代理订购指定减免502：代理订购指定一口价600：折扣返利合同601：渠道框架合同602：专款专用合同603：线下直签合同604：电销授权合同605：商务合同折扣606：渠道商务合同折扣607：合作伙伴授权折扣609：订单调价折扣610：免单金额700：促销折扣800：充值帐户折扣900：产品本身折扣901：基准价一口价的折扣
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountType { get; set; }

        /// <summary>
        /// 折扣金额。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? DiscountAmount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountItemV2 {\n");
            sb.Append("  discountType: ").Append(DiscountType).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiscountItemV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiscountItemV2 input)
        {
            if (input == null) return false;
            if (this.DiscountType != input.DiscountType || (this.DiscountType != null && !this.DiscountType.Equals(input.DiscountType))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;

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
                if (this.DiscountType != null) hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
