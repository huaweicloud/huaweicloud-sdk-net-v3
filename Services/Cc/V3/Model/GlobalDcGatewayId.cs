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
    /// Gdgw的ID。
    /// </summary>
    public class GlobalDcGatewayId 
    {

        /// <summary>
        /// Gdgw的ID。
        /// </summary>
        [JsonProperty("global_dc_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _GlobalDcGatewayId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalDcGatewayId {\n");
            sb.Append("  _globalDcGatewayId: ").Append(_GlobalDcGatewayId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalDcGatewayId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalDcGatewayId input)
        {
            if (input == null) return false;
            if (this._GlobalDcGatewayId != input._GlobalDcGatewayId || (this._GlobalDcGatewayId != null && !this._GlobalDcGatewayId.Equals(input._GlobalDcGatewayId))) return false;

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
                if (this._GlobalDcGatewayId != null) hashCode = hashCode * 59 + this._GlobalDcGatewayId.GetHashCode();
                return hashCode;
            }
        }
    }
}
