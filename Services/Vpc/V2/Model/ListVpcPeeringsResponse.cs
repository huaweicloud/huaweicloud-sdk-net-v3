using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListVpcPeeringsResponse : SdkResponse
    {

        /// <summary>
        /// peering对象列表
        /// </summary>
        [JsonProperty("peerings", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcPeering> Peerings { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("peerings_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> PeeringsLinks { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVpcPeeringsResponse {\n");
            sb.Append("  peerings: ").Append(Peerings).Append("\n");
            sb.Append("  peeringsLinks: ").Append(PeeringsLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVpcPeeringsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVpcPeeringsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Peerings == input.Peerings ||
                    this.Peerings != null &&
                    input.Peerings != null &&
                    this.Peerings.SequenceEqual(input.Peerings)
                ) && 
                (
                    this.PeeringsLinks == input.PeeringsLinks ||
                    this.PeeringsLinks != null &&
                    input.PeeringsLinks != null &&
                    this.PeeringsLinks.SequenceEqual(input.PeeringsLinks)
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
                if (this.Peerings != null)
                    hashCode = hashCode * 59 + this.Peerings.GetHashCode();
                if (this.PeeringsLinks != null)
                    hashCode = hashCode * 59 + this.PeeringsLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
