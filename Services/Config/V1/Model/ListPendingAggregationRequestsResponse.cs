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
    public class ListPendingAggregationRequestsResponse : SdkResponse
    {

        /// <summary>
        /// 挂起的聚合请求列表。
        /// </summary>
        [JsonProperty("pending_aggregation_requests", NullValueHandling = NullValueHandling.Ignore)]
        public List<PendingAggregationRequest> PendingAggregationRequests { get; set; }

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
            sb.Append("class ListPendingAggregationRequestsResponse {\n");
            sb.Append("  pendingAggregationRequests: ").Append(PendingAggregationRequests).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPendingAggregationRequestsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPendingAggregationRequestsResponse input)
        {
            if (input == null) return false;
            if (this.PendingAggregationRequests != input.PendingAggregationRequests || (this.PendingAggregationRequests != null && input.PendingAggregationRequests != null && !this.PendingAggregationRequests.SequenceEqual(input.PendingAggregationRequests))) return false;
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
                if (this.PendingAggregationRequests != null) hashCode = hashCode * 59 + this.PendingAggregationRequests.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
