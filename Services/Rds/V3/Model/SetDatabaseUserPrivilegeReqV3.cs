using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetDatabaseUserPrivilegeReqV3 
    {

        /// <summary>
        /// 是否设置所有用户。
        /// </summary>
        [JsonProperty("all_users", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllUsers { get; set; }

        /// <summary>
        /// 数据库用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 是否为只读权限。
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDatabaseUserPrivilegeReqV3 {\n");
            sb.Append("  allUsers: ").Append(AllUsers).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetDatabaseUserPrivilegeReqV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetDatabaseUserPrivilegeReqV3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllUsers == input.AllUsers ||
                    (this.AllUsers != null &&
                    this.AllUsers.Equals(input.AllUsers))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Readonly == input.Readonly ||
                    (this.Readonly != null &&
                    this.Readonly.Equals(input.Readonly))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AllUsers != null)
                    hashCode = hashCode * 59 + this.AllUsers.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Readonly != null)
                    hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                return hashCode;
            }
        }
    }
}
