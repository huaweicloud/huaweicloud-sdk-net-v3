using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStarRocksDatabaseUserResponse : SdkResponse
    {

        /// <summary>
        /// 数据库账户信息。
        /// </summary>
        [JsonProperty("user_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStarRocksDatabaseUsersUserDetails> UserDetails { get; set; }

        /// <summary>
        /// 数据库账户数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStarRocksDatabaseUserResponse {\n");
            sb.Append("  userDetails: ").Append(UserDetails).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStarRocksDatabaseUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStarRocksDatabaseUserResponse input)
        {
            if (input == null) return false;
            if (this.UserDetails != input.UserDetails || (this.UserDetails != null && input.UserDetails != null && !this.UserDetails.SequenceEqual(input.UserDetails))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.UserDetails != null) hashCode = hashCode * 59 + this.UserDetails.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
