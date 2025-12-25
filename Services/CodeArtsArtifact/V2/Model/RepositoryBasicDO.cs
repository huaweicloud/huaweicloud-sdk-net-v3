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
    public class RepositoryBasicDO 
    {

        /// <summary>
        /// **参数解释**： ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 仓库状态。 **取值范围**： - active：正常。 - delete：删除。 - disabled：无效。 - view：可浏览。 - trash：废弃。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domainId", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 区域。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("createdTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// **参数解释**： 修改时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("modifiedTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// **参数解释**： 创建人ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("createdUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUserId { get; set; }

        /// <summary>
        /// **参数解释**： 创建人名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("createdUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUserName { get; set; }

        /// <summary>
        /// **参数解释**： 修改人ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("modifiedUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserId { get; set; }

        /// <summary>
        /// **参数解释**： 修改人名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("modifiedUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserName { get; set; }

        /// <summary>
        /// **参数解释**： 仓库ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 是否禁用。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// **参数解释**： 制品类型。 **取值范围**： - maven - maven2 - npm - go - pypi - rpm - composer - debian - conan - nuget - docker2 - cocoapods - ohpm - generic - helm - conda - huggingfaceml
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// **参数解释**： 仓库类型。 **取值范围**： - hosted：本地仓库。 - remote：代理仓库。 - virtual：虚拟仓库。
        /// </summary>
        [JsonProperty("repoType", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoType { get; set; }

        /// <summary>
        /// **参数解释**： 仓库策略。 **取值范围**： - release：正式仓库。 - snapshot：快照仓库。
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// **参数解释**： 用于标记一对Maven仓库(release、snapshot)，相同的tab_id即为一对Maven仓库。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tabId", NullValueHandling = NullValueHandling.Ignore)]
        public string TabId { get; set; }

        /// <summary>
        /// **参数解释**： 仓库名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("repositoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// **参数解释**： 展示的仓库名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 仓库描述。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 项目id。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 路径包含规则。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("includesPattern", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludesPattern { get; set; }

        /// <summary>
        /// **参数解释**： 覆盖策略。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("deploymentPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentPolicy { get; set; }

        /// <summary>
        /// **参数解释**： 共享权限级别。 **取值范围**： PROJECT
        /// </summary>
        [JsonProperty("shareRight", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareRight { get; set; }

        /// <summary>
        /// **参数解释**： 仓库地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释**： 制品类型。 **取值范围**： - maven - maven2 - npm - go - pypi - rpm - composer - debian - conan - nuget - docker2 - cocoapods - ohpm - generic - helm - conda - huggingfaceml
        /// </summary>
        [JsonProperty("packageType", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storageSummaryInfo", NullValueHandling = NullValueHandling.Ignore)]
        public DownloadFolderInfo StorageSummaryInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryBasicDO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  createdUserId: ").Append(CreatedUserId).Append("\n");
            sb.Append("  createdUserName: ").Append(CreatedUserName).Append("\n");
            sb.Append("  modifiedUserId: ").Append(ModifiedUserId).Append("\n");
            sb.Append("  modifiedUserName: ").Append(ModifiedUserName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  repoType: ").Append(RepoType).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  tabId: ").Append(TabId).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  includesPattern: ").Append(IncludesPattern).Append("\n");
            sb.Append("  deploymentPolicy: ").Append(DeploymentPolicy).Append("\n");
            sb.Append("  shareRight: ").Append(ShareRight).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  storageSummaryInfo: ").Append(StorageSummaryInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryBasicDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryBasicDO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.CreatedUserId != input.CreatedUserId || (this.CreatedUserId != null && !this.CreatedUserId.Equals(input.CreatedUserId))) return false;
            if (this.CreatedUserName != input.CreatedUserName || (this.CreatedUserName != null && !this.CreatedUserName.Equals(input.CreatedUserName))) return false;
            if (this.ModifiedUserId != input.ModifiedUserId || (this.ModifiedUserId != null && !this.ModifiedUserId.Equals(input.ModifiedUserId))) return false;
            if (this.ModifiedUserName != input.ModifiedUserName || (this.ModifiedUserName != null && !this.ModifiedUserName.Equals(input.ModifiedUserName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.RepoType != input.RepoType || (this.RepoType != null && !this.RepoType.Equals(input.RepoType))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.TabId != input.TabId || (this.TabId != null && !this.TabId.Equals(input.TabId))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IncludesPattern != input.IncludesPattern || (this.IncludesPattern != null && !this.IncludesPattern.Equals(input.IncludesPattern))) return false;
            if (this.DeploymentPolicy != input.DeploymentPolicy || (this.DeploymentPolicy != null && !this.DeploymentPolicy.Equals(input.DeploymentPolicy))) return false;
            if (this.ShareRight != input.ShareRight || (this.ShareRight != null && !this.ShareRight.Equals(input.ShareRight))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.StorageSummaryInfo != input.StorageSummaryInfo || (this.StorageSummaryInfo != null && !this.StorageSummaryInfo.Equals(input.StorageSummaryInfo))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.CreatedUserId != null) hashCode = hashCode * 59 + this.CreatedUserId.GetHashCode();
                if (this.CreatedUserName != null) hashCode = hashCode * 59 + this.CreatedUserName.GetHashCode();
                if (this.ModifiedUserId != null) hashCode = hashCode * 59 + this.ModifiedUserId.GetHashCode();
                if (this.ModifiedUserName != null) hashCode = hashCode * 59 + this.ModifiedUserName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.RepoType != null) hashCode = hashCode * 59 + this.RepoType.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.TabId != null) hashCode = hashCode * 59 + this.TabId.GetHashCode();
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IncludesPattern != null) hashCode = hashCode * 59 + this.IncludesPattern.GetHashCode();
                if (this.DeploymentPolicy != null) hashCode = hashCode * 59 + this.DeploymentPolicy.GetHashCode();
                if (this.ShareRight != null) hashCode = hashCode * 59 + this.ShareRight.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.StorageSummaryInfo != null) hashCode = hashCode * 59 + this.StorageSummaryInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
