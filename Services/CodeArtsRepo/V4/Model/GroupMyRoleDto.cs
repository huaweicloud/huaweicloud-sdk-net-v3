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
    public class GroupMyRoleDto 
    {

        /// <summary>
        /// 成员id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 成员角色值
        /// </summary>
        [JsonProperty("access_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessLevel { get; set; }

        /// <summary>
        /// 角色中文名称
        /// </summary>
        [JsonProperty("role_namecn", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleNamecn { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("role_namen", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleNamen { get; set; }

        /// <summary>
        /// 来源代码组id
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceId { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

        /// <summary>
        /// 提示级别
        /// </summary>
        [JsonProperty("notification_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotificationLevel { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 创建者id
        /// </summary>
        [JsonProperty("created_by_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedById { get; set; }

        /// <summary>
        /// 邀请邮箱
        /// </summary>
        [JsonProperty("invite_email", NullValueHandling = NullValueHandling.Ignore)]
        public string InviteEmail { get; set; }

        /// <summary>
        /// 邀请token
        /// </summary>
        [JsonProperty("invite_token", NullValueHandling = NullValueHandling.Ignore)]
        public string InviteToken { get; set; }

        /// <summary>
        /// 邀请接受时间
        /// </summary>
        [JsonProperty("invite_accepted_at", NullValueHandling = NullValueHandling.Ignore)]
        public string InviteAcceptedAt { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [JsonProperty("requested_at", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestedAt { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// 限制
        /// </summary>
        [JsonProperty("limited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Limited { get; set; }

        /// <summary>
        /// 是否为项目管理员
        /// </summary>
        [JsonProperty("isProjectAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsProjectAdmin { get; set; }

        /// <summary>
        /// 是否为组织创建者
        /// </summary>
        [JsonProperty("isGroupCreator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsGroupCreator { get; set; }

        /// <summary>
        /// 是否仓库创建者
        /// </summary>
        [JsonProperty("isRepoCreator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsRepoCreator { get; set; }

        /// <summary>
        /// 展示标记
        /// </summary>
        [JsonProperty("roleShowFlag", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleShowFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMyRoleDto {\n");
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
            sb.Append("  createdById: ").Append(CreatedById).Append("\n");
            sb.Append("  inviteEmail: ").Append(InviteEmail).Append("\n");
            sb.Append("  inviteToken: ").Append(InviteToken).Append("\n");
            sb.Append("  inviteAcceptedAt: ").Append(InviteAcceptedAt).Append("\n");
            sb.Append("  requestedAt: ").Append(RequestedAt).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  limited: ").Append(Limited).Append("\n");
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
            return this.Equals(input as GroupMyRoleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupMyRoleDto input)
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
            if (this.CreatedById != input.CreatedById || (this.CreatedById != null && !this.CreatedById.Equals(input.CreatedById))) return false;
            if (this.InviteEmail != input.InviteEmail || (this.InviteEmail != null && !this.InviteEmail.Equals(input.InviteEmail))) return false;
            if (this.InviteToken != input.InviteToken || (this.InviteToken != null && !this.InviteToken.Equals(input.InviteToken))) return false;
            if (this.InviteAcceptedAt != input.InviteAcceptedAt || (this.InviteAcceptedAt != null && !this.InviteAcceptedAt.Equals(input.InviteAcceptedAt))) return false;
            if (this.RequestedAt != input.RequestedAt || (this.RequestedAt != null && !this.RequestedAt.Equals(input.RequestedAt))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;
            if (this.Limited != input.Limited || (this.Limited != null && !this.Limited.Equals(input.Limited))) return false;
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
                if (this.CreatedById != null) hashCode = hashCode * 59 + this.CreatedById.GetHashCode();
                if (this.InviteEmail != null) hashCode = hashCode * 59 + this.InviteEmail.GetHashCode();
                if (this.InviteToken != null) hashCode = hashCode * 59 + this.InviteToken.GetHashCode();
                if (this.InviteAcceptedAt != null) hashCode = hashCode * 59 + this.InviteAcceptedAt.GetHashCode();
                if (this.RequestedAt != null) hashCode = hashCode * 59 + this.RequestedAt.GetHashCode();
                if (this.ExpiresAt != null) hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Limited != null) hashCode = hashCode * 59 + this.Limited.GetHashCode();
                if (this.IsProjectAdmin != null) hashCode = hashCode * 59 + this.IsProjectAdmin.GetHashCode();
                if (this.IsGroupCreator != null) hashCode = hashCode * 59 + this.IsGroupCreator.GetHashCode();
                if (this.IsRepoCreator != null) hashCode = hashCode * 59 + this.IsRepoCreator.GetHashCode();
                if (this.RoleShowFlag != null) hashCode = hashCode * 59 + this.RoleShowFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
