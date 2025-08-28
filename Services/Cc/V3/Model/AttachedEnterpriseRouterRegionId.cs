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
    public class AttachedEnterpriseRouterRegionId 
    {

        /// <summary>
        /// ER路由器的regionID。
        /// </summary>
        [JsonProperty("attached_er_table_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachedEnterpriseRouterRegionId {\n");
            sb.Append("  attachedErTableRegionId: ").Append(AttachedErTableRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachedEnterpriseRouterRegionId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachedEnterpriseRouterRegionId input)
        {
            if (input == null) return false;
            if (this.AttachedErTableRegionId != input.AttachedErTableRegionId || (this.AttachedErTableRegionId != null && !this.AttachedErTableRegionId.Equals(input.AttachedErTableRegionId))) return false;

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
                if (this.AttachedErTableRegionId != null) hashCode = hashCode * 59 + this.AttachedErTableRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
