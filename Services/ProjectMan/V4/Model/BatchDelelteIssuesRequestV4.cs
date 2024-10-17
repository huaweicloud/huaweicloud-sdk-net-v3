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
    public class BatchDelelteIssuesRequestV4 
    {

        /// <summary>
        /// 工作项的id
        /// </summary>
        [JsonProperty("issue_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> IssueIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDelelteIssuesRequestV4 {\n");
            sb.Append("  issueIds: ").Append(IssueIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDelelteIssuesRequestV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDelelteIssuesRequestV4 input)
        {
            if (input == null) return false;
            if (this.IssueIds != input.IssueIds || (this.IssueIds != null && input.IssueIds != null && !this.IssueIds.SequenceEqual(input.IssueIds))) return false;

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
                if (this.IssueIds != null) hashCode = hashCode * 59 + this.IssueIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
