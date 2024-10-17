using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HostRoute 
    {

        /// <summary>
        /// 路由目的子网
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 路由下一跳IP
        /// </summary>
        [JsonProperty("nexthop", NullValueHandling = NullValueHandling.Ignore)]
        public string Nexthop { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostRoute {\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  nexthop: ").Append(Nexthop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostRoute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostRoute input)
        {
            if (input == null) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Nexthop != input.Nexthop || (this.Nexthop != null && !this.Nexthop.Equals(input.Nexthop))) return false;

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
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Nexthop != null) hashCode = hashCode * 59 + this.Nexthop.GetHashCode();
                return hashCode;
            }
        }
    }
}
