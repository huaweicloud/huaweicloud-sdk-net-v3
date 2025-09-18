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
    /// 创建应用组,允许创建应用组之后再绑定应用服务器组。
    /// </summary>
    public class CreateAppGroupReq 
    {

        /// <summary>
        /// 应用组名称,名称需满足如下规则: 1. 由中文，英文大小写，数字，_-组成。 2. 长度范围1~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用服务器组ID。
        /// </summary>
        [JsonProperty("app_server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppServerGroupId { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public AppTypeEnum? AppType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppGroupReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  appServerGroupId: ").Append(AppServerGroupId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CreateAppGroupReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAppGroupReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AppServerGroupId != input.AppServerGroupId || (this.AppServerGroupId != null && !this.AppServerGroupId.Equals(input.AppServerGroupId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AppServerGroupId != null) hashCode = hashCode * 59 + this.AppServerGroupId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AuthorizationType != null) hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                return hashCode;
            }
        }
    }
}
