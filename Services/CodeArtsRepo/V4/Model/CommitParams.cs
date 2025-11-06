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
    /// **参数解释：** 提交信息参数。
    /// </summary>
    public class CommitParams 
    {

        /// <summary>
        /// **参数解释：** 分支名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// **参数解释：** 在提交时执行的操作。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionDto> Actions { get; set; }

        /// <summary>
        /// **参数解释：** 从该分支开始新的提交。  **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("start_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string StartBranch { get; set; }

        /// <summary>
        /// **参数解释：** 作者邮箱。  **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("author_email", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// **参数解释：** 作者名称。  **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// **参数解释：** 是否包括提交统计信息。 **取值范围：** - true，包括提交统计信息。 - false，不包括提交统计信息
        /// </summary>
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stats { get; set; }

        /// <summary>
        /// **参数解释：** 是否强制提交。 **取值范围：** - true，强制提交。 - false，非强制提交
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitParams {\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  commitMessage: ").Append(CommitMessage).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  startBranch: ").Append(StartBranch).Append("\n");
            sb.Append("  authorEmail: ").Append(AuthorEmail).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  stats: ").Append(Stats).Append("\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommitParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitParams input)
        {
            if (input == null) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.CommitMessage != input.CommitMessage || (this.CommitMessage != null && !this.CommitMessage.Equals(input.CommitMessage))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.StartBranch != input.StartBranch || (this.StartBranch != null && !this.StartBranch.Equals(input.StartBranch))) return false;
            if (this.AuthorEmail != input.AuthorEmail || (this.AuthorEmail != null && !this.AuthorEmail.Equals(input.AuthorEmail))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.Stats != input.Stats || (this.Stats != null && !this.Stats.Equals(input.Stats))) return false;
            if (this.Force != input.Force || (this.Force != null && !this.Force.Equals(input.Force))) return false;

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
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CommitMessage != null) hashCode = hashCode * 59 + this.CommitMessage.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.StartBranch != null) hashCode = hashCode * 59 + this.StartBranch.GetHashCode();
                if (this.AuthorEmail != null) hashCode = hashCode * 59 + this.AuthorEmail.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.Stats != null) hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Force != null) hashCode = hashCode * 59 + this.Force.GetHashCode();
                return hashCode;
            }
        }
    }
}
