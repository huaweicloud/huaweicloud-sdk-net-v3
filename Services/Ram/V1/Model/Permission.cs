using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// 有关RAM权限的信息。
    /// </summary>
    public class Permission 
    {

        /// <summary>
        /// 权限ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 权限名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 权限的影响和行为。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 该权限是否是此资源类型的默认权限。
        /// </summary>
        [JsonProperty("is_resource_type_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsResourceTypeDefault { get; set; }

        /// <summary>
        /// 权限的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 最后一次更新权限的时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 权限URN。
        /// </summary>
        [JsonProperty("permission_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionUrn { get; set; }

        /// <summary>
        /// 权限类型。
        /// </summary>
        [JsonProperty("permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionType { get; set; }

        /// <summary>
        /// 此权限是否为默认版本。
        /// </summary>
        [JsonProperty("default_version", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultVersion { get; set; }

        /// <summary>
        /// 权限版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <summary>
        /// 权限的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  isResourceTypeDefault: ").Append(IsResourceTypeDefault).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  permissionUrn: ").Append(PermissionUrn).Append("\n");
            sb.Append("  permissionType: ").Append(PermissionType).Append("\n");
            sb.Append("  defaultVersion: ").Append(DefaultVersion).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Permission);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Permission input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.IsResourceTypeDefault != input.IsResourceTypeDefault || (this.IsResourceTypeDefault != null && !this.IsResourceTypeDefault.Equals(input.IsResourceTypeDefault))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.PermissionUrn != input.PermissionUrn || (this.PermissionUrn != null && !this.PermissionUrn.Equals(input.PermissionUrn))) return false;
            if (this.PermissionType != input.PermissionType || (this.PermissionType != null && !this.PermissionType.Equals(input.PermissionType))) return false;
            if (this.DefaultVersion != input.DefaultVersion || (this.DefaultVersion != null && !this.DefaultVersion.Equals(input.DefaultVersion))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.IsResourceTypeDefault != null) hashCode = hashCode * 59 + this.IsResourceTypeDefault.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.PermissionUrn != null) hashCode = hashCode * 59 + this.PermissionUrn.GetHashCode();
                if (this.PermissionType != null) hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                if (this.DefaultVersion != null) hashCode = hashCode * 59 + this.DefaultVersion.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
