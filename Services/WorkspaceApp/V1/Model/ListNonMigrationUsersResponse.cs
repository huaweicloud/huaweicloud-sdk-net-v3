using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListNonMigrationUsersResponse : SdkResponse
    {

        /// <summary>
        /// 热点时不迁移用户id总数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 热点时不迁移用户id列表。
        /// </summary>
        [JsonProperty("non_migrate_users", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserInfo> NonMigrateUsers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNonMigrationUsersResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  nonMigrateUsers: ").Append(NonMigrateUsers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNonMigrationUsersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNonMigrationUsersResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.NonMigrateUsers != input.NonMigrateUsers || (this.NonMigrateUsers != null && input.NonMigrateUsers != null && !this.NonMigrateUsers.SequenceEqual(input.NonMigrateUsers))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.NonMigrateUsers != null) hashCode = hashCode * 59 + this.NonMigrateUsers.GetHashCode();
                return hashCode;
            }
        }
    }
}
