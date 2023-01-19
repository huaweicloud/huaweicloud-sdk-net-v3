using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIssueCompletionRateResponse : SdkResponse
    {

        /// <summary>
        /// 不同类型的工作项完成率
        /// </summary>
        [JsonProperty("issue_completion_rates", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueCompletionRateV4IssueCompletionRates> IssueCompletionRates { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIssueCompletionRateResponse {\n");
            sb.Append("  issueCompletionRates: ").Append(IssueCompletionRates).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIssueCompletionRateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIssueCompletionRateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssueCompletionRates == input.IssueCompletionRates ||
                    this.IssueCompletionRates != null &&
                    input.IssueCompletionRates != null &&
                    this.IssueCompletionRates.SequenceEqual(input.IssueCompletionRates)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.IssueCompletionRates != null)
                    hashCode = hashCode * 59 + this.IssueCompletionRates.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
