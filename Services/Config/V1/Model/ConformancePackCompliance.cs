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
    /// 合规规则评估结果。
    /// </summary>
    public class ConformancePackCompliance 
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
        /// 合规规则合规结果。
        /// </summary>
        [JsonProperty("policy_assignment_compliance", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentCompliance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConformancePackCompliance {\n");
            sb.Append("  policyAssignmentId: ").Append(PolicyAssignmentId).Append("\n");
            sb.Append("  policyAssignmentName: ").Append(PolicyAssignmentName).Append("\n");
            sb.Append("  policyAssignmentCompliance: ").Append(PolicyAssignmentCompliance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConformancePackCompliance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConformancePackCompliance input)
        {
            if (input == null) return false;
            if (this.PolicyAssignmentId != input.PolicyAssignmentId || (this.PolicyAssignmentId != null && !this.PolicyAssignmentId.Equals(input.PolicyAssignmentId))) return false;
            if (this.PolicyAssignmentName != input.PolicyAssignmentName || (this.PolicyAssignmentName != null && !this.PolicyAssignmentName.Equals(input.PolicyAssignmentName))) return false;
            if (this.PolicyAssignmentCompliance != input.PolicyAssignmentCompliance || (this.PolicyAssignmentCompliance != null && !this.PolicyAssignmentCompliance.Equals(input.PolicyAssignmentCompliance))) return false;

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
                if (this.PolicyAssignmentCompliance != null) hashCode = hashCode * 59 + this.PolicyAssignmentCompliance.GetHashCode();
                return hashCode;
            }
        }
    }
}
