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
    public class CollectPolicyStatesSummaryResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyComplianceSummaryResults Results { get; set; }

        /// <summary>
        /// 规则合规总结列表
        /// </summary>
        [JsonProperty("policy_assignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyAssignmentComplianceSummary> PolicyAssignments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectPolicyStatesSummaryResponse {\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  policyAssignments: ").Append(PolicyAssignments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectPolicyStatesSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectPolicyStatesSummaryResponse input)
        {
            if (input == null) return false;
            if (this.Results != input.Results || (this.Results != null && !this.Results.Equals(input.Results))) return false;
            if (this.PolicyAssignments != input.PolicyAssignments || (this.PolicyAssignments != null && input.PolicyAssignments != null && !this.PolicyAssignments.SequenceEqual(input.PolicyAssignments))) return false;

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
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.PolicyAssignments != null) hashCode = hashCode * 59 + this.PolicyAssignments.GetHashCode();
                return hashCode;
            }
        }
    }
}
