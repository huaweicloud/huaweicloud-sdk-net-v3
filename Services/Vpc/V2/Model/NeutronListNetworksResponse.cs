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
    public class NeutronListNetworksResponse : SdkResponse
    {

        /// <summary>
        /// network对象列表
        /// </summary>
        [JsonProperty("networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronNetwork> Networks { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("networks_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> NetworksLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListNetworksResponse {\n");
            sb.Append("  networks: ").Append(Networks).Append("\n");
            sb.Append("  networksLinks: ").Append(NetworksLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListNetworksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListNetworksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Networks == input.Networks ||
                    this.Networks != null &&
                    input.Networks != null &&
                    this.Networks.SequenceEqual(input.Networks)
                ) && 
                (
                    this.NetworksLinks == input.NetworksLinks ||
                    this.NetworksLinks != null &&
                    input.NetworksLinks != null &&
                    this.NetworksLinks.SequenceEqual(input.NetworksLinks)
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
                if (this.Networks != null)
                    hashCode = hashCode * 59 + this.Networks.GetHashCode();
                if (this.NetworksLinks != null)
                    hashCode = hashCode * 59 + this.NetworksLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
