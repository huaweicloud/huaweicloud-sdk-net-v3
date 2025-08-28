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
    /// 中心网络ID。
    /// </summary>
    public class CentralNetworkId 
    {

        /// <summary>
        /// 中心网络ID。
        /// </summary>
        [JsonProperty("central_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _CentralNetworkId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkId {\n");
            sb.Append("  _centralNetworkId: ").Append(_CentralNetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkId input)
        {
            if (input == null) return false;
            if (this._CentralNetworkId != input._CentralNetworkId || (this._CentralNetworkId != null && !this._CentralNetworkId.Equals(input._CentralNetworkId))) return false;

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
                if (this._CentralNetworkId != null) hashCode = hashCode * 59 + this._CentralNetworkId.GetHashCode();
                return hashCode;
            }
        }
    }
}
