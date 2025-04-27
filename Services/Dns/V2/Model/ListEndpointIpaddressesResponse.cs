using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEndpointIpaddressesResponse : SdkResponse
    {

        /// <summary>
        /// 列表数据结构。
        /// </summary>
        [JsonProperty("ipaddresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpaddressesData> Ipaddresses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEndpointIpaddressesResponse {\n");
            sb.Append("  ipaddresses: ").Append(Ipaddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEndpointIpaddressesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEndpointIpaddressesResponse input)
        {
            if (input == null) return false;
            if (this.Ipaddresses != input.Ipaddresses || (this.Ipaddresses != null && input.Ipaddresses != null && !this.Ipaddresses.SequenceEqual(input.Ipaddresses))) return false;

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
                if (this.Ipaddresses != null) hashCode = hashCode * 59 + this.Ipaddresses.GetHashCode();
                return hashCode;
            }
        }
    }
}
