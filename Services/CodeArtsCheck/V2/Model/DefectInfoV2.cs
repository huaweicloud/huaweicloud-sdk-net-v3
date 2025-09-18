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
    /// 缺陷信息
    /// </summary>
    public class DefectInfoV2 
    {

        /// <summary>
        /// 缺陷的id
        /// </summary>
        [JsonProperty("defect_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectId { get; set; }

        /// <summary>
        /// 缺陷对应检查项的名称
        /// </summary>
        [JsonProperty("defect_checker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectCheckerName { get; set; }

        /// <summary>
        /// 缺陷的状态0为解决 1已解决 2已忽略
        /// </summary>
        [JsonProperty("defect_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectStatus { get; set; }

        /// <summary>
        /// 规则标签,多个标签用逗号隔开
        /// </summary>
        [JsonProperty("rule_system_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSystemTags { get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 缺陷所在文件行号
        /// </summary>
        [JsonProperty("line_number", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNumber { get; set; }

        /// <summary>
        /// 缺陷描述
        /// </summary>
        [JsonProperty("defect_content", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectContent { get; set; }

        /// <summary>
        /// 缺陷等级，0致命，1严重，2一般，3提示
        /// </summary>
        [JsonProperty("defect_level", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectLevel { get; set; }

        /// <summary>
        /// 缺陷文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 问题唯一标识
        /// </summary>
        [JsonProperty("issue_key", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueKey { get; set; }

        /// <summary>
        /// 缺陷代码片段详情
        /// </summary>
        [JsonProperty("fragment", NullValueHandling = NullValueHandling.Ignore)]
        public List<DefectFragmentV2> Fragment { get; set; }

        /// <summary>
        /// 调用链信息
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
            sb.Append("  ruleSystemTags: ").Append(RuleSystemTags).Append("\n");
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
            if (this.RuleSystemTags != input.RuleSystemTags || (this.RuleSystemTags != null && !this.RuleSystemTags.Equals(input.RuleSystemTags))) return false;
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
                if (this.RuleSystemTags != null) hashCode = hashCode * 59 + this.RuleSystemTags.GetHashCode();
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
