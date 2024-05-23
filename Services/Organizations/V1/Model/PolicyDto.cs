using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 包含有关策略的详细信息的结构。
    /// </summary>
    public class PolicyDto 
    {

        /// <summary>
        /// 策略的文本内容。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_summary", NullValueHandling = NullValueHandling.Ignore)]
        public PolicySummaryDto PolicySummary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyDto {\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  policySummary: ").Append(PolicySummary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.PolicySummary == input.PolicySummary ||
                    (this.PolicySummary != null &&
                    this.PolicySummary.Equals(input.PolicySummary))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.PolicySummary != null)
                    hashCode = hashCode * 59 + this.PolicySummary.GetHashCode();
                return hashCode;
            }
        }
    }
}
