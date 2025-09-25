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
    public class RoleSyncDto 
    {

        /// <summary>
        /// **参数解释：** 角色记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 角色id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// **参数解释：** 角色同步开关。
        /// </summary>
        [JsonProperty("role_sync_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RoleSyncEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 角色名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// **参数解释：** 角色类型。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleType { get; set; }

        /// <summary>
        /// **参数解释：** 角色中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("role_chinese_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleChineseName { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleSyncDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleSyncEnabled: ").Append(RoleSyncEnabled).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  roleType: ").Append(RoleType).Append("\n");
            sb.Append("  roleChineseName: ").Append(RoleChineseName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleSyncDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleSyncDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleSyncEnabled != input.RoleSyncEnabled || (this.RoleSyncEnabled != null && !this.RoleSyncEnabled.Equals(input.RoleSyncEnabled))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;
            if (this.RoleType != input.RoleType || (this.RoleType != null && !this.RoleType.Equals(input.RoleType))) return false;
            if (this.RoleChineseName != input.RoleChineseName || (this.RoleChineseName != null && !this.RoleChineseName.Equals(input.RoleChineseName))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleSyncEnabled != null) hashCode = hashCode * 59 + this.RoleSyncEnabled.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.RoleType != null) hashCode = hashCode * 59 + this.RoleType.GetHashCode();
                if (this.RoleChineseName != null) hashCode = hashCode * 59 + this.RoleChineseName.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
