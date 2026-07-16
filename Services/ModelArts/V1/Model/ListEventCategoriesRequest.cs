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
    public class ListEventCategoriesRequest 
    {

        /// <summary>
        /// **参数解释**：规格类型 **约束限制**：不涉及。 **取值范围**：可选值如下： - CPU - GPU - Ascend  **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("flavor_type", IsQuery = true)]
        [JsonProperty("flavor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEventCategoriesRequest {\n");
            sb.Append("  flavorType: ").Append(FlavorType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEventCategoriesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEventCategoriesRequest input)
        {
            if (input == null) return false;
            if (this.FlavorType != input.FlavorType || (this.FlavorType != null && !this.FlavorType.Equals(input.FlavorType))) return false;

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
                if (this.FlavorType != null) hashCode = hashCode * 59 + this.FlavorType.GetHashCode();
                return hashCode;
            }
        }
    }
}
