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
    /// 规则总结详情
    /// </summary>
    public class PolicyComplianceSummaryUnit 
    {

        /// <summary>
        /// 合规数量
        /// </summary>
        [JsonProperty("compliant_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompliantCount { get; set; }

        /// <summary>
        /// 不合规数量
        /// </summary>
        [JsonProperty("non_compliant_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NonCompliantCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyComplianceSummaryUnit {\n");
            sb.Append("  compliantCount: ").Append(CompliantCount).Append("\n");
            sb.Append("  nonCompliantCount: ").Append(NonCompliantCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyComplianceSummaryUnit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyComplianceSummaryUnit input)
        {
            if (input == null) return false;
            if (this.CompliantCount != input.CompliantCount || (this.CompliantCount != null && !this.CompliantCount.Equals(input.CompliantCount))) return false;
            if (this.NonCompliantCount != input.NonCompliantCount || (this.NonCompliantCount != null && !this.NonCompliantCount.Equals(input.NonCompliantCount))) return false;

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
                if (this.CompliantCount != null) hashCode = hashCode * 59 + this.CompliantCount.GetHashCode();
                if (this.NonCompliantCount != null) hashCode = hashCode * 59 + this.NonCompliantCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
