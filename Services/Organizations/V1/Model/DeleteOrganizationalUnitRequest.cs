using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteOrganizationalUnitRequest 
    {

        /// <summary>
        /// 与组织单元关联的唯一标识符（ID）。
        /// </summary>
        [SDKProperty("organizational_unit_id", IsPath = true)]
        [JsonProperty("organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteOrganizationalUnitRequest {\n");
            sb.Append("  organizationalUnitId: ").Append(OrganizationalUnitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteOrganizationalUnitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteOrganizationalUnitRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationalUnitId == input.OrganizationalUnitId ||
                    (this.OrganizationalUnitId != null &&
                    this.OrganizationalUnitId.Equals(input.OrganizationalUnitId))
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
                if (this.OrganizationalUnitId != null)
                    hashCode = hashCode * 59 + this.OrganizationalUnitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
