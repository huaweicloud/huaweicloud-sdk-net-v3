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
    /// 资源规格metadata的注释信息。
    /// </summary>
    public class ResourceFlavorAnnotation 
    {

        /// <summary>
        /// **参数解释**：资源规格支持的私有镜像的过滤条件。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.flavor/image.filter", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsFlavorImageFilter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceFlavorAnnotation {\n");
            sb.Append("  osModelartsFlavorImageFilter: ").Append(OsModelartsFlavorImageFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceFlavorAnnotation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceFlavorAnnotation input)
        {
            if (input == null) return false;
            if (this.OsModelartsFlavorImageFilter != input.OsModelartsFlavorImageFilter || (this.OsModelartsFlavorImageFilter != null && !this.OsModelartsFlavorImageFilter.Equals(input.OsModelartsFlavorImageFilter))) return false;

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
                if (this.OsModelartsFlavorImageFilter != null) hashCode = hashCode * 59 + this.OsModelartsFlavorImageFilter.GetHashCode();
                return hashCode;
            }
        }
    }
}
