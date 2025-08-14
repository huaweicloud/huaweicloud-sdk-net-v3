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
    /// Response Object
    /// </summary>
    public class ListAllProvidersResponse : SdkResponse
    {

        /// <summary>
        /// 云服务详情列表
        /// </summary>
        [JsonProperty("resource_providers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceProviderResponse> ResourceProviders { get; set; }

        /// <summary>
        /// 当前支持的云服务总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllProvidersResponse {\n");
            sb.Append("  resourceProviders: ").Append(ResourceProviders).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllProvidersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllProvidersResponse input)
        {
            if (input == null) return false;
            if (this.ResourceProviders != input.ResourceProviders || (this.ResourceProviders != null && input.ResourceProviders != null && !this.ResourceProviders.SequenceEqual(input.ResourceProviders))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.ResourceProviders != null) hashCode = hashCode * 59 + this.ResourceProviders.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
