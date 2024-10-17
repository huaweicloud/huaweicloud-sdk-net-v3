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
    /// 添加设备代理结构体。
    /// </summary>
    public class UpdateDeviceProxy 
    {

        /// <summary>
        /// **参数说明**：设备代理名称
        /// </summary>
        [JsonProperty("proxy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyName { get; set; }

        /// <summary>
        /// **参数说明**：代理设备列表，列表内所有设备共享网关权限，即列表内任意一个网关下的子设备可以通过组里任意一个网关上线然后进行数据上报。 **取值范围**：列表内填写设备id，列表内最少有2个设备id，最多有10个设备id，设备id取值范围：长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合，建议不少于4个字符。
        /// </summary>
        [JsonProperty("proxy_devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProxyDevices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("effective_time_range", NullValueHandling = NullValueHandling.Ignore)]
        public EffectiveTimeRange EffectiveTimeRange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDeviceProxy {\n");
            sb.Append("  proxyName: ").Append(ProxyName).Append("\n");
            sb.Append("  proxyDevices: ").Append(ProxyDevices).Append("\n");
            sb.Append("  effectiveTimeRange: ").Append(EffectiveTimeRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDeviceProxy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDeviceProxy input)
        {
            if (input == null) return false;
            if (this.ProxyName != input.ProxyName || (this.ProxyName != null && !this.ProxyName.Equals(input.ProxyName))) return false;
            if (this.ProxyDevices != input.ProxyDevices || (this.ProxyDevices != null && input.ProxyDevices != null && !this.ProxyDevices.SequenceEqual(input.ProxyDevices))) return false;
            if (this.EffectiveTimeRange != input.EffectiveTimeRange || (this.EffectiveTimeRange != null && !this.EffectiveTimeRange.Equals(input.EffectiveTimeRange))) return false;

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
                if (this.ProxyName != null) hashCode = hashCode * 59 + this.ProxyName.GetHashCode();
                if (this.ProxyDevices != null) hashCode = hashCode * 59 + this.ProxyDevices.GetHashCode();
                if (this.EffectiveTimeRange != null) hashCode = hashCode * 59 + this.EffectiveTimeRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
