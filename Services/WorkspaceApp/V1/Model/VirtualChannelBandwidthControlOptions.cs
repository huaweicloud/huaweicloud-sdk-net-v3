using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VirtualChannelBandwidthControlOptions 
    {

        /// <summary>
        /// 虚拟通道带宽控制量（Kbps）。取值范围为[500-20000]。默认：20000。
        /// </summary>
        [JsonProperty("virtual_channel_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualChannelBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualChannelBandwidthControlOptions {\n");
            sb.Append("  virtualChannelBandwidthControlValue: ").Append(VirtualChannelBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VirtualChannelBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VirtualChannelBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.VirtualChannelBandwidthControlValue != input.VirtualChannelBandwidthControlValue || (this.VirtualChannelBandwidthControlValue != null && !this.VirtualChannelBandwidthControlValue.Equals(input.VirtualChannelBandwidthControlValue))) return false;

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
                if (this.VirtualChannelBandwidthControlValue != null) hashCode = hashCode * 59 + this.VirtualChannelBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
