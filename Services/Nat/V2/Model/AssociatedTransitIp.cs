using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 关联的中转IP。
    /// </summary>
    public class AssociatedTransitIp 
    {

        /// <summary>
        /// 中转IP的ID。
        /// </summary>
        [JsonProperty("transit_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitIpId { get; set; }

        /// <summary>
        /// 中转IP地址。
        /// </summary>
        [JsonProperty("transit_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitIpAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatedTransitIp {\n");
            sb.Append("  transitIpId: ").Append(TransitIpId).Append("\n");
            sb.Append("  transitIpAddress: ").Append(TransitIpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatedTransitIp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociatedTransitIp input)
        {
            if (input == null) return false;
            if (this.TransitIpId != input.TransitIpId || (this.TransitIpId != null && !this.TransitIpId.Equals(input.TransitIpId))) return false;
            if (this.TransitIpAddress != input.TransitIpAddress || (this.TransitIpAddress != null && !this.TransitIpAddress.Equals(input.TransitIpAddress))) return false;

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
                if (this.TransitIpId != null) hashCode = hashCode * 59 + this.TransitIpId.GetHashCode();
                if (this.TransitIpAddress != null) hashCode = hashCode * 59 + this.TransitIpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
