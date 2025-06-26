using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceInternalEndpointsResponse : SdkResponse
    {

        /// <summary>
        /// 内网访问列表
        /// </summary>
        [JsonProperty("internal_endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<InternalEndpoint> InternalEndpoints { get; set; }

        /// <summary>
        /// 内网访问总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceInternalEndpointsResponse {\n");
            sb.Append("  internalEndpoints: ").Append(InternalEndpoints).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceInternalEndpointsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceInternalEndpointsResponse input)
        {
            if (input == null) return false;
            if (this.InternalEndpoints != input.InternalEndpoints || (this.InternalEndpoints != null && input.InternalEndpoints != null && !this.InternalEndpoints.SequenceEqual(input.InternalEndpoints))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.InternalEndpoints != null) hashCode = hashCode * 59 + this.InternalEndpoints.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
