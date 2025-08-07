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
    public class SearchDistinctSharedResourcesResponse : SdkResponse
    {

        /// <summary>
        /// 不同资源的信息列表。
        /// </summary>
        [JsonProperty("distinct_shared_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<DistinctSharedResource> DistinctSharedResources { get; set; }

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
            sb.Append("class SearchDistinctSharedResourcesResponse {\n");
            sb.Append("  distinctSharedResources: ").Append(DistinctSharedResources).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchDistinctSharedResourcesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchDistinctSharedResourcesResponse input)
        {
            if (input == null) return false;
            if (this.DistinctSharedResources != input.DistinctSharedResources || (this.DistinctSharedResources != null && input.DistinctSharedResources != null && !this.DistinctSharedResources.SequenceEqual(input.DistinctSharedResources))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.DistinctSharedResources != null) hashCode = hashCode * 59 + this.DistinctSharedResources.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
