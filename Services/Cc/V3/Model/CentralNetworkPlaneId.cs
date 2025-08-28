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
    public class CentralNetworkPlaneId 
    {

        /// <summary>
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("central_network_plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _CentralNetworkPlaneId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkPlaneId {\n");
            sb.Append("  _centralNetworkPlaneId: ").Append(_CentralNetworkPlaneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkPlaneId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkPlaneId input)
        {
            if (input == null) return false;
            if (this._CentralNetworkPlaneId != input._CentralNetworkPlaneId || (this._CentralNetworkPlaneId != null && !this._CentralNetworkPlaneId.Equals(input._CentralNetworkPlaneId))) return false;

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
                if (this._CentralNetworkPlaneId != null) hashCode = hashCode * 59 + this._CentralNetworkPlaneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
