using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Peer方式打通网络参数模型。
    /// </summary>
    public class PeerConnectionItem 
    {

        /// <summary>
        /// **参数解释**：对端的VPC ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("peerVpcId", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerVpcId { get; set; }

        /// <summary>
        /// **参数解释**：对端的子网ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("peerSubnetId", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerSubnetId { get; set; }

        /// <summary>
        /// **参数解释**：创建默认路由的开关，默认为false不创建。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("defaultGateWay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultGateWay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeerConnectionItem {\n");
            sb.Append("  peerVpcId: ").Append(PeerVpcId).Append("\n");
            sb.Append("  peerSubnetId: ").Append(PeerSubnetId).Append("\n");
            sb.Append("  defaultGateWay: ").Append(DefaultGateWay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeerConnectionItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PeerConnectionItem input)
        {
            if (input == null) return false;
            if (this.PeerVpcId != input.PeerVpcId || (this.PeerVpcId != null && !this.PeerVpcId.Equals(input.PeerVpcId))) return false;
            if (this.PeerSubnetId != input.PeerSubnetId || (this.PeerSubnetId != null && !this.PeerSubnetId.Equals(input.PeerSubnetId))) return false;
            if (this.DefaultGateWay != input.DefaultGateWay || (this.DefaultGateWay != null && !this.DefaultGateWay.Equals(input.DefaultGateWay))) return false;

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
                if (this.PeerVpcId != null) hashCode = hashCode * 59 + this.PeerVpcId.GetHashCode();
                if (this.PeerSubnetId != null) hashCode = hashCode * 59 + this.PeerSubnetId.GetHashCode();
                if (this.DefaultGateWay != null) hashCode = hashCode * 59 + this.DefaultGateWay.GetHashCode();
                return hashCode;
            }
        }
    }
}
