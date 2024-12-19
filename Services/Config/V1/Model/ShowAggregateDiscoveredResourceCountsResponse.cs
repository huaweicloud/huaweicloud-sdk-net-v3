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
    public class ShowAggregateDiscoveredResourceCountsResponse : SdkResponse
    {

        /// <summary>
        /// 资源计数进行分组的键。
        /// </summary>
        [JsonProperty("group_by_key", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupByKey { get; set; }

        /// <summary>
        /// 分组资源计数的列表。
        /// </summary>
        [JsonProperty("grouped_resource_counts", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupedResourceCount> GroupedResourceCounts { get; set; }

        /// <summary>
        /// 指定过滤器的资源聚合器中存在的资源总数。
        /// </summary>
        [JsonProperty("total_discovered_resources", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiscoveredResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAggregateDiscoveredResourceCountsResponse {\n");
            sb.Append("  groupByKey: ").Append(GroupByKey).Append("\n");
            sb.Append("  groupedResourceCounts: ").Append(GroupedResourceCounts).Append("\n");
            sb.Append("  totalDiscoveredResources: ").Append(TotalDiscoveredResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAggregateDiscoveredResourceCountsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAggregateDiscoveredResourceCountsResponse input)
        {
            if (input == null) return false;
            if (this.GroupByKey != input.GroupByKey || (this.GroupByKey != null && !this.GroupByKey.Equals(input.GroupByKey))) return false;
            if (this.GroupedResourceCounts != input.GroupedResourceCounts || (this.GroupedResourceCounts != null && input.GroupedResourceCounts != null && !this.GroupedResourceCounts.SequenceEqual(input.GroupedResourceCounts))) return false;
            if (this.TotalDiscoveredResources != input.TotalDiscoveredResources || (this.TotalDiscoveredResources != null && !this.TotalDiscoveredResources.Equals(input.TotalDiscoveredResources))) return false;

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
                if (this.GroupByKey != null) hashCode = hashCode * 59 + this.GroupByKey.GetHashCode();
                if (this.GroupedResourceCounts != null) hashCode = hashCode * 59 + this.GroupedResourceCounts.GetHashCode();
                if (this.TotalDiscoveredResources != null) hashCode = hashCode * 59 + this.TotalDiscoveredResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
