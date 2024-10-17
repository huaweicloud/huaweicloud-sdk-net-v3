using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AssociateResourceShareResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_share_associations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceShareAssociation> ResourceShareAssociations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateResourceShareResponse {\n");
            sb.Append("  resourceShareAssociations: ").Append(ResourceShareAssociations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateResourceShareResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateResourceShareResponse input)
        {
            if (input == null) return false;
            if (this.ResourceShareAssociations != input.ResourceShareAssociations || (this.ResourceShareAssociations != null && input.ResourceShareAssociations != null && !this.ResourceShareAssociations.SequenceEqual(input.ResourceShareAssociations))) return false;

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
                if (this.ResourceShareAssociations != null) hashCode = hashCode * 59 + this.ResourceShareAssociations.GetHashCode();
                return hashCode;
            }
        }
    }
}
