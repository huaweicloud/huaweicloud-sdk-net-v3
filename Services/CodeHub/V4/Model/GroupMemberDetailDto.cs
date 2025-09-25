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
    public class GroupMemberDetailDto 
    {

        /// <summary>
        /// **参数解释：** 唯一标识id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 资源id。
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceId { get; set; }

        /// <summary>
        /// **参数解释：** 用户id。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

        /// <summary>
        /// **参数解释：** 用户来源。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("user_from", NullValueHandling = NullValueHandling.Ignore)]
        public string UserFrom { get; set; }

        /// <summary>
        /// **参数解释：** 角色id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// **参数解释：** 角色名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// **参数解释：** 角色中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("cn_role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CnRoleName { get; set; }

        /// <summary>
        /// **参数解释：** 项目角色id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("req_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReqRoleId { get; set; }

        /// <summary>
        /// **参数解释：** 项目角色名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("req_role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReqRoleName { get; set; }

        /// <summary>
        /// **参数解释：** 成员组id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("user_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// **参数解释：** 代码组名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释：** 用户名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释：** 租户id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释：** 租户名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数解释：** 用户昵称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// **参数解释：** 是否为代码组创建者。
        /// </summary>
        [JsonProperty("is_group_creator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGroupCreator { get; set; }

        /// <summary>
        /// **参数解释：** 是否为项目管理员。
        /// </summary>
        [JsonProperty("is_project_admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProjectAdmin { get; set; }

        /// <summary>
        /// **参数解释：** 路径。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 角色中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_chinese_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleChineseName { get; set; }

        /// <summary>
        /// **参数解释：** 是否可移除。
        /// </summary>
        [JsonProperty("can_remove", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanRemove { get; set; }

        /// <summary>
        /// **参数解释：** 角色。
        /// </summary>
        [JsonProperty("access_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessLevel { get; set; }

        /// <summary>
        /// **参数解释：** 服务license状态。
        /// </summary>
        [JsonProperty("service_license_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceLicenseStatus { get; set; }

        /// <summary>
        /// **参数解释：** 用户iam_id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("iam_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamId { get; set; }

        /// <summary>
        /// **参数解释：** 是否为当前代码组成员。
        /// </summary>
        [JsonProperty("current_group_member", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CurrentGroupMember { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMemberDetailDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userFrom: ").Append(UserFrom).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  cnRoleName: ").Append(CnRoleName).Append("\n");
            sb.Append("  reqRoleId: ").Append(ReqRoleId).Append("\n");
            sb.Append("  reqRoleName: ").Append(ReqRoleName).Append("\n");
            sb.Append("  userGroupId: ").Append(UserGroupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  isGroupCreator: ").Append(IsGroupCreator).Append("\n");
            sb.Append("  isProjectAdmin: ").Append(IsProjectAdmin).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  roleChineseName: ").Append(RoleChineseName).Append("\n");
            sb.Append("  canRemove: ").Append(CanRemove).Append("\n");
            sb.Append("  accessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  serviceLicenseStatus: ").Append(ServiceLicenseStatus).Append("\n");
            sb.Append("  iamId: ").Append(IamId).Append("\n");
            sb.Append("  currentGroupMember: ").Append(CurrentGroupMember).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMemberDetailDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupMemberDetailDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserFrom != input.UserFrom || (this.UserFrom != null && !this.UserFrom.Equals(input.UserFrom))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;
            if (this.CnRoleName != input.CnRoleName || (this.CnRoleName != null && !this.CnRoleName.Equals(input.CnRoleName))) return false;
            if (this.ReqRoleId != input.ReqRoleId || (this.ReqRoleId != null && !this.ReqRoleId.Equals(input.ReqRoleId))) return false;
            if (this.ReqRoleName != input.ReqRoleName || (this.ReqRoleName != null && !this.ReqRoleName.Equals(input.ReqRoleName))) return false;
            if (this.UserGroupId != input.UserGroupId || (this.UserGroupId != null && !this.UserGroupId.Equals(input.UserGroupId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.IsGroupCreator != input.IsGroupCreator || (this.IsGroupCreator != null && !this.IsGroupCreator.Equals(input.IsGroupCreator))) return false;
            if (this.IsProjectAdmin != input.IsProjectAdmin || (this.IsProjectAdmin != null && !this.IsProjectAdmin.Equals(input.IsProjectAdmin))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.RoleChineseName != input.RoleChineseName || (this.RoleChineseName != null && !this.RoleChineseName.Equals(input.RoleChineseName))) return false;
            if (this.CanRemove != input.CanRemove || (this.CanRemove != null && !this.CanRemove.Equals(input.CanRemove))) return false;
            if (this.AccessLevel != input.AccessLevel || (this.AccessLevel != null && !this.AccessLevel.Equals(input.AccessLevel))) return false;
            if (this.ServiceLicenseStatus != input.ServiceLicenseStatus || (this.ServiceLicenseStatus != null && !this.ServiceLicenseStatus.Equals(input.ServiceLicenseStatus))) return false;
            if (this.IamId != input.IamId || (this.IamId != null && !this.IamId.Equals(input.IamId))) return false;
            if (this.CurrentGroupMember != input.CurrentGroupMember || (this.CurrentGroupMember != null && !this.CurrentGroupMember.Equals(input.CurrentGroupMember))) return false;

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
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserFrom != null) hashCode = hashCode * 59 + this.UserFrom.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.CnRoleName != null) hashCode = hashCode * 59 + this.CnRoleName.GetHashCode();
                if (this.ReqRoleId != null) hashCode = hashCode * 59 + this.ReqRoleId.GetHashCode();
                if (this.ReqRoleName != null) hashCode = hashCode * 59 + this.ReqRoleName.GetHashCode();
                if (this.UserGroupId != null) hashCode = hashCode * 59 + this.UserGroupId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.IsGroupCreator != null) hashCode = hashCode * 59 + this.IsGroupCreator.GetHashCode();
                if (this.IsProjectAdmin != null) hashCode = hashCode * 59 + this.IsProjectAdmin.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.RoleChineseName != null) hashCode = hashCode * 59 + this.RoleChineseName.GetHashCode();
                if (this.CanRemove != null) hashCode = hashCode * 59 + this.CanRemove.GetHashCode();
                if (this.AccessLevel != null) hashCode = hashCode * 59 + this.AccessLevel.GetHashCode();
                if (this.ServiceLicenseStatus != null) hashCode = hashCode * 59 + this.ServiceLicenseStatus.GetHashCode();
                if (this.IamId != null) hashCode = hashCode * 59 + this.IamId.GetHashCode();
                if (this.CurrentGroupMember != null) hashCode = hashCode * 59 + this.CurrentGroupMember.GetHashCode();
                return hashCode;
            }
        }
    }
}
