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
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
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
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;

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
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
