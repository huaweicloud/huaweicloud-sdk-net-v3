using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteConnectorRequestBody 
    {

        /// <summary>
        /// cbc生成实例变更的订单 按需实例不传入此参数。 包周期实例传入删除connector时生成的订单，由cbc调用时传入。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 包周期实例变更时的product id 按需实例不传入此参数。 包周期实例传入对变更实例规格的product，由cbc调用时传入。 
        /// </summary>
        [JsonProperty("csb_instance_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CsbInstanceProductId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteConnectorRequestBody {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  csbInstanceProductId: ").Append(CsbInstanceProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteConnectorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteConnectorRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.CsbInstanceProductId == input.CsbInstanceProductId ||
                    (this.CsbInstanceProductId != null &&
                    this.CsbInstanceProductId.Equals(input.CsbInstanceProductId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.CsbInstanceProductId != null)
                    hashCode = hashCode * 59 + this.CsbInstanceProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
