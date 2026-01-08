using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHostsDetailResponse : SdkResponse
    {

        /// <summary>
        /// 云办公主机列表。
        /// </summary>
        [JsonProperty("dedicated_hosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListHostsRspDedicatedHosts> DedicatedHosts { get; set; }

        /// <summary>
        /// 总共条数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHostsDetailResponse {\n");
            sb.Append("  dedicatedHosts: ").Append(DedicatedHosts).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHostsDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHostsDetailResponse input)
        {
            if (input == null) return false;
            if (this.DedicatedHosts != input.DedicatedHosts || (this.DedicatedHosts != null && input.DedicatedHosts != null && !this.DedicatedHosts.SequenceEqual(input.DedicatedHosts))) return false;
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
                if (this.DedicatedHosts != null) hashCode = hashCode * 59 + this.DedicatedHosts.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
