using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// **参数解释**： 流水线源参数。 **取值范围**： 不涉及。 
    /// </summary>
    public class PipelineSourceParam 
    {

        /// <summary>
        /// **参数解释**： 代码/制品源参数 - 代码仓/制品源别名。 **取值范围**： 别名仅支持输入大小写英文字母、数字、“_”，至多128个字符。 
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// **参数解释**： git代码仓类型。 **取值范围**： - codehub。 - gitee。 - github。 - gitcode。 - gitlab。 
        /// </summary>
        [JsonProperty("git_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GitType { get; set; }

        /// <summary>
        /// **参数解释**： Repo代码仓ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("codehub_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodehubId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展点id。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// **参数解释**： 默认分支。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("default_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// **参数解释**： git链接。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释**： ssh_git链接。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("ssh_git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SshGitUrl { get; set; }

        /// <summary>
        /// **参数解释**： 网页url。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// **参数解释**： 流水线源名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// **参数解释**： 制品源类型。 **取值范围**： 仅包含[generic，docker]。 
        /// </summary>
        [JsonProperty("artifact_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// **参数解释**： 制品源类型名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("artifact_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactTypeName { get; set; }

        /// <summary>
        /// **参数解释**： 过滤分支。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("branch_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchFilter { get; set; }

        /// <summary>
        /// **参数解释**： 制品源所在目录。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("directory", NullValueHandling = NullValueHandling.Ignore)]
        public string Directory { get; set; }

        /// <summary>
        /// **参数解释**： 目录ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("directory_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// **参数解释**： Docker组织。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// **参数解释**： 软件包名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// **参数解释**： 制品源版本。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 获取制品源版本的策略。 **取值范围**： 仅包含[latest，specificVersion]。 
        /// </summary>
        [JsonProperty("version_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionStrategy { get; set; }

        /// <summary>
        /// **参数解释**： 制品源名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("source_system", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSystem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineSourceParam {\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  gitType: ").Append(GitType).Append("\n");
            sb.Append("  codehubId: ").Append(CodehubId).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  defaultBranch: ").Append(DefaultBranch).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  sshGitUrl: ").Append(SshGitUrl).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  artifactType: ").Append(ArtifactType).Append("\n");
            sb.Append("  artifactTypeName: ").Append(ArtifactTypeName).Append("\n");
            sb.Append("  branchFilter: ").Append(BranchFilter).Append("\n");
            sb.Append("  directory: ").Append(Directory).Append("\n");
            sb.Append("  directoryId: ").Append(DirectoryId).Append("\n");
            sb.Append("  organization: ").Append(Organization).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionStrategy: ").Append(VersionStrategy).Append("\n");
            sb.Append("  sourceSystem: ").Append(SourceSystem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineSourceParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineSourceParam input)
        {
            if (input == null) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.GitType != input.GitType || (this.GitType != null && !this.GitType.Equals(input.GitType))) return false;
            if (this.CodehubId != input.CodehubId || (this.CodehubId != null && !this.CodehubId.Equals(input.CodehubId))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.DefaultBranch != input.DefaultBranch || (this.DefaultBranch != null && !this.DefaultBranch.Equals(input.DefaultBranch))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.SshGitUrl != input.SshGitUrl || (this.SshGitUrl != null && !this.SshGitUrl.Equals(input.SshGitUrl))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.ArtifactType != input.ArtifactType || (this.ArtifactType != null && !this.ArtifactType.Equals(input.ArtifactType))) return false;
            if (this.ArtifactTypeName != input.ArtifactTypeName || (this.ArtifactTypeName != null && !this.ArtifactTypeName.Equals(input.ArtifactTypeName))) return false;
            if (this.BranchFilter != input.BranchFilter || (this.BranchFilter != null && !this.BranchFilter.Equals(input.BranchFilter))) return false;
            if (this.Directory != input.Directory || (this.Directory != null && !this.Directory.Equals(input.Directory))) return false;
            if (this.DirectoryId != input.DirectoryId || (this.DirectoryId != null && !this.DirectoryId.Equals(input.DirectoryId))) return false;
            if (this.Organization != input.Organization || (this.Organization != null && !this.Organization.Equals(input.Organization))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionStrategy != input.VersionStrategy || (this.VersionStrategy != null && !this.VersionStrategy.Equals(input.VersionStrategy))) return false;
            if (this.SourceSystem != input.SourceSystem || (this.SourceSystem != null && !this.SourceSystem.Equals(input.SourceSystem))) return false;

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
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.GitType != null) hashCode = hashCode * 59 + this.GitType.GetHashCode();
                if (this.CodehubId != null) hashCode = hashCode * 59 + this.CodehubId.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.DefaultBranch != null) hashCode = hashCode * 59 + this.DefaultBranch.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.SshGitUrl != null) hashCode = hashCode * 59 + this.SshGitUrl.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.ArtifactType != null) hashCode = hashCode * 59 + this.ArtifactType.GetHashCode();
                if (this.ArtifactTypeName != null) hashCode = hashCode * 59 + this.ArtifactTypeName.GetHashCode();
                if (this.BranchFilter != null) hashCode = hashCode * 59 + this.BranchFilter.GetHashCode();
                if (this.Directory != null) hashCode = hashCode * 59 + this.Directory.GetHashCode();
                if (this.DirectoryId != null) hashCode = hashCode * 59 + this.DirectoryId.GetHashCode();
                if (this.Organization != null) hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionStrategy != null) hashCode = hashCode * 59 + this.VersionStrategy.GetHashCode();
                if (this.SourceSystem != null) hashCode = hashCode * 59 + this.SourceSystem.GetHashCode();
                return hashCode;
            }
        }
    }
}
