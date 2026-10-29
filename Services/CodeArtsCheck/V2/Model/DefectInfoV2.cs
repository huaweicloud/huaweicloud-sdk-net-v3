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
    /// 
    /// </summary>
    public class DefectInfoV2 
    {

        /// <summary>
        /// **参数解释：** MergeKey，问题ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("defect_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectId { get; set; }

        /// <summary>
        /// **参数解释：** 废弃字段。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("defect_checker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectCheckerName { get; set; }

        /// <summary>
        /// **参数解释：** 问题状态。 **取值范围：** - 0：待处理。 - 1：已解决。 - 2：已忽略。 [- 3：重新打开（需打开忽略审核开关）。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm) [- 4：待审核（需打开忽略审核开关）。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm)
        /// </summary>
        [JsonProperty("defect_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectStatus { get; set; }

        /// <summary>
        /// **参数解释：** 问题责任人。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("defect_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectOwner { get; set; }

        /// <summary>
        /// **参数解释：** 标签，多个标签用逗号隔开。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("rule_system_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSystemTags { get; set; }

        /// <summary>
        /// **参数解释：** 规则ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// **参数解释：** 规则名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// **参数解释：** 问题所在文件行号。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("line_number", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNumber { get; set; }

        /// <summary>
        /// **参数解释：** 问题详细描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("defect_content", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectContent { get; set; }

        /// <summary>
        /// **参数解释：** 问题级别。 **取值范围：** - 0：致命。 - 1：严重。 - 2：一般。 - 3：提示。
        /// </summary>
        [JsonProperty("defect_level", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectLevel { get; set; }

        /// <summary>
        /// **参数解释：** 问题文件路径。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释：** 问题发现时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 废弃字段。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("issue_key", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueKey { get; set; }

        /// <summary>
        /// **参数解释：** 代码片段内容。
        /// </summary>
        [JsonProperty("fragment", NullValueHandling = NullValueHandling.Ignore)]
        public List<DefectFragmentV2> Fragment { get; set; }

        /// <summary>
        /// **参数解释：** 调用链信息。
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<DefectEvents> Events { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefectInfoV2 {\n");
            sb.Append("  defectId: ").Append(DefectId).Append("\n");
            sb.Append("  defectCheckerName: ").Append(DefectCheckerName).Append("\n");
            sb.Append("  defectStatus: ").Append(DefectStatus).Append("\n");
            sb.Append("  defectOwner: ").Append(DefectOwner).Append("\n");
            sb.Append("  ruleSystemTags: ").Append(RuleSystemTags).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  lineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  defectContent: ").Append(DefectContent).Append("\n");
            sb.Append("  defectLevel: ").Append(DefectLevel).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  issueKey: ").Append(IssueKey).Append("\n");
            sb.Append("  fragment: ").Append(Fragment).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DefectInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DefectInfoV2 input)
        {
            if (input == null) return false;
            if (this.DefectId != input.DefectId || (this.DefectId != null && !this.DefectId.Equals(input.DefectId))) return false;
            if (this.DefectCheckerName != input.DefectCheckerName || (this.DefectCheckerName != null && !this.DefectCheckerName.Equals(input.DefectCheckerName))) return false;
            if (this.DefectStatus != input.DefectStatus || (this.DefectStatus != null && !this.DefectStatus.Equals(input.DefectStatus))) return false;
            if (this.DefectOwner != input.DefectOwner || (this.DefectOwner != null && !this.DefectOwner.Equals(input.DefectOwner))) return false;
            if (this.RuleSystemTags != input.RuleSystemTags || (this.RuleSystemTags != null && !this.RuleSystemTags.Equals(input.RuleSystemTags))) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.LineNumber != input.LineNumber || (this.LineNumber != null && !this.LineNumber.Equals(input.LineNumber))) return false;
            if (this.DefectContent != input.DefectContent || (this.DefectContent != null && !this.DefectContent.Equals(input.DefectContent))) return false;
            if (this.DefectLevel != input.DefectLevel || (this.DefectLevel != null && !this.DefectLevel.Equals(input.DefectLevel))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.IssueKey != input.IssueKey || (this.IssueKey != null && !this.IssueKey.Equals(input.IssueKey))) return false;
            if (this.Fragment != input.Fragment || (this.Fragment != null && input.Fragment != null && !this.Fragment.SequenceEqual(input.Fragment))) return false;
            if (this.Events != input.Events || (this.Events != null && input.Events != null && !this.Events.SequenceEqual(input.Events))) return false;

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
                if (this.DefectId != null) hashCode = hashCode * 59 + this.DefectId.GetHashCode();
                if (this.DefectCheckerName != null) hashCode = hashCode * 59 + this.DefectCheckerName.GetHashCode();
                if (this.DefectStatus != null) hashCode = hashCode * 59 + this.DefectStatus.GetHashCode();
                if (this.DefectOwner != null) hashCode = hashCode * 59 + this.DefectOwner.GetHashCode();
                if (this.RuleSystemTags != null) hashCode = hashCode * 59 + this.RuleSystemTags.GetHashCode();
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.LineNumber != null) hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.DefectContent != null) hashCode = hashCode * 59 + this.DefectContent.GetHashCode();
                if (this.DefectLevel != null) hashCode = hashCode * 59 + this.DefectLevel.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.IssueKey != null) hashCode = hashCode * 59 + this.IssueKey.GetHashCode();
                if (this.Fragment != null) hashCode = hashCode * 59 + this.Fragment.GetHashCode();
                if (this.Events != null) hashCode = hashCode * 59 + this.Events.GetHashCode();
                return hashCode;
            }
        }
    }
}
