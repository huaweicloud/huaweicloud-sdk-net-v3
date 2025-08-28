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
    /// 中心网络平面ID。
    /// </summary>
    public class NonRequiredCentralNetworkPlaneId 
    {

        /// <summary>
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("central_network_plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkPlaneId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonRequiredCentralNetworkPlaneId {\n");
            sb.Append("  centralNetworkPlaneId: ").Append(CentralNetworkPlaneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NonRequiredCentralNetworkPlaneId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NonRequiredCentralNetworkPlaneId input)
        {
            if (input == null) return false;
            if (this.CentralNetworkPlaneId != input.CentralNetworkPlaneId || (this.CentralNetworkPlaneId != null && !this.CentralNetworkPlaneId.Equals(input.CentralNetworkPlaneId))) return false;

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
                if (this.CentralNetworkPlaneId != null) hashCode = hashCode * 59 + this.CentralNetworkPlaneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
