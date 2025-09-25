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
    /// 
    /// </summary>
    public class RepositoryDirDto 
    {

        /// <summary>
        /// **参数解释：** 目录路径。 **约束限制：** 目录路径层级最大不能超过29。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释：** 分支名。 **取值范围：** 最小1个字节，最大200字节 **约束限制：** 该仓库下的已有分支。
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryDirDto {\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  commitMessage: ").Append(CommitMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryDirDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryDirDto input)
        {
            if (input == null) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.CommitMessage != input.CommitMessage || (this.CommitMessage != null && !this.CommitMessage.Equals(input.CommitMessage))) return false;

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
                return hashCode;
            }
        }
    }
}
