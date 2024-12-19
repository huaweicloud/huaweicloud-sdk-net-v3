using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteOrganizationPolicyAssignmentRequest 
    {

        /// <summary>
        /// 组织ID。
        /// </summary>
        [SDKProperty("organization_id", IsPath = true)]
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 组织合规规则ID。
        /// </summary>
        [SDKProperty("organization_policy_assignment_id", IsPath = true)]
        [JsonProperty("organization_policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteOrganizationPolicyAssignmentRequest {\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  organizationPolicyAssignmentId: ").Append(OrganizationPolicyAssignmentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteOrganizationPolicyAssignmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteOrganizationPolicyAssignmentRequest input)
        {
            if (input == null) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.OrganizationPolicyAssignmentId != input.OrganizationPolicyAssignmentId || (this.OrganizationPolicyAssignmentId != null && !this.OrganizationPolicyAssignmentId.Equals(input.OrganizationPolicyAssignmentId))) return false;

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
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.OrganizationPolicyAssignmentId != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
