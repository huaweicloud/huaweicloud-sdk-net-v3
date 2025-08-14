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
    public class CollectPolicyAssignmentsStatesSummaryResponse : SdkResponse
    {

        /// <summary>
        /// 规则合规状态
        /// </summary>
        [JsonProperty("compliance_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplianceState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_assignment", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyAssignment PolicyAssignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyComplianceSummaryResults Results { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectPolicyAssignmentsStatesSummaryResponse {\n");
            sb.Append("  complianceState: ").Append(ComplianceState).Append("\n");
            sb.Append("  policyAssignment: ").Append(PolicyAssignment).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectPolicyAssignmentsStatesSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectPolicyAssignmentsStatesSummaryResponse input)
        {
            if (input == null) return false;
            if (this.ComplianceState != input.ComplianceState || (this.ComplianceState != null && !this.ComplianceState.Equals(input.ComplianceState))) return false;
            if (this.PolicyAssignment != input.PolicyAssignment || (this.PolicyAssignment != null && !this.PolicyAssignment.Equals(input.PolicyAssignment))) return false;
            if (this.Results != input.Results || (this.Results != null && !this.Results.Equals(input.Results))) return false;

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
                if (this.ComplianceState != null) hashCode = hashCode * 59 + this.ComplianceState.GetHashCode();
                if (this.PolicyAssignment != null) hashCode = hashCode * 59 + this.PolicyAssignment.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                return hashCode;
            }
        }
    }
}
