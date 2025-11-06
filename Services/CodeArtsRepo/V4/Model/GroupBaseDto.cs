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
    /// A empty base object for group.
    /// </summary>
    public class GroupBaseDto 
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
        /// **参数解释：** 代码组id。
        /// </summary>
        [JsonProperty("ancestor_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AncestorIds { get; set; }

        /// <summary>
        /// **参数解释：** 代码组名称。
        /// </summary>
        [JsonProperty("ancestor_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AncestorNames { get; set; }

        /// <summary>
        /// **参数解释：** 开发模式，normal，cr。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("develop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopMode { get; set; }

        /// <summary>
        /// **参数解释：** 记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 名称。 **取值范围：** 字符串长度不少于1，不超过1000。
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
        /// **参数解释：** 描述。 **取值范围：** 字符串长度不少于1，不超过1000。
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
        /// **参数解释：** 类型。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("descendant_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DescendantType { get; set; }

        /// <summary>
        /// **参数解释：** 可见性 0 20。
        /// </summary>
        [JsonProperty("visibility_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// **参数解释：** 可见性 private public。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        /// <summary>
        /// **参数解释：** 是否为项目创建者。
        /// </summary>
        [JsonProperty("is_project_admin", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsProjectAdmin { get; set; }

        /// <summary>
        /// **参数解释：** 是否为代码组创建者。
        /// </summary>
        [JsonProperty("is_group_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsGroupCreator { get; set; }

        /// <summary>
        /// **参数解释：** 是否为仓库创建者。
        /// </summary>
        [JsonProperty("is_repo_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsRepoCreator { get; set; }

        /// <summary>
        /// **参数解释：** lfs是否开启。
        /// </summary>
        [JsonProperty("lfs_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LfsEnabled { get; set; }

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
        /// **参数解释：** item类型。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("item_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        /// <summary>
        /// **参数解释：** 父代码组id。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("my_role", NullValueHandling = NullValueHandling.Ignore)]
        public GroupMyRoleDtoV4 MyRole { get; set; }

        /// <summary>
        /// **参数解释：** 成员。
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public int? Members { get; set; }

        /// <summary>
        /// **参数解释：** url地址。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 子代码组数量。
        /// </summary>
        [JsonProperty("sub_group_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubGroupCount { get; set; }

        /// <summary>
        /// **参数解释：** 是否为最后所有者。
        /// </summary>
        [JsonProperty("last_owner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LastOwner { get; set; }

        /// <summary>
        /// **参数解释：** 是否关注。
        /// </summary>
        [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Starred { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupBaseDto {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  ancestorIds: ").Append(AncestorIds).Append("\n");
            sb.Append("  ancestorNames: ").Append(AncestorNames).Append("\n");
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
            sb.Append("  lfsEnabled: ").Append(LfsEnabled).Append("\n");
            sb.Append("  fullName: ").Append(FullName).Append("\n");
            sb.Append("  fullPath: ").Append(FullPath).Append("\n");
            sb.Append("  itemType: ").Append(ItemType).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  myRole: ").Append(MyRole).Append("\n");
            sb.Append("  members: ").Append(Members).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  subGroupCount: ").Append(SubGroupCount).Append("\n");
            sb.Append("  lastOwner: ").Append(LastOwner).Append("\n");
            sb.Append("  starred: ").Append(Starred).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupBaseDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupBaseDto input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.AncestorIds != input.AncestorIds || (this.AncestorIds != null && input.AncestorIds != null && !this.AncestorIds.SequenceEqual(input.AncestorIds))) return false;
            if (this.AncestorNames != input.AncestorNames || (this.AncestorNames != null && input.AncestorNames != null && !this.AncestorNames.SequenceEqual(input.AncestorNames))) return false;
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
            if (this.LfsEnabled != input.LfsEnabled || (this.LfsEnabled != null && !this.LfsEnabled.Equals(input.LfsEnabled))) return false;
            if (this.FullName != input.FullName || (this.FullName != null && !this.FullName.Equals(input.FullName))) return false;
            if (this.FullPath != input.FullPath || (this.FullPath != null && !this.FullPath.Equals(input.FullPath))) return false;
            if (this.ItemType != input.ItemType || (this.ItemType != null && !this.ItemType.Equals(input.ItemType))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.MyRole != input.MyRole || (this.MyRole != null && !this.MyRole.Equals(input.MyRole))) return false;
            if (this.Members != input.Members || (this.Members != null && !this.Members.Equals(input.Members))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.SubGroupCount != input.SubGroupCount || (this.SubGroupCount != null && !this.SubGroupCount.Equals(input.SubGroupCount))) return false;
            if (this.LastOwner != input.LastOwner || (this.LastOwner != null && !this.LastOwner.Equals(input.LastOwner))) return false;
            if (this.Starred != input.Starred || (this.Starred != null && !this.Starred.Equals(input.Starred))) return false;

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
                if (this.AncestorIds != null) hashCode = hashCode * 59 + this.AncestorIds.GetHashCode();
                if (this.AncestorNames != null) hashCode = hashCode * 59 + this.AncestorNames.GetHashCode();
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
                if (this.LfsEnabled != null) hashCode = hashCode * 59 + this.LfsEnabled.GetHashCode();
                if (this.FullName != null) hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.FullPath != null) hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.ItemType != null) hashCode = hashCode * 59 + this.ItemType.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.MyRole != null) hashCode = hashCode * 59 + this.MyRole.GetHashCode();
                if (this.Members != null) hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.SubGroupCount != null) hashCode = hashCode * 59 + this.SubGroupCount.GetHashCode();
                if (this.LastOwner != null) hashCode = hashCode * 59 + this.LastOwner.GetHashCode();
                if (this.Starred != null) hashCode = hashCode * 59 + this.Starred.GetHashCode();
                return hashCode;
            }
        }
    }
}
