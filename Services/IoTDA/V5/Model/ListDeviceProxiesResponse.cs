using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDeviceProxiesResponse : SdkResponse
    {

        /// <summary>
        /// 代理设备列表
        /// </summary>
        [JsonProperty("device_proxies", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryDeviceProxySimplify> DeviceProxies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDeviceProxiesResponse {\n");
            sb.Append("  deviceProxies: ").Append(DeviceProxies).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDeviceProxiesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDeviceProxiesResponse input)
        {
            if (input == null) return false;
            if (this.DeviceProxies != input.DeviceProxies || (this.DeviceProxies != null && input.DeviceProxies != null && !this.DeviceProxies.SequenceEqual(input.DeviceProxies))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;

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
                if (this.DeviceProxies != null) hashCode = hashCode * 59 + this.DeviceProxies.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                return hashCode;
            }
        }
    }
}
