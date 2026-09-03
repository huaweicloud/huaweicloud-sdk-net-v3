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
    public class ShowTrainingFlavorMaxAvailableResourceRequest 
    {

        /// <summary>
        /// **参数解释**：资源规格ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("flavor_id", IsQuery = true)]
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：资源池ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("pool_id", IsQuery = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingFlavorMaxAvailableResourceRequest {\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingFlavorMaxAvailableResourceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingFlavorMaxAvailableResourceRequest input)
        {
            if (input == null) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;

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
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                return hashCode;
            }
        }
    }
}
