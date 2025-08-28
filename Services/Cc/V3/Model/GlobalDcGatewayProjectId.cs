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
    /// Gdgw的项目ID。
    /// </summary>
    public class GlobalDcGatewayProjectId 
    {

        /// <summary>
        /// Gdgw的项目ID。
        /// </summary>
        [JsonProperty("global_dc_gateway_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _GlobalDcGatewayProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalDcGatewayProjectId {\n");
            sb.Append("  _globalDcGatewayProjectId: ").Append(_GlobalDcGatewayProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalDcGatewayProjectId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalDcGatewayProjectId input)
        {
            if (input == null) return false;
            if (this._GlobalDcGatewayProjectId != input._GlobalDcGatewayProjectId || (this._GlobalDcGatewayProjectId != null && !this._GlobalDcGatewayProjectId.Equals(input._GlobalDcGatewayProjectId))) return false;

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
                if (this._GlobalDcGatewayProjectId != null) hashCode = hashCode * 59 + this._GlobalDcGatewayProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
