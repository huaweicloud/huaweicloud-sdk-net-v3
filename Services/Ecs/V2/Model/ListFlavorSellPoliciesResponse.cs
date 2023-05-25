using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFlavorSellPoliciesResponse : SdkResponse
    {

        /// <summary>
        /// 云服务器规格销售策略数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 云服务器规格销售策略。
        /// </summary>
        [JsonProperty("sell_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListFlavorSellPoliciesResult> SellPolicies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorSellPoliciesResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  sellPolicies: ").Append(SellPolicies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorSellPoliciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorSellPoliciesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.SellPolicies == input.SellPolicies ||
                    this.SellPolicies != null &&
                    input.SellPolicies != null &&
                    this.SellPolicies.SequenceEqual(input.SellPolicies)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SellPolicies != null)
                    hashCode = hashCode * 59 + this.SellPolicies.GetHashCode();
                return hashCode;
            }
        }
    }
}
