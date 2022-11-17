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
    /// 
    /// </summary>
    public class IssueCompletionRateV4IssueCompletionRates 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue_status", NullValueHandling = NullValueHandling.Ignore)]
        public IssueCompletionRateV4IssueStatus IssueStatus { get; set; }

        /// <summary>
        /// 工作项类型id,1需求,2任务/Task,3缺陷/Bug,5Epic,6Feature,7Story
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrackerId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueCompletionRateV4IssueCompletionRates {\n");
            sb.Append("  issueStatus: ").Append(IssueStatus).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueCompletionRateV4IssueCompletionRates);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueCompletionRateV4IssueCompletionRates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssueStatus == input.IssueStatus ||
                    (this.IssueStatus != null &&
                    this.IssueStatus.Equals(input.IssueStatus))
                ) && 
                (
                    this.TrackerId == input.TrackerId ||
                    (this.TrackerId != null &&
                    this.TrackerId.Equals(input.TrackerId))
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
                if (this.IssueStatus != null)
                    hashCode = hashCode * 59 + this.IssueStatus.GetHashCode();
                if (this.TrackerId != null)
                    hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
