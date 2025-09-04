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
    /// Response Object
    /// </summary>
    public class ListOrderDiscountsResponse : SdkResponse
    {

        /// <summary>
        /// 可用的折扣列表。 具体请参见表2。
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiscountInfoV3> Discounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOrderDiscountsResponse {\n");
            sb.Append("  discounts: ").Append(Discounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOrderDiscountsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOrderDiscountsResponse input)
        {
            if (input == null) return false;
            if (this.Discounts != input.Discounts || (this.Discounts != null && input.Discounts != null && !this.Discounts.SequenceEqual(input.Discounts))) return false;

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
                if (this.Discounts != null) hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
