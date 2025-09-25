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
    public class SubmoduleDto 
    {

        /// <summary>
        /// **参数解释：** 仓库ID。
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepoId { get; set; }

        /// <summary>
        /// **参数解释：** 分支名。 **取值范围：** 最小1个字节，最大200字节。
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// **参数解释：** 分支名。 **取值范围：** 最小1个字节，最大200字节
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 子模块Git地址。
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释：** 子模块分支名。 **取值范围：** 最小1个字节，最大200字节。
        /// </summary>
        [JsonProperty("submodule_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmoduleBranch { get; set; }

        /// <summary>
        /// 组织名/组织名.../仓库名
        /// </summary>
        [JsonProperty("namespace_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string NamespaceUuid { get; set; }

        /// <summary>
        /// **参数解释：** 子模块仓库ID。
        /// </summary>
        [JsonProperty("submodule_repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubmoduleRepoId { get; set; }

        /// <summary>
        /// **参数解释：** 子模块仓库名称。
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// **参数解释：** 子模块仓库提交。
        /// </summary>
        [JsonProperty("sub_commitId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCommitId { get; set; }

        /// <summary>
        /// **参数解释：** 部署秘钥同步状态。 **取值范围：** - 0，不同步。 - 1，同步。
        /// </summary>
        [JsonProperty("deployKey_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeployKeyStatus { get; set; }

        /// <summary>
        /// **参数解释：** 子模块状态。 **取值范围：** - 0，异常。 - 1，正常。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmoduleDto {\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  submoduleBranch: ").Append(SubmoduleBranch).Append("\n");
            sb.Append("  namespaceUuid: ").Append(NamespaceUuid).Append("\n");
            sb.Append("  submoduleRepoId: ").Append(SubmoduleRepoId).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  subCommitId: ").Append(SubCommitId).Append("\n");
            sb.Append("  deployKeyStatus: ").Append(DeployKeyStatus).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubmoduleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubmoduleDto input)
        {
            if (input == null) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.SubmoduleBranch != input.SubmoduleBranch || (this.SubmoduleBranch != null && !this.SubmoduleBranch.Equals(input.SubmoduleBranch))) return false;
            if (this.NamespaceUuid != input.NamespaceUuid || (this.NamespaceUuid != null && !this.NamespaceUuid.Equals(input.NamespaceUuid))) return false;
            if (this.SubmoduleRepoId != input.SubmoduleRepoId || (this.SubmoduleRepoId != null && !this.SubmoduleRepoId.Equals(input.SubmoduleRepoId))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.SubCommitId != input.SubCommitId || (this.SubCommitId != null && !this.SubCommitId.Equals(input.SubCommitId))) return false;
            if (this.DeployKeyStatus != input.DeployKeyStatus || (this.DeployKeyStatus != null && !this.DeployKeyStatus.Equals(input.DeployKeyStatus))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.SubmoduleBranch != null) hashCode = hashCode * 59 + this.SubmoduleBranch.GetHashCode();
                if (this.NamespaceUuid != null) hashCode = hashCode * 59 + this.NamespaceUuid.GetHashCode();
                if (this.SubmoduleRepoId != null) hashCode = hashCode * 59 + this.SubmoduleRepoId.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.SubCommitId != null) hashCode = hashCode * 59 + this.SubCommitId.GetHashCode();
                if (this.DeployKeyStatus != null) hashCode = hashCode * 59 + this.DeployKeyStatus.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
