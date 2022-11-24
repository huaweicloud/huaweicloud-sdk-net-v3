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
    /// 
    /// </summary>
    public class VpcsData 
    {

        /// <summary>
        /// vpc的ID，uuid形式的一个资源标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// vpc下入站终端节点的数量。
        /// </summary>
        [JsonProperty("inbound_endpoint_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? InboundEndpointCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpcsData {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  inboundEndpointCount: ").Append(InboundEndpointCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpcsData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VpcsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InboundEndpointCount == input.InboundEndpointCount ||
                    (this.InboundEndpointCount != null &&
                    this.InboundEndpointCount.Equals(input.InboundEndpointCount))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InboundEndpointCount != null)
                    hashCode = hashCode * 59 + this.InboundEndpointCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
