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
    /// 仓库成员详情
    /// </summary>
    public class RepositoryMemberDto 
    {

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

        /// <summary>
        /// 用户iamId
        /// </summary>
        [JsonProperty("user_iam_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserIamId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("user_nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserNickName { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 是否为仓库所有者
        /// </summary>
        [JsonProperty("is_repo_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsRepoCreator { get; set; }

        /// <summary>
        /// 是否为父代码组所有者
        /// </summary>
        [JsonProperty("is_group_creator", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsGroupCreator { get; set; }

        /// <summary>
        /// 是否为项目管理员
        /// </summary>
        [JsonProperty("is_Project_admin", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsProjectAdmin { get; set; }

        /// <summary>
        /// 项目角色名称
        /// </summary>
        [JsonProperty("project_role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectRoleName { get; set; }

        /// <summary>
        /// 仓库角色名称
        /// </summary>
        [JsonProperty("repository_role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryRoleName { get; set; }

        /// <summary>
        /// 仓库角色id
        /// </summary>
        [JsonProperty("repository_role_Id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryRoleId { get; set; }

        /// <summary>
        /// 成员如果来自成员组，成员组名称
        /// </summary>
        [JsonProperty("member_source", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberSource { get; set; }

        /// <summary>
        /// 成员如果来自上层代码组，代码组名称
        /// </summary>
        [JsonProperty("member_group_source", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberGroupSource { get; set; }

        /// <summary>
        /// 成员来源id —— 代码组id或者成员组id
        /// </summary>
        [JsonProperty("member_source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberSourceId { get; set; }

        /// <summary>
        /// 成员服务级权限状态： 1-使用中、0-已停用
        /// </summary>
        [JsonProperty("service_license_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceLicenseStatus { get; set; }

        /// <summary>
        /// 是否有对应权限： true-有权限、false-无权限
        /// </summary>
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryMemberDto {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userIamId: ").Append(UserIamId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userNickName: ").Append(UserNickName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  isRepoCreator: ").Append(IsRepoCreator).Append("\n");
            sb.Append("  isGroupCreator: ").Append(IsGroupCreator).Append("\n");
            sb.Append("  isProjectAdmin: ").Append(IsProjectAdmin).Append("\n");
            sb.Append("  projectRoleName: ").Append(ProjectRoleName).Append("\n");
            sb.Append("  repositoryRoleName: ").Append(RepositoryRoleName).Append("\n");
            sb.Append("  repositoryRoleId: ").Append(RepositoryRoleId).Append("\n");
            sb.Append("  memberSource: ").Append(MemberSource).Append("\n");
            sb.Append("  memberGroupSource: ").Append(MemberGroupSource).Append("\n");
            sb.Append("  memberSourceId: ").Append(MemberSourceId).Append("\n");
            sb.Append("  serviceLicenseStatus: ").Append(ServiceLicenseStatus).Append("\n");
            sb.Append("  actionEnabled: ").Append(ActionEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryMemberDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryMemberDto input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserIamId != input.UserIamId || (this.UserIamId != null && !this.UserIamId.Equals(input.UserIamId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserNickName != input.UserNickName || (this.UserNickName != null && !this.UserNickName.Equals(input.UserNickName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.IsRepoCreator != input.IsRepoCreator || (this.IsRepoCreator != null && !this.IsRepoCreator.Equals(input.IsRepoCreator))) return false;
            if (this.IsGroupCreator != input.IsGroupCreator || (this.IsGroupCreator != null && !this.IsGroupCreator.Equals(input.IsGroupCreator))) return false;
            if (this.IsProjectAdmin != input.IsProjectAdmin || (this.IsProjectAdmin != null && !this.IsProjectAdmin.Equals(input.IsProjectAdmin))) return false;
            if (this.ProjectRoleName != input.ProjectRoleName || (this.ProjectRoleName != null && !this.ProjectRoleName.Equals(input.ProjectRoleName))) return false;
            if (this.RepositoryRoleName != input.RepositoryRoleName || (this.RepositoryRoleName != null && !this.RepositoryRoleName.Equals(input.RepositoryRoleName))) return false;
            if (this.RepositoryRoleId != input.RepositoryRoleId || (this.RepositoryRoleId != null && !this.RepositoryRoleId.Equals(input.RepositoryRoleId))) return false;
            if (this.MemberSource != input.MemberSource || (this.MemberSource != null && !this.MemberSource.Equals(input.MemberSource))) return false;
            if (this.MemberGroupSource != input.MemberGroupSource || (this.MemberGroupSource != null && !this.MemberGroupSource.Equals(input.MemberGroupSource))) return false;
            if (this.MemberSourceId != input.MemberSourceId || (this.MemberSourceId != null && !this.MemberSourceId.Equals(input.MemberSourceId))) return false;
            if (this.ServiceLicenseStatus != input.ServiceLicenseStatus || (this.ServiceLicenseStatus != null && !this.ServiceLicenseStatus.Equals(input.ServiceLicenseStatus))) return false;
            if (this.ActionEnabled != input.ActionEnabled || (this.ActionEnabled != null && !this.ActionEnabled.Equals(input.ActionEnabled))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserIamId != null) hashCode = hashCode * 59 + this.UserIamId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserNickName != null) hashCode = hashCode * 59 + this.UserNickName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.IsRepoCreator != null) hashCode = hashCode * 59 + this.IsRepoCreator.GetHashCode();
                if (this.IsGroupCreator != null) hashCode = hashCode * 59 + this.IsGroupCreator.GetHashCode();
                if (this.IsProjectAdmin != null) hashCode = hashCode * 59 + this.IsProjectAdmin.GetHashCode();
                if (this.ProjectRoleName != null) hashCode = hashCode * 59 + this.ProjectRoleName.GetHashCode();
                if (this.RepositoryRoleName != null) hashCode = hashCode * 59 + this.RepositoryRoleName.GetHashCode();
                if (this.RepositoryRoleId != null) hashCode = hashCode * 59 + this.RepositoryRoleId.GetHashCode();
                if (this.MemberSource != null) hashCode = hashCode * 59 + this.MemberSource.GetHashCode();
                if (this.MemberGroupSource != null) hashCode = hashCode * 59 + this.MemberGroupSource.GetHashCode();
                if (this.MemberSourceId != null) hashCode = hashCode * 59 + this.MemberSourceId.GetHashCode();
                if (this.ServiceLicenseStatus != null) hashCode = hashCode * 59 + this.ServiceLicenseStatus.GetHashCode();
                if (this.ActionEnabled != null) hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
