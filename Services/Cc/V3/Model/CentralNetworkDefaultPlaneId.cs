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
    /// 中心网络默认平面的ID。
    /// </summary>
    public class CentralNetworkDefaultPlaneId 
    {

        /// <summary>
        /// 中心网络默认平面的ID。
        /// </summary>
        [JsonProperty("default_plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPlaneId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkDefaultPlaneId {\n");
            sb.Append("  defaultPlaneId: ").Append(DefaultPlaneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkDefaultPlaneId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkDefaultPlaneId input)
        {
            if (input == null) return false;
            if (this.DefaultPlaneId != input.DefaultPlaneId || (this.DefaultPlaneId != null && !this.DefaultPlaneId.Equals(input.DefaultPlaneId))) return false;

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
                if (this.DefaultPlaneId != null) hashCode = hashCode * 59 + this.DefaultPlaneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
