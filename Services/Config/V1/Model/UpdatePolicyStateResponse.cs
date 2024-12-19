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
    public class UpdatePolicyStateResponse : SdkResponse
    {

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 资源区域ID
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("resource_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 触发器类型，可选值：resource, period
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 合规状态
        /// </summary>
        [JsonProperty("compliance_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplianceState { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentName { get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("policy_definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// 合规状态评估时间
        /// </summary>
        [JsonProperty("evaluation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EvaluationTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePolicyStateResponse {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceProvider: ").Append(ResourceProvider).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  complianceState: ").Append(ComplianceState).Append("\n");
            sb.Append("  policyAssignmentId: ").Append(PolicyAssignmentId).Append("\n");
            sb.Append("  policyAssignmentName: ").Append(PolicyAssignmentName).Append("\n");
            sb.Append("  policyDefinitionId: ").Append(PolicyDefinitionId).Append("\n");
            sb.Append("  evaluationTime: ").Append(EvaluationTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePolicyStateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePolicyStateResponse input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceProvider != input.ResourceProvider || (this.ResourceProvider != null && !this.ResourceProvider.Equals(input.ResourceProvider))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.ComplianceState != input.ComplianceState || (this.ComplianceState != null && !this.ComplianceState.Equals(input.ComplianceState))) return false;
            if (this.PolicyAssignmentId != input.PolicyAssignmentId || (this.PolicyAssignmentId != null && !this.PolicyAssignmentId.Equals(input.PolicyAssignmentId))) return false;
            if (this.PolicyAssignmentName != input.PolicyAssignmentName || (this.PolicyAssignmentName != null && !this.PolicyAssignmentName.Equals(input.PolicyAssignmentName))) return false;
            if (this.PolicyDefinitionId != input.PolicyDefinitionId || (this.PolicyDefinitionId != null && !this.PolicyDefinitionId.Equals(input.PolicyDefinitionId))) return false;
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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceProvider != null) hashCode = hashCode * 59 + this.ResourceProvider.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.ComplianceState != null) hashCode = hashCode * 59 + this.ComplianceState.GetHashCode();
                if (this.PolicyAssignmentId != null) hashCode = hashCode * 59 + this.PolicyAssignmentId.GetHashCode();
                if (this.PolicyAssignmentName != null) hashCode = hashCode * 59 + this.PolicyAssignmentName.GetHashCode();
                if (this.PolicyDefinitionId != null) hashCode = hashCode * 59 + this.PolicyDefinitionId.GetHashCode();
                if (this.EvaluationTime != null) hashCode = hashCode * 59 + this.EvaluationTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
