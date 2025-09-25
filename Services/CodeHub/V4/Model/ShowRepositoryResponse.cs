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
    /// Response Object
    /// </summary>
    public class ShowRepositoryResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：** 仓库开发模式。 **取值范围：** - normal - CR
        /// </summary>
        /// <value>**参数解释：** 仓库开发模式。 **取值范围：** - normal - CR</value>
        [JsonConverter(typeof(EnumClassConverter<DevelopModeEnum>))]
        public class DevelopModeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly DevelopModeEnum NORMAL = new DevelopModeEnum("normal");

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            public static readonly DevelopModeEnum CR = new DevelopModeEnum("CR");

            private static readonly Dictionary<string, DevelopModeEnum> StaticFields =
            new Dictionary<string, DevelopModeEnum>()
            {
                { "normal", NORMAL },
                { "CR", CR },
            };

            private string _value;

            public DevelopModeEnum()
            {

            }

            public DevelopModeEnum(string value)
            {
                _value = value;
            }

            public static DevelopModeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as DevelopModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DevelopModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DevelopModeEnum a, DevelopModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DevelopModeEnum a, DevelopModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 仓库描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 仓库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 仓库完整名称。
        /// </summary>
        [JsonProperty("name_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string NameWithNamespace { get; set; }

        /// <summary>
        /// **参数解释：** 仓库路径。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 仓库完整路径。
        /// </summary>
        [JsonProperty("path_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string PathWithNamespace { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 是否归档。
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// **参数解释：** 仓库ssh地址。
        /// </summary>
        [JsonProperty("ssh_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrlToRepo { get; set; }

        /// <summary>
        /// **参数解释：** 仓库http地址。
        /// </summary>
        [JsonProperty("http_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpUrlToRepo { get; set; }

        /// <summary>
        /// **参数解释：** 仓库页面链接。
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// **参数解释：** 仓库readme文件链接。
        /// </summary>
        [JsonProperty("readme_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadmeUrl { get; set; }

        /// <summary>
        /// **参数解释：** 仓库所属项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 仓库所属项目名称。
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释：** 仓库开发模式。 **取值范围：** - normal - CR
        /// </summary>
        [JsonProperty("develop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public DevelopModeEnum DevelopMode { get; set; }
        /// <summary>
        /// **参数解释：** 审核状态。
        /// </summary>
        [JsonProperty("moderation_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModerationResult { get; set; }

        /// <summary>
        /// **参数解释：** 仓库默认分支 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("default_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// **参数解释：** 仓库图标url **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("avatar_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// **参数解释：** 关注数 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("star_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? StarCount { get; set; }

        /// <summary>
        /// **参数解释：** fork数 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("forks_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForksCount { get; set; }

        /// <summary>
        /// **参数解释：** 开启issue数 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("open_issues_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenIssuesCount { get; set; }

        /// <summary>
        /// **参数解释：** 开启中的CR、MR数量 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("open_merge_requests_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenMergeRequestsCount { get; set; }

        /// <summary>
        /// **参数解释：** 最后活跃时间 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("last_activity_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivityAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public NamespaceBasicDto Namespace { get; set; }

        /// <summary>
        /// **参数解释：** 空仓库 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("empty_repo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmptyRepo { get; set; }

        /// <summary>
        /// **参数解释：** 是否已关注 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Starred { get; set; }

        /// <summary>
        /// **参数解释：** 仓库可见等级 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        /// <summary>
        /// **参数解释：** 仓库保密等级 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("security_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityTag { get; set; }

        /// <summary>
        /// **参数解释：** 仓库保密等级 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("security", NullValueHandling = NullValueHandling.Ignore)]
        public string Security { get; set; }

        /// <summary>
        /// **参数解释：** 网络类型 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public RepositoryUserBasicDto Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public RepositoryUserBasicDto Creator { get; set; }

        /// <summary>
        /// **参数解释：** 创建者ID **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("forked_from_repository", NullValueHandling = NullValueHandling.Ignore)]
        public RepositorySimpleDto ForkedFromRepository { get; set; }

        /// <summary>
        /// **参数解释：** 仓库唯一标识符。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// **参数解释：** 祖先仓库ID列表。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("ancestor_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AncestorIds { get; set; }

        /// <summary>
        /// **参数解释：** 祖先仓库名称列表。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("ancestor_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AncestorNames { get; set; }

        /// <summary>
        /// **参数解释：** 导入状态。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("import_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportStatus { get; set; }

        /// <summary>
        /// **参数解释：** 导入源地址。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("import_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportUrl { get; set; }

        /// <summary>
        /// **参数解释：** 导入错误信息。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("import_error", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportError { get; set; }

        /// <summary>
        /// **参数解释：** 仓库类型。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("repo_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoType { get; set; }

        /// <summary>
        /// **参数解释：** 是否仅在流水线成功时允许合并。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("only_allow_merge_if_pipeline_succeeds", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyAllowMergeIfPipelineSucceeds { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用访问请求。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("request_access_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequestAccessEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 是否仅在所有检视意见解决时允许合并。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("only_allow_merge_if_all_discussions_are_resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyAllowMergeIfAllDiscussionsAreResolved { get; set; }

        /// <summary>
        /// **参数解释：** 合并方法。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("merge_method", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeMethod { get; set; }

        /// <summary>
        /// **参数解释：** fork关联仓库列表。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("fork_network_repositories", NullValueHandling = NullValueHandling.Ignore)]
        public List<RepositoryIdentityDto> ForkNetworkRepositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionsDto Permissions { get; set; }

        /// <summary>
        /// **参数解释：** 仓库类型。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("repository_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public RepositoryStatisticsDto Statistics { get; set; }

        /// <summary>
        /// **参数解释：** 分支数量。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("branch_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BranchCount { get; set; }

        /// <summary>
        /// **参数解释：** Tag数量。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("tag_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TagCount { get; set; }

        /// <summary>
        /// **参数解释：** 标签数量。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("label_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LabelCount { get; set; }

        /// <summary>
        /// **参数解释：** 成员数量。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("member_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameWithNamespace: ").Append(NameWithNamespace).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  pathWithNamespace: ").Append(PathWithNamespace).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  sshUrlToRepo: ").Append(SshUrlToRepo).Append("\n");
            sb.Append("  httpUrlToRepo: ").Append(HttpUrlToRepo).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  readmeUrl: ").Append(ReadmeUrl).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  developMode: ").Append(DevelopMode).Append("\n");
            sb.Append("  moderationResult: ").Append(ModerationResult).Append("\n");
            sb.Append("  defaultBranch: ").Append(DefaultBranch).Append("\n");
            sb.Append("  avatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  starCount: ").Append(StarCount).Append("\n");
            sb.Append("  forksCount: ").Append(ForksCount).Append("\n");
            sb.Append("  openIssuesCount: ").Append(OpenIssuesCount).Append("\n");
            sb.Append("  openMergeRequestsCount: ").Append(OpenMergeRequestsCount).Append("\n");
            sb.Append("  lastActivityAt: ").Append(LastActivityAt).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  emptyRepo: ").Append(EmptyRepo).Append("\n");
            sb.Append("  starred: ").Append(Starred).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  securityTag: ").Append(SecurityTag).Append("\n");
            sb.Append("  security: ").Append(Security).Append("\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  forkedFromRepository: ").Append(ForkedFromRepository).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ancestorIds: ").Append(AncestorIds).Append("\n");
            sb.Append("  ancestorNames: ").Append(AncestorNames).Append("\n");
            sb.Append("  importStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  importUrl: ").Append(ImportUrl).Append("\n");
            sb.Append("  importError: ").Append(ImportError).Append("\n");
            sb.Append("  repoType: ").Append(RepoType).Append("\n");
            sb.Append("  onlyAllowMergeIfPipelineSucceeds: ").Append(OnlyAllowMergeIfPipelineSucceeds).Append("\n");
            sb.Append("  requestAccessEnabled: ").Append(RequestAccessEnabled).Append("\n");
            sb.Append("  onlyAllowMergeIfAllDiscussionsAreResolved: ").Append(OnlyAllowMergeIfAllDiscussionsAreResolved).Append("\n");
            sb.Append("  mergeMethod: ").Append(MergeMethod).Append("\n");
            sb.Append("  forkNetworkRepositories: ").Append(ForkNetworkRepositories).Append("\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("  repositoryType: ").Append(RepositoryType).Append("\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("  branchCount: ").Append(BranchCount).Append("\n");
            sb.Append("  tagCount: ").Append(TagCount).Append("\n");
            sb.Append("  labelCount: ").Append(LabelCount).Append("\n");
            sb.Append("  memberCount: ").Append(MemberCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NameWithNamespace != input.NameWithNamespace || (this.NameWithNamespace != null && !this.NameWithNamespace.Equals(input.NameWithNamespace))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.PathWithNamespace != input.PathWithNamespace || (this.PathWithNamespace != null && !this.PathWithNamespace.Equals(input.PathWithNamespace))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.SshUrlToRepo != input.SshUrlToRepo || (this.SshUrlToRepo != null && !this.SshUrlToRepo.Equals(input.SshUrlToRepo))) return false;
            if (this.HttpUrlToRepo != input.HttpUrlToRepo || (this.HttpUrlToRepo != null && !this.HttpUrlToRepo.Equals(input.HttpUrlToRepo))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.ReadmeUrl != input.ReadmeUrl || (this.ReadmeUrl != null && !this.ReadmeUrl.Equals(input.ReadmeUrl))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.DevelopMode != input.DevelopMode) return false;
            if (this.ModerationResult != input.ModerationResult || (this.ModerationResult != null && !this.ModerationResult.Equals(input.ModerationResult))) return false;
            if (this.DefaultBranch != input.DefaultBranch || (this.DefaultBranch != null && !this.DefaultBranch.Equals(input.DefaultBranch))) return false;
            if (this.AvatarUrl != input.AvatarUrl || (this.AvatarUrl != null && !this.AvatarUrl.Equals(input.AvatarUrl))) return false;
            if (this.StarCount != input.StarCount || (this.StarCount != null && !this.StarCount.Equals(input.StarCount))) return false;
            if (this.ForksCount != input.ForksCount || (this.ForksCount != null && !this.ForksCount.Equals(input.ForksCount))) return false;
            if (this.OpenIssuesCount != input.OpenIssuesCount || (this.OpenIssuesCount != null && !this.OpenIssuesCount.Equals(input.OpenIssuesCount))) return false;
            if (this.OpenMergeRequestsCount != input.OpenMergeRequestsCount || (this.OpenMergeRequestsCount != null && !this.OpenMergeRequestsCount.Equals(input.OpenMergeRequestsCount))) return false;
            if (this.LastActivityAt != input.LastActivityAt || (this.LastActivityAt != null && !this.LastActivityAt.Equals(input.LastActivityAt))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.EmptyRepo != input.EmptyRepo || (this.EmptyRepo != null && !this.EmptyRepo.Equals(input.EmptyRepo))) return false;
            if (this.Starred != input.Starred || (this.Starred != null && !this.Starred.Equals(input.Starred))) return false;
            if (this.Visibility != input.Visibility || (this.Visibility != null && !this.Visibility.Equals(input.Visibility))) return false;
            if (this.SecurityTag != input.SecurityTag || (this.SecurityTag != null && !this.SecurityTag.Equals(input.SecurityTag))) return false;
            if (this.Security != input.Security || (this.Security != null && !this.Security.Equals(input.Security))) return false;
            if (this.NetworkType != input.NetworkType || (this.NetworkType != null && !this.NetworkType.Equals(input.NetworkType))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.ForkedFromRepository != input.ForkedFromRepository || (this.ForkedFromRepository != null && !this.ForkedFromRepository.Equals(input.ForkedFromRepository))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.AncestorIds != input.AncestorIds || (this.AncestorIds != null && input.AncestorIds != null && !this.AncestorIds.SequenceEqual(input.AncestorIds))) return false;
            if (this.AncestorNames != input.AncestorNames || (this.AncestorNames != null && input.AncestorNames != null && !this.AncestorNames.SequenceEqual(input.AncestorNames))) return false;
            if (this.ImportStatus != input.ImportStatus || (this.ImportStatus != null && !this.ImportStatus.Equals(input.ImportStatus))) return false;
            if (this.ImportUrl != input.ImportUrl || (this.ImportUrl != null && !this.ImportUrl.Equals(input.ImportUrl))) return false;
            if (this.ImportError != input.ImportError || (this.ImportError != null && !this.ImportError.Equals(input.ImportError))) return false;
            if (this.RepoType != input.RepoType || (this.RepoType != null && !this.RepoType.Equals(input.RepoType))) return false;
            if (this.OnlyAllowMergeIfPipelineSucceeds != input.OnlyAllowMergeIfPipelineSucceeds || (this.OnlyAllowMergeIfPipelineSucceeds != null && !this.OnlyAllowMergeIfPipelineSucceeds.Equals(input.OnlyAllowMergeIfPipelineSucceeds))) return false;
            if (this.RequestAccessEnabled != input.RequestAccessEnabled || (this.RequestAccessEnabled != null && !this.RequestAccessEnabled.Equals(input.RequestAccessEnabled))) return false;
            if (this.OnlyAllowMergeIfAllDiscussionsAreResolved != input.OnlyAllowMergeIfAllDiscussionsAreResolved || (this.OnlyAllowMergeIfAllDiscussionsAreResolved != null && !this.OnlyAllowMergeIfAllDiscussionsAreResolved.Equals(input.OnlyAllowMergeIfAllDiscussionsAreResolved))) return false;
            if (this.MergeMethod != input.MergeMethod || (this.MergeMethod != null && !this.MergeMethod.Equals(input.MergeMethod))) return false;
            if (this.ForkNetworkRepositories != input.ForkNetworkRepositories || (this.ForkNetworkRepositories != null && input.ForkNetworkRepositories != null && !this.ForkNetworkRepositories.SequenceEqual(input.ForkNetworkRepositories))) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && !this.Permissions.Equals(input.Permissions))) return false;
            if (this.RepositoryType != input.RepositoryType || (this.RepositoryType != null && !this.RepositoryType.Equals(input.RepositoryType))) return false;
            if (this.Statistics != input.Statistics || (this.Statistics != null && !this.Statistics.Equals(input.Statistics))) return false;
            if (this.BranchCount != input.BranchCount || (this.BranchCount != null && !this.BranchCount.Equals(input.BranchCount))) return false;
            if (this.TagCount != input.TagCount || (this.TagCount != null && !this.TagCount.Equals(input.TagCount))) return false;
            if (this.LabelCount != input.LabelCount || (this.LabelCount != null && !this.LabelCount.Equals(input.LabelCount))) return false;
            if (this.MemberCount != input.MemberCount || (this.MemberCount != null && !this.MemberCount.Equals(input.MemberCount))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameWithNamespace != null) hashCode = hashCode * 59 + this.NameWithNamespace.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.PathWithNamespace != null) hashCode = hashCode * 59 + this.PathWithNamespace.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.SshUrlToRepo != null) hashCode = hashCode * 59 + this.SshUrlToRepo.GetHashCode();
                if (this.HttpUrlToRepo != null) hashCode = hashCode * 59 + this.HttpUrlToRepo.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.ReadmeUrl != null) hashCode = hashCode * 59 + this.ReadmeUrl.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                hashCode = hashCode * 59 + this.DevelopMode.GetHashCode();
                if (this.ModerationResult != null) hashCode = hashCode * 59 + this.ModerationResult.GetHashCode();
                if (this.DefaultBranch != null) hashCode = hashCode * 59 + this.DefaultBranch.GetHashCode();
                if (this.AvatarUrl != null) hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.StarCount != null) hashCode = hashCode * 59 + this.StarCount.GetHashCode();
                if (this.ForksCount != null) hashCode = hashCode * 59 + this.ForksCount.GetHashCode();
                if (this.OpenIssuesCount != null) hashCode = hashCode * 59 + this.OpenIssuesCount.GetHashCode();
                if (this.OpenMergeRequestsCount != null) hashCode = hashCode * 59 + this.OpenMergeRequestsCount.GetHashCode();
                if (this.LastActivityAt != null) hashCode = hashCode * 59 + this.LastActivityAt.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.EmptyRepo != null) hashCode = hashCode * 59 + this.EmptyRepo.GetHashCode();
                if (this.Starred != null) hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this.Visibility != null) hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.SecurityTag != null) hashCode = hashCode * 59 + this.SecurityTag.GetHashCode();
                if (this.Security != null) hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.NetworkType != null) hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.ForkedFromRepository != null) hashCode = hashCode * 59 + this.ForkedFromRepository.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.AncestorIds != null) hashCode = hashCode * 59 + this.AncestorIds.GetHashCode();
                if (this.AncestorNames != null) hashCode = hashCode * 59 + this.AncestorNames.GetHashCode();
                if (this.ImportStatus != null) hashCode = hashCode * 59 + this.ImportStatus.GetHashCode();
                if (this.ImportUrl != null) hashCode = hashCode * 59 + this.ImportUrl.GetHashCode();
                if (this.ImportError != null) hashCode = hashCode * 59 + this.ImportError.GetHashCode();
                if (this.RepoType != null) hashCode = hashCode * 59 + this.RepoType.GetHashCode();
                if (this.OnlyAllowMergeIfPipelineSucceeds != null) hashCode = hashCode * 59 + this.OnlyAllowMergeIfPipelineSucceeds.GetHashCode();
                if (this.RequestAccessEnabled != null) hashCode = hashCode * 59 + this.RequestAccessEnabled.GetHashCode();
                if (this.OnlyAllowMergeIfAllDiscussionsAreResolved != null) hashCode = hashCode * 59 + this.OnlyAllowMergeIfAllDiscussionsAreResolved.GetHashCode();
                if (this.MergeMethod != null) hashCode = hashCode * 59 + this.MergeMethod.GetHashCode();
                if (this.ForkNetworkRepositories != null) hashCode = hashCode * 59 + this.ForkNetworkRepositories.GetHashCode();
                if (this.Permissions != null) hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.RepositoryType != null) hashCode = hashCode * 59 + this.RepositoryType.GetHashCode();
                if (this.Statistics != null) hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                if (this.BranchCount != null) hashCode = hashCode * 59 + this.BranchCount.GetHashCode();
                if (this.TagCount != null) hashCode = hashCode * 59 + this.TagCount.GetHashCode();
                if (this.LabelCount != null) hashCode = hashCode * 59 + this.LabelCount.GetHashCode();
                if (this.MemberCount != null) hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
