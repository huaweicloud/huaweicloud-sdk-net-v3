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
    public class UpdateOrganizationPolicyAssignmentResponse : SdkResponse
    {

        /// <summary>
        /// 组织合规规则创建者。
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 组织ID。
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 组织合规规则资源唯一标识。
        /// </summary>
        [JsonProperty("organization_policy_assignment_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentUrn { get; set; }

        /// <summary>
        /// 组织合规规则ID。
        /// </summary>
        [JsonProperty("organization_policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentId { get; set; }

        /// <summary>
        /// 组织合规规则名称。
        /// </summary>
        [JsonProperty("organization_policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentName { get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 触发周期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_filter", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyFilterDefinition PolicyFilter { get; set; }

        /// <summary>
        /// 规则参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PolicyParameterValue> Parameters { get; set; }

        /// <summary>
        /// 策略ID。
        /// </summary>
        [JsonProperty("policy_definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganizationPolicyAssignmentResponse {\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  organizationPolicyAssignmentUrn: ").Append(OrganizationPolicyAssignmentUrn).Append("\n");
            sb.Append("  organizationPolicyAssignmentId: ").Append(OrganizationPolicyAssignmentId).Append("\n");
            sb.Append("  organizationPolicyAssignmentName: ").Append(OrganizationPolicyAssignmentName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  policyFilter: ").Append(PolicyFilter).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  policyDefinitionId: ").Append(PolicyDefinitionId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOrganizationPolicyAssignmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateOrganizationPolicyAssignmentResponse input)
        {
            if (input == null) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.OrganizationPolicyAssignmentUrn != input.OrganizationPolicyAssignmentUrn || (this.OrganizationPolicyAssignmentUrn != null && !this.OrganizationPolicyAssignmentUrn.Equals(input.OrganizationPolicyAssignmentUrn))) return false;
            if (this.OrganizationPolicyAssignmentId != input.OrganizationPolicyAssignmentId || (this.OrganizationPolicyAssignmentId != null && !this.OrganizationPolicyAssignmentId.Equals(input.OrganizationPolicyAssignmentId))) return false;
            if (this.OrganizationPolicyAssignmentName != input.OrganizationPolicyAssignmentName || (this.OrganizationPolicyAssignmentName != null && !this.OrganizationPolicyAssignmentName.Equals(input.OrganizationPolicyAssignmentName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.PolicyFilter != input.PolicyFilter || (this.PolicyFilter != null && !this.PolicyFilter.Equals(input.PolicyFilter))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.PolicyDefinitionId != input.PolicyDefinitionId || (this.PolicyDefinitionId != null && !this.PolicyDefinitionId.Equals(input.PolicyDefinitionId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.OrganizationPolicyAssignmentUrn != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentUrn.GetHashCode();
                if (this.OrganizationPolicyAssignmentId != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentId.GetHashCode();
                if (this.OrganizationPolicyAssignmentName != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.PolicyFilter != null) hashCode = hashCode * 59 + this.PolicyFilter.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.PolicyDefinitionId != null) hashCode = hashCode * 59 + this.PolicyDefinitionId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
