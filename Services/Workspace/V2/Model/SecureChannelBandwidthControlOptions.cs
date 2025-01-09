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
    public class SecureChannelBandwidthControlOptions 
    {

        /// <summary>
        /// 安全通道带宽控制量（Kbps）。取值范围为[500-20000]。默认：10000。
        /// </summary>
        [JsonProperty("secure_channel_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecureChannelBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecureChannelBandwidthControlOptions {\n");
            sb.Append("  secureChannelBandwidthControlValue: ").Append(SecureChannelBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecureChannelBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecureChannelBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.SecureChannelBandwidthControlValue != input.SecureChannelBandwidthControlValue || (this.SecureChannelBandwidthControlValue != null && !this.SecureChannelBandwidthControlValue.Equals(input.SecureChannelBandwidthControlValue))) return false;

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
                if (this.SecureChannelBandwidthControlValue != null) hashCode = hashCode * 59 + this.SecureChannelBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
