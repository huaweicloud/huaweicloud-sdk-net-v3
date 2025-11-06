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
    /// 
    /// </summary>
    public class RenameFileBodyDto 
    {

        /// <summary>
        /// **参数解释：** 文件路径 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释：** 分支名 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// **参数解释：** 基于分支名（即基于某分支，向其他分支进行推送） **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("start_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string StartBranch { get; set; }

        /// <summary>
        /// **参数解释：** 作者邮箱 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("author_email", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// **参数解释：** 作者名称 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// **参数解释：** 改名前地址 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("previous_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousPath { get; set; }

        /// <summary>
        /// **参数解释：** 是否迁移内容（与content字段不能同时为空） **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("infer_content", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InferContent { get; set; }

        /// <summary>
        /// **参数解释：** 文件内容（与infer_content字段不能同时为空） **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// **参数解释：** 编码方式。 **取值范围：** - text。 - base64.
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// **参数解释：** 上次已知的文件提交ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCommitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenameFileBodyDto {\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  commitMessage: ").Append(CommitMessage).Append("\n");
            sb.Append("  startBranch: ").Append(StartBranch).Append("\n");
            sb.Append("  authorEmail: ").Append(AuthorEmail).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  previousPath: ").Append(PreviousPath).Append("\n");
            sb.Append("  inferContent: ").Append(InferContent).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  encoding: ").Append(Encoding).Append("\n");
            sb.Append("  lastCommitId: ").Append(LastCommitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RenameFileBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RenameFileBodyDto input)
        {
            if (input == null) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.CommitMessage != input.CommitMessage || (this.CommitMessage != null && !this.CommitMessage.Equals(input.CommitMessage))) return false;
            if (this.StartBranch != input.StartBranch || (this.StartBranch != null && !this.StartBranch.Equals(input.StartBranch))) return false;
            if (this.AuthorEmail != input.AuthorEmail || (this.AuthorEmail != null && !this.AuthorEmail.Equals(input.AuthorEmail))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.PreviousPath != input.PreviousPath || (this.PreviousPath != null && !this.PreviousPath.Equals(input.PreviousPath))) return false;
            if (this.InferContent != input.InferContent || (this.InferContent != null && !this.InferContent.Equals(input.InferContent))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Encoding != input.Encoding || (this.Encoding != null && !this.Encoding.Equals(input.Encoding))) return false;
            if (this.LastCommitId != input.LastCommitId || (this.LastCommitId != null && !this.LastCommitId.Equals(input.LastCommitId))) return false;

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
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.CommitMessage != null) hashCode = hashCode * 59 + this.CommitMessage.GetHashCode();
                if (this.StartBranch != null) hashCode = hashCode * 59 + this.StartBranch.GetHashCode();
                if (this.AuthorEmail != null) hashCode = hashCode * 59 + this.AuthorEmail.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.PreviousPath != null) hashCode = hashCode * 59 + this.PreviousPath.GetHashCode();
                if (this.InferContent != null) hashCode = hashCode * 59 + this.InferContent.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Encoding != null) hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.LastCommitId != null) hashCode = hashCode * 59 + this.LastCommitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
