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
    public class CreateAppGroupResponse : SdkResponse
    {

        /// <summary>
        /// 应用组ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 应用组名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用服务器组ID。
        /// </summary>
        [JsonProperty("app_server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppServerGroupId { get; set; }

        /// <summary>
        /// 应用服务器组名称。
        /// </summary>
        [JsonProperty("app_server_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppServerGroupName { get; set; }

        /// <summary>
        /// 应用组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthorizationTypeEnum? AuthorizationType { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public AppTypeEnum? AppType { get; set; }

        /// <summary>
        /// 发布时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateAt { get; set; }

        /// <summary>
        /// 应用数量。
        /// </summary>
        [JsonProperty("app_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppGroupResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  appServerGroupId: ").Append(AppServerGroupId).Append("\n");
            sb.Append("  appServerGroupName: ").Append(AppServerGroupName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  authorizationType: ").Append(AuthorizationType).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  appCount: ").Append(AppCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAppGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAppGroupResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AppServerGroupId != input.AppServerGroupId || (this.AppServerGroupId != null && !this.AppServerGroupId.Equals(input.AppServerGroupId))) return false;
            if (this.AppServerGroupName != input.AppServerGroupName || (this.AppServerGroupName != null && !this.AppServerGroupName.Equals(input.AppServerGroupName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AuthorizationType != input.AuthorizationType || (this.AuthorizationType != null && !this.AuthorizationType.Equals(input.AuthorizationType))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.AppCount != input.AppCount || (this.AppCount != null && !this.AppCount.Equals(input.AppCount))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AppServerGroupId != null) hashCode = hashCode * 59 + this.AppServerGroupId.GetHashCode();
                if (this.AppServerGroupName != null) hashCode = hashCode * 59 + this.AppServerGroupName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AuthorizationType != null) hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.AppCount != null) hashCode = hashCode * 59 + this.AppCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
