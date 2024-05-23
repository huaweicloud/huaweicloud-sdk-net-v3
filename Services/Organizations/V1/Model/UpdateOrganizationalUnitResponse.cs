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
    /// Response Object
    /// </summary>
    public class UpdateOrganizationalUnitResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("organizational_unit", NullValueHandling = NullValueHandling.Ignore)]
        public OrganizationalUnitDto OrganizationalUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganizationalUnitResponse {\n");
            sb.Append("  organizationalUnit: ").Append(OrganizationalUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOrganizationalUnitResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateOrganizationalUnitResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationalUnit == input.OrganizationalUnit ||
                    (this.OrganizationalUnit != null &&
                    this.OrganizationalUnit.Equals(input.OrganizationalUnit))
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
                if (this.OrganizationalUnit != null)
                    hashCode = hashCode * 59 + this.OrganizationalUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
