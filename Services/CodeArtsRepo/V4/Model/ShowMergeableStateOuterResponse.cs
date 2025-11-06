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
    /// Response Object
    /// </summary>
    public class ShowMergeableStateOuterResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 合并请求id。
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的可合入状态。 **约束限制：** - true，可合入。 - false，不可合入。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public bool? State { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求冲突门禁是否通过。 **约束限制：** - true，不存在冲突。 - false，存在冲突。
        /// </summary>
        [JsonProperty("conflict_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConflictPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求是否需要变基。 **约束限制：** - true，不需变基。 - false，需要变基。
        /// </summary>
        [JsonProperty("non_ff_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonFfPassed { get; set; }

        /// <summary>
        /// **参数解释：** 对当前用户是否有合入当前合并请求的权限判断。 **约束限制：** - true，有权限合入。 - false，无权限合入。
        /// </summary>
        [JsonProperty("merged_by_user_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergedByUserPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求WIP门禁是否通过。 **约束限制：** - true，非WIP状态。 - false，WIP状态。
        /// </summary>
        [JsonProperty("work_in_progress_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WorkInProgressPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求检视意见门禁是否通过。 **约束限制：** - true，检视意见门禁通过。 - false，检视意见门禁不通过。
        /// </summary>
        [JsonProperty("resolve_discussion_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResolveDiscussionPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求流水线门禁是否通过。 **约束限制：** - true，合并请求流水线门禁通过。 - false，合并请求流水线门禁不通过。
        /// </summary>
        [JsonProperty("ci_state_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CiStatePassed { get; set; }

        /// <summary>
        /// **参数解释：** 对当前用户是否有合入自己创建的合并请求的判断。 **约束限制：** - true，非自己创建的mr可以合入。 - false，自己创建的mr不能合入。
        /// </summary>
        [JsonProperty("merge_by_self_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergeBySelfPassed { get; set; }

        /// <summary>
        /// **参数解释：** 当前用户是否可以强制合入当前合并请求。 **约束限制：** - true，可以强制合入。 - false，不能强制合入。
        /// </summary>
        [JsonProperty("can_force_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanForceMerge { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求评分门禁是否通过。 **约束限制：** - true，评分门禁通过。 - false，评分门禁不通过。
        /// </summary>
        [JsonProperty("vote_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VotePassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求必须与CodeArts Req关联门禁是否通过。 **约束限制：** - true，合并请求必须与CodeArts Req关联门禁通过。 - false，合并请求必须与CodeArts Req关联门禁不通过。
        /// </summary>
        [JsonProperty("e2e_check_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? E2eCheckPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求所有E2E单号校验必须通过门禁是否通过。 **约束限制：** - true，合并请求所有E2E单号校验必须通过门禁通过。 - false，合并请求所有E2E单号校验必须通过门禁不通过。
        /// </summary>
        [JsonProperty("all_issues_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllIssuesPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求只能关联一个单号门禁是否通过。 **约束限制：** - true，合并请求只能关联一个单号门禁通过。 - false，合并请求只能关联一个单号门禁不通过。
        /// </summary>
        [JsonProperty("only_one_issue_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyOneIssuePassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求检视门禁是否通过。 **约束限制：** - true，合并请求检视门禁通过。 - false，合并请求检视门禁不通过。
        /// </summary>
        [JsonProperty("approval_reviewers_required_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApprovalReviewersRequiredPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求审核门禁是否通过。 **约束限制：** - true，合并请求审核门禁通过。 - false，合并请求审核门禁不通过。
        /// </summary>
        [JsonProperty("approval_approvers_required_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApprovalApproversRequiredPassed { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求星级评价门禁是否通过。 **约束限制：** - true，合并请求星级评价门禁通过。 - false，合并请求星级评价门禁不通过。
        /// </summary>
        [JsonProperty("evaluation_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EvaluationPassed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMergeableStateOuterResponse {\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  conflictPassed: ").Append(ConflictPassed).Append("\n");
            sb.Append("  nonFfPassed: ").Append(NonFfPassed).Append("\n");
            sb.Append("  mergedByUserPassed: ").Append(MergedByUserPassed).Append("\n");
            sb.Append("  workInProgressPassed: ").Append(WorkInProgressPassed).Append("\n");
            sb.Append("  resolveDiscussionPassed: ").Append(ResolveDiscussionPassed).Append("\n");
            sb.Append("  ciStatePassed: ").Append(CiStatePassed).Append("\n");
            sb.Append("  mergeBySelfPassed: ").Append(MergeBySelfPassed).Append("\n");
            sb.Append("  canForceMerge: ").Append(CanForceMerge).Append("\n");
            sb.Append("  votePassed: ").Append(VotePassed).Append("\n");
            sb.Append("  e2eCheckPassed: ").Append(E2eCheckPassed).Append("\n");
            sb.Append("  allIssuesPassed: ").Append(AllIssuesPassed).Append("\n");
            sb.Append("  onlyOneIssuePassed: ").Append(OnlyOneIssuePassed).Append("\n");
            sb.Append("  approvalReviewersRequiredPassed: ").Append(ApprovalReviewersRequiredPassed).Append("\n");
            sb.Append("  approvalApproversRequiredPassed: ").Append(ApprovalApproversRequiredPassed).Append("\n");
            sb.Append("  evaluationPassed: ").Append(EvaluationPassed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMergeableStateOuterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMergeableStateOuterResponse input)
        {
            if (input == null) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.ConflictPassed != input.ConflictPassed || (this.ConflictPassed != null && !this.ConflictPassed.Equals(input.ConflictPassed))) return false;
            if (this.NonFfPassed != input.NonFfPassed || (this.NonFfPassed != null && !this.NonFfPassed.Equals(input.NonFfPassed))) return false;
            if (this.MergedByUserPassed != input.MergedByUserPassed || (this.MergedByUserPassed != null && !this.MergedByUserPassed.Equals(input.MergedByUserPassed))) return false;
            if (this.WorkInProgressPassed != input.WorkInProgressPassed || (this.WorkInProgressPassed != null && !this.WorkInProgressPassed.Equals(input.WorkInProgressPassed))) return false;
            if (this.ResolveDiscussionPassed != input.ResolveDiscussionPassed || (this.ResolveDiscussionPassed != null && !this.ResolveDiscussionPassed.Equals(input.ResolveDiscussionPassed))) return false;
            if (this.CiStatePassed != input.CiStatePassed || (this.CiStatePassed != null && !this.CiStatePassed.Equals(input.CiStatePassed))) return false;
            if (this.MergeBySelfPassed != input.MergeBySelfPassed || (this.MergeBySelfPassed != null && !this.MergeBySelfPassed.Equals(input.MergeBySelfPassed))) return false;
            if (this.CanForceMerge != input.CanForceMerge || (this.CanForceMerge != null && !this.CanForceMerge.Equals(input.CanForceMerge))) return false;
            if (this.VotePassed != input.VotePassed || (this.VotePassed != null && !this.VotePassed.Equals(input.VotePassed))) return false;
            if (this.E2eCheckPassed != input.E2eCheckPassed || (this.E2eCheckPassed != null && !this.E2eCheckPassed.Equals(input.E2eCheckPassed))) return false;
            if (this.AllIssuesPassed != input.AllIssuesPassed || (this.AllIssuesPassed != null && !this.AllIssuesPassed.Equals(input.AllIssuesPassed))) return false;
            if (this.OnlyOneIssuePassed != input.OnlyOneIssuePassed || (this.OnlyOneIssuePassed != null && !this.OnlyOneIssuePassed.Equals(input.OnlyOneIssuePassed))) return false;
            if (this.ApprovalReviewersRequiredPassed != input.ApprovalReviewersRequiredPassed || (this.ApprovalReviewersRequiredPassed != null && !this.ApprovalReviewersRequiredPassed.Equals(input.ApprovalReviewersRequiredPassed))) return false;
            if (this.ApprovalApproversRequiredPassed != input.ApprovalApproversRequiredPassed || (this.ApprovalApproversRequiredPassed != null && !this.ApprovalApproversRequiredPassed.Equals(input.ApprovalApproversRequiredPassed))) return false;
            if (this.EvaluationPassed != input.EvaluationPassed || (this.EvaluationPassed != null && !this.EvaluationPassed.Equals(input.EvaluationPassed))) return false;

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
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ConflictPassed != null) hashCode = hashCode * 59 + this.ConflictPassed.GetHashCode();
                if (this.NonFfPassed != null) hashCode = hashCode * 59 + this.NonFfPassed.GetHashCode();
                if (this.MergedByUserPassed != null) hashCode = hashCode * 59 + this.MergedByUserPassed.GetHashCode();
                if (this.WorkInProgressPassed != null) hashCode = hashCode * 59 + this.WorkInProgressPassed.GetHashCode();
                if (this.ResolveDiscussionPassed != null) hashCode = hashCode * 59 + this.ResolveDiscussionPassed.GetHashCode();
                if (this.CiStatePassed != null) hashCode = hashCode * 59 + this.CiStatePassed.GetHashCode();
                if (this.MergeBySelfPassed != null) hashCode = hashCode * 59 + this.MergeBySelfPassed.GetHashCode();
                if (this.CanForceMerge != null) hashCode = hashCode * 59 + this.CanForceMerge.GetHashCode();
                if (this.VotePassed != null) hashCode = hashCode * 59 + this.VotePassed.GetHashCode();
                if (this.E2eCheckPassed != null) hashCode = hashCode * 59 + this.E2eCheckPassed.GetHashCode();
                if (this.AllIssuesPassed != null) hashCode = hashCode * 59 + this.AllIssuesPassed.GetHashCode();
                if (this.OnlyOneIssuePassed != null) hashCode = hashCode * 59 + this.OnlyOneIssuePassed.GetHashCode();
                if (this.ApprovalReviewersRequiredPassed != null) hashCode = hashCode * 59 + this.ApprovalReviewersRequiredPassed.GetHashCode();
                if (this.ApprovalApproversRequiredPassed != null) hashCode = hashCode * 59 + this.ApprovalApproversRequiredPassed.GetHashCode();
                if (this.EvaluationPassed != null) hashCode = hashCode * 59 + this.EvaluationPassed.GetHashCode();
                return hashCode;
            }
        }
    }
}
