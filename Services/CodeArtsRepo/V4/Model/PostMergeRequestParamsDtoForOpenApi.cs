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
    /// 
    /// </summary>
    public class PostMergeRequestParamsDtoForOpenApi 
    {

        /// <summary>
        /// 合并请求标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 源分支
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// 目标分支
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// 目标仓库id
        /// </summary>
        [JsonProperty("target_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetRepositoryId { get; set; }

        /// <summary>
        /// 打分模式评审人ids，使用逗号分隔
        /// </summary>
        [JsonProperty("reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewerIds { get; set; }

        /// <summary>
        /// 合并人ids，使用逗号分隔
        /// </summary>
        [JsonProperty("assignee_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string AssigneeIds { get; set; }

        /// <summary>
        /// 审核模式检视人ids，使用逗号分隔
        /// </summary>
        [JsonProperty("approval_reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalReviewerIds { get; set; }

        /// <summary>
        /// 审核人ids，使用逗号分隔
        /// </summary>
        [JsonProperty("approval_approvers_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalApproversIds { get; set; }

        /// <summary>
        /// 合并请求描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 里程碑id
        /// </summary>
        [JsonProperty("milestone_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MilestoneId { get; set; }

        /// <summary>
        /// 标签名称，使用逗号分隔
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Object Labels { get; set; }

        /// <summary>
        /// 合入后自动删除源分支
        /// </summary>
        [JsonProperty("force_remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRemoveSourceBranch { get; set; }

        /// <summary>
        /// 压缩合并
        /// </summary>
        [JsonProperty("squash", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Squash { get; set; }

        /// <summary>
        /// 压缩合并信息
        /// </summary>
        [JsonProperty("squash_commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string SquashCommitMessage { get; set; }

        /// <summary>
        /// e2e单号
        /// </summary>
        [JsonProperty("work_item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WorkItemIds { get; set; }

        /// <summary>
        /// 使用临时分支创建合并请求
        /// </summary>
        [JsonProperty("is_use_temp_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUseTempBranch { get; set; }

        /// <summary>
        /// 只有合并人允许合入
        /// </summary>
        [JsonProperty("only_assignee_can_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyAssigneeCanMerge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostMergeRequestParamsDtoForOpenApi {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  targetRepositoryId: ").Append(TargetRepositoryId).Append("\n");
            sb.Append("  reviewerIds: ").Append(ReviewerIds).Append("\n");
            sb.Append("  assigneeIds: ").Append(AssigneeIds).Append("\n");
            sb.Append("  approvalReviewerIds: ").Append(ApprovalReviewerIds).Append("\n");
            sb.Append("  approvalApproversIds: ").Append(ApprovalApproversIds).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  milestoneId: ").Append(MilestoneId).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  forceRemoveSourceBranch: ").Append(ForceRemoveSourceBranch).Append("\n");
            sb.Append("  squash: ").Append(Squash).Append("\n");
            sb.Append("  squashCommitMessage: ").Append(SquashCommitMessage).Append("\n");
            sb.Append("  workItemIds: ").Append(WorkItemIds).Append("\n");
            sb.Append("  isUseTempBranch: ").Append(IsUseTempBranch).Append("\n");
            sb.Append("  onlyAssigneeCanMerge: ").Append(OnlyAssigneeCanMerge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostMergeRequestParamsDtoForOpenApi);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostMergeRequestParamsDtoForOpenApi input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.TargetRepositoryId != input.TargetRepositoryId || (this.TargetRepositoryId != null && !this.TargetRepositoryId.Equals(input.TargetRepositoryId))) return false;
            if (this.ReviewerIds != input.ReviewerIds || (this.ReviewerIds != null && !this.ReviewerIds.Equals(input.ReviewerIds))) return false;
            if (this.AssigneeIds != input.AssigneeIds || (this.AssigneeIds != null && !this.AssigneeIds.Equals(input.AssigneeIds))) return false;
            if (this.ApprovalReviewerIds != input.ApprovalReviewerIds || (this.ApprovalReviewerIds != null && !this.ApprovalReviewerIds.Equals(input.ApprovalReviewerIds))) return false;
            if (this.ApprovalApproversIds != input.ApprovalApproversIds || (this.ApprovalApproversIds != null && !this.ApprovalApproversIds.Equals(input.ApprovalApproversIds))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.MilestoneId != input.MilestoneId || (this.MilestoneId != null && !this.MilestoneId.Equals(input.MilestoneId))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && !this.Labels.Equals(input.Labels))) return false;
            if (this.ForceRemoveSourceBranch != input.ForceRemoveSourceBranch || (this.ForceRemoveSourceBranch != null && !this.ForceRemoveSourceBranch.Equals(input.ForceRemoveSourceBranch))) return false;
            if (this.Squash != input.Squash || (this.Squash != null && !this.Squash.Equals(input.Squash))) return false;
            if (this.SquashCommitMessage != input.SquashCommitMessage || (this.SquashCommitMessage != null && !this.SquashCommitMessage.Equals(input.SquashCommitMessage))) return false;
            if (this.WorkItemIds != input.WorkItemIds || (this.WorkItemIds != null && input.WorkItemIds != null && !this.WorkItemIds.SequenceEqual(input.WorkItemIds))) return false;
            if (this.IsUseTempBranch != input.IsUseTempBranch || (this.IsUseTempBranch != null && !this.IsUseTempBranch.Equals(input.IsUseTempBranch))) return false;
            if (this.OnlyAssigneeCanMerge != input.OnlyAssigneeCanMerge || (this.OnlyAssigneeCanMerge != null && !this.OnlyAssigneeCanMerge.Equals(input.OnlyAssigneeCanMerge))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.TargetRepositoryId != null) hashCode = hashCode * 59 + this.TargetRepositoryId.GetHashCode();
                if (this.ReviewerIds != null) hashCode = hashCode * 59 + this.ReviewerIds.GetHashCode();
                if (this.AssigneeIds != null) hashCode = hashCode * 59 + this.AssigneeIds.GetHashCode();
                if (this.ApprovalReviewerIds != null) hashCode = hashCode * 59 + this.ApprovalReviewerIds.GetHashCode();
                if (this.ApprovalApproversIds != null) hashCode = hashCode * 59 + this.ApprovalApproversIds.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MilestoneId != null) hashCode = hashCode * 59 + this.MilestoneId.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.ForceRemoveSourceBranch != null) hashCode = hashCode * 59 + this.ForceRemoveSourceBranch.GetHashCode();
                if (this.Squash != null) hashCode = hashCode * 59 + this.Squash.GetHashCode();
                if (this.SquashCommitMessage != null) hashCode = hashCode * 59 + this.SquashCommitMessage.GetHashCode();
                if (this.WorkItemIds != null) hashCode = hashCode * 59 + this.WorkItemIds.GetHashCode();
                if (this.IsUseTempBranch != null) hashCode = hashCode * 59 + this.IsUseTempBranch.GetHashCode();
                if (this.OnlyAssigneeCanMerge != null) hashCode = hashCode * 59 + this.OnlyAssigneeCanMerge.GetHashCode();
                return hashCode;
            }
        }
    }
}
