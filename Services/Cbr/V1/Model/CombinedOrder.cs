using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 组合订单
    /// </summary>
    public class CombinedOrder 
    {

        /// <summary>
        /// 组合订单 ID
        /// </summary>
        [JsonProperty("combined_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CombinedOrderId { get; set; }

        /// <summary>
        /// 组合订单中 ECS 服务器数量，当前批量最大为 500。  最小值：1  最大值：1000
        /// </summary>
        [JsonProperty("combined_order_ecs_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CombinedOrderEcsNum { get; set; }

        /// <summary>
        /// 组合订单数量。  最小值：1  最大值：1000
        /// </summary>
        [JsonProperty("combined_order_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CombinedOrderNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombinedOrder {\n");
            sb.Append("  combinedOrderId: ").Append(CombinedOrderId).Append("\n");
            sb.Append("  combinedOrderEcsNum: ").Append(CombinedOrderEcsNum).Append("\n");
            sb.Append("  combinedOrderNum: ").Append(CombinedOrderNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CombinedOrder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CombinedOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CombinedOrderId == input.CombinedOrderId ||
                    (this.CombinedOrderId != null &&
                    this.CombinedOrderId.Equals(input.CombinedOrderId))
                ) && 
                (
                    this.CombinedOrderEcsNum == input.CombinedOrderEcsNum ||
                    (this.CombinedOrderEcsNum != null &&
                    this.CombinedOrderEcsNum.Equals(input.CombinedOrderEcsNum))
                ) && 
                (
                    this.CombinedOrderNum == input.CombinedOrderNum ||
                    (this.CombinedOrderNum != null &&
                    this.CombinedOrderNum.Equals(input.CombinedOrderNum))
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
                if (this.CombinedOrderId != null)
                    hashCode = hashCode * 59 + this.CombinedOrderId.GetHashCode();
                if (this.CombinedOrderEcsNum != null)
                    hashCode = hashCode * 59 + this.CombinedOrderEcsNum.GetHashCode();
                if (this.CombinedOrderNum != null)
                    hashCode = hashCode * 59 + this.CombinedOrderNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
