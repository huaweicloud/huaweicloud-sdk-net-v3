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
    public class PrinterBandwidthControlOptions 
    {

        /// <summary>
        /// 打印机带宽控制量（Kbps）。取值范围为[1000-5000]。默认：2000。
        /// </summary>
        [JsonProperty("printer_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrinterBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterBandwidthControlOptions {\n");
            sb.Append("  printerBandwidthControlValue: ").Append(PrinterBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrinterBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrinterBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.PrinterBandwidthControlValue != input.PrinterBandwidthControlValue || (this.PrinterBandwidthControlValue != null && !this.PrinterBandwidthControlValue.Equals(input.PrinterBandwidthControlValue))) return false;

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
                if (this.PrinterBandwidthControlValue != null) hashCode = hashCode * 59 + this.PrinterBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
