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
    /// The request body of the CreateResourceShare operation.
    /// </summary>
    public class CreateResourceShareReqBody 
    {

        /// <summary>
        /// 资源共享实例的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源共享实例的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 资源共享实例是否支持共享给组织外账号。
        /// </summary>
        [JsonProperty("allow_external_principals", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowExternalPrincipals { get; set; }

        /// <summary>
        /// 资源共享实例关联的RAM权限列表。一种资源类型只能关联一个RAM权限。如果您没有指定权限ID，RAM将自动为每个资源类型关联默认权限。
        /// </summary>
        [JsonProperty("permission_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PermissionIds { get; set; }

        /// <summary>
        /// 资源共享实例关联的一个或多个资源使用者的列表。
        /// </summary>
        [JsonProperty("principals", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Principals { get; set; }

        /// <summary>
        /// 资源共享实例关联的一个或多个共享资源URN的列表。
        /// </summary>
        [JsonProperty("resource_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceUrns { get; set; }

        /// <summary>
        /// 资源共享标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResourceShareReqBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  allowExternalPrincipals: ").Append(AllowExternalPrincipals).Append("\n");
            sb.Append("  permissionIds: ").Append(PermissionIds).Append("\n");
            sb.Append("  principals: ").Append(Principals).Append("\n");
            sb.Append("  resourceUrns: ").Append(ResourceUrns).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateResourceShareReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateResourceShareReqBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AllowExternalPrincipals != input.AllowExternalPrincipals || (this.AllowExternalPrincipals != null && !this.AllowExternalPrincipals.Equals(input.AllowExternalPrincipals))) return false;
            if (this.PermissionIds != input.PermissionIds || (this.PermissionIds != null && input.PermissionIds != null && !this.PermissionIds.SequenceEqual(input.PermissionIds))) return false;
            if (this.Principals != input.Principals || (this.Principals != null && input.Principals != null && !this.Principals.SequenceEqual(input.Principals))) return false;
            if (this.ResourceUrns != input.ResourceUrns || (this.ResourceUrns != null && input.ResourceUrns != null && !this.ResourceUrns.SequenceEqual(input.ResourceUrns))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AllowExternalPrincipals != null) hashCode = hashCode * 59 + this.AllowExternalPrincipals.GetHashCode();
                if (this.PermissionIds != null) hashCode = hashCode * 59 + this.PermissionIds.GetHashCode();
                if (this.Principals != null) hashCode = hashCode * 59 + this.Principals.GetHashCode();
                if (this.ResourceUrns != null) hashCode = hashCode * 59 + this.ResourceUrns.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
