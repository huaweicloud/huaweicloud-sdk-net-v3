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
    /// **参数解释：** 执行结果。
    /// </summary>
    public class JobResultInfo 
    {

        /// <summary>
        /// **参数解释：** 严重问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("CRITICAL", NullValueHandling = NullValueHandling.Ignore)]
        public int? Critical { get; set; }

        /// <summary>
        /// **参数解释：** 延迟上线问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("DELAYSTATUS_COUNT", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelaystatusCount { get; set; }

        /// <summary>
        /// **参数解释：** 致命问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("FATAL", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fatal { get; set; }

        /// <summary>
        /// **参数解释：** 一般问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("GENERAL", NullValueHandling = NullValueHandling.Ignore)]
        public int? General { get; set; }

        /// <summary>
        /// **参数解释：** 信息问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("INFO", NullValueHandling = NullValueHandling.Ignore)]
        public int? Info { get; set; }

        /// <summary>
        /// **参数解释：** 提示问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("PROMPT", NullValueHandling = NullValueHandling.Ignore)]
        public int? Prompt { get; set; }

        /// <summary>
        /// **参数解释：** 扫描代码行数，不包括空行和注释行。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("codeLine", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLine { get; set; }

        /// <summary>
        /// **参数解释：** 缺陷总数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("defectCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectCount { get; set; }

        /// <summary>
        /// **参数解释：** 已忽略问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("dismissed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dismissed { get; set; }

        /// <summary>
        /// **参数解释：** 文件总数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("fileTotal", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileTotal { get; set; }

        /// <summary>
        /// **参数解释：** 已修复问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("fixed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fixed { get; set; }

        /// <summary>
        /// **参数解释：** 执行ID，来自代码检查执行任务接口的返回值，每次执行代码检查任务都有唯一的执行ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 执行ID，来自代码检查执行任务接口的返回值，每次执行代码检查任务都有唯一的执行ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("jobId", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释：** 未解决且新增的问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("newUnsolvedDefectCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUnsolvedDefectCount { get; set; }

        /// <summary>
        /// **参数解释：** 非安全问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("nonSecurityDefectCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? NonSecurityDefectCount { get; set; }

        /// <summary>
        /// **参数解释：** 门禁结果。 **取值范围：** - success：门禁通过。 - error：门禁未通过。
        /// </summary>
        [JsonProperty("reviewResult", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewResult { get; set; }

        /// <summary>
        /// **参数解释：** 安全问题数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("securityDefectCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityDefectCount { get; set; }

        /// <summary>
        /// **参数解释：** 已解决的问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("solvedDefectCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SolvedDefectCount { get; set; }

        /// <summary>
        /// **参数解释：** 未解决的问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("unsolvedDefectCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnsolvedDefectCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobResultInfo {\n");
            sb.Append("  critical: ").Append(Critical).Append("\n");
            sb.Append("  delaystatusCount: ").Append(DelaystatusCount).Append("\n");
            sb.Append("  fatal: ").Append(Fatal).Append("\n");
            sb.Append("  general: ").Append(General).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("  prompt: ").Append(Prompt).Append("\n");
            sb.Append("  codeLine: ").Append(CodeLine).Append("\n");
            sb.Append("  defectCount: ").Append(DefectCount).Append("\n");
            sb.Append("  dismissed: ").Append(Dismissed).Append("\n");
            sb.Append("  fileTotal: ").Append(FileTotal).Append("\n");
            sb.Append("  Fixed: ").Append(Fixed).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  newUnsolvedDefectCount: ").Append(NewUnsolvedDefectCount).Append("\n");
            sb.Append("  nonSecurityDefectCount: ").Append(NonSecurityDefectCount).Append("\n");
            sb.Append("  reviewResult: ").Append(ReviewResult).Append("\n");
            sb.Append("  securityDefectCount: ").Append(SecurityDefectCount).Append("\n");
            sb.Append("  solvedDefectCount: ").Append(SolvedDefectCount).Append("\n");
            sb.Append("  unsolvedDefectCount: ").Append(UnsolvedDefectCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobResultInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobResultInfo input)
        {
            if (input == null) return false;
            if (this.Critical != input.Critical || (this.Critical != null && !this.Critical.Equals(input.Critical))) return false;
            if (this.DelaystatusCount != input.DelaystatusCount || (this.DelaystatusCount != null && !this.DelaystatusCount.Equals(input.DelaystatusCount))) return false;
            if (this.Fatal != input.Fatal || (this.Fatal != null && !this.Fatal.Equals(input.Fatal))) return false;
            if (this.General != input.General || (this.General != null && !this.General.Equals(input.General))) return false;
            if (this.Info != input.Info || (this.Info != null && !this.Info.Equals(input.Info))) return false;
            if (this.Prompt != input.Prompt || (this.Prompt != null && !this.Prompt.Equals(input.Prompt))) return false;
            if (this.CodeLine != input.CodeLine || (this.CodeLine != null && !this.CodeLine.Equals(input.CodeLine))) return false;
            if (this.DefectCount != input.DefectCount || (this.DefectCount != null && !this.DefectCount.Equals(input.DefectCount))) return false;
            if (this.Dismissed != input.Dismissed || (this.Dismissed != null && !this.Dismissed.Equals(input.Dismissed))) return false;
            if (this.FileTotal != input.FileTotal || (this.FileTotal != null && !this.FileTotal.Equals(input.FileTotal))) return false;
            if (this.Fixed != input.Fixed || (this.Fixed != null && !this.Fixed.Equals(input.Fixed))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.NewUnsolvedDefectCount != input.NewUnsolvedDefectCount || (this.NewUnsolvedDefectCount != null && !this.NewUnsolvedDefectCount.Equals(input.NewUnsolvedDefectCount))) return false;
            if (this.NonSecurityDefectCount != input.NonSecurityDefectCount || (this.NonSecurityDefectCount != null && !this.NonSecurityDefectCount.Equals(input.NonSecurityDefectCount))) return false;
            if (this.ReviewResult != input.ReviewResult || (this.ReviewResult != null && !this.ReviewResult.Equals(input.ReviewResult))) return false;
            if (this.SecurityDefectCount != input.SecurityDefectCount || (this.SecurityDefectCount != null && !this.SecurityDefectCount.Equals(input.SecurityDefectCount))) return false;
            if (this.SolvedDefectCount != input.SolvedDefectCount || (this.SolvedDefectCount != null && !this.SolvedDefectCount.Equals(input.SolvedDefectCount))) return false;
            if (this.UnsolvedDefectCount != input.UnsolvedDefectCount || (this.UnsolvedDefectCount != null && !this.UnsolvedDefectCount.Equals(input.UnsolvedDefectCount))) return false;

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
                if (this.Critical != null) hashCode = hashCode * 59 + this.Critical.GetHashCode();
                if (this.DelaystatusCount != null) hashCode = hashCode * 59 + this.DelaystatusCount.GetHashCode();
                if (this.Fatal != null) hashCode = hashCode * 59 + this.Fatal.GetHashCode();
                if (this.General != null) hashCode = hashCode * 59 + this.General.GetHashCode();
                if (this.Info != null) hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Prompt != null) hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.CodeLine != null) hashCode = hashCode * 59 + this.CodeLine.GetHashCode();
                if (this.DefectCount != null) hashCode = hashCode * 59 + this.DefectCount.GetHashCode();
                if (this.Dismissed != null) hashCode = hashCode * 59 + this.Dismissed.GetHashCode();
                if (this.FileTotal != null) hashCode = hashCode * 59 + this.FileTotal.GetHashCode();
                if (this.Fixed != null) hashCode = hashCode * 59 + this.Fixed.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.NewUnsolvedDefectCount != null) hashCode = hashCode * 59 + this.NewUnsolvedDefectCount.GetHashCode();
                if (this.NonSecurityDefectCount != null) hashCode = hashCode * 59 + this.NonSecurityDefectCount.GetHashCode();
                if (this.ReviewResult != null) hashCode = hashCode * 59 + this.ReviewResult.GetHashCode();
                if (this.SecurityDefectCount != null) hashCode = hashCode * 59 + this.SecurityDefectCount.GetHashCode();
                if (this.SolvedDefectCount != null) hashCode = hashCode * 59 + this.SolvedDefectCount.GetHashCode();
                if (this.UnsolvedDefectCount != null) hashCode = hashCode * 59 + this.UnsolvedDefectCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
