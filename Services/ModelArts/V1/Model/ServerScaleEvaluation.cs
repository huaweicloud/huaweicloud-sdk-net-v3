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
    /// 
    /// </summary>
    public class ServerScaleEvaluation 
    {

        /// <summary>
        /// **参数解释**：是否售罄。 **约束限制**：不涉及 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("is_sold_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSoldOut { get; set; }

        /// <summary>
        /// **参数解释**：规格信息。 **约束限制**：不涉及 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：资源规格信息。 **约束限制**：不涉及 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerScaleEvaluation {\n");
            sb.Append("  isSoldOut: ").Append(IsSoldOut).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  resourceFlavor: ").Append(ResourceFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerScaleEvaluation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerScaleEvaluation input)
        {
            if (input == null) return false;
            if (this.IsSoldOut != input.IsSoldOut || (this.IsSoldOut != null && !this.IsSoldOut.Equals(input.IsSoldOut))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.ResourceFlavor != input.ResourceFlavor || (this.ResourceFlavor != null && !this.ResourceFlavor.Equals(input.ResourceFlavor))) return false;

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
                if (this.IsSoldOut != null) hashCode = hashCode * 59 + this.IsSoldOut.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
