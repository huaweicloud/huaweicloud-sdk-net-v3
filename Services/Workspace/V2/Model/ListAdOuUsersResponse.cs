using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAdOuUsersResponse : SdkResponse
    {

        /// <summary>
        /// OU对象。
        /// </summary>
        [JsonProperty("user_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AdOuUserInfo> UserInfos { get; set; }

        /// <summary>
        /// 用户数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 可以创建的用户数量。
        /// </summary>
        [JsonProperty("enable_create_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnableCreateCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAdOuUsersResponse {\n");
            sb.Append("  userInfos: ").Append(UserInfos).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  enableCreateCount: ").Append(EnableCreateCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAdOuUsersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAdOuUsersResponse input)
        {
            if (input == null) return false;
            if (this.UserInfos != input.UserInfos || (this.UserInfos != null && input.UserInfos != null && !this.UserInfos.SequenceEqual(input.UserInfos))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.EnableCreateCount != input.EnableCreateCount || (this.EnableCreateCount != null && !this.EnableCreateCount.Equals(input.EnableCreateCount))) return false;

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
                if (this.UserInfos != null) hashCode = hashCode * 59 + this.UserInfos.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.EnableCreateCount != null) hashCode = hashCode * 59 + this.EnableCreateCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
