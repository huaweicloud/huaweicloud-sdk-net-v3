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
    /// 资源合规总结
    /// </summary>
    public class PolicyResourceComplianceSummary 
    {

        /// <summary>
        /// 规则合规状态
        /// </summary>
        [JsonProperty("compliance_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplianceState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyResource Resource { get; set; }

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
            sb.Append("class PolicyResourceComplianceSummary {\n");
            sb.Append("  complianceState: ").Append(ComplianceState).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyResourceComplianceSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyResourceComplianceSummary input)
        {
            if (input == null) return false;
            if (this.ComplianceState != input.ComplianceState || (this.ComplianceState != null && !this.ComplianceState.Equals(input.ComplianceState))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
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
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                return hashCode;
            }
        }
    }
}
