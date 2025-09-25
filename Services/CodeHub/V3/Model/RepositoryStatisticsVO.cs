using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryStatisticsVO 
    {

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("repoName", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 提交次数
        /// </summary>
        [JsonProperty("commitCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitCount { get; set; }

        /// <summary>
        /// 仓库容量
        /// </summary>
        [JsonProperty("repoSize", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoSize { get; set; }

        /// <summary>
        /// 最近一次提交时间
        /// </summary>
        [JsonProperty("lastCommitTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCommitTime { get; set; }

        /// <summary>
        /// 代码行数
        /// </summary>
        [JsonProperty("codeLines", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLines { get; set; }

        /// <summary>
        /// 分支数量
        /// </summary>
        [JsonProperty("branchCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? BranchCount { get; set; }

        /// <summary>
        /// 代码仓下载地址
        /// </summary>
        [JsonProperty("archiveUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchiveUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryStatisticsVO {\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  commitCount: ").Append(CommitCount).Append("\n");
            sb.Append("  repoSize: ").Append(RepoSize).Append("\n");
            sb.Append("  lastCommitTime: ").Append(LastCommitTime).Append("\n");
            sb.Append("  codeLines: ").Append(CodeLines).Append("\n");
            sb.Append("  branchCount: ").Append(BranchCount).Append("\n");
            sb.Append("  archiveUrl: ").Append(ArchiveUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryStatisticsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryStatisticsVO input)
        {
            if (input == null) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.CommitCount != input.CommitCount || (this.CommitCount != null && !this.CommitCount.Equals(input.CommitCount))) return false;
            if (this.RepoSize != input.RepoSize || (this.RepoSize != null && !this.RepoSize.Equals(input.RepoSize))) return false;
            if (this.LastCommitTime != input.LastCommitTime || (this.LastCommitTime != null && !this.LastCommitTime.Equals(input.LastCommitTime))) return false;
            if (this.CodeLines != input.CodeLines || (this.CodeLines != null && !this.CodeLines.Equals(input.CodeLines))) return false;
            if (this.BranchCount != input.BranchCount || (this.BranchCount != null && !this.BranchCount.Equals(input.BranchCount))) return false;
            if (this.ArchiveUrl != input.ArchiveUrl || (this.ArchiveUrl != null && !this.ArchiveUrl.Equals(input.ArchiveUrl))) return false;

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
                if (this.ArchiveUrl != null) hashCode = hashCode * 59 + this.ArchiveUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
