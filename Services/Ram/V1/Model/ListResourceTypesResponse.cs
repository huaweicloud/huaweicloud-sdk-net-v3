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
    /// Response Object
    /// </summary>
    public class ListResourceTypesResponse : SdkResponse
    {

        /// <summary>
        /// 云服务资源的详细信息列表。
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTypesSummary> ResourceTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceTypesResponse {\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceTypesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceTypesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceTypes == input.ResourceTypes ||
                    this.ResourceTypes != null &&
                    input.ResourceTypes != null &&
                    this.ResourceTypes.SequenceEqual(input.ResourceTypes)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.ResourceTypes != null)
                    hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
