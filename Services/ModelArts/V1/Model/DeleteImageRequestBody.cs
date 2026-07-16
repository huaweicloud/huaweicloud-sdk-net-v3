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
    /// **参数解释**：删除在SWR的镜像内容，仅对于个人私有镜像有效。 **约束限制**：不涉及。
    /// </summary>
    public class DeleteImageRequestBody 
    {

        /// <summary>
        /// **参数解释**：删除在SWR的镜像内容，仅对于个人私有镜像有效。 **约束限制**：不涉及。 **取值范围**：布尔类型： - true：删除镜像内容。 - false：不删除镜像内容。  **默认取值**：false。
        /// </summary>
        [JsonProperty("is_force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForce { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteImageRequestBody {\n");
            sb.Append("  isForce: ").Append(IsForce).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteImageRequestBody input)
        {
            if (input == null) return false;
            if (this.IsForce != input.IsForce || (this.IsForce != null && !this.IsForce.Equals(input.IsForce))) return false;

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
                if (this.IsForce != null) hashCode = hashCode * 59 + this.IsForce.GetHashCode();
                return hashCode;
            }
        }
    }
}
