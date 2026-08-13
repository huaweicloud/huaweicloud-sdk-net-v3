using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceRelation 
    {

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 关联资源类型
        /// </summary>
        [JsonProperty("related_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedResourceType { get; set; }

        /// <summary>
        /// 关联资源ID
        /// </summary>
        [JsonProperty("related_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedResourceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceRelation {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  relatedResourceType: ").Append(RelatedResourceType).Append("\n");
            sb.Append("  relatedResourceId: ").Append(RelatedResourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceRelation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceRelation input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.RelatedResourceType != input.RelatedResourceType || (this.RelatedResourceType != null && !this.RelatedResourceType.Equals(input.RelatedResourceType))) return false;
            if (this.RelatedResourceId != input.RelatedResourceId || (this.RelatedResourceId != null && !this.RelatedResourceId.Equals(input.RelatedResourceId))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.RelatedResourceType != null) hashCode = hashCode * 59 + this.RelatedResourceType.GetHashCode();
                if (this.RelatedResourceId != null) hashCode = hashCode * 59 + this.RelatedResourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
