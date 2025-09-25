using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponseMergeRequestChanges 
    {

        /// <summary>
        /// 合并请求id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 合并请求iid
        /// </summary>
        [JsonProperty("iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iid { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 合并请求标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 合并请求描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 合并请求状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 合并请求创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 合并请求更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 合并请求目标分支
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// 合并请求源分支
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// 检视意见数量
        /// </summary>
        [JsonProperty("user_notes_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserNotesCount { get; set; }

        /// <summary>
        /// upvotes
        /// </summary>
        [JsonProperty("upvotes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Upvotes { get; set; }

        /// <summary>
        /// downvotes
        /// </summary>
        [JsonProperty("downvotes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Downvotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public Author Author { get; set; }

        /// <summary>
        /// 合并请求源仓库id
        /// </summary>
        [JsonProperty("source_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceProjectId { get; set; }

        /// <summary>
        /// 合并请求目标仓库id
        /// </summary>
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetProjectId { get; set; }

        /// <summary>
        /// 指定仓库的标签列表
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// 合并请求是否为wip状态
        /// </summary>
        [JsonProperty("work_in_progress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WorkInProgress { get; set; }

        /// <summary>
        /// 合并请求是否开启流水线成功后自动合入
        /// </summary>
        [JsonProperty("merge_when_pipeline_succeeds", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergeWhenPipelineSucceeds { get; set; }

        /// <summary>
        /// 合并请求合入状态
        /// </summary>
        [JsonProperty("merge_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeStatus { get; set; }

        /// <summary>
        /// 合并请求的head sha
        /// </summary>
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        /// <summary>
        /// 合并请求合入后是否应该移除源分支
        /// </summary>
        [JsonProperty("should_remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShouldRemoveSourceBranch { get; set; }

        /// <summary>
        /// 合并请求合入后是否移除源分支
        /// </summary>
        [JsonProperty("force_remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRemoveSourceBranch { get; set; }

        /// <summary>
        /// 合并请求url
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 合并请求是否开启squash合并
        /// </summary>
        [JsonProperty("squash", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Squash { get; set; }

        /// <summary>
        /// 合并请求类型
        /// </summary>
        [JsonProperty("merge_request_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestType { get; set; }

        /// <summary>
        /// 是否订阅
        /// </summary>
        [JsonProperty("subscribed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribed { get; set; }

        /// <summary>
        /// 合并请求变更文件数量
        /// </summary>
        [JsonProperty("changes_count", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangesCount { get; set; }

        /// <summary>
        /// 合并请求最新构建开始时间
        /// </summary>
        [JsonProperty("latest_build_started_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestBuildStartedAt { get; set; }

        /// <summary>
        /// 合并请求最新构建结束时间
        /// </summary>
        [JsonProperty("latest_build_finished_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestBuildFinishedAt { get; set; }

        /// <summary>
        /// first deployed to production at
        /// </summary>
        [JsonProperty("first_deployed_to_production_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstDeployedToProductionAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public PipelineBasicDto Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("diff_refs", NullValueHandling = NullValueHandling.Ignore)]
        public DiffRefsDto DiffRefs { get; set; }

        /// <summary>
        /// 合并请求操作错误信息
        /// </summary>
        [JsonProperty("merge_error", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeError { get; set; }

        /// <summary>
        /// 合并请求是否rebase中
        /// </summary>
        [JsonProperty("rebase_in_progress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RebaseInProgress { get; set; }

        /// <summary>
        /// 合并请求落后提交数量
        /// </summary>
        [JsonProperty("diverged_commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DivergedCommitsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public MergeRequestListDtoUser User { get; set; }

        /// <summary>
        /// 合并请求增加行数
        /// </summary>
        [JsonProperty("added_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLines { get; set; }

        /// <summary>
        /// 合并请求删除行数
        /// </summary>
        [JsonProperty("removed_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemovedLines { get; set; }

        /// <summary>
        /// 合并请求文件变更
        /// </summary>
        [JsonProperty("changes", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestDiffFileDto> Changes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_project", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectSimpleDto SourceProject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseMergeRequestChanges {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  userNotesCount: ").Append(UserNotesCount).Append("\n");
            sb.Append("  upvotes: ").Append(Upvotes).Append("\n");
            sb.Append("  downvotes: ").Append(Downvotes).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  sourceProjectId: ").Append(SourceProjectId).Append("\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  workInProgress: ").Append(WorkInProgress).Append("\n");
            sb.Append("  mergeWhenPipelineSucceeds: ").Append(MergeWhenPipelineSucceeds).Append("\n");
            sb.Append("  mergeStatus: ").Append(MergeStatus).Append("\n");
            sb.Append("  sha: ").Append(Sha).Append("\n");
            sb.Append("  shouldRemoveSourceBranch: ").Append(ShouldRemoveSourceBranch).Append("\n");
            sb.Append("  forceRemoveSourceBranch: ").Append(ForceRemoveSourceBranch).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  squash: ").Append(Squash).Append("\n");
            sb.Append("  mergeRequestType: ").Append(MergeRequestType).Append("\n");
            sb.Append("  subscribed: ").Append(Subscribed).Append("\n");
            sb.Append("  changesCount: ").Append(ChangesCount).Append("\n");
            sb.Append("  latestBuildStartedAt: ").Append(LatestBuildStartedAt).Append("\n");
            sb.Append("  latestBuildFinishedAt: ").Append(LatestBuildFinishedAt).Append("\n");
            sb.Append("  firstDeployedToProductionAt: ").Append(FirstDeployedToProductionAt).Append("\n");
            sb.Append("  pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  diffRefs: ").Append(DiffRefs).Append("\n");
            sb.Append("  mergeError: ").Append(MergeError).Append("\n");
            sb.Append("  rebaseInProgress: ").Append(RebaseInProgress).Append("\n");
            sb.Append("  divergedCommitsCount: ").Append(DivergedCommitsCount).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  addedLines: ").Append(AddedLines).Append("\n");
            sb.Append("  removedLines: ").Append(RemovedLines).Append("\n");
            sb.Append("  changes: ").Append(Changes).Append("\n");
            sb.Append("  sourceProject: ").Append(SourceProject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseMergeRequestChanges);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResponseMergeRequestChanges input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.UserNotesCount != input.UserNotesCount || (this.UserNotesCount != null && !this.UserNotesCount.Equals(input.UserNotesCount))) return false;
            if (this.Upvotes != input.Upvotes || (this.Upvotes != null && !this.Upvotes.Equals(input.Upvotes))) return false;
            if (this.Downvotes != input.Downvotes || (this.Downvotes != null && !this.Downvotes.Equals(input.Downvotes))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.SourceProjectId != input.SourceProjectId || (this.SourceProjectId != null && !this.SourceProjectId.Equals(input.SourceProjectId))) return false;
            if (this.TargetProjectId != input.TargetProjectId || (this.TargetProjectId != null && !this.TargetProjectId.Equals(input.TargetProjectId))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.WorkInProgress != input.WorkInProgress || (this.WorkInProgress != null && !this.WorkInProgress.Equals(input.WorkInProgress))) return false;
            if (this.MergeWhenPipelineSucceeds != input.MergeWhenPipelineSucceeds || (this.MergeWhenPipelineSucceeds != null && !this.MergeWhenPipelineSucceeds.Equals(input.MergeWhenPipelineSucceeds))) return false;
            if (this.MergeStatus != input.MergeStatus || (this.MergeStatus != null && !this.MergeStatus.Equals(input.MergeStatus))) return false;
            if (this.Sha != input.Sha || (this.Sha != null && !this.Sha.Equals(input.Sha))) return false;
            if (this.ShouldRemoveSourceBranch != input.ShouldRemoveSourceBranch || (this.ShouldRemoveSourceBranch != null && !this.ShouldRemoveSourceBranch.Equals(input.ShouldRemoveSourceBranch))) return false;
            if (this.ForceRemoveSourceBranch != input.ForceRemoveSourceBranch || (this.ForceRemoveSourceBranch != null && !this.ForceRemoveSourceBranch.Equals(input.ForceRemoveSourceBranch))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.Squash != input.Squash || (this.Squash != null && !this.Squash.Equals(input.Squash))) return false;
            if (this.MergeRequestType != input.MergeRequestType || (this.MergeRequestType != null && !this.MergeRequestType.Equals(input.MergeRequestType))) return false;
            if (this.Subscribed != input.Subscribed || (this.Subscribed != null && !this.Subscribed.Equals(input.Subscribed))) return false;
            if (this.ChangesCount != input.ChangesCount || (this.ChangesCount != null && !this.ChangesCount.Equals(input.ChangesCount))) return false;
            if (this.LatestBuildStartedAt != input.LatestBuildStartedAt || (this.LatestBuildStartedAt != null && !this.LatestBuildStartedAt.Equals(input.LatestBuildStartedAt))) return false;
            if (this.LatestBuildFinishedAt != input.LatestBuildFinishedAt || (this.LatestBuildFinishedAt != null && !this.LatestBuildFinishedAt.Equals(input.LatestBuildFinishedAt))) return false;
            if (this.FirstDeployedToProductionAt != input.FirstDeployedToProductionAt || (this.FirstDeployedToProductionAt != null && !this.FirstDeployedToProductionAt.Equals(input.FirstDeployedToProductionAt))) return false;
            if (this.Pipeline != input.Pipeline || (this.Pipeline != null && !this.Pipeline.Equals(input.Pipeline))) return false;
            if (this.DiffRefs != input.DiffRefs || (this.DiffRefs != null && !this.DiffRefs.Equals(input.DiffRefs))) return false;
            if (this.MergeError != input.MergeError || (this.MergeError != null && !this.MergeError.Equals(input.MergeError))) return false;
            if (this.RebaseInProgress != input.RebaseInProgress || (this.RebaseInProgress != null && !this.RebaseInProgress.Equals(input.RebaseInProgress))) return false;
            if (this.DivergedCommitsCount != input.DivergedCommitsCount || (this.DivergedCommitsCount != null && !this.DivergedCommitsCount.Equals(input.DivergedCommitsCount))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.AddedLines != input.AddedLines || (this.AddedLines != null && !this.AddedLines.Equals(input.AddedLines))) return false;
            if (this.RemovedLines != input.RemovedLines || (this.RemovedLines != null && !this.RemovedLines.Equals(input.RemovedLines))) return false;
            if (this.Changes != input.Changes || (this.Changes != null && input.Changes != null && !this.Changes.SequenceEqual(input.Changes))) return false;
            if (this.SourceProject != input.SourceProject || (this.SourceProject != null && !this.SourceProject.Equals(input.SourceProject))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Iid != null) hashCode = hashCode * 59 + this.Iid.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.UserNotesCount != null) hashCode = hashCode * 59 + this.UserNotesCount.GetHashCode();
                if (this.Upvotes != null) hashCode = hashCode * 59 + this.Upvotes.GetHashCode();
                if (this.Downvotes != null) hashCode = hashCode * 59 + this.Downvotes.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.SourceProjectId != null) hashCode = hashCode * 59 + this.SourceProjectId.GetHashCode();
                if (this.TargetProjectId != null) hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.WorkInProgress != null) hashCode = hashCode * 59 + this.WorkInProgress.GetHashCode();
                if (this.MergeWhenPipelineSucceeds != null) hashCode = hashCode * 59 + this.MergeWhenPipelineSucceeds.GetHashCode();
                if (this.MergeStatus != null) hashCode = hashCode * 59 + this.MergeStatus.GetHashCode();
                if (this.Sha != null) hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.ShouldRemoveSourceBranch != null) hashCode = hashCode * 59 + this.ShouldRemoveSourceBranch.GetHashCode();
                if (this.ForceRemoveSourceBranch != null) hashCode = hashCode * 59 + this.ForceRemoveSourceBranch.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.Squash != null) hashCode = hashCode * 59 + this.Squash.GetHashCode();
                if (this.MergeRequestType != null) hashCode = hashCode * 59 + this.MergeRequestType.GetHashCode();
                if (this.Subscribed != null) hashCode = hashCode * 59 + this.Subscribed.GetHashCode();
                if (this.ChangesCount != null) hashCode = hashCode * 59 + this.ChangesCount.GetHashCode();
                if (this.LatestBuildStartedAt != null) hashCode = hashCode * 59 + this.LatestBuildStartedAt.GetHashCode();
                if (this.LatestBuildFinishedAt != null) hashCode = hashCode * 59 + this.LatestBuildFinishedAt.GetHashCode();
                if (this.FirstDeployedToProductionAt != null) hashCode = hashCode * 59 + this.FirstDeployedToProductionAt.GetHashCode();
                if (this.Pipeline != null) hashCode = hashCode * 59 + this.Pipeline.GetHashCode();
                if (this.DiffRefs != null) hashCode = hashCode * 59 + this.DiffRefs.GetHashCode();
                if (this.MergeError != null) hashCode = hashCode * 59 + this.MergeError.GetHashCode();
                if (this.RebaseInProgress != null) hashCode = hashCode * 59 + this.RebaseInProgress.GetHashCode();
                if (this.DivergedCommitsCount != null) hashCode = hashCode * 59 + this.DivergedCommitsCount.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.AddedLines != null) hashCode = hashCode * 59 + this.AddedLines.GetHashCode();
                if (this.RemovedLines != null) hashCode = hashCode * 59 + this.RemovedLines.GetHashCode();
                if (this.Changes != null) hashCode = hashCode * 59 + this.Changes.GetHashCode();
                if (this.SourceProject != null) hashCode = hashCode * 59 + this.SourceProject.GetHashCode();
                return hashCode;
            }
        }
    }
}
