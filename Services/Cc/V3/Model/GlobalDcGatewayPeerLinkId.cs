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
    /// GDGW的连接ID。
    /// </summary>
    public class GlobalDcGatewayPeerLinkId 
    {

        /// <summary>
        /// GDGW的连接ID。
        /// </summary>
        [JsonProperty("global_dc_gateway_peer_link_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _GlobalDcGatewayPeerLinkId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalDcGatewayPeerLinkId {\n");
            sb.Append("  _globalDcGatewayPeerLinkId: ").Append(_GlobalDcGatewayPeerLinkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalDcGatewayPeerLinkId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalDcGatewayPeerLinkId input)
        {
            if (input == null) return false;
            if (this._GlobalDcGatewayPeerLinkId != input._GlobalDcGatewayPeerLinkId || (this._GlobalDcGatewayPeerLinkId != null && !this._GlobalDcGatewayPeerLinkId.Equals(input._GlobalDcGatewayPeerLinkId))) return false;

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
                if (this._GlobalDcGatewayPeerLinkId != null) hashCode = hashCode * 59 + this._GlobalDcGatewayPeerLinkId.GetHashCode();
                return hashCode;
            }
        }
    }
}
