using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 挂载用户信息。
    /// </summary>
    public class MountUser 
    {

        /// <summary>
        /// 用户ID(-1~65534的非0整数)
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户组ID(-1~65534的非0整数)
        /// </summary>
        [JsonProperty("user_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroupId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MountUser {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userGroupId: ").Append(UserGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MountUser);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MountUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserGroupId == input.UserGroupId ||
                    (this.UserGroupId != null &&
                    this.UserGroupId.Equals(input.UserGroupId))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserGroupId != null)
                    hashCode = hashCode * 59 + this.UserGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
