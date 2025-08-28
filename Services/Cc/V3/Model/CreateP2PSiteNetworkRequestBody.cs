using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 创建P2P类型的分支网络的请求体。
    /// </summary>
    public class CreateP2PSiteNetworkRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("p2p_site_network", NullValueHandling = NullValueHandling.Ignore)]
        public CreateP2PSiteNetwork P2pSiteNetwork { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateP2PSiteNetworkRequestBody {\n");
            sb.Append("  p2pSiteNetwork: ").Append(P2pSiteNetwork).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateP2PSiteNetworkRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateP2PSiteNetworkRequestBody input)
        {
            if (input == null) return false;
            if (this.P2pSiteNetwork != input.P2pSiteNetwork || (this.P2pSiteNetwork != null && !this.P2pSiteNetwork.Equals(input.P2pSiteNetwork))) return false;

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
                if (this.P2pSiteNetwork != null) hashCode = hashCode * 59 + this.P2pSiteNetwork.GetHashCode();
                return hashCode;
            }
        }
    }
}
