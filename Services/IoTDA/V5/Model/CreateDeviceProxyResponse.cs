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
    public class CreateDeviceProxyResponse : SdkResponse
    {

        /// <summary>
        /// **参数说明**：代理ID。用来唯一标识一个代理规则
        /// </summary>
        [JsonProperty("proxy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyId { get; set; }

        /// <summary>
        /// **参数说明**：设备代理名称
        /// </summary>
        [JsonProperty("proxy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyName { get; set; }

        /// <summary>
        /// **参数说明**：代理设备组，组内所有设备共享网关权限，即组内任意一个网关下的子设备可以通过组里任意一个网关上线然后进行数据上报。
        /// </summary>
        [JsonProperty("proxy_devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProxyDevices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("effective_time_range", NullValueHandling = NullValueHandling.Ignore)]
        public EffectiveTimeRangeResponseDTO EffectiveTimeRange { get; set; }

        /// <summary>
        /// **参数说明**：资源空间ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDeviceProxyResponse {\n");
            sb.Append("  proxyId: ").Append(ProxyId).Append("\n");
            sb.Append("  proxyName: ").Append(ProxyName).Append("\n");
            sb.Append("  proxyDevices: ").Append(ProxyDevices).Append("\n");
            sb.Append("  effectiveTimeRange: ").Append(EffectiveTimeRange).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDeviceProxyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDeviceProxyResponse input)
        {
            if (input == null) return false;
            if (this.ProxyId != input.ProxyId || (this.ProxyId != null && !this.ProxyId.Equals(input.ProxyId))) return false;
            if (this.ProxyName != input.ProxyName || (this.ProxyName != null && !this.ProxyName.Equals(input.ProxyName))) return false;
            if (this.ProxyDevices != input.ProxyDevices || (this.ProxyDevices != null && input.ProxyDevices != null && !this.ProxyDevices.SequenceEqual(input.ProxyDevices))) return false;
            if (this.EffectiveTimeRange != input.EffectiveTimeRange || (this.EffectiveTimeRange != null && !this.EffectiveTimeRange.Equals(input.EffectiveTimeRange))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;

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
                if (this.ProxyId != null) hashCode = hashCode * 59 + this.ProxyId.GetHashCode();
                if (this.ProxyName != null) hashCode = hashCode * 59 + this.ProxyName.GetHashCode();
                if (this.ProxyDevices != null) hashCode = hashCode * 59 + this.ProxyDevices.GetHashCode();
                if (this.EffectiveTimeRange != null) hashCode = hashCode * 59 + this.EffectiveTimeRange.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
