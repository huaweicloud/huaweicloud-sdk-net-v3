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
    /// 添加仓库成员信息
    /// </summary>
    public class CreateRepositoryMemberDto 
    {

        /// <summary>
        /// **参数解释：** 用户iamId **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("user_iam_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserIamId { get; set; }

        /// <summary>
        /// **参数解释：** 用户名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释：** 租户名称。 **约束限制：** - 不涉及。
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// **参数解释：** 租户id。 **约束限制：** - 不涉及。    
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释：** 角色id。 **约束限制：** - 不涉及。    
        /// </summary>
        [JsonProperty("repository_role_Id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryRoleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRepositoryMemberDto {\n");
            sb.Append("  userIamId: ").Append(UserIamId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  repositoryRoleId: ").Append(RepositoryRoleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRepositoryMemberDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRepositoryMemberDto input)
        {
            if (input == null) return false;
            if (this.UserIamId != input.UserIamId || (this.UserIamId != null && !this.UserIamId.Equals(input.UserIamId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.RepositoryRoleId != input.RepositoryRoleId || (this.RepositoryRoleId != null && !this.RepositoryRoleId.Equals(input.RepositoryRoleId))) return false;

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
                if (this.UserIamId != null) hashCode = hashCode * 59 + this.UserIamId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.RepositoryRoleId != null) hashCode = hashCode * 59 + this.RepositoryRoleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
