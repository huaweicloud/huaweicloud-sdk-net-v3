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
    /// 打印机重定向。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionPrinterRedirection 
    {

        /// <summary>
        /// 是否开启打印机设备重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("printer_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrinterEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDeviceRedirectionPrinterRedirectionOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionPrinterRedirection {\n");
            sb.Append("  printerEnable: ").Append(PrinterEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionPrinterRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionPrinterRedirection input)
        {
            if (input == null) return false;
            if (this.PrinterEnable != input.PrinterEnable || (this.PrinterEnable != null && !this.PrinterEnable.Equals(input.PrinterEnable))) return false;
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
                if (this.PrinterEnable != null) hashCode = hashCode * 59 + this.PrinterEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
