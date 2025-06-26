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
    public class UsbBandwidthPercentageOptions 
    {

        /// <summary>
        /// USB带宽百分比控制量（%）。取值范围为[0-100]。默认：100。
        /// </summary>
        [JsonProperty("usb_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsbBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsbBandwidthPercentageOptions {\n");
            sb.Append("  usbBandwidthPercentageValue: ").Append(UsbBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UsbBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UsbBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.UsbBandwidthPercentageValue != input.UsbBandwidthPercentageValue || (this.UsbBandwidthPercentageValue != null && !this.UsbBandwidthPercentageValue.Equals(input.UsbBandwidthPercentageValue))) return false;

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
                if (this.UsbBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.UsbBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
