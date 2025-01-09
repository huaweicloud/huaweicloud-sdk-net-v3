using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VirtualChannelOptions 
    {

        /// <summary>
        /// 自定义虚拟通道注册名。目前仅支持ASCII码字符。
        /// </summary>
        [JsonProperty("custom_virtual_channel_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomVirtualChannelName { get; set; }

        /// <summary>
        /// 虚拟通道下载配置信息，需Base64加密。加密前目前仅支持ASCII码字符。
        /// </summary>
        [JsonProperty("virtual_channel_plugin_details", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualChannelPluginDetails { get; set; }

        /// <summary>
        /// 第三方插件名称。
        /// </summary>
        [JsonProperty("third_party_plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdPartyPluginName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualChannelOptions {\n");
            sb.Append("  customVirtualChannelName: ").Append(CustomVirtualChannelName).Append("\n");
            sb.Append("  virtualChannelPluginDetails: ").Append(VirtualChannelPluginDetails).Append("\n");
            sb.Append("  thirdPartyPluginName: ").Append(ThirdPartyPluginName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VirtualChannelOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VirtualChannelOptions input)
        {
            if (input == null) return false;
            if (this.CustomVirtualChannelName != input.CustomVirtualChannelName || (this.CustomVirtualChannelName != null && !this.CustomVirtualChannelName.Equals(input.CustomVirtualChannelName))) return false;
            if (this.VirtualChannelPluginDetails != input.VirtualChannelPluginDetails || (this.VirtualChannelPluginDetails != null && !this.VirtualChannelPluginDetails.Equals(input.VirtualChannelPluginDetails))) return false;
            if (this.ThirdPartyPluginName != input.ThirdPartyPluginName || (this.ThirdPartyPluginName != null && !this.ThirdPartyPluginName.Equals(input.ThirdPartyPluginName))) return false;

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
                if (this.CustomVirtualChannelName != null) hashCode = hashCode * 59 + this.CustomVirtualChannelName.GetHashCode();
                if (this.VirtualChannelPluginDetails != null) hashCode = hashCode * 59 + this.VirtualChannelPluginDetails.GetHashCode();
                if (this.ThirdPartyPluginName != null) hashCode = hashCode * 59 + this.ThirdPartyPluginName.GetHashCode();
                return hashCode;
            }
        }
    }
}
