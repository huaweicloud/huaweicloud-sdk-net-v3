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
    public class MergeMergeRequestResponse : SdkResponse
    {
        /// <summary>
        /// 合并请求模式
        /// </summary>
        /// <value>合并请求模式</value>
        [JsonConverter(typeof(EnumClassConverter<ReviewModeEnum>))]
        public class ReviewModeEnum
        {
            /// <summary>
            /// Enum VOTE for value: vote
            /// </summary>
            public static readonly ReviewModeEnum VOTE = new ReviewModeEnum("vote");

            /// <summary>
            /// Enum APPROVAL for value: approval
            /// </summary>
            public static readonly ReviewModeEnum APPROVAL = new ReviewModeEnum("approval");

            private static readonly Dictionary<string, ReviewModeEnum> StaticFields =
            new Dictionary<string, ReviewModeEnum>()
            {
                { "vote", VOTE },
                { "approval", APPROVAL },
            };

            private string _value;

            public ReviewModeEnum()
            {

            }

            public ReviewModeEnum(string value)
            {
                _value = value;
            }

            public static ReviewModeEnum FromValue(string value)
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

                if (this.Equals(obj as ReviewModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReviewModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReviewModeEnum a, ReviewModeEnum b)
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

            public static bool operator !=(ReviewModeEnum a, ReviewModeEnum b)
            {
                return !(a == b);
            }
        }


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
        /// 目标仓库id
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

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
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

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
        /// 源分支是否为保护分支
        /// </summary>
        [JsonProperty("is_source_branch_protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSourceBranchProtected { get; set; }

        /// <summary>
        /// 源分支
        /// </summary>
        [JsonProperty("devcloud_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string DevcloudSourceBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicExternalDto Author { get; set; }

        /// <summary>
        /// 源仓库id
        /// </summary>
        [JsonProperty("source_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceRepositoryId { get; set; }

        /// <summary>
        /// 目标仓库id
        /// </summary>
        [JsonProperty("target_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetRepositoryId { get; set; }

        /// <summary>
        /// 源项目id
        /// </summary>
        [JsonProperty("source_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceProjectId { get; set; }

        /// <summary>
        /// 目标项目id
        /// </summary>
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Labels { get; set; }

        /// <summary>
        /// WIP状态
        /// </summary>
        [JsonProperty("work_in_progress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WorkInProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("milestone", NullValueHandling = NullValueHandling.Ignore)]
        public MilestoneBasicDto Milestone { get; set; }

        /// <summary>
        /// 流水线成功后自动合入
        /// </summary>
        [JsonProperty("merge_when_build_succeeds", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergeWhenBuildSucceeds { get; set; }

        /// <summary>
        /// 可合并状态
        /// </summary>
        [JsonProperty("merge_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeStatus { get; set; }

        /// <summary>
        /// 当前合并请求最新commit
        /// </summary>
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        /// <summary>
        /// 合入commit节点
        /// </summary>
        [JsonProperty("merge_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeCommitSha { get; set; }

        /// <summary>
        /// 订阅
        /// </summary>
        [JsonProperty("subscribed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("merged_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicExternalDto MergedBy { get; set; }

        /// <summary>
        /// 合并时间
        /// </summary>
        [JsonProperty("merged_at", NullValueHandling = NullValueHandling.Ignore)]
        public string MergedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("closed_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicExternalDto ClosedBy { get; set; }

        /// <summary>
        /// 关闭时间
        /// </summary>
        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedAt { get; set; }

        /// <summary>
        /// 检视意见数量
        /// </summary>
        [JsonProperty("user_notes_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserNotesCount { get; set; }

        /// <summary>
        /// 合入后删除源分支
        /// </summary>
        [JsonProperty("force_remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRemoveSourceBranch { get; set; }

        /// <summary>
        /// 主页url
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("merge_request_diff", NullValueHandling = NullValueHandling.Ignore)]
        public MergeRequestDiffExternalDto MergeRequestDiff { get; set; }

        /// <summary>
        /// 评审人数量
        /// </summary>
        [JsonProperty("merge_request_reviewers_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestReviewersCount { get; set; }

        /// <summary>
        /// 打分
        /// </summary>
        [JsonProperty("merge_request_review_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestReviewCount { get; set; }

        /// <summary>
        /// 评审人列表
        /// </summary>
        [JsonProperty("merge_request_reviewer_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestReviewerExternalDto> MergeRequestReviewerList { get; set; }

        /// <summary>
        /// 合并人列表
        /// </summary>
        [JsonProperty("merge_request_assignee_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicExternalDto> MergeRequestAssigneeList { get; set; }

        /// <summary>
        /// 检视意见
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Notes { get; set; }

        /// <summary>
        /// 代码检查状态
        /// </summary>
        [JsonProperty("codecheck_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodecheckState { get; set; }

        /// <summary>
        /// 代码检查问题数
        /// </summary>
        [JsonProperty("codecheck_defect_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodecheckDefectCount { get; set; }

        /// <summary>
        /// 合并请求关联单数量
        /// </summary>
        [JsonProperty("merge_request_related_work_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestRelatedWorkItemDto> MergeRequestRelatedWorkItems { get; set; }

        /// <summary>
        /// 源分支落后commit数
        /// </summary>
        [JsonProperty("diverged_commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DivergedCommitsCount { get; set; }

        /// <summary>
        /// 送审结果
        /// </summary>
        [JsonProperty("moderation_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModerationResult { get; set; }

        /// <summary>
        /// 送审时间时间戳
        /// </summary>
        [JsonProperty("moderation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModerationTime { get; set; }

        /// <summary>
        /// 送审状态码
        /// </summary>
        [JsonProperty("moderation_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModerationStatus { get; set; }

        /// <summary>
        /// 是否使用临时分支
        /// </summary>
        [JsonProperty("is_use_temp_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUseTempBranch { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        [JsonProperty("approval_merge_request_approvers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApprovalUserDto> ApprovalMergeRequestApprovers { get; set; }

        /// <summary>
        /// 合并请求模式
        /// </summary>
        [JsonProperty("review_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewModeEnum ReviewMode { get; set; }
        /// <summary>
        /// squash合入
        /// </summary>
        [JsonProperty("squash", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Squash { get; set; }

        /// <summary>
        /// squash提交信息
        /// </summary>
        [JsonProperty("squash_commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string SquashCommitMessage { get; set; }

        /// <summary>
        /// 是否正在rebase
        /// </summary>
        [JsonProperty("rebase_in_progress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RebaseInProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_repository", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectSimpleDto SourceRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_repository", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectSimpleDto TargetRepository { get; set; }

        /// <summary>
        /// 源分支是否存在
        /// </summary>
        [JsonProperty("is_source_branch_exist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSourceBranchExist { get; set; }

        /// <summary>
        /// 合并请求类型
        /// </summary>
        [JsonProperty("merge_request_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeMergeRequestResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  isSourceBranchProtected: ").Append(IsSourceBranchProtected).Append("\n");
            sb.Append("  devcloudSourceBranch: ").Append(DevcloudSourceBranch).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  sourceRepositoryId: ").Append(SourceRepositoryId).Append("\n");
            sb.Append("  targetRepositoryId: ").Append(TargetRepositoryId).Append("\n");
            sb.Append("  sourceProjectId: ").Append(SourceProjectId).Append("\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  workInProgress: ").Append(WorkInProgress).Append("\n");
            sb.Append("  milestone: ").Append(Milestone).Append("\n");
            sb.Append("  mergeWhenBuildSucceeds: ").Append(MergeWhenBuildSucceeds).Append("\n");
            sb.Append("  mergeStatus: ").Append(MergeStatus).Append("\n");
            sb.Append("  sha: ").Append(Sha).Append("\n");
            sb.Append("  mergeCommitSha: ").Append(MergeCommitSha).Append("\n");
            sb.Append("  subscribed: ").Append(Subscribed).Append("\n");
            sb.Append("  mergedBy: ").Append(MergedBy).Append("\n");
            sb.Append("  mergedAt: ").Append(MergedAt).Append("\n");
            sb.Append("  closedBy: ").Append(ClosedBy).Append("\n");
            sb.Append("  closedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  userNotesCount: ").Append(UserNotesCount).Append("\n");
            sb.Append("  forceRemoveSourceBranch: ").Append(ForceRemoveSourceBranch).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  mergeRequestDiff: ").Append(MergeRequestDiff).Append("\n");
            sb.Append("  mergeRequestReviewersCount: ").Append(MergeRequestReviewersCount).Append("\n");
            sb.Append("  mergeRequestReviewCount: ").Append(MergeRequestReviewCount).Append("\n");
            sb.Append("  mergeRequestReviewerList: ").Append(MergeRequestReviewerList).Append("\n");
            sb.Append("  mergeRequestAssigneeList: ").Append(MergeRequestAssigneeList).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  codecheckState: ").Append(CodecheckState).Append("\n");
            sb.Append("  codecheckDefectCount: ").Append(CodecheckDefectCount).Append("\n");
            sb.Append("  mergeRequestRelatedWorkItems: ").Append(MergeRequestRelatedWorkItems).Append("\n");
            sb.Append("  divergedCommitsCount: ").Append(DivergedCommitsCount).Append("\n");
            sb.Append("  moderationResult: ").Append(ModerationResult).Append("\n");
            sb.Append("  moderationTime: ").Append(ModerationTime).Append("\n");
            sb.Append("  moderationStatus: ").Append(ModerationStatus).Append("\n");
            sb.Append("  isUseTempBranch: ").Append(IsUseTempBranch).Append("\n");
            sb.Append("  approvalMergeRequestApprovers: ").Append(ApprovalMergeRequestApprovers).Append("\n");
            sb.Append("  reviewMode: ").Append(ReviewMode).Append("\n");
            sb.Append("  squash: ").Append(Squash).Append("\n");
            sb.Append("  squashCommitMessage: ").Append(SquashCommitMessage).Append("\n");
            sb.Append("  rebaseInProgress: ").Append(RebaseInProgress).Append("\n");
            sb.Append("  sourceRepository: ").Append(SourceRepository).Append("\n");
            sb.Append("  targetRepository: ").Append(TargetRepository).Append("\n");
            sb.Append("  isSourceBranchExist: ").Append(IsSourceBranchExist).Append("\n");
            sb.Append("  mergeRequestType: ").Append(MergeRequestType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeMergeRequestResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeMergeRequestResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.IsSourceBranchProtected != input.IsSourceBranchProtected || (this.IsSourceBranchProtected != null && !this.IsSourceBranchProtected.Equals(input.IsSourceBranchProtected))) return false;
            if (this.DevcloudSourceBranch != input.DevcloudSourceBranch || (this.DevcloudSourceBranch != null && !this.DevcloudSourceBranch.Equals(input.DevcloudSourceBranch))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.SourceRepositoryId != input.SourceRepositoryId || (this.SourceRepositoryId != null && !this.SourceRepositoryId.Equals(input.SourceRepositoryId))) return false;
            if (this.TargetRepositoryId != input.TargetRepositoryId || (this.TargetRepositoryId != null && !this.TargetRepositoryId.Equals(input.TargetRepositoryId))) return false;
            if (this.SourceProjectId != input.SourceProjectId || (this.SourceProjectId != null && !this.SourceProjectId.Equals(input.SourceProjectId))) return false;
            if (this.TargetProjectId != input.TargetProjectId || (this.TargetProjectId != null && !this.TargetProjectId.Equals(input.TargetProjectId))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.WorkInProgress != input.WorkInProgress || (this.WorkInProgress != null && !this.WorkInProgress.Equals(input.WorkInProgress))) return false;
            if (this.Milestone != input.Milestone || (this.Milestone != null && !this.Milestone.Equals(input.Milestone))) return false;
            if (this.MergeWhenBuildSucceeds != input.MergeWhenBuildSucceeds || (this.MergeWhenBuildSucceeds != null && !this.MergeWhenBuildSucceeds.Equals(input.MergeWhenBuildSucceeds))) return false;
            if (this.MergeStatus != input.MergeStatus || (this.MergeStatus != null && !this.MergeStatus.Equals(input.MergeStatus))) return false;
            if (this.Sha != input.Sha || (this.Sha != null && !this.Sha.Equals(input.Sha))) return false;
            if (this.MergeCommitSha != input.MergeCommitSha || (this.MergeCommitSha != null && !this.MergeCommitSha.Equals(input.MergeCommitSha))) return false;
            if (this.Subscribed != input.Subscribed || (this.Subscribed != null && !this.Subscribed.Equals(input.Subscribed))) return false;
            if (this.MergedBy != input.MergedBy || (this.MergedBy != null && !this.MergedBy.Equals(input.MergedBy))) return false;
            if (this.MergedAt != input.MergedAt || (this.MergedAt != null && !this.MergedAt.Equals(input.MergedAt))) return false;
            if (this.ClosedBy != input.ClosedBy || (this.ClosedBy != null && !this.ClosedBy.Equals(input.ClosedBy))) return false;
            if (this.ClosedAt != input.ClosedAt || (this.ClosedAt != null && !this.ClosedAt.Equals(input.ClosedAt))) return false;
            if (this.UserNotesCount != input.UserNotesCount || (this.UserNotesCount != null && !this.UserNotesCount.Equals(input.UserNotesCount))) return false;
            if (this.ForceRemoveSourceBranch != input.ForceRemoveSourceBranch || (this.ForceRemoveSourceBranch != null && !this.ForceRemoveSourceBranch.Equals(input.ForceRemoveSourceBranch))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.MergeRequestDiff != input.MergeRequestDiff || (this.MergeRequestDiff != null && !this.MergeRequestDiff.Equals(input.MergeRequestDiff))) return false;
            if (this.MergeRequestReviewersCount != input.MergeRequestReviewersCount || (this.MergeRequestReviewersCount != null && !this.MergeRequestReviewersCount.Equals(input.MergeRequestReviewersCount))) return false;
            if (this.MergeRequestReviewCount != input.MergeRequestReviewCount || (this.MergeRequestReviewCount != null && !this.MergeRequestReviewCount.Equals(input.MergeRequestReviewCount))) return false;
            if (this.MergeRequestReviewerList != input.MergeRequestReviewerList || (this.MergeRequestReviewerList != null && input.MergeRequestReviewerList != null && !this.MergeRequestReviewerList.SequenceEqual(input.MergeRequestReviewerList))) return false;
            if (this.MergeRequestAssigneeList != input.MergeRequestAssigneeList || (this.MergeRequestAssigneeList != null && input.MergeRequestAssigneeList != null && !this.MergeRequestAssigneeList.SequenceEqual(input.MergeRequestAssigneeList))) return false;
            if (this.Notes != input.Notes || (this.Notes != null && !this.Notes.Equals(input.Notes))) return false;
            if (this.CodecheckState != input.CodecheckState || (this.CodecheckState != null && !this.CodecheckState.Equals(input.CodecheckState))) return false;
            if (this.CodecheckDefectCount != input.CodecheckDefectCount || (this.CodecheckDefectCount != null && !this.CodecheckDefectCount.Equals(input.CodecheckDefectCount))) return false;
            if (this.MergeRequestRelatedWorkItems != input.MergeRequestRelatedWorkItems || (this.MergeRequestRelatedWorkItems != null && input.MergeRequestRelatedWorkItems != null && !this.MergeRequestRelatedWorkItems.SequenceEqual(input.MergeRequestRelatedWorkItems))) return false;
            if (this.DivergedCommitsCount != input.DivergedCommitsCount || (this.DivergedCommitsCount != null && !this.DivergedCommitsCount.Equals(input.DivergedCommitsCount))) return false;
            if (this.ModerationResult != input.ModerationResult || (this.ModerationResult != null && !this.ModerationResult.Equals(input.ModerationResult))) return false;
            if (this.ModerationTime != input.ModerationTime || (this.ModerationTime != null && !this.ModerationTime.Equals(input.ModerationTime))) return false;
            if (this.ModerationStatus != input.ModerationStatus || (this.ModerationStatus != null && !this.ModerationStatus.Equals(input.ModerationStatus))) return false;
            if (this.IsUseTempBranch != input.IsUseTempBranch || (this.IsUseTempBranch != null && !this.IsUseTempBranch.Equals(input.IsUseTempBranch))) return false;
            if (this.ApprovalMergeRequestApprovers != input.ApprovalMergeRequestApprovers || (this.ApprovalMergeRequestApprovers != null && input.ApprovalMergeRequestApprovers != null && !this.ApprovalMergeRequestApprovers.SequenceEqual(input.ApprovalMergeRequestApprovers))) return false;
            if (this.ReviewMode != input.ReviewMode) return false;
            if (this.Squash != input.Squash || (this.Squash != null && !this.Squash.Equals(input.Squash))) return false;
            if (this.SquashCommitMessage != input.SquashCommitMessage || (this.SquashCommitMessage != null && !this.SquashCommitMessage.Equals(input.SquashCommitMessage))) return false;
            if (this.RebaseInProgress != input.RebaseInProgress || (this.RebaseInProgress != null && !this.RebaseInProgress.Equals(input.RebaseInProgress))) return false;
            if (this.SourceRepository != input.SourceRepository || (this.SourceRepository != null && !this.SourceRepository.Equals(input.SourceRepository))) return false;
            if (this.TargetRepository != input.TargetRepository || (this.TargetRepository != null && !this.TargetRepository.Equals(input.TargetRepository))) return false;
            if (this.IsSourceBranchExist != input.IsSourceBranchExist || (this.IsSourceBranchExist != null && !this.IsSourceBranchExist.Equals(input.IsSourceBranchExist))) return false;
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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.IsSourceBranchProtected != null) hashCode = hashCode * 59 + this.IsSourceBranchProtected.GetHashCode();
                if (this.DevcloudSourceBranch != null) hashCode = hashCode * 59 + this.DevcloudSourceBranch.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.SourceRepositoryId != null) hashCode = hashCode * 59 + this.SourceRepositoryId.GetHashCode();
                if (this.TargetRepositoryId != null) hashCode = hashCode * 59 + this.TargetRepositoryId.GetHashCode();
                if (this.SourceProjectId != null) hashCode = hashCode * 59 + this.SourceProjectId.GetHashCode();
                if (this.TargetProjectId != null) hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.WorkInProgress != null) hashCode = hashCode * 59 + this.WorkInProgress.GetHashCode();
                if (this.Milestone != null) hashCode = hashCode * 59 + this.Milestone.GetHashCode();
                if (this.MergeWhenBuildSucceeds != null) hashCode = hashCode * 59 + this.MergeWhenBuildSucceeds.GetHashCode();
                if (this.MergeStatus != null) hashCode = hashCode * 59 + this.MergeStatus.GetHashCode();
                if (this.Sha != null) hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.MergeCommitSha != null) hashCode = hashCode * 59 + this.MergeCommitSha.GetHashCode();
                if (this.Subscribed != null) hashCode = hashCode * 59 + this.Subscribed.GetHashCode();
                if (this.MergedBy != null) hashCode = hashCode * 59 + this.MergedBy.GetHashCode();
                if (this.MergedAt != null) hashCode = hashCode * 59 + this.MergedAt.GetHashCode();
                if (this.ClosedBy != null) hashCode = hashCode * 59 + this.ClosedBy.GetHashCode();
                if (this.ClosedAt != null) hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
                if (this.UserNotesCount != null) hashCode = hashCode * 59 + this.UserNotesCount.GetHashCode();
                if (this.ForceRemoveSourceBranch != null) hashCode = hashCode * 59 + this.ForceRemoveSourceBranch.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.MergeRequestDiff != null) hashCode = hashCode * 59 + this.MergeRequestDiff.GetHashCode();
                if (this.MergeRequestReviewersCount != null) hashCode = hashCode * 59 + this.MergeRequestReviewersCount.GetHashCode();
                if (this.MergeRequestReviewCount != null) hashCode = hashCode * 59 + this.MergeRequestReviewCount.GetHashCode();
                if (this.MergeRequestReviewerList != null) hashCode = hashCode * 59 + this.MergeRequestReviewerList.GetHashCode();
                if (this.MergeRequestAssigneeList != null) hashCode = hashCode * 59 + this.MergeRequestAssigneeList.GetHashCode();
                if (this.Notes != null) hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.CodecheckState != null) hashCode = hashCode * 59 + this.CodecheckState.GetHashCode();
                if (this.CodecheckDefectCount != null) hashCode = hashCode * 59 + this.CodecheckDefectCount.GetHashCode();
                if (this.MergeRequestRelatedWorkItems != null) hashCode = hashCode * 59 + this.MergeRequestRelatedWorkItems.GetHashCode();
                if (this.DivergedCommitsCount != null) hashCode = hashCode * 59 + this.DivergedCommitsCount.GetHashCode();
                if (this.ModerationResult != null) hashCode = hashCode * 59 + this.ModerationResult.GetHashCode();
                if (this.ModerationTime != null) hashCode = hashCode * 59 + this.ModerationTime.GetHashCode();
                if (this.ModerationStatus != null) hashCode = hashCode * 59 + this.ModerationStatus.GetHashCode();
                if (this.IsUseTempBranch != null) hashCode = hashCode * 59 + this.IsUseTempBranch.GetHashCode();
                if (this.ApprovalMergeRequestApprovers != null) hashCode = hashCode * 59 + this.ApprovalMergeRequestApprovers.GetHashCode();
                hashCode = hashCode * 59 + this.ReviewMode.GetHashCode();
                if (this.Squash != null) hashCode = hashCode * 59 + this.Squash.GetHashCode();
                if (this.SquashCommitMessage != null) hashCode = hashCode * 59 + this.SquashCommitMessage.GetHashCode();
                if (this.RebaseInProgress != null) hashCode = hashCode * 59 + this.RebaseInProgress.GetHashCode();
                if (this.SourceRepository != null) hashCode = hashCode * 59 + this.SourceRepository.GetHashCode();
                if (this.TargetRepository != null) hashCode = hashCode * 59 + this.TargetRepository.GetHashCode();
                if (this.IsSourceBranchExist != null) hashCode = hashCode * 59 + this.IsSourceBranchExist.GetHashCode();
                if (this.MergeRequestType != null) hashCode = hashCode * 59 + this.MergeRequestType.GetHashCode();
                return hashCode;
            }
        }
    }
}
