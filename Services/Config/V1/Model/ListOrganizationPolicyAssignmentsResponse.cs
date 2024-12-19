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
    /// Response Object
    /// </summary>
    public class ListOrganizationPolicyAssignmentsResponse : SdkResponse
    {

        /// <summary>
        /// 组织合规规则列表。
        /// </summary>
        [JsonProperty("organization_policy_assignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrganizationPolicyAssignmentResponse> OrganizationPolicyAssignments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOrganizationPolicyAssignmentsResponse {\n");
            sb.Append("  organizationPolicyAssignments: ").Append(OrganizationPolicyAssignments).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOrganizationPolicyAssignmentsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOrganizationPolicyAssignmentsResponse input)
        {
            if (input == null) return false;
            if (this.OrganizationPolicyAssignments != input.OrganizationPolicyAssignments || (this.OrganizationPolicyAssignments != null && input.OrganizationPolicyAssignments != null && !this.OrganizationPolicyAssignments.SequenceEqual(input.OrganizationPolicyAssignments))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.OrganizationPolicyAssignments != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignments.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
