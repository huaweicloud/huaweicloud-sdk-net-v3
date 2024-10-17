using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 更新迁移用户请求体
    /// </summary>
    public class UpdateUserReq 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 全局密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 用户迁移信息，迁移用户时必填
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserAccountVO> List { get; set; }

        /// <summary>
        /// 角色迁移信息，迁移用户时必填
        /// </summary>
        [JsonProperty("user_roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserRoleVO> UserRoles { get; set; }

        /// <summary>
        /// 是否设置密码
        /// </summary>
        [JsonProperty("is_set_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSetPassword { get; set; }

        /// <summary>
        /// 是否迁移用户
        /// </summary>
        [JsonProperty("is_migrate_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMigrateUser { get; set; }

        /// <summary>
        /// 是否同步权限，不填默认为false，PG同步使用。
        /// </summary>
        [JsonProperty("is_sync_object_privilege", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSyncObjectPrivilege { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("  userRoles: ").Append(UserRoles).Append("\n");
            sb.Append("  isSetPassword: ").Append(IsSetPassword).Append("\n");
            sb.Append("  isMigrateUser: ").Append(IsMigrateUser).Append("\n");
            sb.Append("  isSyncObjectPrivilege: ").Append(IsSyncObjectPrivilege).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserReq input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.List != input.List || (this.List != null && input.List != null && !this.List.SequenceEqual(input.List))) return false;
            if (this.UserRoles != input.UserRoles || (this.UserRoles != null && input.UserRoles != null && !this.UserRoles.SequenceEqual(input.UserRoles))) return false;
            if (this.IsSetPassword != input.IsSetPassword || (this.IsSetPassword != null && !this.IsSetPassword.Equals(input.IsSetPassword))) return false;
            if (this.IsMigrateUser != input.IsMigrateUser || (this.IsMigrateUser != null && !this.IsMigrateUser.Equals(input.IsMigrateUser))) return false;
            if (this.IsSyncObjectPrivilege != input.IsSyncObjectPrivilege || (this.IsSyncObjectPrivilege != null && !this.IsSyncObjectPrivilege.Equals(input.IsSyncObjectPrivilege))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.List != null) hashCode = hashCode * 59 + this.List.GetHashCode();
                if (this.UserRoles != null) hashCode = hashCode * 59 + this.UserRoles.GetHashCode();
                if (this.IsSetPassword != null) hashCode = hashCode * 59 + this.IsSetPassword.GetHashCode();
                if (this.IsMigrateUser != null) hashCode = hashCode * 59 + this.IsMigrateUser.GetHashCode();
                if (this.IsSyncObjectPrivilege != null) hashCode = hashCode * 59 + this.IsSyncObjectPrivilege.GetHashCode();
                return hashCode;
            }
        }
    }
}
