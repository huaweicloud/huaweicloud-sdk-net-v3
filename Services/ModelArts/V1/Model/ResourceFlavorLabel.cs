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
    /// 资源规格的标签信息。
    /// </summary>
    public class ResourceFlavorLabel 
    {

        /// <summary>
        /// **参数解释**：资源规格支持作业类型，以“.”分割。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/scope", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsScope { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceFlavorLabel {\n");
            sb.Append("  osModelartsScope: ").Append(OsModelartsScope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceFlavorLabel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceFlavorLabel input)
        {
            if (input == null) return false;
            if (this.OsModelartsScope != input.OsModelartsScope || (this.OsModelartsScope != null && !this.OsModelartsScope.Equals(input.OsModelartsScope))) return false;

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
                if (this.OsModelartsScope != null) hashCode = hashCode * 59 + this.OsModelartsScope.GetHashCode();
                return hashCode;
            }
        }
    }
}
