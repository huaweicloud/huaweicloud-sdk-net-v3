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
    public class CentralNetworkConnectionPlaneId 
    {

        /// <summary>
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaneId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkConnectionPlaneId {\n");
            sb.Append("  planeId: ").Append(PlaneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkConnectionPlaneId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkConnectionPlaneId input)
        {
            if (input == null) return false;
            if (this.PlaneId != input.PlaneId || (this.PlaneId != null && !this.PlaneId.Equals(input.PlaneId))) return false;

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
                if (this.PlaneId != null) hashCode = hashCode * 59 + this.PlaneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
