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
    /// Request Object
    /// </summary>
    public class ListAdOuUsersRequest 
    {

        /// <summary>
        /// OU的域名地址
        /// </summary>
        [SDKProperty("ou_dn", IsQuery = true)]
        [JsonProperty("ou_dn", NullValueHandling = NullValueHandling.Ignore)]
        public string OuDn { get; set; }

        /// <summary>
        /// 用户名，支持模糊查询
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户是否已存在
        /// </summary>
        [SDKProperty("has_existed", IsQuery = true)]
        [JsonProperty("has_existed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasExisted { get; set; }

        /// <summary>
        /// 用于分页查询，返回桌面数量限制。如果不指定，则返回所有符合条件的桌面
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAdOuUsersRequest {\n");
            sb.Append("  ouDn: ").Append(OuDn).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  hasExisted: ").Append(HasExisted).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAdOuUsersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAdOuUsersRequest input)
        {
            if (input == null) return false;
            if (this.OuDn != input.OuDn || (this.OuDn != null && !this.OuDn.Equals(input.OuDn))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.HasExisted != input.HasExisted || (this.HasExisted != null && !this.HasExisted.Equals(input.HasExisted))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.OuDn != null) hashCode = hashCode * 59 + this.OuDn.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.HasExisted != null) hashCode = hashCode * 59 + this.HasExisted.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
