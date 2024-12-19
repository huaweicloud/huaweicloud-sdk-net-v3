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
    public class ResourceResp 
    {

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源详情。 资源对象，用于扩展。默认为空
        /// </summary>
        [JsonProperty("resource_detail", NullValueHandling = NullValueHandling.Ignore)]
        public Object ResourceDetail { get; set; }

        /// <summary>
        /// 标签列表，没有标签默认为空数组
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }

        /// <summary>
        /// 资源名称，资源没有名称时默认为空字符串，eip返回ip地址。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceResp {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceDetail: ").Append(ResourceDetail).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceResp input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceDetail != input.ResourceDetail || (this.ResourceDetail != null && !this.ResourceDetail.Equals(input.ResourceDetail))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;

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
                if (this.ResourceDetail != null) hashCode = hashCode * 59 + this.ResourceDetail.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
