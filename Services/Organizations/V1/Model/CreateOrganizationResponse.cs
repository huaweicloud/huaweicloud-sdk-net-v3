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
    public class CreateOrganizationResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public OrganizationDto Organization { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrganizationResponse {\n");
            sb.Append("  organization: ").Append(Organization).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOrganizationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOrganizationResponse input)
        {
            if (input == null) return false;
            if (this.Organization != input.Organization || (this.Organization != null && !this.Organization.Equals(input.Organization))) return false;

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
                if (this.Organization != null) hashCode = hashCode * 59 + this.Organization.GetHashCode();
                return hashCode;
            }
        }
    }
}
