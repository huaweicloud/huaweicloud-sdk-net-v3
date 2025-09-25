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
    public class PermissionDto 
    {

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; }

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
        [JsonProperty("role_name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleNameCn { get; set; }

        /// <summary>
        /// **参数解释：** 资源权限对象。
        /// </summary>
        [JsonProperty("resource_permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ResourcePermissionDto> ResourcePermissions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionDto {\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  roleNameCn: ").Append(RoleNameCn).Append("\n");
            sb.Append("  resourcePermissions: ").Append(ResourcePermissions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionDto input)
        {
            if (input == null) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;
            if (this.RoleNameCn != input.RoleNameCn || (this.RoleNameCn != null && !this.RoleNameCn.Equals(input.RoleNameCn))) return false;
            if (this.ResourcePermissions != input.ResourcePermissions || (this.ResourcePermissions != null && input.ResourcePermissions != null && !this.ResourcePermissions.SequenceEqual(input.ResourcePermissions))) return false;

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
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.RoleNameCn != null) hashCode = hashCode * 59 + this.RoleNameCn.GetHashCode();
                if (this.ResourcePermissions != null) hashCode = hashCode * 59 + this.ResourcePermissions.GetHashCode();
                return hashCode;
            }
        }
    }
}
