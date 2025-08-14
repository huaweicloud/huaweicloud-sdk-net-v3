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
    /// 合规总结结果
    /// </summary>
    public class PolicyComplianceSummaryResults 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_details", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyComplianceSummaryUnit ResourceDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignment_details", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyComplianceSummaryUnit AssignmentDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyComplianceSummaryResults {\n");
            sb.Append("  resourceDetails: ").Append(ResourceDetails).Append("\n");
            sb.Append("  assignmentDetails: ").Append(AssignmentDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyComplianceSummaryResults);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyComplianceSummaryResults input)
        {
            if (input == null) return false;
            if (this.ResourceDetails != input.ResourceDetails || (this.ResourceDetails != null && !this.ResourceDetails.Equals(input.ResourceDetails))) return false;
            if (this.AssignmentDetails != input.AssignmentDetails || (this.AssignmentDetails != null && !this.AssignmentDetails.Equals(input.AssignmentDetails))) return false;

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
                if (this.ResourceDetails != null) hashCode = hashCode * 59 + this.ResourceDetails.GetHashCode();
                if (this.AssignmentDetails != null) hashCode = hashCode * 59 + this.AssignmentDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
