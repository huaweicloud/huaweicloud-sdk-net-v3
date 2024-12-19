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
    public class ShowOrganizationPolicyAssignmentStatusesRequest 
    {

        /// <summary>
        /// 组织ID。
        /// </summary>
        [SDKProperty("organization_id", IsPath = true)]
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 组织合规规则ID
        /// </summary>
        [SDKProperty("organization_policy_assignment_id", IsQuery = true)]
        [JsonProperty("organization_policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentId { get; set; }

        /// <summary>
        /// 组织合规规则名称。
        /// </summary>
        [SDKProperty("organization_policy_assignment_name", IsQuery = true)]
        [JsonProperty("organization_policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentName { get; set; }

        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOrganizationPolicyAssignmentStatusesRequest {\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  organizationPolicyAssignmentId: ").Append(OrganizationPolicyAssignmentId).Append("\n");
            sb.Append("  organizationPolicyAssignmentName: ").Append(OrganizationPolicyAssignmentName).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOrganizationPolicyAssignmentStatusesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOrganizationPolicyAssignmentStatusesRequest input)
        {
            if (input == null) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.OrganizationPolicyAssignmentId != input.OrganizationPolicyAssignmentId || (this.OrganizationPolicyAssignmentId != null && !this.OrganizationPolicyAssignmentId.Equals(input.OrganizationPolicyAssignmentId))) return false;
            if (this.OrganizationPolicyAssignmentName != input.OrganizationPolicyAssignmentName || (this.OrganizationPolicyAssignmentName != null && !this.OrganizationPolicyAssignmentName.Equals(input.OrganizationPolicyAssignmentName))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.OrganizationPolicyAssignmentName != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentName.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
