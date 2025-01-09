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
    public class VirtualChannel 
    {

        /// <summary>
        /// 是否开启虚拟通道策略设置。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("virtual_channel_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VirtualChannelControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualChannelOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualChannel {\n");
            sb.Append("  virtualChannelControlEnable: ").Append(VirtualChannelControlEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VirtualChannel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VirtualChannel input)
        {
            if (input == null) return false;
            if (this.VirtualChannelControlEnable != input.VirtualChannelControlEnable || (this.VirtualChannelControlEnable != null && !this.VirtualChannelControlEnable.Equals(input.VirtualChannelControlEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.VirtualChannelControlEnable != null) hashCode = hashCode * 59 + this.VirtualChannelControlEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
