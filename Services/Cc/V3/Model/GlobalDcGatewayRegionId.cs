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
    /// Gdgw的RegionID。
    /// </summary>
    public class GlobalDcGatewayRegionId 
    {

        /// <summary>
        /// Gdgw的RegionID。
        /// </summary>
        [JsonProperty("global_dc_gateway_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _GlobalDcGatewayRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalDcGatewayRegionId {\n");
            sb.Append("  _globalDcGatewayRegionId: ").Append(_GlobalDcGatewayRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalDcGatewayRegionId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalDcGatewayRegionId input)
        {
            if (input == null) return false;
            if (this._GlobalDcGatewayRegionId != input._GlobalDcGatewayRegionId || (this._GlobalDcGatewayRegionId != null && !this._GlobalDcGatewayRegionId.Equals(input._GlobalDcGatewayRegionId))) return false;

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
                if (this._GlobalDcGatewayRegionId != null) hashCode = hashCode * 59 + this._GlobalDcGatewayRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
