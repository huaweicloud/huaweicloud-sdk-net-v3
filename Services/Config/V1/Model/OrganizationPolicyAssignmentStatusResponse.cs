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
    /// 组织合规规则部署状态。
    /// </summary>
    public class OrganizationPolicyAssignmentStatusResponse 
    {

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
        /// 组织合规规则部署状态。
        /// </summary>
        [JsonProperty("organization_policy_assignment_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentStatus { get; set; }

        /// <summary>
        /// 当创建或更新组织合规规则失败时错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 当创建或更新组织合规规则失败时错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

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
            sb.Append("class OrganizationPolicyAssignmentStatusResponse {\n");
            sb.Append("  organizationPolicyAssignmentId: ").Append(OrganizationPolicyAssignmentId).Append("\n");
            sb.Append("  organizationPolicyAssignmentName: ").Append(OrganizationPolicyAssignmentName).Append("\n");
            sb.Append("  organizationPolicyAssignmentStatus: ").Append(OrganizationPolicyAssignmentStatus).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as OrganizationPolicyAssignmentStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationPolicyAssignmentStatusResponse input)
        {
            if (input == null) return false;
            if (this.OrganizationPolicyAssignmentId != input.OrganizationPolicyAssignmentId || (this.OrganizationPolicyAssignmentId != null && !this.OrganizationPolicyAssignmentId.Equals(input.OrganizationPolicyAssignmentId))) return false;
            if (this.OrganizationPolicyAssignmentName != input.OrganizationPolicyAssignmentName || (this.OrganizationPolicyAssignmentName != null && !this.OrganizationPolicyAssignmentName.Equals(input.OrganizationPolicyAssignmentName))) return false;
            if (this.OrganizationPolicyAssignmentStatus != input.OrganizationPolicyAssignmentStatus || (this.OrganizationPolicyAssignmentStatus != null && !this.OrganizationPolicyAssignmentStatus.Equals(input.OrganizationPolicyAssignmentStatus))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
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
                if (this.OrganizationPolicyAssignmentId != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentId.GetHashCode();
                if (this.OrganizationPolicyAssignmentName != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentName.GetHashCode();
                if (this.OrganizationPolicyAssignmentStatus != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentStatus.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
