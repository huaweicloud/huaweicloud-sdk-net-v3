using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AppPermission 
    {

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("dev_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DevRoleId { get; set; }

        /// <summary>
        /// 是否具有编辑权限
        /// </summary>
        [JsonProperty("can_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanModify { get; set; }

        /// <summary>
        /// 是否具有删除权限
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否具有查看权限
        /// </summary>
        [JsonProperty("can_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanView { get; set; }

        /// <summary>
        /// 是否具有执行权限
        /// </summary>
        [JsonProperty("can_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanExecute { get; set; }

        /// <summary>
        /// 是否具有复制权限
        /// </summary>
        [JsonProperty("can_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCopy { get; set; }

        /// <summary>
        /// 是否具有权限管理权限
        /// </summary>
        [JsonProperty("can_manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// 是否具有创建环境权限
        /// </summary>
        [JsonProperty("can_create_env", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCreateEnv { get; set; }

        /// <summary>
        /// 是否具有禁用权限
        /// </summary>
        [JsonProperty("can_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDisable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppPermission {\n");
            sb.Append("  devRoleId: ").Append(DevRoleId).Append("\n");
            sb.Append("  canModify: ").Append(CanModify).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  canCopy: ").Append(CanCopy).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  canCreateEnv: ").Append(CanCreateEnv).Append("\n");
            sb.Append("  canDisable: ").Append(CanDisable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppPermission);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppPermission input)
        {
            if (input == null) return false;
            if (this.DevRoleId != input.DevRoleId || (this.DevRoleId != null && !this.DevRoleId.Equals(input.DevRoleId))) return false;
            if (this.CanModify != input.CanModify || (this.CanModify != null && !this.CanModify.Equals(input.CanModify))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanView != input.CanView || (this.CanView != null && !this.CanView.Equals(input.CanView))) return false;
            if (this.CanExecute != input.CanExecute || (this.CanExecute != null && !this.CanExecute.Equals(input.CanExecute))) return false;
            if (this.CanCopy != input.CanCopy || (this.CanCopy != null && !this.CanCopy.Equals(input.CanCopy))) return false;
            if (this.CanManage != input.CanManage || (this.CanManage != null && !this.CanManage.Equals(input.CanManage))) return false;
            if (this.CanCreateEnv != input.CanCreateEnv || (this.CanCreateEnv != null && !this.CanCreateEnv.Equals(input.CanCreateEnv))) return false;
            if (this.CanDisable != input.CanDisable || (this.CanDisable != null && !this.CanDisable.Equals(input.CanDisable))) return false;

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
                if (this.DevRoleId != null) hashCode = hashCode * 59 + this.DevRoleId.GetHashCode();
                if (this.CanModify != null) hashCode = hashCode * 59 + this.CanModify.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanView != null) hashCode = hashCode * 59 + this.CanView.GetHashCode();
                if (this.CanExecute != null) hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.CanCopy != null) hashCode = hashCode * 59 + this.CanCopy.GetHashCode();
                if (this.CanManage != null) hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                if (this.CanCreateEnv != null) hashCode = hashCode * 59 + this.CanCreateEnv.GetHashCode();
                if (this.CanDisable != null) hashCode = hashCode * 59 + this.CanDisable.GetHashCode();
                return hashCode;
            }
        }
    }
}
