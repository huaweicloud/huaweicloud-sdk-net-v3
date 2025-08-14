using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class ShowUserProjectPermissionResult 
    {

        /// <summary>
        /// 工程编号
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户是否有创建权限
        /// </summary>
        [JsonProperty("create_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreatePermission { get; set; }

        /// <summary>
        /// 用户是否有修改权限
        /// </summary>
        [JsonProperty("modify_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModifyPermission { get; set; }

        /// <summary>
        /// 用户是否有分类权限
        /// </summary>
        [JsonProperty("group_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupPermission { get; set; }

        /// <summary>
        /// 用户是否有删除权限。
        /// </summary>
        [JsonProperty("delete_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletePermission { get; set; }

        /// <summary>
        /// 用户是否有查看权限。
        /// </summary>
        [JsonProperty("view_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ViewPermission { get; set; }

        /// <summary>
        /// 用户是否有执行权限。
        /// </summary>
        [JsonProperty("execute_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecutePermission { get; set; }

        /// <summary>
        /// 用户是否有克隆权限。
        /// </summary>
        [JsonProperty("copy_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CopyPermission { get; set; }

        /// <summary>
        /// 用户是否有禁用权限。
        /// </summary>
        [JsonProperty("forbidden_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForbiddenPermission { get; set; }

        /// <summary>
        /// 用户是否有管理权限。
        /// </summary>
        [JsonProperty("manager_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManagerPermission { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色编码集合。
        /// </summary>
        [JsonProperty("role_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// 角色名称集合。
        /// </summary>
        [JsonProperty("role_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RoleNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserProjectPermissionResult {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createPermission: ").Append(CreatePermission).Append("\n");
            sb.Append("  modifyPermission: ").Append(ModifyPermission).Append("\n");
            sb.Append("  groupPermission: ").Append(GroupPermission).Append("\n");
            sb.Append("  deletePermission: ").Append(DeletePermission).Append("\n");
            sb.Append("  viewPermission: ").Append(ViewPermission).Append("\n");
            sb.Append("  executePermission: ").Append(ExecutePermission).Append("\n");
            sb.Append("  copyPermission: ").Append(CopyPermission).Append("\n");
            sb.Append("  forbiddenPermission: ").Append(ForbiddenPermission).Append("\n");
            sb.Append("  managerPermission: ").Append(ManagerPermission).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  roleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  roleNames: ").Append(RoleNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserProjectPermissionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserProjectPermissionResult input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatePermission != input.CreatePermission || (this.CreatePermission != null && !this.CreatePermission.Equals(input.CreatePermission))) return false;
            if (this.ModifyPermission != input.ModifyPermission || (this.ModifyPermission != null && !this.ModifyPermission.Equals(input.ModifyPermission))) return false;
            if (this.GroupPermission != input.GroupPermission || (this.GroupPermission != null && !this.GroupPermission.Equals(input.GroupPermission))) return false;
            if (this.DeletePermission != input.DeletePermission || (this.DeletePermission != null && !this.DeletePermission.Equals(input.DeletePermission))) return false;
            if (this.ViewPermission != input.ViewPermission || (this.ViewPermission != null && !this.ViewPermission.Equals(input.ViewPermission))) return false;
            if (this.ExecutePermission != input.ExecutePermission || (this.ExecutePermission != null && !this.ExecutePermission.Equals(input.ExecutePermission))) return false;
            if (this.CopyPermission != input.CopyPermission || (this.CopyPermission != null && !this.CopyPermission.Equals(input.CopyPermission))) return false;
            if (this.ForbiddenPermission != input.ForbiddenPermission || (this.ForbiddenPermission != null && !this.ForbiddenPermission.Equals(input.ForbiddenPermission))) return false;
            if (this.ManagerPermission != input.ManagerPermission || (this.ManagerPermission != null && !this.ManagerPermission.Equals(input.ManagerPermission))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;
            if (this.RoleIds != input.RoleIds || (this.RoleIds != null && input.RoleIds != null && !this.RoleIds.SequenceEqual(input.RoleIds))) return false;
            if (this.RoleNames != input.RoleNames || (this.RoleNames != null && input.RoleNames != null && !this.RoleNames.SequenceEqual(input.RoleNames))) return false;

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
                if (this.CreatePermission != null) hashCode = hashCode * 59 + this.CreatePermission.GetHashCode();
                if (this.ModifyPermission != null) hashCode = hashCode * 59 + this.ModifyPermission.GetHashCode();
                if (this.GroupPermission != null) hashCode = hashCode * 59 + this.GroupPermission.GetHashCode();
                if (this.DeletePermission != null) hashCode = hashCode * 59 + this.DeletePermission.GetHashCode();
                if (this.ViewPermission != null) hashCode = hashCode * 59 + this.ViewPermission.GetHashCode();
                if (this.ExecutePermission != null) hashCode = hashCode * 59 + this.ExecutePermission.GetHashCode();
                if (this.CopyPermission != null) hashCode = hashCode * 59 + this.CopyPermission.GetHashCode();
                if (this.ForbiddenPermission != null) hashCode = hashCode * 59 + this.ForbiddenPermission.GetHashCode();
                if (this.ManagerPermission != null) hashCode = hashCode * 59 + this.ManagerPermission.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.RoleIds != null) hashCode = hashCode * 59 + this.RoleIds.GetHashCode();
                if (this.RoleNames != null) hashCode = hashCode * 59 + this.RoleNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
