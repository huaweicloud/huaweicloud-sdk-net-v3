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
    /// Response Object
    /// </summary>
    public class CreateGroupMergeRequestApproverSettingResponse : SdkResponse
    {
        /// <summary>
        /// 设置类型，当前仅开放branch类型
        /// </summary>
        /// <value>设置类型，当前仅开放branch类型</value>
        [JsonConverter(typeof(EnumClassConverter<TargetTypeEnum>))]
        public class TargetTypeEnum
        {
            /// <summary>
            /// Enum BRANCH for value: branch
            /// </summary>
            public static readonly TargetTypeEnum BRANCH = new TargetTypeEnum("branch");

            /// <summary>
            /// Enum FILE for value: file
            /// </summary>
            public static readonly TargetTypeEnum FILE = new TargetTypeEnum("file");

            /// <summary>
            /// Enum BINARY for value: binary
            /// </summary>
            public static readonly TargetTypeEnum BINARY = new TargetTypeEnum("binary");

            private static readonly Dictionary<string, TargetTypeEnum> StaticFields =
            new Dictionary<string, TargetTypeEnum>()
            {
                { "branch", BRANCH },
                { "file", FILE },
                { "binary", BINARY },
            };

            private string _value;

            public TargetTypeEnum()
            {

            }

            public TargetTypeEnum(string value)
            {
                _value = value;
            }

            public static TargetTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TargetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TargetTypeEnum a, TargetTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TargetTypeEnum a, TargetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：**  设置主键id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：**  分支，可使用*作为通配符使用，如：dev* 指以dev开头的所有分支
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// 设置类型，当前仅开放branch类型
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetTypeEnum TargetType { get; set; }
        /// <summary>
        /// 是否为审核模式，审核模式：true 评分模式：false
        /// </summary>
        [JsonProperty("is_use_approval", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUseApproval { get; set; }

        /// <summary>
        /// 最小检视人数
        /// </summary>
        [JsonProperty("approval_required_reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalRequiredReviewers { get; set; }

        /// <summary>
        /// 最小审核人数
        /// </summary>
        [JsonProperty("approval_required_approvers", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalRequiredApprovers { get; set; }

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
        /// 追加检视人id列表
        /// </summary>
        [JsonProperty("append_reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AppendReviewerIds { get; set; }

        /// <summary>
        /// 追加检视人实体列表
        /// </summary>
        [JsonProperty("append_reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> AppendReviewers { get; set; }

        /// <summary>
        /// 追加审核人id列表
        /// </summary>
        [JsonProperty("append_approver_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AppendApproverIds { get; set; }

        /// <summary>
        /// 追加审核人实体列表
        /// </summary>
        [JsonProperty("append_approvers", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> AppendApprovers { get; set; }

        /// <summary>
        /// 是否开启流水线门禁
        /// </summary>
        [JsonProperty("only_merge_when_pipeline_pass", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyMergeWhenPipelinePass { get; set; }

        /// <summary>
        /// 合并人id列表
        /// </summary>
        [JsonProperty("assignee_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AssigneeIds { get; set; }

        /// <summary>
        /// 合并人实体列表
        /// </summary>
        [JsonProperty("assignees", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> Assignees { get; set; }

        /// <summary>
        /// 审核人id列表
        /// </summary>
        [JsonProperty("approver_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ApproverIds { get; set; }

        /// <summary>
        /// 审核人实体列表
        /// </summary>
        [JsonProperty("approvers", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> Approvers { get; set; }

        /// <summary>
        /// 检视人id列表
        /// </summary>
        [JsonProperty("reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ReviewerIds { get; set; }

        /// <summary>
        /// 检视人实体列表
        /// </summary>
        [JsonProperty("reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> Reviewers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGroupMergeRequestApproverSettingResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  isUseApproval: ").Append(IsUseApproval).Append("\n");
            sb.Append("  approvalRequiredReviewers: ").Append(ApprovalRequiredReviewers).Append("\n");
            sb.Append("  approvalRequiredApprovers: ").Append(ApprovalRequiredApprovers).Append("\n");
            sb.Append("  resetApprovalsOnPush: ").Append(ResetApprovalsOnPush).Append("\n");
            sb.Append("  resetReviewersOnPush: ").Append(ResetReviewersOnPush).Append("\n");
            sb.Append("  approversFromProject: ").Append(ApproversFromProject).Append("\n");
            sb.Append("  appendReviewerIds: ").Append(AppendReviewerIds).Append("\n");
            sb.Append("  appendReviewers: ").Append(AppendReviewers).Append("\n");
            sb.Append("  appendApproverIds: ").Append(AppendApproverIds).Append("\n");
            sb.Append("  appendApprovers: ").Append(AppendApprovers).Append("\n");
            sb.Append("  onlyMergeWhenPipelinePass: ").Append(OnlyMergeWhenPipelinePass).Append("\n");
            sb.Append("  assigneeIds: ").Append(AssigneeIds).Append("\n");
            sb.Append("  assignees: ").Append(Assignees).Append("\n");
            sb.Append("  approverIds: ").Append(ApproverIds).Append("\n");
            sb.Append("  approvers: ").Append(Approvers).Append("\n");
            sb.Append("  reviewerIds: ").Append(ReviewerIds).Append("\n");
            sb.Append("  reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGroupMergeRequestApproverSettingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGroupMergeRequestApproverSettingResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.TargetType != input.TargetType) return false;
            if (this.IsUseApproval != input.IsUseApproval || (this.IsUseApproval != null && !this.IsUseApproval.Equals(input.IsUseApproval))) return false;
            if (this.ApprovalRequiredReviewers != input.ApprovalRequiredReviewers || (this.ApprovalRequiredReviewers != null && !this.ApprovalRequiredReviewers.Equals(input.ApprovalRequiredReviewers))) return false;
            if (this.ApprovalRequiredApprovers != input.ApprovalRequiredApprovers || (this.ApprovalRequiredApprovers != null && !this.ApprovalRequiredApprovers.Equals(input.ApprovalRequiredApprovers))) return false;
            if (this.ResetApprovalsOnPush != input.ResetApprovalsOnPush || (this.ResetApprovalsOnPush != null && !this.ResetApprovalsOnPush.Equals(input.ResetApprovalsOnPush))) return false;
            if (this.ResetReviewersOnPush != input.ResetReviewersOnPush || (this.ResetReviewersOnPush != null && !this.ResetReviewersOnPush.Equals(input.ResetReviewersOnPush))) return false;
            if (this.ApproversFromProject != input.ApproversFromProject || (this.ApproversFromProject != null && !this.ApproversFromProject.Equals(input.ApproversFromProject))) return false;
            if (this.AppendReviewerIds != input.AppendReviewerIds || (this.AppendReviewerIds != null && input.AppendReviewerIds != null && !this.AppendReviewerIds.SequenceEqual(input.AppendReviewerIds))) return false;
            if (this.AppendReviewers != input.AppendReviewers || (this.AppendReviewers != null && input.AppendReviewers != null && !this.AppendReviewers.SequenceEqual(input.AppendReviewers))) return false;
            if (this.AppendApproverIds != input.AppendApproverIds || (this.AppendApproverIds != null && input.AppendApproverIds != null && !this.AppendApproverIds.SequenceEqual(input.AppendApproverIds))) return false;
            if (this.AppendApprovers != input.AppendApprovers || (this.AppendApprovers != null && input.AppendApprovers != null && !this.AppendApprovers.SequenceEqual(input.AppendApprovers))) return false;
            if (this.OnlyMergeWhenPipelinePass != input.OnlyMergeWhenPipelinePass || (this.OnlyMergeWhenPipelinePass != null && !this.OnlyMergeWhenPipelinePass.Equals(input.OnlyMergeWhenPipelinePass))) return false;
            if (this.AssigneeIds != input.AssigneeIds || (this.AssigneeIds != null && input.AssigneeIds != null && !this.AssigneeIds.SequenceEqual(input.AssigneeIds))) return false;
            if (this.Assignees != input.Assignees || (this.Assignees != null && input.Assignees != null && !this.Assignees.SequenceEqual(input.Assignees))) return false;
            if (this.ApproverIds != input.ApproverIds || (this.ApproverIds != null && input.ApproverIds != null && !this.ApproverIds.SequenceEqual(input.ApproverIds))) return false;
            if (this.Approvers != input.Approvers || (this.Approvers != null && input.Approvers != null && !this.Approvers.SequenceEqual(input.Approvers))) return false;
            if (this.ReviewerIds != input.ReviewerIds || (this.ReviewerIds != null && input.ReviewerIds != null && !this.ReviewerIds.SequenceEqual(input.ReviewerIds))) return false;
            if (this.Reviewers != input.Reviewers || (this.Reviewers != null && input.Reviewers != null && !this.Reviewers.SequenceEqual(input.Reviewers))) return false;

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
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.IsUseApproval != null) hashCode = hashCode * 59 + this.IsUseApproval.GetHashCode();
                if (this.ApprovalRequiredReviewers != null) hashCode = hashCode * 59 + this.ApprovalRequiredReviewers.GetHashCode();
                if (this.ApprovalRequiredApprovers != null) hashCode = hashCode * 59 + this.ApprovalRequiredApprovers.GetHashCode();
                if (this.ResetApprovalsOnPush != null) hashCode = hashCode * 59 + this.ResetApprovalsOnPush.GetHashCode();
                if (this.ResetReviewersOnPush != null) hashCode = hashCode * 59 + this.ResetReviewersOnPush.GetHashCode();
                if (this.ApproversFromProject != null) hashCode = hashCode * 59 + this.ApproversFromProject.GetHashCode();
                if (this.AppendReviewerIds != null) hashCode = hashCode * 59 + this.AppendReviewerIds.GetHashCode();
                if (this.AppendReviewers != null) hashCode = hashCode * 59 + this.AppendReviewers.GetHashCode();
                if (this.AppendApproverIds != null) hashCode = hashCode * 59 + this.AppendApproverIds.GetHashCode();
                if (this.AppendApprovers != null) hashCode = hashCode * 59 + this.AppendApprovers.GetHashCode();
                if (this.OnlyMergeWhenPipelinePass != null) hashCode = hashCode * 59 + this.OnlyMergeWhenPipelinePass.GetHashCode();
                if (this.AssigneeIds != null) hashCode = hashCode * 59 + this.AssigneeIds.GetHashCode();
                if (this.Assignees != null) hashCode = hashCode * 59 + this.Assignees.GetHashCode();
                if (this.ApproverIds != null) hashCode = hashCode * 59 + this.ApproverIds.GetHashCode();
                if (this.Approvers != null) hashCode = hashCode * 59 + this.Approvers.GetHashCode();
                if (this.ReviewerIds != null) hashCode = hashCode * 59 + this.ReviewerIds.GetHashCode();
                if (this.Reviewers != null) hashCode = hashCode * 59 + this.Reviewers.GetHashCode();
                return hashCode;
            }
        }
    }
}
