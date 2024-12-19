using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceRelation 
    {

        /// <summary>
        /// 关系类型
        /// </summary>
        [JsonProperty("relation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationType { get; set; }

        /// <summary>
        /// 源资源类型
        /// </summary>
        [JsonProperty("from_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FromResourceType { get; set; }

        /// <summary>
        /// 目的资源类型
        /// </summary>
        [JsonProperty("to_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ToResourceType { get; set; }

        /// <summary>
        /// 源资源ID
        /// </summary>
        [JsonProperty("from_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FromResourceId { get; set; }

        /// <summary>
        /// 目的资源ID
        /// </summary>
        [JsonProperty("to_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ToResourceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceRelation {\n");
            sb.Append("  relationType: ").Append(RelationType).Append("\n");
            sb.Append("  fromResourceType: ").Append(FromResourceType).Append("\n");
            sb.Append("  toResourceType: ").Append(ToResourceType).Append("\n");
            sb.Append("  fromResourceId: ").Append(FromResourceId).Append("\n");
            sb.Append("  toResourceId: ").Append(ToResourceId).Append("\n");
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
            if (this.RelationType != input.RelationType || (this.RelationType != null && !this.RelationType.Equals(input.RelationType))) return false;
            if (this.FromResourceType != input.FromResourceType || (this.FromResourceType != null && !this.FromResourceType.Equals(input.FromResourceType))) return false;
            if (this.ToResourceType != input.ToResourceType || (this.ToResourceType != null && !this.ToResourceType.Equals(input.ToResourceType))) return false;
            if (this.FromResourceId != input.FromResourceId || (this.FromResourceId != null && !this.FromResourceId.Equals(input.FromResourceId))) return false;
            if (this.ToResourceId != input.ToResourceId || (this.ToResourceId != null && !this.ToResourceId.Equals(input.ToResourceId))) return false;

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
                if (this.RelationType != null) hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.FromResourceType != null) hashCode = hashCode * 59 + this.FromResourceType.GetHashCode();
                if (this.ToResourceType != null) hashCode = hashCode * 59 + this.ToResourceType.GetHashCode();
                if (this.FromResourceId != null) hashCode = hashCode * 59 + this.FromResourceId.GetHashCode();
                if (this.ToResourceId != null) hashCode = hashCode * 59 + this.ToResourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
