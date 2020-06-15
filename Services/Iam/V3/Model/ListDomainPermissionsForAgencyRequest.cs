using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDomainPermissionsForAgencyRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("agency_id", IsPath = true)]
        public string AgencyId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainPermissionsForAgencyRequest {\n");
            sb.Append("  agencyId: ").Append(AgencyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainPermissionsForAgencyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainPermissionsForAgencyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgencyId == input.AgencyId ||
                    (this.AgencyId != null &&
                    this.AgencyId.Equals(input.AgencyId))
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
                if (this.AgencyId != null)
                    hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
