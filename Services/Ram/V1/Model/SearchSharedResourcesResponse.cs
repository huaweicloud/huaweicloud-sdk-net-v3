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
    public class SearchSharedResourcesResponse : SdkResponse
    {

        /// <summary>
        /// 共享资源的信息列表。
        /// </summary>
        [JsonProperty("shared_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SharedResource> SharedResources { get; set; }

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
            sb.Append("class SearchSharedResourcesResponse {\n");
            sb.Append("  sharedResources: ").Append(SharedResources).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchSharedResourcesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchSharedResourcesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharedResources == input.SharedResources ||
                    this.SharedResources != null &&
                    input.SharedResources != null &&
                    this.SharedResources.SequenceEqual(input.SharedResources)
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
                if (this.SharedResources != null)
                    hashCode = hashCode * 59 + this.SharedResources.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
