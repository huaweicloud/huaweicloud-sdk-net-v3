using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 用户迁移信息体。
    /// </summary>
    public class UserMigrationInfo 
    {

        /// <summary>
        /// 是否迁移用户。
        /// </summary>
        [JsonProperty("is_migrate_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMigrateUser { get; set; }

        /// <summary>
        /// 是否统一重置密码。取值： - true：重置密码为统一密码。 - false：不统一重置密码。 当前支持的场景：  - 实时迁移场景：MySQL迁移。
        /// </summary>
        [JsonProperty("is_set_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSetPassword { get; set; }

        /// <summary>
        /// 重置后的统一密码。统一重置密码为true时必填。 约束：密码不能为空。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserMigrationList> UserList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("role_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserMigrationRole> RoleList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserMigrationInfo {\n");
            sb.Append("  isMigrateUser: ").Append(IsMigrateUser).Append("\n");
            sb.Append("  isSetPassword: ").Append(IsSetPassword).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  userList: ").Append(UserList).Append("\n");
            sb.Append("  roleList: ").Append(RoleList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserMigrationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserMigrationInfo input)
        {
            if (input == null) return false;
            if (this.IsMigrateUser != input.IsMigrateUser || (this.IsMigrateUser != null && !this.IsMigrateUser.Equals(input.IsMigrateUser))) return false;
            if (this.IsSetPassword != input.IsSetPassword || (this.IsSetPassword != null && !this.IsSetPassword.Equals(input.IsSetPassword))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.UserList != input.UserList || (this.UserList != null && input.UserList != null && !this.UserList.SequenceEqual(input.UserList))) return false;
            if (this.RoleList != input.RoleList || (this.RoleList != null && input.RoleList != null && !this.RoleList.SequenceEqual(input.RoleList))) return false;

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
                if (this.IsMigrateUser != null) hashCode = hashCode * 59 + this.IsMigrateUser.GetHashCode();
                if (this.IsSetPassword != null) hashCode = hashCode * 59 + this.IsSetPassword.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.UserList != null) hashCode = hashCode * 59 + this.UserList.GetHashCode();
                if (this.RoleList != null) hashCode = hashCode * 59 + this.RoleList.GetHashCode();
                return hashCode;
            }
        }
    }
}
