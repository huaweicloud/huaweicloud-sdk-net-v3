using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepoHook 
    {

        /// <summary>
        /// 是否触发build_events事件
        /// </summary>
        [JsonProperty("build_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BuildEvents { get; set; }

        /// <summary>
        /// 仓库统计创建的时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 是否使用ssl验证
        /// </summary>
        [JsonProperty("enable_ssl_verification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSslVerification { get; set; }

        /// <summary>
        /// hook id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 是否触发issues_events事件
        /// </summary>
        [JsonProperty("issues_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IssuesEvents { get; set; }

        /// <summary>
        /// 是否触发merge_requests_events事件
        /// </summary>
        [JsonProperty("merge_requests_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergeRequestsEvents { get; set; }

        /// <summary>
        /// 是否触发note_events事件
        /// </summary>
        [JsonProperty("note_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoteEvents { get; set; }

        /// <summary>
        /// 是否触发pipeline_events事件
        /// </summary>
        [JsonProperty("pipeline_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PipelineEvents { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 是否触发push_events事件
        /// </summary>
        [JsonProperty("push_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PushEvents { get; set; }

        /// <summary>
        /// 是否触发repository_update_events事件
        /// </summary>
        [JsonProperty("repository_update_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RepositoryUpdateEvents { get; set; }

        /// <summary>
        /// 是否触发tag_push_events事件
        /// </summary>
        [JsonProperty("tag_push_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TagPushEvents { get; set; }

        /// <summary>
        /// 是否触发wiki_page_events事件
        /// </summary>
        [JsonProperty("wiki_page_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WikiPageEvents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoHook {\n");
            sb.Append("  buildEvents: ").Append(BuildEvents).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  enableSslVerification: ").Append(EnableSslVerification).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  issuesEvents: ").Append(IssuesEvents).Append("\n");
            sb.Append("  mergeRequestsEvents: ").Append(MergeRequestsEvents).Append("\n");
            sb.Append("  noteEvents: ").Append(NoteEvents).Append("\n");
            sb.Append("  pipelineEvents: ").Append(PipelineEvents).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  pushEvents: ").Append(PushEvents).Append("\n");
            sb.Append("  repositoryUpdateEvents: ").Append(RepositoryUpdateEvents).Append("\n");
            sb.Append("  tagPushEvents: ").Append(TagPushEvents).Append("\n");
            sb.Append("  wikiPageEvents: ").Append(WikiPageEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoHook);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoHook input)
        {
            if (input == null) return false;
            if (this.BuildEvents != input.BuildEvents || (this.BuildEvents != null && !this.BuildEvents.Equals(input.BuildEvents))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.EnableSslVerification != input.EnableSslVerification || (this.EnableSslVerification != null && !this.EnableSslVerification.Equals(input.EnableSslVerification))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IssuesEvents != input.IssuesEvents || (this.IssuesEvents != null && !this.IssuesEvents.Equals(input.IssuesEvents))) return false;
            if (this.MergeRequestsEvents != input.MergeRequestsEvents || (this.MergeRequestsEvents != null && !this.MergeRequestsEvents.Equals(input.MergeRequestsEvents))) return false;
            if (this.NoteEvents != input.NoteEvents || (this.NoteEvents != null && !this.NoteEvents.Equals(input.NoteEvents))) return false;
            if (this.PipelineEvents != input.PipelineEvents || (this.PipelineEvents != null && !this.PipelineEvents.Equals(input.PipelineEvents))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PushEvents != input.PushEvents || (this.PushEvents != null && !this.PushEvents.Equals(input.PushEvents))) return false;
            if (this.RepositoryUpdateEvents != input.RepositoryUpdateEvents || (this.RepositoryUpdateEvents != null && !this.RepositoryUpdateEvents.Equals(input.RepositoryUpdateEvents))) return false;
            if (this.TagPushEvents != input.TagPushEvents || (this.TagPushEvents != null && !this.TagPushEvents.Equals(input.TagPushEvents))) return false;
            if (this.WikiPageEvents != input.WikiPageEvents || (this.WikiPageEvents != null && !this.WikiPageEvents.Equals(input.WikiPageEvents))) return false;

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
                if (this.BuildEvents != null) hashCode = hashCode * 59 + this.BuildEvents.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EnableSslVerification != null) hashCode = hashCode * 59 + this.EnableSslVerification.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssuesEvents != null) hashCode = hashCode * 59 + this.IssuesEvents.GetHashCode();
                if (this.MergeRequestsEvents != null) hashCode = hashCode * 59 + this.MergeRequestsEvents.GetHashCode();
                if (this.NoteEvents != null) hashCode = hashCode * 59 + this.NoteEvents.GetHashCode();
                if (this.PipelineEvents != null) hashCode = hashCode * 59 + this.PipelineEvents.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.PushEvents != null) hashCode = hashCode * 59 + this.PushEvents.GetHashCode();
                if (this.RepositoryUpdateEvents != null) hashCode = hashCode * 59 + this.RepositoryUpdateEvents.GetHashCode();
                if (this.TagPushEvents != null) hashCode = hashCode * 59 + this.TagPushEvents.GetHashCode();
                if (this.WikiPageEvents != null) hashCode = hashCode * 59 + this.WikiPageEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
