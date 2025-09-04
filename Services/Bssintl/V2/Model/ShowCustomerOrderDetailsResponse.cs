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
    public class ShowCustomerOrderDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 订单项个数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order_info", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerOrderV3 OrderInfo { get; set; }

        /// <summary>
        /// 订单对应的订单项。 具体请参见表5。
        /// </summary>
        [JsonProperty("order_line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderLineItemEntityV2> OrderLineItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCustomerOrderDetailsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  orderInfo: ").Append(OrderInfo).Append("\n");
            sb.Append("  orderLineItems: ").Append(OrderLineItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCustomerOrderDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCustomerOrderDetailsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.OrderInfo != input.OrderInfo || (this.OrderInfo != null && !this.OrderInfo.Equals(input.OrderInfo))) return false;
            if (this.OrderLineItems != input.OrderLineItems || (this.OrderLineItems != null && input.OrderLineItems != null && !this.OrderLineItems.SequenceEqual(input.OrderLineItems))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.OrderInfo != null) hashCode = hashCode * 59 + this.OrderInfo.GetHashCode();
                if (this.OrderLineItems != null) hashCode = hashCode * 59 + this.OrderLineItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
