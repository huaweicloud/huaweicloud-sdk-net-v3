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
    /// Response Object
    /// </summary>
    public class ShowProjectMemberSettingResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 项目id **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释：** 同步开关
        /// </summary>
        [JsonProperty("sync_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 同步所有角色开关
        /// </summary>
        [JsonProperty("sync_all_role_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncAllRoleEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 角色同步
        /// </summary>
        [JsonProperty("role_sync", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleSyncDto> RoleSync { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectMemberSettingResponse {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  syncEnabled: ").Append(SyncEnabled).Append("\n");
            sb.Append("  syncAllRoleEnabled: ").Append(SyncAllRoleEnabled).Append("\n");
            sb.Append("  roleSync: ").Append(RoleSync).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectMemberSettingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectMemberSettingResponse input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.SyncEnabled != input.SyncEnabled || (this.SyncEnabled != null && !this.SyncEnabled.Equals(input.SyncEnabled))) return false;
            if (this.SyncAllRoleEnabled != input.SyncAllRoleEnabled || (this.SyncAllRoleEnabled != null && !this.SyncAllRoleEnabled.Equals(input.SyncAllRoleEnabled))) return false;
            if (this.RoleSync != input.RoleSync || (this.RoleSync != null && input.RoleSync != null && !this.RoleSync.SequenceEqual(input.RoleSync))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SyncEnabled != null) hashCode = hashCode * 59 + this.SyncEnabled.GetHashCode();
                if (this.SyncAllRoleEnabled != null) hashCode = hashCode * 59 + this.SyncAllRoleEnabled.GetHashCode();
                if (this.RoleSync != null) hashCode = hashCode * 59 + this.RoleSync.GetHashCode();
                return hashCode;
            }
        }
    }
}
