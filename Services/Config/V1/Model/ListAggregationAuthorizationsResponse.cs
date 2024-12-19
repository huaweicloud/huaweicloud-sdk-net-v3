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
    public class ListAggregationAuthorizationsResponse : SdkResponse
    {

        /// <summary>
        /// 授权过的资源聚合器帐号列表。
        /// </summary>
        [JsonProperty("aggregation_authorizations", NullValueHandling = NullValueHandling.Ignore)]
        public List<AggregationAuthorizationResp> AggregationAuthorizations { get; set; }

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
            sb.Append("class ListAggregationAuthorizationsResponse {\n");
            sb.Append("  aggregationAuthorizations: ").Append(AggregationAuthorizations).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAggregationAuthorizationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAggregationAuthorizationsResponse input)
        {
            if (input == null) return false;
            if (this.AggregationAuthorizations != input.AggregationAuthorizations || (this.AggregationAuthorizations != null && input.AggregationAuthorizations != null && !this.AggregationAuthorizations.SequenceEqual(input.AggregationAuthorizations))) return false;
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
                if (this.AggregationAuthorizations != null) hashCode = hashCode * 59 + this.AggregationAuthorizations.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
