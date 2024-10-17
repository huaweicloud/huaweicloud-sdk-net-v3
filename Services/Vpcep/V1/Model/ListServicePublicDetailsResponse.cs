using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServicePublicDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 终端节点服务列表。
        /// </summary>
        [JsonProperty("endpoint_services", NullValueHandling = NullValueHandling.Ignore)]
        public List<EndpointService> EndpointServices { get; set; }

        /// <summary>
        /// 满足查询条件的公共终端节点服务总条数，不受分页（即limit、offset参数）影响。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServicePublicDetailsResponse {\n");
            sb.Append("  endpointServices: ").Append(EndpointServices).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServicePublicDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServicePublicDetailsResponse input)
        {
            if (input == null) return false;
            if (this.EndpointServices != input.EndpointServices || (this.EndpointServices != null && input.EndpointServices != null && !this.EndpointServices.SequenceEqual(input.EndpointServices))) return false;
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
                if (this.EndpointServices != null) hashCode = hashCode * 59 + this.EndpointServices.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
