using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowNetworkDeviceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_device", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkDevice NetworkDevice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNetworkDeviceResponse {\n");
            sb.Append("  networkDevice: ").Append(NetworkDevice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNetworkDeviceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNetworkDeviceResponse input)
        {
            if (input == null) return false;
            if (this.NetworkDevice != input.NetworkDevice || (this.NetworkDevice != null && !this.NetworkDevice.Equals(input.NetworkDevice))) return false;

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
                if (this.NetworkDevice != null) hashCode = hashCode * 59 + this.NetworkDevice.GetHashCode();
                return hashCode;
            }
        }
    }
}
