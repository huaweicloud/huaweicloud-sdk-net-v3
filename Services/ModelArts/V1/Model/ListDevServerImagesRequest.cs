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
    public class ListDevServerImagesRequest 
    {

        /// <summary>
        /// **参数解释**：server_type。 **约束限制**：不涉及。 **取值范围**：  - BMS  - ECS  - HPS **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("server_type", IsQuery = true)]
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerType { get; set; }

        /// <summary>
        /// **参数解释**：规格名称。 **约束限制**：^.{1,128}$。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("flavor_name", IsQuery = true)]
        [JsonProperty("flavor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDevServerImagesRequest {\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  flavorName: ").Append(FlavorName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDevServerImagesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDevServerImagesRequest input)
        {
            if (input == null) return false;
            if (this.ServerType != input.ServerType || (this.ServerType != null && !this.ServerType.Equals(input.ServerType))) return false;
            if (this.FlavorName != input.FlavorName || (this.FlavorName != null && !this.FlavorName.Equals(input.FlavorName))) return false;

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
                if (this.ServerType != null) hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.FlavorName != null) hashCode = hashCode * 59 + this.FlavorName.GetHashCode();
                return hashCode;
            }
        }
    }
}
