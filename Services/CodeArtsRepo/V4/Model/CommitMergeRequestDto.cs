using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 提交关联的合并请求详情
    /// </summary>
    public class CommitMergeRequestDto 
    {

        /// <summary>
        /// **参数解释：** 合并请求的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的序号。
        /// </summary>
        [JsonProperty("iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iid { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的详细描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求创建的时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求最后一次更新的时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("merged_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto MergedBy { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求被合并的时间。
        /// </summary>
        [JsonProperty("merged_at", NullValueHandling = NullValueHandling.Ignore)]
        public string MergedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("closed_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto ClosedBy { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求被关闭的时间。
        /// </summary>
        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedAt { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的目标分支名称。
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的源分支名称。
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求中检视意见的数量。
        /// </summary>
        [JsonProperty("user_notes_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserNotesCount { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的正向评分数量。
        /// </summary>
        [JsonProperty("upvotes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Upvotes { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的负向评分数量。
        /// </summary>
        [JsonProperty("downvotes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Downvotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Author { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的可合并人列表。
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> Assignee { get; set; }

        /// <summary>
        /// **参数解释：** 源仓库的唯一标识符。
        /// </summary>
        [JsonProperty("source_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceRepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 目标仓库的唯一标识符。
        /// </summary>
        [JsonProperty("target_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetRepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求关联的标签列表。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// **参数解释：** 表示合并请求是否处于“工作进行中”状态。
        /// </summary>
        [JsonProperty("work_in_progress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WorkInProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("milestone", NullValueHandling = NullValueHandling.Ignore)]
        public MilestoneBasicDto Milestone { get; set; }

        /// <summary>
        /// **参数解释：** 表示是否在CI/CD管道成功时自动合并请求。
        /// </summary>
        [JsonProperty("merge_when_pipeline_succeeds", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergeWhenPipelineSucceeds { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的合并状态。
        /// </summary>
        [JsonProperty("merge_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeStatus { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的提交哈希值。
        /// </summary>
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        /// <summary>
        /// **参数解释：** 合并提交的哈希值。
        /// </summary>
        [JsonProperty("merge_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeCommitSha { get; set; }

        /// <summary>
        /// **参数解释：** 表示合并请求的讨论是否被锁定。
        /// </summary>
        [JsonProperty("discussion_locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiscussionLocked { get; set; }

        /// <summary>
        /// **参数解释：** 表示是否强制删除源分支。
        /// </summary>
        [JsonProperty("force_remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRemoveSourceBranch { get; set; }

        /// <summary>
        /// **参数解释：** 表示是否应该删除源分支。
        /// </summary>
        [JsonProperty("should_remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShouldRemoveSourceBranch { get; set; }

        /// <summary>
        /// **参数解释：** 表示是否允许协作者参与。
        /// </summary>
        [JsonProperty("allow_collaboration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowCollaboration { get; set; }

        /// <summary>
        /// **参数解释：** 表示是否允许维护者推送代码。
        /// </summary>
        [JsonProperty("allow_maintainer_to_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowMaintainerToPush { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的网页URL链接。
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time_stats", NullValueHandling = NullValueHandling.Ignore)]
        public IssuableTimeStatsDto TimeStats { get; set; }

        /// <summary>
        /// **参数解释：** 表示是否在合并时将提交压缩为一个。
        /// </summary>
        [JsonProperty("squash", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Squash { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的类型。
        /// </summary>
        [JsonProperty("merge_request_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitMergeRequestDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  mergedBy: ").Append(MergedBy).Append("\n");
            sb.Append("  mergedAt: ").Append(MergedAt).Append("\n");
            sb.Append("  closedBy: ").Append(ClosedBy).Append("\n");
            sb.Append("  closedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  userNotesCount: ").Append(UserNotesCount).Append("\n");
            sb.Append("  upvotes: ").Append(Upvotes).Append("\n");
            sb.Append("  downvotes: ").Append(Downvotes).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  sourceRepositoryId: ").Append(SourceRepositoryId).Append("\n");
            sb.Append("  targetRepositoryId: ").Append(TargetRepositoryId).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  workInProgress: ").Append(WorkInProgress).Append("\n");
            sb.Append("  milestone: ").Append(Milestone).Append("\n");
            sb.Append("  mergeWhenPipelineSucceeds: ").Append(MergeWhenPipelineSucceeds).Append("\n");
            sb.Append("  mergeStatus: ").Append(MergeStatus).Append("\n");
            sb.Append("  sha: ").Append(Sha).Append("\n");
            sb.Append("  mergeCommitSha: ").Append(MergeCommitSha).Append("\n");
            sb.Append("  discussionLocked: ").Append(DiscussionLocked).Append("\n");
            sb.Append("  forceRemoveSourceBranch: ").Append(ForceRemoveSourceBranch).Append("\n");
            sb.Append("  shouldRemoveSourceBranch: ").Append(ShouldRemoveSourceBranch).Append("\n");
            sb.Append("  allowCollaboration: ").Append(AllowCollaboration).Append("\n");
            sb.Append("  allowMaintainerToPush: ").Append(AllowMaintainerToPush).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  timeStats: ").Append(TimeStats).Append("\n");
            sb.Append("  squash: ").Append(Squash).Append("\n");
            sb.Append("  mergeRequestType: ").Append(MergeRequestType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommitMergeRequestDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitMergeRequestDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.MergedBy != input.MergedBy || (this.MergedBy != null && !this.MergedBy.Equals(input.MergedBy))) return false;
            if (this.MergedAt != input.MergedAt || (this.MergedAt != null && !this.MergedAt.Equals(input.MergedAt))) return false;
            if (this.ClosedBy != input.ClosedBy || (this.ClosedBy != null && !this.ClosedBy.Equals(input.ClosedBy))) return false;
            if (this.ClosedAt != input.ClosedAt || (this.ClosedAt != null && !this.ClosedAt.Equals(input.ClosedAt))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.UserNotesCount != input.UserNotesCount || (this.UserNotesCount != null && !this.UserNotesCount.Equals(input.UserNotesCount))) return false;
            if (this.Upvotes != input.Upvotes || (this.Upvotes != null && !this.Upvotes.Equals(input.Upvotes))) return false;
            if (this.Downvotes != input.Downvotes || (this.Downvotes != null && !this.Downvotes.Equals(input.Downvotes))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && input.Assignee != null && !this.Assignee.SequenceEqual(input.Assignee))) return false;
            if (this.SourceRepositoryId != input.SourceRepositoryId || (this.SourceRepositoryId != null && !this.SourceRepositoryId.Equals(input.SourceRepositoryId))) return false;
            if (this.TargetRepositoryId != input.TargetRepositoryId || (this.TargetRepositoryId != null && !this.TargetRepositoryId.Equals(input.TargetRepositoryId))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.WorkInProgress != input.WorkInProgress || (this.WorkInProgress != null && !this.WorkInProgress.Equals(input.WorkInProgress))) return false;
            if (this.Milestone != input.Milestone || (this.Milestone != null && !this.Milestone.Equals(input.Milestone))) return false;
            if (this.MergeWhenPipelineSucceeds != input.MergeWhenPipelineSucceeds || (this.MergeWhenPipelineSucceeds != null && !this.MergeWhenPipelineSucceeds.Equals(input.MergeWhenPipelineSucceeds))) return false;
            if (this.MergeStatus != input.MergeStatus || (this.MergeStatus != null && !this.MergeStatus.Equals(input.MergeStatus))) return false;
            if (this.Sha != input.Sha || (this.Sha != null && !this.Sha.Equals(input.Sha))) return false;
            if (this.MergeCommitSha != input.MergeCommitSha || (this.MergeCommitSha != null && !this.MergeCommitSha.Equals(input.MergeCommitSha))) return false;
            if (this.DiscussionLocked != input.DiscussionLocked || (this.DiscussionLocked != null && !this.DiscussionLocked.Equals(input.DiscussionLocked))) return false;
            if (this.ForceRemoveSourceBranch != input.ForceRemoveSourceBranch || (this.ForceRemoveSourceBranch != null && !this.ForceRemoveSourceBranch.Equals(input.ForceRemoveSourceBranch))) return false;
            if (this.ShouldRemoveSourceBranch != input.ShouldRemoveSourceBranch || (this.ShouldRemoveSourceBranch != null && !this.ShouldRemoveSourceBranch.Equals(input.ShouldRemoveSourceBranch))) return false;
            if (this.AllowCollaboration != input.AllowCollaboration || (this.AllowCollaboration != null && !this.AllowCollaboration.Equals(input.AllowCollaboration))) return false;
            if (this.AllowMaintainerToPush != input.AllowMaintainerToPush || (this.AllowMaintainerToPush != null && !this.AllowMaintainerToPush.Equals(input.AllowMaintainerToPush))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.TimeStats != input.TimeStats || (this.TimeStats != null && !this.TimeStats.Equals(input.TimeStats))) return false;
            if (this.Squash != input.Squash || (this.Squash != null && !this.Squash.Equals(input.Squash))) return false;
            if (this.MergeRequestType != input.MergeRequestType || (this.MergeRequestType != null && !this.MergeRequestType.Equals(input.MergeRequestType))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.MergedBy != null) hashCode = hashCode * 59 + this.MergedBy.GetHashCode();
                if (this.MergedAt != null) hashCode = hashCode * 59 + this.MergedAt.GetHashCode();
                if (this.ClosedBy != null) hashCode = hashCode * 59 + this.ClosedBy.GetHashCode();
                if (this.ClosedAt != null) hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.UserNotesCount != null) hashCode = hashCode * 59 + this.UserNotesCount.GetHashCode();
                if (this.Upvotes != null) hashCode = hashCode * 59 + this.Upvotes.GetHashCode();
                if (this.Downvotes != null) hashCode = hashCode * 59 + this.Downvotes.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.SourceRepositoryId != null) hashCode = hashCode * 59 + this.SourceRepositoryId.GetHashCode();
                if (this.TargetRepositoryId != null) hashCode = hashCode * 59 + this.TargetRepositoryId.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.WorkInProgress != null) hashCode = hashCode * 59 + this.WorkInProgress.GetHashCode();
                if (this.Milestone != null) hashCode = hashCode * 59 + this.Milestone.GetHashCode();
                if (this.MergeWhenPipelineSucceeds != null) hashCode = hashCode * 59 + this.MergeWhenPipelineSucceeds.GetHashCode();
                if (this.MergeStatus != null) hashCode = hashCode * 59 + this.MergeStatus.GetHashCode();
                if (this.Sha != null) hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.MergeCommitSha != null) hashCode = hashCode * 59 + this.MergeCommitSha.GetHashCode();
                if (this.DiscussionLocked != null) hashCode = hashCode * 59 + this.DiscussionLocked.GetHashCode();
                if (this.ForceRemoveSourceBranch != null) hashCode = hashCode * 59 + this.ForceRemoveSourceBranch.GetHashCode();
                if (this.ShouldRemoveSourceBranch != null) hashCode = hashCode * 59 + this.ShouldRemoveSourceBranch.GetHashCode();
                if (this.AllowCollaboration != null) hashCode = hashCode * 59 + this.AllowCollaboration.GetHashCode();
                if (this.AllowMaintainerToPush != null) hashCode = hashCode * 59 + this.AllowMaintainerToPush.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.TimeStats != null) hashCode = hashCode * 59 + this.TimeStats.GetHashCode();
                if (this.Squash != null) hashCode = hashCode * 59 + this.Squash.GetHashCode();
                if (this.MergeRequestType != null) hashCode = hashCode * 59 + this.MergeRequestType.GetHashCode();
                return hashCode;
            }
        }
    }
}
