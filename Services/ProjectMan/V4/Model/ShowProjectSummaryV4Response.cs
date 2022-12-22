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
    public class ShowProjectSummaryV4Response : SdkResponse
    {

        /// <summary>
        /// bug统计列表
        /// </summary>
        [JsonProperty("bug_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<BugStatisticResponseV4> BugStatistics { get; set; }

        /// <summary>
        /// 按模块统计列表
        /// </summary>
        [JsonProperty("demand_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemandStatisticResponseV4> DemandStatistics { get; set; }

        /// <summary>
        /// 按工作项类型统计列表
        /// </summary>
        [JsonProperty("issue_completion_rates", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueCompletionRateResponseV4> IssueCompletionRates { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectSummaryV4Response {\n");
            sb.Append("  bugStatistics: ").Append(BugStatistics).Append("\n");
            sb.Append("  demandStatistics: ").Append(DemandStatistics).Append("\n");
            sb.Append("  issueCompletionRates: ").Append(IssueCompletionRates).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectSummaryV4Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectSummaryV4Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BugStatistics == input.BugStatistics ||
                    this.BugStatistics != null &&
                    input.BugStatistics != null &&
                    this.BugStatistics.SequenceEqual(input.BugStatistics)
                ) && 
                (
                    this.DemandStatistics == input.DemandStatistics ||
                    this.DemandStatistics != null &&
                    input.DemandStatistics != null &&
                    this.DemandStatistics.SequenceEqual(input.DemandStatistics)
                ) && 
                (
                    this.IssueCompletionRates == input.IssueCompletionRates ||
                    this.IssueCompletionRates != null &&
                    input.IssueCompletionRates != null &&
                    this.IssueCompletionRates.SequenceEqual(input.IssueCompletionRates)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.BugStatistics != null)
                    hashCode = hashCode * 59 + this.BugStatistics.GetHashCode();
                if (this.DemandStatistics != null)
                    hashCode = hashCode * 59 + this.DemandStatistics.GetHashCode();
                if (this.IssueCompletionRates != null)
                    hashCode = hashCode * 59 + this.IssueCompletionRates.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
