using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddApplicationResponse : SdkResponse
    {

        /// <summary>
        /// 资源空间ID，唯一标识一个资源空间，由物联网平台在创建资源空间时分配。资源空间对应的是物联网平台原有的应用，在物联网平台的含义与应用一致，只是变更了名称。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 资源空间名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 资源空间创建时间，格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否为默认资源空间
        /// </summary>
        [JsonProperty("default_app", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultApp { get; set; }

        /// <summary>
        /// app的类型，标准版：Junior | 高级版：Normal
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// app与用户的授权关系时，响应为：all | bind | edit | query ，其中bind权限类似于ALL权限，属于子用户权限。
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public string Permission { get; set; }

        /// <summary>
        /// 迁移前实例ID。
        /// </summary>
        [JsonProperty("last_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastInstanceId { get; set; }

        /// <summary>
        /// 当前实例ID。
        /// </summary>
        [JsonProperty("current_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentInstanceId { get; set; }

        /// <summary>
        /// 对接的服务名
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 是否冻结
        /// </summary>
        [JsonProperty("freezed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Freezed { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddApplicationResponse {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  defaultApp: ").Append(DefaultApp).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  lastInstanceId: ").Append(LastInstanceId).Append("\n");
            sb.Append("  currentInstanceId: ").Append(CurrentInstanceId).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  freezed: ").Append(Freezed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddApplicationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddApplicationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.DefaultApp == input.DefaultApp ||
                    (this.DefaultApp != null &&
                    this.DefaultApp.Equals(input.DefaultApp))
                ) && 
                (
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.LastInstanceId == input.LastInstanceId ||
                    (this.LastInstanceId != null &&
                    this.LastInstanceId.Equals(input.LastInstanceId))
                ) && 
                (
                    this.CurrentInstanceId == input.CurrentInstanceId ||
                    (this.CurrentInstanceId != null &&
                    this.CurrentInstanceId.Equals(input.CurrentInstanceId))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Freezed == input.Freezed ||
                    (this.Freezed != null &&
                    this.Freezed.Equals(input.Freezed))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DefaultApp != null)
                    hashCode = hashCode * 59 + this.DefaultApp.GetHashCode();
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.LastInstanceId != null)
                    hashCode = hashCode * 59 + this.LastInstanceId.GetHashCode();
                if (this.CurrentInstanceId != null)
                    hashCode = hashCode * 59 + this.CurrentInstanceId.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.Freezed != null)
                    hashCode = hashCode * 59 + this.Freezed.GetHashCode();
                return hashCode;
            }
        }
    }
}
