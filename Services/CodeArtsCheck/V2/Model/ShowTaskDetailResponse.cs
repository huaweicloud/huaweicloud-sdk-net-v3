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
        /// 任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务名字
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 创建者id
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 代码仓地址
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// 代码仓分支,如果是MR模式，为源分支
        /// </summary>
        [JsonProperty("git_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitBranch { get; set; }

        /// <summary>
        /// 上一次检查时间
        /// </summary>
        [JsonProperty("last_check_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCheckTime { get; set; }

        /// <summary>
        /// 代码总行数
        /// </summary>
        [JsonProperty("code_line_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLineTotal { get; set; }

        /// <summary>
        /// 代码有效行数
        /// </summary>
        [JsonProperty("code_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLine { get; set; }

        /// <summary>
        /// 代码质量
        /// </summary>
        [JsonProperty("code_quality", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CodeQuality { get; set; }

        /// <summary>
        /// 问题数
        /// </summary>
        [JsonProperty("issue_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueCount { get; set; }

        /// <summary>
        /// 危险系数
        /// </summary>
        [JsonProperty("risk_coefficient", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RiskCoefficient { get; set; }

        /// <summary>
        /// 重复比例
        /// </summary>
        [JsonProperty("duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string DuplicationRatio { get; set; }

        /// <summary>
        /// 复杂度
        /// </summary>
        [JsonProperty("complexity_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComplexityCount { get; set; }

        /// <summary>
        /// 重复行数
        /// </summary>
        [JsonProperty("duplicated_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicatedLines { get; set; }

        /// <summary>
        /// 注释行数
        /// </summary>
        [JsonProperty("comment_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommentLines { get; set; }

        /// <summary>
        /// 注释比例
        /// </summary>
        [JsonProperty("comment_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string CommentRatio { get; set; }

        /// <summary>
        /// 重复块
        /// </summary>
        [JsonProperty("duplicated_blocks", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicatedBlocks { get; set; }

        /// <summary>
        /// 上次执行时间
        /// </summary>
        [JsonProperty("last_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecTime { get; set; }

        /// <summary>
        /// 检查类型
        /// </summary>
        [JsonProperty("check_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 代码平均复杂度
        /// </summary>
        [JsonProperty("cyclomatic_complexity_per_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclomaticComplexityPerMethod { get; set; }

        /// <summary>
        /// 代码平均复杂度(文件)
        /// </summary>
        [JsonProperty("cyclomatic_complexity_per_file", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclomaticComplexityPerFile { get; set; }

        /// <summary>
        /// 致命问题数
        /// </summary>
        [JsonProperty("critical_count", NullValueHandling = NullValueHandling.Ignore)]
        public string CriticalCount { get; set; }

        /// <summary>
        /// 严重问题数
        /// </summary>
        [JsonProperty("major_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MajorCount { get; set; }

        /// <summary>
        /// 一般问题数
        /// </summary>
        [JsonProperty("minor_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MinorCount { get; set; }

        /// <summary>
        /// 提示问题数
        /// </summary>
        [JsonProperty("suggestion_count", NullValueHandling = NullValueHandling.Ignore)]
        public string SuggestionCount { get; set; }

        /// <summary>
        /// 门禁质量是否通过
        /// </summary>
        [JsonProperty("is_access", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAccess { get; set; }

        /// <summary>
        /// 任务触发方式
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 文件重复率
        /// </summary>
        [JsonProperty("file_duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string FileDuplicationRatio { get; set; }



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
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  fileDuplicationRatio: ").Append(FileDuplicationRatio).Append("\n");
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
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.FileDuplicationRatio != input.FileDuplicationRatio || (this.FileDuplicationRatio != null && !this.FileDuplicationRatio.Equals(input.FileDuplicationRatio))) return false;

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
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.FileDuplicationRatio != null) hashCode = hashCode * 59 + this.FileDuplicationRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
