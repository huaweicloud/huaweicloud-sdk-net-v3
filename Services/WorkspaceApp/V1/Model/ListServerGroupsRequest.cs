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
    public class ListServerGroupsRequest 
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
        [SDKProperty("server_group_name", IsQuery = true)]
        [JsonProperty("server_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// 服务器组唯一标识。
        /// </summary>
        [SDKProperty("server_group_id", IsQuery = true)]
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 应用组类型： * &#x60;SESSION_DESKTOP_APP&#x60; - 会话桌面app * &#x60;COMMON_APP&#x60; - 普通app
        /// </summary>
        [SDKProperty("app_type", IsQuery = true)]
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 查询tag字段中包含该值的服务器组。
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 企业项目ID(字段为空或者0表示使用默认default企业项目)。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

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
            sb.Append("class ListServerGroupsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  serverGroupName: ").Append(ServerGroupName).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  isSecondaryServerGroup: ").Append(IsSecondaryServerGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServerGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServerGroupsRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ServerGroupName != input.ServerGroupName || (this.ServerGroupName != null && !this.ServerGroupName.Equals(input.ServerGroupName))) return false;
            if (this.ServerGroupId != input.ServerGroupId || (this.ServerGroupId != null && !this.ServerGroupId.Equals(input.ServerGroupId))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
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
                if (this.ServerGroupName != null) hashCode = hashCode * 59 + this.ServerGroupName.GetHashCode();
                if (this.ServerGroupId != null) hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsSecondaryServerGroup != null) hashCode = hashCode * 59 + this.IsSecondaryServerGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
