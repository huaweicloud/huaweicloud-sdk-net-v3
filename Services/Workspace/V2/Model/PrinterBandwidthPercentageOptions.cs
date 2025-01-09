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
    public class PrinterBandwidthPercentageOptions 
    {

        /// <summary>
        /// 打印机带宽百分比控制量（%）。取值范围为[0-100]。默认：5。
        /// </summary>
        [JsonProperty("printer_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrinterBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterBandwidthPercentageOptions {\n");
            sb.Append("  printerBandwidthPercentageValue: ").Append(PrinterBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrinterBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrinterBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.PrinterBandwidthPercentageValue != input.PrinterBandwidthPercentageValue || (this.PrinterBandwidthPercentageValue != null && !this.PrinterBandwidthPercentageValue.Equals(input.PrinterBandwidthPercentageValue))) return false;

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
                if (this.PrinterBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.PrinterBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
