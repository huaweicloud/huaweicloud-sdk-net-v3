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
    public class DisassociateResourceShareResponse : SdkResponse
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
            sb.Append("class DisassociateResourceShareResponse {\n");
            sb.Append("  resourceShareAssociations: ").Append(ResourceShareAssociations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateResourceShareResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateResourceShareResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceShareAssociations == input.ResourceShareAssociations ||
                    this.ResourceShareAssociations != null &&
                    input.ResourceShareAssociations != null &&
                    this.ResourceShareAssociations.SequenceEqual(input.ResourceShareAssociations)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResourceShareAssociations != null)
                    hashCode = hashCode * 59 + this.ResourceShareAssociations.GetHashCode();
                return hashCode;
            }
        }
    }
}
