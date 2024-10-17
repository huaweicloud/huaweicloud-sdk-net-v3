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
    public class ListServiceConnectionsResponse : SdkResponse
    {

        /// <summary>
        /// 连接列表。
        /// </summary>
        [JsonProperty("connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectionEndpoints> Connections { get; set; }

        /// <summary>
        /// 满足查询条件的终端节点总条数，不受分页（即limit、offset参数）影响。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServiceConnectionsResponse {\n");
            sb.Append("  connections: ").Append(Connections).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServiceConnectionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServiceConnectionsResponse input)
        {
            if (input == null) return false;
            if (this.Connections != input.Connections || (this.Connections != null && input.Connections != null && !this.Connections.SequenceEqual(input.Connections))) return false;
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
                if (this.Connections != null) hashCode = hashCode * 59 + this.Connections.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
