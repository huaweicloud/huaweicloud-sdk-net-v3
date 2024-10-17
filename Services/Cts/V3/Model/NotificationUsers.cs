using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 通知用户列表。
    /// </summary>
    public class NotificationUsers 
    {

        /// <summary>
        /// IAM用户组。
        /// </summary>
        [JsonProperty("user_group", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroup { get; set; }

        /// <summary>
        /// IAM用户。
        /// </summary>
        [JsonProperty("user_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationUsers {\n");
            sb.Append("  userGroup: ").Append(UserGroup).Append("\n");
            sb.Append("  userList: ").Append(UserList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationUsers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotificationUsers input)
        {
            if (input == null) return false;
            if (this.UserGroup != input.UserGroup || (this.UserGroup != null && !this.UserGroup.Equals(input.UserGroup))) return false;
            if (this.UserList != input.UserList || (this.UserList != null && input.UserList != null && !this.UserList.SequenceEqual(input.UserList))) return false;

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
                if (this.UserGroup != null) hashCode = hashCode * 59 + this.UserGroup.GetHashCode();
                if (this.UserList != null) hashCode = hashCode * 59 + this.UserList.GetHashCode();
                return hashCode;
            }
        }
    }
}
