using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowOrderRequest 
    {

        /// <summary>
        /// **参数解释**：订单ID。取值自订单列表返回的orderName字段。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("order_name", IsPath = true)]
        [JsonProperty("order_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOrderRequest {\n");
            sb.Append("  orderName: ").Append(OrderName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOrderRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOrderRequest input)
        {
            if (input == null) return false;
            if (this.OrderName != input.OrderName || (this.OrderName != null && !this.OrderName.Equals(input.OrderName))) return false;

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
                if (this.OrderName != null) hashCode = hashCode * 59 + this.OrderName.GetHashCode();
                return hashCode;
            }
        }
    }
}
