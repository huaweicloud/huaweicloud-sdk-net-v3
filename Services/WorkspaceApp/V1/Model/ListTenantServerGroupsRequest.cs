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
    /// Request Object
    /// </summary>
    public class ListTenantServerGroupsRequest 
    {

        /// <summary>
        /// 查询的偏移量，默认值0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的数量，值区间[1-100]，默认值10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 服务器组名称。
        /// </summary>
        [SDKProperty("sever_group_name", IsQuery = true)]
        [JsonProperty("sever_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverGroupName { get; set; }

        /// <summary>
        /// 应用组类型： * &#x60;SESSION_DESKTOP_APP&#x60; - 会话桌面app * &#x60;COMMON_APP&#x60; - 普通app
        /// </summary>
        [SDKProperty("app_type", IsQuery = true)]
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 是否为备服务器组，不传默认查所有： true : 是备服务器组。 false: 主服务器组，默认。
        /// </summary>
        [SDKProperty("is_secondary_server_group", IsQuery = true)]
        [JsonProperty("is_secondary_server_group", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSecondaryServerGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTenantServerGroupsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  severGroupName: ").Append(SeverGroupName).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  isSecondaryServerGroup: ").Append(IsSecondaryServerGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantServerGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantServerGroupsRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SeverGroupName != input.SeverGroupName || (this.SeverGroupName != null && !this.SeverGroupName.Equals(input.SeverGroupName))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.IsSecondaryServerGroup != input.IsSecondaryServerGroup || (this.IsSecondaryServerGroup != null && !this.IsSecondaryServerGroup.Equals(input.IsSecondaryServerGroup))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SeverGroupName != null) hashCode = hashCode * 59 + this.SeverGroupName.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.IsSecondaryServerGroup != null) hashCode = hashCode * 59 + this.IsSecondaryServerGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
