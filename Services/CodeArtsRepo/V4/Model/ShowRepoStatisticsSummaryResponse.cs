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
    /// Response Object
    /// </summary>
    public class ShowRepoStatisticsSummaryResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 仓库名称。 **取值范围：** 最小1个字节，最大200字节 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// **参数解释：** 默认分支的提交数量。 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("commit_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitCount { get; set; }

        /// <summary>
        /// **参数解释：** 仓库占用磁盘空间大小。 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("repo_size", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoSize { get; set; }

        /// <summary>
        /// **参数解释：** 仓库最新的提交日期，格式yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX,例：2025-10-30T08:27:43.000Z **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("last_commit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCommitTime { get; set; }

        /// <summary>
        /// **参数解释：** 默认分支的代码行数。 **取值范围：** 最小0 **默认取值：** 0。
        /// </summary>
        [JsonProperty("code_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLines { get; set; }

        /// <summary>
        /// **参数解释：** 仓库分支数量 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("branch_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BranchCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepoStatisticsSummaryResponse {\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  commitCount: ").Append(CommitCount).Append("\n");
            sb.Append("  repoSize: ").Append(RepoSize).Append("\n");
            sb.Append("  lastCommitTime: ").Append(LastCommitTime).Append("\n");
            sb.Append("  codeLines: ").Append(CodeLines).Append("\n");
            sb.Append("  branchCount: ").Append(BranchCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepoStatisticsSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepoStatisticsSummaryResponse input)
        {
            if (input == null) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.CommitCount != input.CommitCount || (this.CommitCount != null && !this.CommitCount.Equals(input.CommitCount))) return false;
            if (this.RepoSize != input.RepoSize || (this.RepoSize != null && !this.RepoSize.Equals(input.RepoSize))) return false;
            if (this.LastCommitTime != input.LastCommitTime || (this.LastCommitTime != null && !this.LastCommitTime.Equals(input.LastCommitTime))) return false;
            if (this.CodeLines != input.CodeLines || (this.CodeLines != null && !this.CodeLines.Equals(input.CodeLines))) return false;
            if (this.BranchCount != input.BranchCount || (this.BranchCount != null && !this.BranchCount.Equals(input.BranchCount))) return false;

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
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.CommitCount != null) hashCode = hashCode * 59 + this.CommitCount.GetHashCode();
                if (this.RepoSize != null) hashCode = hashCode * 59 + this.RepoSize.GetHashCode();
                if (this.LastCommitTime != null) hashCode = hashCode * 59 + this.LastCommitTime.GetHashCode();
                if (this.CodeLines != null) hashCode = hashCode * 59 + this.CodeLines.GetHashCode();
                if (this.BranchCount != null) hashCode = hashCode * 59 + this.BranchCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
