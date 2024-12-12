using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListUsersRequest 
    {

        /// <summary>
        /// 组织id，为空时查询所有用户。
        /// </summary>
        [SDKProperty("org_id", IsQuery = true)]
        [JsonProperty("org_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgId { get; set; }

        /// <summary>
        /// 第几页。最小值：0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页多少条。最小值：10。最大值：100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 最长64位，用户名，支持模糊查询
        /// </summary>
        [SDKProperty("user_info", IsQuery = true)]
        [JsonProperty("user_info", NullValueHandling = NullValueHandling.Ignore)]
        public string UserInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsersRequest {\n");
            sb.Append("  orgId: ").Append(OrgId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  userInfo: ").Append(UserInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsersRequest input)
        {
            if (input == null) return false;
            if (this.OrgId != input.OrgId || (this.OrgId != null && !this.OrgId.Equals(input.OrgId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.UserInfo != input.UserInfo || (this.UserInfo != null && !this.UserInfo.Equals(input.UserInfo))) return false;

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
                if (this.OrgId != null) hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.UserInfo != null) hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
