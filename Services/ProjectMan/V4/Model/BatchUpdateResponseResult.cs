using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// **参数解释：** 返回结果。 **取值范围：** 不涉及。
    /// </summary>
    public class BatchUpdateResponseResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public BatchUpdateResponseResultProject Project { get; set; }

        /// <summary>
        /// **参数解释：** 历史记录id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("journal_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JournalIds { get; set; }

        /// <summary>
        /// **参数解释：** 编辑失败的工作项。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("error_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ErrorIssues { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的迭代版本。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("versions_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VersionsIssues { get; set; }

        /// <summary>
        /// **参数解释：** 编辑成功的工作项。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("success_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuccessIssues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateResponseResult {\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  journalIds: ").Append(JournalIds).Append("\n");
            sb.Append("  errorIssues: ").Append(ErrorIssues).Append("\n");
            sb.Append("  versionsIssues: ").Append(VersionsIssues).Append("\n");
            sb.Append("  successIssues: ").Append(SuccessIssues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateResponseResult input)
        {
            if (input == null) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;
            if (this.JournalIds != input.JournalIds || (this.JournalIds != null && input.JournalIds != null && !this.JournalIds.SequenceEqual(input.JournalIds))) return false;
            if (this.ErrorIssues != input.ErrorIssues || (this.ErrorIssues != null && input.ErrorIssues != null && !this.ErrorIssues.SequenceEqual(input.ErrorIssues))) return false;
            if (this.VersionsIssues != input.VersionsIssues || (this.VersionsIssues != null && input.VersionsIssues != null && !this.VersionsIssues.SequenceEqual(input.VersionsIssues))) return false;
            if (this.SuccessIssues != input.SuccessIssues || (this.SuccessIssues != null && input.SuccessIssues != null && !this.SuccessIssues.SequenceEqual(input.SuccessIssues))) return false;

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
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.JournalIds != null) hashCode = hashCode * 59 + this.JournalIds.GetHashCode();
                if (this.ErrorIssues != null) hashCode = hashCode * 59 + this.ErrorIssues.GetHashCode();
                if (this.VersionsIssues != null) hashCode = hashCode * 59 + this.VersionsIssues.GetHashCode();
                if (this.SuccessIssues != null) hashCode = hashCode * 59 + this.SuccessIssues.GetHashCode();
                return hashCode;
            }
        }
    }
}
