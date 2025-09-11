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
    /// Request Object
    /// </summary>
    public class ListIpdProjectIssuesRequest 
    {

        /// <summary>
        /// devcloud项目的32位id
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 是否backlog查询
        /// </summary>
        [SDKProperty("is_backlog", IsQuery = true)]
        [JsonProperty("is_backlog", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBacklog { get; set; }

        /// <summary>
        /// 工作项分类：[Epic,FE,IR,RR,SR,US,AR,Bug,Task]
        /// </summary>
        [SDKProperty("issue_type", IsQuery = true)]
        [JsonProperty("issue_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueType { get; set; }

        /// <summary>
        /// 提出项目Id
        /// </summary>
        [SDKProperty("src_domain_id", IsQuery = true)]
        [JsonProperty("src_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDomainId { get; set; }

        /// <summary>
        /// 视图模式[tree,list]
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public string View { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public SearchIpdIssuesRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIpdProjectIssuesRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  isBacklog: ").Append(IsBacklog).Append("\n");
            sb.Append("  issueType: ").Append(IssueType).Append("\n");
            sb.Append("  srcDomainId: ").Append(SrcDomainId).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIpdProjectIssuesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIpdProjectIssuesRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IsBacklog != input.IsBacklog || (this.IsBacklog != null && !this.IsBacklog.Equals(input.IsBacklog))) return false;
            if (this.IssueType != input.IssueType || (this.IssueType != null && !this.IssueType.Equals(input.IssueType))) return false;
            if (this.SrcDomainId != input.SrcDomainId || (this.SrcDomainId != null && !this.SrcDomainId.Equals(input.SrcDomainId))) return false;
            if (this.View != input.View || (this.View != null && !this.View.Equals(input.View))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IsBacklog != null) hashCode = hashCode * 59 + this.IsBacklog.GetHashCode();
                if (this.IssueType != null) hashCode = hashCode * 59 + this.IssueType.GetHashCode();
                if (this.SrcDomainId != null) hashCode = hashCode * 59 + this.SrcDomainId.GetHashCode();
                if (this.View != null) hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
