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
    public class ListEndpointVpcsResponse : SdkResponse
    {

        /// <summary>
        /// 终端节点VPC列表。
        /// </summary>
        [JsonProperty("vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcsData> Vpcs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEndpointVpcsResponse {\n");
            sb.Append("  vpcs: ").Append(Vpcs).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEndpointVpcsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEndpointVpcsResponse input)
        {
            if (input == null) return false;
            if (this.Vpcs != input.Vpcs || (this.Vpcs != null && input.Vpcs != null && !this.Vpcs.SequenceEqual(input.Vpcs))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;

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
                if (this.Vpcs != null) hashCode = hashCode * 59 + this.Vpcs.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
