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
    /// 当前网络与其他网络的连接信息。
    /// </summary>
    public class NetworkConnection 
    {

        /// <summary>
        /// **参数解释**：Peer方式打通网络列表。
        /// </summary>
        [JsonProperty("peerConnectionList", NullValueHandling = NullValueHandling.Ignore)]
        public List<PeerConnectionItem> PeerConnectionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkConnection {\n");
            sb.Append("  peerConnectionList: ").Append(PeerConnectionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkConnection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkConnection input)
        {
            if (input == null) return false;
            if (this.PeerConnectionList != input.PeerConnectionList || (this.PeerConnectionList != null && input.PeerConnectionList != null && !this.PeerConnectionList.SequenceEqual(input.PeerConnectionList))) return false;

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
                if (this.PeerConnectionList != null) hashCode = hashCode * 59 + this.PeerConnectionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
