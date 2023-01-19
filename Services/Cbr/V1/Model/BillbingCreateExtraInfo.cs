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
    /// 
    /// </summary>
    public class BillbingCreateExtraInfo 
    {

        /// <summary>
        /// 组合创建ID，组合创建时必传。
        /// </summary>
        [JsonProperty("combined_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CombinedOrderId { get; set; }

        /// <summary>
        /// 组合创建数量，组合创建时必填。
        /// </summary>
        [JsonProperty("combined_order_ecs_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CombinedOrderEcsNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillbingCreateExtraInfo {\n");
            sb.Append("  combinedOrderId: ").Append(CombinedOrderId).Append("\n");
            sb.Append("  combinedOrderEcsNum: ").Append(CombinedOrderEcsNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillbingCreateExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BillbingCreateExtraInfo input)
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
                return hashCode;
            }
        }
    }
}
