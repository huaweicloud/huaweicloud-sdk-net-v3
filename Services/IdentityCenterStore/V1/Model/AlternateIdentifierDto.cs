using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// A unique identifier for a user or group that is not the its primary identifier.This value can be an identifier from an external identity provider (IdP) that is associated with the group or a unique attribute.
    /// </summary>
    public class AlternateIdentifierDto 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalIdDto ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("unique_attribute", NullValueHandling = NullValueHandling.Ignore)]
        public UniqueAttributeDto UniqueAttribute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlternateIdentifierDto {\n");
            sb.Append("  externalId: ").Append(ExternalId).Append("\n");
            sb.Append("  uniqueAttribute: ").Append(UniqueAttribute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlternateIdentifierDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlternateIdentifierDto input)
        {
            if (input == null) return false;
            if (this.ExternalId != input.ExternalId || (this.ExternalId != null && !this.ExternalId.Equals(input.ExternalId))) return false;
            if (this.UniqueAttribute != input.UniqueAttribute || (this.UniqueAttribute != null && !this.UniqueAttribute.Equals(input.UniqueAttribute))) return false;

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
                if (this.ExternalId != null) hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.UniqueAttribute != null) hashCode = hashCode * 59 + this.UniqueAttribute.GetHashCode();
                return hashCode;
            }
        }
    }
}
