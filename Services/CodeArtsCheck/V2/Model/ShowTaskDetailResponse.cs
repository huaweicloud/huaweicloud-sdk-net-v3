using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTaskDetailResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 旧版任务ID。即新建检查任务接口的返回值，每个代码检查任务及其下的分支任务、通过API创建的增量任务都有唯一的任务ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释：** 任务名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数解释：** 任务创建者用户ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓分支，如果是MR模式，为源分支。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("git_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitBranch { get; set; }

        /// <summary>
        /// **参数解释：** 上一次检查时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_check_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCheckTime { get; set; }

        /// <summary>
        /// **参数解释：** 原始代码行数，包含空行和注释行。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("code_line_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLineTotal { get; set; }

        /// <summary>
        /// **参数解释：** 有效代码行数，不包含空行和注释行。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("code_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLine { get; set; }

        /// <summary>
        /// **参数解释：** 代码质量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("code_quality", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CodeQuality { get; set; }

        /// <summary>
        /// **参数解释：** [待处理问题数。](tag:hws,hws_hk)[待处理和重新打开（需打开忽略审核开关）问题数。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm) **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("issue_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueCount { get; set; }

        /// <summary>
        /// **参数解释：** 危险系数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("risk_coefficient", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RiskCoefficient { get; set; }

        /// <summary>
        /// **参数解释：** 代码重复率。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string DuplicationRatio { get; set; }

        /// <summary>
        /// **参数解释：** 圈复杂度总数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("complexity_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComplexityCount { get; set; }

        /// <summary>
        /// **参数解释：** 重复行数总数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("duplicated_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicatedLines { get; set; }

        /// <summary>
        /// **参数解释：** 注释行数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("comment_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommentLines { get; set; }

        /// <summary>
        /// **参数解释：** 注释率。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("comment_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string CommentRatio { get; set; }

        /// <summary>
        /// **参数解释：** 重复块个数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("duplicated_blocks", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicatedBlocks { get; set; }

        /// <summary>
        /// **参数解释：** 上一次执行时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecTime { get; set; }

        /// <summary>
        /// **参数解释：** 废弃字段。 **约束限制：** 不涉及。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("check_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckType { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 平均圈复杂度（方法）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("cyclomatic_complexity_per_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclomaticComplexityPerMethod { get; set; }

        /// <summary>
        /// **参数解释：** 平均圈复杂度（文件）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("cyclomatic_complexity_per_file", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclomaticComplexityPerFile { get; set; }

        /// <summary>
        /// **参数解释：** 致命问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("critical_count", NullValueHandling = NullValueHandling.Ignore)]
        public string CriticalCount { get; set; }

        /// <summary>
        /// **参数解释：** 严重问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("major_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MajorCount { get; set; }

        /// <summary>
        /// **参数解释：** 一般问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("minor_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MinorCount { get; set; }

        /// <summary>
        /// **参数解释：** 提示问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("suggestion_count", NullValueHandling = NullValueHandling.Ignore)]
        public string SuggestionCount { get; set; }

        /// <summary>
        /// **参数解释：** 门禁质量是否通过。 **取值范围：** - 1：门禁通过。 - 0：门禁不通过。
        /// </summary>
        [JsonProperty("is_access", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAccess { get; set; }

        /// <summary>
        /// **参数解释：** 门禁质量是否通过。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("review_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewResult { get; set; }

        /// <summary>
        /// **参数解释：** 任务触发方式。 **取值范围：** - 0：手动触发。 - 1：定时触发。 - 2：代码提交触发。 - 3：合并请求触发。
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// **参数解释：** 文件重复率。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("file_duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string FileDuplicationRatio { get; set; }

        /// <summary>
        /// **参数解释：** 新发现问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("new_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCount { get; set; }

        /// <summary>
        /// **参数解释：** 已解决和已修复问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("solve_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SolveCount { get; set; }

        /// <summary>
        /// **参数解释：** 已忽略问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("dismissed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DismissedCount { get; set; }

        /// <summary>
        /// **参数解释：** 重复文件数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("duplicated_files", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicatedFiles { get; set; }

        /// <summary>
        /// **参数解释：** 新增致命问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("new_critical_count", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCriticalCount { get; set; }

        /// <summary>
        /// **参数解释：** 新增严重问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("new_major_count", NullValueHandling = NullValueHandling.Ignore)]
        public string NewMajorCount { get; set; }

        /// <summary>
        /// **参数解释：** 新增一般问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("new_minor_count", NullValueHandling = NullValueHandling.Ignore)]
        public string NewMinorCount { get; set; }

        /// <summary>
        /// **参数解释：** 新增提示问题数。不包括已忽略和已修复问题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("new_suggestion_count", NullValueHandling = NullValueHandling.Ignore)]
        public string NewSuggestionCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTaskDetailResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  gitBranch: ").Append(GitBranch).Append("\n");
            sb.Append("  lastCheckTime: ").Append(LastCheckTime).Append("\n");
            sb.Append("  codeLineTotal: ").Append(CodeLineTotal).Append("\n");
            sb.Append("  codeLine: ").Append(CodeLine).Append("\n");
            sb.Append("  codeQuality: ").Append(CodeQuality).Append("\n");
            sb.Append("  issueCount: ").Append(IssueCount).Append("\n");
            sb.Append("  riskCoefficient: ").Append(RiskCoefficient).Append("\n");
            sb.Append("  duplicationRatio: ").Append(DuplicationRatio).Append("\n");
            sb.Append("  complexityCount: ").Append(ComplexityCount).Append("\n");
            sb.Append("  duplicatedLines: ").Append(DuplicatedLines).Append("\n");
            sb.Append("  commentLines: ").Append(CommentLines).Append("\n");
            sb.Append("  commentRatio: ").Append(CommentRatio).Append("\n");
            sb.Append("  duplicatedBlocks: ").Append(DuplicatedBlocks).Append("\n");
            sb.Append("  lastExecTime: ").Append(LastExecTime).Append("\n");
            sb.Append("  checkType: ").Append(CheckType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  cyclomaticComplexityPerMethod: ").Append(CyclomaticComplexityPerMethod).Append("\n");
            sb.Append("  cyclomaticComplexityPerFile: ").Append(CyclomaticComplexityPerFile).Append("\n");
            sb.Append("  criticalCount: ").Append(CriticalCount).Append("\n");
            sb.Append("  majorCount: ").Append(MajorCount).Append("\n");
            sb.Append("  minorCount: ").Append(MinorCount).Append("\n");
            sb.Append("  suggestionCount: ").Append(SuggestionCount).Append("\n");
            sb.Append("  isAccess: ").Append(IsAccess).Append("\n");
            sb.Append("  reviewResult: ").Append(ReviewResult).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  fileDuplicationRatio: ").Append(FileDuplicationRatio).Append("\n");
            sb.Append("  newCount: ").Append(NewCount).Append("\n");
            sb.Append("  solveCount: ").Append(SolveCount).Append("\n");
            sb.Append("  dismissedCount: ").Append(DismissedCount).Append("\n");
            sb.Append("  duplicatedFiles: ").Append(DuplicatedFiles).Append("\n");
            sb.Append("  newCriticalCount: ").Append(NewCriticalCount).Append("\n");
            sb.Append("  newMajorCount: ").Append(NewMajorCount).Append("\n");
            sb.Append("  newMinorCount: ").Append(NewMinorCount).Append("\n");
            sb.Append("  newSuggestionCount: ").Append(NewSuggestionCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTaskDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTaskDetailResponse input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.GitBranch != input.GitBranch || (this.GitBranch != null && !this.GitBranch.Equals(input.GitBranch))) return false;
            if (this.LastCheckTime != input.LastCheckTime || (this.LastCheckTime != null && !this.LastCheckTime.Equals(input.LastCheckTime))) return false;
            if (this.CodeLineTotal != input.CodeLineTotal || (this.CodeLineTotal != null && !this.CodeLineTotal.Equals(input.CodeLineTotal))) return false;
            if (this.CodeLine != input.CodeLine || (this.CodeLine != null && !this.CodeLine.Equals(input.CodeLine))) return false;
            if (this.CodeQuality != input.CodeQuality || (this.CodeQuality != null && !this.CodeQuality.Equals(input.CodeQuality))) return false;
            if (this.IssueCount != input.IssueCount || (this.IssueCount != null && !this.IssueCount.Equals(input.IssueCount))) return false;
            if (this.RiskCoefficient != input.RiskCoefficient || (this.RiskCoefficient != null && !this.RiskCoefficient.Equals(input.RiskCoefficient))) return false;
            if (this.DuplicationRatio != input.DuplicationRatio || (this.DuplicationRatio != null && !this.DuplicationRatio.Equals(input.DuplicationRatio))) return false;
            if (this.ComplexityCount != input.ComplexityCount || (this.ComplexityCount != null && !this.ComplexityCount.Equals(input.ComplexityCount))) return false;
            if (this.DuplicatedLines != input.DuplicatedLines || (this.DuplicatedLines != null && !this.DuplicatedLines.Equals(input.DuplicatedLines))) return false;
            if (this.CommentLines != input.CommentLines || (this.CommentLines != null && !this.CommentLines.Equals(input.CommentLines))) return false;
            if (this.CommentRatio != input.CommentRatio || (this.CommentRatio != null && !this.CommentRatio.Equals(input.CommentRatio))) return false;
            if (this.DuplicatedBlocks != input.DuplicatedBlocks || (this.DuplicatedBlocks != null && !this.DuplicatedBlocks.Equals(input.DuplicatedBlocks))) return false;
            if (this.LastExecTime != input.LastExecTime || (this.LastExecTime != null && !this.LastExecTime.Equals(input.LastExecTime))) return false;
            if (this.CheckType != input.CheckType || (this.CheckType != null && !this.CheckType.Equals(input.CheckType))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.CyclomaticComplexityPerMethod != input.CyclomaticComplexityPerMethod || (this.CyclomaticComplexityPerMethod != null && !this.CyclomaticComplexityPerMethod.Equals(input.CyclomaticComplexityPerMethod))) return false;
            if (this.CyclomaticComplexityPerFile != input.CyclomaticComplexityPerFile || (this.CyclomaticComplexityPerFile != null && !this.CyclomaticComplexityPerFile.Equals(input.CyclomaticComplexityPerFile))) return false;
            if (this.CriticalCount != input.CriticalCount || (this.CriticalCount != null && !this.CriticalCount.Equals(input.CriticalCount))) return false;
            if (this.MajorCount != input.MajorCount || (this.MajorCount != null && !this.MajorCount.Equals(input.MajorCount))) return false;
            if (this.MinorCount != input.MinorCount || (this.MinorCount != null && !this.MinorCount.Equals(input.MinorCount))) return false;
            if (this.SuggestionCount != input.SuggestionCount || (this.SuggestionCount != null && !this.SuggestionCount.Equals(input.SuggestionCount))) return false;
            if (this.IsAccess != input.IsAccess || (this.IsAccess != null && !this.IsAccess.Equals(input.IsAccess))) return false;
            if (this.ReviewResult != input.ReviewResult || (this.ReviewResult != null && !this.ReviewResult.Equals(input.ReviewResult))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.FileDuplicationRatio != input.FileDuplicationRatio || (this.FileDuplicationRatio != null && !this.FileDuplicationRatio.Equals(input.FileDuplicationRatio))) return false;
            if (this.NewCount != input.NewCount || (this.NewCount != null && !this.NewCount.Equals(input.NewCount))) return false;
            if (this.SolveCount != input.SolveCount || (this.SolveCount != null && !this.SolveCount.Equals(input.SolveCount))) return false;
            if (this.DismissedCount != input.DismissedCount || (this.DismissedCount != null && !this.DismissedCount.Equals(input.DismissedCount))) return false;
            if (this.DuplicatedFiles != input.DuplicatedFiles || (this.DuplicatedFiles != null && !this.DuplicatedFiles.Equals(input.DuplicatedFiles))) return false;
            if (this.NewCriticalCount != input.NewCriticalCount || (this.NewCriticalCount != null && !this.NewCriticalCount.Equals(input.NewCriticalCount))) return false;
            if (this.NewMajorCount != input.NewMajorCount || (this.NewMajorCount != null && !this.NewMajorCount.Equals(input.NewMajorCount))) return false;
            if (this.NewMinorCount != input.NewMinorCount || (this.NewMinorCount != null && !this.NewMinorCount.Equals(input.NewMinorCount))) return false;
            if (this.NewSuggestionCount != input.NewSuggestionCount || (this.NewSuggestionCount != null && !this.NewSuggestionCount.Equals(input.NewSuggestionCount))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.GitBranch != null) hashCode = hashCode * 59 + this.GitBranch.GetHashCode();
                if (this.LastCheckTime != null) hashCode = hashCode * 59 + this.LastCheckTime.GetHashCode();
                if (this.CodeLineTotal != null) hashCode = hashCode * 59 + this.CodeLineTotal.GetHashCode();
                if (this.CodeLine != null) hashCode = hashCode * 59 + this.CodeLine.GetHashCode();
                if (this.CodeQuality != null) hashCode = hashCode * 59 + this.CodeQuality.GetHashCode();
                if (this.IssueCount != null) hashCode = hashCode * 59 + this.IssueCount.GetHashCode();
                if (this.RiskCoefficient != null) hashCode = hashCode * 59 + this.RiskCoefficient.GetHashCode();
                if (this.DuplicationRatio != null) hashCode = hashCode * 59 + this.DuplicationRatio.GetHashCode();
                if (this.ComplexityCount != null) hashCode = hashCode * 59 + this.ComplexityCount.GetHashCode();
                if (this.DuplicatedLines != null) hashCode = hashCode * 59 + this.DuplicatedLines.GetHashCode();
                if (this.CommentLines != null) hashCode = hashCode * 59 + this.CommentLines.GetHashCode();
                if (this.CommentRatio != null) hashCode = hashCode * 59 + this.CommentRatio.GetHashCode();
                if (this.DuplicatedBlocks != null) hashCode = hashCode * 59 + this.DuplicatedBlocks.GetHashCode();
                if (this.LastExecTime != null) hashCode = hashCode * 59 + this.LastExecTime.GetHashCode();
                if (this.CheckType != null) hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CyclomaticComplexityPerMethod != null) hashCode = hashCode * 59 + this.CyclomaticComplexityPerMethod.GetHashCode();
                if (this.CyclomaticComplexityPerFile != null) hashCode = hashCode * 59 + this.CyclomaticComplexityPerFile.GetHashCode();
                if (this.CriticalCount != null) hashCode = hashCode * 59 + this.CriticalCount.GetHashCode();
                if (this.MajorCount != null) hashCode = hashCode * 59 + this.MajorCount.GetHashCode();
                if (this.MinorCount != null) hashCode = hashCode * 59 + this.MinorCount.GetHashCode();
                if (this.SuggestionCount != null) hashCode = hashCode * 59 + this.SuggestionCount.GetHashCode();
                if (this.IsAccess != null) hashCode = hashCode * 59 + this.IsAccess.GetHashCode();
                if (this.ReviewResult != null) hashCode = hashCode * 59 + this.ReviewResult.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.FileDuplicationRatio != null) hashCode = hashCode * 59 + this.FileDuplicationRatio.GetHashCode();
                if (this.NewCount != null) hashCode = hashCode * 59 + this.NewCount.GetHashCode();
                if (this.SolveCount != null) hashCode = hashCode * 59 + this.SolveCount.GetHashCode();
                if (this.DismissedCount != null) hashCode = hashCode * 59 + this.DismissedCount.GetHashCode();
                if (this.DuplicatedFiles != null) hashCode = hashCode * 59 + this.DuplicatedFiles.GetHashCode();
                if (this.NewCriticalCount != null) hashCode = hashCode * 59 + this.NewCriticalCount.GetHashCode();
                if (this.NewMajorCount != null) hashCode = hashCode * 59 + this.NewMajorCount.GetHashCode();
                if (this.NewMinorCount != null) hashCode = hashCode * 59 + this.NewMinorCount.GetHashCode();
                if (this.NewSuggestionCount != null) hashCode = hashCode * 59 + this.NewSuggestionCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
