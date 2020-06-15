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
    public class CheckDomainPermissionForAgencyRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("agency_id", IsPath = true)]
        public string AgencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("role_id", IsPath = true)]
        public string RoleId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDomainPermissionForAgencyRequest {\n");
            sb.Append("  agencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckDomainPermissionForAgencyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckDomainPermissionForAgencyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgencyId == input.AgencyId ||
                    (this.AgencyId != null &&
                    this.AgencyId.Equals(input.AgencyId))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
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
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
