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
    public class UsbBandwidthControlOptions 
    {

        /// <summary>
        /// USB带宽控制量（Kbps）。取值范围为[1000-30000]。默认：30000。
        /// </summary>
        [JsonProperty("usb_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsbBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsbBandwidthControlOptions {\n");
            sb.Append("  usbBandwidthControlValue: ").Append(UsbBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UsbBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UsbBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.UsbBandwidthControlValue != input.UsbBandwidthControlValue || (this.UsbBandwidthControlValue != null && !this.UsbBandwidthControlValue.Equals(input.UsbBandwidthControlValue))) return false;

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
                if (this.UsbBandwidthControlValue != null) hashCode = hashCode * 59 + this.UsbBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
