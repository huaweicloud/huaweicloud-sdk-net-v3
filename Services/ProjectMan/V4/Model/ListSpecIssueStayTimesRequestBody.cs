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
    public class ListSpecIssueStayTimesRequestBody 
    {

        /// <summary>
        /// 项目uuid
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工作项id字符串列表
        /// </summary>
        [JsonProperty("issue_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IssueIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSpecIssueStayTimesRequestBody {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  issueIds: ").Append(IssueIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSpecIssueStayTimesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSpecIssueStayTimesRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.IssueIds == input.IssueIds ||
                    this.IssueIds != null &&
                    input.IssueIds != null &&
                    this.IssueIds.SequenceEqual(input.IssueIds)
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IssueIds != null)
                    hashCode = hashCode * 59 + this.IssueIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
