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
    /// 合规规则合规性
    /// </summary>
    public class Compliance 
    {

        /// <summary>
        /// 合规结果。
        /// </summary>
        [JsonProperty("compliance_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplianceState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_details", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyComplianceSummaryUnit ResourceDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Compliance {\n");
            sb.Append("  complianceState: ").Append(ComplianceState).Append("\n");
            sb.Append("  resourceDetails: ").Append(ResourceDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Compliance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Compliance input)
        {
            if (input == null) return false;
            if (this.ComplianceState != input.ComplianceState || (this.ComplianceState != null && !this.ComplianceState.Equals(input.ComplianceState))) return false;
            if (this.ResourceDetails != input.ResourceDetails || (this.ResourceDetails != null && !this.ResourceDetails.Equals(input.ResourceDetails))) return false;

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
                if (this.ResourceDetails != null) hashCode = hashCode * 59 + this.ResourceDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
