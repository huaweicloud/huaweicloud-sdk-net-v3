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
    public class ListAppGroupRequest 
    {

        /// <summary>
        /// 单次查询的大小[1-100]，默认值10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询的偏移量，默认值0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 应用服务器组ID。
        /// </summary>
        [SDKProperty("app_server_group_id", IsQuery = true)]
        [JsonProperty("app_server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppServerGroupId { get; set; }

        /// <summary>
        /// 应用组ID。
        /// </summary>
        [SDKProperty("app_group_id", IsQuery = true)]
        [JsonProperty("app_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupId { get; set; }

        /// <summary>
        /// 应用组名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 授权类型： * &#x60;APP&#x60; - 应用 * &#x60;APP_GROUP&#x60; - 应用组
        /// </summary>
        [SDKProperty("authorization_type", IsQuery = true)]
        [JsonProperty("authorization_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// 应用组类型： * &#x60;SESSION_DESKTOP_APP&#x60; - 会话桌面app * &#x60;COMMON_APP&#x60; - 普通app
        /// </summary>
        [SDKProperty("app_type", IsQuery = true)]
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAppGroupRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  appServerGroupId: ").Append(AppServerGroupId).Append("\n");
            sb.Append("  appGroupId: ").Append(AppGroupId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  authorizationType: ").Append(AuthorizationType).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAppGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAppGroupRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.AppServerGroupId != input.AppServerGroupId || (this.AppServerGroupId != null && !this.AppServerGroupId.Equals(input.AppServerGroupId))) return false;
            if (this.AppGroupId != input.AppGroupId || (this.AppGroupId != null && !this.AppGroupId.Equals(input.AppGroupId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AuthorizationType != input.AuthorizationType || (this.AuthorizationType != null && !this.AuthorizationType.Equals(input.AuthorizationType))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.AppServerGroupId != null) hashCode = hashCode * 59 + this.AppServerGroupId.GetHashCode();
                if (this.AppGroupId != null) hashCode = hashCode * 59 + this.AppGroupId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AuthorizationType != null) hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                return hashCode;
            }
        }
    }
}
