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
    /// Response Object
    /// </summary>
    public class ShowNetworkIpAvailabilitiesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_ip_availability", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkIpAvailability NetworkIpAvailability { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNetworkIpAvailabilitiesResponse {\n");
            sb.Append("  networkIpAvailability: ").Append(NetworkIpAvailability).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNetworkIpAvailabilitiesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNetworkIpAvailabilitiesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NetworkIpAvailability == input.NetworkIpAvailability ||
                    (this.NetworkIpAvailability != null &&
                    this.NetworkIpAvailability.Equals(input.NetworkIpAvailability))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.NetworkIpAvailability != null)
                    hashCode = hashCode * 59 + this.NetworkIpAvailability.GetHashCode();
                return hashCode;
            }
        }
    }
}
