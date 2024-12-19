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
    /// 合规规则评估结果详情。
    /// </summary>
    public class ConformancePackComplianceDetail 
    {

        /// <summary>
        /// 合规规则ID。
        /// </summary>
        [JsonProperty("policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentId { get; set; }

        /// <summary>
        /// 合规规则名称。
        /// </summary>
        [JsonProperty("policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentName { get; set; }

        /// <summary>
        /// 评估资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 合规规则合规结果。
        /// </summary>
        [JsonProperty("compliance_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplianceState { get; set; }

        /// <summary>
        /// 资源评估时间。
        /// </summary>
        [JsonProperty("evaluation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EvaluationTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConformancePackComplianceDetail {\n");
            sb.Append("  policyAssignmentId: ").Append(PolicyAssignmentId).Append("\n");
            sb.Append("  policyAssignmentName: ").Append(PolicyAssignmentName).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  complianceState: ").Append(ComplianceState).Append("\n");
            sb.Append("  evaluationTime: ").Append(EvaluationTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConformancePackComplianceDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConformancePackComplianceDetail input)
        {
            if (input == null) return false;
            if (this.PolicyAssignmentId != input.PolicyAssignmentId || (this.PolicyAssignmentId != null && !this.PolicyAssignmentId.Equals(input.PolicyAssignmentId))) return false;
            if (this.PolicyAssignmentName != input.PolicyAssignmentName || (this.PolicyAssignmentName != null && !this.PolicyAssignmentName.Equals(input.PolicyAssignmentName))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ComplianceState != input.ComplianceState || (this.ComplianceState != null && !this.ComplianceState.Equals(input.ComplianceState))) return false;
            if (this.EvaluationTime != input.EvaluationTime || (this.EvaluationTime != null && !this.EvaluationTime.Equals(input.EvaluationTime))) return false;

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
                if (this.PolicyAssignmentId != null) hashCode = hashCode * 59 + this.PolicyAssignmentId.GetHashCode();
                if (this.PolicyAssignmentName != null) hashCode = hashCode * 59 + this.PolicyAssignmentName.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ComplianceState != null) hashCode = hashCode * 59 + this.ComplianceState.GetHashCode();
                if (this.EvaluationTime != null) hashCode = hashCode * 59 + this.EvaluationTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
