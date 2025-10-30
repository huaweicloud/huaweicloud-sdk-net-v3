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
    public class ListNetworkDevicesResponse : SdkResponse
    {

        /// <summary>
        /// 网络设备列表
        /// </summary>
        [JsonProperty("network_devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetworkDevice> NetworkDevices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNetworkDevicesResponse {\n");
            sb.Append("  networkDevices: ").Append(NetworkDevices).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNetworkDevicesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNetworkDevicesResponse input)
        {
            if (input == null) return false;
            if (this.NetworkDevices != input.NetworkDevices || (this.NetworkDevices != null && input.NetworkDevices != null && !this.NetworkDevices.SequenceEqual(input.NetworkDevices))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.NetworkDevices != null) hashCode = hashCode * 59 + this.NetworkDevices.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
