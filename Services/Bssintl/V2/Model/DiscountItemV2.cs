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
    public class DiscountItemV2 
    {

        /// <summary>
        /// 折扣类型。 200：促销产品折扣；300：促销折扣券；301：促销代金券；302：促销现金券；500：代理订购指定折扣；501：代理订购指定减免；502：代理订购指定一口价；600：折扣返利合同；601：渠道框架合同；602：专款专用合同；603：线下直签合同；604：电销授权合同；605：商务合同折扣；606：渠道商务合同折扣；607：伙伴授权折扣；609：订单调价折扣；610：免单金额；700：促销折扣；800：充值帐户折扣
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
