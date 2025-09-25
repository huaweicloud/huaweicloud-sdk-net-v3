using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 审核策配置
    /// </summary>
    public class CreateMergeRequestApproverSettingDto 
    {

        /// <summary>
        /// 配置分支，可使用*作为通配符使用，如：dev* 指以dev开头的所有分支
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// 为false时，“最小检视人数”，“最小审核人数”，“重新推送代码时重置审核人”，“重新推送代码时重置检视人”，“仅能从以下审核人/检视人中追加审核人/检视人”置为默认
        /// </summary>
        [JsonProperty("is_use_approval", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUseApproval { get; set; }

        /// <summary>
        /// 最小审核人数
        /// </summary>
        [JsonProperty("approval_required_approvers", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalRequiredApprovers { get; set; }

        /// <summary>
        /// 最小检视人数
        /// </summary>
        [JsonProperty("approval_required_reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalRequiredReviewers { get; set; }

        /// <summary>
        /// 推送时是否重置审核门禁状态
        /// </summary>
        [JsonProperty("reset_approvals_on_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetApprovalsOnPush { get; set; }

        /// <summary>
        /// 推送时是否重置检视门禁状态
        /// </summary>
        [JsonProperty("reset_reviewers_on_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetReviewersOnPush { get; set; }

        /// <summary>
        /// 是否开启仅能从以下审核/检视人中追加审核人/检视人
        /// </summary>
        [JsonProperty("approvers_from_project", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApproversFromProject { get; set; }

        /// <summary>
        /// 追加检视人人用户id列表
        /// </summary>
        [JsonProperty("append_reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AppendReviewerIds { get; set; }

        /// <summary>
        /// 追加审核人用户id列表
        /// </summary>
        [JsonProperty("append_approver_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AppendApproverIds { get; set; }

        /// <summary>
        /// 是否开启流水线门禁
        /// </summary>
        [JsonProperty("only_merge_when_pipeline_pass", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyMergeWhenPipelinePass { get; set; }

        /// <summary>
        /// 合并人用户id列表
        /// </summary>
        [JsonProperty("assignee_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AssigneeIds { get; set; }

        /// <summary>
        /// 审核人用户id列表
        /// </summary>
        [JsonProperty("approver_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ApproverIds { get; set; }

        /// <summary>
        /// 检视人用户id列表
        /// </summary>
        [JsonProperty("reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ReviewerIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMergeRequestApproverSettingDto {\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  isUseApproval: ").Append(IsUseApproval).Append("\n");
            sb.Append("  approvalRequiredApprovers: ").Append(ApprovalRequiredApprovers).Append("\n");
            sb.Append("  approvalRequiredReviewers: ").Append(ApprovalRequiredReviewers).Append("\n");
            sb.Append("  resetApprovalsOnPush: ").Append(ResetApprovalsOnPush).Append("\n");
            sb.Append("  resetReviewersOnPush: ").Append(ResetReviewersOnPush).Append("\n");
            sb.Append("  approversFromProject: ").Append(ApproversFromProject).Append("\n");
            sb.Append("  appendReviewerIds: ").Append(AppendReviewerIds).Append("\n");
            sb.Append("  appendApproverIds: ").Append(AppendApproverIds).Append("\n");
            sb.Append("  onlyMergeWhenPipelinePass: ").Append(OnlyMergeWhenPipelinePass).Append("\n");
            sb.Append("  assigneeIds: ").Append(AssigneeIds).Append("\n");
            sb.Append("  approverIds: ").Append(ApproverIds).Append("\n");
            sb.Append("  reviewerIds: ").Append(ReviewerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMergeRequestApproverSettingDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMergeRequestApproverSettingDto input)
        {
            if (input == null) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.IsUseApproval != input.IsUseApproval || (this.IsUseApproval != null && !this.IsUseApproval.Equals(input.IsUseApproval))) return false;
            if (this.ApprovalRequiredApprovers != input.ApprovalRequiredApprovers || (this.ApprovalRequiredApprovers != null && !this.ApprovalRequiredApprovers.Equals(input.ApprovalRequiredApprovers))) return false;
            if (this.ApprovalRequiredReviewers != input.ApprovalRequiredReviewers || (this.ApprovalRequiredReviewers != null && !this.ApprovalRequiredReviewers.Equals(input.ApprovalRequiredReviewers))) return false;
            if (this.ResetApprovalsOnPush != input.ResetApprovalsOnPush || (this.ResetApprovalsOnPush != null && !this.ResetApprovalsOnPush.Equals(input.ResetApprovalsOnPush))) return false;
            if (this.ResetReviewersOnPush != input.ResetReviewersOnPush || (this.ResetReviewersOnPush != null && !this.ResetReviewersOnPush.Equals(input.ResetReviewersOnPush))) return false;
            if (this.ApproversFromProject != input.ApproversFromProject || (this.ApproversFromProject != null && !this.ApproversFromProject.Equals(input.ApproversFromProject))) return false;
            if (this.AppendReviewerIds != input.AppendReviewerIds || (this.AppendReviewerIds != null && input.AppendReviewerIds != null && !this.AppendReviewerIds.SequenceEqual(input.AppendReviewerIds))) return false;
            if (this.AppendApproverIds != input.AppendApproverIds || (this.AppendApproverIds != null && input.AppendApproverIds != null && !this.AppendApproverIds.SequenceEqual(input.AppendApproverIds))) return false;
            if (this.OnlyMergeWhenPipelinePass != input.OnlyMergeWhenPipelinePass || (this.OnlyMergeWhenPipelinePass != null && !this.OnlyMergeWhenPipelinePass.Equals(input.OnlyMergeWhenPipelinePass))) return false;
            if (this.AssigneeIds != input.AssigneeIds || (this.AssigneeIds != null && input.AssigneeIds != null && !this.AssigneeIds.SequenceEqual(input.AssigneeIds))) return false;
            if (this.ApproverIds != input.ApproverIds || (this.ApproverIds != null && input.ApproverIds != null && !this.ApproverIds.SequenceEqual(input.ApproverIds))) return false;
            if (this.ReviewerIds != input.ReviewerIds || (this.ReviewerIds != null && input.ReviewerIds != null && !this.ReviewerIds.SequenceEqual(input.ReviewerIds))) return false;

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
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.IsUseApproval != null) hashCode = hashCode * 59 + this.IsUseApproval.GetHashCode();
                if (this.ApprovalRequiredApprovers != null) hashCode = hashCode * 59 + this.ApprovalRequiredApprovers.GetHashCode();
                if (this.ApprovalRequiredReviewers != null) hashCode = hashCode * 59 + this.ApprovalRequiredReviewers.GetHashCode();
                if (this.ResetApprovalsOnPush != null) hashCode = hashCode * 59 + this.ResetApprovalsOnPush.GetHashCode();
                if (this.ResetReviewersOnPush != null) hashCode = hashCode * 59 + this.ResetReviewersOnPush.GetHashCode();
                if (this.ApproversFromProject != null) hashCode = hashCode * 59 + this.ApproversFromProject.GetHashCode();
                if (this.AppendReviewerIds != null) hashCode = hashCode * 59 + this.AppendReviewerIds.GetHashCode();
                if (this.AppendApproverIds != null) hashCode = hashCode * 59 + this.AppendApproverIds.GetHashCode();
                if (this.OnlyMergeWhenPipelinePass != null) hashCode = hashCode * 59 + this.OnlyMergeWhenPipelinePass.GetHashCode();
                if (this.AssigneeIds != null) hashCode = hashCode * 59 + this.AssigneeIds.GetHashCode();
                if (this.ApproverIds != null) hashCode = hashCode * 59 + this.ApproverIds.GetHashCode();
                if (this.ReviewerIds != null) hashCode = hashCode * 59 + this.ReviewerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
