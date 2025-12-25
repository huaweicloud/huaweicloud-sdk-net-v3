using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryDOV5 
    {

        /// <summary>
        /// **参数解释**: 仓库状态。 **取值范围**: active：正常。 delete：删除。 disabled：无效。 view：私有库浏览者。 trash：废弃。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**: 租户id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**: 区域。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**: 创建时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// **参数解释**: 修改时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// **参数解释**: 创建人id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("created_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUserId { get; set; }

        /// <summary>
        /// **参数解释**: 创建人。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("created_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUserName { get; set; }

        /// <summary>
        /// **参数解释**: 修改人id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("modified_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserId { get; set; }

        /// <summary>
        /// **参数解释**: 修改人。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("modified_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserName { get; set; }

        /// <summary>
        /// **参数解释**: 仓库名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// **参数解释**: 制品类型。 **取值范围**: - maven - maven2 - npm - go - pypi - rpm - composer - debian - conan - nuget - docker2 - cocoapods - ohpm - generic - helm - conda
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// **参数解释**: 仓库类型。 **取值范围**: hosted：本地仓库。 remote：代理仓库。 virtual：聚合仓库。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**: 仓库描述。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**: release仓库名称,release和snapshot至少二选一。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("release", NullValueHandling = NullValueHandling.Ignore)]
        public string Release { get; set; }

        /// <summary>
        /// **参数解释**: snapshot仓库名称,release和snapshot至少二选一。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public string Snapshot { get; set; }

        /// <summary>
        /// **参数解释**: 路径包含规则。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("includes_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludesPattern { get; set; }

        /// <summary>
        /// **参数解释**: 路径排除规则。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("excludes_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludesPattern { get; set; }

        /// <summary>
        /// **参数解释**: 共享权限级别。 **取值范围**: PROJECT。
        /// </summary>
        [JsonProperty("share_right", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareRight { get; set; }

        /// <summary>
        /// **参数解释**: 项目ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**: 仓库id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**: 是否禁用。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// **参数解释**: 仓库策略。 **取值范围**: release或snapshot。
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// **参数解释**: npm。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("npm", NullValueHandling = NullValueHandling.Ignore)]
        public string Npm { get; set; }

        /// <summary>
        /// **参数解释**: uri。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**: repositories。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("repositories", NullValueHandling = NullValueHandling.Ignore)]
        public string Repositories { get; set; }

        /// <summary>
        /// **参数解释**: 账号。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: 密码。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// **参数解释**: 代理。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("proxy", NullValueHandling = NullValueHandling.Ignore)]
        public string Proxy { get; set; }

        /// <summary>
        /// **参数解释**: 范围。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public int? Scope { get; set; }

        /// <summary>
        /// **参数解释**: 地址。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释**: 用于标记一对maven仓库(release、snapshot)，相同的tab_id即为一对maven仓库。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("tab_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TabId { get; set; }

        /// <summary>
        /// **参数解释**: 展示的仓库名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**: 快照仓状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("snapshot_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotStatus { get; set; }

        /// <summary>
        /// **参数解释**: 发布仓状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("release_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseStatus { get; set; }

        /// <summary>
        /// **参数解释**: 仓库id列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("repository_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryIds { get; set; }

        /// <summary>
        /// **参数解释**: 覆盖策略。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("deployment_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentPolicy { get; set; }

        /// <summary>
        /// **参数解释**: 父仓库名。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("parent_repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentRepoName { get; set; }

        /// <summary>
        /// **参数解释**: 代理仓地址。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("remote_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteUrl { get; set; }

        /// <summary>
        /// **参数解释**: 代理仓认证。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("remote_auth", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteAuth { get; set; }

        /// <summary>
        /// **参数解释**: pypi索引代理地址。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("pypi_registry_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PypiRegistryUrl { get; set; }

        /// <summary>
        /// **参数解释**: 虚仓的默认仓库。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("default_deploy_repository", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultDeployRepository { get; set; }

        /// <summary>
        /// **参数解释**: 制品类型。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// **参数解释**: 是否nexu仓库。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("nexu_repo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NexuRepo { get; set; }

        /// <summary>
        /// **参数解释**: 迁移标识。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("migrate_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrateFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryDOV5 {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  createdUserId: ").Append(CreatedUserId).Append("\n");
            sb.Append("  createdUserName: ").Append(CreatedUserName).Append("\n");
            sb.Append("  modifiedUserId: ").Append(ModifiedUserId).Append("\n");
            sb.Append("  modifiedUserName: ").Append(ModifiedUserName).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  release: ").Append(Release).Append("\n");
            sb.Append("  snapshot: ").Append(Snapshot).Append("\n");
            sb.Append("  includesPattern: ").Append(IncludesPattern).Append("\n");
            sb.Append("  excludesPattern: ").Append(ExcludesPattern).Append("\n");
            sb.Append("  shareRight: ").Append(ShareRight).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  npm: ").Append(Npm).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  repositories: ").Append(Repositories).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  proxy: ").Append(Proxy).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  tabId: ").Append(TabId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  snapshotStatus: ").Append(SnapshotStatus).Append("\n");
            sb.Append("  releaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  repositoryIds: ").Append(RepositoryIds).Append("\n");
            sb.Append("  deploymentPolicy: ").Append(DeploymentPolicy).Append("\n");
            sb.Append("  parentRepoName: ").Append(ParentRepoName).Append("\n");
            sb.Append("  remoteUrl: ").Append(RemoteUrl).Append("\n");
            sb.Append("  remoteAuth: ").Append(RemoteAuth).Append("\n");
            sb.Append("  pypiRegistryUrl: ").Append(PypiRegistryUrl).Append("\n");
            sb.Append("  defaultDeployRepository: ").Append(DefaultDeployRepository).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  nexuRepo: ").Append(NexuRepo).Append("\n");
            sb.Append("  migrateFlag: ").Append(MigrateFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryDOV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryDOV5 input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.CreatedUserId != input.CreatedUserId || (this.CreatedUserId != null && !this.CreatedUserId.Equals(input.CreatedUserId))) return false;
            if (this.CreatedUserName != input.CreatedUserName || (this.CreatedUserName != null && !this.CreatedUserName.Equals(input.CreatedUserName))) return false;
            if (this.ModifiedUserId != input.ModifiedUserId || (this.ModifiedUserId != null && !this.ModifiedUserId.Equals(input.ModifiedUserId))) return false;
            if (this.ModifiedUserName != input.ModifiedUserName || (this.ModifiedUserName != null && !this.ModifiedUserName.Equals(input.ModifiedUserName))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Release != input.Release || (this.Release != null && !this.Release.Equals(input.Release))) return false;
            if (this.Snapshot != input.Snapshot || (this.Snapshot != null && !this.Snapshot.Equals(input.Snapshot))) return false;
            if (this.IncludesPattern != input.IncludesPattern || (this.IncludesPattern != null && !this.IncludesPattern.Equals(input.IncludesPattern))) return false;
            if (this.ExcludesPattern != input.ExcludesPattern || (this.ExcludesPattern != null && !this.ExcludesPattern.Equals(input.ExcludesPattern))) return false;
            if (this.ShareRight != input.ShareRight || (this.ShareRight != null && !this.ShareRight.Equals(input.ShareRight))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.Npm != input.Npm || (this.Npm != null && !this.Npm.Equals(input.Npm))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Repositories != input.Repositories || (this.Repositories != null && !this.Repositories.Equals(input.Repositories))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.Proxy != input.Proxy || (this.Proxy != null && !this.Proxy.Equals(input.Proxy))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.TabId != input.TabId || (this.TabId != null && !this.TabId.Equals(input.TabId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.SnapshotStatus != input.SnapshotStatus || (this.SnapshotStatus != null && !this.SnapshotStatus.Equals(input.SnapshotStatus))) return false;
            if (this.ReleaseStatus != input.ReleaseStatus || (this.ReleaseStatus != null && !this.ReleaseStatus.Equals(input.ReleaseStatus))) return false;
            if (this.RepositoryIds != input.RepositoryIds || (this.RepositoryIds != null && !this.RepositoryIds.Equals(input.RepositoryIds))) return false;
            if (this.DeploymentPolicy != input.DeploymentPolicy || (this.DeploymentPolicy != null && !this.DeploymentPolicy.Equals(input.DeploymentPolicy))) return false;
            if (this.ParentRepoName != input.ParentRepoName || (this.ParentRepoName != null && !this.ParentRepoName.Equals(input.ParentRepoName))) return false;
            if (this.RemoteUrl != input.RemoteUrl || (this.RemoteUrl != null && !this.RemoteUrl.Equals(input.RemoteUrl))) return false;
            if (this.RemoteAuth != input.RemoteAuth || (this.RemoteAuth != null && !this.RemoteAuth.Equals(input.RemoteAuth))) return false;
            if (this.PypiRegistryUrl != input.PypiRegistryUrl || (this.PypiRegistryUrl != null && !this.PypiRegistryUrl.Equals(input.PypiRegistryUrl))) return false;
            if (this.DefaultDeployRepository != input.DefaultDeployRepository || (this.DefaultDeployRepository != null && !this.DefaultDeployRepository.Equals(input.DefaultDeployRepository))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.NexuRepo != input.NexuRepo || (this.NexuRepo != null && !this.NexuRepo.Equals(input.NexuRepo))) return false;
            if (this.MigrateFlag != input.MigrateFlag || (this.MigrateFlag != null && !this.MigrateFlag.Equals(input.MigrateFlag))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.CreatedUserId != null) hashCode = hashCode * 59 + this.CreatedUserId.GetHashCode();
                if (this.CreatedUserName != null) hashCode = hashCode * 59 + this.CreatedUserName.GetHashCode();
                if (this.ModifiedUserId != null) hashCode = hashCode * 59 + this.ModifiedUserId.GetHashCode();
                if (this.ModifiedUserName != null) hashCode = hashCode * 59 + this.ModifiedUserName.GetHashCode();
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Release != null) hashCode = hashCode * 59 + this.Release.GetHashCode();
                if (this.Snapshot != null) hashCode = hashCode * 59 + this.Snapshot.GetHashCode();
                if (this.IncludesPattern != null) hashCode = hashCode * 59 + this.IncludesPattern.GetHashCode();
                if (this.ExcludesPattern != null) hashCode = hashCode * 59 + this.ExcludesPattern.GetHashCode();
                if (this.ShareRight != null) hashCode = hashCode * 59 + this.ShareRight.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Npm != null) hashCode = hashCode * 59 + this.Npm.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Repositories != null) hashCode = hashCode * 59 + this.Repositories.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Proxy != null) hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.TabId != null) hashCode = hashCode * 59 + this.TabId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.SnapshotStatus != null) hashCode = hashCode * 59 + this.SnapshotStatus.GetHashCode();
                if (this.ReleaseStatus != null) hashCode = hashCode * 59 + this.ReleaseStatus.GetHashCode();
                if (this.RepositoryIds != null) hashCode = hashCode * 59 + this.RepositoryIds.GetHashCode();
                if (this.DeploymentPolicy != null) hashCode = hashCode * 59 + this.DeploymentPolicy.GetHashCode();
                if (this.ParentRepoName != null) hashCode = hashCode * 59 + this.ParentRepoName.GetHashCode();
                if (this.RemoteUrl != null) hashCode = hashCode * 59 + this.RemoteUrl.GetHashCode();
                if (this.RemoteAuth != null) hashCode = hashCode * 59 + this.RemoteAuth.GetHashCode();
                if (this.PypiRegistryUrl != null) hashCode = hashCode * 59 + this.PypiRegistryUrl.GetHashCode();
                if (this.DefaultDeployRepository != null) hashCode = hashCode * 59 + this.DefaultDeployRepository.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.NexuRepo != null) hashCode = hashCode * 59 + this.NexuRepo.GetHashCode();
                if (this.MigrateFlag != null) hashCode = hashCode * 59 + this.MigrateFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
