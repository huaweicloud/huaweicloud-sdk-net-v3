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
    /// 当前网络与其他云服务的连接状态信息。
    /// </summary>
    public class NetworkConnectionStatus 
    {

        /// <summary>
        /// **参数解释**：Peer方式打通网络的状态信息列表。
        /// </summary>
        [JsonProperty("peerConnectionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<PeerConnectionStatus> PeerConnectionStatus { get; set; }

        /// <summary>
        /// **参数解释**：网络可连通的SFS Turbo信息列表。
        /// </summary>
        [JsonProperty("sfsTurboStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<SfsTurboConnectionStatus> SfsTurboStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkConnectionStatus {\n");
            sb.Append("  peerConnectionStatus: ").Append(PeerConnectionStatus).Append("\n");
            sb.Append("  sfsTurboStatus: ").Append(SfsTurboStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkConnectionStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkConnectionStatus input)
        {
            if (input == null) return false;
            if (this.PeerConnectionStatus != input.PeerConnectionStatus || (this.PeerConnectionStatus != null && input.PeerConnectionStatus != null && !this.PeerConnectionStatus.SequenceEqual(input.PeerConnectionStatus))) return false;
            if (this.SfsTurboStatus != input.SfsTurboStatus || (this.SfsTurboStatus != null && input.SfsTurboStatus != null && !this.SfsTurboStatus.SequenceEqual(input.SfsTurboStatus))) return false;

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
                if (this.PeerConnectionStatus != null) hashCode = hashCode * 59 + this.PeerConnectionStatus.GetHashCode();
                if (this.SfsTurboStatus != null) hashCode = hashCode * 59 + this.SfsTurboStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
