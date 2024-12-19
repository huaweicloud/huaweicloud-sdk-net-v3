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
    /// 组织合规规则请求体。
    /// </summary>
    public class OrganizationPolicyAssignmentRequest 
    {

        /// <summary>
        /// 需要排除配置规则的帐号。
        /// </summary>
        [JsonProperty("excluded_accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcludedAccounts { get; set; }

        /// <summary>
        /// 组织合规规则名称。
        /// </summary>
        [JsonProperty("organization_policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("managed_policy_assignment_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public ManagedPolicyAssignmentMetadata ManagedPolicyAssignmentMetadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationPolicyAssignmentRequest {\n");
            sb.Append("  excludedAccounts: ").Append(ExcludedAccounts).Append("\n");
            sb.Append("  organizationPolicyAssignmentName: ").Append(OrganizationPolicyAssignmentName).Append("\n");
            sb.Append("  managedPolicyAssignmentMetadata: ").Append(ManagedPolicyAssignmentMetadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationPolicyAssignmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationPolicyAssignmentRequest input)
        {
            if (input == null) return false;
            if (this.ExcludedAccounts != input.ExcludedAccounts || (this.ExcludedAccounts != null && input.ExcludedAccounts != null && !this.ExcludedAccounts.SequenceEqual(input.ExcludedAccounts))) return false;
            if (this.OrganizationPolicyAssignmentName != input.OrganizationPolicyAssignmentName || (this.OrganizationPolicyAssignmentName != null && !this.OrganizationPolicyAssignmentName.Equals(input.OrganizationPolicyAssignmentName))) return false;
            if (this.ManagedPolicyAssignmentMetadata != input.ManagedPolicyAssignmentMetadata || (this.ManagedPolicyAssignmentMetadata != null && !this.ManagedPolicyAssignmentMetadata.Equals(input.ManagedPolicyAssignmentMetadata))) return false;

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
                if (this.ExcludedAccounts != null) hashCode = hashCode * 59 + this.ExcludedAccounts.GetHashCode();
                if (this.OrganizationPolicyAssignmentName != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentName.GetHashCode();
                if (this.ManagedPolicyAssignmentMetadata != null) hashCode = hashCode * 59 + this.ManagedPolicyAssignmentMetadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
