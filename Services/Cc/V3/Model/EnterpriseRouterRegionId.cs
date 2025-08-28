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
    /// ER路由器的regionID。
    /// </summary>
    public class EnterpriseRouterRegionId 
    {

        /// <summary>
        /// ER路由器的regionID。
        /// </summary>
        [JsonProperty("enterprise_router_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _EnterpriseRouterRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseRouterRegionId {\n");
            sb.Append("  _enterpriseRouterRegionId: ").Append(_EnterpriseRouterRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseRouterRegionId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseRouterRegionId input)
        {
            if (input == null) return false;
            if (this._EnterpriseRouterRegionId != input._EnterpriseRouterRegionId || (this._EnterpriseRouterRegionId != null && !this._EnterpriseRouterRegionId.Equals(input._EnterpriseRouterRegionId))) return false;

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
                if (this._EnterpriseRouterRegionId != null) hashCode = hashCode * 59 + this._EnterpriseRouterRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
