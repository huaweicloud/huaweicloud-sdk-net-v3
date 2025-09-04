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
    public class OrderV3 
    {

        /// <summary>
        /// 可使用折扣的订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 可使用折扣的订单项列表，具体参见表4。
        /// </summary>
        [JsonProperty("order_line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderLineItemV3> OrderLineItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderV3 {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  orderLineItems: ").Append(OrderLineItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderV3 input)
        {
            if (input == null) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
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
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderLineItems != null) hashCode = hashCode * 59 + this.OrderLineItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
