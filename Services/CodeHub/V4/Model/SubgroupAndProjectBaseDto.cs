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
    /// A empty base object for subgroup and project.
    /// </summary>
    public class SubgroupAndProjectBaseDto 
    {

        /// <summary>
        /// **参数解释：** 项目id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 项目名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释：** 角色中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_namecn", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleNamecn { get; set; }

        /// <summary>
        /// **参数解释：** 角色英文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_nameen", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleNameen { get; set; }

        /// <summary>
        /// **参数解释：** 全名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// **参数解释：** 全路径。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("full_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FullPath { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间戳。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("updated_at_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAtTimestamp { get; set; }

        /// <summary>
        /// **参数解释：** 开始时间戳。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("star_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StarTime { get; set; }

        /// <summary>
        /// **参数解释：** 是否收藏。
        /// </summary>
        [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Starred { get; set; }

        /// <summary>
        /// **参数解释：** 开发模式，cr,\&quot;normal\&quot;。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("develop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopMode { get; set; }

        /// <summary>
        /// **参数解释：** 仓库或者代码组id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 代码组或仓库名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 路径。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 代码组层级。
        /// </summary>
        [JsonProperty("group_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupLevel { get; set; }

        /// <summary>
        /// **参数解释：** 代码组或仓库描述。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 子代码组数量。
        /// </summary>
        [JsonProperty("subgroup_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubgroupCount { get; set; }

        /// <summary>
        /// **参数解释：** 仓库数量。
        /// </summary>
        [JsonProperty("project_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectCount { get; set; }

        /// <summary>
        /// **参数解释：** 代码组角色。
        /// </summary>
        [JsonProperty("group_role", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupRole { get; set; }

        /// <summary>
        /// **参数解释：** 代码组成员数量。
        /// </summary>
        [JsonProperty("group_members_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupMembersCount { get; set; }

        /// <summary>
        /// **参数解释：** 资源类型 group,project。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("descendant_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DescendantType { get; set; }

        /// <summary>
        /// **参数解释：** 可见性level 0(私有),20(公开)
        /// </summary>
        [JsonProperty("visibility_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// **参数解释：** 可见性 private public。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        /// <summary>
        /// **参数解释：** 当前用户是否为项目创建者。
        /// </summary>
        [JsonProperty("is_project_admin", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsProjectAdmin { get; set; }

        /// <summary>
        /// **参数解释：** 当前用户是否为代码组创建者。
        /// </summary>
        [JsonProperty("is_group_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsGroupCreator { get; set; }

        /// <summary>
        /// **参数解释：** 当前用户是否为仓库创建者。
        /// </summary>
        [JsonProperty("is_repo_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsRepoCreator { get; set; }

        /// <summary>
        /// **参数解释：** 角色展示标记。
        /// </summary>
        [JsonProperty("role_show_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleShowFlag { get; set; }

        /// <summary>
        /// **参数解释：** 仓库的uuid。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// **参数解释：** fork数量。
        /// </summary>
        [JsonProperty("forks_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForksCount { get; set; }

        /// <summary>
        /// **参数解释：** 是否为kia。
        /// </summary>
        [JsonProperty("is_kia", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsKia { get; set; }

        /// <summary>
        /// **参数解释：** 是否为所有者。
        /// </summary>
        [JsonProperty("is_owner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// **参数解释：** 是否为存档。
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// **参数解释：** 仓库的最后更新时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("last_repository_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRepositoryUpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 开启的mr数量。
        /// </summary>
        [JsonProperty("open_merge_requests_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenMergeRequestsCount { get; set; }

        /// <summary>
        /// **参数解释：** 所有的mr数量。
        /// </summary>
        [JsonProperty("all_merge_requests_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllMergeRequestsCount { get; set; }

        /// <summary>
        /// **参数解释：** 仓库角色。
        /// </summary>
        [JsonProperty("project_role", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectRole { get; set; }

        /// <summary>
        /// **参数解释：** fork数量。
        /// </summary>
        [JsonProperty("project_members_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectMembersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project_creator", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectCreatorDto ProjectCreator { get; set; }

        /// <summary>
        /// **参数解释：** fork数量。
        /// </summary>
        [JsonProperty("star_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? StarCount { get; set; }

        /// <summary>
        /// **参数解释：** tag列表。
        /// </summary>
        [JsonProperty("tag_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagList { get; set; }

        /// <summary>
        /// **参数解释：** 仓库的http url。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("http_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpUrlToRepo { get; set; }

        /// <summary>
        /// **参数解释：** 仓库的ssh url。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("ssh_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrlToRepo { get; set; }

        /// <summary>
        /// **参数解释：** 状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释：** 活跃统计。
        /// </summary>
        [JsonProperty("active_statistic", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ActiveStatistic { get; set; }

        /// <summary>
        /// **参数解释：** 安全标签。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("security_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubgroupAndProjectBaseDto {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  roleNamecn: ").Append(RoleNamecn).Append("\n");
            sb.Append("  roleNameen: ").Append(RoleNameen).Append("\n");
            sb.Append("  fullName: ").Append(FullName).Append("\n");
            sb.Append("  fullPath: ").Append(FullPath).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAtTimestamp: ").Append(UpdatedAtTimestamp).Append("\n");
            sb.Append("  starTime: ").Append(StarTime).Append("\n");
            sb.Append("  starred: ").Append(Starred).Append("\n");
            sb.Append("  developMode: ").Append(DevelopMode).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  groupLevel: ").Append(GroupLevel).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  subgroupCount: ").Append(SubgroupCount).Append("\n");
            sb.Append("  projectCount: ").Append(ProjectCount).Append("\n");
            sb.Append("  groupRole: ").Append(GroupRole).Append("\n");
            sb.Append("  groupMembersCount: ").Append(GroupMembersCount).Append("\n");
            sb.Append("  descendantType: ").Append(DescendantType).Append("\n");
            sb.Append("  visibilityLevel: ").Append(VisibilityLevel).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  isProjectAdmin: ").Append(IsProjectAdmin).Append("\n");
            sb.Append("  isGroupCreator: ").Append(IsGroupCreator).Append("\n");
            sb.Append("  isRepoCreator: ").Append(IsRepoCreator).Append("\n");
            sb.Append("  roleShowFlag: ").Append(RoleShowFlag).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  forksCount: ").Append(ForksCount).Append("\n");
            sb.Append("  isKia: ").Append(IsKia).Append("\n");
            sb.Append("  isOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  lastRepositoryUpdatedAt: ").Append(LastRepositoryUpdatedAt).Append("\n");
            sb.Append("  openMergeRequestsCount: ").Append(OpenMergeRequestsCount).Append("\n");
            sb.Append("  allMergeRequestsCount: ").Append(AllMergeRequestsCount).Append("\n");
            sb.Append("  projectRole: ").Append(ProjectRole).Append("\n");
            sb.Append("  projectMembersCount: ").Append(ProjectMembersCount).Append("\n");
            sb.Append("  projectCreator: ").Append(ProjectCreator).Append("\n");
            sb.Append("  starCount: ").Append(StarCount).Append("\n");
            sb.Append("  tagList: ").Append(TagList).Append("\n");
            sb.Append("  httpUrlToRepo: ").Append(HttpUrlToRepo).Append("\n");
            sb.Append("  sshUrlToRepo: ").Append(SshUrlToRepo).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  activeStatistic: ").Append(ActiveStatistic).Append("\n");
            sb.Append("  securityTag: ").Append(SecurityTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubgroupAndProjectBaseDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubgroupAndProjectBaseDto input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.RoleNamecn != input.RoleNamecn || (this.RoleNamecn != null && !this.RoleNamecn.Equals(input.RoleNamecn))) return false;
            if (this.RoleNameen != input.RoleNameen || (this.RoleNameen != null && !this.RoleNameen.Equals(input.RoleNameen))) return false;
            if (this.FullName != input.FullName || (this.FullName != null && !this.FullName.Equals(input.FullName))) return false;
            if (this.FullPath != input.FullPath || (this.FullPath != null && !this.FullPath.Equals(input.FullPath))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAtTimestamp != input.UpdatedAtTimestamp || (this.UpdatedAtTimestamp != null && !this.UpdatedAtTimestamp.Equals(input.UpdatedAtTimestamp))) return false;
            if (this.StarTime != input.StarTime || (this.StarTime != null && !this.StarTime.Equals(input.StarTime))) return false;
            if (this.Starred != input.Starred || (this.Starred != null && !this.Starred.Equals(input.Starred))) return false;
            if (this.DevelopMode != input.DevelopMode || (this.DevelopMode != null && !this.DevelopMode.Equals(input.DevelopMode))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.GroupLevel != input.GroupLevel || (this.GroupLevel != null && !this.GroupLevel.Equals(input.GroupLevel))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SubgroupCount != input.SubgroupCount || (this.SubgroupCount != null && !this.SubgroupCount.Equals(input.SubgroupCount))) return false;
            if (this.ProjectCount != input.ProjectCount || (this.ProjectCount != null && !this.ProjectCount.Equals(input.ProjectCount))) return false;
            if (this.GroupRole != input.GroupRole || (this.GroupRole != null && !this.GroupRole.Equals(input.GroupRole))) return false;
            if (this.GroupMembersCount != input.GroupMembersCount || (this.GroupMembersCount != null && !this.GroupMembersCount.Equals(input.GroupMembersCount))) return false;
            if (this.DescendantType != input.DescendantType || (this.DescendantType != null && !this.DescendantType.Equals(input.DescendantType))) return false;
            if (this.VisibilityLevel != input.VisibilityLevel || (this.VisibilityLevel != null && !this.VisibilityLevel.Equals(input.VisibilityLevel))) return false;
            if (this.Visibility != input.Visibility || (this.Visibility != null && !this.Visibility.Equals(input.Visibility))) return false;
            if (this.IsProjectAdmin != input.IsProjectAdmin || (this.IsProjectAdmin != null && !this.IsProjectAdmin.Equals(input.IsProjectAdmin))) return false;
            if (this.IsGroupCreator != input.IsGroupCreator || (this.IsGroupCreator != null && !this.IsGroupCreator.Equals(input.IsGroupCreator))) return false;
            if (this.IsRepoCreator != input.IsRepoCreator || (this.IsRepoCreator != null && !this.IsRepoCreator.Equals(input.IsRepoCreator))) return false;
            if (this.RoleShowFlag != input.RoleShowFlag || (this.RoleShowFlag != null && !this.RoleShowFlag.Equals(input.RoleShowFlag))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.ForksCount != input.ForksCount || (this.ForksCount != null && !this.ForksCount.Equals(input.ForksCount))) return false;
            if (this.IsKia != input.IsKia || (this.IsKia != null && !this.IsKia.Equals(input.IsKia))) return false;
            if (this.IsOwner != input.IsOwner || (this.IsOwner != null && !this.IsOwner.Equals(input.IsOwner))) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.LastRepositoryUpdatedAt != input.LastRepositoryUpdatedAt || (this.LastRepositoryUpdatedAt != null && !this.LastRepositoryUpdatedAt.Equals(input.LastRepositoryUpdatedAt))) return false;
            if (this.OpenMergeRequestsCount != input.OpenMergeRequestsCount || (this.OpenMergeRequestsCount != null && !this.OpenMergeRequestsCount.Equals(input.OpenMergeRequestsCount))) return false;
            if (this.AllMergeRequestsCount != input.AllMergeRequestsCount || (this.AllMergeRequestsCount != null && !this.AllMergeRequestsCount.Equals(input.AllMergeRequestsCount))) return false;
            if (this.ProjectRole != input.ProjectRole || (this.ProjectRole != null && !this.ProjectRole.Equals(input.ProjectRole))) return false;
            if (this.ProjectMembersCount != input.ProjectMembersCount || (this.ProjectMembersCount != null && !this.ProjectMembersCount.Equals(input.ProjectMembersCount))) return false;
            if (this.ProjectCreator != input.ProjectCreator || (this.ProjectCreator != null && !this.ProjectCreator.Equals(input.ProjectCreator))) return false;
            if (this.StarCount != input.StarCount || (this.StarCount != null && !this.StarCount.Equals(input.StarCount))) return false;
            if (this.TagList != input.TagList || (this.TagList != null && input.TagList != null && !this.TagList.SequenceEqual(input.TagList))) return false;
            if (this.HttpUrlToRepo != input.HttpUrlToRepo || (this.HttpUrlToRepo != null && !this.HttpUrlToRepo.Equals(input.HttpUrlToRepo))) return false;
            if (this.SshUrlToRepo != input.SshUrlToRepo || (this.SshUrlToRepo != null && !this.SshUrlToRepo.Equals(input.SshUrlToRepo))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ActiveStatistic != input.ActiveStatistic || (this.ActiveStatistic != null && input.ActiveStatistic != null && !this.ActiveStatistic.SequenceEqual(input.ActiveStatistic))) return false;
            if (this.SecurityTag != input.SecurityTag || (this.SecurityTag != null && !this.SecurityTag.Equals(input.SecurityTag))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.RoleNamecn != null) hashCode = hashCode * 59 + this.RoleNamecn.GetHashCode();
                if (this.RoleNameen != null) hashCode = hashCode * 59 + this.RoleNameen.GetHashCode();
                if (this.FullName != null) hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.FullPath != null) hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAtTimestamp != null) hashCode = hashCode * 59 + this.UpdatedAtTimestamp.GetHashCode();
                if (this.StarTime != null) hashCode = hashCode * 59 + this.StarTime.GetHashCode();
                if (this.Starred != null) hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this.DevelopMode != null) hashCode = hashCode * 59 + this.DevelopMode.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.GroupLevel != null) hashCode = hashCode * 59 + this.GroupLevel.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SubgroupCount != null) hashCode = hashCode * 59 + this.SubgroupCount.GetHashCode();
                if (this.ProjectCount != null) hashCode = hashCode * 59 + this.ProjectCount.GetHashCode();
                if (this.GroupRole != null) hashCode = hashCode * 59 + this.GroupRole.GetHashCode();
                if (this.GroupMembersCount != null) hashCode = hashCode * 59 + this.GroupMembersCount.GetHashCode();
                if (this.DescendantType != null) hashCode = hashCode * 59 + this.DescendantType.GetHashCode();
                if (this.VisibilityLevel != null) hashCode = hashCode * 59 + this.VisibilityLevel.GetHashCode();
                if (this.Visibility != null) hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.IsProjectAdmin != null) hashCode = hashCode * 59 + this.IsProjectAdmin.GetHashCode();
                if (this.IsGroupCreator != null) hashCode = hashCode * 59 + this.IsGroupCreator.GetHashCode();
                if (this.IsRepoCreator != null) hashCode = hashCode * 59 + this.IsRepoCreator.GetHashCode();
                if (this.RoleShowFlag != null) hashCode = hashCode * 59 + this.RoleShowFlag.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.ForksCount != null) hashCode = hashCode * 59 + this.ForksCount.GetHashCode();
                if (this.IsKia != null) hashCode = hashCode * 59 + this.IsKia.GetHashCode();
                if (this.IsOwner != null) hashCode = hashCode * 59 + this.IsOwner.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.LastRepositoryUpdatedAt != null) hashCode = hashCode * 59 + this.LastRepositoryUpdatedAt.GetHashCode();
                if (this.OpenMergeRequestsCount != null) hashCode = hashCode * 59 + this.OpenMergeRequestsCount.GetHashCode();
                if (this.AllMergeRequestsCount != null) hashCode = hashCode * 59 + this.AllMergeRequestsCount.GetHashCode();
                if (this.ProjectRole != null) hashCode = hashCode * 59 + this.ProjectRole.GetHashCode();
                if (this.ProjectMembersCount != null) hashCode = hashCode * 59 + this.ProjectMembersCount.GetHashCode();
                if (this.ProjectCreator != null) hashCode = hashCode * 59 + this.ProjectCreator.GetHashCode();
                if (this.StarCount != null) hashCode = hashCode * 59 + this.StarCount.GetHashCode();
                if (this.TagList != null) hashCode = hashCode * 59 + this.TagList.GetHashCode();
                if (this.HttpUrlToRepo != null) hashCode = hashCode * 59 + this.HttpUrlToRepo.GetHashCode();
                if (this.SshUrlToRepo != null) hashCode = hashCode * 59 + this.SshUrlToRepo.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ActiveStatistic != null) hashCode = hashCode * 59 + this.ActiveStatistic.GetHashCode();
                if (this.SecurityTag != null) hashCode = hashCode * 59 + this.SecurityTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
