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
    public class ShowConfigurationAggregatorSourcesStatusResponse : SdkResponse
    {

        /// <summary>
        /// 资源聚合器状态列表。
        /// </summary>
        [JsonProperty("aggregated_source_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<AggregatedSourceStatus> AggregatedSourceStatuses { get; set; }

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
            sb.Append("class ShowConfigurationAggregatorSourcesStatusResponse {\n");
            sb.Append("  aggregatedSourceStatuses: ").Append(AggregatedSourceStatuses).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigurationAggregatorSourcesStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigurationAggregatorSourcesStatusResponse input)
        {
            if (input == null) return false;
            if (this.AggregatedSourceStatuses != input.AggregatedSourceStatuses || (this.AggregatedSourceStatuses != null && input.AggregatedSourceStatuses != null && !this.AggregatedSourceStatuses.SequenceEqual(input.AggregatedSourceStatuses))) return false;
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
                if (this.AggregatedSourceStatuses != null) hashCode = hashCode * 59 + this.AggregatedSourceStatuses.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
