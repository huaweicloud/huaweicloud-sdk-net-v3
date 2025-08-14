using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetIdentityStoreSummaryResponse : SdkResponse
    {

        /// <summary>
        /// 已创建的用户数量
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public long? Users { get; set; }

        /// <summary>
        /// 用户配额
        /// </summary>
        [JsonProperty("users_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsersQuota { get; set; }

        /// <summary>
        /// 已创建的用户组数量
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public long? Groups { get; set; }

        /// <summary>
        /// 用户组配额
        /// </summary>
        [JsonProperty("groups_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? GroupsQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetIdentityStoreSummaryResponse {\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  usersQuota: ").Append(UsersQuota).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  groupsQuota: ").Append(GroupsQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetIdentityStoreSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetIdentityStoreSummaryResponse input)
        {
            if (input == null) return false;
            if (this.Users != input.Users || (this.Users != null && !this.Users.Equals(input.Users))) return false;
            if (this.UsersQuota != input.UsersQuota || (this.UsersQuota != null && !this.UsersQuota.Equals(input.UsersQuota))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && !this.Groups.Equals(input.Groups))) return false;
            if (this.GroupsQuota != input.GroupsQuota || (this.GroupsQuota != null && !this.GroupsQuota.Equals(input.GroupsQuota))) return false;

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
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.UsersQuota != null) hashCode = hashCode * 59 + this.UsersQuota.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.GroupsQuota != null) hashCode = hashCode * 59 + this.GroupsQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
