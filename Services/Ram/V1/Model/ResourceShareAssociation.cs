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
    /// 与资源共享实例关联的资源使用者或共享资源的详细信息。
    /// </summary>
    public class ResourceShareAssociation 
    {

        /// <summary>
        /// 绑定的实体。这可以是共享资源的URN、账号ID、组织根的URN或OU的URN之一。
        /// </summary>
        [JsonProperty("associated_entity", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedEntity { get; set; }

        /// <summary>
        /// 绑定中包含的实体类型。
        /// </summary>
        [JsonProperty("association_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociationType { get; set; }

        /// <summary>
        /// 绑定被创建的时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 最后一次更新绑定的时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 标识资源使用者是否和共享的拥有者属于同一个组织
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; }

        /// <summary>
        /// 资源共享实例的ID。
        /// </summary>
        [JsonProperty("resource_share_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareId { get; set; }

        /// <summary>
        /// 资源共享实例的名称。
        /// </summary>
        [JsonProperty("resource_share_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareName { get; set; }

        /// <summary>
        /// 绑定的当前状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 绑定的当前状态的描述。
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceShareAssociation {\n");
            sb.Append("  associatedEntity: ").Append(AssociatedEntity).Append("\n");
            sb.Append("  associationType: ").Append(AssociationType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  external: ").Append(External).Append("\n");
            sb.Append("  resourceShareId: ").Append(ResourceShareId).Append("\n");
            sb.Append("  resourceShareName: ").Append(ResourceShareName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceShareAssociation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceShareAssociation input)
        {
            if (input == null) return false;
            if (this.AssociatedEntity != input.AssociatedEntity || (this.AssociatedEntity != null && !this.AssociatedEntity.Equals(input.AssociatedEntity))) return false;
            if (this.AssociationType != input.AssociationType || (this.AssociationType != null && !this.AssociationType.Equals(input.AssociationType))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.External != input.External || (this.External != null && !this.External.Equals(input.External))) return false;
            if (this.ResourceShareId != input.ResourceShareId || (this.ResourceShareId != null && !this.ResourceShareId.Equals(input.ResourceShareId))) return false;
            if (this.ResourceShareName != input.ResourceShareName || (this.ResourceShareName != null && !this.ResourceShareName.Equals(input.ResourceShareName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusMessage != input.StatusMessage || (this.StatusMessage != null && !this.StatusMessage.Equals(input.StatusMessage))) return false;

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
                if (this.AssociatedEntity != null) hashCode = hashCode * 59 + this.AssociatedEntity.GetHashCode();
                if (this.AssociationType != null) hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.External != null) hashCode = hashCode * 59 + this.External.GetHashCode();
                if (this.ResourceShareId != null) hashCode = hashCode * 59 + this.ResourceShareId.GetHashCode();
                if (this.ResourceShareName != null) hashCode = hashCode * 59 + this.ResourceShareName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null) hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
