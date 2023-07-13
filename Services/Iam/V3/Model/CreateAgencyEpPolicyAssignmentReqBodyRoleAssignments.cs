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
    /// 
    /// </summary>
    public class CreateAgencyEpPolicyAssignmentReqBodyRoleAssignments 
    {

        /// <summary>
        /// 委托id
        /// </summary>
        [JsonProperty("agency_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyId { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAgencyEpPolicyAssignmentReqBodyRoleAssignments {\n");
            sb.Append("  agencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAgencyEpPolicyAssignmentReqBodyRoleAssignments);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAgencyEpPolicyAssignmentReqBodyRoleAssignments input)
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
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
