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
    /// **参数解释**：资源池的注释信息。
    /// </summary>
    public class PoolMetadataUpdateAnnotations 
    {

        /// <summary>
        /// **参数解释**：资源池描述信息，用于说明资源池用于某种指定场景。不能包含特殊字符!&lt;&gt;&#x3D;&amp;\&quot;&#39;。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/description", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsDescription { get; set; }

        /// <summary>
        /// **参数解释**：订单id，包周期创建和变更的时候需要传递该参数。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/order.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsOrderId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolMetadataUpdateAnnotations {\n");
            sb.Append("  osModelartsDescription: ").Append(OsModelartsDescription).Append("\n");
            sb.Append("  osModelartsOrderId: ").Append(OsModelartsOrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolMetadataUpdateAnnotations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolMetadataUpdateAnnotations input)
        {
            if (input == null) return false;
            if (this.OsModelartsDescription != input.OsModelartsDescription || (this.OsModelartsDescription != null && !this.OsModelartsDescription.Equals(input.OsModelartsDescription))) return false;
            if (this.OsModelartsOrderId != input.OsModelartsOrderId || (this.OsModelartsOrderId != null && !this.OsModelartsOrderId.Equals(input.OsModelartsOrderId))) return false;

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
                if (this.OsModelartsDescription != null) hashCode = hashCode * 59 + this.OsModelartsDescription.GetHashCode();
                if (this.OsModelartsOrderId != null) hashCode = hashCode * 59 + this.OsModelartsOrderId.GetHashCode();
                return hashCode;
            }
        }
    }
}
