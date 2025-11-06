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
    public class RepositorySimplestDto 
    {

        /// <summary>
        /// **参数解释：** 仓库ID **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 仓库名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 命名空间。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释：** 仓库路径。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 开发模式。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("develop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopMode { get; set; }

        /// <summary>
        /// **参数解释：** 可见性。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        /// <summary>
        /// **参数解释：** 安全级别。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("security", NullValueHandling = NullValueHandling.Ignore)]
        public string Security { get; set; }

        /// <summary>
        /// **参数解释：** 关注数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("star_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? StarCount { get; set; }

        /// <summary>
        /// **参数解释：** Fork数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("forks_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForksCount { get; set; }

        /// <summary>
        /// **参数解释：** 开放的问题数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("open_issues_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenIssuesCount { get; set; }

        /// <summary>
        /// **参数解释：** 开放的合并请求数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("open_merge_requests_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenMergeRequestsCount { get; set; }

        /// <summary>
        /// **参数解释：** 是否已关注。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Starred { get; set; }

        /// <summary>
        /// **参数解释：** 包含命名空间的仓库名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("name_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string NameWithNamespace { get; set; }

        /// <summary>
        /// **参数解释：** 最后活跃时间。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("last_activity_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivityAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("forked_from_repository", NullValueHandling = NullValueHandling.Ignore)]
        public ForkedFromRepositorySimplestDto ForkedFromRepository { get; set; }

        /// <summary>
        /// **参数解释：** 权限。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Permissions { get; set; }

        /// <summary>
        /// **参数解释：** 是否归档。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// **参数解释：** 成员数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("member_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberCount { get; set; }

        /// <summary>
        /// **参数解释：** 仓库唯一标识符。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// **参数解释：** 仓库描述。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 最后更新时间。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("last_repository_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRepositoryUpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** SSH仓库URL。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("ssh_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrlToRepo { get; set; }

        /// <summary>
        /// **参数解释：** HTTP仓库URL。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("http_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpUrlToRepo { get; set; }

        /// <summary>
        /// **参数解释：** 仓库状态。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 活跃统计。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("active_statistic", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ActiveStatistic { get; set; }

        /// <summary>
        /// **参数解释：** 项目名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释：** 项目ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 项目是否删除。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("project_is_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProjectIsDelete { get; set; }

        /// <summary>
        /// **参数解释：** 创建者ID **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositorySimplestDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  developMode: ").Append(DevelopMode).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  security: ").Append(Security).Append("\n");
            sb.Append("  starCount: ").Append(StarCount).Append("\n");
            sb.Append("  forksCount: ").Append(ForksCount).Append("\n");
            sb.Append("  openIssuesCount: ").Append(OpenIssuesCount).Append("\n");
            sb.Append("  openMergeRequestsCount: ").Append(OpenMergeRequestsCount).Append("\n");
            sb.Append("  starred: ").Append(Starred).Append("\n");
            sb.Append("  nameWithNamespace: ").Append(NameWithNamespace).Append("\n");
            sb.Append("  lastActivityAt: ").Append(LastActivityAt).Append("\n");
            sb.Append("  forkedFromRepository: ").Append(ForkedFromRepository).Append("\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  memberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  lastRepositoryUpdatedAt: ").Append(LastRepositoryUpdatedAt).Append("\n");
            sb.Append("  sshUrlToRepo: ").Append(SshUrlToRepo).Append("\n");
            sb.Append("  httpUrlToRepo: ").Append(HttpUrlToRepo).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  activeStatistic: ").Append(ActiveStatistic).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectIsDelete: ").Append(ProjectIsDelete).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositorySimplestDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositorySimplestDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.DevelopMode != input.DevelopMode || (this.DevelopMode != null && !this.DevelopMode.Equals(input.DevelopMode))) return false;
            if (this.Visibility != input.Visibility || (this.Visibility != null && !this.Visibility.Equals(input.Visibility))) return false;
            if (this.Security != input.Security || (this.Security != null && !this.Security.Equals(input.Security))) return false;
            if (this.StarCount != input.StarCount || (this.StarCount != null && !this.StarCount.Equals(input.StarCount))) return false;
            if (this.ForksCount != input.ForksCount || (this.ForksCount != null && !this.ForksCount.Equals(input.ForksCount))) return false;
            if (this.OpenIssuesCount != input.OpenIssuesCount || (this.OpenIssuesCount != null && !this.OpenIssuesCount.Equals(input.OpenIssuesCount))) return false;
            if (this.OpenMergeRequestsCount != input.OpenMergeRequestsCount || (this.OpenMergeRequestsCount != null && !this.OpenMergeRequestsCount.Equals(input.OpenMergeRequestsCount))) return false;
            if (this.Starred != input.Starred || (this.Starred != null && !this.Starred.Equals(input.Starred))) return false;
            if (this.NameWithNamespace != input.NameWithNamespace || (this.NameWithNamespace != null && !this.NameWithNamespace.Equals(input.NameWithNamespace))) return false;
            if (this.LastActivityAt != input.LastActivityAt || (this.LastActivityAt != null && !this.LastActivityAt.Equals(input.LastActivityAt))) return false;
            if (this.ForkedFromRepository != input.ForkedFromRepository || (this.ForkedFromRepository != null && !this.ForkedFromRepository.Equals(input.ForkedFromRepository))) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && !this.Permissions.Equals(input.Permissions))) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.MemberCount != input.MemberCount || (this.MemberCount != null && !this.MemberCount.Equals(input.MemberCount))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LastRepositoryUpdatedAt != input.LastRepositoryUpdatedAt || (this.LastRepositoryUpdatedAt != null && !this.LastRepositoryUpdatedAt.Equals(input.LastRepositoryUpdatedAt))) return false;
            if (this.SshUrlToRepo != input.SshUrlToRepo || (this.SshUrlToRepo != null && !this.SshUrlToRepo.Equals(input.SshUrlToRepo))) return false;
            if (this.HttpUrlToRepo != input.HttpUrlToRepo || (this.HttpUrlToRepo != null && !this.HttpUrlToRepo.Equals(input.HttpUrlToRepo))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ActiveStatistic != input.ActiveStatistic || (this.ActiveStatistic != null && input.ActiveStatistic != null && !this.ActiveStatistic.SequenceEqual(input.ActiveStatistic))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectIsDelete != input.ProjectIsDelete || (this.ProjectIsDelete != null && !this.ProjectIsDelete.Equals(input.ProjectIsDelete))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.DevelopMode != null) hashCode = hashCode * 59 + this.DevelopMode.GetHashCode();
                if (this.Visibility != null) hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.Security != null) hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.StarCount != null) hashCode = hashCode * 59 + this.StarCount.GetHashCode();
                if (this.ForksCount != null) hashCode = hashCode * 59 + this.ForksCount.GetHashCode();
                if (this.OpenIssuesCount != null) hashCode = hashCode * 59 + this.OpenIssuesCount.GetHashCode();
                if (this.OpenMergeRequestsCount != null) hashCode = hashCode * 59 + this.OpenMergeRequestsCount.GetHashCode();
                if (this.Starred != null) hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this.NameWithNamespace != null) hashCode = hashCode * 59 + this.NameWithNamespace.GetHashCode();
                if (this.LastActivityAt != null) hashCode = hashCode * 59 + this.LastActivityAt.GetHashCode();
                if (this.ForkedFromRepository != null) hashCode = hashCode * 59 + this.ForkedFromRepository.GetHashCode();
                if (this.Permissions != null) hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.MemberCount != null) hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastRepositoryUpdatedAt != null) hashCode = hashCode * 59 + this.LastRepositoryUpdatedAt.GetHashCode();
                if (this.SshUrlToRepo != null) hashCode = hashCode * 59 + this.SshUrlToRepo.GetHashCode();
                if (this.HttpUrlToRepo != null) hashCode = hashCode * 59 + this.HttpUrlToRepo.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ActiveStatistic != null) hashCode = hashCode * 59 + this.ActiveStatistic.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectIsDelete != null) hashCode = hashCode * 59 + this.ProjectIsDelete.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
