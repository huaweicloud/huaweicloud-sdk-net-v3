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
    /// 更新合并请求设置请求体
    /// </summary>
    public class UpdateMergeRequestSettingDto 
    {
        /// <summary>
        /// **参数解释：** 合入模式
        /// </summary>
        /// <value>**参数解释：** 合入模式</value>
        [JsonConverter(typeof(EnumClassConverter<ReviewModeEnum>))]
        public class ReviewModeEnum
        {
            /// <summary>
            /// Enum APPROVAL for value: approval
            /// </summary>
            public static readonly ReviewModeEnum APPROVAL = new ReviewModeEnum("approval");

            /// <summary>
            /// Enum VOTE for value: vote
            /// </summary>
            public static readonly ReviewModeEnum VOTE = new ReviewModeEnum("vote");

            private static readonly Dictionary<string, ReviewModeEnum> StaticFields =
            new Dictionary<string, ReviewModeEnum>()
            {
                { "approval", APPROVAL },
                { "vote", VOTE },
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
        /// **参数解释：** 是否将星级评价作为合入门禁-参与星级评价角色。 29：勾选开发者 30：勾选开发者，Committer 35：勾选Committer 40：都不勾选
        /// </summary>
        /// <value>**参数解释：** 是否将星级评价作为合入门禁-参与星级评价角色。 29：勾选开发者 30：勾选开发者，Committer 35：勾选Committer 40：都不勾选</value>
        [JsonConverter(typeof(EnumClassConverter<EvaluationRoleEnum>))]
        public class EvaluationRoleEnum
        {
            /// <summary>
            /// Enum NUMBER_29 for value: 29
            /// </summary>
            public static readonly EvaluationRoleEnum NUMBER_29 = new EvaluationRoleEnum(29);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly EvaluationRoleEnum NUMBER_30 = new EvaluationRoleEnum(30);

            /// <summary>
            /// Enum NUMBER_35 for value: 35
            /// </summary>
            public static readonly EvaluationRoleEnum NUMBER_35 = new EvaluationRoleEnum(35);

            /// <summary>
            /// Enum NUMBER_40 for value: 40
            /// </summary>
            public static readonly EvaluationRoleEnum NUMBER_40 = new EvaluationRoleEnum(40);

            private static readonly Dictionary<int?, EvaluationRoleEnum> StaticFields =
            new Dictionary<int?, EvaluationRoleEnum>()
            {
                { 29, NUMBER_29 },
                { 30, NUMBER_30 },
                { 35, NUMBER_35 },
                { 40, NUMBER_40 },
            };

            private int? _value;

            public EvaluationRoleEnum()
            {

            }

            public EvaluationRoleEnum(int? value)
            {
                _value = value;
            }

            public static EvaluationRoleEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as EvaluationRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EvaluationRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EvaluationRoleEnum a, EvaluationRoleEnum b)
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

            public static bool operator !=(EvaluationRoleEnum a, EvaluationRoleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 合并模式。 merge：通过 Merge Commit 合并 rebase_merge：通过 Merge Commit 合并(记录半线性历史) ff：Fast-forward 合并
        /// </summary>
        /// <value>**参数解释：** 合并模式。 merge：通过 Merge Commit 合并 rebase_merge：通过 Merge Commit 合并(记录半线性历史) ff：Fast-forward 合并</value>
        [JsonConverter(typeof(EnumClassConverter<MergeMethodEnum>))]
        public class MergeMethodEnum
        {
            /// <summary>
            /// Enum MERGE for value: merge
            /// </summary>
            public static readonly MergeMethodEnum MERGE = new MergeMethodEnum("merge");

            /// <summary>
            /// Enum REBASE_MERGE for value: rebase_merge
            /// </summary>
            public static readonly MergeMethodEnum REBASE_MERGE = new MergeMethodEnum("rebase_merge");

            /// <summary>
            /// Enum FF for value: ff
            /// </summary>
            public static readonly MergeMethodEnum FF = new MergeMethodEnum("ff");

            private static readonly Dictionary<string, MergeMethodEnum> StaticFields =
            new Dictionary<string, MergeMethodEnum>()
            {
                { "merge", MERGE },
                { "rebase_merge", REBASE_MERGE },
                { "ff", FF },
            };

            private string _value;

            public MergeMethodEnum()
            {

            }

            public MergeMethodEnum(string value)
            {
                _value = value;
            }

            public static MergeMethodEnum FromValue(string value)
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

                if (this.Equals(obj as MergeMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MergeMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MergeMethodEnum a, MergeMethodEnum b)
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

            public static bool operator !=(MergeMethodEnum a, MergeMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** merged_by：使用MR合入者生成Merge Commit created_by：使用MR创建者生成Merge Commit
        /// </summary>
        /// <value>**参数解释：** merged_by：使用MR合入者生成Merge Commit created_by：使用MR创建者生成Merge Commit</value>
        [JsonConverter(typeof(EnumClassConverter<MergedCommitAuthorEnum>))]
        public class MergedCommitAuthorEnum
        {
            /// <summary>
            /// Enum MERGED_BY for value: merged_by
            /// </summary>
            public static readonly MergedCommitAuthorEnum MERGED_BY = new MergedCommitAuthorEnum("merged_by");

            /// <summary>
            /// Enum CREATED_BY for value: created_by
            /// </summary>
            public static readonly MergedCommitAuthorEnum CREATED_BY = new MergedCommitAuthorEnum("created_by");

            private static readonly Dictionary<string, MergedCommitAuthorEnum> StaticFields =
            new Dictionary<string, MergedCommitAuthorEnum>()
            {
                { "merged_by", MERGED_BY },
                { "created_by", CREATED_BY },
            };

            private string _value;

            public MergedCommitAuthorEnum()
            {

            }

            public MergedCommitAuthorEnum(string value)
            {
                _value = value;
            }

            public static MergedCommitAuthorEnum FromValue(string value)
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

                if (this.Equals(obj as MergedCommitAuthorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MergedCommitAuthorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MergedCommitAuthorEnum a, MergedCommitAuthorEnum b)
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

            public static bool operator !=(MergedCommitAuthorEnum a, MergedCommitAuthorEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 合入模式
        /// </summary>
        [JsonProperty("review_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewModeEnum ReviewMode { get; set; }
        /// <summary>
        /// **参数解释：** 评审问题全部解决才能合入
        /// </summary>
        [JsonProperty("only_allow_merge_if_all_discussions_are_resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyAllowMergeIfAllDiscussionsAreResolved { get; set; }

        /// <summary>
        /// **参数解释：** 必须与CodeArts Req关联
        /// </summary>
        [JsonProperty("must_relate_issue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MustRelateIssue { get; set; }

        /// <summary>
        /// **参数解释：** 只能关联一个单号
        /// </summary>
        [JsonProperty("only_allow_one_issue_check_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyAllowOneIssueCheckPassed { get; set; }

        /// <summary>
        /// **参数解释：** 必须与CodeArts Req关联-所有E2E单号校验必须通过
        /// </summary>
        [JsonProperty("need_all_issues_check_passed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedAllIssuesCheckPassed { get; set; }

        /// <summary>
        /// **参数解释：** 必须与CodeArts Req关联-选择目标分支配置合并请求策略(分支以逗号分支的字符串)
        /// </summary>
        [JsonProperty("need_relate_issue_branches", NullValueHandling = NullValueHandling.Ignore)]
        public string NeedRelateIssueBranches { get; set; }

        /// <summary>
        /// **参数解释：** 是否将星级评价作为合入门禁
        /// </summary>
        [JsonProperty("evaluation_merge_gate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EvaluationMergeGate { get; set; }

        /// <summary>
        /// **参数解释：** 是否将星级评价作为合入门禁-参与星级评价角色。 29：勾选开发者 30：勾选开发者，Committer 35：勾选Committer 40：都不勾选
        /// </summary>
        [JsonProperty("evaluation_role", NullValueHandling = NullValueHandling.Ignore)]
        public EvaluationRoleEnum EvaluationRole { get; set; }
        /// <summary>
        /// **参数解释：** 禁止合入自己创建的合并请求
        /// </summary>
        [JsonProperty("disable_merge_by_self", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableMergeBySelf { get; set; }

        /// <summary>
        /// **参数解释：** 禁止审核自己创建的合并请求
        /// </summary>
        [JsonProperty("disable_approve_by_self", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableApproveBySelf { get; set; }

        /// <summary>
        /// **参数解释：** 禁止检视自己创建的合并请求
        /// </summary>
        [JsonProperty("disable_review_by_self", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableReviewBySelf { get; set; }

        /// <summary>
        /// **参数解释：** 允许仓库管理员及项目经理强制合入
        /// </summary>
        [JsonProperty("can_force_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanForceMerge { get; set; }

        /// <summary>
        /// **参数解释：** 允许合并请求合并或关闭后继续做代码检视和评论
        /// </summary>
        [JsonProperty("add_notes_after_merged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddNotesAfterMerged { get; set; }

        /// <summary>
        /// **参数解释：** 是否将自动合并的MR状态标记为关闭状态
        /// </summary>
        [JsonProperty("mark_auto_merged_mr_as_closed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkAutoMergedMrAsClosed { get; set; }

        /// <summary>
        /// **参数解释：** 不能重新打开一个已经关闭的合并请求
        /// </summary>
        [JsonProperty("can_reopen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanReopen { get; set; }

        /// <summary>
        /// **参数解释：** 新建合并请求，默认开启合并后删除源分支
        /// </summary>
        [JsonProperty("delete_source_branch_when_merged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteSourceBranchWhenMerged { get; set; }

        /// <summary>
        /// **参数解释：** 禁止Squash合并（合入MR时禁止Squash合并）
        /// </summary>
        [JsonProperty("disable_squash_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableSquashMerge { get; set; }

        /// <summary>
        /// **参数解释：** 新建合并请求，默认开启Squash合并
        /// </summary>
        [JsonProperty("auto_squash_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoSquashMerge { get; set; }

        /// <summary>
        /// **参数解释：** 合并模式。 merge：通过 Merge Commit 合并 rebase_merge：通过 Merge Commit 合并(记录半线性历史) ff：Fast-forward 合并
        /// </summary>
        [JsonProperty("merge_method", NullValueHandling = NullValueHandling.Ignore)]
        public MergeMethodEnum MergeMethod { get; set; }
        /// <summary>
        /// **参数解释：** Squash合并不产生Merge节点
        /// </summary>
        [JsonProperty("squash_merge_with_no_merge_commit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SquashMergeWithNoMergeCommit { get; set; }

        /// <summary>
        /// **参数解释：** merged_by：使用MR合入者生成Merge Commit created_by：使用MR创建者生成Merge Commit
        /// </summary>
        [JsonProperty("merged_commit_author", NullValueHandling = NullValueHandling.Ignore)]
        public MergedCommitAuthorEnum MergedCommitAuthor { get; set; }
        /// <summary>
        /// **参数解释：** 启用MR自定义评价维度分类（MR评价设置）
        /// </summary>
        [JsonProperty("enable_custom_evaluation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCustomEvaluation { get; set; }

        /// <summary>
        /// **参数解释：** 评价维度（MR评价设置）
        /// </summary>
        [JsonProperty("evaluation_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EvaluationTypes { get; set; }

        /// <summary>
        /// **参数解释：** 打分模式最低合入分数。
        /// </summary>
        [JsonProperty("only_allow_merge_if_vote_bigger_than", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlyAllowMergeIfVoteBiggerThan { get; set; }

        /// <summary>
        /// **参数解释：** 仅合并人和合并合并请求。
        /// </summary>
        [JsonProperty("only_assignee_can_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyAssigneeCanMerge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMergeRequestSettingDto {\n");
            sb.Append("  reviewMode: ").Append(ReviewMode).Append("\n");
            sb.Append("  onlyAllowMergeIfAllDiscussionsAreResolved: ").Append(OnlyAllowMergeIfAllDiscussionsAreResolved).Append("\n");
            sb.Append("  mustRelateIssue: ").Append(MustRelateIssue).Append("\n");
            sb.Append("  onlyAllowOneIssueCheckPassed: ").Append(OnlyAllowOneIssueCheckPassed).Append("\n");
            sb.Append("  needAllIssuesCheckPassed: ").Append(NeedAllIssuesCheckPassed).Append("\n");
            sb.Append("  needRelateIssueBranches: ").Append(NeedRelateIssueBranches).Append("\n");
            sb.Append("  evaluationMergeGate: ").Append(EvaluationMergeGate).Append("\n");
            sb.Append("  evaluationRole: ").Append(EvaluationRole).Append("\n");
            sb.Append("  disableMergeBySelf: ").Append(DisableMergeBySelf).Append("\n");
            sb.Append("  disableApproveBySelf: ").Append(DisableApproveBySelf).Append("\n");
            sb.Append("  disableReviewBySelf: ").Append(DisableReviewBySelf).Append("\n");
            sb.Append("  canForceMerge: ").Append(CanForceMerge).Append("\n");
            sb.Append("  addNotesAfterMerged: ").Append(AddNotesAfterMerged).Append("\n");
            sb.Append("  markAutoMergedMrAsClosed: ").Append(MarkAutoMergedMrAsClosed).Append("\n");
            sb.Append("  canReopen: ").Append(CanReopen).Append("\n");
            sb.Append("  deleteSourceBranchWhenMerged: ").Append(DeleteSourceBranchWhenMerged).Append("\n");
            sb.Append("  disableSquashMerge: ").Append(DisableSquashMerge).Append("\n");
            sb.Append("  autoSquashMerge: ").Append(AutoSquashMerge).Append("\n");
            sb.Append("  mergeMethod: ").Append(MergeMethod).Append("\n");
            sb.Append("  squashMergeWithNoMergeCommit: ").Append(SquashMergeWithNoMergeCommit).Append("\n");
            sb.Append("  mergedCommitAuthor: ").Append(MergedCommitAuthor).Append("\n");
            sb.Append("  enableCustomEvaluation: ").Append(EnableCustomEvaluation).Append("\n");
            sb.Append("  evaluationTypes: ").Append(EvaluationTypes).Append("\n");
            sb.Append("  onlyAllowMergeIfVoteBiggerThan: ").Append(OnlyAllowMergeIfVoteBiggerThan).Append("\n");
            sb.Append("  onlyAssigneeCanMerge: ").Append(OnlyAssigneeCanMerge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMergeRequestSettingDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMergeRequestSettingDto input)
        {
            if (input == null) return false;
            if (this.ReviewMode != input.ReviewMode) return false;
            if (this.OnlyAllowMergeIfAllDiscussionsAreResolved != input.OnlyAllowMergeIfAllDiscussionsAreResolved || (this.OnlyAllowMergeIfAllDiscussionsAreResolved != null && !this.OnlyAllowMergeIfAllDiscussionsAreResolved.Equals(input.OnlyAllowMergeIfAllDiscussionsAreResolved))) return false;
            if (this.MustRelateIssue != input.MustRelateIssue || (this.MustRelateIssue != null && !this.MustRelateIssue.Equals(input.MustRelateIssue))) return false;
            if (this.OnlyAllowOneIssueCheckPassed != input.OnlyAllowOneIssueCheckPassed || (this.OnlyAllowOneIssueCheckPassed != null && !this.OnlyAllowOneIssueCheckPassed.Equals(input.OnlyAllowOneIssueCheckPassed))) return false;
            if (this.NeedAllIssuesCheckPassed != input.NeedAllIssuesCheckPassed || (this.NeedAllIssuesCheckPassed != null && !this.NeedAllIssuesCheckPassed.Equals(input.NeedAllIssuesCheckPassed))) return false;
            if (this.NeedRelateIssueBranches != input.NeedRelateIssueBranches || (this.NeedRelateIssueBranches != null && !this.NeedRelateIssueBranches.Equals(input.NeedRelateIssueBranches))) return false;
            if (this.EvaluationMergeGate != input.EvaluationMergeGate || (this.EvaluationMergeGate != null && !this.EvaluationMergeGate.Equals(input.EvaluationMergeGate))) return false;
            if (this.EvaluationRole != input.EvaluationRole) return false;
            if (this.DisableMergeBySelf != input.DisableMergeBySelf || (this.DisableMergeBySelf != null && !this.DisableMergeBySelf.Equals(input.DisableMergeBySelf))) return false;
            if (this.DisableApproveBySelf != input.DisableApproveBySelf || (this.DisableApproveBySelf != null && !this.DisableApproveBySelf.Equals(input.DisableApproveBySelf))) return false;
            if (this.DisableReviewBySelf != input.DisableReviewBySelf || (this.DisableReviewBySelf != null && !this.DisableReviewBySelf.Equals(input.DisableReviewBySelf))) return false;
            if (this.CanForceMerge != input.CanForceMerge || (this.CanForceMerge != null && !this.CanForceMerge.Equals(input.CanForceMerge))) return false;
            if (this.AddNotesAfterMerged != input.AddNotesAfterMerged || (this.AddNotesAfterMerged != null && !this.AddNotesAfterMerged.Equals(input.AddNotesAfterMerged))) return false;
            if (this.MarkAutoMergedMrAsClosed != input.MarkAutoMergedMrAsClosed || (this.MarkAutoMergedMrAsClosed != null && !this.MarkAutoMergedMrAsClosed.Equals(input.MarkAutoMergedMrAsClosed))) return false;
            if (this.CanReopen != input.CanReopen || (this.CanReopen != null && !this.CanReopen.Equals(input.CanReopen))) return false;
            if (this.DeleteSourceBranchWhenMerged != input.DeleteSourceBranchWhenMerged || (this.DeleteSourceBranchWhenMerged != null && !this.DeleteSourceBranchWhenMerged.Equals(input.DeleteSourceBranchWhenMerged))) return false;
            if (this.DisableSquashMerge != input.DisableSquashMerge || (this.DisableSquashMerge != null && !this.DisableSquashMerge.Equals(input.DisableSquashMerge))) return false;
            if (this.AutoSquashMerge != input.AutoSquashMerge || (this.AutoSquashMerge != null && !this.AutoSquashMerge.Equals(input.AutoSquashMerge))) return false;
            if (this.MergeMethod != input.MergeMethod) return false;
            if (this.SquashMergeWithNoMergeCommit != input.SquashMergeWithNoMergeCommit || (this.SquashMergeWithNoMergeCommit != null && !this.SquashMergeWithNoMergeCommit.Equals(input.SquashMergeWithNoMergeCommit))) return false;
            if (this.MergedCommitAuthor != input.MergedCommitAuthor) return false;
            if (this.EnableCustomEvaluation != input.EnableCustomEvaluation || (this.EnableCustomEvaluation != null && !this.EnableCustomEvaluation.Equals(input.EnableCustomEvaluation))) return false;
            if (this.EvaluationTypes != input.EvaluationTypes || (this.EvaluationTypes != null && input.EvaluationTypes != null && !this.EvaluationTypes.SequenceEqual(input.EvaluationTypes))) return false;
            if (this.OnlyAllowMergeIfVoteBiggerThan != input.OnlyAllowMergeIfVoteBiggerThan || (this.OnlyAllowMergeIfVoteBiggerThan != null && !this.OnlyAllowMergeIfVoteBiggerThan.Equals(input.OnlyAllowMergeIfVoteBiggerThan))) return false;
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
                hashCode = hashCode * 59 + this.ReviewMode.GetHashCode();
                if (this.OnlyAllowMergeIfAllDiscussionsAreResolved != null) hashCode = hashCode * 59 + this.OnlyAllowMergeIfAllDiscussionsAreResolved.GetHashCode();
                if (this.MustRelateIssue != null) hashCode = hashCode * 59 + this.MustRelateIssue.GetHashCode();
                if (this.OnlyAllowOneIssueCheckPassed != null) hashCode = hashCode * 59 + this.OnlyAllowOneIssueCheckPassed.GetHashCode();
                if (this.NeedAllIssuesCheckPassed != null) hashCode = hashCode * 59 + this.NeedAllIssuesCheckPassed.GetHashCode();
                if (this.NeedRelateIssueBranches != null) hashCode = hashCode * 59 + this.NeedRelateIssueBranches.GetHashCode();
                if (this.EvaluationMergeGate != null) hashCode = hashCode * 59 + this.EvaluationMergeGate.GetHashCode();
                hashCode = hashCode * 59 + this.EvaluationRole.GetHashCode();
                if (this.DisableMergeBySelf != null) hashCode = hashCode * 59 + this.DisableMergeBySelf.GetHashCode();
                if (this.DisableApproveBySelf != null) hashCode = hashCode * 59 + this.DisableApproveBySelf.GetHashCode();
                if (this.DisableReviewBySelf != null) hashCode = hashCode * 59 + this.DisableReviewBySelf.GetHashCode();
                if (this.CanForceMerge != null) hashCode = hashCode * 59 + this.CanForceMerge.GetHashCode();
                if (this.AddNotesAfterMerged != null) hashCode = hashCode * 59 + this.AddNotesAfterMerged.GetHashCode();
                if (this.MarkAutoMergedMrAsClosed != null) hashCode = hashCode * 59 + this.MarkAutoMergedMrAsClosed.GetHashCode();
                if (this.CanReopen != null) hashCode = hashCode * 59 + this.CanReopen.GetHashCode();
                if (this.DeleteSourceBranchWhenMerged != null) hashCode = hashCode * 59 + this.DeleteSourceBranchWhenMerged.GetHashCode();
                if (this.DisableSquashMerge != null) hashCode = hashCode * 59 + this.DisableSquashMerge.GetHashCode();
                if (this.AutoSquashMerge != null) hashCode = hashCode * 59 + this.AutoSquashMerge.GetHashCode();
                hashCode = hashCode * 59 + this.MergeMethod.GetHashCode();
                if (this.SquashMergeWithNoMergeCommit != null) hashCode = hashCode * 59 + this.SquashMergeWithNoMergeCommit.GetHashCode();
                hashCode = hashCode * 59 + this.MergedCommitAuthor.GetHashCode();
                if (this.EnableCustomEvaluation != null) hashCode = hashCode * 59 + this.EnableCustomEvaluation.GetHashCode();
                if (this.EvaluationTypes != null) hashCode = hashCode * 59 + this.EvaluationTypes.GetHashCode();
                if (this.OnlyAllowMergeIfVoteBiggerThan != null) hashCode = hashCode * 59 + this.OnlyAllowMergeIfVoteBiggerThan.GetHashCode();
                if (this.OnlyAssigneeCanMerge != null) hashCode = hashCode * 59 + this.OnlyAssigneeCanMerge.GetHashCode();
                return hashCode;
            }
        }
    }
}
