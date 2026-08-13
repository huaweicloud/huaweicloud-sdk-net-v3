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
    /// Request Object
    /// </summary>
    public class ShowResourceRelationsRequest 
    {

        /// <summary>
        /// 资源ID
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [SDKProperty("related_resource_id", IsQuery = true)]
        [JsonProperty("related_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedResourceId { get; set; }

        /// <summary>
        /// 关联资源类型
        /// </summary>
        [SDKProperty("related_resource_type", IsQuery = true)]
        [JsonProperty("related_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedResourceType { get; set; }

        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResourceRelationsRequest {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  relatedResourceId: ").Append(RelatedResourceId).Append("\n");
            sb.Append("  relatedResourceType: ").Append(RelatedResourceType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResourceRelationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResourceRelationsRequest input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.RelatedResourceId != input.RelatedResourceId || (this.RelatedResourceId != null && !this.RelatedResourceId.Equals(input.RelatedResourceId))) return false;
            if (this.RelatedResourceType != input.RelatedResourceType || (this.RelatedResourceType != null && !this.RelatedResourceType.Equals(input.RelatedResourceType))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.RelatedResourceId != null) hashCode = hashCode * 59 + this.RelatedResourceId.GetHashCode();
                if (this.RelatedResourceType != null) hashCode = hashCode * 59 + this.RelatedResourceType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
