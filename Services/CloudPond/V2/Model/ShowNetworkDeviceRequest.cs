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
    /// Request Object
    /// </summary>
    public class ShowNetworkDeviceRequest 
    {

        /// <summary>
        /// 网络设备ID
        /// </summary>
        [SDKProperty("network_device_id", IsPath = true)]
        [JsonProperty("network_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkDeviceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNetworkDeviceRequest {\n");
            sb.Append("  networkDeviceId: ").Append(NetworkDeviceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNetworkDeviceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNetworkDeviceRequest input)
        {
            if (input == null) return false;
            if (this.NetworkDeviceId != input.NetworkDeviceId || (this.NetworkDeviceId != null && !this.NetworkDeviceId.Equals(input.NetworkDeviceId))) return false;

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
                if (this.NetworkDeviceId != null) hashCode = hashCode * 59 + this.NetworkDeviceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
