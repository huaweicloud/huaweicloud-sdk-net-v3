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
    public class VirtualChannelBandwidthPercentageOptions 
    {

        /// <summary>
        /// 虚拟通道带宽百分比控制量（%）。取值范围为[0-100]。默认：65。
        /// </summary>
        [JsonProperty("virtual_channel_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualChannelBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualChannelBandwidthPercentageOptions {\n");
            sb.Append("  virtualChannelBandwidthPercentageValue: ").Append(VirtualChannelBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VirtualChannelBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VirtualChannelBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.VirtualChannelBandwidthPercentageValue != input.VirtualChannelBandwidthPercentageValue || (this.VirtualChannelBandwidthPercentageValue != null && !this.VirtualChannelBandwidthPercentageValue.Equals(input.VirtualChannelBandwidthPercentageValue))) return false;

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
                if (this.VirtualChannelBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.VirtualChannelBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
