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
    public class GroupMyRoleDtoV4 
    {

        /// <summary>
        /// **参数解释：** 记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 角色。
        /// </summary>
        [JsonProperty("access_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessLevel { get; set; }

        /// <summary>
        /// **参数解释：** 角色中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_namecn", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleNamecn { get; set; }

        /// <summary>
        /// **参数解释：** 角色英文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_namen", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleNamen { get; set; }

        /// <summary>
        /// **参数解释：** 资源id。
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceId { get; set; }

        /// <summary>
        /// **参数解释：** 资源类型。 **取值范围：Group Project** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }

        /// <summary>
        /// **参数解释：** 用户id。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

        /// <summary>
        /// **参数解释：** 通知。
        /// </summary>
        [JsonProperty("notification_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotificationLevel { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 是否是项目创建者。
        /// </summary>
        [JsonProperty("is_project_admin", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsProjectAdmin { get; set; }

        /// <summary>
        /// **参数解释：** 是否是代码组创建者。
        /// </summary>
        [JsonProperty("is_group_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsGroupCreator { get; set; }

        /// <summary>
        /// **参数解释：** 是否是仓库创建者。
        /// </summary>
        [JsonProperty("is_repo_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsRepoCreator { get; set; }

        /// <summary>
        /// **参数解释：** 角色展示。
        /// </summary>
        [JsonProperty("role_show_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleShowFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMyRoleDtoV4 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  accessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  roleNamecn: ").Append(RoleNamecn).Append("\n");
            sb.Append("  roleNamen: ").Append(RoleNamen).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  notificationLevel: ").Append(NotificationLevel).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  isProjectAdmin: ").Append(IsProjectAdmin).Append("\n");
            sb.Append("  isGroupCreator: ").Append(IsGroupCreator).Append("\n");
            sb.Append("  isRepoCreator: ").Append(IsRepoCreator).Append("\n");
            sb.Append("  roleShowFlag: ").Append(RoleShowFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMyRoleDtoV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupMyRoleDtoV4 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AccessLevel != input.AccessLevel || (this.AccessLevel != null && !this.AccessLevel.Equals(input.AccessLevel))) return false;
            if (this.RoleNamecn != input.RoleNamecn || (this.RoleNamecn != null && !this.RoleNamecn.Equals(input.RoleNamecn))) return false;
            if (this.RoleNamen != input.RoleNamen || (this.RoleNamen != null && !this.RoleNamen.Equals(input.RoleNamen))) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.SourceType != input.SourceType || (this.SourceType != null && !this.SourceType.Equals(input.SourceType))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.NotificationLevel != input.NotificationLevel || (this.NotificationLevel != null && !this.NotificationLevel.Equals(input.NotificationLevel))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.IsProjectAdmin != input.IsProjectAdmin || (this.IsProjectAdmin != null && !this.IsProjectAdmin.Equals(input.IsProjectAdmin))) return false;
            if (this.IsGroupCreator != input.IsGroupCreator || (this.IsGroupCreator != null && !this.IsGroupCreator.Equals(input.IsGroupCreator))) return false;
            if (this.IsRepoCreator != input.IsRepoCreator || (this.IsRepoCreator != null && !this.IsRepoCreator.Equals(input.IsRepoCreator))) return false;
            if (this.RoleShowFlag != input.RoleShowFlag || (this.RoleShowFlag != null && !this.RoleShowFlag.Equals(input.RoleShowFlag))) return false;

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
                if (this.AccessLevel != null) hashCode = hashCode * 59 + this.AccessLevel.GetHashCode();
                if (this.RoleNamecn != null) hashCode = hashCode * 59 + this.RoleNamecn.GetHashCode();
                if (this.RoleNamen != null) hashCode = hashCode * 59 + this.RoleNamen.GetHashCode();
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceType != null) hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.NotificationLevel != null) hashCode = hashCode * 59 + this.NotificationLevel.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.IsProjectAdmin != null) hashCode = hashCode * 59 + this.IsProjectAdmin.GetHashCode();
                if (this.IsGroupCreator != null) hashCode = hashCode * 59 + this.IsGroupCreator.GetHashCode();
                if (this.IsRepoCreator != null) hashCode = hashCode * 59 + this.IsRepoCreator.GetHashCode();
                if (this.RoleShowFlag != null) hashCode = hashCode * 59 + this.RoleShowFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
