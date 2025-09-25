using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ArtifactHashCode 
    {

        /// <summary>
        /// **参数解释**： 哈希算法。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("hash_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HashType { get; set; }

        /// <summary>
        /// **参数解释**： 哈希值。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("hash_value", NullValueHandling = NullValueHandling.Ignore)]
        public string HashValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArtifactHashCode {\n");
            sb.Append("  hashType: ").Append(HashType).Append("\n");
            sb.Append("  hashValue: ").Append(HashValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArtifactHashCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ArtifactHashCode input)
        {
            if (input == null) return false;
            if (this.HashType != input.HashType || (this.HashType != null && !this.HashType.Equals(input.HashType))) return false;
            if (this.HashValue != input.HashValue || (this.HashValue != null && !this.HashValue.Equals(input.HashValue))) return false;

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
                if (this.HashType != null) hashCode = hashCode * 59 + this.HashType.GetHashCode();
                if (this.HashValue != null) hashCode = hashCode * 59 + this.HashValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
